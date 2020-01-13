using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    public class DatabaseScriptBatch {
        public string Script { get; set; }
        public bool BreakUpToBatches { get; set; }
    }

    public class DatabaseScript {
        public DatabaseVersion DatabaseVersion { get; set; }
        public int ScriptNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DatabaseScriptBatch DatabaseScriptBatch { get; set; }
        public DateTime DateTime { get; set; }
    }

    public partial class DatabaseManager {
        public List<DatabaseScript> scripts = new List<DatabaseScript>();
        DatabaseScript lastScript = new DatabaseScript();
        String databaseName = string.Empty;
        public String connectionString = string.Empty;
        Int32 scriptNumber = 1;
        bool toRemote;
        public DatabaseVersion minimumVersion = new DatabaseVersion();
        public DatabaseVersion defaultVersion;
        public DatabaseVersion maximumVersion;

        public DatabaseManager(
            String databaseName,
            bool toRemote
            ) {

            if (string.IsNullOrEmpty(databaseName))
                throw new ArgumentException("Missing Database Name", "databaseName");

            try {
                this.databaseName = databaseName;

                // remote or local
                this.toRemote = toRemote;
                if (this.toRemote)
                    connectionString = Conn.ConnectionStringRemote;
                else
                    connectionString = Conn.ConnectionStringLocal;

                int minorNumber = 0;
                InitDatabaseClean(majorNumber: 0, minorNumber: minorNumber++);
                InitVersioning(majorNumber: 0, minorNumber: minorNumber++);
                InitJSONClient(majorNumber: 0, minorNumber: minorNumber++);
                InitSystemReferenceErrorAndIssue(majorNumber: 0, minorNumber: minorNumber++);
                InitDefaultUserActivity(majorNumber: 0, minorNumber: minorNumber++, sequence: out int sequence);
                InitDefaultSystemSetting(majorNumber: 0, minorNumber: minorNumber++, sequence: ref sequence);
                InitDefaultChangeLog(majorNumber: 0, minorNumber: minorNumber++, sequence: ref sequence);
                InitDefaultRule(majorNumber: 0, minorNumber: minorNumber++, sequence: ref sequence);
                InitDefaultPerformanceIssue(majorNumber: 0, minorNumber: minorNumber++, sequence: ref sequence);
                InitLocation(majorNumber: 0, minorNumber: minorNumber++);
                InitFinancial(majorNumber: 0, minorNumber: minorNumber++);
                InitProduct(majorNumber: 0, minorNumber: minorNumber++);
                InitOAuth(majorNumber: 0, minorNumber: minorNumber++);
                InitEFO(majorNumber: 0, minorNumber: minorNumber++);

                // intentionally left blank to serve as a template and to get the last version number
                maximumVersion = InitBlank(majorNumber: 0, minorNumber: minorNumber++);

            } catch (System.Exception ex) {
                throw new System.Exception(
                    "Failed to Initialize database manager",
                    ex
                    );
            }
        }

        public string ExecuteNextScript() {
            try {
                DatabaseScript nextScript = NextScript();

                // execute next script
                string returnMessage = string.Empty;
                returnMessage += DateTime.UtcNow + " " + "Script Executed" + " " + "( " + Execute(nextScript, haltOnException: true) + " )" + "\r\n";

                if (IsVersionTableGood())   // make sure table exists
                    returnMessage += DateTime.UtcNow + " " + DefaultVersion(nextScript.DatabaseVersion) + "\r\n";

                return returnMessage;
            } catch (Exception ex) {
                throw new Exception("Failed to upgrade database to next script", ex);
            }
        }

        public DatabaseScript NextScript() {
            try {
                // find current state
                if (!IsConnectionGood())
                    throw new Exception("Connection not good; " + SanitizePassword(this.connectionString));

                if (!IsDatabaseGood())
                    throw new Exception("Database is not good; " + this.databaseName + " on connection; " + SanitizePassword(this.connectionString));

                // get version
                DatabaseVersion databaseVersion = new DatabaseVersion();

                string returnMessage = string.Empty;
                if (!IsVersionTableGood())
                    throw new Exception("Version table is not good on connection; " + SanitizePassword(this.connectionString));

                databaseVersion = VersionTableLastEntry();

                // is code version and database version the same?
                if (maximumVersion == databaseVersion)
                    return null;

                if (maximumVersion < databaseVersion) 
                    throw new Exception("Maxmimum version is less than the database version" + "\r\n");

                // filter out scripts to execute
                List<DatabaseScript> scriptsFiltered =
                    scripts
                        .Where(s =>
                                    s.DatabaseVersion > databaseVersion
                                && s.DatabaseVersion <= maximumVersion)
                        .ToList();

                if (scriptsFiltered.Count == 0) {
                    return null;
                }

                // find next script
                List<DatabaseScript> scriptOrdered =
                    scriptsFiltered
                        .OrderBy(o => o.DatabaseVersion.MajorNumber)
                        .ThenBy(o2 => o2.DatabaseVersion.MinorNumber)
                        .ThenBy(o3 => o3.DatabaseVersion.SequenceNumber)
                        .ToList();

                DatabaseScript nextScript = scriptOrdered.FirstOrDefault(); // https://codereview.stackexchange.com/questions/55340/update-first-and-last-item-in-listt

                return nextScript;
            } catch (Exception ex) {
                throw new Exception("Failed to get next script", ex);
            }
        }

        public TimeSpan ConectionTimeout() {
            try {
                using (var connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    return TimeSpan.FromSeconds(connection.ConnectionTimeout);
                }
            } catch (Exception) {
                return TimeSpan.FromMinutes(-1);
            }
        }

        public bool IsConnectionGood() {
            try {
                using (var connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    connection.Close();
                }
            } catch (Exception) {
                return false;
            }

            return true;

            //  does version table exist
            //  which version
        }

        public bool IsDatabaseGood() {

            try {
                using (var connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    connection.ChangeDatabase(this.databaseName); // not sure about this one, could be some 'smart' handling preventing switching to current database
                }
            } catch (Exception) {
                return false;
            }

            return true;
        }

        public bool IsVersionTableGood() {
            try {
                string sql = "select * from default_version";
                using (var connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    using (var command = new SqlCommand(sql, connection)) {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected >= -1; // which means the table is there, but might not contain any entries
                    }
                }
            } catch (Exception ex) {
                return false;
            }
        }

        public DatabaseVersion VersionTableLastEntry() {
            try {
                string sql =
                    @" select top 1 default_version_id, fun_version, number, major_number, minor_number, sequence_number, default_user_id, date_time
                       from default_version
                       order by date_time desc
                        ";

                using (var conn = new SqlConnection(this.connectionString)) {
                    conn.Open();    // open standard connection
                    conn.BeginTransaction(IsolationLevel.ReadCommitted).Commit();   // committed read

                    // execute and read one row, close connection
                    using (var command = new SqlCommand(sql, conn)) {
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                        // populate serializable class if row was found
                        DatabaseVersion databaseVersion = new DatabaseVersion();
                        if (reader.Read()) {
                            if (reader["major_number"] != System.DBNull.Value)
                                databaseVersion.MajorNumber = (System.Int32)reader["major_number"];

                            if (reader["minor_number"] != System.DBNull.Value)
                                databaseVersion.MinorNumber = (System.Int32)reader["minor_number"];

                            if (reader["sequence_number"] != System.DBNull.Value)
                                databaseVersion.SequenceNumber = (System.Int32)reader["sequence_number"];

                            if (reader["date_time"] != System.DBNull.Value)
                                databaseVersion.DateTime = (System.DateTime)reader["date_time"];
                        }

                        return databaseVersion;
                    }
                }
            } catch (System.Exception ex) {
                throw new System.Exception(
                    "Failed to fetch last default version" + " on Connection; " + SanitizePassword(this.connectionString),
                    ex
                    );
            }

            throw new System.Exception(
                "Failed to fetch last default version" + " on Connection; " + SanitizePassword(this.connectionString)
                );
        }

        public string ConnectionStringSanitized {
            get {
                return SanitizePassword(connectionString);
            }
        }

        public string SanitizePassword(
            string stringToSanitize
            ) {
            try {
                int passwordPos = stringToSanitize.IndexOf("Password=");
                if (passwordPos == -1)
                    return stringToSanitize;

                int afterPasswordPos = stringToSanitize.Substring(startIndex: passwordPos).IndexOf(";");

                return stringToSanitize.Substring(startIndex: 0, length: passwordPos) + "Password=XXX" + stringToSanitize.Substring(startIndex: passwordPos + afterPasswordPos);

            } catch (Exception ex) {
                return "Failed to sanitize password; " + ex.Message;
            }
        }

        public string ExecuteScriptsBetween(
            DatabaseVersion databaseVersionEqualToOrGreaterThan,
            DatabaseVersion databaseVersionEqualToOrLessThan
            ) {
            try {
                // find current state
                if (!IsConnectionGood())
                    return "Connection not good; " + SanitizePassword(this.connectionString);

                if (!IsDatabaseGood())
                    return "Database is not good; " + this.databaseName + " on connection; " + SanitizePassword(this.connectionString);

                // get version
                DatabaseVersion databaseVersion = new DatabaseVersion();

                string returnMessage = string.Empty;
                if (!IsVersionTableGood())
                    returnMessage += "Version table is not good on connection; " + SanitizePassword(this.connectionString) + "\r\n";
                else
                    databaseVersion = VersionTableLastEntry();

                if (maximumVersion == databaseVersion)
                    returnMessage += "Code version and database version is the same" + "\r\n";

                if (maximumVersion > databaseVersion) {
                    returnMessage += "Code version is greater than the database version" + "\r\n";

                    // https://stackoverflow.com/questions/26196/filtering-collections-in-c-sharp
                    // https://stackoverflow.com/questions/1414893/linq-to-sql-value-between-two-double-values
                    List<DatabaseScript> scriptsFiltered =
                        scripts
                            .Where(s => 
                                       s.DatabaseVersion >= databaseVersionEqualToOrGreaterThan
                                    && s.DatabaseVersion <= databaseVersionEqualToOrLessThan)
                            .ToList();

                    // start message with time, script info
                    // exception message with time, script info, error info
                    // end message with time, script info
                    // no overall run page..
                    List<DatabaseScript> scriptOrdered =
                        scriptsFiltered
                            .OrderBy(o => o.DatabaseVersion.MajorNumber)
                            .ThenBy(o2 => o2.DatabaseVersion.MinorNumber)
                            .ThenBy(o3 => o3.DatabaseVersion.SequenceNumber)
                            .ToList();

                    foreach (DatabaseScript script in scriptOrdered) {
                        returnMessage += DateTime.UtcNow;
                        //returnMessage += "Script Executed" + " " + "( " + script.Name + " )" + "\r\n";
                        returnMessage += "Script Executed" + " " + "( " + Execute(script) + " )" + "\r\n";

                        if (IsVersionTableGood())   // make sure table exists
                            returnMessage += DefaultVersion(script.DatabaseVersion) + "\r\n";
                    }

                    return returnMessage;
                } else {
                    return "Code version is less than the database version";
                }
            } catch (Exception ex) {
                throw new Exception("Failed to upgrade database to latest version", ex);
            }
        }

        DatabaseVersion InitBlank(
            int majorNumber,
            int minorNumber
            ) {
            DatabaseVersion databaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = 0, DateTime = new DateTime(2018, 03, 10) };

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = databaseVersion.SequenceIncrease,
                ScriptNumber = this.scriptNumber++,
                Name = "",
                Description = "",
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                        ",
                    BreakUpToBatches = true
                }
            });

            return databaseVersion;
        }

        public string Version(List<string> scriptList) {
            string reply = string.Empty;

            foreach (string scriptName in scriptList)
                reply += "Script Executed" + " " + "( " + Execute(scripts.Find(x => x.Name.Equals(scriptName))) + " )";

            return reply;
        }

        public string Execute(
            DatabaseScript databaseScript,
            bool haltOnException = false
            ) {

            try {
                if (!Execute(
                    databaseScript.DatabaseScriptBatch.Script,
                    databaseScript.DatabaseScriptBatch.BreakUpToBatches
                    ))

                    return "Failed";

            } catch (System.Exception ex) {
                if (haltOnException)
                    throw new Exception("Failed to execute script; " + databaseScript.Name, ex);

                if (ex.HResult == -2147467261)
                    return "Exception; No database script to execute";
                else
                    return
                          "Script Name: " + databaseScript.Name + "\r\n" + "\r\n"
                        + "Exception: " + ExtractException(ex);
            }

            return databaseScript.Description;
        }

        private string ExtractException(Exception ex) {
            try {
                return (ex?.Message + "\r\n" + "\r\n"
                + ex.InnerException?.Message + "\r\n" + "\r\n"
                + ex.InnerException?.InnerException?.Message + "\r\n" + "\r\n"
                + ex.InnerException?.InnerException?.InnerException?.Message + "\r\n" + "\r\n"
                + ex.InnerException?.InnerException?.InnerException?.InnerException?.Message + "\r\n" + "\r\n"
                );

            } catch (Exception ex2) {
                return "Failed to extract exception;" + ex2.Message;
            }
        }

        bool Execute(
            string sql,
            bool breakUpToBatches = true
            ) {

            if (breakUpToBatches) {
                string[] batches = sql.Split("go\r\n");

                try {
                    using (var connection = new SqlConnection(connectionString)) {
                        connection.Open();

                        // execute script in batches
                        string batchPart = string.Empty;
                        foreach (string batchLine in batches) {
                            try {
                                batchPart = batchLine.Trim();
                                if (!string.IsNullOrEmpty(batchPart)) {
                                    using (var command = new SqlCommand(batchPart, connection)) {
                                        command.CommandTimeout = 60 * 5;    // https://stackoverflow.com/questions/8602395/timeout-expired-the-timeout-period-elapsed-prior-to-completion-of-the-operation
                                        command.ExecuteNonQuery();
                                    }
                                }
                            } catch (System.Exception ex) {
                                throw new System.Exception(
                                    "On Connection; " + SanitizePassword(this.connectionString) + "\r\n"
                                    + "Failed to execute (batch inner): " + batchPart + "\r\n" + "\r\n" + ex.Message,
                                    ex
                                    );
                            }
                        }
                    }

                    return true;
                } catch (System.Exception ex) {
                    throw new System.Exception(
                        "On Connection; " + SanitizePassword(this.connectionString) + "\r\n"
                        + "Failed to execute (batch outer): " + sql + "\r\n" + "\r\n" 
                        + ex.Message,
                        ex
                        );
                }
            } else {
                sql = sql.Replace("go\r\n", string.Empty);
                try {
                    // open standard connection
                    using (var connection = new SqlConnection(connectionString)) {
                        connection.Open();

                        // execute script
                        using (var command = new SqlCommand(sql, connection)) {
                            command.CommandTimeout = 60 * 5;    // https://stackoverflow.com/questions/8602395/timeout-expired-the-timeout-period-elapsed-prior-to-completion-of-the-operation
                            command.ExecuteNonQuery();
                        }
                    }
                    return true;
                } catch (System.Exception ex) {
                    throw new System.Exception(
                        "On Connection; " + SanitizePassword(this.connectionString) + "\r\n"
                        + "Failed to execute (nobatch): " + sql,
                        ex
                        );
                }
            }
        }
    }
}
