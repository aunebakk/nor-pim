/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:41:23 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class ProductAttributeUnitRef {
        
        public const string Grams = "G";
        
        public const string Meters = "METER";
        
        public const string MilliMeters = "MM";
    }
    
    //[Serializable()]
    public partial class CrudeProductAttributeUnitRefData {
        
        public string ProductAttributeUnitRcd { get; set; } //;
        
        public string ProductAttributeUnitName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductAttributeUnitRcd(string productAttributeUnitRcd) {
            string sql = @" select top 1 product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time
                            from [product_attribute_unit_ref]
                            where product_attribute_unit_rcd = @product_attribute_unit_rcd
                            order by product_attribute_unit_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = productAttributeUnitRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductAttributeUnitRefData GetByProductAttributeUnitRcd(string productAttributeUnitRcd) {
            string sql = @" select top 1 product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time
                            from [product_attribute_unit_ref]
                            where product_attribute_unit_rcd = @product_attribute_unit_rcd
                            order by product_attribute_unit_name";

            var ret = new CrudeProductAttributeUnitRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = productAttributeUnitRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductAttributeUnitRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductAttributeUnitRefData>();

            string sql = @" select product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time
                            from [product_attribute_unit_ref]
                            where user_id = @user_id
                              
                            order by product_attribute_unit_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductAttributeUnitRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByProductAttributeUnitName(string productAttributeUnitName) {
            string sql = @" select top 1 product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time
                            from [product_attribute_unit_ref]
                            where product_attribute_unit_name like '%' + @productAttributeUnitName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@productAttributeUnitName",SqlDbType.NVarChar).Value = productAttributeUnitName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeProductAttributeUnitRefData> FetchAll() {
            var dataList = new List<CrudeProductAttributeUnitRefData>();

            string sql = @" select product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time
                            from [product_attribute_unit_ref]
                            order by product_attribute_unit_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductAttributeUnitRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductAttributeUnitRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductAttributeUnitRefData>();

            string sql = @" select top " + limit.ToString() + @" product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time
                            from [product_attribute_unit_ref]
                            order by product_attribute_unit_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductAttributeUnitRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductAttributeUnitRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductAttributeUnitRefData>();

            string sql = @" select product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time
                            from [product_attribute_unit_ref]
                            order by product_attribute_unit_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductAttributeUnitRefData();
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
            string sql = @" select count(*) as count from [product_attribute_unit_ref]";

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
        
        public static List<CrudeProductAttributeUnitRefData> FetchWithFilter(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductAttributeUnitRefData>();

            string sql = @" select product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time
                            from [product_attribute_unit_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(productAttributeUnitRcd)) {
                        sql += "  and product_attribute_unit_rcd like '%' + @product_attribute_unit_rcd + '%'";
                        command.Parameters.Add("@product_attribute_unit_rcd", SqlDbType.NVarChar).Value = productAttributeUnitRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productAttributeUnitName)) {
                        sql += "  and product_attribute_unit_name like '%' + @product_attribute_unit_name + '%'";
                        command.Parameters.Add("@product_attribute_unit_name", SqlDbType.NVarChar).Value = productAttributeUnitName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by product_attribute_unit_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductAttributeUnitRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_attribute_unit_rcd"] != System.DBNull.Value) ProductAttributeUnitRcd = (System.String) reader["product_attribute_unit_rcd"];
            if (reader["product_attribute_unit_name"] != System.DBNull.Value) ProductAttributeUnitName = (System.String) reader["product_attribute_unit_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [product_attribute_unit_ref] (product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time)";
            sql += "            values (@product_attribute_unit_rcd, @product_attribute_unit_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeUnitRcd;
                    command.Parameters.Add("@product_attribute_unit_name",SqlDbType.NVarChar).Value = (System.String)ProductAttributeUnitName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [product_attribute_unit_ref] (product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time)";
            sql += "            values (@product_attribute_unit_rcd, @product_attribute_unit_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeUnitRcd;
                command.Parameters.Add("@product_attribute_unit_name",SqlDbType.NVarChar).Value = (System.String)ProductAttributeUnitName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_attribute_unit_ref] set
                 product_attribute_unit_rcd = @product_attribute_unit_rcd
                ,product_attribute_unit_name = @product_attribute_unit_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_attribute_unit_rcd = @product_attribute_unit_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeUnitRcd;
                    command.Parameters.Add("@product_attribute_unit_name",SqlDbType.NVarChar).Value = (System.String)ProductAttributeUnitName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_attribute_unit_ref] set
                 product_attribute_unit_rcd = @product_attribute_unit_rcd
                ,product_attribute_unit_name = @product_attribute_unit_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_attribute_unit_rcd = @product_attribute_unit_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeUnitRcd;
                command.Parameters.Add("@product_attribute_unit_name",SqlDbType.NVarChar).Value = (System.String)ProductAttributeUnitName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string productAttributeUnitRcd) {
            string sql = @" delete [product_attribute_unit_ref] 
                where product_attribute_unit_rcd = @product_attribute_unit_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = productAttributeUnitRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
