/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:41:22 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeFinancialPaymentBankData {
        
        public System.Guid FinancialPaymentBankId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public string BankName { get; set; } //;
        
        public string BankAccount { get; set; } //;
        
        public string BankNumber { get; set; } //;
        
        public string FinancialBankAccountNumberTypeRcd { get; set; } //;
        
        public decimal Amount { get; set; } //;
        
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        public void FetchByFinancialPaymentBankId(System.Guid financialPaymentBankId) {
            string sql = @" select top 1 financial_payment_bank_id, user_id, date_time, bank_name, bank_account, bank_number, financial_bank_account_number_type_rcd, amount, financial_currency_id
                            from [financial_payment_bank]
                            where financial_payment_bank_id = @financial_payment_bank_id
                            order by bank_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_payment_bank_id",SqlDbType.UniqueIdentifier).Value = financialPaymentBankId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialPaymentBankData GetByFinancialPaymentBankId(System.Guid financialPaymentBankId) {
            string sql = @" select top 1 financial_payment_bank_id, user_id, date_time, bank_name, bank_account, bank_number, financial_bank_account_number_type_rcd, amount, financial_currency_id
                            from [financial_payment_bank]
                            where financial_payment_bank_id = @financial_payment_bank_id
                            order by bank_name";

            var ret = new CrudeFinancialPaymentBankData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_bank_id",SqlDbType.UniqueIdentifier).Value = financialPaymentBankId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialPaymentBankData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialPaymentBankData>();

            string sql = @" select financial_payment_bank_id, user_id, date_time, bank_name, bank_account, bank_number, financial_bank_account_number_type_rcd, amount, financial_currency_id
                            from [financial_payment_bank]
                            where user_id = @user_id
                              
                            order by bank_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentBankData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentBankData> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataList = new List<CrudeFinancialPaymentBankData>();

            string sql = @" select financial_payment_bank_id, user_id, date_time, bank_name, bank_account, bank_number, financial_bank_account_number_type_rcd, amount, financial_currency_id
                            from [financial_payment_bank]
                            where financial_currency_id = @financial_currency_id
                              
                            order by bank_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentBankData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentBankData> FetchByFinancialBankAccountNumberTypeRcd(string financialBankAccountNumberTypeRcd) {
            var dataList = new List<CrudeFinancialPaymentBankData>();

            string sql = @" select financial_payment_bank_id, user_id, date_time, bank_name, bank_account, bank_number, financial_bank_account_number_type_rcd, amount, financial_currency_id
                            from [financial_payment_bank]
                            where financial_bank_account_number_type_rcd = @financial_bank_account_number_type_rcd
                              
                            order by bank_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_bank_account_number_type_rcd", SqlDbType.NVarChar).Value = financialBankAccountNumberTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentBankData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByBankName(string bankName) {
            string sql = @" select top 1 financial_payment_bank_id, user_id, date_time, bank_name, bank_account, bank_number, financial_bank_account_number_type_rcd, amount, financial_currency_id
                            from [financial_payment_bank]
                            where bank_name like '%' + @bankName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@bankName",SqlDbType.NVarChar).Value = bankName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeFinancialPaymentBankData> FetchAll() {
            var dataList = new List<CrudeFinancialPaymentBankData>();

            string sql = @" select financial_payment_bank_id, user_id, date_time, bank_name, bank_account, bank_number, financial_bank_account_number_type_rcd, amount, financial_currency_id
                            from [financial_payment_bank]
                            order by bank_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentBankData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentBankData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialPaymentBankData>();

            string sql = @" select top " + limit.ToString() + @" financial_payment_bank_id, user_id, date_time, bank_name, bank_account, bank_number, financial_bank_account_number_type_rcd, amount, financial_currency_id
                            from [financial_payment_bank]
                            order by bank_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentBankData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentBankData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialPaymentBankData>();

            string sql = @" select financial_payment_bank_id, user_id, date_time, bank_name, bank_account, bank_number, financial_bank_account_number_type_rcd, amount, financial_currency_id
                            from [financial_payment_bank]
                            order by bank_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialPaymentBankData();
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
            string sql = @" select count(*) as count from [financial_payment_bank]";

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
        
        public static List<CrudeFinancialPaymentBankData> FetchWithFilter(System.Guid financialPaymentBankId, System.Guid userId, System.DateTime dateTime, string bankName, string bankAccount, string bankNumber, string financialBankAccountNumberTypeRcd, decimal amount, System.Guid financialCurrencyId) {
            var dataList = new List<CrudeFinancialPaymentBankData>();

            string sql = @" select financial_payment_bank_id, user_id, date_time, bank_name, bank_account, bank_number, financial_bank_account_number_type_rcd, amount, financial_currency_id
                            from [financial_payment_bank]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialPaymentBankId != Guid.Empty) {
                        sql += "  and financial_payment_bank_id = @financial_payment_bank_id";
                        command.Parameters.Add("@financial_payment_bank_id", SqlDbType.UniqueIdentifier).Value = financialPaymentBankId;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (!string.IsNullOrEmpty(bankName)) {
                        sql += "  and bank_name like '%' + @bank_name + '%'";
                        command.Parameters.Add("@bank_name", SqlDbType.NVarChar).Value = bankName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(bankAccount)) {
                        sql += "  and bank_account like '%' + @bank_account + '%'";
                        command.Parameters.Add("@bank_account", SqlDbType.NVarChar).Value = bankAccount.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(bankNumber)) {
                        sql += "  and bank_number like '%' + @bank_number + '%'";
                        command.Parameters.Add("@bank_number", SqlDbType.NVarChar).Value = bankNumber.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(financialBankAccountNumberTypeRcd)) {
                        sql += "  and financial_bank_account_number_type_rcd like '%' + @financial_bank_account_number_type_rcd + '%'";
                        command.Parameters.Add("@financial_bank_account_number_type_rcd", SqlDbType.NVarChar).Value = financialBankAccountNumberTypeRcd.Replace("'","''");
                    }
                    if (amount != 0) {
                        sql += "  and amount = @amount";
                        command.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                    }
                    if (financialCurrencyId != Guid.Empty) {
                        sql += "  and financial_currency_id = @financial_currency_id";
                        command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;
                    }
                    sql += " order by bank_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentBankData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_payment_bank_id"] != System.DBNull.Value) FinancialPaymentBankId = (System.Guid) reader["financial_payment_bank_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["bank_name"] != System.DBNull.Value) BankName = (System.String) reader["bank_name"];
            if (reader["bank_account"] != System.DBNull.Value) BankAccount = (System.String) reader["bank_account"];
            if (reader["bank_number"] != System.DBNull.Value) BankNumber = (System.String) reader["bank_number"];
            if (reader["financial_bank_account_number_type_rcd"] != System.DBNull.Value) FinancialBankAccountNumberTypeRcd = (System.String) reader["financial_bank_account_number_type_rcd"];
            if (reader["amount"] != System.DBNull.Value) Amount = (System.Decimal) reader["amount"];
            if (reader["financial_currency_id"] != System.DBNull.Value) FinancialCurrencyId = (System.Guid) reader["financial_currency_id"];
        }
        
        public void Insert() {

            if (FinancialPaymentBankId == Guid.Empty)
                FinancialPaymentBankId = Guid.NewGuid();

            string sql = "insert into [financial_payment_bank] (financial_payment_bank_id, user_id, date_time, bank_name, bank_account, bank_number, financial_bank_account_number_type_rcd, amount, financial_currency_id)";
            sql += "            values (@financial_payment_bank_id, @user_id, @date_time, @bank_name, @bank_account, @bank_number, @financial_bank_account_number_type_rcd, @amount, @financial_currency_id)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_payment_bank_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentBankId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@bank_name",SqlDbType.NVarChar).Value = (System.String)BankName;
                    command.Parameters.Add("@bank_account",SqlDbType.NVarChar).Value = (System.String)BankAccount;
                    command.Parameters.Add("@bank_number",SqlDbType.NVarChar).Value = (System.String)BankNumber;
                    command.Parameters.Add("@financial_bank_account_number_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialBankAccountNumberTypeRcd;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialPaymentBankId == Guid.Empty)
                FinancialPaymentBankId = Guid.NewGuid();

            string sql = "insert into [financial_payment_bank] (financial_payment_bank_id, user_id, date_time, bank_name, bank_account, bank_number, financial_bank_account_number_type_rcd, amount, financial_currency_id)";
            sql += "            values (@financial_payment_bank_id, @user_id, @date_time, @bank_name, @bank_account, @bank_number, @financial_bank_account_number_type_rcd, @amount, @financial_currency_id)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_payment_bank_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentBankId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@bank_name",SqlDbType.NVarChar).Value = (System.String)BankName;
                command.Parameters.Add("@bank_account",SqlDbType.NVarChar).Value = (System.String)BankAccount;
                command.Parameters.Add("@bank_number",SqlDbType.NVarChar).Value = (System.String)BankNumber;
                command.Parameters.Add("@financial_bank_account_number_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialBankAccountNumberTypeRcd;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_payment_bank] set
                 financial_payment_bank_id = @financial_payment_bank_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,bank_name = @bank_name
                ,bank_account = @bank_account
                ,bank_number = @bank_number
                ,financial_bank_account_number_type_rcd = @financial_bank_account_number_type_rcd
                ,amount = @amount
                ,financial_currency_id = @financial_currency_id
            where financial_payment_bank_id = @financial_payment_bank_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_payment_bank_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentBankId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@bank_name",SqlDbType.NVarChar).Value = (System.String)BankName;
                    command.Parameters.Add("@bank_account",SqlDbType.NVarChar).Value = (System.String)BankAccount;
                    command.Parameters.Add("@bank_number",SqlDbType.NVarChar).Value = (System.String)BankNumber;
                    command.Parameters.Add("@financial_bank_account_number_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialBankAccountNumberTypeRcd;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_payment_bank] set
                 financial_payment_bank_id = @financial_payment_bank_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,bank_name = @bank_name
                ,bank_account = @bank_account
                ,bank_number = @bank_number
                ,financial_bank_account_number_type_rcd = @financial_bank_account_number_type_rcd
                ,amount = @amount
                ,financial_currency_id = @financial_currency_id
            where financial_payment_bank_id = @financial_payment_bank_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_payment_bank_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentBankId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@bank_name",SqlDbType.NVarChar).Value = (System.String)BankName;
                command.Parameters.Add("@bank_account",SqlDbType.NVarChar).Value = (System.String)BankAccount;
                command.Parameters.Add("@bank_number",SqlDbType.NVarChar).Value = (System.String)BankNumber;
                command.Parameters.Add("@financial_bank_account_number_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialBankAccountNumberTypeRcd;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid financialPaymentBankId) {
            string sql = @" delete [financial_payment_bank] 
                where financial_payment_bank_id = @financial_payment_bank_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_bank_id",SqlDbType.UniqueIdentifier).Value = financialPaymentBankId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
