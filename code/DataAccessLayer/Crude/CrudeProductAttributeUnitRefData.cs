using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    public partial class ProductAttributeUnitRef {
    }
    
    [Serializable()]
    public partial class CrudeProductAttributeUnitRefData {
        
        public string ProductAttributeUnitRcd { get; set; } //;
        
        public string ProductAttributeUnitName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductAttributeUnitRcd(string productAttributeUnitRcd) {
            string sql = @" select top 1 product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time
                            from [product_attribute_unit_ref]
                            where product_attribute_unit_rcd = @product_attribute_unit_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = productAttributeUnitRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductAttributeUnitRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductAttributeUnitRefData>();

            string sql = @" select product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time
                            from [product_attribute_unit_ref]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
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
        
        public List<CrudeProductAttributeUnitRefData> FetchAll() {
            var dataList = new List<CrudeProductAttributeUnitRefData>();

            string sql = @" select product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time
                            from [product_attribute_unit_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
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
        
        public List<CrudeProductAttributeUnitRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductAttributeUnitRefData>();

            string sql = @" select top " + limit.ToString() + @" product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time
                            from [product_attribute_unit_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
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
        
        public List<CrudeProductAttributeUnitRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductAttributeUnitRefData>();

            string sql = @" select product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time
                            from [product_attribute_unit_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
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
        
        public int FetchAllCount() {
            string sql = @" select count(*) as count from [product_attribute_unit_ref]";

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
        
        public List<CrudeProductAttributeUnitRefData> FetchWithFilter(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductAttributeUnitRefData>();

            string sql = @" select product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time
                            from [product_attribute_unit_ref]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productAttributeUnitRcd != "") {
                        sql += "  and product_attribute_unit_rcd like '%' + @product_attribute_unit_rcd + '%'";
                        command.Parameters.Add("@product_attribute_unit_rcd", SqlDbType.NVarChar).Value = productAttributeUnitRcd.Replace("'","''");
                    }
                    if (productAttributeUnitName != "") {
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

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = (ProductAttributeUnitRcd == null ? (object)DBNull.Value : (System.String)ProductAttributeUnitRcd);
                    command.Parameters.Add("@product_attribute_unit_name",SqlDbType.NVarChar).Value = (ProductAttributeUnitName == null ? (object)DBNull.Value : (System.String)ProductAttributeUnitName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [product_attribute_unit_ref] (product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time)";
            sql += "            values (@product_attribute_unit_rcd, @product_attribute_unit_name, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = (ProductAttributeUnitRcd == null ? (object)DBNull.Value : (System.String)ProductAttributeUnitRcd);
                command.Parameters.Add("@product_attribute_unit_name",SqlDbType.NVarChar).Value = (ProductAttributeUnitName == null ? (object)DBNull.Value : (System.String)ProductAttributeUnitName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
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

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = (ProductAttributeUnitRcd == null ? (object)DBNull.Value : (System.String)ProductAttributeUnitRcd);
                    command.Parameters.Add("@product_attribute_unit_name",SqlDbType.NVarChar).Value = (ProductAttributeUnitName == null ? (object)DBNull.Value : (System.String)ProductAttributeUnitName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
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

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = (ProductAttributeUnitRcd == null ? (object)DBNull.Value : (System.String)ProductAttributeUnitRcd);
                command.Parameters.Add("@product_attribute_unit_name",SqlDbType.NVarChar).Value = (ProductAttributeUnitName == null ? (object)DBNull.Value : (System.String)ProductAttributeUnitName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_attribute_unit_ref] 
                where product_attribute_unit_rcd = @product_attribute_unit_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_attribute_unit_rcd",SqlDbType.NVarChar).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
