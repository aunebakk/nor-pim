using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.DataAccessLayer {
    /// <summary> 
    /// Provides search with different parameter and result sets
    /// </summary>
    /// <domain>ProductMaintenance</domain>
    public class ProductMaintenanceSearch {

        /// <summary>Get Product Info</summary>
        /// <cardinality>Many</cardinality>
        /// <template>WithDurian</template>
        public List<ProductMaintenanceInfoIndexWithFilterData> ProductMaintenanceInfoIndexWithFilter(
             System.Guid productId
            ) {
            var ret = new List<ProductMaintenanceInfoIndexWithFilterData>();
            string sql = @"
select 
     p.product_name
    ,p.state_rcd
    ,pir.product_info_name
    ,du.default_user_name
    ,pi.product_id
    ,pi.product_info_rcd
    ,pi.product_info_value
    ,pi.user_id
    ,pi.date_time
    ,pi.product_info_id
from product_info as pi
inner join product as p on p.product_id = pi.product_id
inner join product_info_ref as pir on pir.product_info_rcd = pi.product_info_rcd
inner join default_user as du on du.default_user_id = pi.user_id

where 1 = 1
";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productId != Guid.Empty) {
                        command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) productId;
                        sql += " and pi.product_id = @product_id";
                    }

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("ProductMaintenanceInfoIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new ProductMaintenanceInfoIndexWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new ProductMaintenanceInfoIndexWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get Product Image</summary>
        /// <cardinality>Many</cardinality>
        /// <template>WithDurian</template>
        public List<ProductMaintenanceImageIndexWithFilterData> ProductMaintenanceImageIndexWithFilter(
             System.Guid productId
            ) {
            var ret = new List<ProductMaintenanceImageIndexWithFilterData>();
            string sql = @"
select 
     p.product_name
    ,p.state_rcd
    ,pitr.product_image_type_name
    ,pi.image_file_name
    ,du.default_user_name
    ,pi.product_id
    ,pi.product_image_type_rcd
    ,pi.image
    ,pi.user_id
    ,pi.date_time
    ,pi.product_image_id
from product_image as pi
inner join product as p on p.product_id = pi.product_id
inner join product_image_type_ref as pitr on pitr.product_image_type_rcd = pi.product_image_type_rcd
inner join default_user as du on du.default_user_id = pi.user_id

where 1 = 1
";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productId != Guid.Empty) {
                        command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) productId;
                        sql += " and pi.product_id = @product_id";
                    }

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("ProductMaintenanceImageIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new ProductMaintenanceImageIndexWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new ProductMaintenanceImageIndexWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get Product Identifier</summary>
        /// <cardinality>Many</cardinality>
        /// <template>WithDurian</template>
        public List<ProductMaintenanceIdentifierIndexWithFilterData> ProductMaintenanceIdentifierIndexWithFilter(
             System.Guid productId
            ) {
            var ret = new List<ProductMaintenanceIdentifierIndexWithFilterData>();
            string sql = @"
select 
     p.product_name
    ,p.state_rcd
    ,pir.product_identifier_name
    ,du.default_user_name
    ,pi.product_id
    ,pi.product_identifier_rcd
    ,pi.identifier
    ,pi.user_id
    ,pi.date_time
    ,pi.product_identifier_id
from product_identifier as pi
inner join product as p on p.product_id = pi.product_id
inner join product_identifier_ref as pir on pir.product_identifier_rcd = pi.product_identifier_rcd
inner join default_user as du on du.default_user_id = pi.user_id

where 1 = 1
";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productId != Guid.Empty) {
                        command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) productId;
                        sql += " and pi.product_id = @product_id";
                    }

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("ProductMaintenanceIdentifierIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new ProductMaintenanceIdentifierIndexWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new ProductMaintenanceIdentifierIndexWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get Product Documentation</summary>
        /// <cardinality>Many</cardinality>
        /// <template>WithDurian</template>
        public List<ProductMaintenanceDocumentationIndexWithFilterData> ProductMaintenanceDocumentationIndexWithFilter(
             System.Guid productId
            ) {
            var ret = new List<ProductMaintenanceDocumentationIndexWithFilterData>();
            string sql = @"
select 
     p.product_name
    ,p.state_rcd
    ,pdtr.product_documentation_type_name
    ,du.default_user_name
    ,pd.product_id
    ,pd.product_documentation_type_rcd
    ,pd.documentation
    ,pd.user_id
    ,pd.date_time
    ,pd.product_documentation_id
from product_documentation as pd
inner join product as p on p.product_id = pd.product_id
inner join product_documentation_type_ref as pdtr on pdtr.product_documentation_type_rcd = pd.product_documentation_type_rcd
inner join default_user as du on du.default_user_id = pd.user_id

where 1 = 1
";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productId != Guid.Empty) {
                        command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) productId;
                        sql += " and pd.product_id = @product_id";
                    }

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("ProductMaintenanceDocumentationIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new ProductMaintenanceDocumentationIndexWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new ProductMaintenanceDocumentationIndexWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get Product Attribute</summary>
        /// <cardinality>Many</cardinality>
        /// <template>WithDurian</template>
        public List<ProductMaintenanceAttributeIndexWithFilterData> ProductMaintenanceAttributeIndexWithFilter(
             System.Guid productId
            ) {
            var ret = new List<ProductMaintenanceAttributeIndexWithFilterData>();
            string sql = @"
select 
     p.product_name
    ,p.state_rcd
    ,par.product_attribute_name
    ,paur.product_attribute_unit_name
    ,du.default_user_name
    ,pa.product_id
    ,pa.product_attribute_rcd
    ,pa.product_attribute_unit_rcd
    ,pa.value
    ,pa.user_id
    ,pa.date_time
    ,pa.product_attribute_id
from product_attribute as pa
inner join product as p on p.product_id = pa.product_id
inner join product_attribute_ref as par on par.product_attribute_rcd = pa.product_attribute_rcd
left join product_attribute_unit_ref as paur on paur.product_attribute_unit_rcd = pa.product_attribute_unit_rcd
inner join default_user as du on du.default_user_id = pa.user_id

where 1 = 1
";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productId != Guid.Empty) {
                        command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) productId;
                        sql += " and pa.product_id = @product_id";
                    }

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("ProductMaintenanceAttributeIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new ProductMaintenanceAttributeIndexWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new ProductMaintenanceAttributeIndexWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get Product</summary>
        /// <cardinality>Many</cardinality>
        /// <template>WithDurian</template>
        public List<ProductMaintenanceIndexData> ProductMaintenanceIndex() {
            var ret = new List<ProductMaintenanceIndexData>();
            string sql = @"
select 
     p.product_name
    ,p.state_rcd
    ,p.user_id
    ,p.date_time
    ,p.product_id
    ,du.default_user_name
from product as p
inner join default_user as du on du.default_user_id = p.user_id

where 1 = 1
";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("ProductMaintenanceIndex");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new ProductMaintenanceIndexDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new ProductMaintenanceIndexData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }
    
    }
}
