/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 12:41:11 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class CrudeDefaultSystemReferenceTableData {
        
        public System.Guid DefaultSystemReferenceTableId { get; set; }
        
        public string DefaultSystemReferenceTableName { get; set; }
        
        public string DefaultSystemReferenceDisplayName { get; set; }
        
        public System.Guid DefaultUserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public void FetchByDefaultSystemReferenceTableId(System.Guid defaultSystemReferenceTableId) {
            string sql = @" select top 1 default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time
                            from [default_system_reference_table]
                            where default_system_reference_table_id = @default_system_reference_table_id
                            order by default_system_reference_table_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_system_reference_table_id",SqlDbType.UniqueIdentifier).Value = defaultSystemReferenceTableId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultSystemReferenceTableData GetByDefaultSystemReferenceTableId(System.Guid defaultSystemReferenceTableId) {
            string sql = @" select top 1 default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time
                            from [default_system_reference_table]
                            where default_system_reference_table_id = @default_system_reference_table_id
                            order by default_system_reference_table_name";

            var ret = new CrudeDefaultSystemReferenceTableData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_system_reference_table_id",SqlDbType.UniqueIdentifier).Value = defaultSystemReferenceTableId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultSystemReferenceTableData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultSystemReferenceTableData>();

            string sql = @" select default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time
                            from [default_system_reference_table]
                            where default_user_id = @default_user_id
                              
                            order by default_system_reference_table_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemReferenceTableData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByDefaultSystemReferenceTableName(string defaultSystemReferenceTableName) {
            string sql = @" select top 1 default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time
                            from [default_system_reference_table]
                            where default_system_reference_table_name like '%' + @defaultSystemReferenceTableName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@defaultSystemReferenceTableName",SqlDbType.NVarChar).Value = defaultSystemReferenceTableName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultSystemReferenceTableData> FetchAll() {
            var dataList = new List<CrudeDefaultSystemReferenceTableData>();

            string sql = @" select default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time
                            from [default_system_reference_table]
                            order by default_system_reference_table_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemReferenceTableData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultSystemReferenceTableData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultSystemReferenceTableData>();

            string sql = @" select top " + limit.ToString() + @" default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time
                            from [default_system_reference_table]
                            order by default_system_reference_table_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemReferenceTableData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultSystemReferenceTableData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultSystemReferenceTableData>();

            string sql = @" select default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time
                            from [default_system_reference_table]
                            order by default_system_reference_table_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultSystemReferenceTableData();
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
            string sql = @" select count(*) as count from [default_system_reference_table]";

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
        
        public static List<CrudeDefaultSystemReferenceTableData> FetchWithFilter(System.Guid defaultSystemReferenceTableId, string defaultSystemReferenceTableName, string defaultSystemReferenceDisplayName, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultSystemReferenceTableData>();

            string sql = @" select default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time
                            from [default_system_reference_table]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (defaultSystemReferenceTableId != Guid.Empty) {
                        sql += "  and default_system_reference_table_id = @default_system_reference_table_id";
                        command.Parameters.Add("@default_system_reference_table_id", SqlDbType.UniqueIdentifier).Value = defaultSystemReferenceTableId;
                    }
                    if (!string.IsNullOrEmpty(defaultSystemReferenceTableName)) {
                        sql += "  and default_system_reference_table_name like '%' + @default_system_reference_table_name + '%'";
                        command.Parameters.Add("@default_system_reference_table_name", SqlDbType.NVarChar).Value = defaultSystemReferenceTableName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultSystemReferenceDisplayName)) {
                        sql += "  and default_system_reference_display_name like '%' + @default_system_reference_display_name + '%'";
                        command.Parameters.Add("@default_system_reference_display_name", SqlDbType.NVarChar).Value = defaultSystemReferenceDisplayName.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by default_system_reference_table_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemReferenceTableData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_system_reference_table_id"] != System.DBNull.Value) DefaultSystemReferenceTableId = (System.Guid) reader["default_system_reference_table_id"];
            if (reader["default_system_reference_table_name"] != System.DBNull.Value) DefaultSystemReferenceTableName = (System.String) reader["default_system_reference_table_name"];
            if (reader["default_system_reference_display_name"] != System.DBNull.Value) DefaultSystemReferenceDisplayName = (System.String) reader["default_system_reference_display_name"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (DefaultSystemReferenceTableId == Guid.Empty)
                DefaultSystemReferenceTableId = Guid.NewGuid();

            string sql = "insert into [default_system_reference_table] (default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time)";
            sql += "            values (@default_system_reference_table_id, @default_system_reference_table_name, @default_system_reference_display_name, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_system_reference_table_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultSystemReferenceTableId;
                    command.Parameters.Add("@default_system_reference_table_name",SqlDbType.NVarChar).Value = (System.String)DefaultSystemReferenceTableName;
                    command.Parameters.Add("@default_system_reference_display_name",SqlDbType.NVarChar).Value = (System.String)DefaultSystemReferenceDisplayName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultSystemReferenceTableId == Guid.Empty)
                DefaultSystemReferenceTableId = Guid.NewGuid();

            string sql = "insert into [default_system_reference_table] (default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time)";
            sql += "            values (@default_system_reference_table_id, @default_system_reference_table_name, @default_system_reference_display_name, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_system_reference_table_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultSystemReferenceTableId;
                command.Parameters.Add("@default_system_reference_table_name",SqlDbType.NVarChar).Value = (System.String)DefaultSystemReferenceTableName;
                command.Parameters.Add("@default_system_reference_display_name",SqlDbType.NVarChar).Value = (System.String)DefaultSystemReferenceDisplayName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_system_reference_table] set
                 default_system_reference_table_id = @default_system_reference_table_id
                ,default_system_reference_table_name = @default_system_reference_table_name
                ,default_system_reference_display_name = @default_system_reference_display_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_system_reference_table_id = @default_system_reference_table_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_system_reference_table_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultSystemReferenceTableId;
                    command.Parameters.Add("@default_system_reference_table_name",SqlDbType.NVarChar).Value = (System.String)DefaultSystemReferenceTableName;
                    command.Parameters.Add("@default_system_reference_display_name",SqlDbType.NVarChar).Value = (System.String)DefaultSystemReferenceDisplayName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_system_reference_table] set
                 default_system_reference_table_id = @default_system_reference_table_id
                ,default_system_reference_table_name = @default_system_reference_table_name
                ,default_system_reference_display_name = @default_system_reference_display_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_system_reference_table_id = @default_system_reference_table_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_system_reference_table_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultSystemReferenceTableId;
                command.Parameters.Add("@default_system_reference_table_name",SqlDbType.NVarChar).Value = (System.String)DefaultSystemReferenceTableName;
                command.Parameters.Add("@default_system_reference_display_name",SqlDbType.NVarChar).Value = (System.String)DefaultSystemReferenceDisplayName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid defaultSystemReferenceTableId) {
            string sql = @" delete [default_system_reference_table] 
                where default_system_reference_table_id = @default_system_reference_table_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_system_reference_table_id",SqlDbType.UniqueIdentifier).Value = defaultSystemReferenceTableId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
