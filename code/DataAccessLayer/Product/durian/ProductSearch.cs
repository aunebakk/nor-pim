using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace norpim.DataAccessLayer {
    /// <summary> 
    /// Provides product search with different parameter and result sets
    /// </summary>
    /// <domain>Product</domain>
    public partial class ProductSearch {
        /// <summary>Get product history</summary>
        /// <cardinality>Many</cardinality>
        public List<ProductHistory> ProductHistory(Guid productId) {

            var ret = new List<ProductHistory>();

            string sql = @" 
                    select 
	                     p.product_id
	                    ,p.product_name
	                    ,sr.state_name
	                    ,p.date_time
	                    ,u.user_name
	                    ,p.product_became_id
                    from product            as p
                    inner join [user]       as u    on u.user_id = p.user_id
                    inner join state_ref    as sr	on sr.state_rcd = p.state_rcd
                    where p.product_id = @product_id
                ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductHistoryOrdinals(reader);

                    while (reader.Read()) {
                        var data = new ProductHistory();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Search products by name</summary>
        /// <cardinality>Many</cardinality>
        public List<ProductSearchByName> ProductSearchByName(string productName) {

            var ret = new List<ProductSearchByName>();

            string sql = @" 
                select  
                         p.product_id
                        ,p.product_name

                        ,pi.identifier
                        ,pa.value
		                ,pin.product_info_value

		                ,pim.product_image_type_rcd
		                ,pit.product_image_type_name
		                ,pim.image

                from product as p
                inner join product_category_mapping		as pcm on pcm.product_id = p.product_id
                inner join product_attribute			as pa  on pa.product_id = p.product_id
                inner join product_identifier			as pi  on pi.product_id = p.product_id
                 left join product_info					as pin on pin.product_id = p.product_id
                 left join product_image				as pim on pim.product_id = p.product_id
                 left join product_image_type_ref		as pit on pim.product_id = p.product_id

                where p.product_name like '%' + @product_name + '%'
                    ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = productName.Replace("'", "''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductSearchByNameOrdinals(reader);

                    while (reader.Read()) {
                        var data = new ProductSearchByName();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Search products by id</summary>
        /// <cardinality>one</cardinality>
        public ProductSearchById ProductSearchById(Guid productId) {

            var ret = new ProductSearchById();

            string sql = @" 
                select  
                         p.product_name

                        ,pi.identifier
                        ,pa.value
		                ,pin.product_info_value

		                ,pim.product_image_type_rcd
		                ,pit.product_image_type_name
		                ,pim.image

                from product as p
                inner join product_category_mapping		as pcm on pcm.product_id = p.product_id
                inner join product_attribute			as pa  on pa.product_id = p.product_id
                inner join product_identifier			as pi  on pi.product_id = p.product_id
                 left join product_info					as pin on pin.product_id = p.product_id
                 left join product_image				as pim on pim.product_id = p.product_id
                 left join product_image_type_ref		as pit on pim.product_id = p.product_id

                where p.product_id = @product_id
                    ";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (SqlCommand command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                    if (reader.Read())
                        ret.Populate(reader, new ProductSearchByIdOrdinals(reader));
                }

                return ret;
            }
        }

        /// <summary>Search products by category</summary>
        /// <cardinality>Many</cardinality>
        public List<ProductSearchByCategory> ProductSearchByCategory(Guid productCategoryId,
                                                                     bool onParent) {

            var ret = new List<ProductSearchByCategory>();

            string sql = @" 
                select  
                         p.product_id
                        ,p.product_name

                        ,pi.identifier
                        ,pa.value
		                ,pin.product_info_value

		                ,pim.product_image_type_rcd
		                ,pit.product_image_type_name
		                ,pim.image

                from product                            as p
                inner join product_category_mapping		as pcm  on pcm.product_id = p.product_id
                inner join product_category		        as pc   on pc.product_category_id = pcm.product_category_id
                 left join product_attribute			as pa   on pa.product_id = p.product_id
                 left join product_identifier			as pi   on pi.product_id = p.product_id
                 left join product_info					as pin  on pin.product_id = p.product_id
                 left join product_image				as pim  on pim.product_id = p.product_id
                 left join product_image_type_ref		as pit  on pim.product_id = p.product_id
                where pcm.product_category_id = @product_category_id
                  and p.product_became_id is null
                ";

                if (onParent)
                    sql += "    or pc.product_category_parent_id = @product_category_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductSearchByCategoryOrdinals(reader);

                    while (reader.Read()) {
                        var data = new ProductSearchByCategory();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }
        /// <summary>Search products by category, result set 1</summary>
        /// <cardinality>Many</cardinality>
        public List<ProductSearchByCategoryType1> ProductSearchByCategoryType1( Guid productCategoryId,
                                                                                bool onParent
                                                                                ) {

            var ret = new List<ProductSearchByCategoryType1>();

            string sql = @" 
                select  
                         p.product_id
                        ,p.product_name

                        ,(  select top 1 pid.identifier
							from product_identifier as pid
							where	pid.product_id = p.product_id
								and pid.product_identifier_rcd = 'gtin'
							) as gtin

                        ,(  select top 1 pa.value
							from product_attribute as pa
							where	pa.product_id = p.product_id
								and pa.product_attribute_rcd = 'color'
							) as color

                from product                            as p
                inner join product_category_mapping		as pcm  on pcm.product_id = p.product_id
                inner join product_category		        as pc   on pc.product_category_id = pcm.product_category_id
                --realwhere
                where pcm.product_category_id = @product_category_id
                  and p.product_became_id is null
                ";

                if (onParent)
                    sql += "    or pc.product_category_parent_id = @product_category_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductSearchByCategoryType1Ordinals(reader);

                    while (reader.Read()) {
                        var data = new ProductSearchByCategoryType1();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Search products by category, result set 2</summary>
        /// <cardinality>Many</cardinality>
        public List<ProductSearchByCategoryType2> ProductSearchByCategoryType2( Guid productCategoryId,
                                                                                bool onParent
                                                                                ) {

            var ret = new List<ProductSearchByCategoryType2>();

            string sql = @" 
                select  
                         p.product_id
                        ,p.product_name

                        ,(  select top 1 pid.identifier
							from product_identifier as pid
							where	pid.product_id = p.product_id
								and pid.product_identifier_rcd = 'gtin'
							) as gtin

                        ,(  select top 1 pid.identifier
							from product_identifier as pid
							where	pid.product_id = p.product_id
								and pid.product_identifier_rcd = 'hn'
							) as hn

                        ,(  select top 1 pa.value
							from product_attribute as pa
							where	pa.product_id = p.product_id
								and pa.product_attribute_rcd = 'color'
							) as color

                from product                            as p
                inner join product_category_mapping		as pcm  on pcm.product_id = p.product_id
                inner join product_category		        as pc   on pc.product_category_id = pcm.product_category_id
                --realwhere
                where pcm.product_category_id = @product_category_id
                  and p.product_became_id is null
                ";

                if (onParent)
                    sql += "    or pc.product_category_parent_id = @product_category_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductSearchByCategoryType2Ordinals(reader);

                    while (reader.Read()) {
                        var data = new ProductSearchByCategoryType2();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Search products by category, result set 3</summary>
        /// <cardinality>Many</cardinality>
        public List<ProductSearchByCategoryType3> ProductSearchByCategoryType3( Guid productCategoryId,
                                                                                bool onParent
                                                                                ) {

            var ret = new List<ProductSearchByCategoryType3>();

            string sql = @" 
                select  
                         p.product_id
                        ,p.product_name

                        ,(  select top 1 pid.identifier
							from product_identifier as pid
							where	pid.product_id = p.product_id
								and pid.product_identifier_rcd = 'gtin'
							) as gtin

                        ,(  select top 1 pid.identifier
							from product_identifier as pid
							where	pid.product_id = p.product_id
								and pid.product_identifier_rcd = 'hn'
							) as hn

                        ,(  select top 1 pa.value
							from product_attribute as pa
							where	pa.product_id = p.product_id
								and pa.product_attribute_rcd = 'color'
							) as color

                from product                            as p
                inner join product_category_mapping		as pcm  on pcm.product_id = p.product_id
                inner join product_category		        as pc   on pc.product_category_id = pcm.product_category_id
                --realwhere
                where pcm.product_category_id = @product_category_id
                  and p.product_became_id is null
                ";

                if (onParent)
                    sql += "    or pc.product_category_parent_id = @product_category_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductSearchByCategoryType3Ordinals(reader);

                    while (reader.Read()) {
                        var data = new ProductSearchByCategoryType3();
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
