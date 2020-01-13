using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.DataAccessLayer
{
    /// <summary> 
    /// Provides category search with different parameter and result sets
    /// </summary>
    /// <domain>Category</domain>
    public partial class CategorySearch
    {
        /// <summary>Get categories</summary>
        /// <cardinality>Many</cardinality>
        public List<CategoryTreeData> CategoryTree() {

            var ret = new List<CategoryTreeData>();

            string sql = @" 
                select 
						pc.product_category_id, 
						pc.product_category_parent_id, 
						pc.product_category_code, 
						pc.product_category_name
				from product_category as pc
                where pc.product_category_became_id is null
                  and right(pc.product_category_name, 1) != '-'
                order by pc.product_category_code
                        ,pc.product_category_position
                ";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new CategoryTreeDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new CategoryTreeData();
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
        public List<CategoryFindData> CategoryFind(string findWhat) {

            var ret = new List<CategoryFindData>();

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

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@find_what", SqlDbType.VarChar, 4).Value = findWhat;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new CategoryFindDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new CategoryFindData();
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
