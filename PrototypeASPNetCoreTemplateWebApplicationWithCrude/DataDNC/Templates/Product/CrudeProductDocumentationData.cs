/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:45:43 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
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

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_documentation_id",SqlDbType.UniqueIdentifier).Value = productDocumentationId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductDocumentationData GetByProductDocumentationId(System.Guid productDocumentationId) {
            string sql = @" select top 1 product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time
                            from [product_documentation]
                            where product_documentation_id = @product_documentation_id";

            var ret = new CrudeProductDocumentationData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_documentation_id",SqlDbType.UniqueIdentifier).Value = productDocumentationId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductDocumentationData> FetchByProductId(System.Guid productId) {
            var dataList = new List<CrudeProductDocumentationData>();

            string sql = @" select product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time
                            from [product_documentation]
                            where product_id = @product_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
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
        
        public static List<CrudeProductDocumentationData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductDocumentationData>();

            string sql = @" select product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time
                            from [product_documentation]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
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
        
        public static List<CrudeProductDocumentationData> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            var dataList = new List<CrudeProductDocumentationData>();

            string sql = @" select product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time
                            from [product_documentation]
                            where product_documentation_type_rcd = @product_documentation_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_documentation_type_rcd", SqlDbType.NVarChar).Value = productDocumentationTypeRcd.Replace("'","''");

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
        
        public static List<CrudeProductDocumentationData> FetchAll() {
            var dataList = new List<CrudeProductDocumentationData>();

            string sql = @" select product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time
                            from [product_documentation]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
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
        
        public static List<CrudeProductDocumentationData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductDocumentationData>();

            string sql = @" select top " + limit.ToString() + @" product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time
                            from [product_documentation]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
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
        
        public static List<CrudeProductDocumentationData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductDocumentationData>();

            string sql = @" select product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time
                            from [product_documentation]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
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
        
        public static int FetchAllCount() {
            string sql = @" select count(*) as count from [product_documentation]";

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
        
        public static List<CrudeProductDocumentationData> FetchWithFilter(System.Guid productDocumentationId, System.Guid productId, string productDocumentationTypeRcd, string documentation, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductDocumentationData>();

            string sql = @" select product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time
                            from [product_documentation]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
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
                    if (!string.IsNullOrEmpty(productDocumentationTypeRcd)) {
                        sql += "  and product_documentation_type_rcd like '%' + @product_documentation_type_rcd + '%'";
                        command.Parameters.Add("@product_documentation_type_rcd", SqlDbType.NVarChar).Value = productDocumentationTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(documentation)) {
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

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_documentation_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductDocumentationId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductDocumentationTypeRcd;
                    command.Parameters.Add("@documentation",SqlDbType.NVarChar).Value = (System.String)Documentation;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductDocumentationId == Guid.Empty)
                ProductDocumentationId = Guid.NewGuid();

            string sql = "insert into [product_documentation] (product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time)";
            sql += "            values (@product_documentation_id, @product_id, @product_documentation_type_rcd, @documentation, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_documentation_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductDocumentationId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductDocumentationTypeRcd;
                command.Parameters.Add("@documentation",SqlDbType.NVarChar).Value = (System.String)Documentation;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
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

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_documentation_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductDocumentationId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductDocumentationTypeRcd;
                    command.Parameters.Add("@documentation",SqlDbType.NVarChar).Value = (System.String)Documentation;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
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

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_documentation_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductDocumentationId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductDocumentationTypeRcd;
                command.Parameters.Add("@documentation",SqlDbType.NVarChar).Value = (System.String)Documentation;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid productDocumentationId) {
            string sql = @" delete [product_documentation] 
                where product_documentation_id = @product_documentation_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_documentation_id",SqlDbType.UniqueIdentifier).Value = productDocumentationId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
