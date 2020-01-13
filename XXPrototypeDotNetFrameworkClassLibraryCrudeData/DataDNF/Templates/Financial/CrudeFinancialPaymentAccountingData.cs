/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:32:25 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeFinancialPaymentAccountingData {
        
        public System.Guid FinancialPaymentAccountingId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public decimal Amount { get; set; } //;
        
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        public void FetchByFinancialPaymentAccountingId(System.Guid financialPaymentAccountingId) {
            string sql = @" select top 1 financial_payment_accounting_id, user_id, date_time, amount, financial_currency_id
                            from [financial_payment_accounting]
                            where financial_payment_accounting_id = @financial_payment_accounting_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_payment_accounting_id",SqlDbType.UniqueIdentifier).Value = financialPaymentAccountingId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialPaymentAccountingData GetByFinancialPaymentAccountingId(System.Guid financialPaymentAccountingId) {
            string sql = @" select top 1 financial_payment_accounting_id, user_id, date_time, amount, financial_currency_id
                            from [financial_payment_accounting]
                            where financial_payment_accounting_id = @financial_payment_accounting_id";

            var ret = new CrudeFinancialPaymentAccountingData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_accounting_id",SqlDbType.UniqueIdentifier).Value = financialPaymentAccountingId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialPaymentAccountingData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialPaymentAccountingData>();

            string sql = @" select financial_payment_accounting_id, user_id, date_time, amount, financial_currency_id
                            from [financial_payment_accounting]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentAccountingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentAccountingData> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataList = new List<CrudeFinancialPaymentAccountingData>();

            string sql = @" select financial_payment_accounting_id, user_id, date_time, amount, financial_currency_id
                            from [financial_payment_accounting]
                            where financial_currency_id = @financial_currency_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentAccountingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentAccountingData> FetchAll() {
            var dataList = new List<CrudeFinancialPaymentAccountingData>();

            string sql = @" select financial_payment_accounting_id, user_id, date_time, amount, financial_currency_id
                            from [financial_payment_accounting]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentAccountingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentAccountingData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialPaymentAccountingData>();

            string sql = @" select top " + limit.ToString() + @" financial_payment_accounting_id, user_id, date_time, amount, financial_currency_id
                            from [financial_payment_accounting]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentAccountingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentAccountingData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialPaymentAccountingData>();

            string sql = @" select financial_payment_accounting_id, user_id, date_time, amount, financial_currency_id
                            from [financial_payment_accounting]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialPaymentAccountingData();
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
            string sql = @" select count(*) as count from [financial_payment_accounting]";

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
        
        public static List<CrudeFinancialPaymentAccountingData> FetchWithFilter(System.Guid financialPaymentAccountingId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId) {
            var dataList = new List<CrudeFinancialPaymentAccountingData>();

            string sql = @" select financial_payment_accounting_id, user_id, date_time, amount, financial_currency_id
                            from [financial_payment_accounting]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialPaymentAccountingId != Guid.Empty) {
                        sql += "  and financial_payment_accounting_id = @financial_payment_accounting_id";
                        command.Parameters.Add("@financial_payment_accounting_id", SqlDbType.UniqueIdentifier).Value = financialPaymentAccountingId;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (amount != 0) {
                        sql += "  and amount = @amount";
                        command.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                    }
                    if (financialCurrencyId != Guid.Empty) {
                        sql += "  and financial_currency_id = @financial_currency_id";
                        command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentAccountingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_payment_accounting_id"] != System.DBNull.Value) FinancialPaymentAccountingId = (System.Guid) reader["financial_payment_accounting_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["amount"] != System.DBNull.Value) Amount = (System.Decimal) reader["amount"];
            if (reader["financial_currency_id"] != System.DBNull.Value) FinancialCurrencyId = (System.Guid) reader["financial_currency_id"];
        }
        
        public void Insert() {

            if (FinancialPaymentAccountingId == Guid.Empty)
                FinancialPaymentAccountingId = Guid.NewGuid();

            string sql = "insert into [financial_payment_accounting] (financial_payment_accounting_id, user_id, date_time, amount, financial_currency_id)";
            sql += "            values (@financial_payment_accounting_id, @user_id, @date_time, @amount, @financial_currency_id)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_payment_accounting_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentAccountingId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialPaymentAccountingId == Guid.Empty)
                FinancialPaymentAccountingId = Guid.NewGuid();

            string sql = "insert into [financial_payment_accounting] (financial_payment_accounting_id, user_id, date_time, amount, financial_currency_id)";
            sql += "            values (@financial_payment_accounting_id, @user_id, @date_time, @amount, @financial_currency_id)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_payment_accounting_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentAccountingId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_payment_accounting] set
                 financial_payment_accounting_id = @financial_payment_accounting_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,amount = @amount
                ,financial_currency_id = @financial_currency_id
            where financial_payment_accounting_id = @financial_payment_accounting_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_payment_accounting_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentAccountingId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_payment_accounting] set
                 financial_payment_accounting_id = @financial_payment_accounting_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,amount = @amount
                ,financial_currency_id = @financial_currency_id
            where financial_payment_accounting_id = @financial_payment_accounting_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_payment_accounting_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentAccountingId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid financialPaymentAccountingId) {
            string sql = @" delete [financial_payment_accounting] 
                where financial_payment_accounting_id = @financial_payment_accounting_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_accounting_id",SqlDbType.UniqueIdentifier).Value = financialPaymentAccountingId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
