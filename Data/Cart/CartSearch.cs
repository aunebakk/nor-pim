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
        /// <summary>
        /// Get Cart Product
        /// links:
        ///  docLink: http://sql2x.org/documentationLink/06760f02-f3ec-45ad-bbfe-db43d7a0378f
        /// </summary>
        /// <template>DotNetFrameworkByServiceTableCrud</template>
        /// <cardinality>Many</cardinality>
        public List<GetCartProductWithFilterData> GetCartProductWithFilter() {
            var ret = new List<GetCartProductWithFilterData>();
            string sql = @"
select 
     [c].first_name
    ,[c].middle_name
    ,[c].last_name
    ,[p].product_name
    ,[fc].financial_currency_type_name
    ,[du].default_user_name
    ,[c].image_blob_filename
    ,[cp].client_id
    ,[p].state_rcd as product_state_rcd
    ,[cp].product_id
    ,[fc].financial_currency_type_rcd
    ,[fc].financial_currency_against_financial_currency_type_rcd
    ,[fc].financial_currency_type_code
    ,[cp].financial_currency_id
    ,[cp].amount
    ,[cp].session_identificator
    ,[cp].state_rcd as cart_product_state_rcd
    ,[cp].user_id
    ,[cp].date_time
    ,[cp].cart_product_id
    ,[cp].session_id
    ,[cp].asp_id
from cart_product as [cp]
left join client as [c] on [c].client_id = [cp].client_id
inner join product as [p] on [p].product_id = [cp].product_id
inner join financial_currency as [fc] on [fc].financial_currency_id = [cp].financial_currency_id
inner join default_user as [du] on [du].default_user_id = [cp].user_id

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
