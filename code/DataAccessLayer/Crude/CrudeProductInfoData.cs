using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductInfoData {
        
        public System.Guid ProductInfoId { get; set; } //;
        
        public System.Guid ProductId { get; set; } //;
        
        public string ProductInfoRcd { get; set; } //;
        
        public string ProductInfoValue { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductInfoId(System.Guid productInfoId) {
            string sql = @" select top 1 product_info_id, product_id, product_info_rcd, product_info_value, user_id, date_time
                            from [product_info]
                            where product_info_id = @product_info_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_info_id",SqlDbType.UniqueIdentifier).Value = productInfoId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductInfoData> FetchByProductId(System.Guid productId) {
            var dataList = new List<CrudeProductInfoData>();

            string sql = @" select product_info_id, product_id, product_info_rcd, product_info_value, user_id, date_time
                            from [product_info]
                            where product_id = @product_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductInfoData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductInfoData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductInfoData>();

            string sql = @" select product_info_id, product_id, product_info_rcd, product_info_value, user_id, date_time
                            from [product_info]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductInfoData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductInfoData> FetchAll() {
            var dataList = new List<CrudeProductInfoData>();

            string sql = @" select product_info_id, product_id, product_info_rcd, product_info_value, user_id, date_time
                            from [product_info]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductInfoData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductInfoData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductInfoData>();

            string sql = @" select top " + limit.ToString() + @" product_info_id, product_id, product_info_rcd, product_info_value, user_id, date_time
                            from [product_info]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductInfoData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductInfoData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductInfoData>();

            string sql = @" select product_info_id, product_id, product_info_rcd, product_info_value, user_id, date_time
                            from [product_info]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductInfoData();
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
            string sql = @" select count(*) as count from [product_info]";

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
        
        public List<CrudeProductInfoData> FetchWithFilter(System.Guid productInfoId, System.Guid productId, string productInfoRcd, string productInfoValue, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductInfoData>();

            string sql = @" select product_info_id, product_id, product_info_rcd, product_info_value, user_id, date_time
                            from [product_info]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productInfoId != Guid.Empty) {
                        sql += "  and product_info_id = @product_info_id";
                        command.Parameters.Add("@product_info_id", SqlDbType.UniqueIdentifier).Value = productInfoId;
                    }
                    if (productId != Guid.Empty) {
                        sql += "  and product_id = @product_id";
                        command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;
                    }
                    if (productInfoRcd != "") {
                        sql += "  and product_info_rcd like '%' + @product_info_rcd + '%'";
                        command.Parameters.Add("@product_info_rcd", SqlDbType.NVarChar).Value = productInfoRcd.Replace("'","''");
                    }
                    if (productInfoValue != "") {
                        sql += "  and product_info_value like '%' + @product_info_value + '%'";
                        command.Parameters.Add("@product_info_value", SqlDbType.NVarChar).Value = productInfoValue.Replace("'","''");
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
                        var data = new CrudeProductInfoData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_info_id"] != System.DBNull.Value) ProductInfoId = (System.Guid) reader["product_info_id"];
            if (reader["product_id"] != System.DBNull.Value) ProductId = (System.Guid) reader["product_id"];
            if (reader["product_info_rcd"] != System.DBNull.Value) ProductInfoRcd = (System.String) reader["product_info_rcd"];
            if (reader["product_info_value"] != System.DBNull.Value) ProductInfoValue = (System.String) reader["product_info_value"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductInfoId == Guid.Empty)
                ProductInfoId = Guid.NewGuid();

            string sql = "insert into [product_info] (product_info_id, product_id, product_info_rcd, product_info_value, user_id, date_time)";
            sql += "            values (@product_info_id, @product_id, @product_info_rcd, @product_info_value, @user_id, @date_time)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_info_id",SqlDbType.UniqueIdentifier).Value = (ProductInfoId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductInfoId);
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (ProductInfoRcd == null ? (object)DBNull.Value : (System.String)ProductInfoRcd);
                    command.Parameters.Add("@product_info_value",SqlDbType.NVarChar).Value = (ProductInfoValue == null ? (object)DBNull.Value : (System.String)ProductInfoValue);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductInfoId == Guid.Empty)
                ProductInfoId = Guid.NewGuid();

            string sql = "insert into [product_info] (product_info_id, product_id, product_info_rcd, product_info_value, user_id, date_time)";
            sql += "            values (@product_info_id, @product_id, @product_info_rcd, @product_info_value, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_info_id",SqlDbType.UniqueIdentifier).Value = (ProductInfoId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductInfoId);
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (ProductInfoRcd == null ? (object)DBNull.Value : (System.String)ProductInfoRcd);
                command.Parameters.Add("@product_info_value",SqlDbType.NVarChar).Value = (ProductInfoValue == null ? (object)DBNull.Value : (System.String)ProductInfoValue);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_info] set
                 product_info_id = @product_info_id
                ,product_id = @product_id
                ,product_info_rcd = @product_info_rcd
                ,product_info_value = @product_info_value
                ,user_id = @user_id
                ,date_time = @date_time
            where product_info_id = @product_info_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_info_id",SqlDbType.UniqueIdentifier).Value = (ProductInfoId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductInfoId);
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (ProductInfoRcd == null ? (object)DBNull.Value : (System.String)ProductInfoRcd);
                    command.Parameters.Add("@product_info_value",SqlDbType.NVarChar).Value = (ProductInfoValue == null ? (object)DBNull.Value : (System.String)ProductInfoValue);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_info] set
                 product_info_id = @product_info_id
                ,product_id = @product_id
                ,product_info_rcd = @product_info_rcd
                ,product_info_value = @product_info_value
                ,user_id = @user_id
                ,date_time = @date_time
            where product_info_id = @product_info_id";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_info_id",SqlDbType.UniqueIdentifier).Value = (ProductInfoId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductInfoId);
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (ProductId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductId);
                command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (ProductInfoRcd == null ? (object)DBNull.Value : (System.String)ProductInfoRcd);
                command.Parameters.Add("@product_info_value",SqlDbType.NVarChar).Value = (ProductInfoValue == null ? (object)DBNull.Value : (System.String)ProductInfoValue);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_info] 
                where product_info_id = @product_info_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_info_id",SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
