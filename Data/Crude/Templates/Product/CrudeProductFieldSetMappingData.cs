/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:06:15 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class CrudeProductFieldSetMappingData {
        
        public System.Guid ProductFieldSetMappingId { get; set; }
        
        public System.Guid ProductFieldSetId { get; set; }
        
        public string ProductIdentifierRcd { get; set; }
        
        public string ProductAttributeRcd { get; set; }
        
        public string ProductInfoRcd { get; set; }
        
        public string ProductImageTypeRcd { get; set; }
        
        public string ProductDocumentationTypeRcd { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public void FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId) {
            string sql = @" select top 1 product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_field_set_mapping_id = @product_field_set_mapping_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = productFieldSetMappingId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductFieldSetMappingData GetByProductFieldSetMappingId(System.Guid productFieldSetMappingId) {
            string sql = @" select top 1 product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_field_set_mapping_id = @product_field_set_mapping_id";

            var ret = new CrudeProductFieldSetMappingData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = productFieldSetMappingId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductFieldSetMappingData> FetchByProductFieldSetId(System.Guid productFieldSetId) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_field_set_id = @product_field_set_id
                              ";

            // open standard connection
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
        
        public static List<CrudeProductFieldSetMappingData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where user_id = @user_id
                              ";

            // open standard connection
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
        
        public static List<CrudeProductFieldSetMappingData> FetchByProductIdentifierRcd(string productIdentifierRcd) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_identifier_rcd = @product_identifier_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_identifier_rcd", SqlDbType.NVarChar).Value = productIdentifierRcd.Replace("'","''");

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
        
        public static List<CrudeProductFieldSetMappingData> FetchByProductAttributeRcd(string productAttributeRcd) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_attribute_rcd = @product_attribute_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_attribute_rcd", SqlDbType.NVarChar).Value = productAttributeRcd.Replace("'","''");

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
        
        public static List<CrudeProductFieldSetMappingData> FetchByProductInfoRcd(string productInfoRcd) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_info_rcd = @product_info_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_info_rcd", SqlDbType.NVarChar).Value = productInfoRcd.Replace("'","''");

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
        
        public static List<CrudeProductFieldSetMappingData> FetchByProductImageTypeRcd(string productImageTypeRcd) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_image_type_rcd = @product_image_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_image_type_rcd", SqlDbType.NVarChar).Value = productImageTypeRcd.Replace("'","''");

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
        
        public static List<CrudeProductFieldSetMappingData> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where product_documentation_type_rcd = @product_documentation_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_documentation_type_rcd", SqlDbType.NVarChar).Value = productDocumentationTypeRcd.Replace("'","''");

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
        
        public static List<CrudeProductFieldSetMappingData> FetchAll() {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]";

            // open standard connection
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
        
        public static List<CrudeProductFieldSetMappingData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select top " + limit.ToString() + @" product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]";

            // open standard connection
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
        
        public static List<CrudeProductFieldSetMappingData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]";

            // open standard connection
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
        
        public static int FetchAllCount() {
            string sql = @" select count(*) as count from [product_field_set_mapping]";

            // open standard connection
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
        
        public static List<CrudeProductFieldSetMappingData> FetchWithFilter(System.Guid productFieldSetMappingId, System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductFieldSetMappingData>();

            string sql = @" select product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time
                            from [product_field_set_mapping]
                            where 1 = 1";

            // open standard connection
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
                    if (!string.IsNullOrEmpty(productIdentifierRcd)) {
                        sql += "  and product_identifier_rcd like '%' + @product_identifier_rcd + '%'";
                        command.Parameters.Add("@product_identifier_rcd", SqlDbType.NVarChar).Value = productIdentifierRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productAttributeRcd)) {
                        sql += "  and product_attribute_rcd like '%' + @product_attribute_rcd + '%'";
                        command.Parameters.Add("@product_attribute_rcd", SqlDbType.NVarChar).Value = productAttributeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productInfoRcd)) {
                        sql += "  and product_info_rcd like '%' + @product_info_rcd + '%'";
                        command.Parameters.Add("@product_info_rcd", SqlDbType.NVarChar).Value = productInfoRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productImageTypeRcd)) {
                        sql += "  and product_image_type_rcd like '%' + @product_image_type_rcd + '%'";
                        command.Parameters.Add("@product_image_type_rcd", SqlDbType.NVarChar).Value = productImageTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(productDocumentationTypeRcd)) {
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

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetMappingId;
                    command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetId;
                    command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                    command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeRcd;
                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (System.String)ProductInfoRcd;
                    command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductImageTypeRcd;
                    command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductDocumentationTypeRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductFieldSetMappingId == Guid.Empty)
                ProductFieldSetMappingId = Guid.NewGuid();

            string sql = "insert into [product_field_set_mapping] (product_field_set_mapping_id, product_field_set_id, product_identifier_rcd, product_attribute_rcd, product_info_rcd, product_image_type_rcd, product_documentation_type_rcd, user_id, date_time)";
            sql += "            values (@product_field_set_mapping_id, @product_field_set_id, @product_identifier_rcd, @product_attribute_rcd, @product_info_rcd, @product_image_type_rcd, @product_documentation_type_rcd, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetMappingId;
                command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetId;
                command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeRcd;
                command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (System.String)ProductInfoRcd;
                command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductImageTypeRcd;
                command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductDocumentationTypeRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
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

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetMappingId;
                    command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetId;
                    command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                    command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeRcd;
                    command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (System.String)ProductInfoRcd;
                    command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductImageTypeRcd;
                    command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductDocumentationTypeRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
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

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetMappingId;
                command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetId;
                command.Parameters.Add("@product_identifier_rcd",SqlDbType.NVarChar).Value = (System.String)ProductIdentifierRcd;
                command.Parameters.Add("@product_attribute_rcd",SqlDbType.NVarChar).Value = (System.String)ProductAttributeRcd;
                command.Parameters.Add("@product_info_rcd",SqlDbType.NVarChar).Value = (System.String)ProductInfoRcd;
                command.Parameters.Add("@product_image_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductImageTypeRcd;
                command.Parameters.Add("@product_documentation_type_rcd",SqlDbType.NVarChar).Value = (System.String)ProductDocumentationTypeRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid productFieldSetMappingId) {
            string sql = @" delete [product_field_set_mapping] 
                where product_field_set_mapping_id = @product_field_set_mapping_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_field_set_mapping_id",SqlDbType.UniqueIdentifier).Value = productFieldSetMappingId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
