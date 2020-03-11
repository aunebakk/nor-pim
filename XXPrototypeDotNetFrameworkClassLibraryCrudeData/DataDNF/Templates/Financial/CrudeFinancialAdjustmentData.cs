/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:25:56 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeFinancialAdjustmentData {
        
        public System.Guid FinancialAdjustmentId { get; set; } //;
        
        public decimal Amount { get; set; } //;
        
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public string FinancialAdjustmentTypeRcd { get; set; } //;
        
        public void FetchByFinancialAdjustmentId(System.Guid financialAdjustmentId) {
            string sql = @" select top 1 financial_adjustment_id, amount, financial_currency_id, user_id, date_time, financial_adjustment_type_rcd
                            from [financial_adjustment]
                            where financial_adjustment_id = @financial_adjustment_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_adjustment_id",SqlDbType.UniqueIdentifier).Value = financialAdjustmentId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialAdjustmentData GetByFinancialAdjustmentId(System.Guid financialAdjustmentId) {
            string sql = @" select top 1 financial_adjustment_id, amount, financial_currency_id, user_id, date_time, financial_adjustment_type_rcd
                            from [financial_adjustment]
                            where financial_adjustment_id = @financial_adjustment_id";

            var ret = new CrudeFinancialAdjustmentData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_adjustment_id",SqlDbType.UniqueIdentifier).Value = financialAdjustmentId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialAdjustmentData> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataList = new List<CrudeFinancialAdjustmentData>();

            string sql = @" select financial_adjustment_id, amount, financial_currency_id, user_id, date_time, financial_adjustment_type_rcd
                            from [financial_adjustment]
                            where financial_currency_id = @financial_currency_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialAdjustmentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialAdjustmentData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialAdjustmentData>();

            string sql = @" select financial_adjustment_id, amount, financial_currency_id, user_id, date_time, financial_adjustment_type_rcd
                            from [financial_adjustment]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialAdjustmentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialAdjustmentData> FetchByFinancialAdjustmentTypeRcd(string financialAdjustmentTypeRcd) {
            var dataList = new List<CrudeFinancialAdjustmentData>();

            string sql = @" select financial_adjustment_id, amount, financial_currency_id, user_id, date_time, financial_adjustment_type_rcd
                            from [financial_adjustment]
                            where financial_adjustment_type_rcd = @financial_adjustment_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_adjustment_type_rcd", SqlDbType.NVarChar).Value = financialAdjustmentTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialAdjustmentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialAdjustmentData> FetchAll() {
            var dataList = new List<CrudeFinancialAdjustmentData>();

            string sql = @" select financial_adjustment_id, amount, financial_currency_id, user_id, date_time, financial_adjustment_type_rcd
                            from [financial_adjustment]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialAdjustmentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialAdjustmentData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialAdjustmentData>();

            string sql = @" select top " + limit.ToString() + @" financial_adjustment_id, amount, financial_currency_id, user_id, date_time, financial_adjustment_type_rcd
                            from [financial_adjustment]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialAdjustmentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialAdjustmentData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialAdjustmentData>();

            string sql = @" select financial_adjustment_id, amount, financial_currency_id, user_id, date_time, financial_adjustment_type_rcd
                            from [financial_adjustment]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialAdjustmentData();
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
            string sql = @" select count(*) as count from [financial_adjustment]";

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
        
        public static List<CrudeFinancialAdjustmentData> FetchWithFilter(System.Guid financialAdjustmentId, decimal amount, System.Guid financialCurrencyId, System.Guid userId, System.DateTime dateTime, string financialAdjustmentTypeRcd) {
            var dataList = new List<CrudeFinancialAdjustmentData>();

            string sql = @" select financial_adjustment_id, amount, financial_currency_id, user_id, date_time, financial_adjustment_type_rcd
                            from [financial_adjustment]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialAdjustmentId != Guid.Empty) {
                        sql += "  and financial_adjustment_id = @financial_adjustment_id";
                        command.Parameters.Add("@financial_adjustment_id", SqlDbType.UniqueIdentifier).Value = financialAdjustmentId;
                    }
                    if (amount != 0) {
                        sql += "  and amount = @amount";
                        command.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
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
                    if (!string.IsNullOrEmpty(financialAdjustmentTypeRcd)) {
                        sql += "  and financial_adjustment_type_rcd like '%' + @financial_adjustment_type_rcd + '%'";
                        command.Parameters.Add("@financial_adjustment_type_rcd", SqlDbType.NVarChar).Value = financialAdjustmentTypeRcd.Replace("'","''");
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialAdjustmentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_adjustment_id"] != System.DBNull.Value) FinancialAdjustmentId = (System.Guid) reader["financial_adjustment_id"];
            if (reader["amount"] != System.DBNull.Value) Amount = (System.Decimal) reader["amount"];
            if (reader["financial_currency_id"] != System.DBNull.Value) FinancialCurrencyId = (System.Guid) reader["financial_currency_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["financial_adjustment_type_rcd"] != System.DBNull.Value) FinancialAdjustmentTypeRcd = (System.String) reader["financial_adjustment_type_rcd"];
        }
        
        public void Insert() {

            if (FinancialAdjustmentId == Guid.Empty)
                FinancialAdjustmentId = Guid.NewGuid();

            string sql = "insert into [financial_adjustment] (financial_adjustment_id, amount, financial_currency_id, user_id, date_time, financial_adjustment_type_rcd)";
            sql += "            values (@financial_adjustment_id, @amount, @financial_currency_id, @user_id, @date_time, @financial_adjustment_type_rcd)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_adjustment_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialAdjustmentId;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@financial_adjustment_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialAdjustmentTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialAdjustmentId == Guid.Empty)
                FinancialAdjustmentId = Guid.NewGuid();

            string sql = "insert into [financial_adjustment] (financial_adjustment_id, amount, financial_currency_id, user_id, date_time, financial_adjustment_type_rcd)";
            sql += "            values (@financial_adjustment_id, @amount, @financial_currency_id, @user_id, @date_time, @financial_adjustment_type_rcd)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_adjustment_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialAdjustmentId;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@financial_adjustment_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialAdjustmentTypeRcd;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_adjustment] set
                 financial_adjustment_id = @financial_adjustment_id
                ,amount = @amount
                ,financial_currency_id = @financial_currency_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,financial_adjustment_type_rcd = @financial_adjustment_type_rcd
            where financial_adjustment_id = @financial_adjustment_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_adjustment_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialAdjustmentId;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@financial_adjustment_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialAdjustmentTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_adjustment] set
                 financial_adjustment_id = @financial_adjustment_id
                ,amount = @amount
                ,financial_currency_id = @financial_currency_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,financial_adjustment_type_rcd = @financial_adjustment_type_rcd
            where financial_adjustment_id = @financial_adjustment_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_adjustment_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialAdjustmentId;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@financial_adjustment_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialAdjustmentTypeRcd;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid financialAdjustmentId) {
            string sql = @" delete [financial_adjustment] 
                where financial_adjustment_id = @financial_adjustment_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_adjustment_id",SqlDbType.UniqueIdentifier).Value = financialAdjustmentId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
