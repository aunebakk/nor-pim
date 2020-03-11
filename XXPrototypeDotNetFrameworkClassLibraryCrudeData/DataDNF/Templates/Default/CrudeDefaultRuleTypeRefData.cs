/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:54:22 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    public partial class DefaultRuleTypeRef {
        
        public const string HideLayerAddress = "Hide";
    }
    
    [Serializable()]
    public partial class CrudeDefaultRuleTypeRefData {
        
        public string DefaultRuleTypeRcd { get; set; } //;
        
        public string DefaultRuleTypeName { get; set; } //;
        
        public System.Guid DefaultUserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByDefaultRuleTypeRcd(string defaultRuleTypeRcd) {
            string sql = @" select top 1 default_rule_type_rcd, default_rule_type_name, default_user_id, date_time
                            from [default_rule_type_ref]
                            where default_rule_type_rcd = @default_rule_type_rcd
                            order by default_rule_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_rule_type_rcd",SqlDbType.NVarChar).Value = defaultRuleTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultRuleTypeRefData GetByDefaultRuleTypeRcd(string defaultRuleTypeRcd) {
            string sql = @" select top 1 default_rule_type_rcd, default_rule_type_name, default_user_id, date_time
                            from [default_rule_type_ref]
                            where default_rule_type_rcd = @default_rule_type_rcd
                            order by default_rule_type_name";

            var ret = new CrudeDefaultRuleTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_rule_type_rcd",SqlDbType.NVarChar).Value = defaultRuleTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultRuleTypeRefData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultRuleTypeRefData>();

            string sql = @" select default_rule_type_rcd, default_rule_type_name, default_user_id, date_time
                            from [default_rule_type_ref]
                            where default_user_id = @default_user_id
                              
                            order by default_rule_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultRuleTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByDefaultRuleTypeName(string defaultRuleTypeName) {
            string sql = @" select top 1 default_rule_type_rcd, default_rule_type_name, default_user_id, date_time
                            from [default_rule_type_ref]
                            where default_rule_type_name like '%' + @defaultRuleTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@defaultRuleTypeName",SqlDbType.NVarChar).Value = defaultRuleTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultRuleTypeRefData> FetchAll() {
            var dataList = new List<CrudeDefaultRuleTypeRefData>();

            string sql = @" select default_rule_type_rcd, default_rule_type_name, default_user_id, date_time
                            from [default_rule_type_ref]
                            order by default_rule_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultRuleTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultRuleTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultRuleTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" default_rule_type_rcd, default_rule_type_name, default_user_id, date_time
                            from [default_rule_type_ref]
                            order by default_rule_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultRuleTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultRuleTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultRuleTypeRefData>();

            string sql = @" select default_rule_type_rcd, default_rule_type_name, default_user_id, date_time
                            from [default_rule_type_ref]
                            order by default_rule_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultRuleTypeRefData();
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
            string sql = @" select count(*) as count from [default_rule_type_ref]";

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
        
        public static List<CrudeDefaultRuleTypeRefData> FetchWithFilter(string defaultRuleTypeRcd, string defaultRuleTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultRuleTypeRefData>();

            string sql = @" select default_rule_type_rcd, default_rule_type_name, default_user_id, date_time
                            from [default_rule_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(defaultRuleTypeRcd)) {
                        sql += "  and default_rule_type_rcd like '%' + @default_rule_type_rcd + '%'";
                        command.Parameters.Add("@default_rule_type_rcd", SqlDbType.NVarChar).Value = defaultRuleTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultRuleTypeName)) {
                        sql += "  and default_rule_type_name like '%' + @default_rule_type_name + '%'";
                        command.Parameters.Add("@default_rule_type_name", SqlDbType.NVarChar).Value = defaultRuleTypeName.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by default_rule_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultRuleTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_rule_type_rcd"] != System.DBNull.Value) DefaultRuleTypeRcd = (System.String) reader["default_rule_type_rcd"];
            if (reader["default_rule_type_name"] != System.DBNull.Value) DefaultRuleTypeName = (System.String) reader["default_rule_type_name"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [default_rule_type_ref] (default_rule_type_rcd, default_rule_type_name, default_user_id, date_time)";
            sql += "            values (@default_rule_type_rcd, @default_rule_type_name, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_rule_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultRuleTypeRcd;
                    command.Parameters.Add("@default_rule_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultRuleTypeName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [default_rule_type_ref] (default_rule_type_rcd, default_rule_type_name, default_user_id, date_time)";
            sql += "            values (@default_rule_type_rcd, @default_rule_type_name, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_rule_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultRuleTypeRcd;
                command.Parameters.Add("@default_rule_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultRuleTypeName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_rule_type_ref] set
                 default_rule_type_rcd = @default_rule_type_rcd
                ,default_rule_type_name = @default_rule_type_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_rule_type_rcd = @default_rule_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_rule_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultRuleTypeRcd;
                    command.Parameters.Add("@default_rule_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultRuleTypeName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_rule_type_ref] set
                 default_rule_type_rcd = @default_rule_type_rcd
                ,default_rule_type_name = @default_rule_type_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_rule_type_rcd = @default_rule_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_rule_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultRuleTypeRcd;
                command.Parameters.Add("@default_rule_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultRuleTypeName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string defaultRuleTypeRcd) {
            string sql = @" delete [default_rule_type_ref] 
                where default_rule_type_rcd = @default_rule_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_rule_type_rcd",SqlDbType.NVarChar).Value = defaultRuleTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
