using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.DataAccessLayer
{
    /// <summary> 
    /// Provides cart search with different parameter and result sets
    /// </summary>
    /// <domain>Cart</domain>
    public class CartSearch
    {
        
        /// <summary>Get Cart Product</summary>
        /// <cardinality>Many</cardinality>
        /// <template>ByServiceTableCrud</template>
        public List<GetCartProductWithFilterData> GetCartProductWithFilter() {
            var ret = new List<GetCartProductWithFilterData>();
            string sql = @"
select 
     c.first_name
    ,c.middle_name
    ,c.last_name
    ,p.product_name
    ,c.image_blob_filename
    ,p.state_rcd as product_state_rcd
    ,fc.financial_currency_type_name
    ,du.default_user_name
    ,cp.client_id
    ,cp.product_id
    ,fc.financial_currency_type_rcd
    ,fc.financial_currency_against_financial_currency_type_rcd
    ,fc.financial_currency_type_code
    ,cp.financial_currency_id
    ,cp.amount
    ,cp.state_rcd as cart_product_state_rcd
    ,cp.user_id
    ,cp.date_time
    ,cp.cart_product_id
from cart_product as cp
inner join client as c on c.client_id = cp.client_id
inner join product as p on p.product_id = cp.product_id
inner join financial_currency as fc on fc.financial_currency_id = cp.financial_currency_id
inner join default_user as du on du.default_user_id = cp.user_id

where 1 = 1
";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("GetCartProductWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new GetCartProductWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new GetCartProductWithFilterData();
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
