using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductCategoryDocumentationData {
        
        public System.Guid ProductCategoryDocumentationId { get; set; } //;
        
        public string ProductCategoryDocumentationTypeRcd { get; set; } //;
        
        public System.Guid ProductCategoryId { get; set; } //;
        
        public string Documentation { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductCategoryDocumentationId(System.Guid productCategoryDocumentationId) {
            string sql = @" select top 1 product_category_documentation_id, product_category_documentation_type_rcd, product_category_id, documentation, user_id, date_time
                            from [product_category_documentation]
                            where product_category_documentation_id = @product_category_documentation_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_documentation_id",SqlDbType.UniqueIdentifier).Value = productCategoryDocumentationId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductCategoryDocumentationData> FetchByProductCategoryId(System.Guid productCategoryId) {
            var dataList = new List<CrudeProductCategoryDocumentationData>();

            string sql = @" select product_category_documentation_id, product_category_documentation_type_rcd, product_category_id, documentation, user_id, date_time
                            from [product_category_documentation]
                            where product_category_id = @product_category_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryDocumentationData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductCategoryDocumentationData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductCategoryDocumentationData>();

            string sql = @" select product_category_documentation_id, product_category_documentation_type_rcd, product_category_id, documentation, user_id, date_time
                            from [product_category_documentation]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryDocumentationData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductCategoryDocumentationData> FetchAll() {
            var dataList = new List<CrudeProductCategoryDocumentationData>();

            string sql = @" select product_category_documentation_id, product_category_documentation_type_rcd, product_category_id, documentation, user_id, date_time
                            from [product_category_documentation]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryDocumentationData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductCategoryDocumentationData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductCategoryDocumentationData>();

            string sql = @" select top " + limit.ToString() + @" product_category_documentation_id, product_category_documentation_type_rcd, product_category_id, documentation, user_id, date_time
                            from [product_category_documentation]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryDocumentationData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductCategoryDocumentationData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductCategoryDocumentationData>();

            string sql = @" select product_category_documentation_id, product_category_documentation_type_rcd, product_category_id, documentation, user_id, date_time
                            from [product_category_documentation]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductCategoryDocumentationData();
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
            string sql = @" select count(*) as count from [product_category_documentation]";

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
        
        public List<CrudeProductCategoryDocumentationData> FetchWithFilter(System.Guid productCategoryDocumentationId, string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductCategoryDocumentationData>();

            string sql = @" select product_category_documentation_id, product_category_documentation_type_rcd, product_category_id, documentation, user_id, date_time
                            from [product_category_documentation]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productCategoryDocumentationId != Guid.Empty) {
                        sql += "  and product_category_documentation_id = @product_category_documentation_id";
                        command.Parameters.Add("@product_category_documentation_id", SqlDbType.UniqueIdentifier).Value = productCategoryDocumentationId;
                    }
                    if (productCategoryDocumentationTypeRcd != "") {
                        sql += "  and product_category_documentation_type_rcd like '%' + @product_category_documentation_type_rcd + '%'";
                        command.Parameters.Add("@product_category_documentation_type_rcd", SqlDbType.NVarChar).Value = productCategoryDocumentationTypeRcd.Replace("'","''");
                    }
                    if (productCategoryId != Guid.Empty) {
                        sql += "  and product_category_id = @product_category_id";
                        command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;
                    }
                    if (documentation != "") {
                        sql += "  and documentation like '%' + @documentation + '%'";
                        command.Parameters.Add("@documentation", SqlDbType.NVarChar).Value = documentation.Replace("'","''");
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
                        var data = new CrudeProductCategoryDocumentationData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_category_documentation_id"] != System.DBNull.Value) ProductCategoryDocumentationId = (System.Guid) reader["product_category_documentation_id"];
            if (reader["product_category_documentation_type_rcd"] != System.DBNull.Value) ProductCategoryDocumentationTypeRcd = (System.String) reader["product_category_documentation_type_rcd"];
            if (reader["product_category_id"] != System.DBNull.Value) ProductCategoryId = (System.Guid) reader["product_category_id"];
            if (reader["documentation"] != System.DBNull.Value) Documentation = (System.String) reader["documentation"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductCategoryDocumentationId == Guid.Empty)
                ProductCategoryDocumentationId = Guid.NewGuid();

            string sql = "insert into [product_category_documentation] (product_category_documentation_id, product_category_documentation_type_rcd, product_category_id, documentation, user_id, date_time)";
            sql += "            values (@product_category_documentation_id, @product_category_documentation_type_rcd, @product_category_id, @documentation, @user_id, @date_time)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_category_documentation_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryDocumentationId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryDocumentationId);
                    command.Parameters.Add("@product_category_documentation_type_rcd",SqlDbType.NVarChar).Value = (ProductCategoryDocumentationTypeRcd == null ? (object)DBNull.Value : (System.String)ProductCategoryDocumentationTypeRcd);
                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryId);
                    command.Parameters.Add("@documentation",SqlDbType.NVarChar).Value = (Documentation == null ? (object)DBNull.Value : (System.String)Documentation);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductCategoryDocumentationId == Guid.Empty)
                ProductCategoryDocumentationId = Guid.NewGuid();

            string sql = "insert into [product_category_documentation] (product_category_documentation_id, product_category_documentation_type_rcd, product_category_id, documentation, user_id, date_time)";
            sql += "            values (@product_category_documentation_id, @product_category_documentation_type_rcd, @product_category_id, @documentation, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_category_documentation_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryDocumentationId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryDocumentationId);
                command.Parameters.Add("@product_category_documentation_type_rcd",SqlDbType.NVarChar).Value = (ProductCategoryDocumentationTypeRcd == null ? (object)DBNull.Value : (System.String)ProductCategoryDocumentationTypeRcd);
                command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryId);
                command.Parameters.Add("@documentation",SqlDbType.NVarChar).Value = (Documentation == null ? (object)DBNull.Value : (System.String)Documentation);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_category_documentation] set
                 product_category_documentation_id = @product_category_documentation_id
                ,product_category_documentation_type_rcd = @product_category_documentation_type_rcd
                ,product_category_id = @product_category_id
                ,documentation = @documentation
                ,user_id = @user_id
                ,date_time = @date_time
            where product_category_documentation_id = @product_category_documentation_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_category_documentation_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryDocumentationId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryDocumentationId);
                    command.Parameters.Add("@product_category_documentation_type_rcd",SqlDbType.NVarChar).Value = (ProductCategoryDocumentationTypeRcd == null ? (object)DBNull.Value : (System.String)ProductCategoryDocumentationTypeRcd);
                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryId);
                    command.Parameters.Add("@documentation",SqlDbType.NVarChar).Value = (Documentation == null ? (object)DBNull.Value : (System.String)Documentation);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_category_documentation] set
                 product_category_documentation_id = @product_category_documentation_id
                ,product_category_documentation_type_rcd = @product_category_documentation_type_rcd
                ,product_category_id = @product_category_id
                ,documentation = @documentation
                ,user_id = @user_id
                ,date_time = @date_time
            where product_category_documentation_id = @product_category_documentation_id";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_category_documentation_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryDocumentationId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryDocumentationId);
                command.Parameters.Add("@product_category_documentation_type_rcd",SqlDbType.NVarChar).Value = (ProductCategoryDocumentationTypeRcd == null ? (object)DBNull.Value : (System.String)ProductCategoryDocumentationTypeRcd);
                command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (ProductCategoryId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductCategoryId);
                command.Parameters.Add("@documentation",SqlDbType.NVarChar).Value = (Documentation == null ? (object)DBNull.Value : (System.String)Documentation);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_category_documentation] 
                where product_category_documentation_id = @product_category_documentation_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_documentation_id",SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
