using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeSystemReferenceTableData {
        
        public System.Guid SystemReferenceTableId { get; set; } //;
        
        public string SystemReferenceTableName { get; set; } //;
        
        public string SystemReferenceDisplayName { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public void FetchBySystemReferenceTableId(System.Guid systemReferenceTableId) {
            string sql = @" select top 1 system_reference_table_id, system_reference_table_name, system_reference_display_name, date_time, user_id
                            from [system_reference_table]
                            where system_reference_table_id = @system_reference_table_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@system_reference_table_id",SqlDbType.UniqueIdentifier).Value = systemReferenceTableId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeSystemReferenceTableData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeSystemReferenceTableData>();

            string sql = @" select system_reference_table_id, system_reference_table_name, system_reference_display_name, date_time, user_id
                            from [system_reference_table]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeSystemReferenceTableData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeSystemReferenceTableData> FetchAll() {
            var dataList = new List<CrudeSystemReferenceTableData>();

            string sql = @" select system_reference_table_id, system_reference_table_name, system_reference_display_name, date_time, user_id
                            from [system_reference_table]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeSystemReferenceTableData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeSystemReferenceTableData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeSystemReferenceTableData>();

            string sql = @" select top " + limit.ToString() + @" system_reference_table_id, system_reference_table_name, system_reference_display_name, date_time, user_id
                            from [system_reference_table]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeSystemReferenceTableData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeSystemReferenceTableData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeSystemReferenceTableData>();

            string sql = @" select system_reference_table_id, system_reference_table_name, system_reference_display_name, date_time, user_id
                            from [system_reference_table]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeSystemReferenceTableData();
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
            string sql = @" select count(*) as count from [system_reference_table]";

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
        
        public List<CrudeSystemReferenceTableData> FetchWithFilter(System.Guid systemReferenceTableId, string systemReferenceTableName, string systemReferenceDisplayName, System.DateTime dateTime, System.Guid userId) {
            var dataList = new List<CrudeSystemReferenceTableData>();

            string sql = @" select system_reference_table_id, system_reference_table_name, system_reference_display_name, date_time, user_id
                            from [system_reference_table]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (systemReferenceTableId != Guid.Empty) {
                        sql += "  and system_reference_table_id = @system_reference_table_id";
                        command.Parameters.Add("@system_reference_table_id", SqlDbType.UniqueIdentifier).Value = systemReferenceTableId;
                    }
                    if (systemReferenceTableName != "") {
                        sql += "  and system_reference_table_name like '%' + @system_reference_table_name + '%'";
                        command.Parameters.Add("@system_reference_table_name", SqlDbType.NVarChar).Value = systemReferenceTableName.Replace("'","''");
                    }
                    if (systemReferenceDisplayName != "") {
                        sql += "  and system_reference_display_name like '%' + @system_reference_display_name + '%'";
                        command.Parameters.Add("@system_reference_display_name", SqlDbType.NVarChar).Value = systemReferenceDisplayName.Replace("'","''");
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeSystemReferenceTableData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["system_reference_table_id"] != System.DBNull.Value) SystemReferenceTableId = (System.Guid) reader["system_reference_table_id"];
            if (reader["system_reference_table_name"] != System.DBNull.Value) SystemReferenceTableName = (System.String) reader["system_reference_table_name"];
            if (reader["system_reference_display_name"] != System.DBNull.Value) SystemReferenceDisplayName = (System.String) reader["system_reference_display_name"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
        }
        
        public void Insert() {

            if (SystemReferenceTableId == Guid.Empty)
                SystemReferenceTableId = Guid.NewGuid();

            string sql = "insert into [system_reference_table] (system_reference_table_id, system_reference_table_name, system_reference_display_name, date_time, user_id)";
            sql += "            values (@system_reference_table_id, @system_reference_table_name, @system_reference_display_name, @date_time, @user_id)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@system_reference_table_id",SqlDbType.UniqueIdentifier).Value = (SystemReferenceTableId == Guid.Empty ? (object)DBNull.Value : (System.Guid)SystemReferenceTableId);
                    command.Parameters.Add("@system_reference_table_name",SqlDbType.NVarChar).Value = (SystemReferenceTableName == null ? (object)DBNull.Value : (System.String)SystemReferenceTableName);
                    command.Parameters.Add("@system_reference_display_name",SqlDbType.NVarChar).Value = (SystemReferenceDisplayName == null ? (object)DBNull.Value : (System.String)SystemReferenceDisplayName);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (SystemReferenceTableId == Guid.Empty)
                SystemReferenceTableId = Guid.NewGuid();

            string sql = "insert into [system_reference_table] (system_reference_table_id, system_reference_table_name, system_reference_display_name, date_time, user_id)";
            sql += "            values (@system_reference_table_id, @system_reference_table_name, @system_reference_display_name, @date_time, @user_id)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@system_reference_table_id",SqlDbType.UniqueIdentifier).Value = (SystemReferenceTableId == Guid.Empty ? (object)DBNull.Value : (System.Guid)SystemReferenceTableId);
                command.Parameters.Add("@system_reference_table_name",SqlDbType.NVarChar).Value = (SystemReferenceTableName == null ? (object)DBNull.Value : (System.String)SystemReferenceTableName);
                command.Parameters.Add("@system_reference_display_name",SqlDbType.NVarChar).Value = (SystemReferenceDisplayName == null ? (object)DBNull.Value : (System.String)SystemReferenceDisplayName);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [system_reference_table] set
                 system_reference_table_id = @system_reference_table_id
                ,system_reference_table_name = @system_reference_table_name
                ,system_reference_display_name = @system_reference_display_name
                ,date_time = @date_time
                ,user_id = @user_id
            where system_reference_table_id = @system_reference_table_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@system_reference_table_id",SqlDbType.UniqueIdentifier).Value = (SystemReferenceTableId == Guid.Empty ? (object)DBNull.Value : (System.Guid)SystemReferenceTableId);
                    command.Parameters.Add("@system_reference_table_name",SqlDbType.NVarChar).Value = (SystemReferenceTableName == null ? (object)DBNull.Value : (System.String)SystemReferenceTableName);
                    command.Parameters.Add("@system_reference_display_name",SqlDbType.NVarChar).Value = (SystemReferenceDisplayName == null ? (object)DBNull.Value : (System.String)SystemReferenceDisplayName);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [system_reference_table] set
                 system_reference_table_id = @system_reference_table_id
                ,system_reference_table_name = @system_reference_table_name
                ,system_reference_display_name = @system_reference_display_name
                ,date_time = @date_time
                ,user_id = @user_id
            where system_reference_table_id = @system_reference_table_id";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@system_reference_table_id",SqlDbType.UniqueIdentifier).Value = (SystemReferenceTableId == Guid.Empty ? (object)DBNull.Value : (System.Guid)SystemReferenceTableId);
                command.Parameters.Add("@system_reference_table_name",SqlDbType.NVarChar).Value = (SystemReferenceTableName == null ? (object)DBNull.Value : (System.String)SystemReferenceTableName);
                command.Parameters.Add("@system_reference_display_name",SqlDbType.NVarChar).Value = (SystemReferenceDisplayName == null ? (object)DBNull.Value : (System.String)SystemReferenceDisplayName);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [system_reference_table] 
                where system_reference_table_id = @system_reference_table_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@system_reference_table_id",SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
