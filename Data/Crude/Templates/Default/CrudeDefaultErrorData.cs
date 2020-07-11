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
    public partial class CrudeDefaultErrorData {
        
        public System.Guid DefaultErrorId { get; set; }
        
        public string DefaultErrorLayerRcd { get; set; }
        
        public string DefaultErrorTypeRcd { get; set; }
        
        public string LayerAddress { get; set; }
        
        public string ErrorMessage { get; set; }
        
        public string StackTrace { get; set; }
        
        public string MethodName { get; set; }
        
        public string DomainName { get; set; }
        
        public string ClassName { get; set; }
        
        public System.Guid DefaultUserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public void FetchByDefaultErrorId(System.Guid defaultErrorId) {
            string sql = @" select top 1 default_error_id, default_error_layer_rcd, default_error_type_rcd, layer_address, error_message, stack_trace, method_name, domain_name, class_name, default_user_id, date_time
                            from [default_error]
                            where default_error_id = @default_error_id
                            order by method_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_error_id",SqlDbType.UniqueIdentifier).Value = defaultErrorId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultErrorData GetByDefaultErrorId(System.Guid defaultErrorId) {
            string sql = @" select top 1 default_error_id, default_error_layer_rcd, default_error_type_rcd, layer_address, error_message, stack_trace, method_name, domain_name, class_name, default_user_id, date_time
                            from [default_error]
                            where default_error_id = @default_error_id
                            order by method_name";

            var ret = new CrudeDefaultErrorData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_error_id",SqlDbType.UniqueIdentifier).Value = defaultErrorId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultErrorData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultErrorData>();

            string sql = @" select default_error_id, default_error_layer_rcd, default_error_type_rcd, layer_address, error_message, stack_trace, method_name, domain_name, class_name, default_user_id, date_time
                            from [default_error]
                            where default_user_id = @default_user_id
                              
                            order by method_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultErrorData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultErrorData> FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd) {
            var dataList = new List<CrudeDefaultErrorData>();

            string sql = @" select default_error_id, default_error_layer_rcd, default_error_type_rcd, layer_address, error_message, stack_trace, method_name, domain_name, class_name, default_user_id, date_time
                            from [default_error]
                            where default_error_layer_rcd = @default_error_layer_rcd
                              
                            order by method_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_error_layer_rcd", SqlDbType.NVarChar).Value = defaultErrorLayerRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultErrorData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultErrorData> FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd) {
            var dataList = new List<CrudeDefaultErrorData>();

            string sql = @" select default_error_id, default_error_layer_rcd, default_error_type_rcd, layer_address, error_message, stack_trace, method_name, domain_name, class_name, default_user_id, date_time
                            from [default_error]
                            where default_error_type_rcd = @default_error_type_rcd
                              
                            order by method_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_error_type_rcd", SqlDbType.NVarChar).Value = defaultErrorTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultErrorData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByMethodName(string methodName) {
            string sql = @" select top 1 default_error_id, default_error_layer_rcd, default_error_type_rcd, layer_address, error_message, stack_trace, method_name, domain_name, class_name, default_user_id, date_time
                            from [default_error]
                            where method_name like '%' + @methodName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@methodName",SqlDbType.NVarChar).Value = methodName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultErrorData> FetchAll() {
            var dataList = new List<CrudeDefaultErrorData>();

            string sql = @" select default_error_id, default_error_layer_rcd, default_error_type_rcd, layer_address, error_message, stack_trace, method_name, domain_name, class_name, default_user_id, date_time
                            from [default_error]
                            order by method_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultErrorData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultErrorData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultErrorData>();

            string sql = @" select top " + limit.ToString() + @" default_error_id, default_error_layer_rcd, default_error_type_rcd, layer_address, error_message, stack_trace, method_name, domain_name, class_name, default_user_id, date_time
                            from [default_error]
                            order by method_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultErrorData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultErrorData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultErrorData>();

            string sql = @" select default_error_id, default_error_layer_rcd, default_error_type_rcd, layer_address, error_message, stack_trace, method_name, domain_name, class_name, default_user_id, date_time
                            from [default_error]
                            order by method_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultErrorData();
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
            string sql = @" select count(*) as count from [default_error]";

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
        
        public static List<CrudeDefaultErrorData> FetchWithFilter(System.Guid defaultErrorId, string defaultErrorLayerRcd, string defaultErrorTypeRcd, string layerAddress, string errorMessage, string stackTrace, string methodName, string domainName, string className, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultErrorData>();

            string sql = @" select default_error_id, default_error_layer_rcd, default_error_type_rcd, layer_address, error_message, stack_trace, method_name, domain_name, class_name, default_user_id, date_time
                            from [default_error]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (defaultErrorId != Guid.Empty) {
                        sql += "  and default_error_id = @default_error_id";
                        command.Parameters.Add("@default_error_id", SqlDbType.UniqueIdentifier).Value = defaultErrorId;
                    }
                    if (!string.IsNullOrEmpty(defaultErrorLayerRcd)) {
                        sql += "  and default_error_layer_rcd like '%' + @default_error_layer_rcd + '%'";
                        command.Parameters.Add("@default_error_layer_rcd", SqlDbType.NVarChar).Value = defaultErrorLayerRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultErrorTypeRcd)) {
                        sql += "  and default_error_type_rcd like '%' + @default_error_type_rcd + '%'";
                        command.Parameters.Add("@default_error_type_rcd", SqlDbType.NVarChar).Value = defaultErrorTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(layerAddress)) {
                        sql += "  and layer_address like '%' + @layer_address + '%'";
                        command.Parameters.Add("@layer_address", SqlDbType.NVarChar).Value = layerAddress.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(errorMessage)) {
                        sql += "  and error_message like '%' + @error_message + '%'";
                        command.Parameters.Add("@error_message", SqlDbType.NVarChar).Value = errorMessage.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(stackTrace)) {
                        sql += "  and stack_trace like '%' + @stack_trace + '%'";
                        command.Parameters.Add("@stack_trace", SqlDbType.NVarChar).Value = stackTrace.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(methodName)) {
                        sql += "  and method_name like '%' + @method_name + '%'";
                        command.Parameters.Add("@method_name", SqlDbType.NVarChar).Value = methodName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(domainName)) {
                        sql += "  and domain_name like '%' + @domain_name + '%'";
                        command.Parameters.Add("@domain_name", SqlDbType.NVarChar).Value = domainName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(className)) {
                        sql += "  and class_name like '%' + @class_name + '%'";
                        command.Parameters.Add("@class_name", SqlDbType.NVarChar).Value = className.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by method_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultErrorData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_error_id"] != System.DBNull.Value) DefaultErrorId = (System.Guid) reader["default_error_id"];
            if (reader["default_error_layer_rcd"] != System.DBNull.Value) DefaultErrorLayerRcd = (System.String) reader["default_error_layer_rcd"];
            if (reader["default_error_type_rcd"] != System.DBNull.Value) DefaultErrorTypeRcd = (System.String) reader["default_error_type_rcd"];
            if (reader["layer_address"] != System.DBNull.Value) LayerAddress = (System.String) reader["layer_address"];
            if (reader["error_message"] != System.DBNull.Value) ErrorMessage = (System.String) reader["error_message"];
            if (reader["stack_trace"] != System.DBNull.Value) StackTrace = (System.String) reader["stack_trace"];
            if (reader["method_name"] != System.DBNull.Value) MethodName = (System.String) reader["method_name"];
            if (reader["domain_name"] != System.DBNull.Value) DomainName = (System.String) reader["domain_name"];
            if (reader["class_name"] != System.DBNull.Value) ClassName = (System.String) reader["class_name"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (DefaultErrorId == Guid.Empty)
                DefaultErrorId = Guid.NewGuid();

            string sql = "insert into [default_error] (default_error_id, default_error_layer_rcd, default_error_type_rcd, layer_address, error_message, stack_trace, method_name, domain_name, class_name, default_user_id, date_time)";
            sql += "            values (@default_error_id, @default_error_layer_rcd, @default_error_type_rcd, @layer_address, @error_message, @stack_trace, @method_name, @domain_name, @class_name, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_error_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultErrorId;
                    command.Parameters.Add("@default_error_layer_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorLayerRcd;
                    command.Parameters.Add("@default_error_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorTypeRcd;
                    command.Parameters.Add("@layer_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(LayerAddress)) ? (object)DBNull.Value : (System.String)LayerAddress;
                    command.Parameters.Add("@error_message",SqlDbType.NVarChar).Value = (System.String)ErrorMessage;
                    command.Parameters.Add("@stack_trace",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(StackTrace)) ? (object)DBNull.Value : (System.String)StackTrace;
                    command.Parameters.Add("@method_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(MethodName)) ? (object)DBNull.Value : (System.String)MethodName;
                    command.Parameters.Add("@domain_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(DomainName)) ? (object)DBNull.Value : (System.String)DomainName;
                    command.Parameters.Add("@class_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClassName)) ? (object)DBNull.Value : (System.String)ClassName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultErrorId == Guid.Empty)
                DefaultErrorId = Guid.NewGuid();

            string sql = "insert into [default_error] (default_error_id, default_error_layer_rcd, default_error_type_rcd, layer_address, error_message, stack_trace, method_name, domain_name, class_name, default_user_id, date_time)";
            sql += "            values (@default_error_id, @default_error_layer_rcd, @default_error_type_rcd, @layer_address, @error_message, @stack_trace, @method_name, @domain_name, @class_name, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_error_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultErrorId;
                command.Parameters.Add("@default_error_layer_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorLayerRcd;
                command.Parameters.Add("@default_error_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorTypeRcd;
                command.Parameters.Add("@layer_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(LayerAddress)) ? (object)DBNull.Value : (System.String)LayerAddress;
                command.Parameters.Add("@error_message",SqlDbType.NVarChar).Value = (System.String)ErrorMessage;
                command.Parameters.Add("@stack_trace",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(StackTrace)) ? (object)DBNull.Value : (System.String)StackTrace;
                command.Parameters.Add("@method_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(MethodName)) ? (object)DBNull.Value : (System.String)MethodName;
                command.Parameters.Add("@domain_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(DomainName)) ? (object)DBNull.Value : (System.String)DomainName;
                command.Parameters.Add("@class_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClassName)) ? (object)DBNull.Value : (System.String)ClassName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_error] set
                 default_error_id = @default_error_id
                ,default_error_layer_rcd = @default_error_layer_rcd
                ,default_error_type_rcd = @default_error_type_rcd
                ,layer_address = @layer_address
                ,error_message = @error_message
                ,stack_trace = @stack_trace
                ,method_name = @method_name
                ,domain_name = @domain_name
                ,class_name = @class_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_error_id = @default_error_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_error_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultErrorId;
                    command.Parameters.Add("@default_error_layer_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorLayerRcd;
                    command.Parameters.Add("@default_error_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorTypeRcd;
                    command.Parameters.Add("@layer_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(LayerAddress)) ? (object)DBNull.Value : (System.String)LayerAddress;
                    command.Parameters.Add("@error_message",SqlDbType.NVarChar).Value = (System.String)ErrorMessage;
                    command.Parameters.Add("@stack_trace",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(StackTrace)) ? (object)DBNull.Value : (System.String)StackTrace;
                    command.Parameters.Add("@method_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(MethodName)) ? (object)DBNull.Value : (System.String)MethodName;
                    command.Parameters.Add("@domain_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(DomainName)) ? (object)DBNull.Value : (System.String)DomainName;
                    command.Parameters.Add("@class_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClassName)) ? (object)DBNull.Value : (System.String)ClassName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_error] set
                 default_error_id = @default_error_id
                ,default_error_layer_rcd = @default_error_layer_rcd
                ,default_error_type_rcd = @default_error_type_rcd
                ,layer_address = @layer_address
                ,error_message = @error_message
                ,stack_trace = @stack_trace
                ,method_name = @method_name
                ,domain_name = @domain_name
                ,class_name = @class_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_error_id = @default_error_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_error_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultErrorId;
                command.Parameters.Add("@default_error_layer_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorLayerRcd;
                command.Parameters.Add("@default_error_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultErrorTypeRcd;
                command.Parameters.Add("@layer_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(LayerAddress)) ? (object)DBNull.Value : (System.String)LayerAddress;
                command.Parameters.Add("@error_message",SqlDbType.NVarChar).Value = (System.String)ErrorMessage;
                command.Parameters.Add("@stack_trace",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(StackTrace)) ? (object)DBNull.Value : (System.String)StackTrace;
                command.Parameters.Add("@method_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(MethodName)) ? (object)DBNull.Value : (System.String)MethodName;
                command.Parameters.Add("@domain_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(DomainName)) ? (object)DBNull.Value : (System.String)DomainName;
                command.Parameters.Add("@class_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClassName)) ? (object)DBNull.Value : (System.String)ClassName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid defaultErrorId) {
            string sql = @" delete [default_error] 
                where default_error_id = @default_error_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_error_id",SqlDbType.UniqueIdentifier).Value = defaultErrorId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
