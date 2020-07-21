/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:15:54 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

// Data Access Layer
// the DataAccessLayer is the first layer that has access to data coming from
//  sql server after being streamed over a net or internal process
// links:
//   https://en.wikipedia.org/wiki/Data_access_layer: data access layer
namespace SolutionNorSolutionPim.DataAccessLayer {

    public partial class DefaultIssueStatusRef {
        
        public const string NotAnIssue = "NotAnIssue";
        
        public const string NotReproducible = "NotReproducible";
        
        public const string Resolved = "Resolved";
        
        public const string ToBeResolved = "ToBeResolved";
    }
    
    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of default_issue_status_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeDefaultIssueStatusRefData {
        
        public string DefaultIssueStatusRcd { get; set; }
        
        public string DefaultIssueStatusName { get; set; }
        
        public System.Guid DefaultUserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultIssueStatusRcd: primary key of table default_issue_status_ref
        public void FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd) {
            // create query against default_issue_status_ref
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            where default_issue_status_rcd = @default_issue_status_rcd
                            order by default_issue_status_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                // dirty read
                // starting a transaction seems to be the only way of doing a dirty read
                // a dirty read means a row is read even if it is marked
                //   as locked by another database transaction
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = defaultIssueStatusRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        // fetch by Primary key into new class instance
        public static CrudeDefaultIssueStatusRefData GetByDefaultIssueStatusRcd(string defaultIssueStatusRcd) {
            string sql = @" select top 1 default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            where default_issue_status_rcd = @default_issue_status_rcd
                            order by default_issue_status_name";

            var ret = new CrudeDefaultIssueStatusRefData();

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = defaultIssueStatusRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serialized class if row was found
                    if (reader.Read())
                        ret.Populate(reader);
                }
            }

            return ret;
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeDefaultIssueStatusRefData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultIssueStatusRefData>();

            string sql = @" select default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            where default_user_id = @default_user_id
                              
                            order by default_issue_status_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueStatusRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Picker Member into new class instance
        public void FetchByDefaultIssueStatusName(string defaultIssueStatusName) {
            string sql = @" select top 1 default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            where default_issue_status_name like '%' + @defaultIssueStatusName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@defaultIssueStatusName",SqlDbType.NVarChar).Value = defaultIssueStatusName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        // fetch all from table into new List of class instances
        public static List<CrudeDefaultIssueStatusRefData> FetchAll() {
            var dataList = new List<CrudeDefaultIssueStatusRefData>();

            string sql = @" select default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            order by default_issue_status_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueStatusRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeDefaultIssueStatusRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultIssueStatusRefData>();

            string sql = @" select top " + limit.ToString() + @" default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            order by default_issue_status_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueStatusRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns , with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeDefaultIssueStatusRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultIssueStatusRefData>();

            string sql = @" select default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            order by default_issue_status_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultIssueStatusRefData();
                            data.Populate(reader);
                            dataList.Add(data);
                        }
                        count++;
                        if (count > limit + offset) break;
                    }
                }
                
                return dataList;
            }
        }
        
        // get a count of rows in table
        public static int FetchAllCount() {
            string sql = @" select count(*) as count from [default_issue_status_ref]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    reader.Read();
                    count = (System.Int32) reader["count"];
                }

                return count;
            }
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public static List<CrudeDefaultIssueStatusRefData> FetchWithFilter(string defaultIssueStatusRcd, string defaultIssueStatusName, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultIssueStatusRefData>();

            string sql = @" select default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(defaultIssueStatusRcd)) {
                        sql += "  and default_issue_status_rcd like '%' + @default_issue_status_rcd + '%'";
                        command.Parameters.Add("@default_issue_status_rcd", SqlDbType.NVarChar).Value = defaultIssueStatusRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultIssueStatusName)) {
                        sql += "  and default_issue_status_name like '%' + @default_issue_status_name + '%'";
                        command.Parameters.Add("@default_issue_status_name", SqlDbType.NVarChar).Value = defaultIssueStatusName.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by default_issue_status_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueStatusRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["default_issue_status_rcd"] != System.DBNull.Value) DefaultIssueStatusRcd = (System.String) reader["default_issue_status_rcd"];
            if (reader["default_issue_status_name"] != System.DBNull.Value) DefaultIssueStatusName = (System.String) reader["default_issue_status_name"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            string sql = "insert into [default_issue_status_ref] (default_issue_status_rcd, default_issue_status_name, default_user_id, date_time)";
            sql += "            values (@default_issue_status_rcd, @default_issue_status_name, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusRcd;
                    command.Parameters.Add("@default_issue_status_name",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [default_issue_status_ref] (default_issue_status_rcd, default_issue_status_name, default_user_id, date_time)";
            sql += "            values (@default_issue_status_rcd, @default_issue_status_name, @default_user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusRcd;
                command.Parameters.Add("@default_issue_status_name",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            string sql = @" update [default_issue_status_ref] set
                 default_issue_status_rcd = @default_issue_status_rcd
                ,default_issue_status_name = @default_issue_status_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_issue_status_rcd = @default_issue_status_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusRcd;
                    command.Parameters.Add("@default_issue_status_name",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_issue_status_ref] set
                 default_issue_status_rcd = @default_issue_status_rcd
                ,default_issue_status_name = @default_issue_status_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_issue_status_rcd = @default_issue_status_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusRcd;
                command.Parameters.Add("@default_issue_status_name",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(string defaultIssueStatusRcd) {
            string sql = @" delete [default_issue_status_ref] 
                where default_issue_status_rcd = @default_issue_status_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = defaultIssueStatusRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
