using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    public partial class ProductInformationSourceTypeRef {
        
        public static string BasicProductIdentificationAndAttributes = "BPIA";
        
        public static string ProductSupplier = "PS";
        
        public static string AdditionalProductAttributes = "PAA";
        
        public static string TSQLScript = "tsql";
    }
    
    [Serializable()]
    public partial class CrudeProductInformationSourceTypeRefData {
        
        public string ProductInformationSourceTypeRcd { get; set; } //;
        
        public string ProductInformationSourceTypeName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductInformationSourceTypeRcd(string productInformationSourceTypeRcd) {
            string sql = @" select top 1 product_information_source_type_rcd, product_information_source_type_name, user_id, date_time
                            from [product_information_source_type_ref]
                            where product_information_source_type_rcd = @product_information_source_type_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_information_source_type_rcd",SqlDbType.NVarChar).Value = productInformationSourceTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductInformationSourceTypeRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductInformationSourceTypeRefData>();

            string sql = @" select product_information_source_type_rcd, product_information_source_type_name, user_id, date_time
                            from [product_information_source_type_ref]
                            where user_id = @user_id";
                              

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductInformationSourceTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductInformationSourceTypeRefData> FetchAll() {
            var dataList = new List<CrudeProductInformationSourceTypeRefData>();

            string sql = @" select product_information_source_type_rcd, product_information_source_type_name, user_id, date_time
                            from [product_information_source_type_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductInformationSourceTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductInformationSourceTypeRefData> FetchWithFilter(string productInformationSourceTypeRcd, string productInformationSourceTypeName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductInformationSourceTypeRefData>();

            string sql = @" select product_information_source_type_rcd, product_information_source_type_name, user_id, date_time
                            from [product_information_source_type_ref]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productInformationSourceTypeRcd != "") {
                        sql += "  and product_information_source_type_rcd like '%' + @product_information_source_type_rcd + '%'";
                        command.Parameters.Add("@product_information_source_type_rcd", SqlDbType.NVarChar).Value = productInformationSourceTypeRcd.Replace("'","''");
                    }
                    if (productInformationSourceTypeName != "") {
                        sql += "  and product_information_source_type_name like '%' + @product_information_source_type_name + '%'";
                        command.Parameters.Add("@product_information_source_type_name", SqlDbType.NVarChar).Value = productInformationSourceTypeName.Replace("'","''");
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
                        var data = new CrudeProductInformationSourceTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_information_source_type_rcd"] != System.DBNull.Value) ProductInformationSourceTypeRcd = (System.String) reader["product_information_source_type_rcd"];
            if (reader["product_information_source_type_name"] != System.DBNull.Value) ProductInformationSourceTypeName = (System.String) reader["product_information_source_type_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [product_information_source_type_ref] (product_information_source_type_rcd, product_information_source_type_name, user_id, date_time)";
            sql += "            values (@product_information_source_type_rcd, @product_information_source_type_name, @user_id, @date_time)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_information_source_type_rcd",SqlDbType.NVarChar).Value = (ProductInformationSourceTypeRcd == null ? (object)DBNull.Value : (System.String)ProductInformationSourceTypeRcd);
                    command.Parameters.Add("@product_information_source_type_name",SqlDbType.NVarChar).Value = (ProductInformationSourceTypeName == null ? (object)DBNull.Value : (System.String)ProductInformationSourceTypeName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [product_information_source_type_ref] (product_information_source_type_rcd, product_information_source_type_name, user_id, date_time)";
            sql += "            values (@product_information_source_type_rcd, @product_information_source_type_name, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_information_source_type_rcd",SqlDbType.NVarChar).Value = (ProductInformationSourceTypeRcd == null ? (object)DBNull.Value : (System.String)ProductInformationSourceTypeRcd);
                command.Parameters.Add("@product_information_source_type_name",SqlDbType.NVarChar).Value = (ProductInformationSourceTypeName == null ? (object)DBNull.Value : (System.String)ProductInformationSourceTypeName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_information_source_type_ref] set
                 product_information_source_type_rcd = @product_information_source_type_rcd
                ,product_information_source_type_name = @product_information_source_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_information_source_type_rcd = @product_information_source_type_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_information_source_type_rcd",SqlDbType.NVarChar).Value = (ProductInformationSourceTypeRcd == null ? (object)DBNull.Value : (System.String)ProductInformationSourceTypeRcd);
                    command.Parameters.Add("@product_information_source_type_name",SqlDbType.NVarChar).Value = (ProductInformationSourceTypeName == null ? (object)DBNull.Value : (System.String)ProductInformationSourceTypeName);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_information_source_type_ref] set
                 product_information_source_type_rcd = @product_information_source_type_rcd
                ,product_information_source_type_name = @product_information_source_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_information_source_type_rcd = @product_information_source_type_rcd";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_information_source_type_rcd",SqlDbType.NVarChar).Value = (ProductInformationSourceTypeRcd == null ? (object)DBNull.Value : (System.String)ProductInformationSourceTypeRcd);
                command.Parameters.Add("@product_information_source_type_name",SqlDbType.NVarChar).Value = (ProductInformationSourceTypeName == null ? (object)DBNull.Value : (System.String)ProductInformationSourceTypeName);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_information_source_type_ref] 
                where product_information_source_type_rcd = @product_information_source_type_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_information_source_type_rcd",SqlDbType.NVarChar).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
