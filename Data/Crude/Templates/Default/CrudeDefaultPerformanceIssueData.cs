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
    // this class start with an identical representation of default_performance_issue's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeDefaultPerformanceIssueData {
        
        public System.Guid DefaultPerformanceIssueId { get; set; }
        
        public string CommandName { get; set; }
        
        public string CommandText { get; set; }
        
        public int Milliseconds { get; set; }
        
        public System.Guid DefaultUserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultPerformanceIssueId: primary key of table default_performance_issue
        public void FetchByDefaultPerformanceIssueId(System.Guid defaultPerformanceIssueId) {
            // create query against default_performance_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            where default_performance_issue_id = @default_performance_issue_id
                            order by command_name";

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
                    command.Parameters.Add("@default_performance_issue_id",SqlDbType.UniqueIdentifier).Value = defaultPerformanceIssueId;

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
        //   defaultPerformanceIssueId: primary key of table default_performance_issue
        public static CrudeDefaultPerformanceIssueData GetByDefaultPerformanceIssueId(System.Guid defaultPerformanceIssueId) {
            // create query against default_performance_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            where default_performance_issue_id = @default_performance_issue_id
                            order by command_name";

            var ret = new CrudeDefaultPerformanceIssueData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_performance_issue_id",SqlDbType.UniqueIdentifier).Value = defaultPerformanceIssueId;

                    // execute query against default_performance_issue
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
        public static List<CrudeDefaultPerformanceIssueData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultPerformanceIssueData>();

            // create query against default_performance_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            where default_user_id = @default_user_id
                              
                            order by command_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    // execute query against default_performance_issue
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_performance_issue
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultPerformanceIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Picker Member into new class instance
        public void FetchByCommandName(string commandName) {
            // create query against default_performance_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            where command_name like '%' + @commandName + '%'
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                    // add search column
                    // this search column will be used together with the prepared ansi sql statement
                command.Parameters.Add("@commandName",SqlDbType.NVarChar).Value = commandName;

                // execute query against default_performance_issue
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        // fetch all rows from table default_performance_issue into new List of class instances
        public static List<CrudeDefaultPerformanceIssueData> FetchAll() {
            var dataList = new List<CrudeDefaultPerformanceIssueData>();

            // create query against default_performance_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            order by command_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_performance_issue
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_performance_issue
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultPerformanceIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeDefaultPerformanceIssueData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultPerformanceIssueData>();

            // create query against default_performance_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top " + limit.ToString() + @" default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            order by command_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_performance_issue
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_performance_issue
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultPerformanceIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeDefaultPerformanceIssueData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultPerformanceIssueData>();

            // create query against default_performance_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            order by command_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_performance_issue
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    // read all rows returned from the query of default_performance_issue
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultPerformanceIssueData();
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
            // create query against default_performance_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select count(*) as count from [default_performance_issue]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    // execute query against default_performance_issue
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
        public static List<CrudeDefaultPerformanceIssueData> FetchWithFilter(System.Guid defaultPerformanceIssueId, string commandName, string commandText, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultPerformanceIssueData>();

            // create query against default_performance_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
                    if (defaultPerformanceIssueId != Guid.Empty) {
                        sql += "  and default_performance_issue_id = @default_performance_issue_id";
                        command.Parameters.Add("@default_performance_issue_id", SqlDbType.UniqueIdentifier).Value = defaultPerformanceIssueId;
                    }
                    if (!string.IsNullOrEmpty(commandName)) {
                        sql += "  and command_name like '%' + @command_name + '%'";
                        command.Parameters.Add("@command_name", SqlDbType.NVarChar).Value = commandName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(commandText)) {
                        sql += "  and command_text like '%' + @command_text + '%'";
                        command.Parameters.Add("@command_text", SqlDbType.NVarChar).Value = commandText.Replace("'","''");
                    }
                    if (milliseconds != 0) {
                        sql += "  and milliseconds = @milliseconds";
                        command.Parameters.Add("@milliseconds", SqlDbType.Int).Value = milliseconds;
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by command_name";

                    command.CommandText = sql;

                    // execute query against default_performance_issue
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_performance_issue
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultPerformanceIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["default_performance_issue_id"] != System.DBNull.Value) DefaultPerformanceIssueId = (System.Guid) reader["default_performance_issue_id"];
            if (reader["command_name"] != System.DBNull.Value) CommandName = (System.String) reader["command_name"];
            if (reader["command_text"] != System.DBNull.Value) CommandText = (System.String) reader["command_text"];
            if (reader["milliseconds"] != System.DBNull.Value) Milliseconds = (System.Int32) reader["milliseconds"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (DefaultPerformanceIssueId == Guid.Empty)
                DefaultPerformanceIssueId = Guid.NewGuid();

            // create query against default_performance_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [default_performance_issue] (default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time)";
            sql += "            values (@default_performance_issue_id, @command_name, @command_text, @milliseconds, @default_user_id, @date_time)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    // add column(s) to insert as parameter
                    // the insert column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_performance_issue_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultPerformanceIssueId;
                    command.Parameters.Add("@command_name",SqlDbType.NVarChar).Value = (System.String)CommandName;
                    command.Parameters.Add("@command_text",SqlDbType.NVarChar).Value = (System.String)CommandText;
                    command.Parameters.Add("@milliseconds",SqlDbType.Int).Value = (System.Int32)Milliseconds;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against default_performance_issue
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

            if (DefaultPerformanceIssueId == Guid.Empty)
                DefaultPerformanceIssueId = Guid.NewGuid();

            // create query against default_performance_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [default_performance_issue] (default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time)";
            sql += "            values (@default_performance_issue_id, @command_name, @command_text, @milliseconds, @default_user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to insert as parameter(s)
                // the insert column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@default_performance_issue_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultPerformanceIssueId;
                command.Parameters.Add("@command_name",SqlDbType.NVarChar).Value = (System.String)CommandName;
                command.Parameters.Add("@command_text",SqlDbType.NVarChar).Value = (System.String)CommandText;
                command.Parameters.Add("@milliseconds",SqlDbType.Int).Value = (System.Int32)Milliseconds;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against default_performance_issue
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            // create query against default_performance_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [default_performance_issue] set
                 default_performance_issue_id = @default_performance_issue_id
                ,command_name = @command_name
                ,command_text = @command_text
                ,milliseconds = @milliseconds
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_performance_issue_id = @default_performance_issue_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // add column(s) to update as parameter(s)
                    // the update column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_performance_issue_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultPerformanceIssueId;
                    command.Parameters.Add("@command_name",SqlDbType.NVarChar).Value = (System.String)CommandName;
                    command.Parameters.Add("@command_text",SqlDbType.NVarChar).Value = (System.String)CommandText;
                    command.Parameters.Add("@milliseconds",SqlDbType.Int).Value = (System.Int32)Milliseconds;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against default_performance_issue
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            // create query against default_performance_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [default_performance_issue] set
                 default_performance_issue_id = @default_performance_issue_id
                ,command_name = @command_name
                ,command_text = @command_text
                ,milliseconds = @milliseconds
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_performance_issue_id = @default_performance_issue_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to update as parameter
                // the update column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@default_performance_issue_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultPerformanceIssueId;
                command.Parameters.Add("@command_name",SqlDbType.NVarChar).Value = (System.String)CommandName;
                command.Parameters.Add("@command_text",SqlDbType.NVarChar).Value = (System.String)CommandText;
                command.Parameters.Add("@milliseconds",SqlDbType.Int).Value = (System.Int32)Milliseconds;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against default_performance_issue
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid defaultPerformanceIssueId) {
            // create query against default_performance_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" delete [default_performance_issue] 
                where default_performance_issue_id = @default_performance_issue_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_performance_issue_id",SqlDbType.UniqueIdentifier).Value = defaultPerformanceIssueId;
                    // execute query against default_performance_issue
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
