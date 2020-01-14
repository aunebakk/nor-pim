/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:24:07 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    public partial class ProductIdentifierRef {
        
        public const string BlockStructure1 = "BS1";
        
        public const string BlockStructure2 = "BS2";
        
        public const string BlockStructure3 = "BS3";
        
        public const string GlobalTradeItemNumber13 = "GTIN13";
        
        public const string GlobalTradeItemNumber14 = "GTIN14";
        
        public const string HN = "HN";
    }
    
    [Serializable()]
    public partial class CrudeProductIdentifierRefData {
        
        public string ProductIdentifierRcd { get; set; } //;
        
        public string ProductIdentifierName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductIdentifierRcd(string productIdentifierRcd) {
            string sql = @" select top 1 product_identifier_rcd, product_identifier_name, user_id, date_time
                            from [product_identifier_ref]
                            where product_identifier_rcd = @product_identifier_rcd
                            order by product_identifier_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = productIdentifierRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductIdentifierRefData GetByProductIdentifierRcd(string productIdentifierRcd) {
            string sql = @" select top 1 product_identifier_rcd, product_identifier_name, user_id, date_time
                            from [product_identifier_ref]
                            where product_identifier_rcd = @product_identifier_rcd
                            order by product_identifier_name";

            var ret = new CrudeProductIdentifierRefData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = productIdentifierRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductIdentifierRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductIdentifierRefData>();

            string sql = @" select product_identifier_rcd, product_identifier_name, user_id, date_time
                            from [product_identifier_ref]
                            where user_id = @user_id
                              
                            order by product_identifier_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductIdentifierRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByProductIdentifierName(string productIdentifierName) {
            string sql = @" select top 1 product_identifier_rcd, product_identifier_name, user_id, date_time
                            from [product_identifier_ref]
                            where product_identifier_name like '%' + @productIdentifierName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@productIdentifierName",SqlDbType.NVarChar).Value = productIdentifierName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeProductIdentifierRefData> FetchAll() {
            var dataList = new List<CrudeProductIdentifierRefData>();

            string sql = @" select product_identifier_rcd, product_identifier_name, user_id, date_time
                            from [product_identifier_ref]
                            order by product_identifier_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductIdentifierRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductIdentifierRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductIdentifierRefData>();

            string sql = @" select top " + limit.ToString() + @" product_identifier_rcd, product_identifier_name, user_id, date_time
                            from [product_identifier_ref]
                            order by product_identifier_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductIdentifierRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductIdentifierRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductIdentifierRefData>();

            string sql = @" select product_identifier_rcd, product_identifier_name, user_id, date_time
                            from [product_identifier_ref]
                            order by product_identifier_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductIdentifierRefData();
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
            string sql = @" select count(*) as count from [product_identifier_ref]";

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
        
        public static List<CrudeProductIdentifierRefData> FetchWithFilter(string productIdentifierRcd, string productIdentifierName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductIdentifierRefData>();

            string sql = @" select product_identifier_rcd, product_identifier_name, user_id, date_time
                            from [product_identifier_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(productIdentifierRcd)) {
                        sql += "  and product_identifier_rcd like '%' + @product_identifier_rcd + '%'";
                        command.Parameters.Add("@product_identifier_rcd", SqlDbType.NVarChar).Value = productIdentifierRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productIdentifierName)) {
                        sql += "  and product_identifier_name like '%' + @product_identifier_name + '%'";
                        command.Parameters.Add("@product_identifier_name", SqlDbType.NVarChar).Value = productIdentifierName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by product_identifier_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductIdentifierRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_identifier_rcd"] != System.DBNull.Value) ProductIdentifierRcd = (System.String) reader["product_identifier_rcd"];
            if (reader["product_identifier_name"] != System.DBNull.Value) ProductIdentifierName = (System.String) reader["product_identifier_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [product_identifier_ref] (product_identifier_rcd, product_identifier_name, user_id, date_time)";
            sql += "            values (@product_identifier_rcd, @product_identifier_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                    command.Parameters.Add("@product_identifier_name",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [product_identifier_ref] (product_identifier_rcd, product_identifier_name, user_id, date_time)";
            sql += "            values (@product_identifier_rcd, @product_identifier_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                command.Parameters.Add("@product_identifier_name",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_identifier_ref] set
                 product_identifier_rcd = @product_identifier_rcd
                ,product_identifier_name = @product_identifier_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_identifier_rcd = @product_identifier_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                    command.Parameters.Add("@product_identifier_name",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_identifier_ref] set
                 product_identifier_rcd = @product_identifier_rcd
                ,product_identifier_name = @product_identifier_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_identifier_rcd = @product_identifier_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                command.Parameters.Add("@product_identifier_name",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string productIdentifierRcd) {
            string sql = @" delete [product_identifier_ref] 
                where product_identifier_rcd = @product_identifier_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = productIdentifierRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
