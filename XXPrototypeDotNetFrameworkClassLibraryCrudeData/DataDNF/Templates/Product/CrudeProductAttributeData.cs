/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:43:00 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductAttributeData {
        
        public System.Guid ProductAttributeId { get; set; } //;
        
        public System.Guid ProductId { get; set; } //;
        
        public string ProductAttributeRcd { get; set; } //;
        
        public string ProductAttributeUnitRcd { get; set; } //;
        
        public string Value { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductAttributeId(System.Guid productAttributeId) {
            string sql = @" select top 1 product_attribute_id, product_id, product_attribute_rcd, product_attribute_unit_rcd, value, user_id, date_time
                            from [product_attribute]
                            where product_attribute_id = @product_attribute_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_attribute_id",SqlDbType.UniqueIdentifier).Value = productAttributeId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductAttributeData GetByProductAttributeId(System.Guid productAttributeId) {
            string sql = @" select top 1 product_attribute_id, product_id, product_attribute_rcd, product_attribute_unit_rcd, value, user_id, date_time
                            from [product_attribute]
                            where product_attribute_id = @product_attribute_id";

            var ret = new CrudeProductAttributeData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_attribute_id",SqlDbType.UniqueIdentifier).Value = productAttributeId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductAttributeData> FetchByProductId(System.Guid productId) {
            var dataList = new List<CrudeProductAttributeData>();

            string sql = @" select product_attribute_id, product_id, product_attribute_rcd, product_attribute_unit_rcd, value, user_id, date_time
                            from [product_attribute]
                            where product_id = @product_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductAttributeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductAttributeData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductAttributeData>();

            string sql = @" select product_attribute_id, product_id, product_attribute_rcd, product_attribute_unit_rcd, value, user_id, date_time
                            from [product_attribute]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductAttributeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductAttributeData> FetchByProductAttributeRcd(string productAttributeRcd) {
            var dataList = new List<CrudeProductAttributeData>();

            string sql = @" select product_attribute_id, product_id, product_attribute_rcd, product_attribute_unit_rcd, value, user_id, date_time
                            from [product_attribute]
                            where product_attribute_rcd = @product_attribute_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_attribute_rcd", SqlDbType.NVarChar).Value = productAttributeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductAttributeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductAttributeData> FetchByProductAttributeUnitRcd(string productAttributeUnitRcd) {
            var dataList = new List<CrudeProductAttributeData>();

            string sql = @" select product_attribute_id, product_id, product_attribute_rcd, product_attribute_unit_rcd, value, user_id, date_time
                            from [product_attribute]
                            where product_attribute_unit_rcd = @product_attribute_unit_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_attribute_unit_rcd", SqlDbType.NVarChar).Value = productAttributeUnitRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductAttributeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductAttributeData> FetchAll() {
            var dataList = new List<CrudeProductAttributeData>();

            string sql = @" select product_attribute_id, product_id, product_attribute_rcd, product_attribute_unit_rcd, value, user_id, date_time
                            from [product_attribute]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductAttributeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductAttributeData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductAttributeData>();

            string sql = @" select top " + limit.ToString() + @" product_attribute_id, product_id, product_attribute_rcd, product_attribute_unit_rcd, value, user_id, date_time
                            from [product_attribute]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductAttributeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductAttributeData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductAttributeData>();

            string sql = @" select product_attribute_id, product_id, product_attribute_rcd, product_attribute_unit_rcd, value, user_id, date_time
                            from [product_attribute]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductAttributeData();
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
            string sql = @" select count(*) as count from [product_attribute]";

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
        
        public static List<CrudeProductAttributeData> FetchWithFilter(System.Guid productAttributeId, System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, string value, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductAttributeData>();

            string sql = @" select product_attribute_id, product_id, product_attribute_rcd, product_attribute_unit_rcd, value, user_id, date_time
                            from [product_attribute]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productAttributeId != Guid.Empty) {
                        sql += "  and product_attribute_id = @product_attribute_id";
                        command.Parameters.Add("@product_attribute_id", SqlDbType.UniqueIdentifier).Value = productAttributeId;
                    }
                    if (productId != Guid.Empty) {
                        sql += "  and product_id = @product_id";
                        command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;
                    }
                    if (!string.IsNullOrEmpty(productAttributeRcd)) {
                        sql += "  and product_attribute_rcd like '%' + @product_attribute_rcd + '%'";
                        command.Parameters.Add("@product_attribute_rcd", SqlDbType.NVarChar).Value = productAttributeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productAttributeUnitRcd)) {
                        sql += "  and product_attribute_unit_rcd like '%' + @product_attribute_unit_rcd + '%'";
                        command.Parameters.Add("@product_attribute_unit_rcd", SqlDbType.NVarChar).Value = productAttributeUnitRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(value)) {
                        sql += "  and value like '%' + @value + '%'";
                        command.Parameters.Add("@value", SqlDbType.NVarChar).Value = value.Replace("'","''");
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
                        var data = new CrudeProductAttributeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_attribute_id"] != System.DBNull.Value) ProductAttributeId = (System.Guid) reader["product_attribute_id"];
            if (reader["product_id"] != System.DBNull.Value) ProductId = (System.Guid) reader["product_id"];
            if (reader["product_attribute_rcd"] != System.DBNull.Value) ProductAttributeRcd = (System.String) reader["product_attribute_rcd"];
            if (reader["product_attribute_unit_rcd"] != System.DBNull.Value) ProductAttributeUnitRcd = (System.String) reader["product_attribute_unit_rcd"];
            if (reader["value"] != System.DBNull.Value) Value = (System.String) reader["value"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductAttributeId == Guid.Empty)
                ProductAttributeId = Guid.NewGuid();

            string sql = "insert into [product_attribute] (product_attribute_id, product_id, product_attribute_rcd, product_attribute_unit_rcd, value, user_id, date_time)";
            sql += "            values (@product_attribute_id, @product_id, @product_attribute_rcd, @product_attribute_unit_rcd, @value, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_attribute_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductAttributeId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeRcd;
                    command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ProductAttributeUnitRcd)) ? (object)DBNull.Value : (System.String)ProductAttributeUnitRcd;
                    command.Parameters.Add("@value",SqlDbType.NVarChar).Value = (System.String)Value;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductAttributeId == Guid.Empty)
                ProductAttributeId = Guid.NewGuid();

            string sql = "insert into [product_attribute] (product_attribute_id, product_id, product_attribute_rcd, product_attribute_unit_rcd, value, user_id, date_time)";
            sql += "            values (@product_attribute_id, @product_id, @product_attribute_rcd, @product_attribute_unit_rcd, @value, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_attribute_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductAttributeId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeRcd;
                command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ProductAttributeUnitRcd)) ? (object)DBNull.Value : (System.String)ProductAttributeUnitRcd;
                command.Parameters.Add("@value",SqlDbType.NVarChar).Value = (System.String)Value;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_attribute] set
                 product_attribute_id = @product_attribute_id
                ,product_id = @product_id
                ,product_attribute_rcd = @product_attribute_rcd
                ,product_attribute_unit_rcd = @product_attribute_unit_rcd
                ,value = @value
                ,user_id = @user_id
                ,date_time = @date_time
            where product_attribute_id = @product_attribute_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_attribute_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductAttributeId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeRcd;
                    command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ProductAttributeUnitRcd)) ? (object)DBNull.Value : (System.String)ProductAttributeUnitRcd;
                    command.Parameters.Add("@value",SqlDbType.NVarChar).Value = (System.String)Value;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_attribute] set
                 product_attribute_id = @product_attribute_id
                ,product_id = @product_id
                ,product_attribute_rcd = @product_attribute_rcd
                ,product_attribute_unit_rcd = @product_attribute_unit_rcd
                ,value = @value
                ,user_id = @user_id
                ,date_time = @date_time
            where product_attribute_id = @product_attribute_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_attribute_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductAttributeId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeRcd;
                command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ProductAttributeUnitRcd)) ? (object)DBNull.Value : (System.String)ProductAttributeUnitRcd;
                command.Parameters.Add("@value",SqlDbType.NVarChar).Value = (System.String)Value;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid productAttributeId) {
            string sql = @" delete [product_attribute] 
                where product_attribute_id = @product_attribute_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_attribute_id",SqlDbType.UniqueIdentifier).Value = productAttributeId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
