/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:46:27 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeFinancialOrderData {
        
        public System.Guid FinancialOrderId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public string Comment { get; set; } //;
        
        public System.Guid LocationAddressId { get; set; } //;
        
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        public string FinancialOrderSourceRcd { get; set; } //;
        
        public System.Guid ClientId { get; set; } //;
        
        public void FetchByFinancialOrderId(System.Guid financialOrderId) {
            string sql = @" select top 1 financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where financial_order_id = @financial_order_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = financialOrderId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialOrderData GetByFinancialOrderId(System.Guid financialOrderId) {
            string sql = @" select top 1 financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where financial_order_id = @financial_order_id";

            var ret = new CrudeFinancialOrderData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = financialOrderId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialOrderData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderData> FetchByLocationAddressId(System.Guid locationAddressId) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where location_address_id = @location_address_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@location_address_id", SqlDbType.UniqueIdentifier).Value = locationAddressId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderData> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where financial_currency_id = @financial_currency_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderData> FetchByClientId(System.Guid clientId) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where client_id = @client_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderData> FetchByFinancialOrderSourceRcd(string financialOrderSourceRcd) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where financial_order_source_rcd = @financial_order_source_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_source_rcd", SqlDbType.NVarChar).Value = financialOrderSourceRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderData> FetchAll() {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select top " + limit.ToString() + @" financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialOrderData();
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
            string sql = @" select count(*) as count from [financial_order]";

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
        
        public static List<CrudeFinancialOrderData> FetchWithFilter(System.Guid financialOrderId, System.Guid userId, System.DateTime dateTime, string comment, System.Guid locationAddressId, System.Guid financialCurrencyId, string financialOrderSourceRcd, System.Guid clientId) {
            var dataList = new List<CrudeFinancialOrderData>();

            string sql = @" select financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id
                            from [financial_order]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialOrderId != Guid.Empty) {
                        sql += "  and financial_order_id = @financial_order_id";
                        command.Parameters.Add("@financial_order_id", SqlDbType.UniqueIdentifier).Value = financialOrderId;
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
                    if (locationAddressId != Guid.Empty) {
                        sql += "  and location_address_id = @location_address_id";
                        command.Parameters.Add("@location_address_id", SqlDbType.UniqueIdentifier).Value = locationAddressId;
                    }
                    if (financialCurrencyId != Guid.Empty) {
                        sql += "  and financial_currency_id = @financial_currency_id";
                        command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;
                    }
                    if (!string.IsNullOrEmpty(financialOrderSourceRcd)) {
                        sql += "  and financial_order_source_rcd like '%' + @financial_order_source_rcd + '%'";
                        command.Parameters.Add("@financial_order_source_rcd", SqlDbType.NVarChar).Value = financialOrderSourceRcd.Replace("'","''");
                    }
                    if (clientId != Guid.Empty) {
                        sql += "  and client_id = @client_id";
                        command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_order_id"] != System.DBNull.Value) FinancialOrderId = (System.Guid) reader["financial_order_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["comment"] != System.DBNull.Value) Comment = (System.String) reader["comment"];
            if (reader["location_address_id"] != System.DBNull.Value) LocationAddressId = (System.Guid) reader["location_address_id"];
            if (reader["financial_currency_id"] != System.DBNull.Value) FinancialCurrencyId = (System.Guid) reader["financial_currency_id"];
            if (reader["financial_order_source_rcd"] != System.DBNull.Value) FinancialOrderSourceRcd = (System.String) reader["financial_order_source_rcd"];
            if (reader["client_id"] != System.DBNull.Value) ClientId = (System.Guid) reader["client_id"];
        }
        
        public void Insert() {

            if (FinancialOrderId == Guid.Empty)
                FinancialOrderId = Guid.NewGuid();

            string sql = "insert into [financial_order] (financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id)";
            sql += "            values (@financial_order_id, @user_id, @date_time, @comment, @location_address_id, @financial_currency_id, @financial_order_source_rcd, @client_id)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                    command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = (LocationAddressId == Guid.Empty ? (object)DBNull.Value : (System.Guid)LocationAddressId);
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@financial_order_source_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderSourceRcd;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialOrderId == Guid.Empty)
                FinancialOrderId = Guid.NewGuid();

            string sql = "insert into [financial_order] (financial_order_id, user_id, date_time, comment, location_address_id, financial_currency_id, financial_order_source_rcd, client_id)";
            sql += "            values (@financial_order_id, @user_id, @date_time, @comment, @location_address_id, @financial_currency_id, @financial_order_source_rcd, @client_id)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = (LocationAddressId == Guid.Empty ? (object)DBNull.Value : (System.Guid)LocationAddressId);
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@financial_order_source_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderSourceRcd;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_order] set
                 financial_order_id = @financial_order_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,comment = @comment
                ,location_address_id = @location_address_id
                ,financial_currency_id = @financial_currency_id
                ,financial_order_source_rcd = @financial_order_source_rcd
                ,client_id = @client_id
            where financial_order_id = @financial_order_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                    command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = (LocationAddressId == Guid.Empty ? (object)DBNull.Value : (System.Guid)LocationAddressId);
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@financial_order_source_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderSourceRcd;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_order] set
                 financial_order_id = @financial_order_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,comment = @comment
                ,location_address_id = @location_address_id
                ,financial_currency_id = @financial_currency_id
                ,financial_order_source_rcd = @financial_order_source_rcd
                ,client_id = @client_id
            where financial_order_id = @financial_order_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = (LocationAddressId == Guid.Empty ? (object)DBNull.Value : (System.Guid)LocationAddressId);
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@financial_order_source_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderSourceRcd;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid financialOrderId) {
            string sql = @" delete [financial_order] 
                where financial_order_id = @financial_order_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = financialOrderId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
