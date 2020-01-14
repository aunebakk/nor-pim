/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:42:28 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductExposedSelectionData {
        
        public System.Guid ProductExposedSelectionId { get; set; } //;
        
        public System.Guid ProductExposeId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductExposedSelectionId(System.Guid productExposedSelectionId) {
            string sql = @" select top 1 product_exposed_selection_id, product_expose_id, user_id, date_time
                            from [product_exposed_selection]
                            where product_exposed_selection_id = @product_exposed_selection_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_exposed_selection_id",SqlDbType.UniqueIdentifier).Value = productExposedSelectionId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductExposedSelectionData GetByProductExposedSelectionId(System.Guid productExposedSelectionId) {
            string sql = @" select top 1 product_exposed_selection_id, product_expose_id, user_id, date_time
                            from [product_exposed_selection]
                            where product_exposed_selection_id = @product_exposed_selection_id";

            var ret = new CrudeProductExposedSelectionData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_exposed_selection_id",SqlDbType.UniqueIdentifier).Value = productExposedSelectionId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductExposedSelectionData> FetchByProductExposeId(System.Guid productExposeId) {
            var dataList = new List<CrudeProductExposedSelectionData>();

            string sql = @" select product_exposed_selection_id, product_expose_id, user_id, date_time
                            from [product_exposed_selection]
                            where product_expose_id = @product_expose_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_expose_id", SqlDbType.UniqueIdentifier).Value = productExposeId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposedSelectionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposedSelectionData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductExposedSelectionData>();

            string sql = @" select product_exposed_selection_id, product_expose_id, user_id, date_time
                            from [product_exposed_selection]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposedSelectionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposedSelectionData> FetchAll() {
            var dataList = new List<CrudeProductExposedSelectionData>();

            string sql = @" select product_exposed_selection_id, product_expose_id, user_id, date_time
                            from [product_exposed_selection]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposedSelectionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposedSelectionData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductExposedSelectionData>();

            string sql = @" select top " + limit.ToString() + @" product_exposed_selection_id, product_expose_id, user_id, date_time
                            from [product_exposed_selection]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposedSelectionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposedSelectionData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductExposedSelectionData>();

            string sql = @" select product_exposed_selection_id, product_expose_id, user_id, date_time
                            from [product_exposed_selection]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductExposedSelectionData();
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
            string sql = @" select count(*) as count from [product_exposed_selection]";

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
        
        public static List<CrudeProductExposedSelectionData> FetchWithFilter(System.Guid productExposedSelectionId, System.Guid productExposeId, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductExposedSelectionData>();

            string sql = @" select product_exposed_selection_id, product_expose_id, user_id, date_time
                            from [product_exposed_selection]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productExposedSelectionId != Guid.Empty) {
                        sql += "  and product_exposed_selection_id = @product_exposed_selection_id";
                        command.Parameters.Add("@product_exposed_selection_id", SqlDbType.UniqueIdentifier).Value = productExposedSelectionId;
                    }
                    if (productExposeId != Guid.Empty) {
                        sql += "  and product_expose_id = @product_expose_id";
                        command.Parameters.Add("@product_expose_id", SqlDbType.UniqueIdentifier).Value = productExposeId;
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
                        var data = new CrudeProductExposedSelectionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_exposed_selection_id"] != System.DBNull.Value) ProductExposedSelectionId = (System.Guid) reader["product_exposed_selection_id"];
            if (reader["product_expose_id"] != System.DBNull.Value) ProductExposeId = (System.Guid) reader["product_expose_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductExposedSelectionId == Guid.Empty)
                ProductExposedSelectionId = Guid.NewGuid();

            string sql = "insert into [product_exposed_selection] (product_exposed_selection_id, product_expose_id, user_id, date_time)";
            sql += "            values (@product_exposed_selection_id, @product_expose_id, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_exposed_selection_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposedSelectionId;
                    command.Parameters.Add("@product_expose_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductExposedSelectionId == Guid.Empty)
                ProductExposedSelectionId = Guid.NewGuid();

            string sql = "insert into [product_exposed_selection] (product_exposed_selection_id, product_expose_id, user_id, date_time)";
            sql += "            values (@product_exposed_selection_id, @product_expose_id, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_exposed_selection_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposedSelectionId;
                command.Parameters.Add("@product_expose_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_exposed_selection] set
                 product_exposed_selection_id = @product_exposed_selection_id
                ,product_expose_id = @product_expose_id
                ,user_id = @user_id
                ,date_time = @date_time
            where product_exposed_selection_id = @product_exposed_selection_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_exposed_selection_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposedSelectionId;
                    command.Parameters.Add("@product_expose_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_exposed_selection] set
                 product_exposed_selection_id = @product_exposed_selection_id
                ,product_expose_id = @product_expose_id
                ,user_id = @user_id
                ,date_time = @date_time
            where product_exposed_selection_id = @product_exposed_selection_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_exposed_selection_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposedSelectionId;
                command.Parameters.Add("@product_expose_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid productExposedSelectionId) {
            string sql = @" delete [product_exposed_selection] 
                where product_exposed_selection_id = @product_exposed_selection_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_exposed_selection_id",SqlDbType.UniqueIdentifier).Value = productExposedSelectionId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
