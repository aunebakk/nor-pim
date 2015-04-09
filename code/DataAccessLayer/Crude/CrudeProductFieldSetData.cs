using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductFieldSetData {
        
        public System.Guid ProductFieldSetId { get; set; } //;
        
        public string ProductFieldSetName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductFieldSetId(System.Guid productFieldSetId) {
            string sql = @" select top 1 product_field_set_id, product_field_set_name, user_id, date_time
                            from [product_field_set]
                            where product_field_set_id = @product_field_set_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = productFieldSetId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductFieldSetData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductFieldSetData>();

            string sql = @" select product_field_set_id, product_field_set_name, user_id, date_time
                            from [product_field_set]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductFieldSetData> FetchAll() {
            var dataList = new List<CrudeProductFieldSetData>();

            string sql = @" select product_field_set_id, product_field_set_name, user_id, date_time
                            from [product_field_set]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductFieldSetData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductFieldSetData>();

            string sql = @" select top " + limit.ToString() + @" product_field_set_id, product_field_set_name, user_id, date_time
                            from [product_field_set]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductFieldSetData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductFieldSetData>();

            string sql = @" select product_field_set_id, product_field_set_name, user_id, date_time
                            from [product_field_set]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductFieldSetData();
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
            string sql = @" select count(*) as count from [product_field_set]";

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
        
        public List<CrudeProductFieldSetData> FetchWithFilter(System.Guid productFieldSetId, string productFieldSetName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductFieldSetData>();

            string sql = @" select product_field_set_id, product_field_set_name, user_id, date_time
                            from [product_field_set]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productFieldSetId != Guid.Empty) {
                        sql += "  and product_field_set_id = @product_field_set_id";
                        command.Parameters.Add("@product_field_set_id", SqlDbType.UniqueIdentifier).Value = productFieldSetId;
                    }
                    if (productFieldSetName != "") {
                        sql += "  and product_field_set_name like '%' + @product_field_set_name + '%'";
                        command.Parameters.Add("@product_field_set_name", SqlDbType.NVarChar).Value = productFieldSetName.Replace("'","''");
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
                        var data = new CrudeProductFieldSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_field_set_id"] != System.DBNull.Value) ProductFieldSetId = (System.Guid) reader["product_field_set_id"];
            if (reader["product_field_set_name"] != System.DBNull.Value) ProductFieldSetName = (System.String) reader["product_field_set_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductFieldSetId == Guid.Empty)
                ProductFieldSetId = Guid.NewGuid();

            string sql = "insert into [product_field_set] (product_field_set_id, product_field_set_name, user_id, date_time)";
            sql += "            values (@product_field_set_id, @product_field_set_name, @user_id, @date_time)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (ProductFieldSetId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductFieldSetId);
                    command.Parameters.Add("@product_field_set_name",SqlDbType.NVarChar).Value = (ProductFieldSetName == null ? (object)DBNull.Value : (System.String)ProductFieldSetName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductFieldSetId == Guid.Empty)
                ProductFieldSetId = Guid.NewGuid();

            string sql = "insert into [product_field_set] (product_field_set_id, product_field_set_name, user_id, date_time)";
            sql += "            values (@product_field_set_id, @product_field_set_name, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (ProductFieldSetId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductFieldSetId);
                command.Parameters.Add("@product_field_set_name",SqlDbType.NVarChar).Value = (ProductFieldSetName == null ? (object)DBNull.Value : (System.String)ProductFieldSetName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_field_set] set
                 product_field_set_id = @product_field_set_id
                ,product_field_set_name = @product_field_set_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_field_set_id = @product_field_set_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (ProductFieldSetId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductFieldSetId);
                    command.Parameters.Add("@product_field_set_name",SqlDbType.NVarChar).Value = (ProductFieldSetName == null ? (object)DBNull.Value : (System.String)ProductFieldSetName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_field_set] set
                 product_field_set_id = @product_field_set_id
                ,product_field_set_name = @product_field_set_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_field_set_id = @product_field_set_id";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (ProductFieldSetId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductFieldSetId);
                command.Parameters.Add("@product_field_set_name",SqlDbType.NVarChar).Value = (ProductFieldSetName == null ? (object)DBNull.Value : (System.String)ProductFieldSetName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_field_set] 
                where product_field_set_id = @product_field_set_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
