/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:22:59 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeProductCategoryImageData {
        
        public System.Guid ProductCategoryImageId { get; set; } //;
        
        public System.Guid ProductCategoryId { get; set; } //;
        
        public string ProductCategoryImageTypeRcd { get; set; } //;
        
        public byte[] Image { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductCategoryImageId(System.Guid productCategoryImageId) {
            string sql = @" select top 1 product_category_image_id, product_category_id, product_category_image_type_rcd, image, user_id, date_time
                            from [product_category_image]
                            where product_category_image_id = @product_category_image_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_category_image_id",SqlDbType.UniqueIdentifier).Value = productCategoryImageId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductCategoryImageData GetByProductCategoryImageId(System.Guid productCategoryImageId) {
            string sql = @" select top 1 product_category_image_id, product_category_id, product_category_image_type_rcd, image, user_id, date_time
                            from [product_category_image]
                            where product_category_image_id = @product_category_image_id";

            var ret = new CrudeProductCategoryImageData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_image_id",SqlDbType.UniqueIdentifier).Value = productCategoryImageId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductCategoryImageData> FetchByProductCategoryId(System.Guid productCategoryId) {
            var dataList = new List<CrudeProductCategoryImageData>();

            string sql = @" select product_category_image_id, product_category_id, product_category_image_type_rcd, image, user_id, date_time
                            from [product_category_image]
                            where product_category_id = @product_category_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryImageData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductCategoryImageData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductCategoryImageData>();

            string sql = @" select product_category_image_id, product_category_id, product_category_image_type_rcd, image, user_id, date_time
                            from [product_category_image]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryImageData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductCategoryImageData> FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd) {
            var dataList = new List<CrudeProductCategoryImageData>();

            string sql = @" select product_category_image_id, product_category_id, product_category_image_type_rcd, image, user_id, date_time
                            from [product_category_image]
                            where product_category_image_type_rcd = @product_category_image_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_image_type_rcd", SqlDbType.NVarChar).Value = productCategoryImageTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryImageData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductCategoryImageData> FetchAll() {
            var dataList = new List<CrudeProductCategoryImageData>();

            string sql = @" select product_category_image_id, product_category_id, product_category_image_type_rcd, image, user_id, date_time
                            from [product_category_image]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryImageData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductCategoryImageData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductCategoryImageData>();

            string sql = @" select top " + limit.ToString() + @" product_category_image_id, product_category_id, product_category_image_type_rcd, image, user_id, date_time
                            from [product_category_image]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryImageData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductCategoryImageData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductCategoryImageData>();

            string sql = @" select product_category_image_id, product_category_id, product_category_image_type_rcd, image, user_id, date_time
                            from [product_category_image]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductCategoryImageData();
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
            string sql = @" select count(*) as count from [product_category_image]";

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
        
        public static List<CrudeProductCategoryImageData> FetchWithFilter(System.Guid productCategoryImageId, System.Guid productCategoryId, string productCategoryImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductCategoryImageData>();

            string sql = @" select product_category_image_id, product_category_id, product_category_image_type_rcd, image, user_id, date_time
                            from [product_category_image]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productCategoryImageId != Guid.Empty) {
                        sql += "  and product_category_image_id = @product_category_image_id";
                        command.Parameters.Add("@product_category_image_id", SqlDbType.UniqueIdentifier).Value = productCategoryImageId;
                    }
                    if (productCategoryId != Guid.Empty) {
                        sql += "  and product_category_id = @product_category_id";
                        command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;
                    }
                    if (!string.IsNullOrEmpty(productCategoryImageTypeRcd)) {
                        sql += "  and product_category_image_type_rcd like '%' + @product_category_image_type_rcd + '%'";
                        command.Parameters.Add("@product_category_image_type_rcd", SqlDbType.NVarChar).Value = productCategoryImageTypeRcd.Replace("'","''");
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
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductCategoryImageData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_category_image_id"] != System.DBNull.Value) ProductCategoryImageId = (System.Guid) reader["product_category_image_id"];
            if (reader["product_category_id"] != System.DBNull.Value) ProductCategoryId = (System.Guid) reader["product_category_id"];
            if (reader["product_category_image_type_rcd"] != System.DBNull.Value) ProductCategoryImageTypeRcd = (System.String) reader["product_category_image_type_rcd"];
            if (reader["image"] != System.DBNull.Value) Image = (System.Byte[]) reader["image"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductCategoryImageId == Guid.Empty)
                ProductCategoryImageId = Guid.NewGuid();

            string sql = "insert into [product_category_image] (product_category_image_id, product_category_id, product_category_image_type_rcd, image, user_id, date_time)";
            sql += "            values (@product_category_image_id, @product_category_id, @product_category_image_type_rcd, @image, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_category_image_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryImageId;
                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryId;
                    command.Parameters.Add("@product_category_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductCategoryImageTypeRcd;
                    command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (System.Byte[])Image;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductCategoryImageId == Guid.Empty)
                ProductCategoryImageId = Guid.NewGuid();

            string sql = "insert into [product_category_image] (product_category_image_id, product_category_id, product_category_image_type_rcd, image, user_id, date_time)";
            sql += "            values (@product_category_image_id, @product_category_id, @product_category_image_type_rcd, @image, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_category_image_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryImageId;
                command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryId;
                command.Parameters.Add("@product_category_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductCategoryImageTypeRcd;
                command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (System.Byte[])Image;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_category_image] set
                 product_category_image_id = @product_category_image_id
                ,product_category_id = @product_category_id
                ,product_category_image_type_rcd = @product_category_image_type_rcd
                ,image = @image
                ,user_id = @user_id
                ,date_time = @date_time
            where product_category_image_id = @product_category_image_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_category_image_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryImageId;
                    command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryId;
                    command.Parameters.Add("@product_category_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductCategoryImageTypeRcd;
                    command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (System.Byte[])Image;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_category_image] set
                 product_category_image_id = @product_category_image_id
                ,product_category_id = @product_category_id
                ,product_category_image_type_rcd = @product_category_image_type_rcd
                ,image = @image
                ,user_id = @user_id
                ,date_time = @date_time
            where product_category_image_id = @product_category_image_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_category_image_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryImageId;
                command.Parameters.Add("@product_category_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductCategoryId;
                command.Parameters.Add("@product_category_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductCategoryImageTypeRcd;
                command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (System.Byte[])Image;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid productCategoryImageId) {
            string sql = @" delete [product_category_image] 
                where product_category_image_id = @product_category_image_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_image_id",SqlDbType.UniqueIdentifier).Value = productCategoryImageId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
