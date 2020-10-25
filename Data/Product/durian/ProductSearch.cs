using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.DataAccessLayer
{
    /// <summary> 
    /// Provides product search with different parameter and result sets
    /// </summary>
    /// <domain>Product</domain>
    public partial class ProductSearch
    {
        /// <summary>Get product history</summary>
        /// <cardinality>Many</cardinality>
        public List<ProductHistoryData> ProductHistory(
            Guid productId
            ) {

            var ret = new List<ProductHistoryData>();

            string sql = @" 
                    select 
	                     p.product_id
	                    ,p.product_name
	                    ,sr.default_state_name  as state_name
	                    ,p.date_time
	                    ,u.default_user_name    as user_name
	                    ,p.product_became_id
                    from product                    as p
                    inner join default_user         as u    on u.default_user_id = p.user_id
                    inner join default_state_ref    as sr	on sr.default_state_rcd = p.state_rcd
                    where p.product_id = @product_id
                    order by p.date_time
                ";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductHistoryDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new ProductHistoryData();
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
        public List<ProductSearchByNameData> ProductSearchByName(
            string productName
            ) {

            var ret = new List<ProductSearchByNameData>();

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
                order by p.date_time
                    ";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = productName.Replace("'", "''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductSearchByNameDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new ProductSearchByNameData();
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
        public ProductSearchByIdData ProductSearchById(
            Guid productId
            ) {

            var ret = new ProductSearchByIdData();

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

            using ( SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( SqlCommand command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                    if ( reader.Read() )
                        ret.Populate(reader, new ProductSearchByIdDataOrdinals(reader));
                }

                return ret;
            }
        }
        
        /// <summary>Search products by category</summary>
        /// <cardinality>Many</cardinality>
        public List<ProductSearchByCategoryData> ProductSearchByCategory(
            Guid productCategoryId,
            bool onParent
            ) {
            var ret = new List<ProductSearchByCategoryData>();

            string sql = @" 
                select  
                         p.product_id
                        ,p.product_name

                        ,(  select top 1 pid.identifier
			                from product_identifier as pid
			                where	pid.product_id = p.product_id
			                order by pid.date_time
			                ) as identifier
                        ,(  select top 1 pa.value
			                from product_attribute as pa
			                where	pa.product_id = p.product_id
			                order by pa.date_time
			                ) as value
                        ,(  select top 1 pi.product_info_value
			                from product_info as pi
			                where	pi.product_id = p.product_id
			                order by pi.date_time
			                ) as product_info_value
                        ,(  select top 1 pi.product_image_type_rcd
			                from product_image as pi
			                where	pi.product_id = p.product_id
			                order by pi.date_time
			                ) as product_image_type_rcd
                        ,(  select top 1 pi.product_image_type_rcd
			                from product_image as pi
                            inner join product_image_type_ref		as pit  on pit.product_image_type_rcd = pi.product_image_type_rcd
			                where	pi.product_id = p.product_id
			                order by pi.date_time
			                ) as product_image_type_name
                        ,(  select top 1 pi.image
			                from product_image as pi
			                where	pi.product_id = p.product_id
			                order by pi.date_time
			                ) as image
                from product                            as p
                inner join product_category_mapping		as pcm  on pcm.product_id = p.product_id
                inner join product_category		        as pc   on pc.product_category_id = pcm.product_category_id
                --realwhere
                where pcm.product_category_id = @product_category_id
                  and p.product_became_id is null
                ";

            if ( onParent )
                sql += "    or pc.product_category_parent_id = @product_category_id\r\n";

            sql += "    order by p.product_name, identifier\r\n";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductSearchByCategoryDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new ProductSearchByCategoryData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Search products by category</summary>
        /// <cardinality>Many</cardinality>
        public List<ProductSearchByCategoryCodeData> ProductSearchByCategoryCode(
            String productCategoryCode,
            bool onParent
            ) {
            var ret = new List<ProductSearchByCategoryCodeData>();

            string sql = @" 
                select  
                         p.product_id
                        ,p.product_name

                        ,(  select top 1 pid.identifier
			                from product_identifier as pid
			                where	pid.product_id = p.product_id
			                order by pid.date_time
			                ) as identifier
                        ,(  select top 1 pa.value
			                from product_attribute as pa
			                where	pa.product_id = p.product_id
			                order by pa.date_time
			                ) as value
                        ,(  select top 1 pi.product_info_value
			                from product_info as pi
			                where	pi.product_id = p.product_id
			                order by pi.date_time
			                ) as product_info_value
                        ,(  select top 1 pi.product_image_type_rcd
			                from product_image as pi
			                where	pi.product_id = p.product_id
			                order by pi.date_time
			                ) as product_image_type_rcd
                        ,(  select top 1 pi.product_image_type_rcd
			                from product_image as pi
                            inner join product_image_type_ref		as pit  on pit.product_image_type_rcd = pi.product_image_type_rcd
			                where	pi.product_id = p.product_id
			                order by pi.date_time
			                ) as product_image_type_name
                        ,(  select top 1 pi.image
			                from product_image as pi
			                where	pi.product_id = p.product_id
			                order by pi.date_time
			                ) as image
                from product                            as p
                inner join product_category_mapping		as pcm  on pcm.product_id = p.product_id
                inner join product_category		        as pc   on pc.product_category_id = pcm.product_category_id
                 left join product_category		        as pcp  on pcp.product_category_id = pc.product_category_parent_id
                --realwhere
                where pc.product_category_code = @product_category_code
                  and p.product_became_id is null
                ";

            if (onParent)
                sql += "    or pcp.product_category_code = @product_category_code\r\n";

            sql += "    order by p.product_name, identifier\r\n";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_category_code", SqlDbType.NVarChar).Value = productCategoryCode;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductSearchByCategoryCodeDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new ProductSearchByCategoryCodeData();
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
        public List<ProductSearchByCategoryType1Data> ProductSearchByCategoryType1(
            Guid productCategoryId,
            bool onParent
            ) {

            var ret = new List<ProductSearchByCategoryType1Data>();

            string sql = @" 
                select  
                         p.product_id
                        ,p.product_name

                        ,(  select top 1 pid.identifier
							from product_identifier as pid
							where	pid.product_id = p.product_id
								and pid.product_identifier_rcd = 'gtin13'
							) as gtin13

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

            if ( onParent )
                sql += "    or pc.product_category_parent_id = @product_category_id\r\n";

            sql += "    order by p.product_name, gtin13\r\n";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductSearchByCategoryType1DataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new ProductSearchByCategoryType1Data();
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
        public List<ProductSearchByCategoryType2Data> ProductSearchByCategoryType2(
            Guid productCategoryId,
            bool onParent
            ) {

            var ret = new List<ProductSearchByCategoryType2Data>();

            string sql = @" 
                select  
                         p.product_id
                        ,p.product_name

                        ,(  select top 1 pid.identifier
							from product_identifier as pid
							where	pid.product_id = p.product_id
								and pid.product_identifier_rcd = 'gtin13'
							) as gtin13

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

            if ( onParent )
                sql += "    or pc.product_category_parent_id = @product_category_id\r\n";

            sql += "    order by p.product_name, gtin13\r\n";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductSearchByCategoryType2DataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new ProductSearchByCategoryType2Data();
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
        public List<ProductSearchByCategoryType3Data> ProductSearchByCategoryType3(
            Guid productCategoryId,
            bool onParent
            ) {

            var ret = new List<ProductSearchByCategoryType3Data>();

            string sql = @" 
                select  
                         p.product_id
                        ,p.product_name

                        ,(  select top 1 pid.identifier
							from product_identifier as pid
							where	pid.product_id = p.product_id
								and pid.product_identifier_rcd = 'gtin13'
							) as gtin13

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

            if ( onParent )
                sql += "    or pc.product_category_parent_id = @product_category_id\r\n";

            sql += "    order by p.product_name, gtin13\r\n";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductSearchByCategoryType3DataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new ProductSearchByCategoryType3Data();
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
        public List<ProductSearchByCategoryType4Data> ProductSearchByCategoryType4(
            Guid productCategoryId,
            bool onParent
            ) {

            var ret = new List<ProductSearchByCategoryType4Data>();

            string sql = @" 
                select  
                         (  select top 1 pid.identifier
							from product_identifier as pid
							where	pid.product_id = p.product_id
								and pid.product_identifier_rcd = 'hn'
							) as hn

                        ,p.product_name

                        ,(  select top 1 pid.identifier
							from product_identifier as pid
							where	pid.product_id = p.product_id
								and pid.product_identifier_rcd = 'GTIN13'
							) as gtin13

						,ps.supplier_name
                        ,p.product_id

                from product                            as p
                inner join product_category_mapping		as pcm  on pcm.product_id = p.product_id
                inner join product_category		        as pc   on pc.product_category_id = pcm.product_category_id
                 left join product_supplier		        as ps   on ps.product_id = p.product_id

                --realwhere
                where pcm.product_category_id = @product_category_id
                  and p.product_became_id is null
                ";

            if ( onParent )
                sql += "    or pc.product_category_parent_id = @product_category_id\r\n";

            sql += "    order by p.product_name, gtin13\r\n";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@product_category_id", SqlDbType.UniqueIdentifier).Value = productCategoryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductSearchByCategoryType4DataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new ProductSearchByCategoryType4Data();
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
