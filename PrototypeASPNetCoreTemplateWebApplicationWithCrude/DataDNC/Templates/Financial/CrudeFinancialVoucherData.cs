/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:27 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeFinancialVoucherData {
        
        public System.Guid FinancialVoucherId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public decimal ValueAmount { get; set; } //;
        
        public System.DateTime ValidFromDateTime { get; set; } //;
        
        public System.DateTime ValidUntilDateTime { get; set; } //;
        
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        public int VoucherNumber { get; set; } //;
        
        public string VoucherDescription { get; set; } //;
        
        public string FinancialVoucherTypeRcd { get; set; } //;
        
        public void FetchByFinancialVoucherId(System.Guid financialVoucherId) {
            string sql = @" select top 1 financial_voucher_id, user_id, date_time, value_amount, valid_from_date_time, valid_until_date_time, financial_currency_id, voucher_number, voucher_description, financial_voucher_type_rcd
                            from [financial_voucher]
                            where financial_voucher_id = @financial_voucher_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_voucher_id",SqlDbType.UniqueIdentifier).Value = financialVoucherId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialVoucherData GetByFinancialVoucherId(System.Guid financialVoucherId) {
            string sql = @" select top 1 financial_voucher_id, user_id, date_time, value_amount, valid_from_date_time, valid_until_date_time, financial_currency_id, voucher_number, voucher_description, financial_voucher_type_rcd
                            from [financial_voucher]
                            where financial_voucher_id = @financial_voucher_id";

            var ret = new CrudeFinancialVoucherData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_voucher_id",SqlDbType.UniqueIdentifier).Value = financialVoucherId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialVoucherData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialVoucherData>();

            string sql = @" select financial_voucher_id, user_id, date_time, value_amount, valid_from_date_time, valid_until_date_time, financial_currency_id, voucher_number, voucher_description, financial_voucher_type_rcd
                            from [financial_voucher]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialVoucherData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialVoucherData> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataList = new List<CrudeFinancialVoucherData>();

            string sql = @" select financial_voucher_id, user_id, date_time, value_amount, valid_from_date_time, valid_until_date_time, financial_currency_id, voucher_number, voucher_description, financial_voucher_type_rcd
                            from [financial_voucher]
                            where financial_currency_id = @financial_currency_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialVoucherData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialVoucherData> FetchByFinancialVoucherTypeRcd(string financialVoucherTypeRcd) {
            var dataList = new List<CrudeFinancialVoucherData>();

            string sql = @" select financial_voucher_id, user_id, date_time, value_amount, valid_from_date_time, valid_until_date_time, financial_currency_id, voucher_number, voucher_description, financial_voucher_type_rcd
                            from [financial_voucher]
                            where financial_voucher_type_rcd = @financial_voucher_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_voucher_type_rcd", SqlDbType.NVarChar).Value = financialVoucherTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialVoucherData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialVoucherData> FetchAll() {
            var dataList = new List<CrudeFinancialVoucherData>();

            string sql = @" select financial_voucher_id, user_id, date_time, value_amount, valid_from_date_time, valid_until_date_time, financial_currency_id, voucher_number, voucher_description, financial_voucher_type_rcd
                            from [financial_voucher]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialVoucherData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialVoucherData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialVoucherData>();

            string sql = @" select top " + limit.ToString() + @" financial_voucher_id, user_id, date_time, value_amount, valid_from_date_time, valid_until_date_time, financial_currency_id, voucher_number, voucher_description, financial_voucher_type_rcd
                            from [financial_voucher]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialVoucherData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialVoucherData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialVoucherData>();

            string sql = @" select financial_voucher_id, user_id, date_time, value_amount, valid_from_date_time, valid_until_date_time, financial_currency_id, voucher_number, voucher_description, financial_voucher_type_rcd
                            from [financial_voucher]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialVoucherData();
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
            string sql = @" select count(*) as count from [financial_voucher]";

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
        
        public static List<CrudeFinancialVoucherData> FetchWithFilter(System.Guid financialVoucherId, System.Guid userId, System.DateTime dateTime, decimal valueAmount, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, System.Guid financialCurrencyId, int voucherNumber, string voucherDescription, string financialVoucherTypeRcd) {
            var dataList = new List<CrudeFinancialVoucherData>();

            string sql = @" select financial_voucher_id, user_id, date_time, value_amount, valid_from_date_time, valid_until_date_time, financial_currency_id, voucher_number, voucher_description, financial_voucher_type_rcd
                            from [financial_voucher]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialVoucherId != Guid.Empty) {
                        sql += "  and financial_voucher_id = @financial_voucher_id";
                        command.Parameters.Add("@financial_voucher_id", SqlDbType.UniqueIdentifier).Value = financialVoucherId;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (valueAmount != 0) {
                        sql += "  and value_amount = @value_amount";
                        command.Parameters.Add("@value_amount", SqlDbType.Decimal).Value = valueAmount;
                    }
                    if (validFromDateTime != DateTime.MinValue) {
                        sql += "  and valid_from_date_time = @valid_from_date_time";
                        command.Parameters.Add("@valid_from_date_time", SqlDbType.DateTime).Value = validFromDateTime;
                    }
                    if (validUntilDateTime != DateTime.MinValue) {
                        sql += "  and valid_until_date_time = @valid_until_date_time";
                        command.Parameters.Add("@valid_until_date_time", SqlDbType.DateTime).Value = validUntilDateTime;
                    }
                    if (financialCurrencyId != Guid.Empty) {
                        sql += "  and financial_currency_id = @financial_currency_id";
                        command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;
                    }
                    if (voucherNumber != 0) {
                        sql += "  and voucher_number = @voucher_number";
                        command.Parameters.Add("@voucher_number", SqlDbType.Int).Value = voucherNumber;
                    }
                    if (!string.IsNullOrEmpty(voucherDescription)) {
                        sql += "  and voucher_description like '%' + @voucher_description + '%'";
                        command.Parameters.Add("@voucher_description", SqlDbType.NVarChar).Value = voucherDescription.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(financialVoucherTypeRcd)) {
                        sql += "  and financial_voucher_type_rcd like '%' + @financial_voucher_type_rcd + '%'";
                        command.Parameters.Add("@financial_voucher_type_rcd", SqlDbType.NVarChar).Value = financialVoucherTypeRcd.Replace("'","''");
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialVoucherData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_voucher_id"] != System.DBNull.Value) FinancialVoucherId = (System.Guid) reader["financial_voucher_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["value_amount"] != System.DBNull.Value) ValueAmount = (System.Decimal) reader["value_amount"];
            if (reader["valid_from_date_time"] != System.DBNull.Value) ValidFromDateTime = (System.DateTime) reader["valid_from_date_time"];
            if (reader["valid_until_date_time"] != System.DBNull.Value) ValidUntilDateTime = (System.DateTime) reader["valid_until_date_time"];
            if (reader["financial_currency_id"] != System.DBNull.Value) FinancialCurrencyId = (System.Guid) reader["financial_currency_id"];
            if (reader["voucher_number"] != System.DBNull.Value) VoucherNumber = (System.Int32) reader["voucher_number"];
            if (reader["voucher_description"] != System.DBNull.Value) VoucherDescription = (System.String) reader["voucher_description"];
            if (reader["financial_voucher_type_rcd"] != System.DBNull.Value) FinancialVoucherTypeRcd = (System.String) reader["financial_voucher_type_rcd"];
        }
        
        public void Insert() {

            if (FinancialVoucherId == Guid.Empty)
                FinancialVoucherId = Guid.NewGuid();

            string sql = "insert into [financial_voucher] (financial_voucher_id, user_id, date_time, value_amount, valid_from_date_time, valid_until_date_time, financial_currency_id, voucher_number, voucher_description, financial_voucher_type_rcd)";
            sql += "            values (@financial_voucher_id, @user_id, @date_time, @value_amount, @valid_from_date_time, @valid_until_date_time, @financial_currency_id, @voucher_number, @voucher_description, @financial_voucher_type_rcd)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_voucher_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialVoucherId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@value_amount",SqlDbType.Decimal).Value = (System.Decimal)ValueAmount;
                    command.Parameters.Add("@valid_from_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidFromDateTime;
                    command.Parameters.Add("@valid_until_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidUntilDateTime;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@voucher_number",SqlDbType.Int).Value = (System.Int32)VoucherNumber;
                    command.Parameters.Add("@voucher_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(VoucherDescription)) ? (object)DBNull.Value : (System.String)VoucherDescription;
                    command.Parameters.Add("@financial_voucher_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialVoucherTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialVoucherId == Guid.Empty)
                FinancialVoucherId = Guid.NewGuid();

            string sql = "insert into [financial_voucher] (financial_voucher_id, user_id, date_time, value_amount, valid_from_date_time, valid_until_date_time, financial_currency_id, voucher_number, voucher_description, financial_voucher_type_rcd)";
            sql += "            values (@financial_voucher_id, @user_id, @date_time, @value_amount, @valid_from_date_time, @valid_until_date_time, @financial_currency_id, @voucher_number, @voucher_description, @financial_voucher_type_rcd)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_voucher_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialVoucherId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@value_amount",SqlDbType.Decimal).Value = (System.Decimal)ValueAmount;
                command.Parameters.Add("@valid_from_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidFromDateTime;
                command.Parameters.Add("@valid_until_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidUntilDateTime;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@voucher_number",SqlDbType.Int).Value = (System.Int32)VoucherNumber;
                command.Parameters.Add("@voucher_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(VoucherDescription)) ? (object)DBNull.Value : (System.String)VoucherDescription;
                command.Parameters.Add("@financial_voucher_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialVoucherTypeRcd;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_voucher] set
                 financial_voucher_id = @financial_voucher_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,value_amount = @value_amount
                ,valid_from_date_time = @valid_from_date_time
                ,valid_until_date_time = @valid_until_date_time
                ,financial_currency_id = @financial_currency_id
                ,voucher_number = @voucher_number
                ,voucher_description = @voucher_description
                ,financial_voucher_type_rcd = @financial_voucher_type_rcd
            where financial_voucher_id = @financial_voucher_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_voucher_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialVoucherId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@value_amount",SqlDbType.Decimal).Value = (System.Decimal)ValueAmount;
                    command.Parameters.Add("@valid_from_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidFromDateTime;
                    command.Parameters.Add("@valid_until_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidUntilDateTime;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@voucher_number",SqlDbType.Int).Value = (System.Int32)VoucherNumber;
                    command.Parameters.Add("@voucher_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(VoucherDescription)) ? (object)DBNull.Value : (System.String)VoucherDescription;
                    command.Parameters.Add("@financial_voucher_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialVoucherTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_voucher] set
                 financial_voucher_id = @financial_voucher_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,value_amount = @value_amount
                ,valid_from_date_time = @valid_from_date_time
                ,valid_until_date_time = @valid_until_date_time
                ,financial_currency_id = @financial_currency_id
                ,voucher_number = @voucher_number
                ,voucher_description = @voucher_description
                ,financial_voucher_type_rcd = @financial_voucher_type_rcd
            where financial_voucher_id = @financial_voucher_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_voucher_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialVoucherId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@value_amount",SqlDbType.Decimal).Value = (System.Decimal)ValueAmount;
                command.Parameters.Add("@valid_from_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidFromDateTime;
                command.Parameters.Add("@valid_until_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidUntilDateTime;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@voucher_number",SqlDbType.Int).Value = (System.Int32)VoucherNumber;
                command.Parameters.Add("@voucher_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(VoucherDescription)) ? (object)DBNull.Value : (System.String)VoucherDescription;
                command.Parameters.Add("@financial_voucher_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialVoucherTypeRcd;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid financialVoucherId) {
            string sql = @" delete [financial_voucher] 
                where financial_voucher_id = @financial_voucher_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_voucher_id",SqlDbType.UniqueIdentifier).Value = financialVoucherId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
