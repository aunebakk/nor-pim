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
        /// <summary>Get product history part</summary>
        /// <cardinality>One</cardinality>
        public ProductHistory ProductHistoryPart(Guid productId) {

            var ret = new ProductHistory();

            string sql = @" 
                    select top 1 -- not needed
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

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                    if (reader.Read())
                        ret.Populate(reader, new ProductHistoryOrdinals(reader));
                }

                return ret;
            }
        }

        /// <summary>Get product history part</summary>
        /// <cardinality>One</cardinality>
        public ProductHistory ProductHistoryBecame(Guid becameProductId) {

            var ret = new ProductHistory();

            string sql = @" 
                    select top 1 -- not needed
	                     p.product_id
	                    ,p.product_name
	                    ,sr.state_name
	                    ,p.date_time
	                    ,u.user_name
	                    ,p.product_became_id
                    from product            as p
                    inner join [user]       as u    on u.user_id = p.user_id
                    inner join state_ref    as sr	on sr.state_rcd = p.state_rcd
                    where p.product_became_id = @product_became_id
                ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_became_id", SqlDbType.UniqueIdentifier).Value = becameProductId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                    if (reader.Read())
                        ret.Populate(reader, new ProductHistoryOrdinals(reader));
                }

                return ret;
            }
        }
    }
}
