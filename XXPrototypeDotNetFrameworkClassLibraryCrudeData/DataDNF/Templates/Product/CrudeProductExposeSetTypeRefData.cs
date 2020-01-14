/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:41:29 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    public partial class ProductExposeSetTypeRef {
        
        public const string Customer = "Customer";
        
        public const string Export = "Export";
        
        public const string Print = "Print";
        
        public const string Web = "Web";
    }
    
    [Serializable()]
    public partial class CrudeProductExposeSetTypeRefData {
        
        public string ProductExposeSetTypeRcd { get; set; } //;
        
        public string ProductExposeSetTypeName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            string sql = @" select top 1 product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time
                            from [product_expose_set_type_ref]
                            where product_expose_set_type_rcd = @product_expose_set_type_rcd
                            order by product_expose_set_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = productExposeSetTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductExposeSetTypeRefData GetByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            string sql = @" select top 1 product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time
                            from [product_expose_set_type_ref]
                            where product_expose_set_type_rcd = @product_expose_set_type_rcd
                            order by product_expose_set_type_name";

            var ret = new CrudeProductExposeSetTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = productExposeSetTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductExposeSetTypeRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductExposeSetTypeRefData>();

            string sql = @" select product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time
                            from [product_expose_set_type_ref]
                            where user_id = @user_id
                              
                            order by product_expose_set_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposeSetTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByProductExposeSetTypeName(string productExposeSetTypeName) {
            string sql = @" select top 1 product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time
                            from [product_expose_set_type_ref]
                            where product_expose_set_type_name like '%' + @productExposeSetTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@productExposeSetTypeName",SqlDbType.NVarChar).Value = productExposeSetTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeProductExposeSetTypeRefData> FetchAll() {
            var dataList = new List<CrudeProductExposeSetTypeRefData>();

            string sql = @" select product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time
                            from [product_expose_set_type_ref]
                            order by product_expose_set_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposeSetTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposeSetTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductExposeSetTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time
                            from [product_expose_set_type_ref]
                            order by product_expose_set_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposeSetTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposeSetTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductExposeSetTypeRefData>();

            string sql = @" select product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time
                            from [product_expose_set_type_ref]
                            order by product_expose_set_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductExposeSetTypeRefData();
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
            string sql = @" select count(*) as count from [product_expose_set_type_ref]";

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
        
        public static List<CrudeProductExposeSetTypeRefData> FetchWithFilter(string productExposeSetTypeRcd, string productExposeSetTypeName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductExposeSetTypeRefData>();

            string sql = @" select product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time
                            from [product_expose_set_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(productExposeSetTypeRcd)) {
                        sql += "  and product_expose_set_type_rcd like '%' + @product_expose_set_type_rcd + '%'";
                        command.Parameters.Add("@product_expose_set_type_rcd", SqlDbType.NVarChar).Value = productExposeSetTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productExposeSetTypeName)) {
                        sql += "  and product_expose_set_type_name like '%' + @product_expose_set_type_name + '%'";
                        command.Parameters.Add("@product_expose_set_type_name", SqlDbType.NVarChar).Value = productExposeSetTypeName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by product_expose_set_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposeSetTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_expose_set_type_rcd"] != System.DBNull.Value) ProductExposeSetTypeRcd = (System.String) reader["product_expose_set_type_rcd"];
            if (reader["product_expose_set_type_name"] != System.DBNull.Value) ProductExposeSetTypeName = (System.String) reader["product_expose_set_type_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [product_expose_set_type_ref] (product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time)";
            sql += "            values (@product_expose_set_type_rcd, @product_expose_set_type_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeRcd;
                    command.Parameters.Add("@product_expose_set_type_name",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [product_expose_set_type_ref] (product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time)";
            sql += "            values (@product_expose_set_type_rcd, @product_expose_set_type_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeRcd;
                command.Parameters.Add("@product_expose_set_type_name",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_expose_set_type_ref] set
                 product_expose_set_type_rcd = @product_expose_set_type_rcd
                ,product_expose_set_type_name = @product_expose_set_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_expose_set_type_rcd = @product_expose_set_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeRcd;
                    command.Parameters.Add("@product_expose_set_type_name",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_expose_set_type_ref] set
                 product_expose_set_type_rcd = @product_expose_set_type_rcd
                ,product_expose_set_type_name = @product_expose_set_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_expose_set_type_rcd = @product_expose_set_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeRcd;
                command.Parameters.Add("@product_expose_set_type_name",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string productExposeSetTypeRcd) {
            string sql = @" delete [product_expose_set_type_ref] 
                where product_expose_set_type_rcd = @product_expose_set_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = productExposeSetTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
