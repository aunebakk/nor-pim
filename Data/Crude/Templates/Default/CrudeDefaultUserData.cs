/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 1:34:57 PM
  From Machine: DESKTOP-742U247
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
    // this class start with an identical representation of default_user's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeDefaultUserData {
        
        public System.Guid DefaultUserId { get; set; }
        
        public string DefaultUserCode { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public string DefaultStateRcd { get; set; }
        
        public System.Guid CreatedByDefaultUserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.DateTime LastActivityDateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultUserId: primary key of table default_user
        public void FetchByDefaultUserId(System.Guid defaultUserId) {
            // create query against default_user
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            where default_user_id = @default_user_id
                            order by default_user_name";

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
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = defaultUserId;

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
        //   defaultUserId: primary key of table default_user
        public static CrudeDefaultUserData GetByDefaultUserId(System.Guid defaultUserId) {
            // create query against default_user
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            where default_user_id = @default_user_id
                            order by default_user_name";

            var ret = new CrudeDefaultUserData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    // execute query against default_user
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
        public static List<CrudeDefaultUserData> FetchByCreatedByDefaultUserId(System.Guid createdByDefaultUserId) {
            var dataList = new List<CrudeDefaultUserData>();

            // create query against default_user
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            where created_by_default_user_id = @created_by_default_user_id
                              
                            order by default_user_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@created_by_default_user_id", SqlDbType.UniqueIdentifier).Value = createdByDefaultUserId;

                    // execute query against default_user
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_user
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultUserData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeDefaultUserData> FetchByDefaultStateRcd(string defaultStateRcd) {
            var dataList = new List<CrudeDefaultUserData>();

            // create query against default_user
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            where default_state_rcd = @default_state_rcd
                              
                            order by default_user_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_state_rcd", SqlDbType.NVarChar).Value = defaultStateRcd.Replace("'","''");

                    // execute query against default_user
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_user
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultUserData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Picker Member into new class instance
        public void FetchByDefaultUserName(string defaultUserName) {
            // create query against default_user
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            where default_user_name like '%' + @defaultUserName + '%'
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                    // add search column
                    // this search column will be used together with the prepared ansi sql statement
                command.Parameters.Add("@defaultUserName",SqlDbType.NVarChar).Value = defaultUserName;

                // execute query against default_user
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        // fetch all rows from table default_user into new List of class instances
        public static List<CrudeDefaultUserData> FetchAll() {
            var dataList = new List<CrudeDefaultUserData>();

            // create query against default_user
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            order by default_user_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_user
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_user
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultUserData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeDefaultUserData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultUserData>();

            // create query against default_user
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top " + limit.ToString() + @" default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            order by default_user_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_user
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_user
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultUserData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeDefaultUserData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultUserData>();

            // create query against default_user
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            order by default_user_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_user
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    // read all rows returned from the query of default_user
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultUserData();
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
            // create query against default_user
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select count(*) as count from [default_user]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    // execute query against default_user
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
        public static List<CrudeDefaultUserData> FetchWithFilter(System.Guid defaultUserId, string defaultUserCode, string defaultUserName, string email, string password, string defaultStateRcd, System.Guid createdByDefaultUserId, System.DateTime dateTime, System.DateTime lastActivityDateTime) {
            var dataList = new List<CrudeDefaultUserData>();

            // create query against default_user
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (!string.IsNullOrEmpty(defaultUserCode)) {
                        sql += "  and default_user_code like '%' + @default_user_code + '%'";
                        command.Parameters.Add("@default_user_code", SqlDbType.NVarChar).Value = defaultUserCode.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultUserName)) {
                        sql += "  and default_user_name like '%' + @default_user_name + '%'";
                        command.Parameters.Add("@default_user_name", SqlDbType.NVarChar).Value = defaultUserName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(email)) {
                        sql += "  and email like '%' + @email + '%'";
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(password)) {
                        sql += "  and password like '%' + @password + '%'";
                        command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultStateRcd)) {
                        sql += "  and default_state_rcd like '%' + @default_state_rcd + '%'";
                        command.Parameters.Add("@default_state_rcd", SqlDbType.NVarChar).Value = defaultStateRcd.Replace("'","''");
                    }
                    if (createdByDefaultUserId != Guid.Empty) {
                        sql += "  and created_by_default_user_id = @created_by_default_user_id";
                        command.Parameters.Add("@created_by_default_user_id", SqlDbType.UniqueIdentifier).Value = createdByDefaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (lastActivityDateTime != DateTime.MinValue) {
                        sql += "  and last_activity_date_time = @last_activity_date_time";
                        command.Parameters.Add("@last_activity_date_time", SqlDbType.DateTime).Value = lastActivityDateTime;
                    }
                    sql += " order by default_user_name";

                    command.CommandText = sql;

                    // execute query against default_user
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_user
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultUserData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["default_user_code"] != System.DBNull.Value) DefaultUserCode = (System.String) reader["default_user_code"];
            if (reader["default_user_name"] != System.DBNull.Value) DefaultUserName = (System.String) reader["default_user_name"];
            if (reader["email"] != System.DBNull.Value) Email = (System.String) reader["email"];
            if (reader["password"] != System.DBNull.Value) Password = (System.String) reader["password"];
            if (reader["default_state_rcd"] != System.DBNull.Value) DefaultStateRcd = (System.String) reader["default_state_rcd"];
            if (reader["created_by_default_user_id"] != System.DBNull.Value) CreatedByDefaultUserId = (System.Guid) reader["created_by_default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["last_activity_date_time"] != System.DBNull.Value) LastActivityDateTime = (System.DateTime) reader["last_activity_date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (DefaultUserId == Guid.Empty)
                DefaultUserId = Guid.NewGuid();

            // create query against default_user
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [default_user] (default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time)";
            sql += "            values (@default_user_id, @default_user_code, @default_user_name, @email, @password, @default_state_rcd, @created_by_default_user_id, @date_time, @last_activity_date_time)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    // add column(s) to insert as parameter
                    // the insert column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@default_user_code",SqlDbType.NVarChar).Value = (System.String)DefaultUserCode;
                    command.Parameters.Add("@default_user_name",SqlDbType.NVarChar).Value = (System.String)DefaultUserName;
                    command.Parameters.Add("@email",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Email)) ? (object)DBNull.Value : (System.String)Email;
                    command.Parameters.Add("@password",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Password)) ? (object)DBNull.Value : (System.String)Password;
                    command.Parameters.Add("@default_state_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultStateRcd;
                    command.Parameters.Add("@created_by_default_user_id",SqlDbType.UniqueIdentifier).Value = (CreatedByDefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)CreatedByDefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@last_activity_date_time",SqlDbType.DateTime).Value = (LastActivityDateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)LastActivityDateTime);
                    // execute query against default_user
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

            if (DefaultUserId == Guid.Empty)
                DefaultUserId = Guid.NewGuid();

            // create query against default_user
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [default_user] (default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time)";
            sql += "            values (@default_user_id, @default_user_code, @default_user_name, @email, @password, @default_state_rcd, @created_by_default_user_id, @date_time, @last_activity_date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to insert as parameter(s)
                // the insert column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@default_user_code",SqlDbType.NVarChar).Value = (System.String)DefaultUserCode;
                command.Parameters.Add("@default_user_name",SqlDbType.NVarChar).Value = (System.String)DefaultUserName;
                command.Parameters.Add("@email",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Email)) ? (object)DBNull.Value : (System.String)Email;
                command.Parameters.Add("@password",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Password)) ? (object)DBNull.Value : (System.String)Password;
                command.Parameters.Add("@default_state_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultStateRcd;
                command.Parameters.Add("@created_by_default_user_id",SqlDbType.UniqueIdentifier).Value = (CreatedByDefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)CreatedByDefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@last_activity_date_time",SqlDbType.DateTime).Value = (LastActivityDateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)LastActivityDateTime);
                // execute query against default_user
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            // create query against default_user
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [default_user] set
                 default_user_id = @default_user_id
                ,default_user_code = @default_user_code
                ,default_user_name = @default_user_name
                ,email = @email
                ,password = @password
                ,default_state_rcd = @default_state_rcd
                ,created_by_default_user_id = @created_by_default_user_id
                ,date_time = @date_time
                ,last_activity_date_time = @last_activity_date_time
            where default_user_id = @default_user_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // add column(s) to update as parameter(s)
                    // the update column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@default_user_code",SqlDbType.NVarChar).Value = (System.String)DefaultUserCode;
                    command.Parameters.Add("@default_user_name",SqlDbType.NVarChar).Value = (System.String)DefaultUserName;
                    command.Parameters.Add("@email",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Email)) ? (object)DBNull.Value : (System.String)Email;
                    command.Parameters.Add("@password",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Password)) ? (object)DBNull.Value : (System.String)Password;
                    command.Parameters.Add("@default_state_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultStateRcd;
                    command.Parameters.Add("@created_by_default_user_id",SqlDbType.UniqueIdentifier).Value = (CreatedByDefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)CreatedByDefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@last_activity_date_time",SqlDbType.DateTime).Value = (LastActivityDateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)LastActivityDateTime);
                    // execute query against default_user
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            // create query against default_user
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [default_user] set
                 default_user_id = @default_user_id
                ,default_user_code = @default_user_code
                ,default_user_name = @default_user_name
                ,email = @email
                ,password = @password
                ,default_state_rcd = @default_state_rcd
                ,created_by_default_user_id = @created_by_default_user_id
                ,date_time = @date_time
                ,last_activity_date_time = @last_activity_date_time
            where default_user_id = @default_user_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to update as parameter
                // the update column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@default_user_code",SqlDbType.NVarChar).Value = (System.String)DefaultUserCode;
                command.Parameters.Add("@default_user_name",SqlDbType.NVarChar).Value = (System.String)DefaultUserName;
                command.Parameters.Add("@email",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Email)) ? (object)DBNull.Value : (System.String)Email;
                command.Parameters.Add("@password",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Password)) ? (object)DBNull.Value : (System.String)Password;
                command.Parameters.Add("@default_state_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultStateRcd;
                command.Parameters.Add("@created_by_default_user_id",SqlDbType.UniqueIdentifier).Value = (CreatedByDefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)CreatedByDefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@last_activity_date_time",SqlDbType.DateTime).Value = (LastActivityDateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)LastActivityDateTime);
                // execute query against default_user
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid defaultUserId) {
            // create query against default_user
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" delete [default_user] 
                where default_user_id = @default_user_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    // execute query against default_user
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
