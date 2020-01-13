using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.DataAccessLayer
{
    /// <summary> 
    /// Provides Product Reference search with different parameter and result sets
    /// </summary>
    /// <domain>ProductReference</domain>
    public class ProductReferenceAttributeSearch
    {
        
        /// <summary>Get Product Attribute Ref</summary>
        /// <cardinality>Many</cardinality>
        /// <template>ByServiceTableCrud</template>
        public List<ProductReferenceAttributeSearchWithFilterData> ProductReferenceAttributeSearchWithFilter() {
            var ret = new List<ProductReferenceAttributeSearchWithFilterData>();
            string sql = @"
select 
     par.product_attribute_name
    ,du.default_user_name
    ,par.user_id
    ,par.date_time
    ,par.product_attribute_rcd
from product_attribute_ref as par
inner join default_user as du on du.default_user_id = par.user_id

where 1 = 1
";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("ProductReferenceAttributeSearchWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new ProductReferenceAttributeSearchWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new ProductReferenceAttributeSearchWithFilterData();
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
