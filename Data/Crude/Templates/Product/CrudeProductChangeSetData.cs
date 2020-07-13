/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 10:52:44 AM
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
    public partial class CrudeProductChangeSetData {
        
        public System.Guid ProductChangeSetId { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public System.Guid ProductGatherKeyId { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public void FetchByProductChangeSetId(System.Guid productChangeSetId) {
            string sql = @" select top 1 product_change_set_id, product_id, product_gather_key_id, user_id, date_time
                            from [product_change_set]
                            where product_change_set_id = @product_change_set_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_change_set_id",SqlDbType.UniqueIdentifier).Value = productChangeSetId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductChangeSetData GetByProductChangeSetId(System.Guid productChangeSetId) {
            string sql = @" select top 1 product_change_set_id, product_id, product_gather_key_id, user_id, date_time
                            from [product_change_set]
                            where product_change_set_id = @product_change_set_id";

            var ret = new CrudeProductChangeSetData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_change_set_id",SqlDbType.UniqueIdentifier).Value = productChangeSetId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductChangeSetData> FetchByProductId(System.Guid productId) {
            var dataList = new List<CrudeProductChangeSetData>();

            string sql = @" select product_change_set_id, product_id, product_gather_key_id, user_id, date_time
                            from [product_change_set]
                            where product_id = @product_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductChangeSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductChangeSetData> FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            var dataList = new List<CrudeProductChangeSetData>();

            string sql = @" select product_change_set_id, product_id, product_gather_key_id, user_id, date_time
                            from [product_change_set]
                            where product_gather_key_id = @product_gather_key_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_gather_key_id", SqlDbType.UniqueIdentifier).Value = productGatherKeyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductChangeSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductChangeSetData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductChangeSetData>();

            string sql = @" select product_change_set_id, product_id, product_gather_key_id, user_id, date_time
                            from [product_change_set]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductChangeSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductChangeSetData> FetchAll() {
            var dataList = new List<CrudeProductChangeSetData>();

            string sql = @" select product_change_set_id, product_id, product_gather_key_id, user_id, date_time
                            from [product_change_set]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductChangeSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductChangeSetData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductChangeSetData>();

            string sql = @" select top " + limit.ToString() + @" product_change_set_id, product_id, product_gather_key_id, user_id, date_time
                            from [product_change_set]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductChangeSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductChangeSetData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductChangeSetData>();

            string sql = @" select product_change_set_id, product_id, product_gather_key_id, user_id, date_time
                            from [product_change_set]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductChangeSetData();
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
            string sql = @" select count(*) as count from [product_change_set]";

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
        
        public static List<CrudeProductChangeSetData> FetchWithFilter(System.Guid productChangeSetId, System.Guid productId, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductChangeSetData>();

            string sql = @" select product_change_set_id, product_id, product_gather_key_id, user_id, date_time
                            from [product_change_set]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productChangeSetId != Guid.Empty) {
                        sql += "  and product_change_set_id = @product_change_set_id";
                        command.Parameters.Add("@product_change_set_id", SqlDbType.UniqueIdentifier).Value = productChangeSetId;
                    }
                    if (productId != Guid.Empty) {
                        sql += "  and product_id = @product_id";
                        command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;
                    }
                    if (productGatherKeyId != Guid.Empty) {
                        sql += "  and product_gather_key_id = @product_gather_key_id";
                        command.Parameters.Add("@product_gather_key_id", SqlDbType.UniqueIdentifier).Value = productGatherKeyId;
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
                        var data = new CrudeProductChangeSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_change_set_id"] != System.DBNull.Value) ProductChangeSetId = (System.Guid) reader["product_change_set_id"];
            if (reader["product_id"] != System.DBNull.Value) ProductId = (System.Guid) reader["product_id"];
            if (reader["product_gather_key_id"] != System.DBNull.Value) ProductGatherKeyId = (System.Guid) reader["product_gather_key_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductChangeSetId == Guid.Empty)
                ProductChangeSetId = Guid.NewGuid();

            string sql = "insert into [product_change_set] (product_change_set_id, product_id, product_gather_key_id, user_id, date_time)";
            sql += "            values (@product_change_set_id, @product_id, @product_gather_key_id, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_change_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductChangeSetId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherKeyId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductChangeSetId == Guid.Empty)
                ProductChangeSetId = Guid.NewGuid();

            string sql = "insert into [product_change_set] (product_change_set_id, product_id, product_gather_key_id, user_id, date_time)";
            sql += "            values (@product_change_set_id, @product_id, @product_gather_key_id, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_change_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductChangeSetId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherKeyId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_change_set] set
                 product_change_set_id = @product_change_set_id
                ,product_id = @product_id
                ,product_gather_key_id = @product_gather_key_id
                ,user_id = @user_id
                ,date_time = @date_time
            where product_change_set_id = @product_change_set_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_change_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductChangeSetId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherKeyId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_change_set] set
                 product_change_set_id = @product_change_set_id
                ,product_id = @product_id
                ,product_gather_key_id = @product_gather_key_id
                ,user_id = @user_id
                ,date_time = @date_time
            where product_change_set_id = @product_change_set_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_change_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductChangeSetId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherKeyId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid productChangeSetId) {
            string sql = @" delete [product_change_set] 
                where product_change_set_id = @product_change_set_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_change_set_id",SqlDbType.UniqueIdentifier).Value = productChangeSetId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
