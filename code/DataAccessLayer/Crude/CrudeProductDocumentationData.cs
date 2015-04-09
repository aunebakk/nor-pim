using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductDocumentationData {
        
        public System.Guid ProductDocumentationId { get; set; } //;
        
        public System.Guid ProductId { get; set; } //;
        
        public string ProductDocumentationTypeRcd { get; set; } //;
        
        public string Documentation { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductDocumentationId(System.Guid productDocumentationId) {
            string sql = @" select top 1 product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time
                            from [product_documentation]
                            where product_documentation_id = @product_documentation_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_documentation_id",SqlDbType.UniqueIdentifier).Value = productDocumentationId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductDocumentationData> FetchByProductId(System.Guid productId) {
            var dataList = new List<CrudeProductDocumentationData>();

            string sql = @" select product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time
                            from [product_documentation]
                            where product_id = @product_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductDocumentationData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductDocumentationData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductDocumentationData>();

            string sql = @" select product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time
                            from [product_documentation]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductDocumentationData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductDocumentationData> FetchAll() {
            var dataList = new List<CrudeProductDocumentationData>();

            string sql = @" select product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time
                            from [product_documentation]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductDocumentationData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductDocumentationData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductDocumentationData>();

            string sql = @" select top " + limit.ToString() + @" product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time
                            from [product_documentation]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductDocumentationData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductDocumentationData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductDocumentationData>();

            string sql = @" select product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time
                            from [product_documentation]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductDocumentationData();
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
            string sql = @" select count(*) as count from [product_documentation]";

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
        
        public List<CrudeProductDocumentationData> FetchWithFilter(System.Guid productDocumentationId, System.Guid productId, string productDocumentationTypeRcd, string documentation, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductDocumentationData>();

            string sql = @" select product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time
                            from [product_documentation]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productDocumentationId != Guid.Empty) {
                        sql += "  and product_documentation_id = @product_documentation_id";
                        command.Parameters.Add("@product_documentation_id", SqlDbType.UniqueIdentifier).Value = productDocumentationId;
                    }
                    if (productId != Guid.Empty) {
                        sql += "  and product_id = @product_id";
                        command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;
                    }
                    if (productDocumentationTypeRcd != "") {
                        sql += "  and product_documentation_type_rcd like '%' + @product_documentation_type_rcd + '%'";
                        command.Parameters.Add("@product_documentation_type_rcd", SqlDbType.NVarChar).Value = productDocumentationTypeRcd.Replace("'","''");
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
                        var data = new CrudeProductDocumentationData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_documentation_id"] != System.DBNull.Value) ProductDocumentationId = (System.Guid) reader["product_documentation_id"];
            if (reader["product_id"] != System.DBNull.Value) ProductId = (System.Guid) reader["product_id"];
            if (reader["product_documentation_type_rcd"] != System.DBNull.Value) ProductDocumentationTypeRcd = (System.String) reader["product_documentation_type_rcd"];
            if (reader["documentation"] != System.DBNull.Value) Documentation = (System.String) reader["documentation"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductDocumentationId == Guid.Empty)
                ProductDocumentationId = Guid.NewGuid();

            string sql = "insert into [product_documentation] (product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time)";
            sql += "            values (@product_documentation_id, @product_id, @product_documentation_type_rcd, @documentation, @user_id, @date_time)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_documentation_id",SqlDbType.UniqueIdentifier).Value = (ProductDocumentationId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductDocumentationId);
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                    command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (ProductDocumentationTypeRcd == null ? (object)DBNull.Value : (System.String)ProductDocumentationTypeRcd);
                    command.Parameters.Add("@documentation",SqlDbType.NVarChar).Value = (Documentation == null ? (object)DBNull.Value : (System.String)Documentation);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductDocumentationId == Guid.Empty)
                ProductDocumentationId = Guid.NewGuid();

            string sql = "insert into [product_documentation] (product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time)";
            sql += "            values (@product_documentation_id, @product_id, @product_documentation_type_rcd, @documentation, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_documentation_id",SqlDbType.UniqueIdentifier).Value = (ProductDocumentationId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductDocumentationId);
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (ProductDocumentationTypeRcd == null ? (object)DBNull.Value : (System.String)ProductDocumentationTypeRcd);
                command.Parameters.Add("@documentation",SqlDbType.NVarChar).Value = (Documentation == null ? (object)DBNull.Value : (System.String)Documentation);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_documentation] set
                 product_documentation_id = @product_documentation_id
                ,product_id = @product_id
                ,product_documentation_type_rcd = @product_documentation_type_rcd
                ,documentation = @documentation
                ,user_id = @user_id
                ,date_time = @date_time
            where product_documentation_id = @product_documentation_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_documentation_id",SqlDbType.UniqueIdentifier).Value = (ProductDocumentationId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductDocumentationId);
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                    command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (ProductDocumentationTypeRcd == null ? (object)DBNull.Value : (System.String)ProductDocumentationTypeRcd);
                    command.Parameters.Add("@documentation",SqlDbType.NVarChar).Value = (Documentation == null ? (object)DBNull.Value : (System.String)Documentation);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_documentation] set
                 product_documentation_id = @product_documentation_id
                ,product_id = @product_id
                ,product_documentation_type_rcd = @product_documentation_type_rcd
                ,documentation = @documentation
                ,user_id = @user_id
                ,date_time = @date_time
            where product_documentation_id = @product_documentation_id";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_documentation_id",SqlDbType.UniqueIdentifier).Value = (ProductDocumentationId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductDocumentationId);
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (ProductDocumentationTypeRcd == null ? (object)DBNull.Value : (System.String)ProductDocumentationTypeRcd);
                command.Parameters.Add("@documentation",SqlDbType.NVarChar).Value = (Documentation == null ? (object)DBNull.Value : (System.String)Documentation);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_documentation] 
                where product_documentation_id = @product_documentation_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_documentation_id",SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
