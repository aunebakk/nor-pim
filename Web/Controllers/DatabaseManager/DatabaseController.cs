/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 6/22/2020 12:24:43 PM
  From Machine: DESKTOP-517I8BU
  Origin: SQL2XExtensionV3.SQL2XExtensionCreatorNorSolutionQueue.Content_DatabaseControllerDOTcs_DNF
  Documentation:
    Methods for maintaining the SQL Server and Azure SQL Server database
*/
//using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;
using Microsoft.Rest;
using Microsoft.Rest.Azure.Authentication;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.BusinessLogicLayer.Controllers {
    //[Produces("application/json")]
    [Route("api/1/database")]
    public class DatabaseController : Controller {

        /// <summary>
        /// Index for database management functions
        /// </summary>
        /// <returns>View with links</returns>
        //[HttpGet("IndexDatabase")]
        public ActionResult Index() {
            return View("Index");
        }

        /// <summary>
        /// ANSI SQL script executed against a SQL server database
        /// A select against Stored Procedure [db_id] is done
        ///  and if that is not null then a TSQL [drop] is executed
        ///  against the connection string in static class [Conn]
        /// </summary>
        /// <param name="databaseName">Name of Database to delete</param>
        /// <returns>List of comments from the database</returns>
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
                            connectionString: Conn.ConnectionString,
                            sql: sql
                        );

            foreach (string line in result) {
                //Log("SQL Execute Result: " + line);
            }

            return result;
        }

        /// <summary>
        /// ANSI SQL script executed against a SQL server database
        ///  A TSQL [create] is executed against the connection string in static class [Conn]
        /// </summary>
        /// <param name="databaseName">Name of Database to create</param>
        /// <returns>List of comments from the database</returns>
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
                            connectionString: Conn.ConnectionString,
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
        /// <returns>Result from sql statements</returns>
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

        /// <summary>
        /// Connection to Azure SQL Server using client secret
        /// </summary>
        /// <returns>Connection object</returns>
        private static SqlManagementClient AzureSqlClient() {
            SqlManagementClient sqlClient;
            try {
                string clientId = "";        // Principal Id | Application ID | Client ID
                string secret = "";
                string tenantId = "";        // Environment.GetEnvironmentVariable("AZURE_TENANT_ID");
                string subscriptionId = "";  // Environment.GetEnvironmentVariable("AZURE_SUBSCRIPTION_ID");

                ServiceClientCredentials serviceCreds = Task.Run(() => ApplicationTokenProvider.LoginSilentAsync(domain: tenantId, clientId: clientId, secret: secret)).Result;

                sqlClient = new SqlManagementClient(serviceCreds);
                sqlClient.SubscriptionId = subscriptionId;
            } catch (Exception ex) {
                if (ex != null) { }
                throw new Exception(message: $"Failed to get Azure Service Principal: {ex.Message}");
            }
            return sqlClient;
        }

        /// <summary>
        /// Create Azure Sql Server SQL2X Queue database
        /// </summary>
        /// <returns>MVC View</returns>
        //[HttpGet("CreateDatabase")]
        public ActionResult CreateDatabase() {

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
                    serverName: "sqlServerName",
                    databaseName: "NorSolutionPim",
                    parameters: newDb
                    );
            }

            return View();
        }

        /// <summary>
        /// Remove Azure SQL server SQL2X Queue database
        /// </summary>
        /// <returns>MVC View</returns>
        //[HttpGet("RemoveDatabase")]
        public ActionResult RemoveDatabase() {
            if (IsLocal) {
                DatabaseDelete("NorSolutionPim");
            } else {
                SqlManagementClient sqlClient = AzureSqlClient();

                var newDb = new Microsoft.Azure.Management.Sql.Models.Database {
                    Location = "East US 2"
                };

                sqlClient.Databases.Delete(
                    resourceGroupName: "Default-SQL-EastUS2",
                    serverName: "sqlServerName",
                    databaseName: "NorSolutionPim"
                    );
            }

            return View();
        }

        /// <summary>
        /// Check HTTP host string if we are running on local machine
        /// </summary>
        /// <returns>True if local</returns>
        //private bool IsLocal { get { return this.Request.Host.ToString().IndexOf("localhost") != -1; } }
        private bool IsLocal { get { return false; } }

        /// <summary>
        /// Get version as object from SQL2X Queue database
        /// </summary>
        /// <returns>Version Object</returns>
        //[HttpGet("getversionobject")]
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
        /// Get version as text string
        /// </summary>
        /// <returns>Version as text string</returns>
        //[HttpGet("getversion")]
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

        /// <summary>
        /// Set SQL2X Queue version to zero
        /// </summary>
        /// <returns>MVC View with outcome</returns>
        //[HttpGet("SetVersionZero")]
        public ActionResult SetVersionZero() {
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

                string whyNot = string.Empty;
                if (databaseManager.IsConnectionGood(out whyNot))
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
                            databaseManager.defaultVersion,
                            breakOnCreationCheckmark: false
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

        /// <summary>
        /// Increase SQL2X Queue version
        /// </summary>
        /// <returns>MVC View with outcome</returns>
        //[HttpGet("increaseversion")]
        public ActionResult IncreaseVersion() {
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

                string whyNot = string.Empty;
                if (databaseManager.IsConnectionGood(out whyNot))
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

        /// <summary>
        /// Set SQL2X Queue version to code version
        /// </summary>
        /// <returns>MVC View with outcome</returns>
        //[HttpGet("increaseversiontolatest")]
        public ActionResult IncreaseVersionToLatest() {
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

                string whyNot = string.Empty;
                if (databaseManager.IsConnectionGood(out whyNot))
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

        /// <summary>
        /// Set SQL2X Queue version to latest
        /// </summary>
        /// <returns>MVC View with outcome</returns>
        //[HttpGet("versiontolatest")]
        public ActionResult VersionToLatest() {
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
                        databaseManager.maximumVersion,
                        breakOnCreationCheckmark: false
                        );

            } catch (System.Exception ex) {
                returnMessage = ExtractException(ex);
            }

            ViewData["Message"] = returnMessage.Replace("\r\n", "<br>");

            return View();
        }

        //[HttpGet("versionX")]
        public ContentResult VersionX() {
            string returnMessage = string.Empty;

            try {
                DatabaseManager databaseManager =
                    new DatabaseManager(databaseName: "NorPimRedone", toRemote: true);

                returnMessage += databaseManager.Version(new List<string> { "DatabaseCleanScript1" });

                returnMessage += "\r\n" + databaseManager.DefaultVersion(databaseManager.scripts.Find(x => x.Name.Equals("Versioning")).DatabaseVersion);

            } catch (System.Exception ex) {
                returnMessage = ExtractException(ex);
            }

            return new ContentResult() { Content = returnMessage.Replace("\r\n", "<br>"), ContentType = "text/html" };
        }
    }
}

