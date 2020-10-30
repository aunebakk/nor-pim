/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 11:00:09 AM
  From Machine: DESKTOP-9A2DH39
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
    // this class start with an identical representation of default_user_activity's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeDefaultUserActivityData {
        
        public System.Guid DefaultUserActivityId { get; set; }
        
        public string DefaultUserActivityTypeRcd { get; set; }
        
        public string UserActivityNote { get; set; }
        
        public string OriginatingAddress { get; set; }
        
        public string Referrer { get; set; }
        
        public System.Guid DefaultUserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultUserActivityId: primary key of table default_user_activity
        public void FetchByDefaultUserActivityId(System.Guid defaultUserActivityId) {
            // create query against default_user_activity
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]
                            where default_user_activity_id = @default_user_activity_id";

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
                    command.Parameters.Add("@default_user_activity_id",SqlDbType.UniqueIdentifier).Value = defaultUserActivityId;

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
        //   defaultUserActivityId: primary key of table default_user_activity
        public static CrudeDefaultUserActivityData GetByDefaultUserActivityId(System.Guid defaultUserActivityId) {
            // create query against default_user_activity
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]
                            where default_user_activity_id = @default_user_activity_id";

            var ret = new CrudeDefaultUserActivityData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_user_activity_id",SqlDbType.UniqueIdentifier).Value = defaultUserActivityId;

                    // execute query against default_user_activity
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
        public static List<CrudeDefaultUserActivityData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultUserActivityData>();

            // create query against default_user_activity
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]
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

                    // execute query against default_user_activity
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_user_activity
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultUserActivityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeDefaultUserActivityData> FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd) {
            var dataList = new List<CrudeDefaultUserActivityData>();

            // create query against default_user_activity
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]
                            where default_user_activity_type_rcd = @default_user_activity_type_rcd
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_user_activity_type_rcd", SqlDbType.NVarChar).Value = defaultUserActivityTypeRcd.Replace("'","''");

                    // execute query against default_user_activity
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_user_activity
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultUserActivityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all rows from table default_user_activity into new List of class instances
        public static List<CrudeDefaultUserActivityData> FetchAll() {
            var dataList = new List<CrudeDefaultUserActivityData>();

            // create query against default_user_activity
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_user_activity
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_user_activity
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultUserActivityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeDefaultUserActivityData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultUserActivityData>();

            // create query against default_user_activity
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top " + limit.ToString() + @" default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_user_activity
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_user_activity
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultUserActivityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeDefaultUserActivityData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultUserActivityData>();

            // create query against default_user_activity
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_user_activity
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    // read all rows returned from the query of default_user_activity
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultUserActivityData();
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
            // create query against default_user_activity
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select count(*) as count from [default_user_activity]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    // execute query against default_user_activity
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
        public static List<CrudeDefaultUserActivityData> FetchWithFilter(System.Guid defaultUserActivityId, string defaultUserActivityTypeRcd, string userActivityNote, string originatingAddress, string referrer, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultUserActivityData>();

            // create query against default_user_activity
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
                    if (defaultUserActivityId != Guid.Empty) {
                        sql += "  and default_user_activity_id = @default_user_activity_id";
                        command.Parameters.Add("@default_user_activity_id", SqlDbType.UniqueIdentifier).Value = defaultUserActivityId;
                    }
                    if (!string.IsNullOrEmpty(defaultUserActivityTypeRcd)) {
                        sql += "  and default_user_activity_type_rcd like '%' + @default_user_activity_type_rcd + '%'";
                        command.Parameters.Add("@default_user_activity_type_rcd", SqlDbType.NVarChar).Value = defaultUserActivityTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(userActivityNote)) {
                        sql += "  and user_activity_note like '%' + @user_activity_note + '%'";
                        command.Parameters.Add("@user_activity_note", SqlDbType.NVarChar).Value = userActivityNote.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(originatingAddress)) {
                        sql += "  and originating_address like '%' + @originating_address + '%'";
                        command.Parameters.Add("@originating_address", SqlDbType.NVarChar).Value = originatingAddress.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(referrer)) {
                        sql += "  and referrer like '%' + @referrer + '%'";
                        command.Parameters.Add("@referrer", SqlDbType.NVarChar).Value = referrer.Replace("'","''");
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

                    // execute query against default_user_activity
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_user_activity
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultUserActivityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["default_user_activity_id"] != System.DBNull.Value) DefaultUserActivityId = (System.Guid) reader["default_user_activity_id"];
            if (reader["default_user_activity_type_rcd"] != System.DBNull.Value) DefaultUserActivityTypeRcd = (System.String) reader["default_user_activity_type_rcd"];
            if (reader["user_activity_note"] != System.DBNull.Value) UserActivityNote = (System.String) reader["user_activity_note"];
            if (reader["originating_address"] != System.DBNull.Value) OriginatingAddress = (System.String) reader["originating_address"];
            if (reader["referrer"] != System.DBNull.Value) Referrer = (System.String) reader["referrer"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (DefaultUserActivityId == Guid.Empty)
                DefaultUserActivityId = Guid.NewGuid();

            // create query against default_user_activity
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [default_user_activity] (default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time)";
            sql += "            values (@default_user_activity_id, @default_user_activity_type_rcd, @user_activity_note, @originating_address, @referrer, @default_user_id, @date_time)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    // add column(s) to insert as parameter
                    // the insert column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_user_activity_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserActivityId;
                    command.Parameters.Add("@default_user_activity_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeRcd;
                    command.Parameters.Add("@user_activity_note",SqlDbType.NVarChar).Value = (System.String)UserActivityNote;
                    command.Parameters.Add("@originating_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(OriginatingAddress)) ? (object)DBNull.Value : (System.String)OriginatingAddress;
                    command.Parameters.Add("@referrer",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Referrer)) ? (object)DBNull.Value : (System.String)Referrer;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against default_user_activity
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

            if (DefaultUserActivityId == Guid.Empty)
                DefaultUserActivityId = Guid.NewGuid();

            // create query against default_user_activity
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [default_user_activity] (default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time)";
            sql += "            values (@default_user_activity_id, @default_user_activity_type_rcd, @user_activity_note, @originating_address, @referrer, @default_user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to insert as parameter(s)
                // the insert column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@default_user_activity_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserActivityId;
                command.Parameters.Add("@default_user_activity_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeRcd;
                command.Parameters.Add("@user_activity_note",SqlDbType.NVarChar).Value = (System.String)UserActivityNote;
                command.Parameters.Add("@originating_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(OriginatingAddress)) ? (object)DBNull.Value : (System.String)OriginatingAddress;
                command.Parameters.Add("@referrer",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Referrer)) ? (object)DBNull.Value : (System.String)Referrer;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against default_user_activity
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            // create query against default_user_activity
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [default_user_activity] set
                 default_user_activity_id = @default_user_activity_id
                ,default_user_activity_type_rcd = @default_user_activity_type_rcd
                ,user_activity_note = @user_activity_note
                ,originating_address = @originating_address
                ,referrer = @referrer
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_user_activity_id = @default_user_activity_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // add column(s) to update as parameter(s)
                    // the update column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_user_activity_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserActivityId;
                    command.Parameters.Add("@default_user_activity_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeRcd;
                    command.Parameters.Add("@user_activity_note",SqlDbType.NVarChar).Value = (System.String)UserActivityNote;
                    command.Parameters.Add("@originating_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(OriginatingAddress)) ? (object)DBNull.Value : (System.String)OriginatingAddress;
                    command.Parameters.Add("@referrer",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Referrer)) ? (object)DBNull.Value : (System.String)Referrer;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against default_user_activity
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            // create query against default_user_activity
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [default_user_activity] set
                 default_user_activity_id = @default_user_activity_id
                ,default_user_activity_type_rcd = @default_user_activity_type_rcd
                ,user_activity_note = @user_activity_note
                ,originating_address = @originating_address
                ,referrer = @referrer
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_user_activity_id = @default_user_activity_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to update as parameter
                // the update column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@default_user_activity_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserActivityId;
                command.Parameters.Add("@default_user_activity_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeRcd;
                command.Parameters.Add("@user_activity_note",SqlDbType.NVarChar).Value = (System.String)UserActivityNote;
                command.Parameters.Add("@originating_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(OriginatingAddress)) ? (object)DBNull.Value : (System.String)OriginatingAddress;
                command.Parameters.Add("@referrer",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Referrer)) ? (object)DBNull.Value : (System.String)Referrer;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against default_user_activity
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid defaultUserActivityId) {
            // create query against default_user_activity
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" delete [default_user_activity] 
                where default_user_activity_id = @default_user_activity_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_user_activity_id",SqlDbType.UniqueIdentifier).Value = defaultUserActivityId;
                    // execute query against default_user_activity
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
