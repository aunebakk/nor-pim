/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:30:37 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeFinancialFeeData {
        
        public System.Guid FinancialFeeId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public string FinancialFeeTypeRcd { get; set; } //;
        
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        public decimal Amount { get; set; } //;
        
        public void FetchByFinancialFeeId(System.Guid financialFeeId) {
            string sql = @" select top 1 financial_fee_id, user_id, date_time, financial_fee_type_rcd, financial_currency_id, amount
                            from [financial_fee]
                            where financial_fee_id = @financial_fee_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_fee_id",SqlDbType.UniqueIdentifier).Value = financialFeeId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialFeeData GetByFinancialFeeId(System.Guid financialFeeId) {
            string sql = @" select top 1 financial_fee_id, user_id, date_time, financial_fee_type_rcd, financial_currency_id, amount
                            from [financial_fee]
                            where financial_fee_id = @financial_fee_id";

            var ret = new CrudeFinancialFeeData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_fee_id",SqlDbType.UniqueIdentifier).Value = financialFeeId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialFeeData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialFeeData>();

            string sql = @" select financial_fee_id, user_id, date_time, financial_fee_type_rcd, financial_currency_id, amount
                            from [financial_fee]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialFeeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialFeeData> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataList = new List<CrudeFinancialFeeData>();

            string sql = @" select financial_fee_id, user_id, date_time, financial_fee_type_rcd, financial_currency_id, amount
                            from [financial_fee]
                            where financial_currency_id = @financial_currency_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialFeeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialFeeData> FetchByFinancialFeeTypeRcd(string financialFeeTypeRcd) {
            var dataList = new List<CrudeFinancialFeeData>();

            string sql = @" select financial_fee_id, user_id, date_time, financial_fee_type_rcd, financial_currency_id, amount
                            from [financial_fee]
                            where financial_fee_type_rcd = @financial_fee_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_fee_type_rcd", SqlDbType.NVarChar).Value = financialFeeTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialFeeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialFeeData> FetchAll() {
            var dataList = new List<CrudeFinancialFeeData>();

            string sql = @" select financial_fee_id, user_id, date_time, financial_fee_type_rcd, financial_currency_id, amount
                            from [financial_fee]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialFeeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialFeeData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialFeeData>();

            string sql = @" select top " + limit.ToString() + @" financial_fee_id, user_id, date_time, financial_fee_type_rcd, financial_currency_id, amount
                            from [financial_fee]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialFeeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialFeeData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialFeeData>();

            string sql = @" select financial_fee_id, user_id, date_time, financial_fee_type_rcd, financial_currency_id, amount
                            from [financial_fee]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialFeeData();
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
            string sql = @" select count(*) as count from [financial_fee]";

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
        
        public static List<CrudeFinancialFeeData> FetchWithFilter(System.Guid financialFeeId, System.Guid userId, System.DateTime dateTime, string financialFeeTypeRcd, System.Guid financialCurrencyId, decimal amount) {
            var dataList = new List<CrudeFinancialFeeData>();

            string sql = @" select financial_fee_id, user_id, date_time, financial_fee_type_rcd, financial_currency_id, amount
                            from [financial_fee]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialFeeId != Guid.Empty) {
                        sql += "  and financial_fee_id = @financial_fee_id";
                        command.Parameters.Add("@financial_fee_id", SqlDbType.UniqueIdentifier).Value = financialFeeId;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (!string.IsNullOrEmpty(financialFeeTypeRcd)) {
                        sql += "  and financial_fee_type_rcd like '%' + @financial_fee_type_rcd + '%'";
                        command.Parameters.Add("@financial_fee_type_rcd", SqlDbType.NVarChar).Value = financialFeeTypeRcd.Replace("'","''");
                    }
                    if (financialCurrencyId != Guid.Empty) {
                        sql += "  and financial_currency_id = @financial_currency_id";
                        command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;
                    }
                    if (amount != 0) {
                        sql += "  and amount = @amount";
                        command.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialFeeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_fee_id"] != System.DBNull.Value) FinancialFeeId = (System.Guid) reader["financial_fee_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["financial_fee_type_rcd"] != System.DBNull.Value) FinancialFeeTypeRcd = (System.String) reader["financial_fee_type_rcd"];
            if (reader["financial_currency_id"] != System.DBNull.Value) FinancialCurrencyId = (System.Guid) reader["financial_currency_id"];
            if (reader["amount"] != System.DBNull.Value) Amount = (System.Decimal) reader["amount"];
        }
        
        public void Insert() {

            if (FinancialFeeId == Guid.Empty)
                FinancialFeeId = Guid.NewGuid();

            string sql = "insert into [financial_fee] (financial_fee_id, user_id, date_time, financial_fee_type_rcd, financial_currency_id, amount)";
            sql += "            values (@financial_fee_id, @user_id, @date_time, @financial_fee_type_rcd, @financial_currency_id, @amount)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_fee_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialFeeId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@financial_fee_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialFeeTypeRcd;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialFeeId == Guid.Empty)
                FinancialFeeId = Guid.NewGuid();

            string sql = "insert into [financial_fee] (financial_fee_id, user_id, date_time, financial_fee_type_rcd, financial_currency_id, amount)";
            sql += "            values (@financial_fee_id, @user_id, @date_time, @financial_fee_type_rcd, @financial_currency_id, @amount)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_fee_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialFeeId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@financial_fee_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialFeeTypeRcd;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_fee] set
                 financial_fee_id = @financial_fee_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,financial_fee_type_rcd = @financial_fee_type_rcd
                ,financial_currency_id = @financial_currency_id
                ,amount = @amount
            where financial_fee_id = @financial_fee_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_fee_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialFeeId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@financial_fee_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialFeeTypeRcd;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_fee] set
                 financial_fee_id = @financial_fee_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,financial_fee_type_rcd = @financial_fee_type_rcd
                ,financial_currency_id = @financial_currency_id
                ,amount = @amount
            where financial_fee_id = @financial_fee_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_fee_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialFeeId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@financial_fee_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialFeeTypeRcd;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid financialFeeId) {
            string sql = @" delete [financial_fee] 
                where financial_fee_id = @financial_fee_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_fee_id",SqlDbType.UniqueIdentifier).Value = financialFeeId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
