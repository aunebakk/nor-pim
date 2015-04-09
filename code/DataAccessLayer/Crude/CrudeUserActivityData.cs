using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeUserActivityData {
        
        public System.Guid UserActivityId { get; set; } //;
        
        public string UserActivityTypeRcd { get; set; } //;
        
        public string UserActivityNote { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public string OriginatingAddress { get; set; } //;
        
        public void FetchByUserActivityId(System.Guid userActivityId) {
            string sql = @" select top 1 user_activity_id, user_activity_type_rcd, user_activity_note, user_id, date_time, originating_address
                            from [user_activity]
                            where user_activity_id = @user_activity_id
                            order by date_time";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_activity_id",SqlDbType.UniqueIdentifier).Value = userActivityId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeUserActivityData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeUserActivityData>();

            string sql = @" select user_activity_id, user_activity_type_rcd, user_activity_note, user_id, date_time, originating_address
                            from [user_activity]
                            where user_id = @user_id
                              
                            order by date_time";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeUserActivityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeUserActivityData> FetchAll() {
            var dataList = new List<CrudeUserActivityData>();

            string sql = @" select user_activity_id, user_activity_type_rcd, user_activity_note, user_id, date_time, originating_address
                            from [user_activity]
                            order by date_time";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeUserActivityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeUserActivityData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeUserActivityData>();

            string sql = @" select top " + limit.ToString() + @" user_activity_id, user_activity_type_rcd, user_activity_note, user_id, date_time, originating_address
                            from [user_activity]
                            order by date_time";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeUserActivityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeUserActivityData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeUserActivityData>();

            string sql = @" select user_activity_id, user_activity_type_rcd, user_activity_note, user_id, date_time, originating_address
                            from [user_activity]
                            order by date_time";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeUserActivityData();
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
            string sql = @" select count(*) as count from [user_activity]";

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
        
        public List<CrudeUserActivityData> FetchWithFilter(System.Guid userActivityId, string userActivityTypeRcd, string userActivityNote, System.Guid userId, System.DateTime dateTime, string originatingAddress) {
            var dataList = new List<CrudeUserActivityData>();

            string sql = @" select user_activity_id, user_activity_type_rcd, user_activity_note, user_id, date_time, originating_address
                            from [user_activity]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (userActivityId != Guid.Empty) {
                        sql += "  and user_activity_id = @user_activity_id";
                        command.Parameters.Add("@user_activity_id", SqlDbType.UniqueIdentifier).Value = userActivityId;
                    }
                    if (userActivityTypeRcd != "") {
                        sql += "  and user_activity_type_rcd like '%' + @user_activity_type_rcd + '%'";
                        command.Parameters.Add("@user_activity_type_rcd", SqlDbType.NVarChar).Value = userActivityTypeRcd.Replace("'","''");
                    }
                    if (userActivityNote != "") {
                        sql += "  and user_activity_note like '%' + @user_activity_note + '%'";
                        command.Parameters.Add("@user_activity_note", SqlDbType.NVarChar).Value = userActivityNote.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (originatingAddress != "") {
                        sql += "  and originating_address like '%' + @originating_address + '%'";
                        command.Parameters.Add("@originating_address", SqlDbType.NVarChar).Value = originatingAddress.Replace("'","''");
                    }
                    sql += " order by date_time";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeUserActivityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["user_activity_id"] != System.DBNull.Value) UserActivityId = (System.Guid) reader["user_activity_id"];
            if (reader["user_activity_type_rcd"] != System.DBNull.Value) UserActivityTypeRcd = (System.String) reader["user_activity_type_rcd"];
            if (reader["user_activity_note"] != System.DBNull.Value) UserActivityNote = (System.String) reader["user_activity_note"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["originating_address"] != System.DBNull.Value) OriginatingAddress = (System.String) reader["originating_address"];
        }
        
        public void Insert() {

            if (UserActivityId == Guid.Empty)
                UserActivityId = Guid.NewGuid();

            string sql = "insert into [user_activity] (user_activity_id, user_activity_type_rcd, user_activity_note, user_id, date_time, originating_address)";
            sql += "            values (@user_activity_id, @user_activity_type_rcd, @user_activity_note, @user_id, @date_time, @originating_address)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@user_activity_id",SqlDbType.UniqueIdentifier).Value = (UserActivityId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserActivityId);
                    command.Parameters.Add("@user_activity_type_rcd",SqlDbType.NVarChar).Value = (UserActivityTypeRcd == null ? (object)DBNull.Value : (System.String)UserActivityTypeRcd);
                    command.Parameters.Add("@user_activity_note",SqlDbType.NVarChar).Value = (UserActivityNote == null ? (object)DBNull.Value : (System.String)UserActivityNote);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.Parameters.Add("@originating_address",SqlDbType.NVarChar).Value = (OriginatingAddress == null ? (object)DBNull.Value : (System.String)OriginatingAddress);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (UserActivityId == Guid.Empty)
                UserActivityId = Guid.NewGuid();

            string sql = "insert into [user_activity] (user_activity_id, user_activity_type_rcd, user_activity_note, user_id, date_time, originating_address)";
            sql += "            values (@user_activity_id, @user_activity_type_rcd, @user_activity_note, @user_id, @date_time, @originating_address)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@user_activity_id",SqlDbType.UniqueIdentifier).Value = (UserActivityId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserActivityId);
                command.Parameters.Add("@user_activity_type_rcd",SqlDbType.NVarChar).Value = (UserActivityTypeRcd == null ? (object)DBNull.Value : (System.String)UserActivityTypeRcd);
                command.Parameters.Add("@user_activity_note",SqlDbType.NVarChar).Value = (UserActivityNote == null ? (object)DBNull.Value : (System.String)UserActivityNote);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.Parameters.Add("@originating_address",SqlDbType.NVarChar).Value = (OriginatingAddress == null ? (object)DBNull.Value : (System.String)OriginatingAddress);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [user_activity] set
                 user_activity_id = @user_activity_id
                ,user_activity_type_rcd = @user_activity_type_rcd
                ,user_activity_note = @user_activity_note
                ,user_id = @user_id
                ,date_time = @date_time
                ,originating_address = @originating_address
            where user_activity_id = @user_activity_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@user_activity_id",SqlDbType.UniqueIdentifier).Value = (UserActivityId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserActivityId);
                    command.Parameters.Add("@user_activity_type_rcd",SqlDbType.NVarChar).Value = (UserActivityTypeRcd == null ? (object)DBNull.Value : (System.String)UserActivityTypeRcd);
                    command.Parameters.Add("@user_activity_note",SqlDbType.NVarChar).Value = (UserActivityNote == null ? (object)DBNull.Value : (System.String)UserActivityNote);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.Parameters.Add("@originating_address",SqlDbType.NVarChar).Value = (OriginatingAddress == null ? (object)DBNull.Value : (System.String)OriginatingAddress);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [user_activity] set
                 user_activity_id = @user_activity_id
                ,user_activity_type_rcd = @user_activity_type_rcd
                ,user_activity_note = @user_activity_note
                ,user_id = @user_id
                ,date_time = @date_time
                ,originating_address = @originating_address
            where user_activity_id = @user_activity_id";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@user_activity_id",SqlDbType.UniqueIdentifier).Value = (UserActivityId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserActivityId);
                command.Parameters.Add("@user_activity_type_rcd",SqlDbType.NVarChar).Value = (UserActivityTypeRcd == null ? (object)DBNull.Value : (System.String)UserActivityTypeRcd);
                command.Parameters.Add("@user_activity_note",SqlDbType.NVarChar).Value = (UserActivityNote == null ? (object)DBNull.Value : (System.String)UserActivityNote);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.Parameters.Add("@originating_address",SqlDbType.NVarChar).Value = (OriginatingAddress == null ? (object)DBNull.Value : (System.String)OriginatingAddress);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [user_activity] 
                where user_activity_id = @user_activity_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_activity_id",SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
