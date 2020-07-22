/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/22/2020 9:24:04 AM
  From Machine: DESKTOP-00MSEIL
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

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of default_change_log's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeDefaultChangeLogData {
        
        public System.Guid DefaultChangeLogId { get; set; }
        
        public string DefaultChangeName { get; set; }
        
        public string DefaultChangeDescription { get; set; }
        
        public System.Guid DefaultUserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public string DefaultChangeLogTypeRcd { get; set; }
        
        public System.Guid DefaultIssueId { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultChangeLogId: primary key of table default_change_log
        public void FetchByDefaultChangeLogId(System.Guid defaultChangeLogId) {
            // create query against default_change_log
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            where default_change_log_id = @default_change_log_id
                            order by default_change_name";

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
                    command.Parameters.Add("@default_change_log_id",SqlDbType.UniqueIdentifier).Value = defaultChangeLogId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        // fetch by Primary key into new class instance
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultChangeLogId: primary key of table default_change_log
        public static CrudeDefaultChangeLogData GetByDefaultChangeLogId(System.Guid defaultChangeLogId) {
            // create query against default_change_log
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            where default_change_log_id = @default_change_log_id
                            order by default_change_name";

            var ret = new CrudeDefaultChangeLogData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_change_log_id",SqlDbType.UniqueIdentifier).Value = defaultChangeLogId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serialized class if row was found
                    if (reader.Read())
                        ret.Populate(reader);
                }
            }

            return ret;
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeDefaultChangeLogData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultChangeLogData>();

            string sql = @" select default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            where default_user_id = @default_user_id
                              
                            order by default_change_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeDefaultChangeLogData> FetchByDefaultIssueId(System.Guid defaultIssueId) {
            var dataList = new List<CrudeDefaultChangeLogData>();

            string sql = @" select default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            where default_issue_id = @default_issue_id
                              
                            order by default_change_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_issue_id", SqlDbType.UniqueIdentifier).Value = defaultIssueId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeDefaultChangeLogData> FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd) {
            var dataList = new List<CrudeDefaultChangeLogData>();

            string sql = @" select default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            where default_change_log_type_rcd = @default_change_log_type_rcd
                              
                            order by default_change_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_change_log_type_rcd", SqlDbType.NVarChar).Value = defaultChangeLogTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Picker Member into new class instance
        public void FetchByDefaultChangeName(string defaultChangeName) {
            string sql = @" select top 1 default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            where default_change_name like '%' + @defaultChangeName + '%'
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                    // add search column
                    // this search column will be used together with the prepared ansi sql statement
                command.Parameters.Add("@defaultChangeName",SqlDbType.NVarChar).Value = defaultChangeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        // fetch all from table into new List of class instances
        public static List<CrudeDefaultChangeLogData> FetchAll() {
            var dataList = new List<CrudeDefaultChangeLogData>();

            string sql = @" select default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            order by default_change_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeDefaultChangeLogData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultChangeLogData>();

            string sql = @" select top " + limit.ToString() + @" default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            order by default_change_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns , with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeDefaultChangeLogData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultChangeLogData>();

            string sql = @" select default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            order by default_change_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultChangeLogData();
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
            string sql = @" select count(*) as count from [default_change_log]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
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
        public static List<CrudeDefaultChangeLogData> FetchWithFilter(System.Guid defaultChangeLogId, string defaultChangeName, string defaultChangeDescription, System.Guid defaultUserId, System.DateTime dateTime, string defaultChangeLogTypeRcd, System.Guid defaultIssueId) {
            var dataList = new List<CrudeDefaultChangeLogData>();

            string sql = @" select default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
                    if (defaultChangeLogId != Guid.Empty) {
                        sql += "  and default_change_log_id = @default_change_log_id";
                        command.Parameters.Add("@default_change_log_id", SqlDbType.UniqueIdentifier).Value = defaultChangeLogId;
                    }
                    if (!string.IsNullOrEmpty(defaultChangeName)) {
                        sql += "  and default_change_name like '%' + @default_change_name + '%'";
                        command.Parameters.Add("@default_change_name", SqlDbType.NVarChar).Value = defaultChangeName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultChangeDescription)) {
                        sql += "  and default_change_description like '%' + @default_change_description + '%'";
                        command.Parameters.Add("@default_change_description", SqlDbType.NVarChar).Value = defaultChangeDescription.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (!string.IsNullOrEmpty(defaultChangeLogTypeRcd)) {
                        sql += "  and default_change_log_type_rcd like '%' + @default_change_log_type_rcd + '%'";
                        command.Parameters.Add("@default_change_log_type_rcd", SqlDbType.NVarChar).Value = defaultChangeLogTypeRcd.Replace("'","''");
                    }
                    if (defaultIssueId != Guid.Empty) {
                        sql += "  and default_issue_id = @default_issue_id";
                        command.Parameters.Add("@default_issue_id", SqlDbType.UniqueIdentifier).Value = defaultIssueId;
                    }
                    sql += " order by default_change_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["default_change_log_id"] != System.DBNull.Value) DefaultChangeLogId = (System.Guid) reader["default_change_log_id"];
            if (reader["default_change_name"] != System.DBNull.Value) DefaultChangeName = (System.String) reader["default_change_name"];
            if (reader["default_change_description"] != System.DBNull.Value) DefaultChangeDescription = (System.String) reader["default_change_description"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["default_change_log_type_rcd"] != System.DBNull.Value) DefaultChangeLogTypeRcd = (System.String) reader["default_change_log_type_rcd"];
            if (reader["default_issue_id"] != System.DBNull.Value) DefaultIssueId = (System.Guid) reader["default_issue_id"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (DefaultChangeLogId == Guid.Empty)
                DefaultChangeLogId = Guid.NewGuid();

            string sql = "insert into [default_change_log] (default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id)";
            sql += "            values (@default_change_log_id, @default_change_name, @default_change_description, @default_user_id, @date_time, @default_change_log_type_rcd, @default_issue_id)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_change_log_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultChangeLogId;
                    command.Parameters.Add("@default_change_name",SqlDbType.NVarChar).Value = (System.String)DefaultChangeName;
                    command.Parameters.Add("@default_change_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(DefaultChangeDescription)) ? (object)DBNull.Value : (System.String)DefaultChangeDescription;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@default_change_log_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeRcd;
                    command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = (DefaultIssueId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultIssueId);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultChangeLogId == Guid.Empty)
                DefaultChangeLogId = Guid.NewGuid();

            string sql = "insert into [default_change_log] (default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id)";
            sql += "            values (@default_change_log_id, @default_change_name, @default_change_description, @default_user_id, @date_time, @default_change_log_type_rcd, @default_issue_id)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_change_log_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultChangeLogId;
                command.Parameters.Add("@default_change_name",SqlDbType.NVarChar).Value = (System.String)DefaultChangeName;
                command.Parameters.Add("@default_change_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(DefaultChangeDescription)) ? (object)DBNull.Value : (System.String)DefaultChangeDescription;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@default_change_log_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeRcd;
                command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = (DefaultIssueId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultIssueId);
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            string sql = @" update [default_change_log] set
                 default_change_log_id = @default_change_log_id
                ,default_change_name = @default_change_name
                ,default_change_description = @default_change_description
                ,default_user_id = @default_user_id
                ,date_time = @date_time
                ,default_change_log_type_rcd = @default_change_log_type_rcd
                ,default_issue_id = @default_issue_id
            where default_change_log_id = @default_change_log_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_change_log_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultChangeLogId;
                    command.Parameters.Add("@default_change_name",SqlDbType.NVarChar).Value = (System.String)DefaultChangeName;
                    command.Parameters.Add("@default_change_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(DefaultChangeDescription)) ? (object)DBNull.Value : (System.String)DefaultChangeDescription;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@default_change_log_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeRcd;
                    command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = (DefaultIssueId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultIssueId);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_change_log] set
                 default_change_log_id = @default_change_log_id
                ,default_change_name = @default_change_name
                ,default_change_description = @default_change_description
                ,default_user_id = @default_user_id
                ,date_time = @date_time
                ,default_change_log_type_rcd = @default_change_log_type_rcd
                ,default_issue_id = @default_issue_id
            where default_change_log_id = @default_change_log_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_change_log_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultChangeLogId;
                command.Parameters.Add("@default_change_name",SqlDbType.NVarChar).Value = (System.String)DefaultChangeName;
                command.Parameters.Add("@default_change_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(DefaultChangeDescription)) ? (object)DBNull.Value : (System.String)DefaultChangeDescription;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@default_change_log_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeRcd;
                command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = (DefaultIssueId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultIssueId);
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid defaultChangeLogId) {
            string sql = @" delete [default_change_log] 
                where default_change_log_id = @default_change_log_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_change_log_id",SqlDbType.UniqueIdentifier).Value = defaultChangeLogId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
