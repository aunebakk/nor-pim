/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:57:17 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    public partial class FinancialUnitOfMeasurementRef {
        
        public const string Pieces = "P";
        
        public const string Meter = "M";
        
        public const string Centimeter = "C";
    }
    
    [Serializable()]
    public partial class CrudeFinancialUnitOfMeasurementRefData {
        
        public string FinancialUnitOfMeasurementRcd { get; set; } //;
        
        public int SortSequenceNumber { get; set; } //;
        
        public bool ChangeFlag { get; set; } //;
        
        public string StatusCode { get; set; } //;
        
        public string FinancialUnitOfMeasurementName { get; set; } //;
        
        public string FinancialUnitOfMeasurementCode { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByFinancialUnitOfMeasurementRcd(string financialUnitOfMeasurementRcd) {
            string sql = @" select top 1 financial_unit_of_measurement_rcd, sort_sequence_number, change_flag, status_code, financial_unit_of_measurement_name, financial_unit_of_measurement_code, user_id, date_time
                            from [financial_unit_of_measurement_ref]
                            where financial_unit_of_measurement_rcd = @financial_unit_of_measurement_rcd
                            order by financial_unit_of_measurement_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_unit_of_measurement_rcd",SqlDbType.NVarChar).Value = financialUnitOfMeasurementRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialUnitOfMeasurementRefData GetByFinancialUnitOfMeasurementRcd(string financialUnitOfMeasurementRcd) {
            string sql = @" select top 1 financial_unit_of_measurement_rcd, sort_sequence_number, change_flag, status_code, financial_unit_of_measurement_name, financial_unit_of_measurement_code, user_id, date_time
                            from [financial_unit_of_measurement_ref]
                            where financial_unit_of_measurement_rcd = @financial_unit_of_measurement_rcd
                            order by financial_unit_of_measurement_name";

            var ret = new CrudeFinancialUnitOfMeasurementRefData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_unit_of_measurement_rcd",SqlDbType.NVarChar).Value = financialUnitOfMeasurementRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialUnitOfMeasurementRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialUnitOfMeasurementRefData>();

            string sql = @" select financial_unit_of_measurement_rcd, sort_sequence_number, change_flag, status_code, financial_unit_of_measurement_name, financial_unit_of_measurement_code, user_id, date_time
                            from [financial_unit_of_measurement_ref]
                            where user_id = @user_id
                              
                            order by financial_unit_of_measurement_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialUnitOfMeasurementRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByFinancialUnitOfMeasurementName(string financialUnitOfMeasurementName) {
            string sql = @" select top 1 financial_unit_of_measurement_rcd, sort_sequence_number, change_flag, status_code, financial_unit_of_measurement_name, financial_unit_of_measurement_code, user_id, date_time
                            from [financial_unit_of_measurement_ref]
                            where financial_unit_of_measurement_name like '%' + @financialUnitOfMeasurementName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@financialUnitOfMeasurementName",SqlDbType.NVarChar).Value = financialUnitOfMeasurementName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeFinancialUnitOfMeasurementRefData> FetchAll() {
            var dataList = new List<CrudeFinancialUnitOfMeasurementRefData>();

            string sql = @" select financial_unit_of_measurement_rcd, sort_sequence_number, change_flag, status_code, financial_unit_of_measurement_name, financial_unit_of_measurement_code, user_id, date_time
                            from [financial_unit_of_measurement_ref]
                            order by financial_unit_of_measurement_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialUnitOfMeasurementRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialUnitOfMeasurementRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialUnitOfMeasurementRefData>();

            string sql = @" select top " + limit.ToString() + @" financial_unit_of_measurement_rcd, sort_sequence_number, change_flag, status_code, financial_unit_of_measurement_name, financial_unit_of_measurement_code, user_id, date_time
                            from [financial_unit_of_measurement_ref]
                            order by financial_unit_of_measurement_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialUnitOfMeasurementRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialUnitOfMeasurementRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialUnitOfMeasurementRefData>();

            string sql = @" select financial_unit_of_measurement_rcd, sort_sequence_number, change_flag, status_code, financial_unit_of_measurement_name, financial_unit_of_measurement_code, user_id, date_time
                            from [financial_unit_of_measurement_ref]
                            order by financial_unit_of_measurement_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialUnitOfMeasurementRefData();
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
            string sql = @" select count(*) as count from [financial_unit_of_measurement_ref]";

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
        
        public static List<CrudeFinancialUnitOfMeasurementRefData> FetchWithFilter(string financialUnitOfMeasurementRcd, int sortSequenceNumber, bool changeFlag, string statusCode, string financialUnitOfMeasurementName, string financialUnitOfMeasurementCode, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeFinancialUnitOfMeasurementRefData>();

            string sql = @" select financial_unit_of_measurement_rcd, sort_sequence_number, change_flag, status_code, financial_unit_of_measurement_name, financial_unit_of_measurement_code, user_id, date_time
                            from [financial_unit_of_measurement_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(financialUnitOfMeasurementRcd)) {
                        sql += "  and financial_unit_of_measurement_rcd like '%' + @financial_unit_of_measurement_rcd + '%'";
                        command.Parameters.Add("@financial_unit_of_measurement_rcd", SqlDbType.NVarChar).Value = financialUnitOfMeasurementRcd.Replace("'","''");
                    }
                    if (sortSequenceNumber != 0) {
                        sql += "  and sort_sequence_number = @sort_sequence_number";
                        command.Parameters.Add("@sort_sequence_number", SqlDbType.Int).Value = sortSequenceNumber;
                    }
                    if (changeFlag != false) {
                        sql += "  and change_flag = @change_flag";
                        command.Parameters.Add("@change_flag", SqlDbType.Bit).Value = changeFlag;
                    }
                    if (!string.IsNullOrEmpty(statusCode)) {
                        sql += "  and status_code like '%' + @status_code + '%'";
                        command.Parameters.Add("@status_code", SqlDbType.NVarChar).Value = statusCode.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(financialUnitOfMeasurementName)) {
                        sql += "  and financial_unit_of_measurement_name like '%' + @financial_unit_of_measurement_name + '%'";
                        command.Parameters.Add("@financial_unit_of_measurement_name", SqlDbType.NVarChar).Value = financialUnitOfMeasurementName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(financialUnitOfMeasurementCode)) {
                        sql += "  and financial_unit_of_measurement_code like '%' + @financial_unit_of_measurement_code + '%'";
                        command.Parameters.Add("@financial_unit_of_measurement_code", SqlDbType.NVarChar).Value = financialUnitOfMeasurementCode.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by financial_unit_of_measurement_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialUnitOfMeasurementRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_unit_of_measurement_rcd"] != System.DBNull.Value) FinancialUnitOfMeasurementRcd = (System.String) reader["financial_unit_of_measurement_rcd"];
            if (reader["sort_sequence_number"] != System.DBNull.Value) SortSequenceNumber = (System.Int32) reader["sort_sequence_number"];
            if (reader["change_flag"] != System.DBNull.Value) ChangeFlag = (System.Boolean) reader["change_flag"];
            if (reader["status_code"] != System.DBNull.Value) StatusCode = (System.String) reader["status_code"];
            if (reader["financial_unit_of_measurement_name"] != System.DBNull.Value) FinancialUnitOfMeasurementName = (System.String) reader["financial_unit_of_measurement_name"];
            if (reader["financial_unit_of_measurement_code"] != System.DBNull.Value) FinancialUnitOfMeasurementCode = (System.String) reader["financial_unit_of_measurement_code"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [financial_unit_of_measurement_ref] (financial_unit_of_measurement_rcd, sort_sequence_number, change_flag, status_code, financial_unit_of_measurement_name, financial_unit_of_measurement_code, user_id, date_time)";
            sql += "            values (@financial_unit_of_measurement_rcd, @sort_sequence_number, @change_flag, @status_code, @financial_unit_of_measurement_name, @financial_unit_of_measurement_code, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_unit_of_measurement_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementRcd;
                    command.Parameters.Add("@sort_sequence_number",SqlDbType.Int).Value = (System.Int32)SortSequenceNumber;
                    command.Parameters.Add("@change_flag",SqlDbType.Bit).Value = (System.Boolean)ChangeFlag;
                    command.Parameters.Add("@status_code",SqlDbType.NVarChar).Value = (System.String)StatusCode;
                    command.Parameters.Add("@financial_unit_of_measurement_name",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementName;
                    command.Parameters.Add("@financial_unit_of_measurement_code",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementCode;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [financial_unit_of_measurement_ref] (financial_unit_of_measurement_rcd, sort_sequence_number, change_flag, status_code, financial_unit_of_measurement_name, financial_unit_of_measurement_code, user_id, date_time)";
            sql += "            values (@financial_unit_of_measurement_rcd, @sort_sequence_number, @change_flag, @status_code, @financial_unit_of_measurement_name, @financial_unit_of_measurement_code, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_unit_of_measurement_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementRcd;
                command.Parameters.Add("@sort_sequence_number",SqlDbType.Int).Value = (System.Int32)SortSequenceNumber;
                command.Parameters.Add("@change_flag",SqlDbType.Bit).Value = (System.Boolean)ChangeFlag;
                command.Parameters.Add("@status_code",SqlDbType.NVarChar).Value = (System.String)StatusCode;
                command.Parameters.Add("@financial_unit_of_measurement_name",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementName;
                command.Parameters.Add("@financial_unit_of_measurement_code",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementCode;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_unit_of_measurement_ref] set
                 financial_unit_of_measurement_rcd = @financial_unit_of_measurement_rcd
                ,sort_sequence_number = @sort_sequence_number
                ,change_flag = @change_flag
                ,status_code = @status_code
                ,financial_unit_of_measurement_name = @financial_unit_of_measurement_name
                ,financial_unit_of_measurement_code = @financial_unit_of_measurement_code
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_unit_of_measurement_rcd = @financial_unit_of_measurement_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_unit_of_measurement_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementRcd;
                    command.Parameters.Add("@sort_sequence_number",SqlDbType.Int).Value = (System.Int32)SortSequenceNumber;
                    command.Parameters.Add("@change_flag",SqlDbType.Bit).Value = (System.Boolean)ChangeFlag;
                    command.Parameters.Add("@status_code",SqlDbType.NVarChar).Value = (System.String)StatusCode;
                    command.Parameters.Add("@financial_unit_of_measurement_name",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementName;
                    command.Parameters.Add("@financial_unit_of_measurement_code",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementCode;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_unit_of_measurement_ref] set
                 financial_unit_of_measurement_rcd = @financial_unit_of_measurement_rcd
                ,sort_sequence_number = @sort_sequence_number
                ,change_flag = @change_flag
                ,status_code = @status_code
                ,financial_unit_of_measurement_name = @financial_unit_of_measurement_name
                ,financial_unit_of_measurement_code = @financial_unit_of_measurement_code
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_unit_of_measurement_rcd = @financial_unit_of_measurement_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_unit_of_measurement_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementRcd;
                command.Parameters.Add("@sort_sequence_number",SqlDbType.Int).Value = (System.Int32)SortSequenceNumber;
                command.Parameters.Add("@change_flag",SqlDbType.Bit).Value = (System.Boolean)ChangeFlag;
                command.Parameters.Add("@status_code",SqlDbType.NVarChar).Value = (System.String)StatusCode;
                command.Parameters.Add("@financial_unit_of_measurement_name",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementName;
                command.Parameters.Add("@financial_unit_of_measurement_code",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementCode;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string financialUnitOfMeasurementRcd) {
            string sql = @" delete [financial_unit_of_measurement_ref] 
                where financial_unit_of_measurement_rcd = @financial_unit_of_measurement_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_unit_of_measurement_rcd",SqlDbType.NVarChar).Value = financialUnitOfMeasurementRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
