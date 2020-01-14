﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:22:57 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class FinancialCurrencyTypeRef {
        
        public const string Euro = "EUR";
        
        public const string NorwegianKrone = "NOK";
        
        public const string SwedishKrona = "SEK";
        
        public const string ThaiBath = "THB";
        
        public const string UnitedStatesDollar = "USD";
    }
    
    //[Serializable()]
    public partial class CrudeFinancialCurrencyTypeRefData {
        
        public string FinancialCurrencyTypeRcd { get; set; } //;
        
        public string FinancialCurrencyTypeName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public int DecimalCount { get; set; } //;
        
        public string FinancialCurrencyTypeCode { get; set; } //;
        
        public void FetchByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd) {
            string sql = @" select top 1 financial_currency_type_rcd, financial_currency_type_name, user_id, date_time, decimal_count, financial_currency_type_code
                            from [financial_currency_type_ref]
                            where financial_currency_type_rcd = @financial_currency_type_rcd
                            order by financial_currency_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_currency_type_rcd",SqlDbType.NVarChar).Value = financialCurrencyTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialCurrencyTypeRefData GetByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd) {
            string sql = @" select top 1 financial_currency_type_rcd, financial_currency_type_name, user_id, date_time, decimal_count, financial_currency_type_code
                            from [financial_currency_type_ref]
                            where financial_currency_type_rcd = @financial_currency_type_rcd
                            order by financial_currency_type_name";

            var ret = new CrudeFinancialCurrencyTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_currency_type_rcd",SqlDbType.NVarChar).Value = financialCurrencyTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialCurrencyTypeRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialCurrencyTypeRefData>();

            string sql = @" select financial_currency_type_rcd, financial_currency_type_name, user_id, date_time, decimal_count, financial_currency_type_code
                            from [financial_currency_type_ref]
                            where user_id = @user_id
                              
                            order by financial_currency_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCurrencyTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByFinancialCurrencyTypeName(string financialCurrencyTypeName) {
            string sql = @" select top 1 financial_currency_type_rcd, financial_currency_type_name, user_id, date_time, decimal_count, financial_currency_type_code
                            from [financial_currency_type_ref]
                            where financial_currency_type_name like '%' + @financialCurrencyTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@financialCurrencyTypeName",SqlDbType.NVarChar).Value = financialCurrencyTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeFinancialCurrencyTypeRefData> FetchAll() {
            var dataList = new List<CrudeFinancialCurrencyTypeRefData>();

            string sql = @" select financial_currency_type_rcd, financial_currency_type_name, user_id, date_time, decimal_count, financial_currency_type_code
                            from [financial_currency_type_ref]
                            order by financial_currency_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCurrencyTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCurrencyTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialCurrencyTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" financial_currency_type_rcd, financial_currency_type_name, user_id, date_time, decimal_count, financial_currency_type_code
                            from [financial_currency_type_ref]
                            order by financial_currency_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCurrencyTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCurrencyTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialCurrencyTypeRefData>();

            string sql = @" select financial_currency_type_rcd, financial_currency_type_name, user_id, date_time, decimal_count, financial_currency_type_code
                            from [financial_currency_type_ref]
                            order by financial_currency_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialCurrencyTypeRefData();
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
            string sql = @" select count(*) as count from [financial_currency_type_ref]";

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
        
        public static List<CrudeFinancialCurrencyTypeRefData> FetchWithFilter(string financialCurrencyTypeRcd, string financialCurrencyTypeName, System.Guid userId, System.DateTime dateTime, int decimalCount, string financialCurrencyTypeCode) {
            var dataList = new List<CrudeFinancialCurrencyTypeRefData>();

            string sql = @" select financial_currency_type_rcd, financial_currency_type_name, user_id, date_time, decimal_count, financial_currency_type_code
                            from [financial_currency_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(financialCurrencyTypeRcd)) {
                        sql += "  and financial_currency_type_rcd like '%' + @financial_currency_type_rcd + '%'";
                        command.Parameters.Add("@financial_currency_type_rcd", SqlDbType.NVarChar).Value = financialCurrencyTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(financialCurrencyTypeName)) {
                        sql += "  and financial_currency_type_name like '%' + @financial_currency_type_name + '%'";
                        command.Parameters.Add("@financial_currency_type_name", SqlDbType.NVarChar).Value = financialCurrencyTypeName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (decimalCount != 0) {
                        sql += "  and decimal_count = @decimal_count";
                        command.Parameters.Add("@decimal_count", SqlDbType.Int).Value = decimalCount;
                    }
                    if (!string.IsNullOrEmpty(financialCurrencyTypeCode)) {
                        sql += "  and financial_currency_type_code like '%' + @financial_currency_type_code + '%'";
                        command.Parameters.Add("@financial_currency_type_code", SqlDbType.NVarChar).Value = financialCurrencyTypeCode.Replace("'","''");
                    }
                    sql += " order by financial_currency_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCurrencyTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_currency_type_rcd"] != System.DBNull.Value) FinancialCurrencyTypeRcd = (System.String) reader["financial_currency_type_rcd"];
            if (reader["financial_currency_type_name"] != System.DBNull.Value) FinancialCurrencyTypeName = (System.String) reader["financial_currency_type_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["decimal_count"] != System.DBNull.Value) DecimalCount = (System.Int32) reader["decimal_count"];
            if (reader["financial_currency_type_code"] != System.DBNull.Value) FinancialCurrencyTypeCode = (System.String) reader["financial_currency_type_code"];
        }
        
        public void Insert() {

            string sql = "insert into [financial_currency_type_ref] (financial_currency_type_rcd, financial_currency_type_name, user_id, date_time, decimal_count, financial_currency_type_code)";
            sql += "            values (@financial_currency_type_rcd, @financial_currency_type_name, @user_id, @date_time, @decimal_count, @financial_currency_type_code)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_currency_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCurrencyTypeRcd;
                    command.Parameters.Add("@financial_currency_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialCurrencyTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@decimal_count",SqlDbType.Int).Value = (System.Int32)DecimalCount;
                    command.Parameters.Add("@financial_currency_type_code",SqlDbType.NVarChar).Value = (System.String)FinancialCurrencyTypeCode;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [financial_currency_type_ref] (financial_currency_type_rcd, financial_currency_type_name, user_id, date_time, decimal_count, financial_currency_type_code)";
            sql += "            values (@financial_currency_type_rcd, @financial_currency_type_name, @user_id, @date_time, @decimal_count, @financial_currency_type_code)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_currency_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCurrencyTypeRcd;
                command.Parameters.Add("@financial_currency_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialCurrencyTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@decimal_count",SqlDbType.Int).Value = (System.Int32)DecimalCount;
                command.Parameters.Add("@financial_currency_type_code",SqlDbType.NVarChar).Value = (System.String)FinancialCurrencyTypeCode;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_currency_type_ref] set
                 financial_currency_type_rcd = @financial_currency_type_rcd
                ,financial_currency_type_name = @financial_currency_type_name
                ,user_id = @user_id
                ,date_time = @date_time
                ,decimal_count = @decimal_count
                ,financial_currency_type_code = @financial_currency_type_code
            where financial_currency_type_rcd = @financial_currency_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_currency_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCurrencyTypeRcd;
                    command.Parameters.Add("@financial_currency_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialCurrencyTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@decimal_count",SqlDbType.Int).Value = (System.Int32)DecimalCount;
                    command.Parameters.Add("@financial_currency_type_code",SqlDbType.NVarChar).Value = (System.String)FinancialCurrencyTypeCode;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_currency_type_ref] set
                 financial_currency_type_rcd = @financial_currency_type_rcd
                ,financial_currency_type_name = @financial_currency_type_name
                ,user_id = @user_id
                ,date_time = @date_time
                ,decimal_count = @decimal_count
                ,financial_currency_type_code = @financial_currency_type_code
            where financial_currency_type_rcd = @financial_currency_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_currency_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCurrencyTypeRcd;
                command.Parameters.Add("@financial_currency_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialCurrencyTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@decimal_count",SqlDbType.Int).Value = (System.Int32)DecimalCount;
                command.Parameters.Add("@financial_currency_type_code",SqlDbType.NVarChar).Value = (System.String)FinancialCurrencyTypeCode;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string financialCurrencyTypeRcd) {
            string sql = @" delete [financial_currency_type_ref] 
                where financial_currency_type_rcd = @financial_currency_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_currency_type_rcd",SqlDbType.NVarChar).Value = financialCurrencyTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
