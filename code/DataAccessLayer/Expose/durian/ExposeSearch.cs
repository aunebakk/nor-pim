using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace norpim.DataAccessLayer {
    /// <summary> 
    /// Provides expose searches
    /// </summary>
    /// <domain>Expose</domain>
    public partial class ExposeSearch {
        /// <summary>get product details for one expose set</summary>
        /// <cardinality>Many</cardinality>
        public List<ExposeProductDetails> ExposeProductDetails(Guid productExposeSetId) {
            var ret = new List<ExposeProductDetails>();

            string sql = @" 
                select 
	                     pe.expose_product_id
		                ,p.product_name
		                ,pc.product_category_name
		                ,u.user_name				as product_user_name
		                ,p.date_time				as product_date_time
		                ,sr.state_name				as product_state_name

                from product_expose					as pe
                inner join product					as p	on p.product_id = pe.expose_product_id
                inner join product_category_mapping as pcm	on pcm.product_id = p.product_id
                inner join product_category			as pc	on pc.product_category_id = pcm.product_category_id
                inner join [user]					as u	on u.user_id = p.user_id
                inner join state_ref				as sr	on sr.state_rcd = p.state_rcd
                ";
            
            if (productExposeSetId != Guid.Empty) 
                sql += " where pe.product_expose_set_id = @product_expose_set_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_expose_set_id", SqlDbType.UniqueIdentifier).Value = productExposeSetId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ExposeProductDetailsOrdinals(reader);

                    while (reader.Read()) {
                        var data = new ExposeProductDetails();
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
