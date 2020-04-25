/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:19:44 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductExposeSetData {
        
        public System.Guid ProductExposeSetId { get; set; } //;
        
        public string ProductExposeSetTypeRcd { get; set; } //;
        
        public string ProductExposeSetName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductExposeSetId(System.Guid productExposeSetId) {
            string sql = @" select top 1 product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time
                            from [product_expose_set]
                            where product_expose_set_id = @product_expose_set_id
                            order by product_expose_set_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = productExposeSetId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductExposeSetData GetByProductExposeSetId(System.Guid productExposeSetId) {
            string sql = @" select top 1 product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time
                            from [product_expose_set]
                            where product_expose_set_id = @product_expose_set_id
                            order by product_expose_set_name";

            var ret = new CrudeProductExposeSetData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = productExposeSetId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductExposeSetData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductExposeSetData>();

            string sql = @" select product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time
                            from [product_expose_set]
                            where user_id = @user_id
                              
                            order by product_expose_set_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposeSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposeSetData> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            var dataList = new List<CrudeProductExposeSetData>();

            string sql = @" select product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time
                            from [product_expose_set]
                            where product_expose_set_type_rcd = @product_expose_set_type_rcd
                              
                            order by product_expose_set_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_expose_set_type_rcd", SqlDbType.NVarChar).Value = productExposeSetTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposeSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByProductExposeSetName(string productExposeSetName) {
            string sql = @" select top 1 product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time
                            from [product_expose_set]
                            where product_expose_set_name like '%' + @productExposeSetName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@productExposeSetName",SqlDbType.NVarChar).Value = productExposeSetName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeProductExposeSetData> FetchAll() {
            var dataList = new List<CrudeProductExposeSetData>();

            string sql = @" select product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time
                            from [product_expose_set]
                            order by product_expose_set_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposeSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposeSetData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductExposeSetData>();

            string sql = @" select top " + limit.ToString() + @" product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time
                            from [product_expose_set]
                            order by product_expose_set_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposeSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposeSetData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductExposeSetData>();

            string sql = @" select product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time
                            from [product_expose_set]
                            order by product_expose_set_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductExposeSetData();
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
            string sql = @" select count(*) as count from [product_expose_set]";

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
        
        public static List<CrudeProductExposeSetData> FetchWithFilter(System.Guid productExposeSetId, string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductExposeSetData>();

            string sql = @" select product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time
                            from [product_expose_set]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productExposeSetId != Guid.Empty) {
                        sql += "  and product_expose_set_id = @product_expose_set_id";
                        command.Parameters.Add("@product_expose_set_id", SqlDbType.UniqueIdentifier).Value = productExposeSetId;
                    }
                    if (!string.IsNullOrEmpty(productExposeSetTypeRcd)) {
                        sql += "  and product_expose_set_type_rcd like '%' + @product_expose_set_type_rcd + '%'";
                        command.Parameters.Add("@product_expose_set_type_rcd", SqlDbType.NVarChar).Value = productExposeSetTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productExposeSetName)) {
                        sql += "  and product_expose_set_name like '%' + @product_expose_set_name + '%'";
                        command.Parameters.Add("@product_expose_set_name", SqlDbType.NVarChar).Value = productExposeSetName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by product_expose_set_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposeSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_expose_set_id"] != System.DBNull.Value) ProductExposeSetId = (System.Guid) reader["product_expose_set_id"];
            if (reader["product_expose_set_type_rcd"] != System.DBNull.Value) ProductExposeSetTypeRcd = (System.String) reader["product_expose_set_type_rcd"];
            if (reader["product_expose_set_name"] != System.DBNull.Value) ProductExposeSetName = (System.String) reader["product_expose_set_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductExposeSetId == Guid.Empty)
                ProductExposeSetId = Guid.NewGuid();

            string sql = "insert into [product_expose_set] (product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time)";
            sql += "            values (@product_expose_set_id, @product_expose_set_type_rcd, @product_expose_set_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeSetId;
                    command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeRcd;
                    command.Parameters.Add("@product_expose_set_name",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductExposeSetId == Guid.Empty)
                ProductExposeSetId = Guid.NewGuid();

            string sql = "insert into [product_expose_set] (product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time)";
            sql += "            values (@product_expose_set_id, @product_expose_set_type_rcd, @product_expose_set_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeSetId;
                command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeRcd;
                command.Parameters.Add("@product_expose_set_name",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_expose_set] set
                 product_expose_set_id = @product_expose_set_id
                ,product_expose_set_type_rcd = @product_expose_set_type_rcd
                ,product_expose_set_name = @product_expose_set_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_expose_set_id = @product_expose_set_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeSetId;
                    command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeRcd;
                    command.Parameters.Add("@product_expose_set_name",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_expose_set] set
                 product_expose_set_id = @product_expose_set_id
                ,product_expose_set_type_rcd = @product_expose_set_type_rcd
                ,product_expose_set_name = @product_expose_set_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_expose_set_id = @product_expose_set_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeSetId;
                command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetTypeRcd;
                command.Parameters.Add("@product_expose_set_name",SqlDbType.NVarChar).Value = (System.String)ProductExposeSetName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid productExposeSetId) {
            string sql = @" delete [product_expose_set] 
                where product_expose_set_id = @product_expose_set_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = productExposeSetId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
