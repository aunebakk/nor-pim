using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductGatherKeyData {
        
        public System.Guid ProductGatherKeyId { get; set; } //;
        
        public string ProductGatherKeyValue { get; set; } //;
        
        public System.Guid ProductGatherId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            string sql = @" select top 1 product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time
                            from [product_gather_key]
                            where product_gather_key_id = @product_gather_key_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = productGatherKeyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductGatherKeyData> FetchByProductGatherId(System.Guid productGatherId) {
            var dataList = new List<CrudeProductGatherKeyData>();

            string sql = @" select product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time
                            from [product_gather_key]
                            where product_gather_id = @product_gather_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_gather_id", SqlDbType.UniqueIdentifier).Value = productGatherId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherKeyData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductGatherKeyData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductGatherKeyData>();

            string sql = @" select product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time
                            from [product_gather_key]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherKeyData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductGatherKeyData> FetchAll() {
            var dataList = new List<CrudeProductGatherKeyData>();

            string sql = @" select product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time
                            from [product_gather_key]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherKeyData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductGatherKeyData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductGatherKeyData>();

            string sql = @" select top " + limit.ToString() + @" product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time
                            from [product_gather_key]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherKeyData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductGatherKeyData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductGatherKeyData>();

            string sql = @" select product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time
                            from [product_gather_key]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductGatherKeyData();
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
        
        public int FetchAllCount() {
            string sql = @" select count(*) as count from [product_gather_key]";

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
        
        public List<CrudeProductGatherKeyData> FetchWithFilter(System.Guid productGatherKeyId, string productGatherKeyValue, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductGatherKeyData>();

            string sql = @" select product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time
                            from [product_gather_key]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productGatherKeyId != Guid.Empty) {
                        sql += "  and product_gather_key_id = @product_gather_key_id";
                        command.Parameters.Add("@product_gather_key_id", SqlDbType.UniqueIdentifier).Value = productGatherKeyId;
                    }
                    if (productGatherKeyValue != "") {
                        sql += "  and product_gather_key_value like '%' + @product_gather_key_value + '%'";
                        command.Parameters.Add("@product_gather_key_value", SqlDbType.NVarChar).Value = productGatherKeyValue.Replace("'","''");
                    }
                    if (productGatherId != Guid.Empty) {
                        sql += "  and product_gather_id = @product_gather_id";
                        command.Parameters.Add("@product_gather_id", SqlDbType.UniqueIdentifier).Value = productGatherId;
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
                        var data = new CrudeProductGatherKeyData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_gather_key_id"] != System.DBNull.Value) ProductGatherKeyId = (System.Guid) reader["product_gather_key_id"];
            if (reader["product_gather_key_value"] != System.DBNull.Value) ProductGatherKeyValue = (System.String) reader["product_gather_key_value"];
            if (reader["product_gather_id"] != System.DBNull.Value) ProductGatherId = (System.Guid) reader["product_gather_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductGatherKeyId == Guid.Empty)
                ProductGatherKeyId = Guid.NewGuid();

            string sql = "insert into [product_gather_key] (product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time)";
            sql += "            values (@product_gather_key_id, @product_gather_key_value, @product_gather_id, @user_id, @date_time)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherKeyId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherKeyId);
                    command.Parameters.Add("@product_gather_key_value",SqlDbType.NVarChar).Value = (ProductGatherKeyValue == null ? (object)DBNull.Value : (System.String)ProductGatherKeyValue);
                    command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherId);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductGatherKeyId == Guid.Empty)
                ProductGatherKeyId = Guid.NewGuid();

            string sql = "insert into [product_gather_key] (product_gather_key_id, product_gather_key_value, product_gather_id, user_id, date_time)";
            sql += "            values (@product_gather_key_id, @product_gather_key_value, @product_gather_id, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherKeyId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherKeyId);
                command.Parameters.Add("@product_gather_key_value",SqlDbType.NVarChar).Value = (ProductGatherKeyValue == null ? (object)DBNull.Value : (System.String)ProductGatherKeyValue);
                command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherId);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_gather_key] set
                 product_gather_key_id = @product_gather_key_id
                ,product_gather_key_value = @product_gather_key_value
                ,product_gather_id = @product_gather_id
                ,user_id = @user_id
                ,date_time = @date_time
            where product_gather_key_id = @product_gather_key_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherKeyId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherKeyId);
                    command.Parameters.Add("@product_gather_key_value",SqlDbType.NVarChar).Value = (ProductGatherKeyValue == null ? (object)DBNull.Value : (System.String)ProductGatherKeyValue);
                    command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherId);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_gather_key] set
                 product_gather_key_id = @product_gather_key_id
                ,product_gather_key_value = @product_gather_key_value
                ,product_gather_id = @product_gather_id
                ,user_id = @user_id
                ,date_time = @date_time
            where product_gather_key_id = @product_gather_key_id";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherKeyId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherKeyId);
                command.Parameters.Add("@product_gather_key_value",SqlDbType.NVarChar).Value = (ProductGatherKeyValue == null ? (object)DBNull.Value : (System.String)ProductGatherKeyValue);
                command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherId);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_gather_key] 
                where product_gather_key_id = @product_gather_key_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_gather_key_id",SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
