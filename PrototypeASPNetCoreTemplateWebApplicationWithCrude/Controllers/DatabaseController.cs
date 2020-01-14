/*  database management for norClient   */
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;
//using Microsoft.Azure.Management.Resources;
//using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Rest;
using Microsoft.Rest.Azure.Authentication;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SolutionNorSolutionPim.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/database")]
    public class DatabaseController : Controller {
        public List<string> DatabaseDelete(
            string databaseName
            ) {

            string sql =
@"select 'Dropping database: " + databaseName + @", db_id=' + cast(db_id('" + databaseName + @"') as varchar(10))

if ( db_id('" + databaseName + @"') is not null) begin
    drop database " + databaseName + @"

    select 'Database " + databaseName + @" dropped'
end
";

            List<string> result =
                ExecuteWithResultInList(
                            connectionString: Conn.ConnectionStringNoInitialCatalog,
                            sql: sql
                        );

            foreach (string line in result) {
                //Log("SQL Execute Result: " + line);
            }

            return result;
        }

        public List<string> DatabaseCreate(
            string databaseName
            ) {

            string sql =
@"select 'Creating database: " + databaseName + @"'

create database " + databaseName + @"

select 'Created database: " + databaseName + @"'
";

            List<string> result =
                ExecuteWithResultInList(
                            connectionString: Conn.ConnectionStringNoInitialCatalog,
                            sql: sql
                        );

            foreach (string line in result) {
                //Log("SQL Execute Result: " + line);
            }

            return result;
        }

        /// <summary>
        /// Get dataset from sql statement
        /// </summary>
        /// <param name="sql">Sql statement to execute</param>
        /// <returns>Dataset from sql</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public static DataSet GetDataSet(string connectionString, string sql) {
            try {
                var connection = new SqlConnection(connectionString.Replace(@"\\", @"\"));
                var command = new SqlCommand(sql, connection);
                var adapter = new SqlDataAdapter(command);
                var dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            } catch (Exception ex) {
                if (ex.InnerException == null) {
                    throw (ex);
                } else {
                    throw (ex.InnerException);
                }
            } finally {
            }
        }

        /// <summary>
        /// Execute sql statements
        /// </summary>
        /// <param name="sql">Sql statement to execute</param>
        public static List<string> ExecuteWithResultInList(
            string connectionString,
            string sql
            ) {
            try {
                DataSet result = GetDataSet(connectionString, sql);

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

        private static SqlManagementClient AzureSqlClient() {
            SqlManagementClient sqlClient;
            try {
                var clientId = "";        // Principal Id | Application ID | Client ID
                var secret = "";
                var tenantId = "";        // Environment.GetEnvironmentVariable("AZURE_TENANT_ID");
                var subscriptionId = "";  // Environment.GetEnvironmentVariable("AZURE_SUBSCRIPTION_ID");

                ServiceClientCredentials serviceCreds = Task.Run(() => ApplicationTokenProvider.LoginSilentAsync(domain: tenantId, clientId: clientId, secret: secret)).Result;

                sqlClient = new SqlManagementClient(serviceCreds);
                sqlClient.SubscriptionId = subscriptionId;
            } catch (Exception ex) {
                throw new Exception(message: "failed to get Azure Service Principal");
            }
            return sqlClient;
        }

        [HttpGet("CreateDatabase")]
        public IActionResult CreateDatabase() {

            if (IsLocal) {
                DatabaseCreate("NorSolutionPim");
            } else {
                SqlManagementClient sqlClient = AzureSqlClient();

                var newDb = new Microsoft.Azure.Management.Sql.Models.Database {
                    Location = "East US 2",
                    LicenseType = "BasePrice",
                    Sku = new Sku(name: "Basic")
                };

                sqlClient.Databases.CreateOrUpdate(
                    resourceGroupName: "Default-SQL-EastUS2",
                    serverName: "azureSQLServerName",
                    databaseName: "NorSolutionPim",
                    parameters: newDb
                    );
            }

            return View();
        }

        [HttpGet("RemoveDatabase")]
        public IActionResult RemoveDatabase() {
            if (IsLocal) {
                DatabaseDelete("NorSolutionPim");
            } else {
                SqlManagementClient sqlClient = AzureSqlClient();

                var newDb = new Microsoft.Azure.Management.Sql.Models.Database {
                    Location = "East US 2"
                };

                sqlClient.Databases.Delete(
                    resourceGroupName: "Default-SQL-EastUS2",
                    serverName: "azureSQLServerName",
                    databaseName: "NorSolutionPim"
                    );
            }

            return View();
        }

        private bool IsLocal { get { return this.Request.Host.ToString().IndexOf("localhost") != -1; } }

        [HttpGet("CopyConnectionStringToClipboard")]
        public IActionResult CopyConnectionStringToClipboard() {
            return View();
        }

        [HttpGet("getversionobject")]
        public DatabaseVersion GetVersionObject() {
            string returnMessage = string.Empty;

            DatabaseVersion databaseVersion = new DatabaseVersion();

            try {
                string sql =
                    @"
                    select 
            	            top 1
            	         dv.major_number
            	        ,dv.minor_number
            	        ,dv.sequence_number
            	        ,dv.date_time 
                    from default_version as dv
                    order by dv.date_time desc
                    ";

                using (var conn = new SqlConnection(Conn.ConnectionString)) {
                    conn.Open();

                    using (var command = new SqlCommand(sql, conn)) {
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                        if (reader.Read()) {
                            databaseVersion.MajorNumber = (int)reader["major_number"];
                            databaseVersion.MinorNumber = (int)reader["minor_number"];
                            databaseVersion.SequenceNumber = (int)reader["sequence_number"];
                            databaseVersion.DateTime = (DateTime)reader["date_time"];
                        }

                        reader.Close();
                    }
                }
            } catch (System.Exception ex) {
                returnMessage = ExtractException(ex).Replace("\r\n", "<br>");
            }

            return databaseVersion;
        }

        private string ExtractException ( Exception ex ) {
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

        [HttpGet("getversion")]
        public ContentResult GetVersion() {
            string returnMessage = string.Empty;

            try {
                string sql =
                    @"
                    select 
            	            top 1
            	         dv.major_number
            	        ,dv.minor_number
            	        ,dv.sequence_number
            	        ,dv.date_time 
                    from default_version as dv
                    order by dv.date_time desc
                    ";

                using (var conn = new SqlConnection(Conn.ConnectionString)) {
                    conn.Open();

                    using (var command = new SqlCommand(sql, conn)) {
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                        if (reader.Read()) {
                            returnMessage += reader["major_number"];
                            returnMessage += ".";
                            returnMessage += reader["minor_number"];
                            returnMessage += ".";
                            returnMessage += reader["sequence_number"];
                            returnMessage += "\r\n";
                            returnMessage += reader["date_time"];
                        } else {
                            returnMessage += "No Data\r\n";
                        }

                        reader.Close();
                    }
                }
            } catch (System.Exception ex) {
                returnMessage = ExtractException(ex).Replace("\r\n", "<br>");
            }

            return new ContentResult() { Content = returnMessage.Replace("\r\n", "<br>"), ContentType = "text/html" };
        }

        [HttpGet("SetVersionZero")]
        public IActionResult SetVersionZero() {
            string returnMessage = string.Empty;

            try {
                DatabaseManager databaseManager =
                    new DatabaseManager(
                        databaseName: "NorSolutionPim",
                        toRemote: true  // always remote here
                        );

                returnMessage += "Connection" + "\r\n";

                returnMessage +=
                    "    "
                    + databaseManager.ConnectionStringSanitized
                    .Replace("=", " = ")
                    .Replace(";", "\r\n    ");

                returnMessage += "" + "\r\n";
                returnMessage += "" + "\r\n";

                if (databaseManager.IsConnectionGood())
                    returnMessage += DateTime.UtcNow + " " + "Connection is good" + "\r\n";

                if (databaseManager.IsDatabaseGood())
                    returnMessage += DateTime.UtcNow + " " + "Database is good" + "\r\n";

                if (databaseManager.IsVersionTableGood())
                    returnMessage += DateTime.UtcNow + " " + "Version table is good" + "\r\n";

                // set version zero
                try {
                    returnMessage += DateTime.UtcNow + " " + databaseManager.DefaultVersion(new DatabaseVersion());
                } catch (Exception ex) {
                    returnMessage += DateTime.UtcNow + " " + ex.Message;
                }

                // get version 
                DatabaseVersion databaseVersion = databaseManager.minimumVersion;
                try {
                    databaseVersion = databaseManager.VersionTableLastEntry();
                } catch (Exception ex) {
                    returnMessage += DateTime.UtcNow + " " + ex.Message;
                }

                // if database version is minimum version then run to where default version table is created
                if (databaseVersion == databaseManager.minimumVersion) {
                    returnMessage =
                        databaseManager.ExecuteScriptsBetween(
                            databaseManager.minimumVersion,
                            databaseManager.defaultVersion
                            );
                }

                returnMessage += DateTime.UtcNow + " " + "Database Version is; " + databaseVersion.ToString() + "\r\n";
                returnMessage += DateTime.UtcNow + " " + "Code Version is; " + databaseManager.maximumVersion.ToString() + "\r\n";

            } catch (System.Exception ex) {
                returnMessage = ExtractException(ex);
            }

            ViewData["Message"] = returnMessage;

            return View();
        }

        [HttpGet("increaseversion")]
        public IActionResult IncreaseVersion() {
            string returnMessage = string.Empty;

            try {
                DatabaseManager databaseManager =
                    new DatabaseManager(
                        databaseName: "NorSolutionPim",
                        toRemote: true  // always remote here
                        );

                returnMessage += "Connection" + "\r\n";

                returnMessage += 
                    "    " 
                    + databaseManager.ConnectionStringSanitized
                    .Replace("=", " = ")
                    .Replace(";", "\r\n    ");

                returnMessage += "" + "\r\n";
                returnMessage += "" + "\r\n";

                if (databaseManager.IsConnectionGood())
                    returnMessage += DateTime.UtcNow + " " + "Connection is good" + "\r\n";

                if (databaseManager.IsDatabaseGood())
                    returnMessage += DateTime.UtcNow + " " + "Database is good" + "\r\n";

                if (databaseManager.IsVersionTableGood())
                    returnMessage += DateTime.UtcNow + " " + "Version table is good" + "\r\n";

                DatabaseVersion databaseVersion = databaseManager.minimumVersion;
                try {
                    databaseVersion = databaseManager.VersionTableLastEntry();
                } catch (Exception ex) {
                    returnMessage += DateTime.UtcNow + " " + ex.Message;
                }

                returnMessage += DateTime.UtcNow + " " + "Database Version is; " + databaseVersion.ToString() + "\r\n";
                returnMessage += DateTime.UtcNow + " " + "Code Version is; " + databaseManager.maximumVersion.ToString() + "\r\n";

                returnMessage += DateTime.UtcNow + " " + "Start Script" + "\r\n";

                // execute next script
                returnMessage += databaseManager.ExecuteNextScript();

                returnMessage += DateTime.UtcNow + " " + "End Script" + "\r\n";

            } catch (System.Exception ex) {
                returnMessage = ExtractException(ex);
            }

            ViewData["Message"] = returnMessage;

            return View();
        }

        [HttpGet("increaseversiontolatest")]
        public IActionResult IncreaseVersionToLatest() {
            string returnMessage = string.Empty;

            try {
                DatabaseManager databaseManager =
                    new DatabaseManager(
                        databaseName: "NorSolutionPim",
                        toRemote: true  // always remote here
                        );

                returnMessage += "Connection" + "\r\n";

                returnMessage +=
                    "    "
                    + databaseManager.ConnectionStringSanitized
                    .Replace("=", " = ")
                    .Replace(";", "\r\n    ");

                returnMessage += "" + "\r\n";
                returnMessage += "" + "\r\n";

                if (databaseManager.IsConnectionGood())
                    returnMessage += DateTime.UtcNow + " " + "Connection is good" + "\r\n";

                if (databaseManager.IsDatabaseGood())
                    returnMessage += DateTime.UtcNow + " " + "Database is good" + "\r\n";

                if (databaseManager.IsVersionTableGood())
                    returnMessage += DateTime.UtcNow + " " + "Version table is good" + "\r\n";

                DatabaseVersion databaseVersion = databaseManager.minimumVersion;
                try {
                    databaseVersion = databaseManager.VersionTableLastEntry();
                } catch (Exception ex) {
                    returnMessage += DateTime.UtcNow + " " + ex.Message;
                }

                returnMessage += DateTime.UtcNow + " " + "Database Version is; " + databaseVersion.ToString() + "\r\n";
                returnMessage += DateTime.UtcNow + " " + "Code Version is; " + databaseManager.maximumVersion.ToString() + "\r\n";

                returnMessage += DateTime.UtcNow + " " + "Start Script" + "\r\n";

                // execute next script
                DatabaseScript nextScript = databaseManager.NextScript();
                if (nextScript != null) {
                    returnMessage += DateTime.UtcNow + " " + "Script Executed" + " " + "( " + databaseManager.Execute(nextScript, haltOnException: true) + " )" + "\r\n";

                    if (databaseManager.IsVersionTableGood())   // make sure table exists
                        returnMessage += DateTime.UtcNow + " " + databaseManager.DefaultVersion(nextScript.DatabaseVersion) + "\r\n";

                    returnMessage += DateTime.UtcNow + " " + "End Script" + "\r\n";

                    // check if version is as expected
                    try {
                        databaseVersion = databaseManager.VersionTableLastEntry();
                    } catch (Exception ex) {
                        returnMessage += DateTime.UtcNow + " " + ex.Message;
                    }

                    // run next script if previous went through
                    if (nextScript.DatabaseVersion == databaseVersion) {
                        returnMessage += DateTime.UtcNow + " " + "Database version is at expected version, running next script";
                        ViewData["KeepRunning"] = "true";
                    } else {
                        returnMessage += DateTime.UtcNow + " " + "Database version is not at expected version, halting run to latest";
                    }
                } else {
                    returnMessage += DateTime.UtcNow + " " + "Database version is at last version";
                }
            } catch (System.Exception ex) {
                returnMessage = ExtractException(ex);
            }

            ViewData["Message"] = returnMessage;

            return View();
        }

        [HttpGet("versiontolatest")]
        public IActionResult VersionToLatest() {
            string returnMessage = string.Empty;

            try {
                DatabaseManager databaseManager =
                    new DatabaseManager(
                        databaseName: "NorSolutionPim",
                        toRemote: true  // always remote here
                        );

                returnMessage =
                    databaseManager.ExecuteScriptsBetween(
                        databaseManager.minimumVersion,
                        databaseManager.maximumVersion
                        );

            } catch (System.Exception ex) {
                returnMessage = ExtractException(ex);
            }

            ViewData["Message"] = returnMessage.Replace("\r\n", "<br>");

            return View();
        }

        [HttpGet("versionX")]
        public ContentResult VersionX() {
            string returnMessage = string.Empty;

            try {
                DatabaseManager databaseManager =
                    new DatabaseManager(databaseName: "NorSolutionPim", toRemote: true);

                returnMessage += databaseManager.Version(new List<string> { "DatabaseCleanScript1" });

                returnMessage += "\r\n" + databaseManager.DefaultVersion(databaseManager.scripts.Find(x => x.Name.Equals("Versioning")).DatabaseVersion);

            } catch (System.Exception ex) {
                returnMessage = ExtractException(ex);
            }

            return new ContentResult() { Content = returnMessage.Replace("\r\n", "<br>"), ContentType = "text/html" };
        }
    }
}

