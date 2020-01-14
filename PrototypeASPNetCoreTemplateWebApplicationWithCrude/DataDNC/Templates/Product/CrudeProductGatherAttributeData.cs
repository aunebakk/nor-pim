/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:46:30 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeProductGatherAttributeData {
        
        public System.Guid ProductGatherAttributeId { get; set; } //;
        
        public string ProductGatherAttributeValue { get; set; } //;
        
        public string ProductGatherAttributeTypeRcd { get; set; } //;
        
        public System.Guid ProductGatherKeyId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductGatherAttributeId(System.Guid productGatherAttributeId) {
            string sql = @" select top 1 product_gather_attribute_id, product_gather_attribute_value, product_gather_attribute_type_rcd, product_gather_key_id, user_id, date_time
                            from [product_gather_attribute]
                            where product_gather_attribute_id = @product_gather_attribute_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_gather_attribute_id",SqlDbType.UniqueIdentifier).Value = productGatherAttributeId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductGatherAttributeData GetByProductGatherAttributeId(System.Guid productGatherAttributeId) {
            string sql = @" select top 1 product_gather_attribute_id, product_gather_attribute_value, product_gather_attribute_type_rcd, product_gather_key_id, user_id, date_time
                            from [product_gather_attribute]
                            where product_gather_attribute_id = @product_gather_attribute_id";

            var ret = new CrudeProductGatherAttributeData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_gather_attribute_id",SqlDbType.UniqueIdentifier).Value = productGatherAttributeId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductGatherAttributeData> FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            var dataList = new List<CrudeProductGatherAttributeData>();

            string sql = @" select product_gather_attribute_id, product_gather_attribute_value, product_gather_attribute_type_rcd, product_gather_key_id, user_id, date_time
                            from [product_gather_attribute]
                            where product_gather_key_id = @product_gather_key_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_gather_key_id", SqlDbType.UniqueIdentifier).Value = productGatherKeyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherAttributeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductGatherAttributeData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductGatherAttributeData>();

            string sql = @" select product_gather_attribute_id, product_gather_attribute_value, product_gather_attribute_type_rcd, product_gather_key_id, user_id, date_time
                            from [product_gather_attribute]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherAttributeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductGatherAttributeData> FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd) {
            var dataList = new List<CrudeProductGatherAttributeData>();

            string sql = @" select product_gather_attribute_id, product_gather_attribute_value, product_gather_attribute_type_rcd, product_gather_key_id, user_id, date_time
                            from [product_gather_attribute]
                            where product_gather_attribute_type_rcd = @product_gather_attribute_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_gather_attribute_type_rcd", SqlDbType.NVarChar).Value = productGatherAttributeTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherAttributeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductGatherAttributeData> FetchAll() {
            var dataList = new List<CrudeProductGatherAttributeData>();

            string sql = @" select product_gather_attribute_id, product_gather_attribute_value, product_gather_attribute_type_rcd, product_gather_key_id, user_id, date_time
                            from [product_gather_attribute]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherAttributeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductGatherAttributeData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductGatherAttributeData>();

            string sql = @" select top " + limit.ToString() + @" product_gather_attribute_id, product_gather_attribute_value, product_gather_attribute_type_rcd, product_gather_key_id, user_id, date_time
                            from [product_gather_attribute]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherAttributeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductGatherAttributeData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductGatherAttributeData>();

            string sql = @" select product_gather_attribute_id, product_gather_attribute_value, product_gather_attribute_type_rcd, product_gather_key_id, user_id, date_time
                            from [product_gather_attribute]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductGatherAttributeData();
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
            string sql = @" select count(*) as count from [product_gather_attribute]";

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
        
        public static List<CrudeProductGatherAttributeData> FetchWithFilter(System.Guid productGatherAttributeId, string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductGatherAttributeData>();

            string sql = @" select product_gather_attribute_id, product_gather_attribute_value, product_gather_attribute_type_rcd, product_gather_key_id, user_id, date_time
                            from [product_gather_attribute]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productGatherAttributeId != Guid.Empty) {
                        sql += "  and product_gather_attribute_id = @product_gather_attribute_id";
                        command.Parameters.Add("@product_gather_attribute_id", SqlDbType.UniqueIdentifier).Value = productGatherAttributeId;
                    }
                    if (!string.IsNullOrEmpty(productGatherAttributeValue)) {
                        sql += "  and product_gather_attribute_value like '%' + @product_gather_attribute_value + '%'";
                        command.Parameters.Add("@product_gather_attribute_value", SqlDbType.NVarChar).Value = productGatherAttributeValue.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productGatherAttributeTypeRcd)) {
                        sql += "  and product_gather_attribute_type_rcd like '%' + @product_gather_attribute_type_rcd + '%'";
                        command.Parameters.Add("@product_gather_attribute_type_rcd", SqlDbType.NVarChar).Value = productGatherAttributeTypeRcd.Replace("'","''");
                    }
                    if (productGatherKeyId != Guid.Empty) {
                        sql += "  and product_gather_key_id = @product_gather_key_id";
                        command.Parameters.Add("@product_gather_key_id", SqlDbType.UniqueIdentifier).Value = productGatherKeyId;
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
                        var data = new CrudeProductGatherAttributeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_gather_attribute_id"] != System.DBNull.Value) ProductGatherAttributeId = (System.Guid) reader["product_gather_attribute_id"];
            if (reader["product_gather_attribute_value"] != System.DBNull.Value) ProductGatherAttributeValue = (System.String) reader["product_gather_attribute_value"];
            if (reader["product_gather_attribute_type_rcd"] != System.DBNull.Value) ProductGatherAttributeTypeRcd = (System.String) reader["product_gather_attribute_type_rcd"];
            if (reader["product_gather_key_id"] != System.DBNull.Value) ProductGatherKeyId = (System.Guid) reader["product_gather_key_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductGatherAttributeId == Guid.Empty)
                ProductGatherAttributeId = Guid.NewGuid();

            string sql = "insert into [product_gather_attribute] (product_gather_attribute_id, product_gather_attribute_value, product_gather_attribute_type_rcd, product_gather_key_id, user_id, date_time)";
            sql += "            values (@product_gather_attribute_id, @product_gather_attribute_value, @product_gather_attribute_type_rcd, @product_gather_key_id, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_gather_attribute_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherAttributeId;
                    command.Parameters.Add("@product_gather_attribute_value",SqlDbType.NVarChar).Value = (System.String)ProductGatherAttributeValue;
                    command.Parameters.Add("@product_gather_attribute_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductGatherAttributeTypeRcd;
                    command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherKeyId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductGatherAttributeId == Guid.Empty)
                ProductGatherAttributeId = Guid.NewGuid();

            string sql = "insert into [product_gather_attribute] (product_gather_attribute_id, product_gather_attribute_value, product_gather_attribute_type_rcd, product_gather_key_id, user_id, date_time)";
            sql += "            values (@product_gather_attribute_id, @product_gather_attribute_value, @product_gather_attribute_type_rcd, @product_gather_key_id, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_gather_attribute_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherAttributeId;
                command.Parameters.Add("@product_gather_attribute_value",SqlDbType.NVarChar).Value = (System.String)ProductGatherAttributeValue;
                command.Parameters.Add("@product_gather_attribute_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductGatherAttributeTypeRcd;
                command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherKeyId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_gather_attribute] set
                 product_gather_attribute_id = @product_gather_attribute_id
                ,product_gather_attribute_value = @product_gather_attribute_value
                ,product_gather_attribute_type_rcd = @product_gather_attribute_type_rcd
                ,product_gather_key_id = @product_gather_key_id
                ,user_id = @user_id
                ,date_time = @date_time
            where product_gather_attribute_id = @product_gather_attribute_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_gather_attribute_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherAttributeId;
                    command.Parameters.Add("@product_gather_attribute_value",SqlDbType.NVarChar).Value = (System.String)ProductGatherAttributeValue;
                    command.Parameters.Add("@product_gather_attribute_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductGatherAttributeTypeRcd;
                    command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherKeyId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_gather_attribute] set
                 product_gather_attribute_id = @product_gather_attribute_id
                ,product_gather_attribute_value = @product_gather_attribute_value
                ,product_gather_attribute_type_rcd = @product_gather_attribute_type_rcd
                ,product_gather_key_id = @product_gather_key_id
                ,user_id = @user_id
                ,date_time = @date_time
            where product_gather_attribute_id = @product_gather_attribute_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_gather_attribute_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherAttributeId;
                command.Parameters.Add("@product_gather_attribute_value",SqlDbType.NVarChar).Value = (System.String)ProductGatherAttributeValue;
                command.Parameters.Add("@product_gather_attribute_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductGatherAttributeTypeRcd;
                command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherKeyId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid productGatherAttributeId) {
            string sql = @" delete [product_gather_attribute] 
                where product_gather_attribute_id = @product_gather_attribute_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_gather_attribute_id",SqlDbType.UniqueIdentifier).Value = productGatherAttributeId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
