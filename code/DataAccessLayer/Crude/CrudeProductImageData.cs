using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductImageData {
        
        public System.Guid ProductImageId { get; set; } //;
        
        public System.Guid ProductId { get; set; } //;
        
        public string ProductImageTypeRcd { get; set; } //;
        
        public byte[] Image { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public string ImageFileName { get; set; } //;
        
        public void FetchByProductImageId(System.Guid productImageId) {
            string sql = @" select top 1 product_image_id, product_id, product_image_type_rcd, image, user_id, date_time, image_file_name
                            from [product_image]
                            where product_image_id = @product_image_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_image_id",SqlDbType.UniqueIdentifier).Value = productImageId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductImageData> FetchByProductId(System.Guid productId) {
            var dataList = new List<CrudeProductImageData>();

            string sql = @" select product_image_id, product_id, product_image_type_rcd, image, user_id, date_time, image_file_name
                            from [product_image]
                            where product_id = @product_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductImageData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductImageData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductImageData>();

            string sql = @" select product_image_id, product_id, product_image_type_rcd, image, user_id, date_time, image_file_name
                            from [product_image]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductImageData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductImageData> FetchAll() {
            var dataList = new List<CrudeProductImageData>();

            string sql = @" select product_image_id, product_id, product_image_type_rcd, image, user_id, date_time, image_file_name
                            from [product_image]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductImageData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductImageData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductImageData>();

            string sql = @" select top " + limit.ToString() + @" product_image_id, product_id, product_image_type_rcd, image, user_id, date_time, image_file_name
                            from [product_image]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductImageData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductImageData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductImageData>();

            string sql = @" select product_image_id, product_id, product_image_type_rcd, image, user_id, date_time, image_file_name
                            from [product_image]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductImageData();
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
            string sql = @" select count(*) as count from [product_image]";

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
        
        public List<CrudeProductImageData> FetchWithFilter(System.Guid productImageId, System.Guid productId, string productImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime, string imageFileName) {
            var dataList = new List<CrudeProductImageData>();

            string sql = @" select product_image_id, product_id, product_image_type_rcd, image, user_id, date_time, image_file_name
                            from [product_image]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productImageId != Guid.Empty) {
                        sql += "  and product_image_id = @product_image_id";
                        command.Parameters.Add("@product_image_id", SqlDbType.UniqueIdentifier).Value = productImageId;
                    }
                    if (productId != Guid.Empty) {
                        sql += "  and product_id = @product_id";
                        command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;
                    }
                    if (productImageTypeRcd != "") {
                        sql += "  and product_image_type_rcd like '%' + @product_image_type_rcd + '%'";
                        command.Parameters.Add("@product_image_type_rcd", SqlDbType.NVarChar).Value = productImageTypeRcd.Replace("'","''");
                    }
                    if (image != null) {
                        sql += "  and image = @image";
                        command.Parameters.Add("@image", SqlDbType.VarBinary).Value = image;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (imageFileName != "") {
                        sql += "  and image_file_name like '%' + @image_file_name + '%'";
                        command.Parameters.Add("@image_file_name", SqlDbType.NVarChar).Value = imageFileName.Replace("'","''");
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductImageData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_image_id"] != System.DBNull.Value) ProductImageId = (System.Guid) reader["product_image_id"];
            if (reader["product_id"] != System.DBNull.Value) ProductId = (System.Guid) reader["product_id"];
            if (reader["product_image_type_rcd"] != System.DBNull.Value) ProductImageTypeRcd = (System.String) reader["product_image_type_rcd"];
            if (reader["image"] != System.DBNull.Value) Image = (System.Byte[]) reader["image"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["image_file_name"] != System.DBNull.Value) ImageFileName = (System.String) reader["image_file_name"];
        }
        
        public void Insert() {

            if (ProductImageId == Guid.Empty)
                ProductImageId = Guid.NewGuid();

            string sql = "insert into [product_image] (product_image_id, product_id, product_image_type_rcd, image, user_id, date_time, image_file_name)";
            sql += "            values (@product_image_id, @product_id, @product_image_type_rcd, @image, @user_id, @date_time, @image_file_name)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_image_id",SqlDbType.UniqueIdentifier).Value = (ProductImageId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductImageId);
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                    command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (ProductImageTypeRcd == null ? (object)DBNull.Value : (System.String)ProductImageTypeRcd);
                    command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (Image == null ? (object)DBNull.Value : (System.Byte[])Image);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.Parameters.Add("@image_file_name",SqlDbType.NVarChar).Value = (ImageFileName == null ? (object)DBNull.Value : (System.String)ImageFileName);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductImageId == Guid.Empty)
                ProductImageId = Guid.NewGuid();

            string sql = "insert into [product_image] (product_image_id, product_id, product_image_type_rcd, image, user_id, date_time, image_file_name)";
            sql += "            values (@product_image_id, @product_id, @product_image_type_rcd, @image, @user_id, @date_time, @image_file_name)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_image_id",SqlDbType.UniqueIdentifier).Value = (ProductImageId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductImageId);
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (ProductImageTypeRcd == null ? (object)DBNull.Value : (System.String)ProductImageTypeRcd);
                command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (Image == null ? (object)DBNull.Value : (System.Byte[])Image);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.Parameters.Add("@image_file_name",SqlDbType.NVarChar).Value = (ImageFileName == null ? (object)DBNull.Value : (System.String)ImageFileName);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_image] set
                 product_image_id = @product_image_id
                ,product_id = @product_id
                ,product_image_type_rcd = @product_image_type_rcd
                ,image = @image
                ,user_id = @user_id
                ,date_time = @date_time
                ,image_file_name = @image_file_name
            where product_image_id = @product_image_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_image_id",SqlDbType.UniqueIdentifier).Value = (ProductImageId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductImageId);
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                    command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (ProductImageTypeRcd == null ? (object)DBNull.Value : (System.String)ProductImageTypeRcd);
                    command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (Image == null ? (object)DBNull.Value : (System.Byte[])Image);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.Parameters.Add("@image_file_name",SqlDbType.NVarChar).Value = (ImageFileName == null ? (object)DBNull.Value : (System.String)ImageFileName);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_image] set
                 product_image_id = @product_image_id
                ,product_id = @product_id
                ,product_image_type_rcd = @product_image_type_rcd
                ,image = @image
                ,user_id = @user_id
                ,date_time = @date_time
                ,image_file_name = @image_file_name
            where product_image_id = @product_image_id";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_image_id",SqlDbType.UniqueIdentifier).Value = (ProductImageId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductImageId);
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (ProductImageTypeRcd == null ? (object)DBNull.Value : (System.String)ProductImageTypeRcd);
                command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (Image == null ? (object)DBNull.Value : (System.Byte[])Image);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.Parameters.Add("@image_file_name",SqlDbType.NVarChar).Value = (ImageFileName == null ? (object)DBNull.Value : (System.String)ImageFileName);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_image] 
                where product_image_id = @product_image_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_image_id",SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
