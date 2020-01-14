/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:24 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeDefaultSystemSettingData {
        
        public System.Guid DefaultSystemSettingId { get; set; } //;
        
        public string DefaultSystemSettingRcd { get; set; } //;
        
        public string DefaultSystemSettingValue { get; set; } //;
        
        public System.Guid DefaultUserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByDefaultSystemSettingId(System.Guid defaultSystemSettingId) {
            string sql = @" select top 1 default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]
                            where default_system_setting_id = @default_system_setting_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_system_setting_id",SqlDbType.UniqueIdentifier).Value = defaultSystemSettingId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultSystemSettingData GetByDefaultSystemSettingId(System.Guid defaultSystemSettingId) {
            string sql = @" select top 1 default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]
                            where default_system_setting_id = @default_system_setting_id";

            var ret = new CrudeDefaultSystemSettingData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_system_setting_id",SqlDbType.UniqueIdentifier).Value = defaultSystemSettingId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultSystemSettingData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultSystemSettingData>();

            string sql = @" select default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]
                            where default_user_id = @default_user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemSettingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultSystemSettingData> FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd) {
            var dataList = new List<CrudeDefaultSystemSettingData>();

            string sql = @" select default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]
                            where default_system_setting_rcd = @default_system_setting_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_system_setting_rcd", SqlDbType.NVarChar).Value = defaultSystemSettingRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemSettingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultSystemSettingData> FetchAll() {
            var dataList = new List<CrudeDefaultSystemSettingData>();

            string sql = @" select default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemSettingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultSystemSettingData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultSystemSettingData>();

            string sql = @" select top " + limit.ToString() + @" default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemSettingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultSystemSettingData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultSystemSettingData>();

            string sql = @" select default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultSystemSettingData();
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
            string sql = @" select count(*) as count from [default_system_setting]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
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
        
        public static List<CrudeDefaultSystemSettingData> FetchWithFilter(System.Guid defaultSystemSettingId, string defaultSystemSettingRcd, string defaultSystemSettingValue, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultSystemSettingData>();

            string sql = @" select default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time
                            from [default_system_setting]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (defaultSystemSettingId != Guid.Empty) {
                        sql += "  and default_system_setting_id = @default_system_setting_id";
                        command.Parameters.Add("@default_system_setting_id", SqlDbType.UniqueIdentifier).Value = defaultSystemSettingId;
                    }
                    if (!string.IsNullOrEmpty(defaultSystemSettingRcd)) {
                        sql += "  and default_system_setting_rcd like '%' + @default_system_setting_rcd + '%'";
                        command.Parameters.Add("@default_system_setting_rcd", SqlDbType.NVarChar).Value = defaultSystemSettingRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultSystemSettingValue)) {
                        sql += "  and default_system_setting_value like '%' + @default_system_setting_value + '%'";
                        command.Parameters.Add("@default_system_setting_value", SqlDbType.NVarChar).Value = defaultSystemSettingValue.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemSettingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_system_setting_id"] != System.DBNull.Value) DefaultSystemSettingId = (System.Guid) reader["default_system_setting_id"];
            if (reader["default_system_setting_rcd"] != System.DBNull.Value) DefaultSystemSettingRcd = (System.String) reader["default_system_setting_rcd"];
            if (reader["default_system_setting_value"] != System.DBNull.Value) DefaultSystemSettingValue = (System.String) reader["default_system_setting_value"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (DefaultSystemSettingId == Guid.Empty)
                DefaultSystemSettingId = Guid.NewGuid();

            string sql = "insert into [default_system_setting] (default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time)";
            sql += "            values (@default_system_setting_id, @default_system_setting_rcd, @default_system_setting_value, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_system_setting_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultSystemSettingId;
                    command.Parameters.Add("@default_system_setting_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingRcd;
                    command.Parameters.Add("@default_system_setting_value",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingValue;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultSystemSettingId == Guid.Empty)
                DefaultSystemSettingId = Guid.NewGuid();

            string sql = "insert into [default_system_setting] (default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time)";
            sql += "            values (@default_system_setting_id, @default_system_setting_rcd, @default_system_setting_value, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_system_setting_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultSystemSettingId;
                command.Parameters.Add("@default_system_setting_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingRcd;
                command.Parameters.Add("@default_system_setting_value",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingValue;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_system_setting] set
                 default_system_setting_id = @default_system_setting_id
                ,default_system_setting_rcd = @default_system_setting_rcd
                ,default_system_setting_value = @default_system_setting_value
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_system_setting_id = @default_system_setting_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_system_setting_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultSystemSettingId;
                    command.Parameters.Add("@default_system_setting_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingRcd;
                    command.Parameters.Add("@default_system_setting_value",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingValue;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_system_setting] set
                 default_system_setting_id = @default_system_setting_id
                ,default_system_setting_rcd = @default_system_setting_rcd
                ,default_system_setting_value = @default_system_setting_value
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_system_setting_id = @default_system_setting_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_system_setting_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultSystemSettingId;
                command.Parameters.Add("@default_system_setting_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingRcd;
                command.Parameters.Add("@default_system_setting_value",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingValue;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid defaultSystemSettingId) {
            string sql = @" delete [default_system_setting] 
                where default_system_setting_id = @default_system_setting_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_system_setting_id",SqlDbType.UniqueIdentifier).Value = defaultSystemSettingId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
