using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
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
                            where product_expose_set_id = @product_expose_set_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = productExposeSetId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductExposeSetData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductExposeSetData>();

            string sql = @" select product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time
                            from [product_expose_set]
                            where user_id = @user_id
                              ";

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
        
        public List<CrudeProductExposeSetData> FetchAll() {
            var dataList = new List<CrudeProductExposeSetData>();

            string sql = @" select product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time
                            from [product_expose_set]";

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
        
        public List<CrudeProductExposeSetData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductExposeSetData>();

            string sql = @" select top " + limit.ToString() + @" product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time
                            from [product_expose_set]";

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
        
        public List<CrudeProductExposeSetData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductExposeSetData>();

            string sql = @" select product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time
                            from [product_expose_set]";

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
        
        public int FetchAllCount() {
            string sql = @" select count(*) as count from [product_expose_set]";

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
        
        public List<CrudeProductExposeSetData> FetchWithFilter(System.Guid productExposeSetId, string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductExposeSetData>();

            string sql = @" select product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time
                            from [product_expose_set]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productExposeSetId != Guid.Empty) {
                        sql += "  and product_expose_set_id = @product_expose_set_id";
                        command.Parameters.Add("@product_expose_set_id", SqlDbType.UniqueIdentifier).Value = productExposeSetId;
                    }
                    if (productExposeSetTypeRcd != "") {
                        sql += "  and product_expose_set_type_rcd like '%' + @product_expose_set_type_rcd + '%'";
                        command.Parameters.Add("@product_expose_set_type_rcd", SqlDbType.NVarChar).Value = productExposeSetTypeRcd.Replace("'","''");
                    }
                    if (productExposeSetName != "") {
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

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = (ProductExposeSetId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductExposeSetId);
                    command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (ProductExposeSetTypeRcd == null ? (object)DBNull.Value : (System.String)ProductExposeSetTypeRcd);
                    command.Parameters.Add("@product_expose_set_name",SqlDbType.NVarChar).Value = (ProductExposeSetName == null ? (object)DBNull.Value : (System.String)ProductExposeSetName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductExposeSetId == Guid.Empty)
                ProductExposeSetId = Guid.NewGuid();

            string sql = "insert into [product_expose_set] (product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time)";
            sql += "            values (@product_expose_set_id, @product_expose_set_type_rcd, @product_expose_set_name, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = (ProductExposeSetId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductExposeSetId);
                command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (ProductExposeSetTypeRcd == null ? (object)DBNull.Value : (System.String)ProductExposeSetTypeRcd);
                command.Parameters.Add("@product_expose_set_name",SqlDbType.NVarChar).Value = (ProductExposeSetName == null ? (object)DBNull.Value : (System.String)ProductExposeSetName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
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

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = (ProductExposeSetId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductExposeSetId);
                    command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (ProductExposeSetTypeRcd == null ? (object)DBNull.Value : (System.String)ProductExposeSetTypeRcd);
                    command.Parameters.Add("@product_expose_set_name",SqlDbType.NVarChar).Value = (ProductExposeSetName == null ? (object)DBNull.Value : (System.String)ProductExposeSetName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
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

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = (ProductExposeSetId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductExposeSetId);
                command.Parameters.Add("@product_expose_set_type_rcd",SqlDbType.NVarChar).Value = (ProductExposeSetTypeRcd == null ? (object)DBNull.Value : (System.String)ProductExposeSetTypeRcd);
                command.Parameters.Add("@product_expose_set_name",SqlDbType.NVarChar).Value = (ProductExposeSetName == null ? (object)DBNull.Value : (System.String)ProductExposeSetName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_expose_set] 
                where product_expose_set_id = @product_expose_set_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
