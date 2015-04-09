using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace norpim.DataAccessLayer {
    /// <summary> 
    /// Provides category search with different parameter and result sets
    /// </summary>
    /// <domain>Category</domain>
    public partial class CategorySearch {
        /// <summary>Get categories</summary>
        /// <cardinality>Many</cardinality>
        public List<CategoryTree> CategoryTree() {

            var ret = new List<CategoryTree>();

            string sql = @" 
                select 
						pc.product_category_id, 
						pc.product_category_parent_id, 
						pc.product_category_code, 
						pc.product_category_name
				from product_category as pc
                where pc.product_category_became_id is null
                order by pc.product_category_position
                ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new CategoryTreeOrdinals(reader);

                    while (reader.Read()) {
                        var data = new CategoryTree();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Find categories</summary>
        /// <cardinality>Many</cardinality>
        public List<CategoryFind> CategoryFind(string findWhat) {

            var ret = new List<CategoryFind>();

            string sql = @" 
                select 
	                 pc.product_category_code
	                ,p.product_name
	                ,pc.product_category_id
	                ,p.product_id
                from product_category				as pc
                inner join product_category_mapping as pcm	on pcm.product_category_id = pc.product_category_id
                inner join product					as p	on p.product_id = pcm.product_id
											                and p.product_became_id is null
                where pc.product_category_code like '%' + @find_what + '%'
                   or p.product_name like '%' + @find_what + '%'
                ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@find_what", SqlDbType.VarChar, 4).Value = findWhat;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new CategoryFindOrdinals(reader);

                    while (reader.Read()) {
                        var data = new CategoryFind();
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