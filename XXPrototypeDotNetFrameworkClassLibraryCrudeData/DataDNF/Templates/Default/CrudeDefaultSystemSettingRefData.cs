/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:54:25 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    public partial class DefaultSystemSettingRef {
        
        public const string BookingCostcentre = "BCC";
        
        public const string BookingCurrency = "BCU";
        
        public const string ElektroforeningenWebLink = "EFOLINK";
        
        public const string FDVWebLink = "FDVLINK";
    }
    
    [Serializable()]
    public partial class CrudeDefaultSystemSettingRefData {
        
        public string DefaultSystemSettingRcd { get; set; } //;
        
        public string DefaultSystemSettingName { get; set; } //;
        
        public System.Guid DefaultUserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd) {
            string sql = @" select top 1 default_system_setting_rcd, default_system_setting_name, default_user_id, date_time
                            from [default_system_setting_ref]
                            where default_system_setting_rcd = @default_system_setting_rcd
                            order by default_system_setting_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_system_setting_rcd",SqlDbType.NVarChar).Value = defaultSystemSettingRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultSystemSettingRefData GetByDefaultSystemSettingRcd(string defaultSystemSettingRcd) {
            string sql = @" select top 1 default_system_setting_rcd, default_system_setting_name, default_user_id, date_time
                            from [default_system_setting_ref]
                            where default_system_setting_rcd = @default_system_setting_rcd
                            order by default_system_setting_name";

            var ret = new CrudeDefaultSystemSettingRefData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_system_setting_rcd",SqlDbType.NVarChar).Value = defaultSystemSettingRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultSystemSettingRefData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultSystemSettingRefData>();

            string sql = @" select default_system_setting_rcd, default_system_setting_name, default_user_id, date_time
                            from [default_system_setting_ref]
                            where default_user_id = @default_user_id
                              
                            order by default_system_setting_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemSettingRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByDefaultSystemSettingName(string defaultSystemSettingName) {
            string sql = @" select top 1 default_system_setting_rcd, default_system_setting_name, default_user_id, date_time
                            from [default_system_setting_ref]
                            where default_system_setting_name like '%' + @defaultSystemSettingName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@defaultSystemSettingName",SqlDbType.NVarChar).Value = defaultSystemSettingName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultSystemSettingRefData> FetchAll() {
            var dataList = new List<CrudeDefaultSystemSettingRefData>();

            string sql = @" select default_system_setting_rcd, default_system_setting_name, default_user_id, date_time
                            from [default_system_setting_ref]
                            order by default_system_setting_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemSettingRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultSystemSettingRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultSystemSettingRefData>();

            string sql = @" select top " + limit.ToString() + @" default_system_setting_rcd, default_system_setting_name, default_user_id, date_time
                            from [default_system_setting_ref]
                            order by default_system_setting_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemSettingRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultSystemSettingRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultSystemSettingRefData>();

            string sql = @" select default_system_setting_rcd, default_system_setting_name, default_user_id, date_time
                            from [default_system_setting_ref]
                            order by default_system_setting_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultSystemSettingRefData();
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
            string sql = @" select count(*) as count from [default_system_setting_ref]";

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
        
        public static List<CrudeDefaultSystemSettingRefData> FetchWithFilter(string defaultSystemSettingRcd, string defaultSystemSettingName, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultSystemSettingRefData>();

            string sql = @" select default_system_setting_rcd, default_system_setting_name, default_user_id, date_time
                            from [default_system_setting_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(defaultSystemSettingRcd)) {
                        sql += "  and default_system_setting_rcd like '%' + @default_system_setting_rcd + '%'";
                        command.Parameters.Add("@default_system_setting_rcd", SqlDbType.NVarChar).Value = defaultSystemSettingRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultSystemSettingName)) {
                        sql += "  and default_system_setting_name like '%' + @default_system_setting_name + '%'";
                        command.Parameters.Add("@default_system_setting_name", SqlDbType.NVarChar).Value = defaultSystemSettingName.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by default_system_setting_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultSystemSettingRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_system_setting_rcd"] != System.DBNull.Value) DefaultSystemSettingRcd = (System.String) reader["default_system_setting_rcd"];
            if (reader["default_system_setting_name"] != System.DBNull.Value) DefaultSystemSettingName = (System.String) reader["default_system_setting_name"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [default_system_setting_ref] (default_system_setting_rcd, default_system_setting_name, default_user_id, date_time)";
            sql += "            values (@default_system_setting_rcd, @default_system_setting_name, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_system_setting_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingRcd;
                    command.Parameters.Add("@default_system_setting_name",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [default_system_setting_ref] (default_system_setting_rcd, default_system_setting_name, default_user_id, date_time)";
            sql += "            values (@default_system_setting_rcd, @default_system_setting_name, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_system_setting_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingRcd;
                command.Parameters.Add("@default_system_setting_name",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_system_setting_ref] set
                 default_system_setting_rcd = @default_system_setting_rcd
                ,default_system_setting_name = @default_system_setting_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_system_setting_rcd = @default_system_setting_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_system_setting_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingRcd;
                    command.Parameters.Add("@default_system_setting_name",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_system_setting_ref] set
                 default_system_setting_rcd = @default_system_setting_rcd
                ,default_system_setting_name = @default_system_setting_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_system_setting_rcd = @default_system_setting_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_system_setting_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingRcd;
                command.Parameters.Add("@default_system_setting_name",SqlDbType.NVarChar).Value = (System.String)DefaultSystemSettingName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string defaultSystemSettingRcd) {
            string sql = @" delete [default_system_setting_ref] 
                where default_system_setting_rcd = @default_system_setting_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_system_setting_rcd",SqlDbType.NVarChar).Value = defaultSystemSettingRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
