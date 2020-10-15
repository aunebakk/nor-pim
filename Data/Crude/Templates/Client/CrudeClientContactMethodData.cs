/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 6:14:57 PM
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
    // this class start with an identical representation of client_contact_method's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeClientContactMethodData {
        
        public System.Guid ClientContactMethodId { get; set; }
        
        public System.Guid ClientId { get; set; }
        
        public string ClientContactMethodRcd { get; set; }
        
        public string ContactMethodWay { get; set; }
        
        public string Comment { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientContactMethodId: primary key of table client_contact_method
        public void FetchByClientContactMethodId(System.Guid clientContactMethodId) {
            // create query against client_contact_method
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]
                            where client_contact_method_id = @client_contact_method_id";

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
                    command.Parameters.Add("@client_contact_method_id",SqlDbType.UniqueIdentifier).Value = clientContactMethodId;

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
        //   clientContactMethodId: primary key of table client_contact_method
        public static CrudeClientContactMethodData GetByClientContactMethodId(System.Guid clientContactMethodId) {
            // create query against client_contact_method
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]
                            where client_contact_method_id = @client_contact_method_id";

            var ret = new CrudeClientContactMethodData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_contact_method_id",SqlDbType.UniqueIdentifier).Value = clientContactMethodId;

                    // execute query against client_contact_method
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
        public static List<CrudeClientContactMethodData> FetchByClientId(System.Guid clientId) {
            var dataList = new List<CrudeClientContactMethodData>();

            // create query against client_contact_method
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]
                            where client_id = @client_id
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;

                    // execute query against client_contact_method
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_contact_method
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientContactMethodData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientContactMethodData>();

            // create query against client_contact_method
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]
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

                    // execute query against client_contact_method
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_contact_method
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientContactMethodData> FetchByClientContactMethodRcd(string clientContactMethodRcd) {
            var dataList = new List<CrudeClientContactMethodData>();

            // create query against client_contact_method
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]
                            where client_contact_method_rcd = @client_contact_method_rcd
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_contact_method_rcd", SqlDbType.NVarChar).Value = clientContactMethodRcd.Replace("'","''");

                    // execute query against client_contact_method
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_contact_method
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all rows from table client_contact_method into new List of class instances
        public static List<CrudeClientContactMethodData> FetchAll() {
            var dataList = new List<CrudeClientContactMethodData>();

            // create query against client_contact_method
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against client_contact_method
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_contact_method
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeClientContactMethodData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientContactMethodData>();

            // create query against client_contact_method
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top " + limit.ToString() + @" client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against client_contact_method
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_contact_method
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeClientContactMethodData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientContactMethodData>();

            // create query against client_contact_method
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against client_contact_method
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    // read all rows returned from the query of client_contact_method
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeClientContactMethodData();
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
            // create query against client_contact_method
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select count(*) as count from [client_contact_method]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    // execute query against client_contact_method
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
        public static List<CrudeClientContactMethodData> FetchWithFilter(System.Guid clientContactMethodId, System.Guid clientId, string clientContactMethodRcd, string contactMethodWay, string comment, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeClientContactMethodData>();

            // create query against client_contact_method
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
                    if (clientContactMethodId != Guid.Empty) {
                        sql += "  and client_contact_method_id = @client_contact_method_id";
                        command.Parameters.Add("@client_contact_method_id", SqlDbType.UniqueIdentifier).Value = clientContactMethodId;
                    }
                    if (clientId != Guid.Empty) {
                        sql += "  and client_id = @client_id";
                        command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;
                    }
                    if (!string.IsNullOrEmpty(clientContactMethodRcd)) {
                        sql += "  and client_contact_method_rcd like '%' + @client_contact_method_rcd + '%'";
                        command.Parameters.Add("@client_contact_method_rcd", SqlDbType.NVarChar).Value = clientContactMethodRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(contactMethodWay)) {
                        sql += "  and contact_method_way like '%' + @contact_method_way + '%'";
                        command.Parameters.Add("@contact_method_way", SqlDbType.NVarChar).Value = contactMethodWay.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(comment)) {
                        sql += "  and comment like '%' + @comment + '%'";
                        command.Parameters.Add("@comment", SqlDbType.NVarChar).Value = comment.Replace("'","''");
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

                    // execute query against client_contact_method
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_contact_method
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["client_contact_method_id"] != System.DBNull.Value) ClientContactMethodId = (System.Guid) reader["client_contact_method_id"];
            if (reader["client_id"] != System.DBNull.Value) ClientId = (System.Guid) reader["client_id"];
            if (reader["client_contact_method_rcd"] != System.DBNull.Value) ClientContactMethodRcd = (System.String) reader["client_contact_method_rcd"];
            if (reader["contact_method_way"] != System.DBNull.Value) ContactMethodWay = (System.String) reader["contact_method_way"];
            if (reader["comment"] != System.DBNull.Value) Comment = (System.String) reader["comment"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (ClientContactMethodId == Guid.Empty)
                ClientContactMethodId = Guid.NewGuid();

            // create query against client_contact_method
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [client_contact_method] (client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time)";
            sql += "            values (@client_contact_method_id, @client_id, @client_contact_method_rcd, @contact_method_way, @comment, @user_id, @date_time)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    // add column(s) to insert as parameter
                    // the insert column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_contact_method_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientContactMethodId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodRcd;
                    command.Parameters.Add("@contact_method_way",SqlDbType.NVarChar).Value = (System.String)ContactMethodWay;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (System.String)Comment;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against client_contact_method
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

            if (ClientContactMethodId == Guid.Empty)
                ClientContactMethodId = Guid.NewGuid();

            // create query against client_contact_method
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [client_contact_method] (client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time)";
            sql += "            values (@client_contact_method_id, @client_id, @client_contact_method_rcd, @contact_method_way, @comment, @user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to insert as parameter(s)
                // the insert column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@client_contact_method_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientContactMethodId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodRcd;
                command.Parameters.Add("@contact_method_way",SqlDbType.NVarChar).Value = (System.String)ContactMethodWay;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (System.String)Comment;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against client_contact_method
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            // create query against client_contact_method
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [client_contact_method] set
                 client_contact_method_id = @client_contact_method_id
                ,client_id = @client_id
                ,client_contact_method_rcd = @client_contact_method_rcd
                ,contact_method_way = @contact_method_way
                ,comment = @comment
                ,user_id = @user_id
                ,date_time = @date_time
            where client_contact_method_id = @client_contact_method_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // add column(s) to update as parameter(s)
                    // the update column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_contact_method_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientContactMethodId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodRcd;
                    command.Parameters.Add("@contact_method_way",SqlDbType.NVarChar).Value = (System.String)ContactMethodWay;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (System.String)Comment;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against client_contact_method
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            // create query against client_contact_method
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [client_contact_method] set
                 client_contact_method_id = @client_contact_method_id
                ,client_id = @client_id
                ,client_contact_method_rcd = @client_contact_method_rcd
                ,contact_method_way = @contact_method_way
                ,comment = @comment
                ,user_id = @user_id
                ,date_time = @date_time
            where client_contact_method_id = @client_contact_method_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to update as parameter
                // the update column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@client_contact_method_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientContactMethodId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodRcd;
                command.Parameters.Add("@contact_method_way",SqlDbType.NVarChar).Value = (System.String)ContactMethodWay;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (System.String)Comment;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against client_contact_method
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid clientContactMethodId) {
            // create query against client_contact_method
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" delete [client_contact_method] 
                where client_contact_method_id = @client_contact_method_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_contact_method_id",SqlDbType.UniqueIdentifier).Value = clientContactMethodId;
                    // execute query against client_contact_method
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
