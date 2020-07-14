/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 6:12:02 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class CrudeCartProductData {
        
        public System.Guid CartProductId { get; set; }
        
        public System.Guid ClientId { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public System.Guid FinancialCurrencyId { get; set; }
        
        public decimal Amount { get; set; }
        
        public System.Guid SessionId { get; set; }
        
        public string SessionIdentificator { get; set; }
        
        public System.Guid AspId { get; set; }
        
        public string StateRcd { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public void FetchByCartProductId(System.Guid cartProductId) {
            string sql = @" select top 1 cart_product_id, client_id, product_id, financial_currency_id, amount, session_id, session_identificator, asp_id, state_rcd, user_id, date_time
                            from [cart_product]
                            where cart_product_id = @cart_product_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@cart_product_id",SqlDbType.UniqueIdentifier).Value = cartProductId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeCartProductData GetByCartProductId(System.Guid cartProductId) {
            string sql = @" select top 1 cart_product_id, client_id, product_id, financial_currency_id, amount, session_id, session_identificator, asp_id, state_rcd, user_id, date_time
                            from [cart_product]
                            where cart_product_id = @cart_product_id";

            var ret = new CrudeCartProductData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@cart_product_id",SqlDbType.UniqueIdentifier).Value = cartProductId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeCartProductData> FetchByClientId(System.Guid clientId) {
            var dataList = new List<CrudeCartProductData>();

            string sql = @" select cart_product_id, client_id, product_id, financial_currency_id, amount, session_id, session_identificator, asp_id, state_rcd, user_id, date_time
                            from [cart_product]
                            where client_id = @client_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeCartProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeCartProductData> FetchByProductId(System.Guid productId) {
            var dataList = new List<CrudeCartProductData>();

            string sql = @" select cart_product_id, client_id, product_id, financial_currency_id, amount, session_id, session_identificator, asp_id, state_rcd, user_id, date_time
                            from [cart_product]
                            where product_id = @product_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeCartProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeCartProductData> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            var dataList = new List<CrudeCartProductData>();

            string sql = @" select cart_product_id, client_id, product_id, financial_currency_id, amount, session_id, session_identificator, asp_id, state_rcd, user_id, date_time
                            from [cart_product]
                            where financial_currency_id = @financial_currency_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeCartProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeCartProductData> FetchBySessionId(System.Guid sessionId) {
            var dataList = new List<CrudeCartProductData>();

            string sql = @" select cart_product_id, client_id, product_id, financial_currency_id, amount, session_id, session_identificator, asp_id, state_rcd, user_id, date_time
                            from [cart_product]
                            where session_id = @session_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@session_id", SqlDbType.UniqueIdentifier).Value = sessionId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeCartProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeCartProductData> FetchByAspId(System.Guid aspId) {
            var dataList = new List<CrudeCartProductData>();

            string sql = @" select cart_product_id, client_id, product_id, financial_currency_id, amount, session_id, session_identificator, asp_id, state_rcd, user_id, date_time
                            from [cart_product]
                            where asp_id = @asp_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@asp_id", SqlDbType.UniqueIdentifier).Value = aspId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeCartProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeCartProductData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeCartProductData>();

            string sql = @" select cart_product_id, client_id, product_id, financial_currency_id, amount, session_id, session_identificator, asp_id, state_rcd, user_id, date_time
                            from [cart_product]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeCartProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeCartProductData> FetchByStateRcd(string stateRcd) {
            var dataList = new List<CrudeCartProductData>();

            string sql = @" select cart_product_id, client_id, product_id, financial_currency_id, amount, session_id, session_identificator, asp_id, state_rcd, user_id, date_time
                            from [cart_product]
                            where state_rcd = @state_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@state_rcd", SqlDbType.NVarChar).Value = stateRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeCartProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeCartProductData> FetchAll() {
            var dataList = new List<CrudeCartProductData>();

            string sql = @" select cart_product_id, client_id, product_id, financial_currency_id, amount, session_id, session_identificator, asp_id, state_rcd, user_id, date_time
                            from [cart_product]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeCartProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeCartProductData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeCartProductData>();

            string sql = @" select top " + limit.ToString() + @" cart_product_id, client_id, product_id, financial_currency_id, amount, session_id, session_identificator, asp_id, state_rcd, user_id, date_time
                            from [cart_product]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeCartProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeCartProductData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeCartProductData>();

            string sql = @" select cart_product_id, client_id, product_id, financial_currency_id, amount, session_id, session_identificator, asp_id, state_rcd, user_id, date_time
                            from [cart_product]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeCartProductData();
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
            string sql = @" select count(*) as count from [cart_product]";

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
        
        public static List<CrudeCartProductData> FetchWithFilter(System.Guid cartProductId, System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, decimal amount, System.Guid sessionId, string sessionIdentificator, System.Guid aspId, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeCartProductData>();

            string sql = @" select cart_product_id, client_id, product_id, financial_currency_id, amount, session_id, session_identificator, asp_id, state_rcd, user_id, date_time
                            from [cart_product]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (cartProductId != Guid.Empty) {
                        sql += "  and cart_product_id = @cart_product_id";
                        command.Parameters.Add("@cart_product_id", SqlDbType.UniqueIdentifier).Value = cartProductId;
                    }
                    if (clientId != Guid.Empty) {
                        sql += "  and client_id = @client_id";
                        command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;
                    }
                    if (productId != Guid.Empty) {
                        sql += "  and product_id = @product_id";
                        command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;
                    }
                    if (financialCurrencyId != Guid.Empty) {
                        sql += "  and financial_currency_id = @financial_currency_id";
                        command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;
                    }
                    if (amount != 0) {
                        sql += "  and amount = @amount";
                        command.Parameters.Add("@amount", SqlDbType.Decimal).Value = amount;
                    }
                    if (sessionId != Guid.Empty) {
                        sql += "  and session_id = @session_id";
                        command.Parameters.Add("@session_id", SqlDbType.UniqueIdentifier).Value = sessionId;
                    }
                    if (!string.IsNullOrEmpty(sessionIdentificator)) {
                        sql += "  and session_identificator like '%' + @session_identificator + '%'";
                        command.Parameters.Add("@session_identificator", SqlDbType.NVarChar).Value = sessionIdentificator.Replace("'","''");
                    }
                    if (aspId != Guid.Empty) {
                        sql += "  and asp_id = @asp_id";
                        command.Parameters.Add("@asp_id", SqlDbType.UniqueIdentifier).Value = aspId;
                    }
                    if (!string.IsNullOrEmpty(stateRcd)) {
                        sql += "  and state_rcd like '%' + @state_rcd + '%'";
                        command.Parameters.Add("@state_rcd", SqlDbType.NVarChar).Value = stateRcd.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeCartProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["cart_product_id"] != System.DBNull.Value) CartProductId = (System.Guid) reader["cart_product_id"];
            if (reader["client_id"] != System.DBNull.Value) ClientId = (System.Guid) reader["client_id"];
            if (reader["product_id"] != System.DBNull.Value) ProductId = (System.Guid) reader["product_id"];
            if (reader["financial_currency_id"] != System.DBNull.Value) FinancialCurrencyId = (System.Guid) reader["financial_currency_id"];
            if (reader["amount"] != System.DBNull.Value) Amount = (System.Decimal) reader["amount"];
            if (reader["session_id"] != System.DBNull.Value) SessionId = (System.Guid) reader["session_id"];
            if (reader["session_identificator"] != System.DBNull.Value) SessionIdentificator = (System.String) reader["session_identificator"];
            if (reader["asp_id"] != System.DBNull.Value) AspId = (System.Guid) reader["asp_id"];
            if (reader["state_rcd"] != System.DBNull.Value) StateRcd = (System.String) reader["state_rcd"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (CartProductId == Guid.Empty)
                CartProductId = Guid.NewGuid();

            string sql = "insert into [cart_product] (cart_product_id, client_id, product_id, financial_currency_id, amount, session_id, session_identificator, asp_id, state_rcd, user_id, date_time)";
            sql += "            values (@cart_product_id, @client_id, @product_id, @financial_currency_id, @amount, @session_id, @session_identificator, @asp_id, @state_rcd, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@cart_product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)CartProductId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (ClientId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ClientId);
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.Parameters.Add("@session_id",SqlDbType.UniqueIdentifier).Value = (SessionId == Guid.Empty ? (object)DBNull.Value : (System.Guid)SessionId);
                    command.Parameters.Add("@session_identificator",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(SessionIdentificator)) ? (object)DBNull.Value : (System.String)SessionIdentificator;
                    command.Parameters.Add("@asp_id",SqlDbType.UniqueIdentifier).Value = (AspId == Guid.Empty ? (object)DBNull.Value : (System.Guid)AspId);
                    command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (CartProductId == Guid.Empty)
                CartProductId = Guid.NewGuid();

            string sql = "insert into [cart_product] (cart_product_id, client_id, product_id, financial_currency_id, amount, session_id, session_identificator, asp_id, state_rcd, user_id, date_time)";
            sql += "            values (@cart_product_id, @client_id, @product_id, @financial_currency_id, @amount, @session_id, @session_identificator, @asp_id, @state_rcd, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@cart_product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)CartProductId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (ClientId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ClientId);
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.Parameters.Add("@session_id",SqlDbType.UniqueIdentifier).Value = (SessionId == Guid.Empty ? (object)DBNull.Value : (System.Guid)SessionId);
                command.Parameters.Add("@session_identificator",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(SessionIdentificator)) ? (object)DBNull.Value : (System.String)SessionIdentificator;
                command.Parameters.Add("@asp_id",SqlDbType.UniqueIdentifier).Value = (AspId == Guid.Empty ? (object)DBNull.Value : (System.Guid)AspId);
                command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [cart_product] set
                 cart_product_id = @cart_product_id
                ,client_id = @client_id
                ,product_id = @product_id
                ,financial_currency_id = @financial_currency_id
                ,amount = @amount
                ,session_id = @session_id
                ,session_identificator = @session_identificator
                ,asp_id = @asp_id
                ,state_rcd = @state_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where cart_product_id = @cart_product_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@cart_product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)CartProductId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (ClientId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ClientId);
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                    command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                    command.Parameters.Add("@session_id",SqlDbType.UniqueIdentifier).Value = (SessionId == Guid.Empty ? (object)DBNull.Value : (System.Guid)SessionId);
                    command.Parameters.Add("@session_identificator",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(SessionIdentificator)) ? (object)DBNull.Value : (System.String)SessionIdentificator;
                    command.Parameters.Add("@asp_id",SqlDbType.UniqueIdentifier).Value = (AspId == Guid.Empty ? (object)DBNull.Value : (System.Guid)AspId);
                    command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [cart_product] set
                 cart_product_id = @cart_product_id
                ,client_id = @client_id
                ,product_id = @product_id
                ,financial_currency_id = @financial_currency_id
                ,amount = @amount
                ,session_id = @session_id
                ,session_identificator = @session_identificator
                ,asp_id = @asp_id
                ,state_rcd = @state_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where cart_product_id = @cart_product_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@cart_product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)CartProductId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (ClientId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ClientId);
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCurrencyId;
                command.Parameters.Add("@amount",SqlDbType.Decimal).Value = (System.Decimal)Amount;
                command.Parameters.Add("@session_id",SqlDbType.UniqueIdentifier).Value = (SessionId == Guid.Empty ? (object)DBNull.Value : (System.Guid)SessionId);
                command.Parameters.Add("@session_identificator",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(SessionIdentificator)) ? (object)DBNull.Value : (System.String)SessionIdentificator;
                command.Parameters.Add("@asp_id",SqlDbType.UniqueIdentifier).Value = (AspId == Guid.Empty ? (object)DBNull.Value : (System.Guid)AspId);
                command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid cartProductId) {
            string sql = @" delete [cart_product] 
                where cart_product_id = @cart_product_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@cart_product_id",SqlDbType.UniqueIdentifier).Value = cartProductId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
