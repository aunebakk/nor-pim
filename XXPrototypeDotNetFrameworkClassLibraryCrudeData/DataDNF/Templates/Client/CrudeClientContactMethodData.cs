/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:40:34 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeClientContactMethodData {
        
        public System.Guid ClientContactMethodId { get; set; } //;
        
        public System.Guid ClientId { get; set; } //;
        
        public string ClientContactMethodRcd { get; set; } //;
        
        public string ContactMethodWay { get; set; } //;
        
        public string Comment { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByClientContactMethodId(System.Guid clientContactMethodId) {
            string sql = @" select top 1 client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]
                            where client_contact_method_id = @client_contact_method_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@client_contact_method_id",SqlDbType.UniqueIdentifier).Value = clientContactMethodId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeClientContactMethodData GetByClientContactMethodId(System.Guid clientContactMethodId) {
            string sql = @" select top 1 client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]
                            where client_contact_method_id = @client_contact_method_id";

            var ret = new CrudeClientContactMethodData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_contact_method_id",SqlDbType.UniqueIdentifier).Value = clientContactMethodId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeClientContactMethodData> FetchByClientId(System.Guid clientId) {
            var dataList = new List<CrudeClientContactMethodData>();

            string sql = @" select client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]
                            where client_id = @client_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientContactMethodData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientContactMethodData>();

            string sql = @" select client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientContactMethodData> FetchByClientContactMethodRcd(string clientContactMethodRcd) {
            var dataList = new List<CrudeClientContactMethodData>();

            string sql = @" select client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]
                            where client_contact_method_rcd = @client_contact_method_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_contact_method_rcd", SqlDbType.NVarChar).Value = clientContactMethodRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientContactMethodData> FetchAll() {
            var dataList = new List<CrudeClientContactMethodData>();

            string sql = @" select client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientContactMethodData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientContactMethodData>();

            string sql = @" select top " + limit.ToString() + @" client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientContactMethodData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientContactMethodData>();

            string sql = @" select client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

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
        
        public static int FetchAllCount() {
            string sql = @" select count(*) as count from [client_contact_method]";

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
        
        public static List<CrudeClientContactMethodData> FetchWithFilter(System.Guid clientContactMethodId, System.Guid clientId, string clientContactMethodRcd, string contactMethodWay, string comment, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeClientContactMethodData>();

            string sql = @" select client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time
                            from [client_contact_method]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
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

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["client_contact_method_id"] != System.DBNull.Value) ClientContactMethodId = (System.Guid) reader["client_contact_method_id"];
            if (reader["client_id"] != System.DBNull.Value) ClientId = (System.Guid) reader["client_id"];
            if (reader["client_contact_method_rcd"] != System.DBNull.Value) ClientContactMethodRcd = (System.String) reader["client_contact_method_rcd"];
            if (reader["contact_method_way"] != System.DBNull.Value) ContactMethodWay = (System.String) reader["contact_method_way"];
            if (reader["comment"] != System.DBNull.Value) Comment = (System.String) reader["comment"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ClientContactMethodId == Guid.Empty)
                ClientContactMethodId = Guid.NewGuid();

            string sql = "insert into [client_contact_method] (client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time)";
            sql += "            values (@client_contact_method_id, @client_id, @client_contact_method_rcd, @contact_method_way, @comment, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@client_contact_method_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientContactMethodId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodRcd;
                    command.Parameters.Add("@contact_method_way",SqlDbType.NVarChar).Value = (System.String)ContactMethodWay;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (System.String)Comment;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ClientContactMethodId == Guid.Empty)
                ClientContactMethodId = Guid.NewGuid();

            string sql = "insert into [client_contact_method] (client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time)";
            sql += "            values (@client_contact_method_id, @client_id, @client_contact_method_rcd, @contact_method_way, @comment, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_contact_method_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientContactMethodId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodRcd;
                command.Parameters.Add("@contact_method_way",SqlDbType.NVarChar).Value = (System.String)ContactMethodWay;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (System.String)Comment;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
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
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@client_contact_method_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientContactMethodId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodRcd;
                    command.Parameters.Add("@contact_method_way",SqlDbType.NVarChar).Value = (System.String)ContactMethodWay;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (System.String)Comment;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
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
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_contact_method_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientContactMethodId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodRcd;
                command.Parameters.Add("@contact_method_way",SqlDbType.NVarChar).Value = (System.String)ContactMethodWay;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (System.String)Comment;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid clientContactMethodId) {
            string sql = @" delete [client_contact_method] 
                where client_contact_method_id = @client_contact_method_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_contact_method_id",SqlDbType.UniqueIdentifier).Value = clientContactMethodId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
