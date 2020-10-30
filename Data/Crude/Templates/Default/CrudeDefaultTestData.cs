/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 7:41:37 AM
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
    // this class start with an identical representation of default_test's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeDefaultTestData {
        
        public System.Guid DefaultTestId { get; set; }
        
        public string SystemName { get; set; }
        
        public string TestArea { get; set; }
        
        public string TestSubArea { get; set; }
        
        public string TestAddress { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultTestId: primary key of table default_test
        public void FetchByDefaultTestId(System.Guid defaultTestId) {
            // create query against default_test
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            where default_test_id = @default_test_id
                            order by system_name";

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
                    command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = defaultTestId;

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
        //   defaultTestId: primary key of table default_test
        public static CrudeDefaultTestData GetByDefaultTestId(System.Guid defaultTestId) {
            // create query against default_test
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            where default_test_id = @default_test_id
                            order by system_name";

            var ret = new CrudeDefaultTestData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = defaultTestId;

                    // execute query against default_test
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
        public static List<CrudeDefaultTestData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeDefaultTestData>();

            // create query against default_test
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            where user_id = @user_id
                              
                            order by system_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    // execute query against default_test
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_test
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultTestData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Picker Member into new class instance
        public void FetchBySystemName(string systemName) {
            // create query against default_test
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            where system_name like '%' + @systemName + '%'
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                    // add search column
                    // this search column will be used together with the prepared ansi sql statement
                command.Parameters.Add("@systemName",SqlDbType.NVarChar).Value = systemName;

                // execute query against default_test
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        // fetch all rows from table default_test into new List of class instances
        public static List<CrudeDefaultTestData> FetchAll() {
            var dataList = new List<CrudeDefaultTestData>();

            // create query against default_test
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            order by system_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_test
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_test
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultTestData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeDefaultTestData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultTestData>();

            // create query against default_test
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top " + limit.ToString() + @" default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            order by system_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_test
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_test
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultTestData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeDefaultTestData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultTestData>();

            // create query against default_test
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            order by system_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_test
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    // read all rows returned from the query of default_test
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultTestData();
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
            // create query against default_test
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select count(*) as count from [default_test]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    // execute query against default_test
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
        public static List<CrudeDefaultTestData> FetchWithFilter(System.Guid defaultTestId, string systemName, string testArea, string testSubArea, string testAddress, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultTestData>();

            // create query against default_test
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
                    if (defaultTestId != Guid.Empty) {
                        sql += "  and default_test_id = @default_test_id";
                        command.Parameters.Add("@default_test_id", SqlDbType.UniqueIdentifier).Value = defaultTestId;
                    }
                    if (!string.IsNullOrEmpty(systemName)) {
                        sql += "  and system_name like '%' + @system_name + '%'";
                        command.Parameters.Add("@system_name", SqlDbType.NVarChar).Value = systemName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(testArea)) {
                        sql += "  and test_area like '%' + @test_area + '%'";
                        command.Parameters.Add("@test_area", SqlDbType.NVarChar).Value = testArea.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(testSubArea)) {
                        sql += "  and test_sub_area like '%' + @test_sub_area + '%'";
                        command.Parameters.Add("@test_sub_area", SqlDbType.NVarChar).Value = testSubArea.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(testAddress)) {
                        sql += "  and test_address like '%' + @test_address + '%'";
                        command.Parameters.Add("@test_address", SqlDbType.NVarChar).Value = testAddress.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by system_name";

                    command.CommandText = sql;

                    // execute query against default_test
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_test
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultTestData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["default_test_id"] != System.DBNull.Value) DefaultTestId = (System.Guid) reader["default_test_id"];
            if (reader["system_name"] != System.DBNull.Value) SystemName = (System.String) reader["system_name"];
            if (reader["test_area"] != System.DBNull.Value) TestArea = (System.String) reader["test_area"];
            if (reader["test_sub_area"] != System.DBNull.Value) TestSubArea = (System.String) reader["test_sub_area"];
            if (reader["test_address"] != System.DBNull.Value) TestAddress = (System.String) reader["test_address"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (DefaultTestId == Guid.Empty)
                DefaultTestId = Guid.NewGuid();

            // create query against default_test
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [default_test] (default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time)";
            sql += "            values (@default_test_id, @system_name, @test_area, @test_sub_area, @test_address, @user_id, @date_time)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    // add column(s) to insert as parameter
                    // the insert column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                    command.Parameters.Add("@system_name",SqlDbType.NVarChar).Value = (System.String)SystemName;
                    command.Parameters.Add("@test_area",SqlDbType.NVarChar).Value = (System.String)TestArea;
                    command.Parameters.Add("@test_sub_area",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestSubArea)) ? (object)DBNull.Value : (System.String)TestSubArea;
                    command.Parameters.Add("@test_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestAddress)) ? (object)DBNull.Value : (System.String)TestAddress;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against default_test
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

            if (DefaultTestId == Guid.Empty)
                DefaultTestId = Guid.NewGuid();

            // create query against default_test
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [default_test] (default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time)";
            sql += "            values (@default_test_id, @system_name, @test_area, @test_sub_area, @test_address, @user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to insert as parameter(s)
                // the insert column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                command.Parameters.Add("@system_name",SqlDbType.NVarChar).Value = (System.String)SystemName;
                command.Parameters.Add("@test_area",SqlDbType.NVarChar).Value = (System.String)TestArea;
                command.Parameters.Add("@test_sub_area",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestSubArea)) ? (object)DBNull.Value : (System.String)TestSubArea;
                command.Parameters.Add("@test_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestAddress)) ? (object)DBNull.Value : (System.String)TestAddress;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against default_test
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            // create query against default_test
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [default_test] set
                 default_test_id = @default_test_id
                ,system_name = @system_name
                ,test_area = @test_area
                ,test_sub_area = @test_sub_area
                ,test_address = @test_address
                ,user_id = @user_id
                ,date_time = @date_time
            where default_test_id = @default_test_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // add column(s) to update as parameter(s)
                    // the update column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                    command.Parameters.Add("@system_name",SqlDbType.NVarChar).Value = (System.String)SystemName;
                    command.Parameters.Add("@test_area",SqlDbType.NVarChar).Value = (System.String)TestArea;
                    command.Parameters.Add("@test_sub_area",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestSubArea)) ? (object)DBNull.Value : (System.String)TestSubArea;
                    command.Parameters.Add("@test_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestAddress)) ? (object)DBNull.Value : (System.String)TestAddress;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against default_test
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            // create query against default_test
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [default_test] set
                 default_test_id = @default_test_id
                ,system_name = @system_name
                ,test_area = @test_area
                ,test_sub_area = @test_sub_area
                ,test_address = @test_address
                ,user_id = @user_id
                ,date_time = @date_time
            where default_test_id = @default_test_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to update as parameter
                // the update column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                command.Parameters.Add("@system_name",SqlDbType.NVarChar).Value = (System.String)SystemName;
                command.Parameters.Add("@test_area",SqlDbType.NVarChar).Value = (System.String)TestArea;
                command.Parameters.Add("@test_sub_area",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestSubArea)) ? (object)DBNull.Value : (System.String)TestSubArea;
                command.Parameters.Add("@test_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestAddress)) ? (object)DBNull.Value : (System.String)TestAddress;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against default_test
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid defaultTestId) {
            // create query against default_test
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" delete [default_test] 
                where default_test_id = @default_test_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = defaultTestId;
                    // execute query against default_test
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
