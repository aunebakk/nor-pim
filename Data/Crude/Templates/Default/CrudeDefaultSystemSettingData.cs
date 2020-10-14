/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:23:51 AM
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

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of default_system_setting's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeDefaultSystemSettingData {
        
        public System.Guid DefaultSystemSettingId { get; set; }
        
        public string DefaultSystemSettingRcd { get; set; }
        
        public string DefaultSystemSettingValue { get; set; }
        
        public System.Guid DefaultUserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultSystemSettingId: primary key of table default_system_setting
        public void FetchByDefaultSystemSettingId(System.Guid defaultSystemSettingId) {
            // create query against default_system_setting
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]
                            where default_system_setting_id = @default_system_setting_id";

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
                    command.Parameters.Add("@default_system_setting_id",SqlDbType.UniqueIdentifier).Value = defaultSystemSettingId;

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
        //   defaultSystemSettingId: primary key of table default_system_setting
        public static CrudeDefaultSystemSettingData GetByDefaultSystemSettingId(System.Guid defaultSystemSettingId) {
            // create query against default_system_setting
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]
                            where default_system_setting_id = @default_system_setting_id";

            var ret = new CrudeDefaultSystemSettingData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_system_setting_id",SqlDbType.UniqueIdentifier).Value = defaultSystemSettingId;

                    // execute query against default_system_setting
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serialized class if a row was found
                    if (reader.Read())
                        ret.Populate(reader);
                }
            }

            return ret;
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeDefaultSystemSettingData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultSystemSettingData>();

            // create query against default_system_setting
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]
                            where default_user_id = @default_user_id
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    // execute query against default_system_setting
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_system_setting
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemSettingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeDefaultSystemSettingData> FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd) {
            var dataList = new List<CrudeDefaultSystemSettingData>();

            // create query against default_system_setting
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]
                            where default_system_setting_rcd = @default_system_setting_rcd
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_system_setting_rcd", SqlDbType.NVarChar).Value = defaultSystemSettingRcd.Replace("'","''");

                    // execute query against default_system_setting
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_system_setting
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemSettingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all rows from table default_system_setting into new List of class instances
        public static List<CrudeDefaultSystemSettingData> FetchAll() {
            var dataList = new List<CrudeDefaultSystemSettingData>();

            // create query against default_system_setting
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_system_setting
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_system_setting
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemSettingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeDefaultSystemSettingData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultSystemSettingData>();

            // create query against default_system_setting
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top " + limit.ToString() + @" default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_system_setting
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_system_setting
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemSettingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeDefaultSystemSettingData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultSystemSettingData>();

            // create query against default_system_setting
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_system_setting
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    // read all rows returned from the query of default_system_setting
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultSystemSettingData();
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
            // create query against default_system_setting
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select count(*) as count from [default_system_setting]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    // execute query against default_system_setting
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    reader.Read();
                    count = (System.Int32) reader["count"];
                }

                return count;
            }
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public static List<CrudeDefaultSystemSettingData> FetchWithFilter(System.Guid defaultSystemSettingId, string defaultSystemSettingRcd, string defaultSystemSettingValue, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultSystemSettingData>();

            // create query against default_system_setting
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
                    if (defaultSystemSettingId != Guid.Empty) {
                        sql += "  and default_system_setting_id = @default_system_setting_id";
                        command.Parameters.Add("@default_system_setting_id", SqlDbType.UniqueIdentifier).Value = defaultSystemSettingId;
                    }
                    if (!string.IsNullOrEmpty(defaultSystemSettingRcd)) {
                        sql += "  and default_system_setting_rcd like '%' + @default_system_setting_rcd + '%'";
                        command.Parameters.Add("@default_system_setting_rcd", SqlDbType.NVarChar).Value = defaultSystemSettingRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultSystemSettingValue)) {
                        sql += "  and default_system_setting_value like '%' + @default_system_setting_value + '%'";
                        command.Parameters.Add("@default_system_setting_value", SqlDbType.NVarChar).Value = defaultSystemSettingValue.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    command.CommandText = sql;

                    // execute query against default_system_setting
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_system_setting
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemSettingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["default_system_setting_id"] != System.DBNull.Value) DefaultSystemSettingId = (System.Guid) reader["default_system_setting_id"];
            if (reader["default_system_setting_rcd"] != System.DBNull.Value) DefaultSystemSettingRcd = (System.String) reader["default_system_setting_rcd"];
            if (reader["default_system_setting_value"] != System.DBNull.Value) DefaultSystemSettingValue = (System.String) reader["default_system_setting_value"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (DefaultSystemSettingId == Guid.Empty)
                DefaultSystemSettingId = Guid.NewGuid();

            // create query against default_system_setting
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [default_system_setting] (default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time)";
            sql += "            values (@default_system_setting_id, @default_system_setting_rcd, @default_system_setting_value, @default_user_id, @date_time)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    // add column(s) to insert as parameter
                    // the insert column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_system_setting_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultSystemSettingId;
                    command.Parameters.Add("@default_system_setting_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingRcd;
                    command.Parameters.Add("@default_system_setting_value",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingValue;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against default_system_setting
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultSystemSettingId == Guid.Empty)
                DefaultSystemSettingId = Guid.NewGuid();

            // create query against default_system_setting
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [default_system_setting] (default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time)";
            sql += "            values (@default_system_setting_id, @default_system_setting_rcd, @default_system_setting_value, @default_user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to insert as parameter(s)
                // the insert column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@default_system_setting_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultSystemSettingId;
                command.Parameters.Add("@default_system_setting_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingRcd;
                command.Parameters.Add("@default_system_setting_value",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingValue;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against default_system_setting
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            // create query against default_system_setting
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [default_system_setting] set
                 default_system_setting_id = @default_system_setting_id
                ,default_system_setting_rcd = @default_system_setting_rcd
                ,default_system_setting_value = @default_system_setting_value
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_system_setting_id = @default_system_setting_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // add column(s) to update as parameter(s)
                    // the update column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_system_setting_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultSystemSettingId;
                    command.Parameters.Add("@default_system_setting_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingRcd;
                    command.Parameters.Add("@default_system_setting_value",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingValue;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against default_system_setting
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            // create query against default_system_setting
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [default_system_setting] set
                 default_system_setting_id = @default_system_setting_id
                ,default_system_setting_rcd = @default_system_setting_rcd
                ,default_system_setting_value = @default_system_setting_value
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_system_setting_id = @default_system_setting_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to update as parameter
                // the update column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@default_system_setting_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultSystemSettingId;
                command.Parameters.Add("@default_system_setting_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingRcd;
                command.Parameters.Add("@default_system_setting_value",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingValue;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against default_system_setting
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid defaultSystemSettingId) {
            // create query against default_system_setting
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" delete [default_system_setting] 
                where default_system_setting_id = @default_system_setting_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_system_setting_id",SqlDbType.UniqueIdentifier).Value = defaultSystemSettingId;
                    // execute query against default_system_setting
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
