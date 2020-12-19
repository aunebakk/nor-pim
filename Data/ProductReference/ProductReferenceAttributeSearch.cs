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
        /// <template>DotNetFrameworkByServiceTableCrud</template>
        public List<ProductReferenceAttributeSearchWithFilterData> ProductReferenceAttributeSearchWithFilter() {
            var ret = new List<ProductReferenceAttributeSearchWithFilterData>();
            string sql = @"
select 
     par.product_attribute_name
    ,par.product_attribute_rcd
    ,par.date_time
from product_attribute_ref as par

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
