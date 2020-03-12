/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:38:53 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeDefaultRuleData {
        
        public System.Guid DefaultRuleId { get; set; } //;
        
        public string DefaultRuleTypeRcd { get; set; } //;
        
        public string Address { get; set; } //;
        
        public System.Guid DefaultUserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByDefaultRuleId(System.Guid defaultRuleId) {
            string sql = @" select top 1 default_rule_id, default_rule_type_rcd, address, default_user_id, date_time
                            from [default_rule]
                            where default_rule_id = @default_rule_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_rule_id",SqlDbType.UniqueIdentifier).Value = defaultRuleId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultRuleData GetByDefaultRuleId(System.Guid defaultRuleId) {
            string sql = @" select top 1 default_rule_id, default_rule_type_rcd, address, default_user_id, date_time
                            from [default_rule]
                            where default_rule_id = @default_rule_id";

            var ret = new CrudeDefaultRuleData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_rule_id",SqlDbType.UniqueIdentifier).Value = defaultRuleId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultRuleData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultRuleData>();

            string sql = @" select default_rule_id, default_rule_type_rcd, address, default_user_id, date_time
                            from [default_rule]
                            where default_user_id = @default_user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultRuleData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultRuleData> FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd) {
            var dataList = new List<CrudeDefaultRuleData>();

            string sql = @" select default_rule_id, default_rule_type_rcd, address, default_user_id, date_time
                            from [default_rule]
                            where default_rule_type_rcd = @default_rule_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_rule_type_rcd", SqlDbType.NVarChar).Value = defaultRuleTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultRuleData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultRuleData> FetchAll() {
            var dataList = new List<CrudeDefaultRuleData>();

            string sql = @" select default_rule_id, default_rule_type_rcd, address, default_user_id, date_time
                            from [default_rule]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultRuleData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultRuleData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultRuleData>();

            string sql = @" select top " + limit.ToString() + @" default_rule_id, default_rule_type_rcd, address, default_user_id, date_time
                            from [default_rule]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultRuleData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultRuleData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultRuleData>();

            string sql = @" select default_rule_id, default_rule_type_rcd, address, default_user_id, date_time
                            from [default_rule]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultRuleData();
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
            string sql = @" select count(*) as count from [default_rule]";

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
        
        public static List<CrudeDefaultRuleData> FetchWithFilter(System.Guid defaultRuleId, string defaultRuleTypeRcd, string address, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultRuleData>();

            string sql = @" select default_rule_id, default_rule_type_rcd, address, default_user_id, date_time
                            from [default_rule]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (defaultRuleId != Guid.Empty) {
                        sql += "  and default_rule_id = @default_rule_id";
                        command.Parameters.Add("@default_rule_id", SqlDbType.UniqueIdentifier).Value = defaultRuleId;
                    }
                    if (!string.IsNullOrEmpty(defaultRuleTypeRcd)) {
                        sql += "  and default_rule_type_rcd like '%' + @default_rule_type_rcd + '%'";
                        command.Parameters.Add("@default_rule_type_rcd", SqlDbType.NVarChar).Value = defaultRuleTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(address)) {
                        sql += "  and address like '%' + @address + '%'";
                        command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address.Replace("'","''");
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
                        var data = new CrudeDefaultRuleData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_rule_id"] != System.DBNull.Value) DefaultRuleId = (System.Guid) reader["default_rule_id"];
            if (reader["default_rule_type_rcd"] != System.DBNull.Value) DefaultRuleTypeRcd = (System.String) reader["default_rule_type_rcd"];
            if (reader["address"] != System.DBNull.Value) Address = (System.String) reader["address"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (DefaultRuleId == Guid.Empty)
                DefaultRuleId = Guid.NewGuid();

            string sql = "insert into [default_rule] (default_rule_id, default_rule_type_rcd, address, default_user_id, date_time)";
            sql += "            values (@default_rule_id, @default_rule_type_rcd, @address, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_rule_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultRuleId;
                    command.Parameters.Add("@default_rule_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultRuleTypeRcd;
                    command.Parameters.Add("@address",SqlDbType.NVarChar).Value = (System.String)Address;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultRuleId == Guid.Empty)
                DefaultRuleId = Guid.NewGuid();

            string sql = "insert into [default_rule] (default_rule_id, default_rule_type_rcd, address, default_user_id, date_time)";
            sql += "            values (@default_rule_id, @default_rule_type_rcd, @address, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_rule_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultRuleId;
                command.Parameters.Add("@default_rule_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultRuleTypeRcd;
                command.Parameters.Add("@address",SqlDbType.NVarChar).Value = (System.String)Address;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_rule] set
                 default_rule_id = @default_rule_id
                ,default_rule_type_rcd = @default_rule_type_rcd
                ,address = @address
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_rule_id = @default_rule_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_rule_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultRuleId;
                    command.Parameters.Add("@default_rule_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultRuleTypeRcd;
                    command.Parameters.Add("@address",SqlDbType.NVarChar).Value = (System.String)Address;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_rule] set
                 default_rule_id = @default_rule_id
                ,default_rule_type_rcd = @default_rule_type_rcd
                ,address = @address
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_rule_id = @default_rule_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_rule_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultRuleId;
                command.Parameters.Add("@default_rule_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultRuleTypeRcd;
                command.Parameters.Add("@address",SqlDbType.NVarChar).Value = (System.String)Address;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid defaultRuleId) {
            string sql = @" delete [default_rule] 
                where default_rule_id = @default_rule_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_rule_id",SqlDbType.UniqueIdentifier).Value = defaultRuleId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
