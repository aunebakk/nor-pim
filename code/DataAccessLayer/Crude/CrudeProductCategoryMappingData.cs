using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductCategoryMappingData {
        
        public System.Guid ProductCategoryMappingId { get; set; } //;
        
        public System.Guid ProductCategoryId { get; set; } //;
        
        public System.Guid ProductId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductCategoryMappingId(System.Guid productCategoryMappingId) {
            string sql = @" select top 1 product_category_mapping_id, product_category_id, product_id, user_id, date_time
                            from [product_category_mapping]
                            where product_category_mapping_id = @product_category_mapping_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_mapping_id",SqlDbType.UniqueIdentifier).Value = productCategoryMappingId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductCategoryMappingData> FetchByProductCategoryId(System.Guid productCategoryId) {
            var dataList = new List<CrudeProductCategoryMappingData>();

            string sql = @" select product_category_mapping_id, product_category_id, product_id, user_id, date_time
                            from [product_category_mapping]
                            where product_category_id = @product_category_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductCategoryMappingData> FetchByProductId(System.Guid productId) {
            var dataList = new List<CrudeProductCategoryMappingData>();

            string sql = @" select product_category_mapping_id, product_category_id, product_id, user_id, date_time
                            from [product_category_mapping]
                            where product_id = @product_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductCategoryMappingData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductCategoryMappingData>();

            string sql = @" select product_category_mapping_id, product_category_id, product_id, user_id, date_time
                            from [product_category_mapping]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductCategoryMappingData> FetchAll() {
            var dataList = new List<CrudeProductCategoryMappingData>();

            string sql = @" select product_category_mapping_id, product_category_id, product_id, user_id, date_time
                            from [product_category_mapping]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductCategoryMappingData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductCategoryMappingData>();

            string sql = @" select top " + limit.ToString() + @" product_category_mapping_id, product_category_id, product_id, user_id, date_time
                            from [product_category_mapping]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductCategoryMappingData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductCategoryMappingData>();

            string sql = @" select product_category_mapping_id, product_category_id, product_id, user_id, date_time
                            from [product_category_mapping]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductCategoryMappingData();
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
        
        public int FetchAllCount() {
            string sql = @" select count(*) as count from [product_category_mapping]";

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
        
        public List<CrudeProductCategoryMappingData> FetchWithFilter(System.Guid productCategoryMappingId, System.Guid productCategoryId, System.Guid productId, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductCategoryMappingData>();

            string sql = @" select product_category_mapping_id, product_category_id, product_id, user_id, date_time
                            from [product_category_mapping]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productCategoryMappingId != Guid.Empty) {
                        sql += "  and product_category_mapping_id = @product_category_mapping_id";
                        command.Parameters.Add("@product_category_mapping_id", SqlDbType.UniqueIdentifier).Value = productCategoryMappingId;
                    }
                    if (productCategoryId != Guid.Empty) {
                        sql += "  and product_category_id = @product_category_id";
                        command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;
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
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_category_mapping_id"] != System.DBNull.Value) ProductCategoryMappingId = (System.Guid) reader["product_category_mapping_id"];
            if (reader["product_category_id"] != System.DBNull.Value) ProductCategoryId = (System.Guid) reader["product_category_id"];
            if (reader["product_id"] != System.DBNull.Value) ProductId = (System.Guid) reader["product_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductCategoryMappingId == Guid.Empty)
                ProductCategoryMappingId = Guid.NewGuid();

            string sql = "insert into [product_category_mapping] (product_category_mapping_id, product_category_id, product_id, user_id, date_time)";
            sql += "            values (@product_category_mapping_id, @product_category_id, @product_id, @user_id, @date_time)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_category_mapping_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryMappingId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryMappingId);
                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryId);
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductCategoryMappingId == Guid.Empty)
                ProductCategoryMappingId = Guid.NewGuid();

            string sql = "insert into [product_category_mapping] (product_category_mapping_id, product_category_id, product_id, user_id, date_time)";
            sql += "            values (@product_category_mapping_id, @product_category_id, @product_id, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_category_mapping_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryMappingId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryMappingId);
                command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryId);
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_category_mapping] set
                 product_category_mapping_id = @product_category_mapping_id
                ,product_category_id = @product_category_id
                ,product_id = @product_id
                ,user_id = @user_id
                ,date_time = @date_time
            where product_category_mapping_id = @product_category_mapping_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_category_mapping_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryMappingId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryMappingId);
                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryId);
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_category_mapping] set
                 product_category_mapping_id = @product_category_mapping_id
                ,product_category_id = @product_category_id
                ,product_id = @product_id
                ,user_id = @user_id
                ,date_time = @date_time
            where product_category_mapping_id = @product_category_mapping_id";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_category_mapping_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryMappingId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryMappingId);
                command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryId);
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_category_mapping] 
                where product_category_mapping_id = @product_category_mapping_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_mapping_id",SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
