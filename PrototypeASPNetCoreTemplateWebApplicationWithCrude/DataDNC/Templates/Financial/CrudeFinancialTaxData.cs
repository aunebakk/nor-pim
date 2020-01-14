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
    public partial class CrudeFinancialTaxData {
        
        public System.Guid FinancialTaxId { get; set; } //;
        
        public string FinancialTaxTypeRcd { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        public decimal Amount { get; set; } //;
        
        public void FetchByFinancialTaxId(System.Guid financialTaxId) {
            string sql = @" select top 1 financial_tax_id, financial_tax_type_rcd, user_id, date_time, financial_currency_id, amount
                            from [financial_tax]
                            where financial_tax_id = @financial_tax_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_tax_id",SqlDbType.UniqueIdentifier).Value = financialTaxId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialTaxData GetByFinancialTaxId(System.Guid financialTaxId) {
            string sql = @" select top 1 financial_tax_id, financial_tax_type_rcd, user_id, date_time, financial_currency_id, amount
                            from [financial_tax]
                            where financial_tax_id = @financial_tax_id";

            var ret = new CrudeFinancialTaxData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_tax_id",SqlDbType.UniqueIdentifier).Value = financialTaxId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialTaxData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialTaxData>();

            string sql = @" select financial_tax_id, financial_tax_type_rcd, user_id, date_time, financial_currency_id, amount
                            from [financial_tax]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialTaxData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialTaxData> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataList = new List<CrudeFinancialTaxData>();

            string sql = @" select financial_tax_id, financial_tax_type_rcd, user_id, date_time, financial_currency_id, amount
                            from [financial_tax]
                            where financial_currency_id = @financial_currency_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialTaxData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialTaxData> FetchByFinancialTaxTypeRcd(string financialTaxTypeRcd) {
            var dataList = new List<CrudeFinancialTaxData>();

            string sql = @" select financial_tax_id, financial_tax_type_rcd, user_id, date_time, financial_currency_id, amount
                            from [financial_tax]
                            where financial_tax_type_rcd = @financial_tax_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_tax_type_rcd", SqlDbType.NVarChar).Value = financialTaxTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialTaxData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialTaxData> FetchAll() {
            var dataList = new List<CrudeFinancialTaxData>();

            string sql = @" select financial_tax_id, financial_tax_type_rcd, user_id, date_time, financial_currency_id, amount
                            from [financial_tax]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialTaxData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialTaxData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialTaxData>();

            string sql = @" select top " + limit.ToString() + @" financial_tax_id, financial_tax_type_rcd, user_id, date_time, financial_currency_id, amount
                            from [financial_tax]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialTaxData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialTaxData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialTaxData>();

            string sql = @" select financial_tax_id, financial_tax_type_rcd, user_id, date_time, financial_currency_id, amount
                            from [financial_tax]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialTaxData();
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
            string sql = @" select count(*) as count from [financial_tax]";

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
        
        public static List<CrudeFinancialTaxData> FetchWithFilter(System.Guid financialTaxId, string financialTaxTypeRcd, System.Guid userId, System.DateTime dateTime, System.Guid financialCurrencyId, decimal amount) {
            var dataList = new List<CrudeFinancialTaxData>();

            string sql = @" select financial_tax_id, financial_tax_type_rcd, user_id, date_time, financial_currency_id, amount
                            from [financial_tax]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialTaxId != Guid.Empty) {
                        sql += "  and financial_tax_id = @financial_tax_id";
                        command.Parameters.Add("@financial_tax_id", SqlDbType.UniqueIdentifier).Value = financialTaxId;
                    }
                    if (!string.IsNullOrEmpty(financialTaxTypeRcd)) {
                        sql += "  and financial_tax_type_rcd like '%' + @financial_tax_type_rcd + '%'";
                        command.Parameters.Add("@financial_tax_type_rcd", SqlDbType.NVarChar).Value = financialTaxTypeRcd.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
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
                        var data = new CrudeFinancialTaxData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_tax_id"] != System.DBNull.Value) FinancialTaxId = (System.Guid) reader["financial_tax_id"];
            if (reader["financial_tax_type_rcd"] != System.DBNull.Value) FinancialTaxTypeRcd = (System.String) reader["financial_tax_type_rcd"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["financial_currency_id"] != System.DBNull.Value) FinancialCurrencyId = (System.Guid) reader["financial_currency_id"];
            if (reader["amount"] != System.DBNull.Value) Amount = (System.Decimal) reader["amount"];
        }
        
        public void Insert() {

            if (FinancialTaxId == Guid.Empty)
                FinancialTaxId = Guid.NewGuid();

            string sql = "insert into [financial_tax] (financial_tax_id, financial_tax_type_rcd, user_id, date_time, financial_currency_id, amount)";
            sql += "            values (@financial_tax_id, @financial_tax_type_rcd, @user_id, @date_time, @financial_currency_id, @amount)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_tax_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialTaxId;
                    command.Parameters.Add("@financial_tax_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialTaxTypeRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialTaxId == Guid.Empty)
                FinancialTaxId = Guid.NewGuid();

            string sql = "insert into [financial_tax] (financial_tax_id, financial_tax_type_rcd, user_id, date_time, financial_currency_id, amount)";
            sql += "            values (@financial_tax_id, @financial_tax_type_rcd, @user_id, @date_time, @financial_currency_id, @amount)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_tax_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialTaxId;
                command.Parameters.Add("@financial_tax_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialTaxTypeRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_tax] set
                 financial_tax_id = @financial_tax_id
                ,financial_tax_type_rcd = @financial_tax_type_rcd
                ,user_id = @user_id
                ,date_time = @date_time
                ,financial_currency_id = @financial_currency_id
                ,amount = @amount
            where financial_tax_id = @financial_tax_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_tax_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialTaxId;
                    command.Parameters.Add("@financial_tax_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialTaxTypeRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_tax] set
                 financial_tax_id = @financial_tax_id
                ,financial_tax_type_rcd = @financial_tax_type_rcd
                ,user_id = @user_id
                ,date_time = @date_time
                ,financial_currency_id = @financial_currency_id
                ,amount = @amount
            where financial_tax_id = @financial_tax_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_tax_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialTaxId;
                command.Parameters.Add("@financial_tax_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialTaxTypeRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid financialTaxId) {
            string sql = @" delete [financial_tax] 
                where financial_tax_id = @financial_tax_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_tax_id",SqlDbType.UniqueIdentifier).Value = financialTaxId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
