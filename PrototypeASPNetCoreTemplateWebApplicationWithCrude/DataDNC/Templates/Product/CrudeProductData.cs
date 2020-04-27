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
    public partial class CrudeProductData {
        
        public System.Guid ProductId { get; set; } //;
        
        public System.Guid ProductBecameId { get; set; } //;
        
        public string ProductName { get; set; } //;
        
        public string StateRcd { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductId(System.Guid productId) {
            string sql = @" select top 1 product_id, product_became_id, product_name, state_rcd, user_id, date_time
                            from [product]
                            where product_id = @product_id
                            order by product_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = productId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductData GetByProductId(System.Guid productId) {
            string sql = @" select top 1 product_id, product_became_id, product_name, state_rcd, user_id, date_time
                            from [product]
                            where product_id = @product_id
                            order by product_name";

            var ret = new CrudeProductData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductData> FetchByProductBecameId(System.Guid productBecameId) {
            var dataList = new List<CrudeProductData>();

            string sql = @" select product_id, product_became_id, product_name, state_rcd, user_id, date_time
                            from [product]
                            where product_became_id = @product_became_id
                              
                            order by product_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_became_id", SqlDbType.UniqueIdentifier).Value = productBecameId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductData>();

            string sql = @" select product_id, product_became_id, product_name, state_rcd, user_id, date_time
                            from [product]
                            where user_id = @user_id
                              
                            order by product_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductData> FetchByStateRcd(string stateRcd) {
            var dataList = new List<CrudeProductData>();

            string sql = @" select product_id, product_became_id, product_name, state_rcd, user_id, date_time
                            from [product]
                            where state_rcd = @state_rcd
                              
                            order by product_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@state_rcd", SqlDbType.NVarChar).Value = stateRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByProductName(string productName) {
            string sql = @" select top 1 product_id, product_became_id, product_name, state_rcd, user_id, date_time
                            from [product]
                            where product_name like '%' + @productName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@productName",SqlDbType.NVarChar).Value = productName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeProductData> FetchAll() {
            var dataList = new List<CrudeProductData>();

            string sql = @" select product_id, product_became_id, product_name, state_rcd, user_id, date_time
                            from [product]
                            order by product_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductData>();

            string sql = @" select top " + limit.ToString() + @" product_id, product_became_id, product_name, state_rcd, user_id, date_time
                            from [product]
                            order by product_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductData>();

            string sql = @" select product_id, product_became_id, product_name, state_rcd, user_id, date_time
                            from [product]
                            order by product_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductData();
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
            string sql = @" select count(*) as count from [product]";

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
        
        public static List<CrudeProductData> FetchWithFilter(System.Guid productId, System.Guid productBecameId, string productName, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductData>();

            string sql = @" select product_id, product_became_id, product_name, state_rcd, user_id, date_time
                            from [product]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productId != Guid.Empty) {
                        sql += "  and product_id = @product_id";
                        command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;
                    }
                    if (productBecameId != Guid.Empty) {
                        sql += "  and product_became_id = @product_became_id";
                        command.Parameters.Add("@product_became_id", SqlDbType.UniqueIdentifier).Value = productBecameId;
                    }
                    if (!string.IsNullOrEmpty(productName)) {
                        sql += "  and product_name like '%' + @product_name + '%'";
                        command.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = productName.Replace("'","''");
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
                    sql += " order by product_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_id"] != System.DBNull.Value) ProductId = (System.Guid) reader["product_id"];
            if (reader["product_became_id"] != System.DBNull.Value) ProductBecameId = (System.Guid) reader["product_became_id"];
            if (reader["product_name"] != System.DBNull.Value) ProductName = (System.String) reader["product_name"];
            if (reader["state_rcd"] != System.DBNull.Value) StateRcd = (System.String) reader["state_rcd"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductId == Guid.Empty)
                ProductId = Guid.NewGuid();

            string sql = "insert into [product] (product_id, product_became_id, product_name, state_rcd, user_id, date_time)";
            sql += "            values (@product_id, @product_became_id, @product_name, @state_rcd, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@product_became_id",SqlDbType.UniqueIdentifier).Value = (ProductBecameId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductBecameId);
                    command.Parameters.Add("@product_name",SqlDbType.NVarChar).Value = (System.String)ProductName;
                    command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductId == Guid.Empty)
                ProductId = Guid.NewGuid();

            string sql = "insert into [product] (product_id, product_became_id, product_name, state_rcd, user_id, date_time)";
            sql += "            values (@product_id, @product_became_id, @product_name, @state_rcd, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@product_became_id",SqlDbType.UniqueIdentifier).Value = (ProductBecameId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductBecameId);
                command.Parameters.Add("@product_name",SqlDbType.NVarChar).Value = (System.String)ProductName;
                command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product] set
                 product_id = @product_id
                ,product_became_id = @product_became_id
                ,product_name = @product_name
                ,state_rcd = @state_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where product_id = @product_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@product_became_id",SqlDbType.UniqueIdentifier).Value = (ProductBecameId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductBecameId);
                    command.Parameters.Add("@product_name",SqlDbType.NVarChar).Value = (System.String)ProductName;
                    command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product] set
                 product_id = @product_id
                ,product_became_id = @product_became_id
                ,product_name = @product_name
                ,state_rcd = @state_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where product_id = @product_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@product_became_id",SqlDbType.UniqueIdentifier).Value = (ProductBecameId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductBecameId);
                command.Parameters.Add("@product_name",SqlDbType.NVarChar).Value = (System.String)ProductName;
                command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid productId) {
            string sql = @" delete [product] 
                where product_id = @product_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = productId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
