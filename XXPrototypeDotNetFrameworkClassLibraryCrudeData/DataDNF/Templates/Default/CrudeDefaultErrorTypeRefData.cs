/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:19:15 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    public partial class DefaultErrorTypeRef {
        
        public const string Engine = "Engine";
        
        public const string SilentCaught = "Silent";
        
        public const string AutomatedTest = "Test";
        
        public const string UserInitiated = "User";
    }
    
    [Serializable()]
    public partial class CrudeDefaultErrorTypeRefData {
        
        public string DefaultErrorTypeRcd { get; set; } //;
        
        public string DefaultErrorTypeName { get; set; } //;
        
        public System.Guid DefaultUserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd) {
            string sql = @" select top 1 default_error_type_rcd, default_error_type_name, default_user_id, date_time
                            from [default_error_type_ref]
                            where default_error_type_rcd = @default_error_type_rcd
                            order by default_error_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_error_type_rcd",SqlDbType.NVarChar).Value = defaultErrorTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultErrorTypeRefData GetByDefaultErrorTypeRcd(string defaultErrorTypeRcd) {
            string sql = @" select top 1 default_error_type_rcd, default_error_type_name, default_user_id, date_time
                            from [default_error_type_ref]
                            where default_error_type_rcd = @default_error_type_rcd
                            order by default_error_type_name";

            var ret = new CrudeDefaultErrorTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_error_type_rcd",SqlDbType.NVarChar).Value = defaultErrorTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultErrorTypeRefData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultErrorTypeRefData>();

            string sql = @" select default_error_type_rcd, default_error_type_name, default_user_id, date_time
                            from [default_error_type_ref]
                            where default_user_id = @default_user_id
                              
                            order by default_error_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultErrorTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByDefaultErrorTypeName(string defaultErrorTypeName) {
            string sql = @" select top 1 default_error_type_rcd, default_error_type_name, default_user_id, date_time
                            from [default_error_type_ref]
                            where default_error_type_name like '%' + @defaultErrorTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@defaultErrorTypeName",SqlDbType.NVarChar).Value = defaultErrorTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultErrorTypeRefData> FetchAll() {
            var dataList = new List<CrudeDefaultErrorTypeRefData>();

            string sql = @" select default_error_type_rcd, default_error_type_name, default_user_id, date_time
                            from [default_error_type_ref]
                            order by default_error_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultErrorTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultErrorTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultErrorTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" default_error_type_rcd, default_error_type_name, default_user_id, date_time
                            from [default_error_type_ref]
                            order by default_error_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultErrorTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultErrorTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultErrorTypeRefData>();

            string sql = @" select default_error_type_rcd, default_error_type_name, default_user_id, date_time
                            from [default_error_type_ref]
                            order by default_error_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultErrorTypeRefData();
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
            string sql = @" select count(*) as count from [default_error_type_ref]";

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
        
        public static List<CrudeDefaultErrorTypeRefData> FetchWithFilter(string defaultErrorTypeRcd, string defaultErrorTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultErrorTypeRefData>();

            string sql = @" select default_error_type_rcd, default_error_type_name, default_user_id, date_time
                            from [default_error_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(defaultErrorTypeRcd)) {
                        sql += "  and default_error_type_rcd like '%' + @default_error_type_rcd + '%'";
                        command.Parameters.Add("@default_error_type_rcd", SqlDbType.NVarChar).Value = defaultErrorTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultErrorTypeName)) {
                        sql += "  and default_error_type_name like '%' + @default_error_type_name + '%'";
                        command.Parameters.Add("@default_error_type_name", SqlDbType.NVarChar).Value = defaultErrorTypeName.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by default_error_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultErrorTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_error_type_rcd"] != System.DBNull.Value) DefaultErrorTypeRcd = (System.String) reader["default_error_type_rcd"];
            if (reader["default_error_type_name"] != System.DBNull.Value) DefaultErrorTypeName = (System.String) reader["default_error_type_name"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [default_error_type_ref] (default_error_type_rcd, default_error_type_name, default_user_id, date_time)";
            sql += "            values (@default_error_type_rcd, @default_error_type_name, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_error_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorTypeRcd;
                    command.Parameters.Add("@default_error_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultErrorTypeName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [default_error_type_ref] (default_error_type_rcd, default_error_type_name, default_user_id, date_time)";
            sql += "            values (@default_error_type_rcd, @default_error_type_name, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_error_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorTypeRcd;
                command.Parameters.Add("@default_error_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultErrorTypeName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_error_type_ref] set
                 default_error_type_rcd = @default_error_type_rcd
                ,default_error_type_name = @default_error_type_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_error_type_rcd = @default_error_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_error_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorTypeRcd;
                    command.Parameters.Add("@default_error_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultErrorTypeName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_error_type_ref] set
                 default_error_type_rcd = @default_error_type_rcd
                ,default_error_type_name = @default_error_type_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_error_type_rcd = @default_error_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_error_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorTypeRcd;
                command.Parameters.Add("@default_error_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultErrorTypeName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string defaultErrorTypeRcd) {
            string sql = @" delete [default_error_type_ref] 
                where default_error_type_rcd = @default_error_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_error_type_rcd",SqlDbType.NVarChar).Value = defaultErrorTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
