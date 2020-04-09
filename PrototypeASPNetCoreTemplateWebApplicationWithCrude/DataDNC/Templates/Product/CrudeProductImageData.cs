/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:26:55 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeProductImageData {
        
        public System.Guid ProductImageId { get; set; } //;
        
        public System.Guid ProductId { get; set; } //;
        
        public string ProductImageTypeRcd { get; set; } //;
        
        public string ImageFileName { get; set; } //;
        
        public byte[] Image { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductImageId(System.Guid productImageId) {
            string sql = @" select top 1 product_image_id, product_id, product_image_type_rcd, image_file_name, image, user_id, date_time
                            from [product_image]
                            where product_image_id = @product_image_id
                            order by image_file_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_image_id",SqlDbType.UniqueIdentifier).Value = productImageId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductImageData GetByProductImageId(System.Guid productImageId) {
            string sql = @" select top 1 product_image_id, product_id, product_image_type_rcd, image_file_name, image, user_id, date_time
                            from [product_image]
                            where product_image_id = @product_image_id
                            order by image_file_name";

            var ret = new CrudeProductImageData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_image_id",SqlDbType.UniqueIdentifier).Value = productImageId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductImageData> FetchByProductId(System.Guid productId) {
            var dataList = new List<CrudeProductImageData>();

            string sql = @" select product_image_id, product_id, product_image_type_rcd, image_file_name, image, user_id, date_time
                            from [product_image]
                            where product_id = @product_id
                              
                            order by image_file_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
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
        
        public static List<CrudeProductImageData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductImageData>();

            string sql = @" select product_image_id, product_id, product_image_type_rcd, image_file_name, image, user_id, date_time
                            from [product_image]
                            where user_id = @user_id
                              
                            order by image_file_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
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
        
        public static List<CrudeProductImageData> FetchByProductImageTypeRcd(string productImageTypeRcd) {
            var dataList = new List<CrudeProductImageData>();

            string sql = @" select product_image_id, product_id, product_image_type_rcd, image_file_name, image, user_id, date_time
                            from [product_image]
                            where product_image_type_rcd = @product_image_type_rcd
                              
                            order by image_file_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_image_type_rcd", SqlDbType.NVarChar).Value = productImageTypeRcd.Replace("'","''");

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
        
        public void FetchByImageFileName(string imageFileName) {
            string sql = @" select top 1 product_image_id, product_id, product_image_type_rcd, image_file_name, image, user_id, date_time
                            from [product_image]
                            where image_file_name like '%' + @imageFileName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@imageFileName",SqlDbType.NVarChar).Value = imageFileName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeProductImageData> FetchAll() {
            var dataList = new List<CrudeProductImageData>();

            string sql = @" select product_image_id, product_id, product_image_type_rcd, image_file_name, image, user_id, date_time
                            from [product_image]
                            order by image_file_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
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
        
        public static List<CrudeProductImageData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductImageData>();

            string sql = @" select top " + limit.ToString() + @" product_image_id, product_id, product_image_type_rcd, image_file_name, image, user_id, date_time
                            from [product_image]
                            order by image_file_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
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
        
        public static List<CrudeProductImageData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductImageData>();

            string sql = @" select product_image_id, product_id, product_image_type_rcd, image_file_name, image, user_id, date_time
                            from [product_image]
                            order by image_file_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
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
        
        public static int FetchAllCount() {
            string sql = @" select count(*) as count from [product_image]";

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
        
        public static List<CrudeProductImageData> FetchWithFilter(System.Guid productImageId, System.Guid productId, string productImageTypeRcd, string imageFileName, byte[] image, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductImageData>();

            string sql = @" select product_image_id, product_id, product_image_type_rcd, image_file_name, image, user_id, date_time
                            from [product_image]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
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
                    if (!string.IsNullOrEmpty(productImageTypeRcd)) {
                        sql += "  and product_image_type_rcd like '%' + @product_image_type_rcd + '%'";
                        command.Parameters.Add("@product_image_type_rcd", SqlDbType.NVarChar).Value = productImageTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(imageFileName)) {
                        sql += "  and image_file_name like '%' + @image_file_name + '%'";
                        command.Parameters.Add("@image_file_name", SqlDbType.NVarChar).Value = imageFileName.Replace("'","''");
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
                    sql += " order by image_file_name";

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
            if (reader["image_file_name"] != System.DBNull.Value) ImageFileName = (System.String) reader["image_file_name"];
            if (reader["image"] != System.DBNull.Value) Image = (System.Byte[]) reader["image"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductImageId == Guid.Empty)
                ProductImageId = Guid.NewGuid();

            string sql = "insert into [product_image] (product_image_id, product_id, product_image_type_rcd, image_file_name, image, user_id, date_time)";
            sql += "            values (@product_image_id, @product_id, @product_image_type_rcd, @image_file_name, @image, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_image_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductImageId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductImageTypeRcd;
                    command.Parameters.Add("@image_file_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ImageFileName)) ? (object)DBNull.Value : (System.String)ImageFileName;
                    command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (Image == null ? (object)DBNull.Value : (System.Byte[])Image);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductImageId == Guid.Empty)
                ProductImageId = Guid.NewGuid();

            string sql = "insert into [product_image] (product_image_id, product_id, product_image_type_rcd, image_file_name, image, user_id, date_time)";
            sql += "            values (@product_image_id, @product_id, @product_image_type_rcd, @image_file_name, @image, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_image_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductImageId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductImageTypeRcd;
                command.Parameters.Add("@image_file_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ImageFileName)) ? (object)DBNull.Value : (System.String)ImageFileName;
                command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (Image == null ? (object)DBNull.Value : (System.Byte[])Image);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_image] set
                 product_image_id = @product_image_id
                ,product_id = @product_id
                ,product_image_type_rcd = @product_image_type_rcd
                ,image_file_name = @image_file_name
                ,image = @image
                ,user_id = @user_id
                ,date_time = @date_time
            where product_image_id = @product_image_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_image_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductImageId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductImageTypeRcd;
                    command.Parameters.Add("@image_file_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ImageFileName)) ? (object)DBNull.Value : (System.String)ImageFileName;
                    command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (Image == null ? (object)DBNull.Value : (System.Byte[])Image);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_image] set
                 product_image_id = @product_image_id
                ,product_id = @product_id
                ,product_image_type_rcd = @product_image_type_rcd
                ,image_file_name = @image_file_name
                ,image = @image
                ,user_id = @user_id
                ,date_time = @date_time
            where product_image_id = @product_image_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_image_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductImageId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductImageTypeRcd;
                command.Parameters.Add("@image_file_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ImageFileName)) ? (object)DBNull.Value : (System.String)ImageFileName;
                command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (Image == null ? (object)DBNull.Value : (System.Byte[])Image);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid productImageId) {
            string sql = @" delete [product_image] 
                where product_image_id = @product_image_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_image_id",SqlDbType.UniqueIdentifier).Value = productImageId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
