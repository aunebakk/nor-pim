using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    public partial class UserActivityTypeRef {
        
        public static string BusinessLogicMethodInvoked = "blmi";
        
        public static string FormOpened = "fo";
        
        public static string Login = "li";
        
        public static string Logout = "lo";
        
        public static string ScheduledEvent = "se";
        
        public static string WebPageOpened = "wpo";
    }
    
    [Serializable()]
    public partial class CrudeUserActivityTypeRefData {
        
        public string UserActivityTypeRcd { get; set; } //;
        
        public string UserActivityTypeName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByUserActivityTypeRcd(string userActivityTypeRcd) {
            string sql = @" select top 1 user_activity_type_rcd, user_activity_type_name, user_id, date_time
                            from [user_activity_type_ref]
                            where user_activity_type_rcd = @user_activity_type_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_activity_type_rcd",SqlDbType.NVarChar).Value = userActivityTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeUserActivityTypeRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeUserActivityTypeRefData>();

            string sql = @" select user_activity_type_rcd, user_activity_type_name, user_id, date_time
                            from [user_activity_type_ref]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeUserActivityTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeUserActivityTypeRefData> FetchAll() {
            var dataList = new List<CrudeUserActivityTypeRefData>();

            string sql = @" select user_activity_type_rcd, user_activity_type_name, user_id, date_time
                            from [user_activity_type_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeUserActivityTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeUserActivityTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeUserActivityTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" user_activity_type_rcd, user_activity_type_name, user_id, date_time
                            from [user_activity_type_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeUserActivityTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeUserActivityTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeUserActivityTypeRefData>();

            string sql = @" select user_activity_type_rcd, user_activity_type_name, user_id, date_time
                            from [user_activity_type_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeUserActivityTypeRefData();
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
        
        public int FetchAllCount() {
            string sql = @" select count(*) as count from [user_activity_type_ref]";

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
        
        public List<CrudeUserActivityTypeRefData> FetchWithFilter(string userActivityTypeRcd, string userActivityTypeName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeUserActivityTypeRefData>();

            string sql = @" select user_activity_type_rcd, user_activity_type_name, user_id, date_time
                            from [user_activity_type_ref]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (userActivityTypeRcd != "") {
                        sql += "  and user_activity_type_rcd like '%' + @user_activity_type_rcd + '%'";
                        command.Parameters.Add("@user_activity_type_rcd", SqlDbType.NVarChar).Value = userActivityTypeRcd.Replace("'","''");
                    }
                    if (userActivityTypeName != "") {
                        sql += "  and user_activity_type_name like '%' + @user_activity_type_name + '%'";
                        command.Parameters.Add("@user_activity_type_name", SqlDbType.NVarChar).Value = userActivityTypeName.Replace("'","''");
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
                        var data = new CrudeUserActivityTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["user_activity_type_rcd"] != System.DBNull.Value) UserActivityTypeRcd = (System.String) reader["user_activity_type_rcd"];
            if (reader["user_activity_type_name"] != System.DBNull.Value) UserActivityTypeName = (System.String) reader["user_activity_type_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [user_activity_type_ref] (user_activity_type_rcd, user_activity_type_name, user_id, date_time)";
            sql += "            values (@user_activity_type_rcd, @user_activity_type_name, @user_id, @date_time)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@user_activity_type_rcd",SqlDbType.NVarChar).Value = (UserActivityTypeRcd == null ? (object)DBNull.Value : (System.String)UserActivityTypeRcd);
                    command.Parameters.Add("@user_activity_type_name",SqlDbType.NVarChar).Value = (UserActivityTypeName == null ? (object)DBNull.Value : (System.String)UserActivityTypeName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [user_activity_type_ref] (user_activity_type_rcd, user_activity_type_name, user_id, date_time)";
            sql += "            values (@user_activity_type_rcd, @user_activity_type_name, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@user_activity_type_rcd",SqlDbType.NVarChar).Value = (UserActivityTypeRcd == null ? (object)DBNull.Value : (System.String)UserActivityTypeRcd);
                command.Parameters.Add("@user_activity_type_name",SqlDbType.NVarChar).Value = (UserActivityTypeName == null ? (object)DBNull.Value : (System.String)UserActivityTypeName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [user_activity_type_ref] set
                 user_activity_type_rcd = @user_activity_type_rcd
                ,user_activity_type_name = @user_activity_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where user_activity_type_rcd = @user_activity_type_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@user_activity_type_rcd",SqlDbType.NVarChar).Value = (UserActivityTypeRcd == null ? (object)DBNull.Value : (System.String)UserActivityTypeRcd);
                    command.Parameters.Add("@user_activity_type_name",SqlDbType.NVarChar).Value = (UserActivityTypeName == null ? (object)DBNull.Value : (System.String)UserActivityTypeName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [user_activity_type_ref] set
                 user_activity_type_rcd = @user_activity_type_rcd
                ,user_activity_type_name = @user_activity_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where user_activity_type_rcd = @user_activity_type_rcd";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@user_activity_type_rcd",SqlDbType.NVarChar).Value = (UserActivityTypeRcd == null ? (object)DBNull.Value : (System.String)UserActivityTypeRcd);
                command.Parameters.Add("@user_activity_type_name",SqlDbType.NVarChar).Value = (UserActivityTypeName == null ? (object)DBNull.Value : (System.String)UserActivityTypeName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [user_activity_type_ref] 
                where user_activity_type_rcd = @user_activity_type_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_activity_type_rcd",SqlDbType.NVarChar).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
