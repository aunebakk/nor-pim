using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    public partial class ProductInfoRef {
    }
    
    [Serializable()]
    public partial class CrudeProductInfoRefData {
        
        public string ProductInfoRcd { get; set; } //;
        
        public string ProductInfoName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductInfoRcd(string productInfoRcd) {
            string sql = @" select top 1 product_info_rcd, product_info_name, user_id, date_time
                            from [product_info_ref]
                            where product_info_rcd = @product_info_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = productInfoRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductInfoRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductInfoRefData>();

            string sql = @" select product_info_rcd, product_info_name, user_id, date_time
                            from [product_info_ref]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
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
        
        public List<CrudeProductInfoRefData> FetchAll() {
            var dataList = new List<CrudeProductInfoRefData>();

            string sql = @" select product_info_rcd, product_info_name, user_id, date_time
                            from [product_info_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
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
        
        public List<CrudeProductInfoRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductInfoRefData>();

            string sql = @" select top " + limit.ToString() + @" product_info_rcd, product_info_name, user_id, date_time
                            from [product_info_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
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
        
        public List<CrudeProductInfoRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductInfoRefData>();

            string sql = @" select product_info_rcd, product_info_name, user_id, date_time
                            from [product_info_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
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
        
        public int FetchAllCount() {
            string sql = @" select count(*) as count from [product_info_ref]";

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
        
        public List<CrudeProductInfoRefData> FetchWithFilter(string productInfoRcd, string productInfoName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductInfoRefData>();

            string sql = @" select product_info_rcd, product_info_name, user_id, date_time
                            from [product_info_ref]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productInfoRcd != "") {
                        sql += "  and product_info_rcd like '%' + @product_info_rcd + '%'";
                        command.Parameters.Add("@product_info_rcd", SqlDbType.NVarChar).Value = productInfoRcd.Replace("'","''");
                    }
                    if (productInfoName != "") {
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

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (ProductInfoRcd == null ? (object)DBNull.Value : (System.String)ProductInfoRcd);
                    command.Parameters.Add("@product_info_name",SqlDbType.NVarChar).Value = (ProductInfoName == null ? (object)DBNull.Value : (System.String)ProductInfoName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [product_info_ref] (product_info_rcd, product_info_name, user_id, date_time)";
            sql += "            values (@product_info_rcd, @product_info_name, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (ProductInfoRcd == null ? (object)DBNull.Value : (System.String)ProductInfoRcd);
                command.Parameters.Add("@product_info_name",SqlDbType.NVarChar).Value = (ProductInfoName == null ? (object)DBNull.Value : (System.String)ProductInfoName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
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

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (ProductInfoRcd == null ? (object)DBNull.Value : (System.String)ProductInfoRcd);
                    command.Parameters.Add("@product_info_name",SqlDbType.NVarChar).Value = (ProductInfoName == null ? (object)DBNull.Value : (System.String)ProductInfoName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
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

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (ProductInfoRcd == null ? (object)DBNull.Value : (System.String)ProductInfoRcd);
                command.Parameters.Add("@product_info_name",SqlDbType.NVarChar).Value = (ProductInfoName == null ? (object)DBNull.Value : (System.String)ProductInfoName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_info_ref] 
                where product_info_rcd = @product_info_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
