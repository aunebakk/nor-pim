/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:26 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeFinancialOrderTransactionData {
        
        public System.Guid FinancialBookingTransactionId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public decimal Amount { get; set; } //;
        
        public System.Guid FinancialFeeId { get; set; } //;
        
        public System.Guid FinancialTaxId { get; set; } //;
        
        public System.Guid FinancialPaymentId { get; set; } //;
        
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        public int TransactionNumber { get; set; } //;
        
        public System.Guid FinancialCostcentreId { get; set; } //;
        
        public System.Guid FinancialAdjustmentId { get; set; } //;
        
        public string FinancialOrderTransactionTypeRcd { get; set; } //;
        
        public System.Guid FinancialOrderId { get; set; } //;
        
        public void FetchByFinancialBookingTransactionId(System.Guid financialBookingTransactionId) {
            string sql = @" select top 1 financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id
                            from [financial_order_transaction]
                            where financial_booking_transaction_id = @financial_booking_transaction_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_booking_transaction_id",SqlDbType.UniqueIdentifier).Value = financialBookingTransactionId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialOrderTransactionData GetByFinancialBookingTransactionId(System.Guid financialBookingTransactionId) {
            string sql = @" select top 1 financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id
                            from [financial_order_transaction]
                            where financial_booking_transaction_id = @financial_booking_transaction_id";

            var ret = new CrudeFinancialOrderTransactionData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_booking_transaction_id",SqlDbType.UniqueIdentifier).Value = financialBookingTransactionId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialOrderTransactionData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialOrderTransactionData>();

            string sql = @" select financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id
                            from [financial_order_transaction]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderTransactionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderTransactionData> FetchByFinancialFeeId(System.Guid financialFeeId) {
            var dataList = new List<CrudeFinancialOrderTransactionData>();

            string sql = @" select financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id
                            from [financial_order_transaction]
                            where financial_fee_id = @financial_fee_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_fee_id", SqlDbType.UniqueIdentifier).Value = financialFeeId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderTransactionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderTransactionData> FetchByFinancialTaxId(System.Guid financialTaxId) {
            var dataList = new List<CrudeFinancialOrderTransactionData>();

            string sql = @" select financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id
                            from [financial_order_transaction]
                            where financial_tax_id = @financial_tax_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_tax_id", SqlDbType.UniqueIdentifier).Value = financialTaxId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderTransactionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderTransactionData> FetchByFinancialPaymentId(System.Guid financialPaymentId) {
            var dataList = new List<CrudeFinancialOrderTransactionData>();

            string sql = @" select financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id
                            from [financial_order_transaction]
                            where financial_payment_id = @financial_payment_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_id", SqlDbType.UniqueIdentifier).Value = financialPaymentId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderTransactionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderTransactionData> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataList = new List<CrudeFinancialOrderTransactionData>();

            string sql = @" select financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id
                            from [financial_order_transaction]
                            where financial_currency_id = @financial_currency_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderTransactionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderTransactionData> FetchByFinancialCostcentreId(System.Guid financialCostcentreId) {
            var dataList = new List<CrudeFinancialOrderTransactionData>();

            string sql = @" select financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id
                            from [financial_order_transaction]
                            where financial_costcentre_id = @financial_costcentre_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_costcentre_id", SqlDbType.UniqueIdentifier).Value = financialCostcentreId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderTransactionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderTransactionData> FetchByFinancialAdjustmentId(System.Guid financialAdjustmentId) {
            var dataList = new List<CrudeFinancialOrderTransactionData>();

            string sql = @" select financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id
                            from [financial_order_transaction]
                            where financial_adjustment_id = @financial_adjustment_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_adjustment_id", SqlDbType.UniqueIdentifier).Value = financialAdjustmentId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderTransactionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderTransactionData> FetchByFinancialOrderId(System.Guid financialOrderId) {
            var dataList = new List<CrudeFinancialOrderTransactionData>();

            string sql = @" select financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id
                            from [financial_order_transaction]
                            where financial_order_id = @financial_order_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_id", SqlDbType.UniqueIdentifier).Value = financialOrderId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderTransactionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderTransactionData> FetchByFinancialOrderTransactionTypeRcd(string financialOrderTransactionTypeRcd) {
            var dataList = new List<CrudeFinancialOrderTransactionData>();

            string sql = @" select financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id
                            from [financial_order_transaction]
                            where financial_order_transaction_type_rcd = @financial_order_transaction_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_transaction_type_rcd", SqlDbType.NVarChar).Value = financialOrderTransactionTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderTransactionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderTransactionData> FetchAll() {
            var dataList = new List<CrudeFinancialOrderTransactionData>();

            string sql = @" select financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id
                            from [financial_order_transaction]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderTransactionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderTransactionData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialOrderTransactionData>();

            string sql = @" select top " + limit.ToString() + @" financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id
                            from [financial_order_transaction]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderTransactionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderTransactionData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialOrderTransactionData>();

            string sql = @" select financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id
                            from [financial_order_transaction]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialOrderTransactionData();
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
            string sql = @" select count(*) as count from [financial_order_transaction]";

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
        
        public static List<CrudeFinancialOrderTransactionData> FetchWithFilter(System.Guid financialBookingTransactionId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialFeeId, System.Guid financialTaxId, System.Guid financialPaymentId, System.Guid financialCurrencyId, int transactionNumber, System.Guid financialCostcentreId, System.Guid financialAdjustmentId, string financialOrderTransactionTypeRcd, System.Guid financialOrderId) {
            var dataList = new List<CrudeFinancialOrderTransactionData>();

            string sql = @" select financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id
                            from [financial_order_transaction]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialBookingTransactionId != Guid.Empty) {
                        sql += "  and financial_booking_transaction_id = @financial_booking_transaction_id";
                        command.Parameters.Add("@financial_booking_transaction_id", SqlDbType.UniqueIdentifier).Value = financialBookingTransactionId;
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
                    if (financialFeeId != Guid.Empty) {
                        sql += "  and financial_fee_id = @financial_fee_id";
                        command.Parameters.Add("@financial_fee_id", SqlDbType.UniqueIdentifier).Value = financialFeeId;
                    }
                    if (financialTaxId != Guid.Empty) {
                        sql += "  and financial_tax_id = @financial_tax_id";
                        command.Parameters.Add("@financial_tax_id", SqlDbType.UniqueIdentifier).Value = financialTaxId;
                    }
                    if (financialPaymentId != Guid.Empty) {
                        sql += "  and financial_payment_id = @financial_payment_id";
                        command.Parameters.Add("@financial_payment_id", SqlDbType.UniqueIdentifier).Value = financialPaymentId;
                    }
                    if (financialCurrencyId != Guid.Empty) {
                        sql += "  and financial_currency_id = @financial_currency_id";
                        command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;
                    }
                    if (transactionNumber != 0) {
                        sql += "  and transaction_number = @transaction_number";
                        command.Parameters.Add("@transaction_number", SqlDbType.Int).Value = transactionNumber;
                    }
                    if (financialCostcentreId != Guid.Empty) {
                        sql += "  and financial_costcentre_id = @financial_costcentre_id";
                        command.Parameters.Add("@financial_costcentre_id", SqlDbType.UniqueIdentifier).Value = financialCostcentreId;
                    }
                    if (financialAdjustmentId != Guid.Empty) {
                        sql += "  and financial_adjustment_id = @financial_adjustment_id";
                        command.Parameters.Add("@financial_adjustment_id", SqlDbType.UniqueIdentifier).Value = financialAdjustmentId;
                    }
                    if (!string.IsNullOrEmpty(financialOrderTransactionTypeRcd)) {
                        sql += "  and financial_order_transaction_type_rcd like '%' + @financial_order_transaction_type_rcd + '%'";
                        command.Parameters.Add("@financial_order_transaction_type_rcd", SqlDbType.NVarChar).Value = financialOrderTransactionTypeRcd.Replace("'","''");
                    }
                    if (financialOrderId != Guid.Empty) {
                        sql += "  and financial_order_id = @financial_order_id";
                        command.Parameters.Add("@financial_order_id", SqlDbType.UniqueIdentifier).Value = financialOrderId;
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderTransactionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_booking_transaction_id"] != System.DBNull.Value) FinancialBookingTransactionId = (System.Guid) reader["financial_booking_transaction_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["amount"] != System.DBNull.Value) Amount = (System.Decimal) reader["amount"];
            if (reader["financial_fee_id"] != System.DBNull.Value) FinancialFeeId = (System.Guid) reader["financial_fee_id"];
            if (reader["financial_tax_id"] != System.DBNull.Value) FinancialTaxId = (System.Guid) reader["financial_tax_id"];
            if (reader["financial_payment_id"] != System.DBNull.Value) FinancialPaymentId = (System.Guid) reader["financial_payment_id"];
            if (reader["financial_currency_id"] != System.DBNull.Value) FinancialCurrencyId = (System.Guid) reader["financial_currency_id"];
            if (reader["transaction_number"] != System.DBNull.Value) TransactionNumber = (System.Int32) reader["transaction_number"];
            if (reader["financial_costcentre_id"] != System.DBNull.Value) FinancialCostcentreId = (System.Guid) reader["financial_costcentre_id"];
            if (reader["financial_adjustment_id"] != System.DBNull.Value) FinancialAdjustmentId = (System.Guid) reader["financial_adjustment_id"];
            if (reader["financial_order_transaction_type_rcd"] != System.DBNull.Value) FinancialOrderTransactionTypeRcd = (System.String) reader["financial_order_transaction_type_rcd"];
            if (reader["financial_order_id"] != System.DBNull.Value) FinancialOrderId = (System.Guid) reader["financial_order_id"];
        }
        
        public void Insert() {

            if (FinancialBookingTransactionId == Guid.Empty)
                FinancialBookingTransactionId = Guid.NewGuid();

            string sql = "insert into [financial_order_transaction] (financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id)";
            sql += "            values (@financial_booking_transaction_id, @user_id, @date_time, @amount, @financial_fee_id, @financial_tax_id, @financial_payment_id, @financial_currency_id, @transaction_number, @financial_costcentre_id, @financial_adjustment_id, @financial_order_transaction_type_rcd, @financial_order_id)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_booking_transaction_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialBookingTransactionId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.Parameters.Add("@financial_fee_id",SqlDbType.UniqueIdentifier).Value = (FinancialFeeId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialFeeId);
                    command.Parameters.Add("@financial_tax_id",SqlDbType.UniqueIdentifier).Value = (FinancialTaxId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialTaxId);
                    command.Parameters.Add("@financial_payment_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentId);
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@transaction_number",SqlDbType.Int).Value = (System.Int32)TransactionNumber;
                    command.Parameters.Add("@financial_costcentre_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCostcentreId;
                    command.Parameters.Add("@financial_adjustment_id",SqlDbType.UniqueIdentifier).Value = (FinancialAdjustmentId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialAdjustmentId);
                    command.Parameters.Add("@financial_order_transaction_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderTransactionTypeRcd;
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialBookingTransactionId == Guid.Empty)
                FinancialBookingTransactionId = Guid.NewGuid();

            string sql = "insert into [financial_order_transaction] (financial_booking_transaction_id, user_id, date_time, amount, financial_fee_id, financial_tax_id, financial_payment_id, financial_currency_id, transaction_number, financial_costcentre_id, financial_adjustment_id, financial_order_transaction_type_rcd, financial_order_id)";
            sql += "            values (@financial_booking_transaction_id, @user_id, @date_time, @amount, @financial_fee_id, @financial_tax_id, @financial_payment_id, @financial_currency_id, @transaction_number, @financial_costcentre_id, @financial_adjustment_id, @financial_order_transaction_type_rcd, @financial_order_id)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_booking_transaction_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialBookingTransactionId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.Parameters.Add("@financial_fee_id",SqlDbType.UniqueIdentifier).Value = (FinancialFeeId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialFeeId);
                command.Parameters.Add("@financial_tax_id",SqlDbType.UniqueIdentifier).Value = (FinancialTaxId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialTaxId);
                command.Parameters.Add("@financial_payment_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentId);
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@transaction_number",SqlDbType.Int).Value = (System.Int32)TransactionNumber;
                command.Parameters.Add("@financial_costcentre_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCostcentreId;
                command.Parameters.Add("@financial_adjustment_id",SqlDbType.UniqueIdentifier).Value = (FinancialAdjustmentId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialAdjustmentId);
                command.Parameters.Add("@financial_order_transaction_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderTransactionTypeRcd;
                command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_order_transaction] set
                 financial_booking_transaction_id = @financial_booking_transaction_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,amount = @amount
                ,financial_fee_id = @financial_fee_id
                ,financial_tax_id = @financial_tax_id
                ,financial_payment_id = @financial_payment_id
                ,financial_currency_id = @financial_currency_id
                ,transaction_number = @transaction_number
                ,financial_costcentre_id = @financial_costcentre_id
                ,financial_adjustment_id = @financial_adjustment_id
                ,financial_order_transaction_type_rcd = @financial_order_transaction_type_rcd
                ,financial_order_id = @financial_order_id
            where financial_booking_transaction_id = @financial_booking_transaction_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_booking_transaction_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialBookingTransactionId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.Parameters.Add("@financial_fee_id",SqlDbType.UniqueIdentifier).Value = (FinancialFeeId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialFeeId);
                    command.Parameters.Add("@financial_tax_id",SqlDbType.UniqueIdentifier).Value = (FinancialTaxId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialTaxId);
                    command.Parameters.Add("@financial_payment_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentId);
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@transaction_number",SqlDbType.Int).Value = (System.Int32)TransactionNumber;
                    command.Parameters.Add("@financial_costcentre_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCostcentreId;
                    command.Parameters.Add("@financial_adjustment_id",SqlDbType.UniqueIdentifier).Value = (FinancialAdjustmentId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialAdjustmentId);
                    command.Parameters.Add("@financial_order_transaction_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderTransactionTypeRcd;
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_order_transaction] set
                 financial_booking_transaction_id = @financial_booking_transaction_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,amount = @amount
                ,financial_fee_id = @financial_fee_id
                ,financial_tax_id = @financial_tax_id
                ,financial_payment_id = @financial_payment_id
                ,financial_currency_id = @financial_currency_id
                ,transaction_number = @transaction_number
                ,financial_costcentre_id = @financial_costcentre_id
                ,financial_adjustment_id = @financial_adjustment_id
                ,financial_order_transaction_type_rcd = @financial_order_transaction_type_rcd
                ,financial_order_id = @financial_order_id
            where financial_booking_transaction_id = @financial_booking_transaction_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_booking_transaction_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialBookingTransactionId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.Parameters.Add("@financial_fee_id",SqlDbType.UniqueIdentifier).Value = (FinancialFeeId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialFeeId);
                command.Parameters.Add("@financial_tax_id",SqlDbType.UniqueIdentifier).Value = (FinancialTaxId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialTaxId);
                command.Parameters.Add("@financial_payment_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentId);
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@transaction_number",SqlDbType.Int).Value = (System.Int32)TransactionNumber;
                command.Parameters.Add("@financial_costcentre_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCostcentreId;
                command.Parameters.Add("@financial_adjustment_id",SqlDbType.UniqueIdentifier).Value = (FinancialAdjustmentId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialAdjustmentId);
                command.Parameters.Add("@financial_order_transaction_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderTransactionTypeRcd;
                command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid financialBookingTransactionId) {
            string sql = @" delete [financial_order_transaction] 
                where financial_booking_transaction_id = @financial_booking_transaction_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_booking_transaction_id",SqlDbType.UniqueIdentifier).Value = financialBookingTransactionId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
