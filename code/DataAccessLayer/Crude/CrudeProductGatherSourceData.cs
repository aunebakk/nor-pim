using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductGatherSourceData {
        
        public System.Guid ProductGatherSourceId { get; set; } //;
        
        public System.Guid ProductGatherId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public string ProductGatherSourceTypeRcd { get; set; } //;
        
        public void FetchByProductGatherSourceId(System.Guid productGatherSourceId) {
            string sql = @" select top 1 product_gather_source_id, product_gather_id, user_id, date_time, product_gather_source_type_rcd
                            from [product_gather_source]
                            where product_gather_source_id = @product_gather_source_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_gather_source_id",SqlDbType.UniqueIdentifier).Value = productGatherSourceId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductGatherSourceData> FetchByProductGatherId(System.Guid productGatherId) {
            var dataList = new List<CrudeProductGatherSourceData>();

            string sql = @" select product_gather_source_id, product_gather_id, user_id, date_time, product_gather_source_type_rcd
                            from [product_gather_source]
                            where product_gather_id = @product_gather_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_gather_id", SqlDbType.UniqueIdentifier).Value = productGatherId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherSourceData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductGatherSourceData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductGatherSourceData>();

            string sql = @" select product_gather_source_id, product_gather_id, user_id, date_time, product_gather_source_type_rcd
                            from [product_gather_source]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherSourceData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductGatherSourceData> FetchAll() {
            var dataList = new List<CrudeProductGatherSourceData>();

            string sql = @" select product_gather_source_id, product_gather_id, user_id, date_time, product_gather_source_type_rcd
                            from [product_gather_source]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherSourceData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductGatherSourceData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductGatherSourceData>();

            string sql = @" select top " + limit.ToString() + @" product_gather_source_id, product_gather_id, user_id, date_time, product_gather_source_type_rcd
                            from [product_gather_source]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherSourceData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductGatherSourceData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductGatherSourceData>();

            string sql = @" select product_gather_source_id, product_gather_id, user_id, date_time, product_gather_source_type_rcd
                            from [product_gather_source]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductGatherSourceData();
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
            string sql = @" select count(*) as count from [product_gather_source]";

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
        
        public List<CrudeProductGatherSourceData> FetchWithFilter(System.Guid productGatherSourceId, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime, string productGatherSourceTypeRcd) {
            var dataList = new List<CrudeProductGatherSourceData>();

            string sql = @" select product_gather_source_id, product_gather_id, user_id, date_time, product_gather_source_type_rcd
                            from [product_gather_source]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productGatherSourceId != Guid.Empty) {
                        sql += "  and product_gather_source_id = @product_gather_source_id";
                        command.Parameters.Add("@product_gather_source_id", SqlDbType.UniqueIdentifier).Value = productGatherSourceId;
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
                    if (productGatherSourceTypeRcd != "") {
                        sql += "  and product_gather_source_type_rcd like '%' + @product_gather_source_type_rcd + '%'";
                        command.Parameters.Add("@product_gather_source_type_rcd", SqlDbType.NVarChar).Value = productGatherSourceTypeRcd.Replace("'","''");
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherSourceData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_gather_source_id"] != System.DBNull.Value) ProductGatherSourceId = (System.Guid) reader["product_gather_source_id"];
            if (reader["product_gather_id"] != System.DBNull.Value) ProductGatherId = (System.Guid) reader["product_gather_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["product_gather_source_type_rcd"] != System.DBNull.Value) ProductGatherSourceTypeRcd = (System.String) reader["product_gather_source_type_rcd"];
        }
        
        public void Insert() {

            if (ProductGatherSourceId == Guid.Empty)
                ProductGatherSourceId = Guid.NewGuid();

            string sql = "insert into [product_gather_source] (product_gather_source_id, product_gather_id, user_id, date_time, product_gather_source_type_rcd)";
            sql += "            values (@product_gather_source_id, @product_gather_id, @user_id, @date_time, @product_gather_source_type_rcd)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_gather_source_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherSourceId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherSourceId);
                    command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherId);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.Parameters.Add("@product_gather_source_type_rcd",SqlDbType.NVarChar).Value = (ProductGatherSourceTypeRcd == null ? (object)DBNull.Value : (System.String)ProductGatherSourceTypeRcd);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductGatherSourceId == Guid.Empty)
                ProductGatherSourceId = Guid.NewGuid();

            string sql = "insert into [product_gather_source] (product_gather_source_id, product_gather_id, user_id, date_time, product_gather_source_type_rcd)";
            sql += "            values (@product_gather_source_id, @product_gather_id, @user_id, @date_time, @product_gather_source_type_rcd)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_gather_source_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherSourceId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherSourceId);
                command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherId);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.Parameters.Add("@product_gather_source_type_rcd",SqlDbType.NVarChar).Value = (ProductGatherSourceTypeRcd == null ? (object)DBNull.Value : (System.String)ProductGatherSourceTypeRcd);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_gather_source] set
                 product_gather_source_id = @product_gather_source_id
                ,product_gather_id = @product_gather_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,product_gather_source_type_rcd = @product_gather_source_type_rcd
            where product_gather_source_id = @product_gather_source_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_gather_source_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherSourceId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherSourceId);
                    command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherId);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.Parameters.Add("@product_gather_source_type_rcd",SqlDbType.NVarChar).Value = (ProductGatherSourceTypeRcd == null ? (object)DBNull.Value : (System.String)ProductGatherSourceTypeRcd);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_gather_source] set
                 product_gather_source_id = @product_gather_source_id
                ,product_gather_id = @product_gather_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,product_gather_source_type_rcd = @product_gather_source_type_rcd
            where product_gather_source_id = @product_gather_source_id";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_gather_source_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherSourceId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherSourceId);
                command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (ProductGatherId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductGatherId);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.Parameters.Add("@product_gather_source_type_rcd",SqlDbType.NVarChar).Value = (ProductGatherSourceTypeRcd == null ? (object)DBNull.Value : (System.String)ProductGatherSourceTypeRcd);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_gather_source] 
                where product_gather_source_id = @product_gather_source_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_gather_source_id",SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
