/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 3:39:45 PM
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
    // this class start with an identical representation of default_test_run's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeDefaultTestRunData {
        
        public System.Guid DefaultTestRunId { get; set; }
        
        public System.Guid DefaultTestId { get; set; }
        
        public string DefaultTestRunResultRcd { get; set; }
        
        public string Result { get; set; }
        
        public System.DateTime StartDateTime { get; set; }
        
        public System.DateTime EndDateTime { get; set; }
        
        public int ElapsedMilliseconds { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultTestRunId: primary key of table default_test_run
        public void FetchByDefaultTestRunId(System.Guid defaultTestRunId) {
            // create query against default_test_run
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]
                            where default_test_run_id = @default_test_run_id";

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
                    command.Parameters.Add("@default_test_run_id",SqlDbType.UniqueIdentifier).Value = defaultTestRunId;

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
        //   defaultTestRunId: primary key of table default_test_run
        public static CrudeDefaultTestRunData GetByDefaultTestRunId(System.Guid defaultTestRunId) {
            // create query against default_test_run
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]
                            where default_test_run_id = @default_test_run_id";

            var ret = new CrudeDefaultTestRunData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_test_run_id",SqlDbType.UniqueIdentifier).Value = defaultTestRunId;

                    // execute query against default_test_run
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
        public static List<CrudeDefaultTestRunData> FetchByDefaultTestId(System.Guid defaultTestId) {
            var dataList = new List<CrudeDefaultTestRunData>();

            // create query against default_test_run
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]
                            where default_test_id = @default_test_id
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_test_id", SqlDbType.UniqueIdentifier).Value = defaultTestId;

                    // execute query against default_test_run
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_test_run
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeDefaultTestRunData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeDefaultTestRunData>();

            // create query against default_test_run
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]
                            where user_id = @user_id
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    // execute query against default_test_run
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_test_run
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeDefaultTestRunData> FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd) {
            var dataList = new List<CrudeDefaultTestRunData>();

            // create query against default_test_run
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]
                            where default_test_run_result_rcd = @default_test_run_result_rcd
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_test_run_result_rcd", SqlDbType.NVarChar).Value = defaultTestRunResultRcd.Replace("'","''");

                    // execute query against default_test_run
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_test_run
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all rows from table default_test_run into new List of class instances
        public static List<CrudeDefaultTestRunData> FetchAll() {
            var dataList = new List<CrudeDefaultTestRunData>();

            // create query against default_test_run
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_test_run
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_test_run
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeDefaultTestRunData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultTestRunData>();

            // create query against default_test_run
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top " + limit.ToString() + @" default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_test_run
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_test_run
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeDefaultTestRunData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultTestRunData>();

            // create query against default_test_run
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_test_run
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    // read all rows returned from the query of default_test_run
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultTestRunData();
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
            // create query against default_test_run
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select count(*) as count from [default_test_run]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    // execute query against default_test_run
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
        public static List<CrudeDefaultTestRunData> FetchWithFilter(System.Guid defaultTestRunId, System.Guid defaultTestId, string defaultTestRunResultRcd, string result, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultTestRunData>();

            // create query against default_test_run
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
                    if (defaultTestRunId != Guid.Empty) {
                        sql += "  and default_test_run_id = @default_test_run_id";
                        command.Parameters.Add("@default_test_run_id", SqlDbType.UniqueIdentifier).Value = defaultTestRunId;
                    }
                    if (defaultTestId != Guid.Empty) {
                        sql += "  and default_test_id = @default_test_id";
                        command.Parameters.Add("@default_test_id", SqlDbType.UniqueIdentifier).Value = defaultTestId;
                    }
                    if (!string.IsNullOrEmpty(defaultTestRunResultRcd)) {
                        sql += "  and default_test_run_result_rcd like '%' + @default_test_run_result_rcd + '%'";
                        command.Parameters.Add("@default_test_run_result_rcd", SqlDbType.NVarChar).Value = defaultTestRunResultRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(result)) {
                        sql += "  and result like '%' + @result + '%'";
                        command.Parameters.Add("@result", SqlDbType.NVarChar).Value = result.Replace("'","''");
                    }
                    if (startDateTime != DateTime.MinValue) {
                        sql += "  and start_date_time = @start_date_time";
                        command.Parameters.Add("@start_date_time", SqlDbType.DateTime).Value = startDateTime;
                    }
                    if (endDateTime != DateTime.MinValue) {
                        sql += "  and end_date_time = @end_date_time";
                        command.Parameters.Add("@end_date_time", SqlDbType.DateTime).Value = endDateTime;
                    }
                    if (elapsedMilliseconds != 0) {
                        sql += "  and elapsed_milliseconds = @elapsed_milliseconds";
                        command.Parameters.Add("@elapsed_milliseconds", SqlDbType.Int).Value = elapsedMilliseconds;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    command.CommandText = sql;

                    // execute query against default_test_run
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_test_run
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["default_test_run_id"] != System.DBNull.Value) DefaultTestRunId = (System.Guid) reader["default_test_run_id"];
            if (reader["default_test_id"] != System.DBNull.Value) DefaultTestId = (System.Guid) reader["default_test_id"];
            if (reader["default_test_run_result_rcd"] != System.DBNull.Value) DefaultTestRunResultRcd = (System.String) reader["default_test_run_result_rcd"];
            if (reader["result"] != System.DBNull.Value) Result = (System.String) reader["result"];
            if (reader["start_date_time"] != System.DBNull.Value) StartDateTime = (System.DateTime) reader["start_date_time"];
            if (reader["end_date_time"] != System.DBNull.Value) EndDateTime = (System.DateTime) reader["end_date_time"];
            if (reader["elapsed_milliseconds"] != System.DBNull.Value) ElapsedMilliseconds = (System.Int32) reader["elapsed_milliseconds"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (DefaultTestRunId == Guid.Empty)
                DefaultTestRunId = Guid.NewGuid();

            // create query against default_test_run
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [default_test_run] (default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time)";
            sql += "            values (@default_test_run_id, @default_test_id, @default_test_run_result_rcd, @result, @start_date_time, @end_date_time, @elapsed_milliseconds, @user_id, @date_time)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    // add column(s) to insert as parameter
                    // the insert column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_test_run_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestRunId;
                    command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                    command.Parameters.Add("@default_test_run_result_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultRcd;
                    command.Parameters.Add("@result",SqlDbType.NVarChar).Value = (System.String)Result;
                    command.Parameters.Add("@start_date_time",SqlDbType.DateTime).Value = (System.DateTime)StartDateTime;
                    command.Parameters.Add("@end_date_time",SqlDbType.DateTime).Value = (System.DateTime)EndDateTime;
                    command.Parameters.Add("@elapsed_milliseconds",SqlDbType.Int).Value = (System.Int32)ElapsedMilliseconds;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against default_test_run
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

            if (DefaultTestRunId == Guid.Empty)
                DefaultTestRunId = Guid.NewGuid();

            // create query against default_test_run
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [default_test_run] (default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time)";
            sql += "            values (@default_test_run_id, @default_test_id, @default_test_run_result_rcd, @result, @start_date_time, @end_date_time, @elapsed_milliseconds, @user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to insert as parameter(s)
                // the insert column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@default_test_run_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestRunId;
                command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                command.Parameters.Add("@default_test_run_result_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultRcd;
                command.Parameters.Add("@result",SqlDbType.NVarChar).Value = (System.String)Result;
                command.Parameters.Add("@start_date_time",SqlDbType.DateTime).Value = (System.DateTime)StartDateTime;
                command.Parameters.Add("@end_date_time",SqlDbType.DateTime).Value = (System.DateTime)EndDateTime;
                command.Parameters.Add("@elapsed_milliseconds",SqlDbType.Int).Value = (System.Int32)ElapsedMilliseconds;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against default_test_run
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            // create query against default_test_run
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [default_test_run] set
                 default_test_run_id = @default_test_run_id
                ,default_test_id = @default_test_id
                ,default_test_run_result_rcd = @default_test_run_result_rcd
                ,result = @result
                ,start_date_time = @start_date_time
                ,end_date_time = @end_date_time
                ,elapsed_milliseconds = @elapsed_milliseconds
                ,user_id = @user_id
                ,date_time = @date_time
            where default_test_run_id = @default_test_run_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // add column(s) to update as parameter(s)
                    // the update column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_test_run_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestRunId;
                    command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                    command.Parameters.Add("@default_test_run_result_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultRcd;
                    command.Parameters.Add("@result",SqlDbType.NVarChar).Value = (System.String)Result;
                    command.Parameters.Add("@start_date_time",SqlDbType.DateTime).Value = (System.DateTime)StartDateTime;
                    command.Parameters.Add("@end_date_time",SqlDbType.DateTime).Value = (System.DateTime)EndDateTime;
                    command.Parameters.Add("@elapsed_milliseconds",SqlDbType.Int).Value = (System.Int32)ElapsedMilliseconds;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against default_test_run
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            // create query against default_test_run
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [default_test_run] set
                 default_test_run_id = @default_test_run_id
                ,default_test_id = @default_test_id
                ,default_test_run_result_rcd = @default_test_run_result_rcd
                ,result = @result
                ,start_date_time = @start_date_time
                ,end_date_time = @end_date_time
                ,elapsed_milliseconds = @elapsed_milliseconds
                ,user_id = @user_id
                ,date_time = @date_time
            where default_test_run_id = @default_test_run_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to update as parameter
                // the update column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@default_test_run_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestRunId;
                command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                command.Parameters.Add("@default_test_run_result_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultRcd;
                command.Parameters.Add("@result",SqlDbType.NVarChar).Value = (System.String)Result;
                command.Parameters.Add("@start_date_time",SqlDbType.DateTime).Value = (System.DateTime)StartDateTime;
                command.Parameters.Add("@end_date_time",SqlDbType.DateTime).Value = (System.DateTime)EndDateTime;
                command.Parameters.Add("@elapsed_milliseconds",SqlDbType.Int).Value = (System.Int32)ElapsedMilliseconds;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against default_test_run
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid defaultTestRunId) {
            // create query against default_test_run
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" delete [default_test_run] 
                where default_test_run_id = @default_test_run_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_test_run_id",SqlDbType.UniqueIdentifier).Value = defaultTestRunId;
                    // execute query against default_test_run
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
