/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:43:04 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeClientEventData {
        
        public System.Guid ClientEventId { get; set; } //;
        
        public System.Guid ClientId { get; set; } //;
        
        public string ClientEventTypeRcd { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByClientEventId(System.Guid clientEventId) {
            string sql = @" select top 1 client_event_id, client_id, client_event_type_rcd, user_id, date_time
                            from [client_event]
                            where client_event_id = @client_event_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@client_event_id",SqlDbType.UniqueIdentifier).Value = clientEventId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeClientEventData GetByClientEventId(System.Guid clientEventId) {
            string sql = @" select top 1 client_event_id, client_id, client_event_type_rcd, user_id, date_time
                            from [client_event]
                            where client_event_id = @client_event_id";

            var ret = new CrudeClientEventData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_event_id",SqlDbType.UniqueIdentifier).Value = clientEventId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeClientEventData> FetchByClientId(System.Guid clientId) {
            var dataList = new List<CrudeClientEventData>();

            string sql = @" select client_event_id, client_id, client_event_type_rcd, user_id, date_time
                            from [client_event]
                            where client_id = @client_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientEventData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientEventData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientEventData>();

            string sql = @" select client_event_id, client_id, client_event_type_rcd, user_id, date_time
                            from [client_event]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientEventData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientEventData> FetchByClientEventTypeRcd(string clientEventTypeRcd) {
            var dataList = new List<CrudeClientEventData>();

            string sql = @" select client_event_id, client_id, client_event_type_rcd, user_id, date_time
                            from [client_event]
                            where client_event_type_rcd = @client_event_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_event_type_rcd", SqlDbType.NVarChar).Value = clientEventTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientEventData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientEventData> FetchAll() {
            var dataList = new List<CrudeClientEventData>();

            string sql = @" select client_event_id, client_id, client_event_type_rcd, user_id, date_time
                            from [client_event]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientEventData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientEventData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientEventData>();

            string sql = @" select top " + limit.ToString() + @" client_event_id, client_id, client_event_type_rcd, user_id, date_time
                            from [client_event]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientEventData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientEventData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientEventData>();

            string sql = @" select client_event_id, client_id, client_event_type_rcd, user_id, date_time
                            from [client_event]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeClientEventData();
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
            string sql = @" select count(*) as count from [client_event]";

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
        
        public static List<CrudeClientEventData> FetchWithFilter(System.Guid clientEventId, System.Guid clientId, string clientEventTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeClientEventData>();

            string sql = @" select client_event_id, client_id, client_event_type_rcd, user_id, date_time
                            from [client_event]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (clientEventId != Guid.Empty) {
                        sql += "  and client_event_id = @client_event_id";
                        command.Parameters.Add("@client_event_id", SqlDbType.UniqueIdentifier).Value = clientEventId;
                    }
                    if (clientId != Guid.Empty) {
                        sql += "  and client_id = @client_id";
                        command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;
                    }
                    if (!string.IsNullOrEmpty(clientEventTypeRcd)) {
                        sql += "  and client_event_type_rcd like '%' + @client_event_type_rcd + '%'";
                        command.Parameters.Add("@client_event_type_rcd", SqlDbType.NVarChar).Value = clientEventTypeRcd.Replace("'","''");
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
                        var data = new CrudeClientEventData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["client_event_id"] != System.DBNull.Value) ClientEventId = (System.Guid) reader["client_event_id"];
            if (reader["client_id"] != System.DBNull.Value) ClientId = (System.Guid) reader["client_id"];
            if (reader["client_event_type_rcd"] != System.DBNull.Value) ClientEventTypeRcd = (System.String) reader["client_event_type_rcd"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ClientEventId == Guid.Empty)
                ClientEventId = Guid.NewGuid();

            string sql = "insert into [client_event] (client_event_id, client_id, client_event_type_rcd, user_id, date_time)";
            sql += "            values (@client_event_id, @client_id, @client_event_type_rcd, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@client_event_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientEventId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.Parameters.Add("@client_event_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientEventTypeRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ClientEventId == Guid.Empty)
                ClientEventId = Guid.NewGuid();

            string sql = "insert into [client_event] (client_event_id, client_id, client_event_type_rcd, user_id, date_time)";
            sql += "            values (@client_event_id, @client_id, @client_event_type_rcd, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_event_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientEventId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.Parameters.Add("@client_event_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientEventTypeRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [client_event] set
                 client_event_id = @client_event_id
                ,client_id = @client_id
                ,client_event_type_rcd = @client_event_type_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where client_event_id = @client_event_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@client_event_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientEventId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.Parameters.Add("@client_event_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientEventTypeRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [client_event] set
                 client_event_id = @client_event_id
                ,client_id = @client_id
                ,client_event_type_rcd = @client_event_type_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where client_event_id = @client_event_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_event_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientEventId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.Parameters.Add("@client_event_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientEventTypeRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid clientEventId) {
            string sql = @" delete [client_event] 
                where client_event_id = @client_event_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_event_id",SqlDbType.UniqueIdentifier).Value = clientEventId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
