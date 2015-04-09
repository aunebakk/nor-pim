using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace norpim.DataAccessLayer {
    /// <summary> 
    /// Provides gather searches
    /// </summary>
    /// <domain>Gather</domain>
    public partial class GatherSearch {
        /// <summary>get product details on one gather</summary>
        /// <cardinality>Many</cardinality>
        public List<GatherProductDetails> GatherProductDetails(Guid productGatherId) {
            var ret = new List<GatherProductDetails>();

            string sql = @" 
                    select 
		                     pcs.product_id
		                    ,pgk.product_gather_key_value
		                    ,p.product_name
		                    ,pc.product_category_name
							,u.user_name				as product_user_name
							,p.date_time				as product_date_time
							,sr.state_name				as product_state_name

                    from product_gather_key				as pgk 
                    inner join product_change_set		as pcs  on pcs.product_gather_key_id = pgk.product_gather_key_id
                     left join product					as p	on p.product_id = pcs.product_id
                     left join product_category_mapping as pcm	on pcm.product_id = p.product_id
                     left join product_category			as pc	on pc.product_category_id = pcm.product_category_id
					 left join [user]					as u	on u.user_id = p.user_id
					 left join state_ref				as sr	on sr.state_rcd = p.state_rcd
                ";
            
            if (productGatherId != Guid.Empty) 
                sql += " where pgk.product_gather_id = @product_gather_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_gather_id", SqlDbType.UniqueIdentifier).Value = productGatherId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new GatherProductDetailsOrdinals(reader);

                    while (reader.Read()) {
                        var data = new GatherProductDetails();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }
        /// <summary>get gather overview</summary>
        /// <cardinality>Many</cardinality>
        public List<GatherOverview> GatherOverview() {
            var ret = new List<GatherOverview>();

            string sql = @" 
                select
	                 pg.product_gather_id
	                ,pg.start_date_time
	                ,pg.finish_date_time
	                ,pgstr.product_gather_source_type_rcd
	                ,pgstr.product_gather_source_type_name
	                ,(	select count(*)
		                from product_gather_key as pgk
		                where pgk.product_gather_id = pg.product_gather_id
		                ) as key_count
	                ,u.user_name
	                ,pg.date_time
                from product_gather							as pg
                inner join product_gather_source			as pgs		on pgs.product_gather_id = pg.product_gather_id
                inner join product_gather_source_type_ref	as pgstr	on pgstr.product_gather_source_type_rcd = pgs.product_gather_source_type_rcd
                inner join [user]							as u		on u.user_id = pg.user_id
                --realwhere
                order by pg.start_date_time
                ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new GatherOverviewOrdinals(reader);

                    while (reader.Read()) {
                        var data = new GatherOverview();
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
