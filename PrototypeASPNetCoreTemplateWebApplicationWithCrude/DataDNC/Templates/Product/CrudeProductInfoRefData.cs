/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:53 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class ProductInfoRef {
        
        public const string FDVInfo = "FDV";
        
        public const string HMSInfo = "HMS";
        
        public const string HTMLInfo = "HTML";
        
        public const string ProductInfo = "PI";
        
        public const string UserManual = "UM";
    }
    
    //[Serializable()]
    public partial class CrudeProductInfoRefData {
        
        public string ProductInfoRcd { get; set; } //;
        
        public string ProductInfoName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductInfoRcd(string productInfoRcd) {
            string sql = @" select top 1 product_info_rcd, product_info_name, user_id, date_time
                            from [product_info_ref]
                            where product_info_rcd = @product_info_rcd
                            order by product_info_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = productInfoRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductInfoRefData GetByProductInfoRcd(string productInfoRcd) {
            string sql = @" select top 1 product_info_rcd, product_info_name, user_id, date_time
                            from [product_info_ref]
                            where product_info_rcd = @product_info_rcd
                            order by product_info_name";

            var ret = new CrudeProductInfoRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = productInfoRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductInfoRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductInfoRefData>();

            string sql = @" select product_info_rcd, product_info_name, user_id, date_time
                            from [product_info_ref]
                            where user_id = @user_id
                              
                            order by product_info_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductInfoRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByProductInfoName(string productInfoName) {
            string sql = @" select top 1 product_info_rcd, product_info_name, user_id, date_time
                            from [product_info_ref]
                            where product_info_name like '%' + @productInfoName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@productInfoName",SqlDbType.NVarChar).Value = productInfoName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeProductInfoRefData> FetchAll() {
            var dataList = new List<CrudeProductInfoRefData>();

            string sql = @" select product_info_rcd, product_info_name, user_id, date_time
                            from [product_info_ref]
                            order by product_info_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductInfoRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductInfoRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductInfoRefData>();

            string sql = @" select top " + limit.ToString() + @" product_info_rcd, product_info_name, user_id, date_time
                            from [product_info_ref]
                            order by product_info_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductInfoRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductInfoRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductInfoRefData>();

            string sql = @" select product_info_rcd, product_info_name, user_id, date_time
                            from [product_info_ref]
                            order by product_info_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductInfoRefData();
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
            string sql = @" select count(*) as count from [product_info_ref]";

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
        
        public static List<CrudeProductInfoRefData> FetchWithFilter(string productInfoRcd, string productInfoName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductInfoRefData>();

            string sql = @" select product_info_rcd, product_info_name, user_id, date_time
                            from [product_info_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(productInfoRcd)) {
                        sql += "  and product_info_rcd like '%' + @product_info_rcd + '%'";
                        command.Parameters.Add("@product_info_rcd", SqlDbType.NVarChar).Value = productInfoRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productInfoName)) {
                        sql += "  and product_info_name like '%' + @product_info_name + '%'";
                        command.Parameters.Add("@product_info_name", SqlDbType.NVarChar).Value = productInfoName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by product_info_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductInfoRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_info_rcd"] != System.DBNull.Value) ProductInfoRcd = (System.String) reader["product_info_rcd"];
            if (reader["product_info_name"] != System.DBNull.Value) ProductInfoName = (System.String) reader["product_info_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [product_info_ref] (product_info_rcd, product_info_name, user_id, date_time)";
            sql += "            values (@product_info_rcd, @product_info_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (System.String)ProductInfoRcd;
                    command.Parameters.Add("@product_info_name",SqlDbType.NVarChar).Value = (System.String)ProductInfoName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [product_info_ref] (product_info_rcd, product_info_name, user_id, date_time)";
            sql += "            values (@product_info_rcd, @product_info_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (System.String)ProductInfoRcd;
                command.Parameters.Add("@product_info_name",SqlDbType.NVarChar).Value = (System.String)ProductInfoName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_info_ref] set
                 product_info_rcd = @product_info_rcd
                ,product_info_name = @product_info_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_info_rcd = @product_info_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (System.String)ProductInfoRcd;
                    command.Parameters.Add("@product_info_name",SqlDbType.NVarChar).Value = (System.String)ProductInfoName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_info_ref] set
                 product_info_rcd = @product_info_rcd
                ,product_info_name = @product_info_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_info_rcd = @product_info_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (System.String)ProductInfoRcd;
                command.Parameters.Add("@product_info_name",SqlDbType.NVarChar).Value = (System.String)ProductInfoName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string productInfoRcd) {
            string sql = @" delete [product_info_ref] 
                where product_info_rcd = @product_info_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = productInfoRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
