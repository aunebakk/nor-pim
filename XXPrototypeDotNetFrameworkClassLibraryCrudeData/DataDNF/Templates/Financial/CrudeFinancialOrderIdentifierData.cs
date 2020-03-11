/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:54:43 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeFinancialOrderIdentifierData {
        
        public System.Guid FinancialOrderIdentifierId { get; set; } //;
        
        public System.Guid FinancialOrderId { get; set; } //;
        
        public string FinancialOrderIdentifierTypeRcd { get; set; } //;
        
        public string FinancialOrderIdentifierCode { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByFinancialOrderIdentifierId(System.Guid financialOrderIdentifierId) {
            string sql = @" select top 1 financial_order_identifier_id, financial_order_id, financial_order_identifier_type_rcd, financial_order_identifier_code, user_id, date_time
                            from [financial_order_identifier]
                            where financial_order_identifier_id = @financial_order_identifier_id
                            order by financial_order_identifier_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_order_identifier_id",SqlDbType.UniqueIdentifier).Value = financialOrderIdentifierId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialOrderIdentifierData GetByFinancialOrderIdentifierId(System.Guid financialOrderIdentifierId) {
            string sql = @" select top 1 financial_order_identifier_id, financial_order_id, financial_order_identifier_type_rcd, financial_order_identifier_code, user_id, date_time
                            from [financial_order_identifier]
                            where financial_order_identifier_id = @financial_order_identifier_id
                            order by financial_order_identifier_code";

            var ret = new CrudeFinancialOrderIdentifierData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_identifier_id",SqlDbType.UniqueIdentifier).Value = financialOrderIdentifierId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialOrderIdentifierData> FetchByFinancialOrderId(System.Guid financialOrderId) {
            var dataList = new List<CrudeFinancialOrderIdentifierData>();

            string sql = @" select financial_order_identifier_id, financial_order_id, financial_order_identifier_type_rcd, financial_order_identifier_code, user_id, date_time
                            from [financial_order_identifier]
                            where financial_order_id = @financial_order_id
                              
                            order by financial_order_identifier_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_id", SqlDbType.UniqueIdentifier).Value = financialOrderId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderIdentifierData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialOrderIdentifierData>();

            string sql = @" select financial_order_identifier_id, financial_order_id, financial_order_identifier_type_rcd, financial_order_identifier_code, user_id, date_time
                            from [financial_order_identifier]
                            where user_id = @user_id
                              
                            order by financial_order_identifier_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderIdentifierData> FetchByFinancialOrderIdentifierTypeRcd(string financialOrderIdentifierTypeRcd) {
            var dataList = new List<CrudeFinancialOrderIdentifierData>();

            string sql = @" select financial_order_identifier_id, financial_order_id, financial_order_identifier_type_rcd, financial_order_identifier_code, user_id, date_time
                            from [financial_order_identifier]
                            where financial_order_identifier_type_rcd = @financial_order_identifier_type_rcd
                              
                            order by financial_order_identifier_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_identifier_type_rcd", SqlDbType.NVarChar).Value = financialOrderIdentifierTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderIdentifierData> FetchAll() {
            var dataList = new List<CrudeFinancialOrderIdentifierData>();

            string sql = @" select financial_order_identifier_id, financial_order_id, financial_order_identifier_type_rcd, financial_order_identifier_code, user_id, date_time
                            from [financial_order_identifier]
                            order by financial_order_identifier_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderIdentifierData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialOrderIdentifierData>();

            string sql = @" select top " + limit.ToString() + @" financial_order_identifier_id, financial_order_id, financial_order_identifier_type_rcd, financial_order_identifier_code, user_id, date_time
                            from [financial_order_identifier]
                            order by financial_order_identifier_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderIdentifierData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialOrderIdentifierData>();

            string sql = @" select financial_order_identifier_id, financial_order_id, financial_order_identifier_type_rcd, financial_order_identifier_code, user_id, date_time
                            from [financial_order_identifier]
                            order by financial_order_identifier_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialOrderIdentifierData();
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
            string sql = @" select count(*) as count from [financial_order_identifier]";

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
        
        public static List<CrudeFinancialOrderIdentifierData> FetchWithFilter(System.Guid financialOrderIdentifierId, System.Guid financialOrderId, string financialOrderIdentifierTypeRcd, string financialOrderIdentifierCode, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeFinancialOrderIdentifierData>();

            string sql = @" select financial_order_identifier_id, financial_order_id, financial_order_identifier_type_rcd, financial_order_identifier_code, user_id, date_time
                            from [financial_order_identifier]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialOrderIdentifierId != Guid.Empty) {
                        sql += "  and financial_order_identifier_id = @financial_order_identifier_id";
                        command.Parameters.Add("@financial_order_identifier_id", SqlDbType.UniqueIdentifier).Value = financialOrderIdentifierId;
                    }
                    if (financialOrderId != Guid.Empty) {
                        sql += "  and financial_order_id = @financial_order_id";
                        command.Parameters.Add("@financial_order_id", SqlDbType.UniqueIdentifier).Value = financialOrderId;
                    }
                    if (!string.IsNullOrEmpty(financialOrderIdentifierTypeRcd)) {
                        sql += "  and financial_order_identifier_type_rcd like '%' + @financial_order_identifier_type_rcd + '%'";
                        command.Parameters.Add("@financial_order_identifier_type_rcd", SqlDbType.NVarChar).Value = financialOrderIdentifierTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(financialOrderIdentifierCode)) {
                        sql += "  and financial_order_identifier_code like '%' + @financial_order_identifier_code + '%'";
                        command.Parameters.Add("@financial_order_identifier_code", SqlDbType.NVarChar).Value = financialOrderIdentifierCode.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by financial_order_identifier_code";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_order_identifier_id"] != System.DBNull.Value) FinancialOrderIdentifierId = (System.Guid) reader["financial_order_identifier_id"];
            if (reader["financial_order_id"] != System.DBNull.Value) FinancialOrderId = (System.Guid) reader["financial_order_id"];
            if (reader["financial_order_identifier_type_rcd"] != System.DBNull.Value) FinancialOrderIdentifierTypeRcd = (System.String) reader["financial_order_identifier_type_rcd"];
            if (reader["financial_order_identifier_code"] != System.DBNull.Value) FinancialOrderIdentifierCode = (System.String) reader["financial_order_identifier_code"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (FinancialOrderIdentifierId == Guid.Empty)
                FinancialOrderIdentifierId = Guid.NewGuid();

            string sql = "insert into [financial_order_identifier] (financial_order_identifier_id, financial_order_id, financial_order_identifier_type_rcd, financial_order_identifier_code, user_id, date_time)";
            sql += "            values (@financial_order_identifier_id, @financial_order_id, @financial_order_identifier_type_rcd, @financial_order_identifier_code, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_order_identifier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderIdentifierId;
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                    command.Parameters.Add("@financial_order_identifier_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeRcd;
                    command.Parameters.Add("@financial_order_identifier_code",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierCode;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialOrderIdentifierId == Guid.Empty)
                FinancialOrderIdentifierId = Guid.NewGuid();

            string sql = "insert into [financial_order_identifier] (financial_order_identifier_id, financial_order_id, financial_order_identifier_type_rcd, financial_order_identifier_code, user_id, date_time)";
            sql += "            values (@financial_order_identifier_id, @financial_order_id, @financial_order_identifier_type_rcd, @financial_order_identifier_code, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_order_identifier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderIdentifierId;
                command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                command.Parameters.Add("@financial_order_identifier_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeRcd;
                command.Parameters.Add("@financial_order_identifier_code",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierCode;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_order_identifier] set
                 financial_order_identifier_id = @financial_order_identifier_id
                ,financial_order_id = @financial_order_id
                ,financial_order_identifier_type_rcd = @financial_order_identifier_type_rcd
                ,financial_order_identifier_code = @financial_order_identifier_code
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_order_identifier_id = @financial_order_identifier_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_order_identifier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderIdentifierId;
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                    command.Parameters.Add("@financial_order_identifier_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeRcd;
                    command.Parameters.Add("@financial_order_identifier_code",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierCode;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_order_identifier] set
                 financial_order_identifier_id = @financial_order_identifier_id
                ,financial_order_id = @financial_order_id
                ,financial_order_identifier_type_rcd = @financial_order_identifier_type_rcd
                ,financial_order_identifier_code = @financial_order_identifier_code
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_order_identifier_id = @financial_order_identifier_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_order_identifier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderIdentifierId;
                command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                command.Parameters.Add("@financial_order_identifier_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeRcd;
                command.Parameters.Add("@financial_order_identifier_code",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierCode;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid financialOrderIdentifierId) {
            string sql = @" delete [financial_order_identifier] 
                where financial_order_identifier_id = @financial_order_identifier_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_identifier_id",SqlDbType.UniqueIdentifier).Value = financialOrderIdentifierId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
