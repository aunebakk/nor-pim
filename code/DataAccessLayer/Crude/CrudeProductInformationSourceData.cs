using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductInformationSourceData {
        
        public System.Guid ProductInformationSourceId { get; set; } //;
        
        public string ProductInformationSourceTypeRcd { get; set; } //;
        
        public string ProductInformationSource { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductInformationSourceId(System.Guid productInformationSourceId) {
            string sql = @" select top 1 product_information_source_id, product_information_source_type_rcd, product_information_source, user_id, date_time
                            from [product_information_source]
                            where product_information_source_id = @product_information_source_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_information_source_id",SqlDbType.UniqueIdentifier).Value = productInformationSourceId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductInformationSourceData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductInformationSourceData>();

            string sql = @" select product_information_source_id, product_information_source_type_rcd, product_information_source, user_id, date_time
                            from [product_information_source]
                            where user_id = @user_id";
                              

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductInformationSourceData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductInformationSourceData> FetchAll() {
            var dataList = new List<CrudeProductInformationSourceData>();

            string sql = @" select product_information_source_id, product_information_source_type_rcd, product_information_source, user_id, date_time
                            from [product_information_source]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductInformationSourceData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductInformationSourceData> FetchWithFilter(System.Guid productInformationSourceId, string productInformationSourceTypeRcd, string productInformationSource, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductInformationSourceData>();

            string sql = @" select product_information_source_id, product_information_source_type_rcd, product_information_source, user_id, date_time
                            from [product_information_source]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productInformationSourceId != Guid.Empty) {
                        sql += "  and product_information_source_id = @product_information_source_id";
                        command.Parameters.Add("@product_information_source_id", SqlDbType.UniqueIdentifier).Value = productInformationSourceId;
                    }
                    if (productInformationSourceTypeRcd != "") {
                        sql += "  and product_information_source_type_rcd like '%' + @product_information_source_type_rcd + '%'";
                        command.Parameters.Add("@product_information_source_type_rcd", SqlDbType.NVarChar).Value = productInformationSourceTypeRcd.Replace("'","''");
                    }
                    if (productInformationSource != "") {
                        sql += "  and product_information_source like '%' + @product_information_source + '%'";
                        command.Parameters.Add("@product_information_source", SqlDbType.NVarChar).Value = productInformationSource.Replace("'","''");
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
                        var data = new CrudeProductInformationSourceData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_information_source_id"] != System.DBNull.Value) ProductInformationSourceId = (System.Guid) reader["product_information_source_id"];
            if (reader["product_information_source_type_rcd"] != System.DBNull.Value) ProductInformationSourceTypeRcd = (System.String) reader["product_information_source_type_rcd"];
            if (reader["product_information_source"] != System.DBNull.Value) ProductInformationSource = (System.String) reader["product_information_source"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductInformationSourceId == Guid.Empty)
                ProductInformationSourceId = Guid.NewGuid();

            string sql = "insert into [product_information_source] (product_information_source_id, product_information_source_type_rcd, product_information_source, user_id, date_time)";
            sql += "            values (@product_information_source_id, @product_information_source_type_rcd, @product_information_source, @user_id, @date_time)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_information_source_id",SqlDbType.UniqueIdentifier).Value = (ProductInformationSourceId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductInformationSourceId);
                    command.Parameters.Add("@product_information_source_type_rcd",SqlDbType.NVarChar).Value = (ProductInformationSourceTypeRcd == null ? (object)DBNull.Value : (System.String)ProductInformationSourceTypeRcd);
                    command.Parameters.Add("@product_information_source",SqlDbType.NVarChar).Value = (ProductInformationSource == null ? (object)DBNull.Value : (System.String)ProductInformationSource);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductInformationSourceId == Guid.Empty)
                ProductInformationSourceId = Guid.NewGuid();

            string sql = "insert into [product_information_source] (product_information_source_id, product_information_source_type_rcd, product_information_source, user_id, date_time)";
            sql += "            values (@product_information_source_id, @product_information_source_type_rcd, @product_information_source, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_information_source_id",SqlDbType.UniqueIdentifier).Value = (ProductInformationSourceId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductInformationSourceId);
                command.Parameters.Add("@product_information_source_type_rcd",SqlDbType.NVarChar).Value = (ProductInformationSourceTypeRcd == null ? (object)DBNull.Value : (System.String)ProductInformationSourceTypeRcd);
                command.Parameters.Add("@product_information_source",SqlDbType.NVarChar).Value = (ProductInformationSource == null ? (object)DBNull.Value : (System.String)ProductInformationSource);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_information_source] set
                 product_information_source_id = @product_information_source_id
                ,product_information_source_type_rcd = @product_information_source_type_rcd
                ,product_information_source = @product_information_source
                ,user_id = @user_id
                ,date_time = @date_time
            where product_information_source_id = @product_information_source_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_information_source_id",SqlDbType.UniqueIdentifier).Value = (ProductInformationSourceId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductInformationSourceId);
                    command.Parameters.Add("@product_information_source_type_rcd",SqlDbType.NVarChar).Value = (ProductInformationSourceTypeRcd == null ? (object)DBNull.Value : (System.String)ProductInformationSourceTypeRcd);
                    command.Parameters.Add("@product_information_source",SqlDbType.NVarChar).Value = (ProductInformationSource == null ? (object)DBNull.Value : (System.String)ProductInformationSource);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_information_source] set
                 product_information_source_id = @product_information_source_id
                ,product_information_source_type_rcd = @product_information_source_type_rcd
                ,product_information_source = @product_information_source
                ,user_id = @user_id
                ,date_time = @date_time
            where product_information_source_id = @product_information_source_id";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_information_source_id",SqlDbType.UniqueIdentifier).Value = (ProductInformationSourceId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductInformationSourceId);
                command.Parameters.Add("@product_information_source_type_rcd",SqlDbType.NVarChar).Value = (ProductInformationSourceTypeRcd == null ? (object)DBNull.Value : (System.String)ProductInformationSourceTypeRcd);
                command.Parameters.Add("@product_information_source",SqlDbType.NVarChar).Value = (ProductInformationSource == null ? (object)DBNull.Value : (System.String)ProductInformationSource);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_information_source] 
                where product_information_source_id = @product_information_source_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_information_source_id",SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
