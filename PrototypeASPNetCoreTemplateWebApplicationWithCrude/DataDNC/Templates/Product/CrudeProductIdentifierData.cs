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
    public partial class CrudeProductIdentifierData {
        
        public System.Guid ProductIdentifierId { get; set; } //;
        
        public System.Guid ProductId { get; set; } //;
        
        public string ProductIdentifierRcd { get; set; } //;
        
        public string Identifier { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductIdentifierId(System.Guid productIdentifierId) {
            string sql = @" select top 1 product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time
                            from [product_identifier]
                            where product_identifier_id = @product_identifier_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_identifier_id",SqlDbType.UniqueIdentifier).Value = productIdentifierId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductIdentifierData GetByProductIdentifierId(System.Guid productIdentifierId) {
            string sql = @" select top 1 product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time
                            from [product_identifier]
                            where product_identifier_id = @product_identifier_id";

            var ret = new CrudeProductIdentifierData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_identifier_id",SqlDbType.UniqueIdentifier).Value = productIdentifierId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductIdentifierData> FetchByProductId(System.Guid productId) {
            var dataList = new List<CrudeProductIdentifierData>();

            string sql = @" select product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time
                            from [product_identifier]
                            where product_id = @product_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductIdentifierData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductIdentifierData>();

            string sql = @" select product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time
                            from [product_identifier]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductIdentifierData> FetchByProductIdentifierRcd(string productIdentifierRcd) {
            var dataList = new List<CrudeProductIdentifierData>();

            string sql = @" select product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time
                            from [product_identifier]
                            where product_identifier_rcd = @product_identifier_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_identifier_rcd", SqlDbType.NVarChar).Value = productIdentifierRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductIdentifierData> FetchAll() {
            var dataList = new List<CrudeProductIdentifierData>();

            string sql = @" select product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time
                            from [product_identifier]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductIdentifierData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductIdentifierData>();

            string sql = @" select top " + limit.ToString() + @" product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time
                            from [product_identifier]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductIdentifierData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductIdentifierData>();

            string sql = @" select product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time
                            from [product_identifier]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductIdentifierData();
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
            string sql = @" select count(*) as count from [product_identifier]";

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
        
        public static List<CrudeProductIdentifierData> FetchWithFilter(System.Guid productIdentifierId, System.Guid productId, string productIdentifierRcd, string identifier, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductIdentifierData>();

            string sql = @" select product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time
                            from [product_identifier]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productIdentifierId != Guid.Empty) {
                        sql += "  and product_identifier_id = @product_identifier_id";
                        command.Parameters.Add("@product_identifier_id", SqlDbType.UniqueIdentifier).Value = productIdentifierId;
                    }
                    if (productId != Guid.Empty) {
                        sql += "  and product_id = @product_id";
                        command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;
                    }
                    if (!string.IsNullOrEmpty(productIdentifierRcd)) {
                        sql += "  and product_identifier_rcd like '%' + @product_identifier_rcd + '%'";
                        command.Parameters.Add("@product_identifier_rcd", SqlDbType.NVarChar).Value = productIdentifierRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(identifier)) {
                        sql += "  and identifier like '%' + @identifier + '%'";
                        command.Parameters.Add("@identifier", SqlDbType.NVarChar).Value = identifier.Replace("'","''");
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
                        var data = new CrudeProductIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_identifier_id"] != System.DBNull.Value) ProductIdentifierId = (System.Guid) reader["product_identifier_id"];
            if (reader["product_id"] != System.DBNull.Value) ProductId = (System.Guid) reader["product_id"];
            if (reader["product_identifier_rcd"] != System.DBNull.Value) ProductIdentifierRcd = (System.String) reader["product_identifier_rcd"];
            if (reader["identifier"] != System.DBNull.Value) Identifier = (System.String) reader["identifier"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductIdentifierId == Guid.Empty)
                ProductIdentifierId = Guid.NewGuid();

            string sql = "insert into [product_identifier] (product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time)";
            sql += "            values (@product_identifier_id, @product_id, @product_identifier_rcd, @identifier, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_identifier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductIdentifierId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                    command.Parameters.Add("@identifier",SqlDbType.NVarChar).Value = (System.String)Identifier;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductIdentifierId == Guid.Empty)
                ProductIdentifierId = Guid.NewGuid();

            string sql = "insert into [product_identifier] (product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time)";
            sql += "            values (@product_identifier_id, @product_id, @product_identifier_rcd, @identifier, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_identifier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductIdentifierId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                command.Parameters.Add("@identifier",SqlDbType.NVarChar).Value = (System.String)Identifier;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_identifier] set
                 product_identifier_id = @product_identifier_id
                ,product_id = @product_id
                ,product_identifier_rcd = @product_identifier_rcd
                ,identifier = @identifier
                ,user_id = @user_id
                ,date_time = @date_time
            where product_identifier_id = @product_identifier_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_identifier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductIdentifierId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                    command.Parameters.Add("@identifier",SqlDbType.NVarChar).Value = (System.String)Identifier;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_identifier] set
                 product_identifier_id = @product_identifier_id
                ,product_id = @product_id
                ,product_identifier_rcd = @product_identifier_rcd
                ,identifier = @identifier
                ,user_id = @user_id
                ,date_time = @date_time
            where product_identifier_id = @product_identifier_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_identifier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductIdentifierId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                command.Parameters.Add("@identifier",SqlDbType.NVarChar).Value = (System.String)Identifier;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid productIdentifierId) {
            string sql = @" delete [product_identifier] 
                where product_identifier_id = @product_identifier_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_identifier_id",SqlDbType.UniqueIdentifier).Value = productIdentifierId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
