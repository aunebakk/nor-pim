using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductFieldSetMappingData {
        
        public System.Guid ProductFieldSetMappingId { get; set; } //;
        
        public System.Guid ProductFieldSetId { get; set; } //;
        
        public string ProductIdentifierRcd { get; set; } //;
        
        public string ProductAttributeRcd { get; set; } //;
        
        public string ProductInfoRcd { get; set; } //;
        
        public string ProductImageTypeRcd { get; set; } //;
        
        public string ProductDocumentationTypeRcd { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId) {
            string sql = @" select top 1 product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_field_set_mapping_id = @product_field_set_mapping_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = productFieldSetMappingId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeProductFieldSetMappingData> FetchByProductFieldSetId(System.Guid productFieldSetId) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_field_set_id = @product_field_set_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_field_set_id", SqlDbType.UniqueIdentifier).Value = productFieldSetId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductFieldSetMappingData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where user_id = @user_id
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductFieldSetMappingData> FetchAll() {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductFieldSetMappingData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select top " + limit.ToString() + @" product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeProductFieldSetMappingData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductFieldSetMappingData();
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
            string sql = @" select count(*) as count from [product_field_set_mapping]";

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
        
        public List<CrudeProductFieldSetMappingData> FetchWithFilter(System.Guid productFieldSetMappingId, System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productFieldSetMappingId != Guid.Empty) {
                        sql += "  and product_field_set_mapping_id = @product_field_set_mapping_id";
                        command.Parameters.Add("@product_field_set_mapping_id", SqlDbType.UniqueIdentifier).Value = productFieldSetMappingId;
                    }
                    if (productFieldSetId != Guid.Empty) {
                        sql += "  and product_field_set_id = @product_field_set_id";
                        command.Parameters.Add("@product_field_set_id", SqlDbType.UniqueIdentifier).Value = productFieldSetId;
                    }
                    if (productIdentifierRcd != "") {
                        sql += "  and product_identifier_rcd like '%' + @product_identifier_rcd + '%'";
                        command.Parameters.Add("@product_identifier_rcd", SqlDbType.NVarChar).Value = productIdentifierRcd.Replace("'","''");
                    }
                    if (productAttributeRcd != "") {
                        sql += "  and product_attribute_rcd like '%' + @product_attribute_rcd + '%'";
                        command.Parameters.Add("@product_attribute_rcd", SqlDbType.NVarChar).Value = productAttributeRcd.Replace("'","''");
                    }
                    if (productInfoRcd != "") {
                        sql += "  and product_info_rcd like '%' + @product_info_rcd + '%'";
                        command.Parameters.Add("@product_info_rcd", SqlDbType.NVarChar).Value = productInfoRcd.Replace("'","''");
                    }
                    if (productImageTypeRcd != "") {
                        sql += "  and product_image_type_rcd like '%' + @product_image_type_rcd + '%'";
                        command.Parameters.Add("@product_image_type_rcd", SqlDbType.NVarChar).Value = productImageTypeRcd.Replace("'","''");
                    }
                    if (productDocumentationTypeRcd != "") {
                        sql += "  and product_documentation_type_rcd like '%' + @product_documentation_type_rcd + '%'";
                        command.Parameters.Add("@product_documentation_type_rcd", SqlDbType.NVarChar).Value = productDocumentationTypeRcd.Replace("'","''");
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
                        var data = new CrudeProductFieldSetMappingData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_field_set_mapping_id"] != System.DBNull.Value) ProductFieldSetMappingId = (System.Guid) reader["product_field_set_mapping_id"];
            if (reader["product_field_set_id"] != System.DBNull.Value) ProductFieldSetId = (System.Guid) reader["product_field_set_id"];
            if (reader["product_identifier_rcd"] != System.DBNull.Value) ProductIdentifierRcd = (System.String) reader["product_identifier_rcd"];
            if (reader["product_attribute_rcd"] != System.DBNull.Value) ProductAttributeRcd = (System.String) reader["product_attribute_rcd"];
            if (reader["product_info_rcd"] != System.DBNull.Value) ProductInfoRcd = (System.String) reader["product_info_rcd"];
            if (reader["product_image_type_rcd"] != System.DBNull.Value) ProductImageTypeRcd = (System.String) reader["product_image_type_rcd"];
            if (reader["product_documentation_type_rcd"] != System.DBNull.Value) ProductDocumentationTypeRcd = (System.String) reader["product_documentation_type_rcd"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductFieldSetMappingId == Guid.Empty)
                ProductFieldSetMappingId = Guid.NewGuid();

            string sql = "insert into [product_field_set_mapping] (product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time)";
            sql += "            values (@product_field_set_mapping_id, @product_field_set_id, @product_identifier_rcd, @product_attribute_rcd, @product_info_rcd, @product_image_type_rcd, @product_documentation_type_rcd, @user_id, @date_time)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = (ProductFieldSetMappingId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductFieldSetMappingId);
                    command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (ProductFieldSetId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductFieldSetId);
                    command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (ProductIdentifierRcd == null ? (object)DBNull.Value : (System.String)ProductIdentifierRcd);
                    command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (ProductAttributeRcd == null ? (object)DBNull.Value : (System.String)ProductAttributeRcd);
                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (ProductInfoRcd == null ? (object)DBNull.Value : (System.String)ProductInfoRcd);
                    command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (ProductImageTypeRcd == null ? (object)DBNull.Value : (System.String)ProductImageTypeRcd);
                    command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (ProductDocumentationTypeRcd == null ? (object)DBNull.Value : (System.String)ProductDocumentationTypeRcd);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductFieldSetMappingId == Guid.Empty)
                ProductFieldSetMappingId = Guid.NewGuid();

            string sql = "insert into [product_field_set_mapping] (product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time)";
            sql += "            values (@product_field_set_mapping_id, @product_field_set_id, @product_identifier_rcd, @product_attribute_rcd, @product_info_rcd, @product_image_type_rcd, @product_documentation_type_rcd, @user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = (ProductFieldSetMappingId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductFieldSetMappingId);
                command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (ProductFieldSetId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductFieldSetId);
                command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (ProductIdentifierRcd == null ? (object)DBNull.Value : (System.String)ProductIdentifierRcd);
                command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (ProductAttributeRcd == null ? (object)DBNull.Value : (System.String)ProductAttributeRcd);
                command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (ProductInfoRcd == null ? (object)DBNull.Value : (System.String)ProductInfoRcd);
                command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (ProductImageTypeRcd == null ? (object)DBNull.Value : (System.String)ProductImageTypeRcd);
                command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (ProductDocumentationTypeRcd == null ? (object)DBNull.Value : (System.String)ProductDocumentationTypeRcd);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_field_set_mapping] set
                 product_field_set_mapping_id = @product_field_set_mapping_id
                ,product_field_set_id = @product_field_set_id
                ,product_identifier_rcd = @product_identifier_rcd
                ,product_attribute_rcd = @product_attribute_rcd
                ,product_info_rcd = @product_info_rcd
                ,product_image_type_rcd = @product_image_type_rcd
                ,product_documentation_type_rcd = @product_documentation_type_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where product_field_set_mapping_id = @product_field_set_mapping_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = (ProductFieldSetMappingId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductFieldSetMappingId);
                    command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (ProductFieldSetId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductFieldSetId);
                    command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (ProductIdentifierRcd == null ? (object)DBNull.Value : (System.String)ProductIdentifierRcd);
                    command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (ProductAttributeRcd == null ? (object)DBNull.Value : (System.String)ProductAttributeRcd);
                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (ProductInfoRcd == null ? (object)DBNull.Value : (System.String)ProductInfoRcd);
                    command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (ProductImageTypeRcd == null ? (object)DBNull.Value : (System.String)ProductImageTypeRcd);
                    command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (ProductDocumentationTypeRcd == null ? (object)DBNull.Value : (System.String)ProductDocumentationTypeRcd);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_field_set_mapping] set
                 product_field_set_mapping_id = @product_field_set_mapping_id
                ,product_field_set_id = @product_field_set_id
                ,product_identifier_rcd = @product_identifier_rcd
                ,product_attribute_rcd = @product_attribute_rcd
                ,product_info_rcd = @product_info_rcd
                ,product_image_type_rcd = @product_image_type_rcd
                ,product_documentation_type_rcd = @product_documentation_type_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where product_field_set_mapping_id = @product_field_set_mapping_id";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = (ProductFieldSetMappingId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductFieldSetMappingId);
                command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (ProductFieldSetId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ProductFieldSetId);
                command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (ProductIdentifierRcd == null ? (object)DBNull.Value : (System.String)ProductIdentifierRcd);
                command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (ProductAttributeRcd == null ? (object)DBNull.Value : (System.String)ProductAttributeRcd);
                command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (ProductInfoRcd == null ? (object)DBNull.Value : (System.String)ProductInfoRcd);
                command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (ProductImageTypeRcd == null ? (object)DBNull.Value : (System.String)ProductImageTypeRcd);
                command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (ProductDocumentationTypeRcd == null ? (object)DBNull.Value : (System.String)ProductDocumentationTypeRcd);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [product_field_set_mapping] 
                where product_field_set_mapping_id = @product_field_set_mapping_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
