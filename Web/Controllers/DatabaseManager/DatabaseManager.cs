/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 6/22/2020 12:24:43 PM
  From Machine: DESKTOP-517I8BU
  Origin: SQL2XExtensionV3.SQL2XExtensionCreatorNorSolutionQueue.Content_DatabaseManagerDOTcs_DNF
  Documentation:
    Methods for creating the initial state of a database
     and manage scripts to upgrade database between versions
*/
using System;
using System.Collections.Generic;
using System.Configuration;
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

        /// <summary>
        /// Init Database Manager
        /// </summary>
        /// <param name="databaseName">Name of Database to delete</param>
        /// <param name="toRemote">Use remote or local database</param>
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

                // check if database exist
                if (!DatabaseExist(
                        connectionStringLocal: connectionString.Replace("Initial Catalog=NorSolutionPim;", ""),
                        databaseName: this.databaseName
                    )) {

                    DatabaseCreate(
                        connectionStringLocal: connectionString.Replace("Initial Catalog=NorSolutionPim;", ""),
                        databaseName: this.databaseName
                        );

                    Console.WriteLine($"Created database {this.databaseName}");
                }

                int minorNumber = 0;
                int sequence = 0;
                InitDatabaseClean(majorNumber: 0, minorNumber: minorNumber++);
                InitVersioning(majorNumber: 0, minorNumber: minorNumber++);
                InitJSONClient(majorNumber: 0, minorNumber: minorNumber++);
                InitSystemReferenceErrorAndIssue(majorNumber: 0, minorNumber: minorNumber++);
                InitDefaultUserActivity(majorNumber: 0, minorNumber: minorNumber++, sequence: out sequence);
                InitDefaultSystemSetting(majorNumber: 0, minorNumber: minorNumber++, sequence: ref sequence);
                InitDefaultChangeLog(majorNumber: 0, minorNumber: minorNumber++, sequence: ref sequence);
                InitDefaultRule(majorNumber: 0, minorNumber: minorNumber++, sequence: ref sequence);
                InitDefaultPerformanceIssue(majorNumber: 0, minorNumber: minorNumber++, sequence: ref sequence);
                InitFinancial(majorNumber: 0, minorNumber: minorNumber++);
                InitProduct(majorNumber: 0, minorNumber: minorNumber++);
                InitOAuth(majorNumber: 0, minorNumber: minorNumber++);
                InitIpsum(majorNumber: 0, minorNumber: minorNumber++);

                // creation checkmark, do not process scripts after this until creation is created
                scripts.Add(lastScript = new DatabaseScript {
                    DatabaseVersion = new DatabaseVersion { MajorNumber = 0, MinorNumber = minorNumber++, SequenceNumber = sequence++, DateTime = new DateTime(2019, 02, 05) },
                    ScriptNumber = this.scriptNumber++,
                    Name = "CreationCheckmark"
                });

                // intentionally left blank to serve as a template and to get the last version number
                maximumVersion = InitBlank(majorNumber: 0, minorNumber: minorNumber++);

            } catch (System.Exception ex) {
                throw new System.Exception(
                    "Failed to Initialize database manager",
                    ex
                    );
            }
        }

        public List<string> DatabaseCreate(
            string connectionStringLocal,
            string databaseName
            ) {

            string sql =
@"select 'Creating database: " + databaseName + @"'

create database " + databaseName + @"

select 'Created database: " + databaseName + @"'
";

            List<string> result =
                ExecuteWithResultInList(
                            connectionStringLocal: connectionStringLocal,
                            sql: sql
                        );

            foreach (string line in result) {
                // Log("SQL Execute Result: " + line);
            }

            return result;
        }

        /// <summary>
        /// Execute sql statements
        /// </summary>
        /// <param name="sql">Sql statement to execute</param>
        public static List<string> ExecuteWithResultInList (
            string connectionStringLocal,
            string sql
            ) {

            try {
                DataSet result = GetDataSet(connectionStringLocal, sql);

                List<string> resultList = new List<string>();

                foreach (DataTable table in result.Tables) {
                    foreach (DataRow row in table.Rows) {
                        resultList.Add(row[0].ToString());
                    }
                }

                return resultList;
            } catch (Exception ex) {
                throw new Exception("Failed when executing: \r\n" + sql, ex);
            }
        }

        /// <summary>
        /// Get dataset from sql statement
        /// </summary>
        /// <param name="sql">Sql statement to execute</param>
        /// <returns>Dataset from sql</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage ( "Microsoft.Security" , "CA2100:Review SQL queries for security vulnerabilities" )]
        public static DataSet GetDataSet ( string connectionString, string sql ) {
            try {
                var connection = new SqlConnection ( connectionString.Replace ( @"\\", @"\" ) );
                var command = new SqlCommand ( sql, connection );
                var adapter = new SqlDataAdapter ( command );
                var dataSet = new DataSet ( );
                adapter.Fill ( dataSet );

                return dataSet;
            } catch ( Exception ex ) {
                if ( ex.InnerException == null ) {
                    throw ( ex );
                } else {
                    throw ( ex.InnerException );
                }
            } finally {
            }
        }

        public bool DatabaseExist(
            string connectionStringLocal,
            string databaseName
            )
        {

            try {
                string sql =
@"select db_id('" + databaseName + @"')";

                List<string> result =
                    ExecuteWithResultInList(
                                connectionStringLocal: connectionStringLocal,
                                sql: sql
                            );

                int dbid;
                int.TryParse(result[0], out dbid);

                return dbid > 0;
            } catch (Exception ex) {
                // ErrorHandler.ErrorEx(serviceProvider, MethodBase.GetCurrentMethod(), "Failed to check if database exist", ex, rethrow: true);
            }

            return false;
        }
        /// <summary>
        /// Execute Next Script
        /// </summary>
        /// <returns>DateTime and comments from next script</returns>
        public string ExecuteNextScript() {
            try {
                DatabaseScript nextScript = NextScript();

                // execute next script
                string returnMessage = string.Empty;
                if (nextScript != null) {
                    returnMessage += DateTime.UtcNow + " " + "Script Executed" + " " + "( " + Execute(nextScript, haltOnException: true) + " )" + "\r\n";

                    if (IsVersionTableGood())   // make sure table exists
                        returnMessage += DateTime.UtcNow + " " + DefaultVersion(nextScript.DatabaseVersion) + "\r\n";

                } else {
                    returnMessage = DateTime.UtcNow + " " + "Database is up to date\r\n";
                }

                return returnMessage;
            } catch (Exception ex) {
                throw new Exception("Failed to upgrade database to next script", ex);
            }
        }

        /// <summary>
        /// Get Next Script from current version in database
        /// </summary>
        /// <returns>Next DatabaseScript Object</returns>
        public DatabaseScript NextScript() {
            try {
                // find current state
                string whyNot = string.Empty;
                if (!IsConnectionGood(out whyNot))
                    throw new Exception($"Connection not good; {SanitizePassword(this.connectionString)}\r\n    Because: {whyNot}");

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

        /// <summary>
        /// Get database connection timeout
        /// </summary>
        /// <returns>Timespan of timeout</returns>
        public TimeSpan ConectionTimeout() {
            try {
                using (var connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    return TimeSpan.FromSeconds(connection.ConnectionTimeout);
                }
            } catch (Exception ex) {
                if (ex != null) { }
                return TimeSpan.FromMinutes(-1);
            }
        }

        /// <summary>
        /// Check if connection is open
        /// </summary>
        /// <returns>True if open</returns>
        public bool IsConnectionGood(
                out string whyNot
            ) {
            try {
                using (var connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    connection.Close();
                }
            } catch (Exception ex) {
                if (ex != null) { }
                whyNot = ex.Message;
                return false;
            }

            whyNot = string.Empty;
            return true;
        }

        /// <summary>
        /// Check if SQL Server is responding by trying to switch database (probably a problem in Azure Sql Server)
        /// </summary>
        /// <returns>True if database is responding</returns>
        public bool IsDatabaseGood() {

            try {
                using (var connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    connection.ChangeDatabase(this.databaseName); // not sure about this one, could be some 'smart' handling preventing switching to current database
                }
            } catch (Exception ex) {
                if (ex != null) { }
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check is version table in database is present
        /// </summary>
        /// <returns>True if present</returns>
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
                if (ex != null) { }
                return false;
            }
        }

        /// <summary>
        /// Get last entry in version table
        /// </summary>
        /// <returns>Database Version object</returns>
        public DatabaseVersion VersionTableLastEntry() {
            try {
                string sql =
                    @" select top 1 default_version_id, fun_version, number, major_number, minor_number, sequence_number, date_time
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

        /// <summary>
        /// Get connection string without sensitive info
        /// </summary>
        /// <returns>Connection string</returns>
        public string ConnectionStringSanitized {
            get {
                return SanitizePassword(connectionString);
            }
        }

        /// <summary>
        /// Remove password from string
        /// </summary>
        /// <param name="stringToSanitize">String to sanitize</param>
        /// <returns>String without password</returns>
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

        /// <summary>
        /// Execute all scripts between to versions
        /// </summary>
        /// <param name="databaseVersionEqualToOrGreaterThan">DatabaseVersion object with version to start from</param>
        /// <param name="databaseVersionEqualToOrLessThan">DatabaseVersion object with version to go to</param>
        /// <returns>SQL Server comments from executing the scripts</returns>
        public string ExecuteScriptsBetween(
            DatabaseVersion databaseVersionEqualToOrGreaterThan,
            DatabaseVersion databaseVersionEqualToOrLessThan,
            bool breakOnCreationCheckmark
            ) {
            try {
                // find current state
                string whyNot = string.Empty;
                if (!IsConnectionGood(out whyNot))
                    throw new Exception($"Connection not good; {SanitizePassword(this.connectionString)}\r\n    Because: {whyNot}");

                if (!IsDatabaseGood())
                    return "Database is not good; " + this.databaseName + " on connection; " + SanitizePassword(this.connectionString);

                // get version
                DatabaseVersion databaseVersion = new DatabaseVersion();

                string returnMessage = string.Empty;
                if (!IsVersionTableGood())
                    returnMessage += "Version table is not good on connection; " + SanitizePassword(this.connectionString) + "\r\n";
                else {
                    try {
                        databaseVersion = VersionTableLastEntry();
                    } catch (Exception ex) {
                        if (ex != null) { }
                    }
                }

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

                        if (script.Name.Equals("CreationCheckmark") && breakOnCreationCheckmark)
                            break;

                        if (script.Name.Equals("CreationCheckmark"))
                            continue;   // do not execute this script

                        returnMessage += DateTime.UtcNow;
                        //returnMessage += "Script Executed" + " " + "( " + script.Name + " )" + "\r\n";
                        returnMessage += "Script Executed" + " " + "( " + Execute(script) + " )" + "\r\n";

                        try {
                            if (IsVersionTableGood())   // make sure table exists
                                returnMessage += DefaultVersion(script.DatabaseVersion) + "\r\n";
                        } catch (Exception ex) {
                            if (ex != null) { }
                        }

                    }

                    return returnMessage;
                } else {
                    return "Code version is less than the database version";
                }
            } catch (Exception ex) {
                throw new Exception("Failed to upgrade database to latest version", ex);
            }
        }

        /// <summary>
        /// Place holder for new script
        /// </summary>
        /// <param name="majorNumber">Major number for version</param>
        /// <param name="minorNumber">Minor number for version</param>
        /// <returns>Database Version script</returns>
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

        /// <summary>
        /// Execute a number of scripts
        /// </summary>
        /// <param name="scriptList">List of scripts to execute</param>
        /// <returns>Comments from scripts</returns>
        public string Version(
            List<string> scriptList
            ) {
            string reply = string.Empty;

            foreach (string scriptName in scriptList)
                reply += "Script Executed" + " " + "( " + Execute(scripts.Find(x => x.Name.Equals(scriptName))) + " )";

            return reply;
        }

        /// <summary>
        /// Execute a script
        /// </summary>
        /// <param name="databaseScript">Database Script to execute</param>
        /// <param name="haltOnException">Halt if exception is caught</param>
        /// <returns>Comments from scripts</returns>
        public string Execute(
            DatabaseScript databaseScript,
            bool haltOnException = false
            ) {

            if (databaseScript.Name.Equals("CreationCheckmark"))
                return string.Empty;   // do not execute this script

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

        /// <summary>
        /// Extract Exception information as string
        /// </summary>
        /// <returns>String with error information</returns>
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

        /// <summary>
        /// Execute a script
        /// </summary>
        /// <param name="sql">Database Script to execute</param>
        /// <param name="breakUpToBatches">Break scripts up on 'go'</param>
        /// <returns>True if executed without errors</returns>
        bool Execute(
            string sql,
            bool breakUpToBatches = true
            ) {
            //breakUpToBatches = false;
            if (breakUpToBatches) {
                string[] batches = sql.Split(new string[] { "go\r\n" }, StringSplitOptions.None);

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
