/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:53:26 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeClientLinkData {
        
        public System.Guid ClientLinkId { get; set; } //;
        
        public System.Guid ClientId { get; set; } //;
        
        public string ClientLinkTypeRcd { get; set; } //;
        
        public string LinkName { get; set; } //;
        
        public string Link { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByClientLinkId(System.Guid clientLinkId) {
            string sql = @" select top 1 client_link_id, client_id, client_link_type_rcd, link_name, link, user_id, date_time
                            from [client_link]
                            where client_link_id = @client_link_id
                            order by link_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@client_link_id",SqlDbType.UniqueIdentifier).Value = clientLinkId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
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

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
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
        
        public void Populate(IDataReader reader) {
            if (reader["client_link_id"] != System.DBNull.Value) ClientLinkId = (System.Guid) reader["client_link_id"];
            if (reader["client_id"] != System.DBNull.Value) ClientId = (System.Guid) reader["client_id"];
            if (reader["client_link_type_rcd"] != System.DBNull.Value) ClientLinkTypeRcd = (System.String) reader["client_link_type_rcd"];
            if (reader["link_name"] != System.DBNull.Value) LinkName = (System.String) reader["link_name"];
            if (reader["link"] != System.DBNull.Value) Link = (System.String) reader["link"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
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
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ClientLinkId == Guid.Empty)
                ClientLinkId = Guid.NewGuid();

            string sql = "insert into [client_link] (client_link_id, client_id, client_link_type_rcd, link_name, link, user_id, date_time)";
            sql += "            values (@client_link_id, @client_id, @client_link_type_rcd, @link_name, @link, @user_id, @date_time)";

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
