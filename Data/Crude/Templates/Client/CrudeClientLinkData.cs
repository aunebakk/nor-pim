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

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of client_link's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeClientLinkData {
        
        public System.Guid ClientLinkId { get; set; }
        
        public System.Guid ClientId { get; set; }
        
        public string ClientLinkTypeRcd { get; set; }
        
        public string LinkName { get; set; }
        
        public string Link { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientLinkId: primary key of table client_link
        public void FetchByClientLinkId(System.Guid clientLinkId) {
            // create query against client_link
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 client_link_id, client_id, client_link_type_rcd, link_name, link, user_id, date_time
                            from [client_link]
                            where client_link_id = @client_link_id
                            order by link_name";

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
                    command.Parameters.Add("@client_link_id",SqlDbType.UniqueIdentifier).Value = clientLinkId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        // fetch by Primary key into new class instance
        public static CrudeClientLinkData GetByClientLinkId(System.Guid clientLinkId) {
            string sql = @" select top 1 client_link_id, client_id, client_link_type_rcd, link_name, link, user_id, date_time
                            from [client_link]
                            where client_link_id = @client_link_id
                            order by link_name";

            var ret = new CrudeClientLinkData();

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_link_id",SqlDbType.UniqueIdentifier).Value = clientLinkId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serialized class if row was found
                    if (reader.Read())
                        ret.Populate(reader);
                }
            }

            return ret;
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientLinkData> FetchByClientId(System.Guid clientId) {
            var dataList = new List<CrudeClientLinkData>();

            string sql = @" select client_link_id, client_id, client_link_type_rcd, link_name, link, user_id, date_time
                            from [client_link]
                            where client_id = @client_id
                              
                            order by link_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientLinkData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientLinkData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientLinkData>();

            string sql = @" select client_link_id, client_id, client_link_type_rcd, link_name, link, user_id, date_time
                            from [client_link]
                            where user_id = @user_id
                              
                            order by link_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientLinkData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientLinkData> FetchByClientLinkTypeRcd(string clientLinkTypeRcd) {
            var dataList = new List<CrudeClientLinkData>();

            string sql = @" select client_link_id, client_id, client_link_type_rcd, link_name, link, user_id, date_time
                            from [client_link]
                            where client_link_type_rcd = @client_link_type_rcd
                              
                            order by link_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_link_type_rcd", SqlDbType.NVarChar).Value = clientLinkTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientLinkData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Picker Member into new class instance
        public void FetchByLinkName(string linkName) {
            string sql = @" select top 1 client_link_id, client_id, client_link_type_rcd, link_name, link, user_id, date_time
                            from [client_link]
                            where link_name like '%' + @linkName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@linkName",SqlDbType.NVarChar).Value = linkName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        // fetch all from table into new List of class instances
        public static List<CrudeClientLinkData> FetchAll() {
            var dataList = new List<CrudeClientLinkData>();

            string sql = @" select client_link_id, client_id, client_link_type_rcd, link_name, link, user_id, date_time
                            from [client_link]
                            order by link_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientLinkData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeClientLinkData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientLinkData>();

            string sql = @" select top " + limit.ToString() + @" client_link_id, client_id, client_link_type_rcd, link_name, link, user_id, date_time
                            from [client_link]
                            order by link_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientLinkData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns , with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeClientLinkData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientLinkData>();

            string sql = @" select client_link_id, client_id, client_link_type_rcd, link_name, link, user_id, date_time
                            from [client_link]
                            order by link_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeClientLinkData();
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
            string sql = @" select count(*) as count from [client_link]";

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
        public static List<CrudeClientLinkData> FetchWithFilter(System.Guid clientLinkId, System.Guid clientId, string clientLinkTypeRcd, string linkName, string link, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeClientLinkData>();

            string sql = @" select client_link_id, client_id, client_link_type_rcd, link_name, link, user_id, date_time
                            from [client_link]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (clientLinkId != Guid.Empty) {
                        sql += "  and client_link_id = @client_link_id";
                        command.Parameters.Add("@client_link_id", SqlDbType.UniqueIdentifier).Value = clientLinkId;
                    }
                    if (clientId != Guid.Empty) {
                        sql += "  and client_id = @client_id";
                        command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;
                    }
                    if (!string.IsNullOrEmpty(clientLinkTypeRcd)) {
                        sql += "  and client_link_type_rcd like '%' + @client_link_type_rcd + '%'";
                        command.Parameters.Add("@client_link_type_rcd", SqlDbType.NVarChar).Value = clientLinkTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(linkName)) {
                        sql += "  and link_name like '%' + @link_name + '%'";
                        command.Parameters.Add("@link_name", SqlDbType.NVarChar).Value = linkName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(link)) {
                        sql += "  and link like '%' + @link + '%'";
                        command.Parameters.Add("@link", SqlDbType.NVarChar).Value = link.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by link_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientLinkData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["client_link_id"] != System.DBNull.Value) ClientLinkId = (System.Guid) reader["client_link_id"];
            if (reader["client_id"] != System.DBNull.Value) ClientId = (System.Guid) reader["client_id"];
            if (reader["client_link_type_rcd"] != System.DBNull.Value) ClientLinkTypeRcd = (System.String) reader["client_link_type_rcd"];
            if (reader["link_name"] != System.DBNull.Value) LinkName = (System.String) reader["link_name"];
            if (reader["link"] != System.DBNull.Value) Link = (System.String) reader["link"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (ClientLinkId == Guid.Empty)
                ClientLinkId = Guid.NewGuid();

            string sql = "insert into [client_link] (client_link_id, client_id, client_link_type_rcd, link_name, link, user_id, date_time)";
            sql += "            values (@client_link_id, @client_id, @client_link_type_rcd, @link_name, @link, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@client_link_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientLinkId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.Parameters.Add("@client_link_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientLinkTypeRcd;
                    command.Parameters.Add("@link_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(LinkName)) ? (object)DBNull.Value : (System.String)LinkName;
                    command.Parameters.Add("@link",SqlDbType.NVarChar).Value = (System.String)Link;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ClientLinkId == Guid.Empty)
                ClientLinkId = Guid.NewGuid();

            string sql = "insert into [client_link] (client_link_id, client_id, client_link_type_rcd, link_name, link, user_id, date_time)";
            sql += "            values (@client_link_id, @client_id, @client_link_type_rcd, @link_name, @link, @user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_link_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientLinkId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.Parameters.Add("@client_link_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientLinkTypeRcd;
                command.Parameters.Add("@link_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(LinkName)) ? (object)DBNull.Value : (System.String)LinkName;
                command.Parameters.Add("@link",SqlDbType.NVarChar).Value = (System.String)Link;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            string sql = @" update [client_link] set
                 client_link_id = @client_link_id
                ,client_id = @client_id
                ,client_link_type_rcd = @client_link_type_rcd
                ,link_name = @link_name
                ,link = @link
                ,user_id = @user_id
                ,date_time = @date_time
            where client_link_id = @client_link_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@client_link_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientLinkId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.Parameters.Add("@client_link_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientLinkTypeRcd;
                    command.Parameters.Add("@link_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(LinkName)) ? (object)DBNull.Value : (System.String)LinkName;
                    command.Parameters.Add("@link",SqlDbType.NVarChar).Value = (System.String)Link;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [client_link] set
                 client_link_id = @client_link_id
                ,client_id = @client_id
                ,client_link_type_rcd = @client_link_type_rcd
                ,link_name = @link_name
                ,link = @link
                ,user_id = @user_id
                ,date_time = @date_time
            where client_link_id = @client_link_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_link_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientLinkId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.Parameters.Add("@client_link_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientLinkTypeRcd;
                command.Parameters.Add("@link_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(LinkName)) ? (object)DBNull.Value : (System.String)LinkName;
                command.Parameters.Add("@link",SqlDbType.NVarChar).Value = (System.String)Link;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid clientLinkId) {
            string sql = @" delete [client_link] 
                where client_link_id = @client_link_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_link_id",SqlDbType.UniqueIdentifier).Value = clientLinkId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
