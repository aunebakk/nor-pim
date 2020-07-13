/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 1:45:24 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class CrudeProductExposePlanData {
        
        public System.Guid ProductExposePlanId { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public string ProductExposeSetTypeRcd { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public void FetchByProductExposePlanId(System.Guid productExposePlanId) {
            string sql = @" select top 1 product_expose_plan_id, product_id, product_expose_set_type_rcd, user_id, date_time
                            from [product_expose_plan]
                            where product_expose_plan_id = @product_expose_plan_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_expose_plan_id",SqlDbType.UniqueIdentifier).Value = productExposePlanId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductExposePlanData GetByProductExposePlanId(System.Guid productExposePlanId) {
            string sql = @" select top 1 product_expose_plan_id, product_id, product_expose_set_type_rcd, user_id, date_time
                            from [product_expose_plan]
                            where product_expose_plan_id = @product_expose_plan_id";

            var ret = new CrudeProductExposePlanData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_expose_plan_id",SqlDbType.UniqueIdentifier).Value = productExposePlanId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductExposePlanData> FetchByProductId(System.Guid productId) {
            var dataList = new List<CrudeProductExposePlanData>();

            string sql = @" select product_expose_plan_id, product_id, product_expose_set_type_rcd, user_id, date_time
                            from [product_expose_plan]
                            where product_id = @product_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposePlanData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposePlanData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductExposePlanData>();

            string sql = @" select product_expose_plan_id, product_id, product_expose_set_type_rcd, user_id, date_time
                            from [product_expose_plan]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposePlanData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposePlanData> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            var dataList = new List<CrudeProductExposePlanData>();

            string sql = @" select product_expose_plan_id, product_id, product_expose_set_type_rcd, user_id, date_time
                            from [product_expose_plan]
                            where product_expose_set_type_rcd = @product_expose_set_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_expose_set_type_rcd", SqlDbType.NVarChar).Value = productExposeSetTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposePlanData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposePlanData> FetchAll() {
            var dataList = new List<CrudeProductExposePlanData>();

            string sql = @" select product_expose_plan_id, product_id, product_expose_set_type_rcd, user_id, date_time
                            from [product_expose_plan]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposePlanData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposePlanData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductExposePlanData>();

            string sql = @" select top " + limit.ToString() + @" product_expose_plan_id, product_id, product_expose_set_type_rcd, user_id, date_time
                            from [product_expose_plan]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposePlanData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposePlanData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductExposePlanData>();

            string sql = @" select product_expose_plan_id, product_id, product_expose_set_type_rcd, user_id, date_time
                            from [product_expose_plan]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductExposePlanData();
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
            string sql = @" select count(*) as count from [product_expose_plan]";

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
        
        public static List<CrudeProductExposePlanData> FetchWithFilter(System.Guid productExposePlanId, System.Guid productId, string productExposeSetTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductExposePlanData>();

            string sql = @" select product_expose_plan_id, product_id, product_expose_set_type_rcd, user_id, date_time
                            from [product_expose_plan]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productExposePlanId != Guid.Empty) {
                        sql += "  and product_expose_plan_id = @product_expose_plan_id";
                        command.Parameters.Add("@product_expose_plan_id", SqlDbType.UniqueIdentifier).Value = productExposePlanId;
                    }
                    if (productId != Guid.Empty) {
                        sql += "  and product_id = @product_id";
                        command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;
                    }
                    if (!string.IsNullOrEmpty(productExposeSetTypeRcd)) {
                        sql += "  and product_expose_set_type_rcd like '%' + @product_expose_set_type_rcd + '%'";
                        command.Parameters.Add("@product_expose_set_type_rcd", SqlDbType.NVarChar).Value = productExposeSetTypeRcd.Replace("'","''");
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
                        var data = new CrudeProductExposePlanData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_expose_plan_id"] != System.DBNull.Value) ProductExposePlanId = (System.Guid) reader["product_expose_plan_id"];
            if (reader["product_id"] != System.DBNull.Value) ProductId = (System.Guid) reader["product_id"];
            if (reader["product_expose_set_type_rcd"] != System.DBNull.Value) ProductExposeSetTypeRcd = (System.String) reader["product_expose_set_type_rcd"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductExposePlanId == Guid.Empty)
                ProductExposePlanId = Guid.NewGuid();

            string sql = "insert into [product_expose_plan] (product_expose_plan_id, product_id, product_expose_set_type_rcd, user_id, date_time)";
            sql += "            values (@product_expose_plan_id, @product_id, @product_expose_set_type_rcd, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_expose_plan_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposePlanId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductExposePlanId == Guid.Empty)
                ProductExposePlanId = Guid.NewGuid();

            string sql = "insert into [product_expose_plan] (product_expose_plan_id, product_id, product_expose_set_type_rcd, user_id, date_time)";
            sql += "            values (@product_expose_plan_id, @product_id, @product_expose_set_type_rcd, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_expose_plan_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposePlanId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_expose_plan] set
                 product_expose_plan_id = @product_expose_plan_id
                ,product_id = @product_id
                ,product_expose_set_type_rcd = @product_expose_set_type_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where product_expose_plan_id = @product_expose_plan_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_expose_plan_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposePlanId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_expose_plan] set
                 product_expose_plan_id = @product_expose_plan_id
                ,product_id = @product_id
                ,product_expose_set_type_rcd = @product_expose_set_type_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where product_expose_plan_id = @product_expose_plan_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_expose_plan_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposePlanId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid productExposePlanId) {
            string sql = @" delete [product_expose_plan] 
                where product_expose_plan_id = @product_expose_plan_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_expose_plan_id",SqlDbType.UniqueIdentifier).Value = productExposePlanId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
