/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:22:09 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductCategoryData {
        
        public System.Guid ProductCategoryId { get; set; } //;
        
        public System.Guid ProductCategoryBecameId { get; set; } //;
        
        public System.Guid ProductCategoryParentId { get; set; } //;
        
        public string ProductCategoryCode { get; set; } //;
        
        public string ProductCategoryName { get; set; } //;
        
        public int ProductCategoryPosition { get; set; } //;
        
        public string StateRcd { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductCategoryId(System.Guid productCategoryId) {
            string sql = @" select top 1 product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where product_category_id = @product_category_id
                            order by product_category_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductCategoryData GetByProductCategoryId(System.Guid productCategoryId) {
            string sql = @" select top 1 product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where product_category_id = @product_category_id
                            order by product_category_name";

            var ret = new CrudeProductCategoryData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductCategoryData> FetchByProductCategoryBecameId(System.Guid productCategoryBecameId) {
            var dataList = new List<CrudeProductCategoryData>();

            string sql = @" select product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where product_category_became_id = @product_category_became_id
                              
                            order by product_category_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_became_id", SqlDbType.UniqueIdentifier).Value = productCategoryBecameId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductCategoryData> FetchByProductCategoryParentId(System.Guid productCategoryParentId) {
            var dataList = new List<CrudeProductCategoryData>();

            string sql = @" select product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where product_category_parent_id = @product_category_parent_id
                              
                            order by product_category_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_parent_id", SqlDbType.UniqueIdentifier).Value = productCategoryParentId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductCategoryData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductCategoryData>();

            string sql = @" select product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where user_id = @user_id
                              
                            order by product_category_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductCategoryData> FetchByStateRcd(string stateRcd) {
            var dataList = new List<CrudeProductCategoryData>();

            string sql = @" select product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where state_rcd = @state_rcd
                              
                            order by product_category_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@state_rcd", SqlDbType.NVarChar).Value = stateRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByProductCategoryName(string productCategoryName) {
            string sql = @" select top 1 product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where product_category_name like '%' + @productCategoryName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@productCategoryName",SqlDbType.NVarChar).Value = productCategoryName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeProductCategoryData> FetchAll() {
            var dataList = new List<CrudeProductCategoryData>();

            string sql = @" select product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            order by product_category_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductCategoryData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductCategoryData>();

            string sql = @" select top " + limit.ToString() + @" product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            order by product_category_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductCategoryData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductCategoryData>();

            string sql = @" select product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            order by product_category_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductCategoryData();
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
            string sql = @" select count(*) as count from [product_category]";

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
        
        public static List<CrudeProductCategoryData> FetchWithFilter(System.Guid productCategoryId, System.Guid productCategoryBecameId, System.Guid productCategoryParentId, string productCategoryCode, string productCategoryName, int productCategoryPosition, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductCategoryData>();

            string sql = @" select product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time
                            from [product_category]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productCategoryId != Guid.Empty) {
                        sql += "  and product_category_id = @product_category_id";
                        command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;
                    }
                    if (productCategoryBecameId != Guid.Empty) {
                        sql += "  and product_category_became_id = @product_category_became_id";
                        command.Parameters.Add("@product_category_became_id", SqlDbType.UniqueIdentifier).Value = productCategoryBecameId;
                    }
                    if (productCategoryParentId != Guid.Empty) {
                        sql += "  and product_category_parent_id = @product_category_parent_id";
                        command.Parameters.Add("@product_category_parent_id", SqlDbType.UniqueIdentifier).Value = productCategoryParentId;
                    }
                    if (!string.IsNullOrEmpty(productCategoryCode)) {
                        sql += "  and product_category_code like '%' + @product_category_code + '%'";
                        command.Parameters.Add("@product_category_code", SqlDbType.NVarChar).Value = productCategoryCode.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productCategoryName)) {
                        sql += "  and product_category_name like '%' + @product_category_name + '%'";
                        command.Parameters.Add("@product_category_name", SqlDbType.NVarChar).Value = productCategoryName.Replace("'","''");
                    }
                    if (productCategoryPosition != 0) {
                        sql += "  and product_category_position = @product_category_position";
                        command.Parameters.Add("@product_category_position", SqlDbType.Int).Value = productCategoryPosition;
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
                    sql += " order by product_category_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_category_id"] != System.DBNull.Value) ProductCategoryId = (System.Guid) reader["product_category_id"];
            if (reader["product_category_became_id"] != System.DBNull.Value) ProductCategoryBecameId = (System.Guid) reader["product_category_became_id"];
            if (reader["product_category_parent_id"] != System.DBNull.Value) ProductCategoryParentId = (System.Guid) reader["product_category_parent_id"];
            if (reader["product_category_code"] != System.DBNull.Value) ProductCategoryCode = (System.String) reader["product_category_code"];
            if (reader["product_category_name"] != System.DBNull.Value) ProductCategoryName = (System.String) reader["product_category_name"];
            if (reader["product_category_position"] != System.DBNull.Value) ProductCategoryPosition = (System.Int32) reader["product_category_position"];
            if (reader["state_rcd"] != System.DBNull.Value) StateRcd = (System.String) reader["state_rcd"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductCategoryId == Guid.Empty)
                ProductCategoryId = Guid.NewGuid();

            string sql = "insert into [product_category] (product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time)";
            sql += "            values (@product_category_id, @product_category_became_id, @product_category_parent_id, @product_category_code, @product_category_name, @product_category_position, @state_rcd, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryId;
                    command.Parameters.Add("@product_category_became_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryBecameId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryBecameId);
                    command.Parameters.Add("@product_category_parent_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryParentId;
                    command.Parameters.Add("@product_category_code",SqlDbType.NVarChar).Value = (System.String)ProductCategoryCode;
                    command.Parameters.Add("@product_category_name",SqlDbType.NVarChar).Value = (System.String)ProductCategoryName;
                    command.Parameters.Add("@product_category_position",SqlDbType.Int).Value = (System.Int32)ProductCategoryPosition;
                    command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductCategoryId == Guid.Empty)
                ProductCategoryId = Guid.NewGuid();

            string sql = "insert into [product_category] (product_category_id, product_category_became_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time)";
            sql += "            values (@product_category_id, @product_category_became_id, @product_category_parent_id, @product_category_code, @product_category_name, @product_category_position, @state_rcd, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryId;
                command.Parameters.Add("@product_category_became_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryBecameId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryBecameId);
                command.Parameters.Add("@product_category_parent_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryParentId;
                command.Parameters.Add("@product_category_code",SqlDbType.NVarChar).Value = (System.String)ProductCategoryCode;
                command.Parameters.Add("@product_category_name",SqlDbType.NVarChar).Value = (System.String)ProductCategoryName;
                command.Parameters.Add("@product_category_position",SqlDbType.Int).Value = (System.Int32)ProductCategoryPosition;
                command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_category] set
                 product_category_id = @product_category_id
                ,product_category_became_id = @product_category_became_id
                ,product_category_parent_id = @product_category_parent_id
                ,product_category_code = @product_category_code
                ,product_category_name = @product_category_name
                ,product_category_position = @product_category_position
                ,state_rcd = @state_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where product_category_id = @product_category_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryId;
                    command.Parameters.Add("@product_category_became_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryBecameId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryBecameId);
                    command.Parameters.Add("@product_category_parent_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryParentId;
                    command.Parameters.Add("@product_category_code",SqlDbType.NVarChar).Value = (System.String)ProductCategoryCode;
                    command.Parameters.Add("@product_category_name",SqlDbType.NVarChar).Value = (System.String)ProductCategoryName;
                    command.Parameters.Add("@product_category_position",SqlDbType.Int).Value = (System.Int32)ProductCategoryPosition;
                    command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_category] set
                 product_category_id = @product_category_id
                ,product_category_became_id = @product_category_became_id
                ,product_category_parent_id = @product_category_parent_id
                ,product_category_code = @product_category_code
                ,product_category_name = @product_category_name
                ,product_category_position = @product_category_position
                ,state_rcd = @state_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where product_category_id = @product_category_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryId;
                command.Parameters.Add("@product_category_became_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryBecameId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryBecameId);
                command.Parameters.Add("@product_category_parent_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryParentId;
                command.Parameters.Add("@product_category_code",SqlDbType.NVarChar).Value = (System.String)ProductCategoryCode;
                command.Parameters.Add("@product_category_name",SqlDbType.NVarChar).Value = (System.String)ProductCategoryName;
                command.Parameters.Add("@product_category_position",SqlDbType.Int).Value = (System.Int32)ProductCategoryPosition;
                command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (System.String)StateRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid productCategoryId) {
            string sql = @" delete [product_category] 
                where product_category_id = @product_category_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = productCategoryId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
