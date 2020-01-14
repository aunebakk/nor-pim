/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:31 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class ProductEntityTypeRef {
        
        public const string Product = "P";
        
        public const string ProductAttribute = "PA";
        
        public const string ProductCategory = "PC";
        
        public const string ProductDescription = "PD";
        
        public const string ProductIdentifier = "PID";
        
        public const string ProductInfo = "PI";
        
        public const string ProductSupplier = "PS";
    }
    
    //[Serializable()]
    public partial class CrudeProductEntityTypeRefData {
        
        public string ProductEntityTypeRcd { get; set; } //;
        
        public string ProductEntityTypeName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductEntityTypeRcd(string productEntityTypeRcd) {
            string sql = @" select top 1 product_entity_type_rcd, product_entity_type_name, user_id, date_time
                            from [product_entity_type_ref]
                            where product_entity_type_rcd = @product_entity_type_rcd
                            order by product_entity_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_entity_type_rcd",SqlDbType.NVarChar).Value = productEntityTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductEntityTypeRefData GetByProductEntityTypeRcd(string productEntityTypeRcd) {
            string sql = @" select top 1 product_entity_type_rcd, product_entity_type_name, user_id, date_time
                            from [product_entity_type_ref]
                            where product_entity_type_rcd = @product_entity_type_rcd
                            order by product_entity_type_name";

            var ret = new CrudeProductEntityTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_entity_type_rcd",SqlDbType.NVarChar).Value = productEntityTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductEntityTypeRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductEntityTypeRefData>();

            string sql = @" select product_entity_type_rcd, product_entity_type_name, user_id, date_time
                            from [product_entity_type_ref]
                            where user_id = @user_id
                              
                            order by product_entity_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductEntityTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByProductEntityTypeName(string productEntityTypeName) {
            string sql = @" select top 1 product_entity_type_rcd, product_entity_type_name, user_id, date_time
                            from [product_entity_type_ref]
                            where product_entity_type_name like '%' + @productEntityTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@productEntityTypeName",SqlDbType.NVarChar).Value = productEntityTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeProductEntityTypeRefData> FetchAll() {
            var dataList = new List<CrudeProductEntityTypeRefData>();

            string sql = @" select product_entity_type_rcd, product_entity_type_name, user_id, date_time
                            from [product_entity_type_ref]
                            order by product_entity_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductEntityTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductEntityTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductEntityTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" product_entity_type_rcd, product_entity_type_name, user_id, date_time
                            from [product_entity_type_ref]
                            order by product_entity_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductEntityTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductEntityTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductEntityTypeRefData>();

            string sql = @" select product_entity_type_rcd, product_entity_type_name, user_id, date_time
                            from [product_entity_type_ref]
                            order by product_entity_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductEntityTypeRefData();
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
            string sql = @" select count(*) as count from [product_entity_type_ref]";

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
        
        public static List<CrudeProductEntityTypeRefData> FetchWithFilter(string productEntityTypeRcd, string productEntityTypeName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductEntityTypeRefData>();

            string sql = @" select product_entity_type_rcd, product_entity_type_name, user_id, date_time
                            from [product_entity_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(productEntityTypeRcd)) {
                        sql += "  and product_entity_type_rcd like '%' + @product_entity_type_rcd + '%'";
                        command.Parameters.Add("@product_entity_type_rcd", SqlDbType.NVarChar).Value = productEntityTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productEntityTypeName)) {
                        sql += "  and product_entity_type_name like '%' + @product_entity_type_name + '%'";
                        command.Parameters.Add("@product_entity_type_name", SqlDbType.NVarChar).Value = productEntityTypeName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by product_entity_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductEntityTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_entity_type_rcd"] != System.DBNull.Value) ProductEntityTypeRcd = (System.String) reader["product_entity_type_rcd"];
            if (reader["product_entity_type_name"] != System.DBNull.Value) ProductEntityTypeName = (System.String) reader["product_entity_type_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [product_entity_type_ref] (product_entity_type_rcd, product_entity_type_name, user_id, date_time)";
            sql += "            values (@product_entity_type_rcd, @product_entity_type_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_entity_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductEntityTypeRcd;
                    command.Parameters.Add("@product_entity_type_name",SqlDbType.NVarChar).Value = (System.String)ProductEntityTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [product_entity_type_ref] (product_entity_type_rcd, product_entity_type_name, user_id, date_time)";
            sql += "            values (@product_entity_type_rcd, @product_entity_type_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_entity_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductEntityTypeRcd;
                command.Parameters.Add("@product_entity_type_name",SqlDbType.NVarChar).Value = (System.String)ProductEntityTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_entity_type_ref] set
                 product_entity_type_rcd = @product_entity_type_rcd
                ,product_entity_type_name = @product_entity_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_entity_type_rcd = @product_entity_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_entity_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductEntityTypeRcd;
                    command.Parameters.Add("@product_entity_type_name",SqlDbType.NVarChar).Value = (System.String)ProductEntityTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_entity_type_ref] set
                 product_entity_type_rcd = @product_entity_type_rcd
                ,product_entity_type_name = @product_entity_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_entity_type_rcd = @product_entity_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_entity_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductEntityTypeRcd;
                command.Parameters.Add("@product_entity_type_name",SqlDbType.NVarChar).Value = (System.String)ProductEntityTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string productEntityTypeRcd) {
            string sql = @" delete [product_entity_type_ref] 
                where product_entity_type_rcd = @product_entity_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_entity_type_rcd",SqlDbType.NVarChar).Value = productEntityTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
