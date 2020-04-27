/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:45:11 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeFinancialOrderLineData {
        
        public System.Guid FinancialOrderLineId { get; set; } //;
        
        public System.Guid FinancialOrderId { get; set; } //;
        
        public System.Guid ProductId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public string Comment { get; set; } //;
        
        public int LineNumber { get; set; } //;
        
        public string FinancialUnitOfMeasurementRcd { get; set; } //;
        
        public int QuantityNumber { get; set; } //;
        
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        public decimal Amount { get; set; } //;
        
        public void FetchByFinancialOrderLineId(System.Guid financialOrderLineId) {
            string sql = @" select top 1 financial_order_line_id, financial_order_id, product_id, user_id, date_time, comment, line_number, financial_unit_of_measurement_rcd, quantity_number, financial_currency_id, amount
                            from [financial_order_line]
                            where financial_order_line_id = @financial_order_line_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_order_line_id",SqlDbType.UniqueIdentifier).Value = financialOrderLineId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialOrderLineData GetByFinancialOrderLineId(System.Guid financialOrderLineId) {
            string sql = @" select top 1 financial_order_line_id, financial_order_id, product_id, user_id, date_time, comment, line_number, financial_unit_of_measurement_rcd, quantity_number, financial_currency_id, amount
                            from [financial_order_line]
                            where financial_order_line_id = @financial_order_line_id";

            var ret = new CrudeFinancialOrderLineData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_line_id",SqlDbType.UniqueIdentifier).Value = financialOrderLineId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialOrderLineData> FetchByFinancialOrderId(System.Guid financialOrderId) {
            var dataList = new List<CrudeFinancialOrderLineData>();

            string sql = @" select financial_order_line_id, financial_order_id, product_id, user_id, date_time, comment, line_number, financial_unit_of_measurement_rcd, quantity_number, financial_currency_id, amount
                            from [financial_order_line]
                            where financial_order_id = @financial_order_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_id", SqlDbType.UniqueIdentifier).Value = financialOrderId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderLineData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderLineData> FetchByProductId(System.Guid productId) {
            var dataList = new List<CrudeFinancialOrderLineData>();

            string sql = @" select financial_order_line_id, financial_order_id, product_id, user_id, date_time, comment, line_number, financial_unit_of_measurement_rcd, quantity_number, financial_currency_id, amount
                            from [financial_order_line]
                            where product_id = @product_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderLineData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderLineData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialOrderLineData>();

            string sql = @" select financial_order_line_id, financial_order_id, product_id, user_id, date_time, comment, line_number, financial_unit_of_measurement_rcd, quantity_number, financial_currency_id, amount
                            from [financial_order_line]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderLineData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderLineData> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataList = new List<CrudeFinancialOrderLineData>();

            string sql = @" select financial_order_line_id, financial_order_id, product_id, user_id, date_time, comment, line_number, financial_unit_of_measurement_rcd, quantity_number, financial_currency_id, amount
                            from [financial_order_line]
                            where financial_currency_id = @financial_currency_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderLineData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderLineData> FetchByFinancialUnitOfMeasurementRcd(string financialUnitOfMeasurementRcd) {
            var dataList = new List<CrudeFinancialOrderLineData>();

            string sql = @" select financial_order_line_id, financial_order_id, product_id, user_id, date_time, comment, line_number, financial_unit_of_measurement_rcd, quantity_number, financial_currency_id, amount
                            from [financial_order_line]
                            where financial_unit_of_measurement_rcd = @financial_unit_of_measurement_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_unit_of_measurement_rcd", SqlDbType.NVarChar).Value = financialUnitOfMeasurementRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderLineData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderLineData> FetchAll() {
            var dataList = new List<CrudeFinancialOrderLineData>();

            string sql = @" select financial_order_line_id, financial_order_id, product_id, user_id, date_time, comment, line_number, financial_unit_of_measurement_rcd, quantity_number, financial_currency_id, amount
                            from [financial_order_line]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderLineData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderLineData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialOrderLineData>();

            string sql = @" select top " + limit.ToString() + @" financial_order_line_id, financial_order_id, product_id, user_id, date_time, comment, line_number, financial_unit_of_measurement_rcd, quantity_number, financial_currency_id, amount
                            from [financial_order_line]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderLineData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderLineData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialOrderLineData>();

            string sql = @" select financial_order_line_id, financial_order_id, product_id, user_id, date_time, comment, line_number, financial_unit_of_measurement_rcd, quantity_number, financial_currency_id, amount
                            from [financial_order_line]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialOrderLineData();
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
            string sql = @" select count(*) as count from [financial_order_line]";

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
        
        public static List<CrudeFinancialOrderLineData> FetchWithFilter(System.Guid financialOrderLineId, System.Guid financialOrderId, System.Guid productId, System.Guid userId, System.DateTime dateTime, string comment, int lineNumber, string financialUnitOfMeasurementRcd, int quantityNumber, System.Guid financialCurrencyId, decimal amount) {
            var dataList = new List<CrudeFinancialOrderLineData>();

            string sql = @" select financial_order_line_id, financial_order_id, product_id, user_id, date_time, comment, line_number, financial_unit_of_measurement_rcd, quantity_number, financial_currency_id, amount
                            from [financial_order_line]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialOrderLineId != Guid.Empty) {
                        sql += "  and financial_order_line_id = @financial_order_line_id";
                        command.Parameters.Add("@financial_order_line_id", SqlDbType.UniqueIdentifier).Value = financialOrderLineId;
                    }
                    if (financialOrderId != Guid.Empty) {
                        sql += "  and financial_order_id = @financial_order_id";
                        command.Parameters.Add("@financial_order_id", SqlDbType.UniqueIdentifier).Value = financialOrderId;
                    }
                    if (productId != Guid.Empty) {
                        sql += "  and product_id = @product_id";
                        command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (!string.IsNullOrEmpty(comment)) {
                        sql += "  and comment like '%' + @comment + '%'";
                        command.Parameters.Add("@comment", SqlDbType.NVarChar).Value = comment.Replace("'","''");
                    }
                    if (lineNumber != 0) {
                        sql += "  and line_number = @line_number";
                        command.Parameters.Add("@line_number", SqlDbType.Int).Value = lineNumber;
                    }
                    if (!string.IsNullOrEmpty(financialUnitOfMeasurementRcd)) {
                        sql += "  and financial_unit_of_measurement_rcd like '%' + @financial_unit_of_measurement_rcd + '%'";
                        command.Parameters.Add("@financial_unit_of_measurement_rcd", SqlDbType.NVarChar).Value = financialUnitOfMeasurementRcd.Replace("'","''");
                    }
                    if (quantityNumber != 0) {
                        sql += "  and quantity_number = @quantity_number";
                        command.Parameters.Add("@quantity_number", SqlDbType.Int).Value = quantityNumber;
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
                        var data = new CrudeFinancialOrderLineData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_order_line_id"] != System.DBNull.Value) FinancialOrderLineId = (System.Guid) reader["financial_order_line_id"];
            if (reader["financial_order_id"] != System.DBNull.Value) FinancialOrderId = (System.Guid) reader["financial_order_id"];
            if (reader["product_id"] != System.DBNull.Value) ProductId = (System.Guid) reader["product_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["comment"] != System.DBNull.Value) Comment = (System.String) reader["comment"];
            if (reader["line_number"] != System.DBNull.Value) LineNumber = (System.Int32) reader["line_number"];
            if (reader["financial_unit_of_measurement_rcd"] != System.DBNull.Value) FinancialUnitOfMeasurementRcd = (System.String) reader["financial_unit_of_measurement_rcd"];
            if (reader["quantity_number"] != System.DBNull.Value) QuantityNumber = (System.Int32) reader["quantity_number"];
            if (reader["financial_currency_id"] != System.DBNull.Value) FinancialCurrencyId = (System.Guid) reader["financial_currency_id"];
            if (reader["amount"] != System.DBNull.Value) Amount = (System.Decimal) reader["amount"];
        }
        
        public void Insert() {

            if (FinancialOrderLineId == Guid.Empty)
                FinancialOrderLineId = Guid.NewGuid();

            string sql = "insert into [financial_order_line] (financial_order_line_id, financial_order_id, product_id, user_id, date_time, comment, line_number, financial_unit_of_measurement_rcd, quantity_number, financial_currency_id, amount)";
            sql += "            values (@financial_order_line_id, @financial_order_id, @product_id, @user_id, @date_time, @comment, @line_number, @financial_unit_of_measurement_rcd, @quantity_number, @financial_currency_id, @amount)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_order_line_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderLineId;
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                    command.Parameters.Add("@line_number",SqlDbType.Int).Value = (System.Int32)LineNumber;
                    command.Parameters.Add("@financial_unit_of_measurement_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementRcd;
                    command.Parameters.Add("@quantity_number",SqlDbType.Int).Value = (System.Int32)QuantityNumber;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialOrderLineId == Guid.Empty)
                FinancialOrderLineId = Guid.NewGuid();

            string sql = "insert into [financial_order_line] (financial_order_line_id, financial_order_id, product_id, user_id, date_time, comment, line_number, financial_unit_of_measurement_rcd, quantity_number, financial_currency_id, amount)";
            sql += "            values (@financial_order_line_id, @financial_order_id, @product_id, @user_id, @date_time, @comment, @line_number, @financial_unit_of_measurement_rcd, @quantity_number, @financial_currency_id, @amount)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_order_line_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderLineId;
                command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                command.Parameters.Add("@line_number",SqlDbType.Int).Value = (System.Int32)LineNumber;
                command.Parameters.Add("@financial_unit_of_measurement_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementRcd;
                command.Parameters.Add("@quantity_number",SqlDbType.Int).Value = (System.Int32)QuantityNumber;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_order_line] set
                 financial_order_line_id = @financial_order_line_id
                ,financial_order_id = @financial_order_id
                ,product_id = @product_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,comment = @comment
                ,line_number = @line_number
                ,financial_unit_of_measurement_rcd = @financial_unit_of_measurement_rcd
                ,quantity_number = @quantity_number
                ,financial_currency_id = @financial_currency_id
                ,amount = @amount
            where financial_order_line_id = @financial_order_line_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_order_line_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderLineId;
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                    command.Parameters.Add("@line_number",SqlDbType.Int).Value = (System.Int32)LineNumber;
                    command.Parameters.Add("@financial_unit_of_measurement_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementRcd;
                    command.Parameters.Add("@quantity_number",SqlDbType.Int).Value = (System.Int32)QuantityNumber;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_order_line] set
                 financial_order_line_id = @financial_order_line_id
                ,financial_order_id = @financial_order_id
                ,product_id = @product_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,comment = @comment
                ,line_number = @line_number
                ,financial_unit_of_measurement_rcd = @financial_unit_of_measurement_rcd
                ,quantity_number = @quantity_number
                ,financial_currency_id = @financial_currency_id
                ,amount = @amount
            where financial_order_line_id = @financial_order_line_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_order_line_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderLineId;
                command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                command.Parameters.Add("@line_number",SqlDbType.Int).Value = (System.Int32)LineNumber;
                command.Parameters.Add("@financial_unit_of_measurement_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialUnitOfMeasurementRcd;
                command.Parameters.Add("@quantity_number",SqlDbType.Int).Value = (System.Int32)QuantityNumber;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid financialOrderLineId) {
            string sql = @" delete [financial_order_line] 
                where financial_order_line_id = @financial_order_line_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_line_id",SqlDbType.UniqueIdentifier).Value = financialOrderLineId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
