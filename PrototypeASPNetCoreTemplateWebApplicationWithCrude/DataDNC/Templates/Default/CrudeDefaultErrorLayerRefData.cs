/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:25:17 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class DefaultErrorLayerRef {
        
        public const string BusinessLogicLayer = "BLL";
        
        public const string BusinessLayerEngine = "BLLEngine";
        
        public const string BusinessLogicLayerRest = "BLLRest";
        
        public const string BusinessLogicLayerSoap = "BLLSoap";
        
        public const string ClientEngine = "CEngine";
        
        public const string Database = "DB";
        
        public const string DataAccessLayer = "DLL";
        
        public const string Documentation = "DOC";
        
        public const string ASPModelViewController = "MVC";
        
        public const string ClientProxy = "Proxy";
        
        public const string Sql2Wcf = "S2W";
        
        public const string AutomatedTesting = "Test";
        
        public const string TestFront = "TestF";
        
        public const string WindowsWinforms = "WinForms";
    }
    
    //[Serializable()]
    public partial class CrudeDefaultErrorLayerRefData {
        
        public string DefaultErrorLayerRcd { get; set; } //;
        
        public string DefaultErrorLayerName { get; set; } //;
        
        public System.Guid DefaultUserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd) {
            string sql = @" select top 1 default_error_layer_rcd, default_error_layer_name, default_user_id, date_time
                            from [default_error_layer_ref]
                            where default_error_layer_rcd = @default_error_layer_rcd
                            order by default_error_layer_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_error_layer_rcd",SqlDbType.NVarChar).Value = defaultErrorLayerRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultErrorLayerRefData GetByDefaultErrorLayerRcd(string defaultErrorLayerRcd) {
            string sql = @" select top 1 default_error_layer_rcd, default_error_layer_name, default_user_id, date_time
                            from [default_error_layer_ref]
                            where default_error_layer_rcd = @default_error_layer_rcd
                            order by default_error_layer_name";

            var ret = new CrudeDefaultErrorLayerRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_error_layer_rcd",SqlDbType.NVarChar).Value = defaultErrorLayerRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultErrorLayerRefData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultErrorLayerRefData>();

            string sql = @" select default_error_layer_rcd, default_error_layer_name, default_user_id, date_time
                            from [default_error_layer_ref]
                            where default_user_id = @default_user_id
                              
                            order by default_error_layer_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultErrorLayerRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByDefaultErrorLayerName(string defaultErrorLayerName) {
            string sql = @" select top 1 default_error_layer_rcd, default_error_layer_name, default_user_id, date_time
                            from [default_error_layer_ref]
                            where default_error_layer_name like '%' + @defaultErrorLayerName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@defaultErrorLayerName",SqlDbType.NVarChar).Value = defaultErrorLayerName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultErrorLayerRefData> FetchAll() {
            var dataList = new List<CrudeDefaultErrorLayerRefData>();

            string sql = @" select default_error_layer_rcd, default_error_layer_name, default_user_id, date_time
                            from [default_error_layer_ref]
                            order by default_error_layer_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultErrorLayerRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultErrorLayerRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultErrorLayerRefData>();

            string sql = @" select top " + limit.ToString() + @" default_error_layer_rcd, default_error_layer_name, default_user_id, date_time
                            from [default_error_layer_ref]
                            order by default_error_layer_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultErrorLayerRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultErrorLayerRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultErrorLayerRefData>();

            string sql = @" select default_error_layer_rcd, default_error_layer_name, default_user_id, date_time
                            from [default_error_layer_ref]
                            order by default_error_layer_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultErrorLayerRefData();
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
            string sql = @" select count(*) as count from [default_error_layer_ref]";

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
        
        public static List<CrudeDefaultErrorLayerRefData> FetchWithFilter(string defaultErrorLayerRcd, string defaultErrorLayerName, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultErrorLayerRefData>();

            string sql = @" select default_error_layer_rcd, default_error_layer_name, default_user_id, date_time
                            from [default_error_layer_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(defaultErrorLayerRcd)) {
                        sql += "  and default_error_layer_rcd like '%' + @default_error_layer_rcd + '%'";
                        command.Parameters.Add("@default_error_layer_rcd", SqlDbType.NVarChar).Value = defaultErrorLayerRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultErrorLayerName)) {
                        sql += "  and default_error_layer_name like '%' + @default_error_layer_name + '%'";
                        command.Parameters.Add("@default_error_layer_name", SqlDbType.NVarChar).Value = defaultErrorLayerName.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by default_error_layer_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultErrorLayerRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_error_layer_rcd"] != System.DBNull.Value) DefaultErrorLayerRcd = (System.String) reader["default_error_layer_rcd"];
            if (reader["default_error_layer_name"] != System.DBNull.Value) DefaultErrorLayerName = (System.String) reader["default_error_layer_name"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [default_error_layer_ref] (default_error_layer_rcd, default_error_layer_name, default_user_id, date_time)";
            sql += "            values (@default_error_layer_rcd, @default_error_layer_name, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_error_layer_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorLayerRcd;
                    command.Parameters.Add("@default_error_layer_name",SqlDbType.NVarChar).Value = (System.String)DefaultErrorLayerName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [default_error_layer_ref] (default_error_layer_rcd, default_error_layer_name, default_user_id, date_time)";
            sql += "            values (@default_error_layer_rcd, @default_error_layer_name, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_error_layer_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorLayerRcd;
                command.Parameters.Add("@default_error_layer_name",SqlDbType.NVarChar).Value = (System.String)DefaultErrorLayerName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_error_layer_ref] set
                 default_error_layer_rcd = @default_error_layer_rcd
                ,default_error_layer_name = @default_error_layer_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_error_layer_rcd = @default_error_layer_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_error_layer_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorLayerRcd;
                    command.Parameters.Add("@default_error_layer_name",SqlDbType.NVarChar).Value = (System.String)DefaultErrorLayerName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_error_layer_ref] set
                 default_error_layer_rcd = @default_error_layer_rcd
                ,default_error_layer_name = @default_error_layer_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_error_layer_rcd = @default_error_layer_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_error_layer_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorLayerRcd;
                command.Parameters.Add("@default_error_layer_name",SqlDbType.NVarChar).Value = (System.String)DefaultErrorLayerName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string defaultErrorLayerRcd) {
            string sql = @" delete [default_error_layer_ref] 
                where default_error_layer_rcd = @default_error_layer_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_error_layer_rcd",SqlDbType.NVarChar).Value = defaultErrorLayerRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
