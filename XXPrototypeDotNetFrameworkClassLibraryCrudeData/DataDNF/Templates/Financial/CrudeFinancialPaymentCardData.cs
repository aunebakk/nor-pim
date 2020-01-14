/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:41:26 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeFinancialPaymentCardData {
        
        public System.Guid FinancialPaymentCardId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public string CardNumber { get; set; } //;
        
        public string NameOnCard { get; set; } //;
        
        public int ExpiryYear { get; set; } //;
        
        public int ExpiryMonth { get; set; } //;
        
        public string FinancialCardTypeRcd { get; set; } //;
        
        public int CardVerificationValue { get; set; } //;
        
        public int IssuedMonth { get; set; } //;
        
        public int IssuedYear { get; set; } //;
        
        public string AddressVerificationCode { get; set; } //;
        
        public decimal Amount { get; set; } //;
        
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        public void FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId) {
            string sql = @" select top 1 financial_payment_card_id, user_id, date_time, card_number, name_on_card, expiry_year, expiry_month, financial_card_type_rcd, card_verification_value, issued_month, issued_year, address_verification_code, amount, financial_currency_id
                            from [financial_payment_card]
                            where financial_payment_card_id = @financial_payment_card_id
                            order by address_verification_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_payment_card_id",SqlDbType.UniqueIdentifier).Value = financialPaymentCardId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialPaymentCardData GetByFinancialPaymentCardId(System.Guid financialPaymentCardId) {
            string sql = @" select top 1 financial_payment_card_id, user_id, date_time, card_number, name_on_card, expiry_year, expiry_month, financial_card_type_rcd, card_verification_value, issued_month, issued_year, address_verification_code, amount, financial_currency_id
                            from [financial_payment_card]
                            where financial_payment_card_id = @financial_payment_card_id
                            order by address_verification_code";

            var ret = new CrudeFinancialPaymentCardData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_card_id",SqlDbType.UniqueIdentifier).Value = financialPaymentCardId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialPaymentCardData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialPaymentCardData>();

            string sql = @" select financial_payment_card_id, user_id, date_time, card_number, name_on_card, expiry_year, expiry_month, financial_card_type_rcd, card_verification_value, issued_month, issued_year, address_verification_code, amount, financial_currency_id
                            from [financial_payment_card]
                            where user_id = @user_id
                              
                            order by address_verification_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentCardData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentCardData> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataList = new List<CrudeFinancialPaymentCardData>();

            string sql = @" select financial_payment_card_id, user_id, date_time, card_number, name_on_card, expiry_year, expiry_month, financial_card_type_rcd, card_verification_value, issued_month, issued_year, address_verification_code, amount, financial_currency_id
                            from [financial_payment_card]
                            where financial_currency_id = @financial_currency_id
                              
                            order by address_verification_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentCardData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentCardData> FetchByFinancialCardTypeRcd(string financialCardTypeRcd) {
            var dataList = new List<CrudeFinancialPaymentCardData>();

            string sql = @" select financial_payment_card_id, user_id, date_time, card_number, name_on_card, expiry_year, expiry_month, financial_card_type_rcd, card_verification_value, issued_month, issued_year, address_verification_code, amount, financial_currency_id
                            from [financial_payment_card]
                            where financial_card_type_rcd = @financial_card_type_rcd
                              
                            order by address_verification_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_card_type_rcd", SqlDbType.NVarChar).Value = financialCardTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentCardData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentCardData> FetchAll() {
            var dataList = new List<CrudeFinancialPaymentCardData>();

            string sql = @" select financial_payment_card_id, user_id, date_time, card_number, name_on_card, expiry_year, expiry_month, financial_card_type_rcd, card_verification_value, issued_month, issued_year, address_verification_code, amount, financial_currency_id
                            from [financial_payment_card]
                            order by address_verification_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentCardData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentCardData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialPaymentCardData>();

            string sql = @" select top " + limit.ToString() + @" financial_payment_card_id, user_id, date_time, card_number, name_on_card, expiry_year, expiry_month, financial_card_type_rcd, card_verification_value, issued_month, issued_year, address_verification_code, amount, financial_currency_id
                            from [financial_payment_card]
                            order by address_verification_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentCardData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialPaymentCardData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialPaymentCardData>();

            string sql = @" select financial_payment_card_id, user_id, date_time, card_number, name_on_card, expiry_year, expiry_month, financial_card_type_rcd, card_verification_value, issued_month, issued_year, address_verification_code, amount, financial_currency_id
                            from [financial_payment_card]
                            order by address_verification_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialPaymentCardData();
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
            string sql = @" select count(*) as count from [financial_payment_card]";

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
        
        public static List<CrudeFinancialPaymentCardData> FetchWithFilter(System.Guid financialPaymentCardId, System.Guid userId, System.DateTime dateTime, string cardNumber, string nameOnCard, int expiryYear, int expiryMonth, string financialCardTypeRcd, int cardVerificationValue, int issuedMonth, int issuedYear, string addressVerificationCode, decimal amount, System.Guid financialCurrencyId) {
            var dataList = new List<CrudeFinancialPaymentCardData>();

            string sql = @" select financial_payment_card_id, user_id, date_time, card_number, name_on_card, expiry_year, expiry_month, financial_card_type_rcd, card_verification_value, issued_month, issued_year, address_verification_code, amount, financial_currency_id
                            from [financial_payment_card]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialPaymentCardId != Guid.Empty) {
                        sql += "  and financial_payment_card_id = @financial_payment_card_id";
                        command.Parameters.Add("@financial_payment_card_id", SqlDbType.UniqueIdentifier).Value = financialPaymentCardId;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (!string.IsNullOrEmpty(cardNumber)) {
                        sql += "  and card_number like '%' + @card_number + '%'";
                        command.Parameters.Add("@card_number", SqlDbType.NVarChar).Value = cardNumber.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(nameOnCard)) {
                        sql += "  and name_on_card like '%' + @name_on_card + '%'";
                        command.Parameters.Add("@name_on_card", SqlDbType.NVarChar).Value = nameOnCard.Replace("'","''");
                    }
                    if (expiryYear != 0) {
                        sql += "  and expiry_year = @expiry_year";
                        command.Parameters.Add("@expiry_year", SqlDbType.Int).Value = expiryYear;
                    }
                    if (expiryMonth != 0) {
                        sql += "  and expiry_month = @expiry_month";
                        command.Parameters.Add("@expiry_month", SqlDbType.Int).Value = expiryMonth;
                    }
                    if (!string.IsNullOrEmpty(financialCardTypeRcd)) {
                        sql += "  and financial_card_type_rcd like '%' + @financial_card_type_rcd + '%'";
                        command.Parameters.Add("@financial_card_type_rcd", SqlDbType.NVarChar).Value = financialCardTypeRcd.Replace("'","''");
                    }
                    if (cardVerificationValue != 0) {
                        sql += "  and card_verification_value = @card_verification_value";
                        command.Parameters.Add("@card_verification_value", SqlDbType.Int).Value = cardVerificationValue;
                    }
                    if (issuedMonth != 0) {
                        sql += "  and issued_month = @issued_month";
                        command.Parameters.Add("@issued_month", SqlDbType.Int).Value = issuedMonth;
                    }
                    if (issuedYear != 0) {
                        sql += "  and issued_year = @issued_year";
                        command.Parameters.Add("@issued_year", SqlDbType.Int).Value = issuedYear;
                    }
                    if (!string.IsNullOrEmpty(addressVerificationCode)) {
                        sql += "  and address_verification_code like '%' + @address_verification_code + '%'";
                        command.Parameters.Add("@address_verification_code", SqlDbType.NVarChar).Value = addressVerificationCode.Replace("'","''");
                    }
                    if (amount != 0) {
                        sql += "  and amount = @amount";
                        command.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                    }
                    if (financialCurrencyId != Guid.Empty) {
                        sql += "  and financial_currency_id = @financial_currency_id";
                        command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;
                    }
                    sql += " order by address_verification_code";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialPaymentCardData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_payment_card_id"] != System.DBNull.Value) FinancialPaymentCardId = (System.Guid) reader["financial_payment_card_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["card_number"] != System.DBNull.Value) CardNumber = (System.String) reader["card_number"];
            if (reader["name_on_card"] != System.DBNull.Value) NameOnCard = (System.String) reader["name_on_card"];
            if (reader["expiry_year"] != System.DBNull.Value) ExpiryYear = (System.Int32) reader["expiry_year"];
            if (reader["expiry_month"] != System.DBNull.Value) ExpiryMonth = (System.Int32) reader["expiry_month"];
            if (reader["financial_card_type_rcd"] != System.DBNull.Value) FinancialCardTypeRcd = (System.String) reader["financial_card_type_rcd"];
            if (reader["card_verification_value"] != System.DBNull.Value) CardVerificationValue = (System.Int32) reader["card_verification_value"];
            if (reader["issued_month"] != System.DBNull.Value) IssuedMonth = (System.Int32) reader["issued_month"];
            if (reader["issued_year"] != System.DBNull.Value) IssuedYear = (System.Int32) reader["issued_year"];
            if (reader["address_verification_code"] != System.DBNull.Value) AddressVerificationCode = (System.String) reader["address_verification_code"];
            if (reader["amount"] != System.DBNull.Value) Amount = (System.Decimal) reader["amount"];
            if (reader["financial_currency_id"] != System.DBNull.Value) FinancialCurrencyId = (System.Guid) reader["financial_currency_id"];
        }
        
        public void Insert() {

            if (FinancialPaymentCardId == Guid.Empty)
                FinancialPaymentCardId = Guid.NewGuid();

            string sql = "insert into [financial_payment_card] (financial_payment_card_id, user_id, date_time, card_number, name_on_card, expiry_year, expiry_month, financial_card_type_rcd, card_verification_value, issued_month, issued_year, address_verification_code, amount, financial_currency_id)";
            sql += "            values (@financial_payment_card_id, @user_id, @date_time, @card_number, @name_on_card, @expiry_year, @expiry_month, @financial_card_type_rcd, @card_verification_value, @issued_month, @issued_year, @address_verification_code, @amount, @financial_currency_id)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_payment_card_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentCardId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@card_number",SqlDbType.NVarChar).Value = (System.String)CardNumber;
                    command.Parameters.Add("@name_on_card",SqlDbType.NVarChar).Value = (System.String)NameOnCard;
                    command.Parameters.Add("@expiry_year",SqlDbType.Int).Value = (System.Int32)ExpiryYear;
                    command.Parameters.Add("@expiry_month",SqlDbType.Int).Value = (System.Int32)ExpiryMonth;
                    command.Parameters.Add("@financial_card_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCardTypeRcd;
                    command.Parameters.Add("@card_verification_value",SqlDbType.Int).Value = (CardVerificationValue == 0 ? (object)DBNull.Value : (System.Int32)CardVerificationValue);
                    command.Parameters.Add("@issued_month",SqlDbType.Int).Value = (IssuedMonth == 0 ? (object)DBNull.Value : (System.Int32)IssuedMonth);
                    command.Parameters.Add("@issued_year",SqlDbType.Int).Value = (IssuedYear == 0 ? (object)DBNull.Value : (System.Int32)IssuedYear);
                    command.Parameters.Add("@address_verification_code",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressVerificationCode)) ? (object)DBNull.Value : (System.String)AddressVerificationCode;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialPaymentCardId == Guid.Empty)
                FinancialPaymentCardId = Guid.NewGuid();

            string sql = "insert into [financial_payment_card] (financial_payment_card_id, user_id, date_time, card_number, name_on_card, expiry_year, expiry_month, financial_card_type_rcd, card_verification_value, issued_month, issued_year, address_verification_code, amount, financial_currency_id)";
            sql += "            values (@financial_payment_card_id, @user_id, @date_time, @card_number, @name_on_card, @expiry_year, @expiry_month, @financial_card_type_rcd, @card_verification_value, @issued_month, @issued_year, @address_verification_code, @amount, @financial_currency_id)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_payment_card_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentCardId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@card_number",SqlDbType.NVarChar).Value = (System.String)CardNumber;
                command.Parameters.Add("@name_on_card",SqlDbType.NVarChar).Value = (System.String)NameOnCard;
                command.Parameters.Add("@expiry_year",SqlDbType.Int).Value = (System.Int32)ExpiryYear;
                command.Parameters.Add("@expiry_month",SqlDbType.Int).Value = (System.Int32)ExpiryMonth;
                command.Parameters.Add("@financial_card_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCardTypeRcd;
                command.Parameters.Add("@card_verification_value",SqlDbType.Int).Value = (CardVerificationValue == 0 ? (object)DBNull.Value : (System.Int32)CardVerificationValue);
                command.Parameters.Add("@issued_month",SqlDbType.Int).Value = (IssuedMonth == 0 ? (object)DBNull.Value : (System.Int32)IssuedMonth);
                command.Parameters.Add("@issued_year",SqlDbType.Int).Value = (IssuedYear == 0 ? (object)DBNull.Value : (System.Int32)IssuedYear);
                command.Parameters.Add("@address_verification_code",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressVerificationCode)) ? (object)DBNull.Value : (System.String)AddressVerificationCode;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_payment_card] set
                 financial_payment_card_id = @financial_payment_card_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,card_number = @card_number
                ,name_on_card = @name_on_card
                ,expiry_year = @expiry_year
                ,expiry_month = @expiry_month
                ,financial_card_type_rcd = @financial_card_type_rcd
                ,card_verification_value = @card_verification_value
                ,issued_month = @issued_month
                ,issued_year = @issued_year
                ,address_verification_code = @address_verification_code
                ,amount = @amount
                ,financial_currency_id = @financial_currency_id
            where financial_payment_card_id = @financial_payment_card_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_payment_card_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentCardId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@card_number",SqlDbType.NVarChar).Value = (System.String)CardNumber;
                    command.Parameters.Add("@name_on_card",SqlDbType.NVarChar).Value = (System.String)NameOnCard;
                    command.Parameters.Add("@expiry_year",SqlDbType.Int).Value = (System.Int32)ExpiryYear;
                    command.Parameters.Add("@expiry_month",SqlDbType.Int).Value = (System.Int32)ExpiryMonth;
                    command.Parameters.Add("@financial_card_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCardTypeRcd;
                    command.Parameters.Add("@card_verification_value",SqlDbType.Int).Value = (CardVerificationValue == 0 ? (object)DBNull.Value : (System.Int32)CardVerificationValue);
                    command.Parameters.Add("@issued_month",SqlDbType.Int).Value = (IssuedMonth == 0 ? (object)DBNull.Value : (System.Int32)IssuedMonth);
                    command.Parameters.Add("@issued_year",SqlDbType.Int).Value = (IssuedYear == 0 ? (object)DBNull.Value : (System.Int32)IssuedYear);
                    command.Parameters.Add("@address_verification_code",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressVerificationCode)) ? (object)DBNull.Value : (System.String)AddressVerificationCode;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_payment_card] set
                 financial_payment_card_id = @financial_payment_card_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,card_number = @card_number
                ,name_on_card = @name_on_card
                ,expiry_year = @expiry_year
                ,expiry_month = @expiry_month
                ,financial_card_type_rcd = @financial_card_type_rcd
                ,card_verification_value = @card_verification_value
                ,issued_month = @issued_month
                ,issued_year = @issued_year
                ,address_verification_code = @address_verification_code
                ,amount = @amount
                ,financial_currency_id = @financial_currency_id
            where financial_payment_card_id = @financial_payment_card_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_payment_card_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialPaymentCardId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@card_number",SqlDbType.NVarChar).Value = (System.String)CardNumber;
                command.Parameters.Add("@name_on_card",SqlDbType.NVarChar).Value = (System.String)NameOnCard;
                command.Parameters.Add("@expiry_year",SqlDbType.Int).Value = (System.Int32)ExpiryYear;
                command.Parameters.Add("@expiry_month",SqlDbType.Int).Value = (System.Int32)ExpiryMonth;
                command.Parameters.Add("@financial_card_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCardTypeRcd;
                command.Parameters.Add("@card_verification_value",SqlDbType.Int).Value = (CardVerificationValue == 0 ? (object)DBNull.Value : (System.Int32)CardVerificationValue);
                command.Parameters.Add("@issued_month",SqlDbType.Int).Value = (IssuedMonth == 0 ? (object)DBNull.Value : (System.Int32)IssuedMonth);
                command.Parameters.Add("@issued_year",SqlDbType.Int).Value = (IssuedYear == 0 ? (object)DBNull.Value : (System.Int32)IssuedYear);
                command.Parameters.Add("@address_verification_code",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressVerificationCode)) ? (object)DBNull.Value : (System.String)AddressVerificationCode;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid financialPaymentCardId) {
            string sql = @" delete [financial_payment_card] 
                where financial_payment_card_id = @financial_payment_card_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_payment_card_id",SqlDbType.UniqueIdentifier).Value = financialPaymentCardId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
