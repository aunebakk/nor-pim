/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:44:41 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeFinancialPaymentData {
        
        public System.Guid FinancialPaymentId { get; set; } //;
        
        public string FinancialPaymentTypeRcd { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public System.Guid FinancialPaymentAccountingId { get; set; } //;
        
        public System.Guid FinancialPaymentBankId { get; set; } //;
        
        public System.Guid FinancialPaymentVoucherId { get; set; } //;
        
        public System.Guid FinancialPaymentCardId { get; set; } //;
        
        public System.Guid FinancialPaymentCashId { get; set; } //;
        
        public System.Guid FinancialPaymentCouponId { get; set; } //;
        
        public void FetchByFinancialPaymentId(System.Guid financialPaymentId) {
            string sql = @" select top 1 financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id
                            from [financial_payment]
                            where financial_payment_id = @financial_payment_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_payment_id",SqlDbType.UniqueIdentifier).Value = financialPaymentId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialPaymentData GetByFinancialPaymentId(System.Guid financialPaymentId) {
            string sql = @" select top 1 financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id
                            from [financial_payment]
                            where financial_payment_id = @financial_payment_id";

            var ret = new CrudeFinancialPaymentData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_id",SqlDbType.UniqueIdentifier).Value = financialPaymentId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialPaymentData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialPaymentData>();

            string sql = @" select financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id
                            from [financial_payment]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentData> FetchByFinancialPaymentAccountingId(System.Guid financialPaymentAccountingId) {
            var dataList = new List<CrudeFinancialPaymentData>();

            string sql = @" select financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id
                            from [financial_payment]
                            where financial_payment_accounting_id = @financial_payment_accounting_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_accounting_id", SqlDbType.UniqueIdentifier).Value = financialPaymentAccountingId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentData> FetchByFinancialPaymentBankId(System.Guid financialPaymentBankId) {
            var dataList = new List<CrudeFinancialPaymentData>();

            string sql = @" select financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id
                            from [financial_payment]
                            where financial_payment_bank_id = @financial_payment_bank_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_bank_id", SqlDbType.UniqueIdentifier).Value = financialPaymentBankId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentData> FetchByFinancialPaymentVoucherId(System.Guid financialPaymentVoucherId) {
            var dataList = new List<CrudeFinancialPaymentData>();

            string sql = @" select financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id
                            from [financial_payment]
                            where financial_payment_voucher_id = @financial_payment_voucher_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_voucher_id", SqlDbType.UniqueIdentifier).Value = financialPaymentVoucherId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentData> FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId) {
            var dataList = new List<CrudeFinancialPaymentData>();

            string sql = @" select financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id
                            from [financial_payment]
                            where financial_payment_card_id = @financial_payment_card_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_card_id", SqlDbType.UniqueIdentifier).Value = financialPaymentCardId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentData> FetchByFinancialPaymentCashId(System.Guid financialPaymentCashId) {
            var dataList = new List<CrudeFinancialPaymentData>();

            string sql = @" select financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id
                            from [financial_payment]
                            where financial_payment_cash_id = @financial_payment_cash_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_cash_id", SqlDbType.UniqueIdentifier).Value = financialPaymentCashId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentData> FetchByFinancialPaymentCouponId(System.Guid financialPaymentCouponId) {
            var dataList = new List<CrudeFinancialPaymentData>();

            string sql = @" select financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id
                            from [financial_payment]
                            where financial_payment_coupon_id = @financial_payment_coupon_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_coupon_id", SqlDbType.UniqueIdentifier).Value = financialPaymentCouponId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentData> FetchByFinancialPaymentTypeRcd(string financialPaymentTypeRcd) {
            var dataList = new List<CrudeFinancialPaymentData>();

            string sql = @" select financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id
                            from [financial_payment]
                            where financial_payment_type_rcd = @financial_payment_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_type_rcd", SqlDbType.NVarChar).Value = financialPaymentTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentData> FetchAll() {
            var dataList = new List<CrudeFinancialPaymentData>();

            string sql = @" select financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id
                            from [financial_payment]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialPaymentData>();

            string sql = @" select top " + limit.ToString() + @" financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id
                            from [financial_payment]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialPaymentData>();

            string sql = @" select financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id
                            from [financial_payment]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialPaymentData();
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
            string sql = @" select count(*) as count from [financial_payment]";

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
        
        public static List<CrudeFinancialPaymentData> FetchWithFilter(System.Guid financialPaymentId, string financialPaymentTypeRcd, System.Guid userId, System.DateTime dateTime, System.Guid financialPaymentAccountingId, System.Guid financialPaymentBankId, System.Guid financialPaymentVoucherId, System.Guid financialPaymentCardId, System.Guid financialPaymentCashId, System.Guid financialPaymentCouponId) {
            var dataList = new List<CrudeFinancialPaymentData>();

            string sql = @" select financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id
                            from [financial_payment]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialPaymentId != Guid.Empty) {
                        sql += "  and financial_payment_id = @financial_payment_id";
                        command.Parameters.Add("@financial_payment_id", SqlDbType.UniqueIdentifier).Value = financialPaymentId;
                    }
                    if (!string.IsNullOrEmpty(financialPaymentTypeRcd)) {
                        sql += "  and financial_payment_type_rcd like '%' + @financial_payment_type_rcd + '%'";
                        command.Parameters.Add("@financial_payment_type_rcd", SqlDbType.NVarChar).Value = financialPaymentTypeRcd.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (financialPaymentAccountingId != Guid.Empty) {
                        sql += "  and financial_payment_accounting_id = @financial_payment_accounting_id";
                        command.Parameters.Add("@financial_payment_accounting_id", SqlDbType.UniqueIdentifier).Value = financialPaymentAccountingId;
                    }
                    if (financialPaymentBankId != Guid.Empty) {
                        sql += "  and financial_payment_bank_id = @financial_payment_bank_id";
                        command.Parameters.Add("@financial_payment_bank_id", SqlDbType.UniqueIdentifier).Value = financialPaymentBankId;
                    }
                    if (financialPaymentVoucherId != Guid.Empty) {
                        sql += "  and financial_payment_voucher_id = @financial_payment_voucher_id";
                        command.Parameters.Add("@financial_payment_voucher_id", SqlDbType.UniqueIdentifier).Value = financialPaymentVoucherId;
                    }
                    if (financialPaymentCardId != Guid.Empty) {
                        sql += "  and financial_payment_card_id = @financial_payment_card_id";
                        command.Parameters.Add("@financial_payment_card_id", SqlDbType.UniqueIdentifier).Value = financialPaymentCardId;
                    }
                    if (financialPaymentCashId != Guid.Empty) {
                        sql += "  and financial_payment_cash_id = @financial_payment_cash_id";
                        command.Parameters.Add("@financial_payment_cash_id", SqlDbType.UniqueIdentifier).Value = financialPaymentCashId;
                    }
                    if (financialPaymentCouponId != Guid.Empty) {
                        sql += "  and financial_payment_coupon_id = @financial_payment_coupon_id";
                        command.Parameters.Add("@financial_payment_coupon_id", SqlDbType.UniqueIdentifier).Value = financialPaymentCouponId;
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_payment_id"] != System.DBNull.Value) FinancialPaymentId = (System.Guid) reader["financial_payment_id"];
            if (reader["financial_payment_type_rcd"] != System.DBNull.Value) FinancialPaymentTypeRcd = (System.String) reader["financial_payment_type_rcd"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["financial_payment_accounting_id"] != System.DBNull.Value) FinancialPaymentAccountingId = (System.Guid) reader["financial_payment_accounting_id"];
            if (reader["financial_payment_bank_id"] != System.DBNull.Value) FinancialPaymentBankId = (System.Guid) reader["financial_payment_bank_id"];
            if (reader["financial_payment_voucher_id"] != System.DBNull.Value) FinancialPaymentVoucherId = (System.Guid) reader["financial_payment_voucher_id"];
            if (reader["financial_payment_card_id"] != System.DBNull.Value) FinancialPaymentCardId = (System.Guid) reader["financial_payment_card_id"];
            if (reader["financial_payment_cash_id"] != System.DBNull.Value) FinancialPaymentCashId = (System.Guid) reader["financial_payment_cash_id"];
            if (reader["financial_payment_coupon_id"] != System.DBNull.Value) FinancialPaymentCouponId = (System.Guid) reader["financial_payment_coupon_id"];
        }
        
        public void Insert() {

            if (FinancialPaymentId == Guid.Empty)
                FinancialPaymentId = Guid.NewGuid();

            string sql = "insert into [financial_payment] (financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id)";
            sql += "            values (@financial_payment_id, @financial_payment_type_rcd, @user_id, @date_time, @financial_payment_accounting_id, @financial_payment_bank_id, @financial_payment_voucher_id, @financial_payment_card_id, @financial_payment_cash_id, @financial_payment_coupon_id)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_payment_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentId;
                    command.Parameters.Add("@financial_payment_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialPaymentTypeRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@financial_payment_accounting_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentAccountingId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentAccountingId);
                    command.Parameters.Add("@financial_payment_bank_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentBankId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentBankId);
                    command.Parameters.Add("@financial_payment_voucher_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentVoucherId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentVoucherId);
                    command.Parameters.Add("@financial_payment_card_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentCardId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentCardId);
                    command.Parameters.Add("@financial_payment_cash_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentCashId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentCashId);
                    command.Parameters.Add("@financial_payment_coupon_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentCouponId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentCouponId);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialPaymentId == Guid.Empty)
                FinancialPaymentId = Guid.NewGuid();

            string sql = "insert into [financial_payment] (financial_payment_id, financial_payment_type_rcd, user_id, date_time, financial_payment_accounting_id, financial_payment_bank_id, financial_payment_voucher_id, financial_payment_card_id, financial_payment_cash_id, financial_payment_coupon_id)";
            sql += "            values (@financial_payment_id, @financial_payment_type_rcd, @user_id, @date_time, @financial_payment_accounting_id, @financial_payment_bank_id, @financial_payment_voucher_id, @financial_payment_card_id, @financial_payment_cash_id, @financial_payment_coupon_id)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_payment_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentId;
                command.Parameters.Add("@financial_payment_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialPaymentTypeRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@financial_payment_accounting_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentAccountingId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentAccountingId);
                command.Parameters.Add("@financial_payment_bank_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentBankId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentBankId);
                command.Parameters.Add("@financial_payment_voucher_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentVoucherId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentVoucherId);
                command.Parameters.Add("@financial_payment_card_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentCardId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentCardId);
                command.Parameters.Add("@financial_payment_cash_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentCashId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentCashId);
                command.Parameters.Add("@financial_payment_coupon_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentCouponId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentCouponId);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_payment] set
                 financial_payment_id = @financial_payment_id
                ,financial_payment_type_rcd = @financial_payment_type_rcd
                ,user_id = @user_id
                ,date_time = @date_time
                ,financial_payment_accounting_id = @financial_payment_accounting_id
                ,financial_payment_bank_id = @financial_payment_bank_id
                ,financial_payment_voucher_id = @financial_payment_voucher_id
                ,financial_payment_card_id = @financial_payment_card_id
                ,financial_payment_cash_id = @financial_payment_cash_id
                ,financial_payment_coupon_id = @financial_payment_coupon_id
            where financial_payment_id = @financial_payment_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_payment_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentId;
                    command.Parameters.Add("@financial_payment_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialPaymentTypeRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@financial_payment_accounting_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentAccountingId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentAccountingId);
                    command.Parameters.Add("@financial_payment_bank_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentBankId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentBankId);
                    command.Parameters.Add("@financial_payment_voucher_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentVoucherId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentVoucherId);
                    command.Parameters.Add("@financial_payment_card_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentCardId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentCardId);
                    command.Parameters.Add("@financial_payment_cash_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentCashId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentCashId);
                    command.Parameters.Add("@financial_payment_coupon_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentCouponId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentCouponId);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_payment] set
                 financial_payment_id = @financial_payment_id
                ,financial_payment_type_rcd = @financial_payment_type_rcd
                ,user_id = @user_id
                ,date_time = @date_time
                ,financial_payment_accounting_id = @financial_payment_accounting_id
                ,financial_payment_bank_id = @financial_payment_bank_id
                ,financial_payment_voucher_id = @financial_payment_voucher_id
                ,financial_payment_card_id = @financial_payment_card_id
                ,financial_payment_cash_id = @financial_payment_cash_id
                ,financial_payment_coupon_id = @financial_payment_coupon_id
            where financial_payment_id = @financial_payment_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_payment_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentId;
                command.Parameters.Add("@financial_payment_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialPaymentTypeRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@financial_payment_accounting_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentAccountingId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentAccountingId);
                command.Parameters.Add("@financial_payment_bank_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentBankId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentBankId);
                command.Parameters.Add("@financial_payment_voucher_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentVoucherId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentVoucherId);
                command.Parameters.Add("@financial_payment_card_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentCardId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentCardId);
                command.Parameters.Add("@financial_payment_cash_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentCashId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentCashId);
                command.Parameters.Add("@financial_payment_coupon_id",SqlDbType.UniqueIdentifier).Value = (FinancialPaymentCouponId == Guid.Empty ? (object)DBNull.Value : (System.Guid)FinancialPaymentCouponId);
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid financialPaymentId) {
            string sql = @" delete [financial_payment] 
                where financial_payment_id = @financial_payment_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_id",SqlDbType.UniqueIdentifier).Value = financialPaymentId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
