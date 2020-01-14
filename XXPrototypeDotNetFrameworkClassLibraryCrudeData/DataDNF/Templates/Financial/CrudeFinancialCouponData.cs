/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:42:22 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeFinancialCouponData {
        
        public System.Guid FinancialCouponId { get; set; } //;
        
        public int CouponNumber { get; set; } //;
        
        public decimal ValueAmount { get; set; } //;
        
        public System.DateTime ValidFromDateTime { get; set; } //;
        
        public System.DateTime ValidUntilDateTime { get; set; } //;
        
        public string CouponDescription { get; set; } //;
        
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public string FinancialCouponTypeRcd { get; set; } //;
        
        public void FetchByFinancialCouponId(System.Guid financialCouponId) {
            string sql = @" select top 1 financial_coupon_id, coupon_number, value_amount, valid_from_date_time, valid_until_date_time, coupon_description, financial_currency_id, user_id, date_time, financial_coupon_type_rcd
                            from [financial_coupon]
                            where financial_coupon_id = @financial_coupon_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_coupon_id",SqlDbType.UniqueIdentifier).Value = financialCouponId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialCouponData GetByFinancialCouponId(System.Guid financialCouponId) {
            string sql = @" select top 1 financial_coupon_id, coupon_number, value_amount, valid_from_date_time, valid_until_date_time, coupon_description, financial_currency_id, user_id, date_time, financial_coupon_type_rcd
                            from [financial_coupon]
                            where financial_coupon_id = @financial_coupon_id";

            var ret = new CrudeFinancialCouponData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_coupon_id",SqlDbType.UniqueIdentifier).Value = financialCouponId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialCouponData> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataList = new List<CrudeFinancialCouponData>();

            string sql = @" select financial_coupon_id, coupon_number, value_amount, valid_from_date_time, valid_until_date_time, coupon_description, financial_currency_id, user_id, date_time, financial_coupon_type_rcd
                            from [financial_coupon]
                            where financial_currency_id = @financial_currency_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCouponData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCouponData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialCouponData>();

            string sql = @" select financial_coupon_id, coupon_number, value_amount, valid_from_date_time, valid_until_date_time, coupon_description, financial_currency_id, user_id, date_time, financial_coupon_type_rcd
                            from [financial_coupon]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCouponData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCouponData> FetchByFinancialCouponTypeRcd(string financialCouponTypeRcd) {
            var dataList = new List<CrudeFinancialCouponData>();

            string sql = @" select financial_coupon_id, coupon_number, value_amount, valid_from_date_time, valid_until_date_time, coupon_description, financial_currency_id, user_id, date_time, financial_coupon_type_rcd
                            from [financial_coupon]
                            where financial_coupon_type_rcd = @financial_coupon_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_coupon_type_rcd", SqlDbType.NVarChar).Value = financialCouponTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCouponData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCouponData> FetchAll() {
            var dataList = new List<CrudeFinancialCouponData>();

            string sql = @" select financial_coupon_id, coupon_number, value_amount, valid_from_date_time, valid_until_date_time, coupon_description, financial_currency_id, user_id, date_time, financial_coupon_type_rcd
                            from [financial_coupon]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCouponData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCouponData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialCouponData>();

            string sql = @" select top " + limit.ToString() + @" financial_coupon_id, coupon_number, value_amount, valid_from_date_time, valid_until_date_time, coupon_description, financial_currency_id, user_id, date_time, financial_coupon_type_rcd
                            from [financial_coupon]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCouponData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCouponData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialCouponData>();

            string sql = @" select financial_coupon_id, coupon_number, value_amount, valid_from_date_time, valid_until_date_time, coupon_description, financial_currency_id, user_id, date_time, financial_coupon_type_rcd
                            from [financial_coupon]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialCouponData();
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
            string sql = @" select count(*) as count from [financial_coupon]";

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
        
        public static List<CrudeFinancialCouponData> FetchWithFilter(System.Guid financialCouponId, int couponNumber, decimal valueAmount, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, string couponDescription, System.Guid financialCurrencyId, System.Guid userId, System.DateTime dateTime, string financialCouponTypeRcd) {
            var dataList = new List<CrudeFinancialCouponData>();

            string sql = @" select financial_coupon_id, coupon_number, value_amount, valid_from_date_time, valid_until_date_time, coupon_description, financial_currency_id, user_id, date_time, financial_coupon_type_rcd
                            from [financial_coupon]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialCouponId != Guid.Empty) {
                        sql += "  and financial_coupon_id = @financial_coupon_id";
                        command.Parameters.Add("@financial_coupon_id", SqlDbType.UniqueIdentifier).Value = financialCouponId;
                    }
                    if (couponNumber != 0) {
                        sql += "  and coupon_number = @coupon_number";
                        command.Parameters.Add("@coupon_number", SqlDbType.Int).Value = couponNumber;
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
                    if (!string.IsNullOrEmpty(couponDescription)) {
                        sql += "  and coupon_description like '%' + @coupon_description + '%'";
                        command.Parameters.Add("@coupon_description", SqlDbType.NVarChar).Value = couponDescription.Replace("'","''");
                    }
                    if (financialCurrencyId != Guid.Empty) {
                        sql += "  and financial_currency_id = @financial_currency_id";
                        command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (!string.IsNullOrEmpty(financialCouponTypeRcd)) {
                        sql += "  and financial_coupon_type_rcd like '%' + @financial_coupon_type_rcd + '%'";
                        command.Parameters.Add("@financial_coupon_type_rcd", SqlDbType.NVarChar).Value = financialCouponTypeRcd.Replace("'","''");
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCouponData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_coupon_id"] != System.DBNull.Value) FinancialCouponId = (System.Guid) reader["financial_coupon_id"];
            if (reader["coupon_number"] != System.DBNull.Value) CouponNumber = (System.Int32) reader["coupon_number"];
            if (reader["value_amount"] != System.DBNull.Value) ValueAmount = (System.Decimal) reader["value_amount"];
            if (reader["valid_from_date_time"] != System.DBNull.Value) ValidFromDateTime = (System.DateTime) reader["valid_from_date_time"];
            if (reader["valid_until_date_time"] != System.DBNull.Value) ValidUntilDateTime = (System.DateTime) reader["valid_until_date_time"];
            if (reader["coupon_description"] != System.DBNull.Value) CouponDescription = (System.String) reader["coupon_description"];
            if (reader["financial_currency_id"] != System.DBNull.Value) FinancialCurrencyId = (System.Guid) reader["financial_currency_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["financial_coupon_type_rcd"] != System.DBNull.Value) FinancialCouponTypeRcd = (System.String) reader["financial_coupon_type_rcd"];
        }
        
        public void Insert() {

            if (FinancialCouponId == Guid.Empty)
                FinancialCouponId = Guid.NewGuid();

            string sql = "insert into [financial_coupon] (financial_coupon_id, coupon_number, value_amount, valid_from_date_time, valid_until_date_time, coupon_description, financial_currency_id, user_id, date_time, financial_coupon_type_rcd)";
            sql += "            values (@financial_coupon_id, @coupon_number, @value_amount, @valid_from_date_time, @valid_until_date_time, @coupon_description, @financial_currency_id, @user_id, @date_time, @financial_coupon_type_rcd)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_coupon_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCouponId;
                    command.Parameters.Add("@coupon_number",SqlDbType.Int).Value = (System.Int32)CouponNumber;
                    command.Parameters.Add("@value_amount",SqlDbType.Decimal).Value = (System.Decimal)ValueAmount;
                    command.Parameters.Add("@valid_from_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidFromDateTime;
                    command.Parameters.Add("@valid_until_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidUntilDateTime;
                    command.Parameters.Add("@coupon_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(CouponDescription)) ? (object)DBNull.Value : (System.String)CouponDescription;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@financial_coupon_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCouponTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialCouponId == Guid.Empty)
                FinancialCouponId = Guid.NewGuid();

            string sql = "insert into [financial_coupon] (financial_coupon_id, coupon_number, value_amount, valid_from_date_time, valid_until_date_time, coupon_description, financial_currency_id, user_id, date_time, financial_coupon_type_rcd)";
            sql += "            values (@financial_coupon_id, @coupon_number, @value_amount, @valid_from_date_time, @valid_until_date_time, @coupon_description, @financial_currency_id, @user_id, @date_time, @financial_coupon_type_rcd)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_coupon_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCouponId;
                command.Parameters.Add("@coupon_number",SqlDbType.Int).Value = (System.Int32)CouponNumber;
                command.Parameters.Add("@value_amount",SqlDbType.Decimal).Value = (System.Decimal)ValueAmount;
                command.Parameters.Add("@valid_from_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidFromDateTime;
                command.Parameters.Add("@valid_until_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidUntilDateTime;
                command.Parameters.Add("@coupon_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(CouponDescription)) ? (object)DBNull.Value : (System.String)CouponDescription;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@financial_coupon_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCouponTypeRcd;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_coupon] set
                 financial_coupon_id = @financial_coupon_id
                ,coupon_number = @coupon_number
                ,value_amount = @value_amount
                ,valid_from_date_time = @valid_from_date_time
                ,valid_until_date_time = @valid_until_date_time
                ,coupon_description = @coupon_description
                ,financial_currency_id = @financial_currency_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,financial_coupon_type_rcd = @financial_coupon_type_rcd
            where financial_coupon_id = @financial_coupon_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_coupon_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCouponId;
                    command.Parameters.Add("@coupon_number",SqlDbType.Int).Value = (System.Int32)CouponNumber;
                    command.Parameters.Add("@value_amount",SqlDbType.Decimal).Value = (System.Decimal)ValueAmount;
                    command.Parameters.Add("@valid_from_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidFromDateTime;
                    command.Parameters.Add("@valid_until_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidUntilDateTime;
                    command.Parameters.Add("@coupon_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(CouponDescription)) ? (object)DBNull.Value : (System.String)CouponDescription;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@financial_coupon_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCouponTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_coupon] set
                 financial_coupon_id = @financial_coupon_id
                ,coupon_number = @coupon_number
                ,value_amount = @value_amount
                ,valid_from_date_time = @valid_from_date_time
                ,valid_until_date_time = @valid_until_date_time
                ,coupon_description = @coupon_description
                ,financial_currency_id = @financial_currency_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,financial_coupon_type_rcd = @financial_coupon_type_rcd
            where financial_coupon_id = @financial_coupon_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_coupon_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCouponId;
                command.Parameters.Add("@coupon_number",SqlDbType.Int).Value = (System.Int32)CouponNumber;
                command.Parameters.Add("@value_amount",SqlDbType.Decimal).Value = (System.Decimal)ValueAmount;
                command.Parameters.Add("@valid_from_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidFromDateTime;
                command.Parameters.Add("@valid_until_date_time",SqlDbType.DateTime).Value = (System.DateTime)ValidUntilDateTime;
                command.Parameters.Add("@coupon_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(CouponDescription)) ? (object)DBNull.Value : (System.String)CouponDescription;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@financial_coupon_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCouponTypeRcd;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid financialCouponId) {
            string sql = @" delete [financial_coupon] 
                where financial_coupon_id = @financial_coupon_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_coupon_id",SqlDbType.UniqueIdentifier).Value = financialCouponId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
