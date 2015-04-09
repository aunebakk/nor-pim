using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    public partial class SystemSettingRef {
        
        public static string DarkColorScheme = "dcs";
        
        public static string ProductGridLayout = "pl";
    }
    
    [Serializable()]
    public partial class CrudeSystemSettingRefData {
        
        public string SystemSettingRcd { get; set; } //;
        
        public string SystemSettingName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchBySystemSettingRcd(string systemSettingRcd) {
            string sql = @" select top 1 system_setting_rcd, system_setting_name, user_id, date_time
                            from [system_setting_ref]
                            where system_setting_rcd = @system_setting_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@system_setting_rcd",SqlDbType.NVarChar).Value = systemSettingRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeSystemSettingRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeSystemSettingRefData>();

            string sql = @" select system_setting_rcd, system_setting_name, user_id, date_time
                            from [system_setting_ref]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeSystemSettingRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeSystemSettingRefData> FetchAll() {
            var dataList = new List<CrudeSystemSettingRefData>();

            string sql = @" select system_setting_rcd, system_setting_name, user_id, date_time
                            from [system_setting_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeSystemSettingRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeSystemSettingRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeSystemSettingRefData>();

            string sql = @" select top " + limit.ToString() + @" system_setting_rcd, system_setting_name, user_id, date_time
                            from [system_setting_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeSystemSettingRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeSystemSettingRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeSystemSettingRefData>();

            string sql = @" select system_setting_rcd, system_setting_name, user_id, date_time
                            from [system_setting_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeSystemSettingRefData();
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
            string sql = @" select count(*) as count from [system_setting_ref]";

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
        
        public List<CrudeSystemSettingRefData> FetchWithFilter(string systemSettingRcd, string systemSettingName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeSystemSettingRefData>();

            string sql = @" select system_setting_rcd, system_setting_name, user_id, date_time
                            from [system_setting_ref]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (systemSettingRcd != "") {
                        sql += "  and system_setting_rcd like '%' + @system_setting_rcd + '%'";
                        command.Parameters.Add("@system_setting_rcd", SqlDbType.NVarChar).Value = systemSettingRcd.Replace("'","''");
                    }
                    if (systemSettingName != "") {
                        sql += "  and system_setting_name like '%' + @system_setting_name + '%'";
                        command.Parameters.Add("@system_setting_name", SqlDbType.NVarChar).Value = systemSettingName.Replace("'","''");
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
                        var data = new CrudeSystemSettingRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["system_setting_rcd"] != System.DBNull.Value) SystemSettingRcd = (System.String) reader["system_setting_rcd"];
            if (reader["system_setting_name"] != System.DBNull.Value) SystemSettingName = (System.String) reader["system_setting_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [system_setting_ref] (system_setting_rcd, system_setting_name, user_id, date_time)";
            sql += "            values (@system_setting_rcd, @system_setting_name, @user_id, @date_time)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@system_setting_rcd",SqlDbType.NVarChar).Value = (SystemSettingRcd == null ? (object)DBNull.Value : (System.String)SystemSettingRcd);
                    command.Parameters.Add("@system_setting_name",SqlDbType.NVarChar).Value = (SystemSettingName == null ? (object)DBNull.Value : (System.String)SystemSettingName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [system_setting_ref] (system_setting_rcd, system_setting_name, user_id, date_time)";
            sql += "            values (@system_setting_rcd, @system_setting_name, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@system_setting_rcd",SqlDbType.NVarChar).Value = (SystemSettingRcd == null ? (object)DBNull.Value : (System.String)SystemSettingRcd);
                command.Parameters.Add("@system_setting_name",SqlDbType.NVarChar).Value = (SystemSettingName == null ? (object)DBNull.Value : (System.String)SystemSettingName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [system_setting_ref] set
                 system_setting_rcd = @system_setting_rcd
                ,system_setting_name = @system_setting_name
                ,user_id = @user_id
                ,date_time = @date_time
            where system_setting_rcd = @system_setting_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@system_setting_rcd",SqlDbType.NVarChar).Value = (SystemSettingRcd == null ? (object)DBNull.Value : (System.String)SystemSettingRcd);
                    command.Parameters.Add("@system_setting_name",SqlDbType.NVarChar).Value = (SystemSettingName == null ? (object)DBNull.Value : (System.String)SystemSettingName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [system_setting_ref] set
                 system_setting_rcd = @system_setting_rcd
                ,system_setting_name = @system_setting_name
                ,user_id = @user_id
                ,date_time = @date_time
            where system_setting_rcd = @system_setting_rcd";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@system_setting_rcd",SqlDbType.NVarChar).Value = (SystemSettingRcd == null ? (object)DBNull.Value : (System.String)SystemSettingRcd);
                command.Parameters.Add("@system_setting_name",SqlDbType.NVarChar).Value = (SystemSettingName == null ? (object)DBNull.Value : (System.String)SystemSettingName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [system_setting_ref] 
                where system_setting_rcd = @system_setting_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@system_setting_rcd",SqlDbType.NVarChar).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
