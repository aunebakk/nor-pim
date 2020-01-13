using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.DataAccessLayer
{
    /// <summary> 
    /// Provides product search with different parameter and result sets
    /// </summary>
    public partial class ProductSearch
    {
        /// <summary>Get product history part</summary>
        /// <cardinality>One</cardinality>
        public ProductHistoryData ProductHistoryPart(Guid productId) {

            var ret = new ProductHistoryData();

            string sql = @" 
                    select top 1 -- not needed
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
                ";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                    if ( reader.Read() )
                        ret.Populate(reader, new ProductHistoryDataOrdinals(reader));
                }

                return ret;
            }
        }

        /// <summary>Get product history part</summary>
        /// <cardinality>One</cardinality>
        public ProductHistoryData ProductHistoryBecame(Guid becameProductId) {

            var ret = new ProductHistoryData();

            string sql = @" 
                    select top 1 -- not needed
	                     p.product_id
	                    ,p.product_name
	                    ,sr.default_state_name  as state_name
	                    ,p.date_time
	                    ,u.default_user_name    as user_name
	                    ,p.product_became_id
                    from product                    as p
                    inner join default_user         as u    on u.default_user_id = p.user_id
                    inner join default_state_ref    as sr	on sr.default_state_rcd = p.state_rcd
                    where p.product_became_id = @product_became_id
                ";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@product_became_id", SqlDbType.UniqueIdentifier).Value = becameProductId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                    if ( reader.Read() )
                        ret.Populate(reader, new ProductHistoryDataOrdinals(reader));
                }

                return ret;
            }
        }
    }
}
