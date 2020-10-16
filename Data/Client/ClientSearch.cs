using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.DataAccessLayer {
    /// <summary> 
    /// Provides client search with different parameter and result sets
    /// </summary>
    /// <domain>Client</domain>
    public class ClientSearch {
        /// <summary>Get Client</summary>
        /// <cardinality>Many</cardinality>
        public List<GetClientWithFilterData> GetClientWithFilter(
             string lastName
            , string clientTypeRcd
            ) {

            List<GetClientWithFilterData> ret = new List<GetClientWithFilterData>();
            string sql = @"select
     c.first_name
    ,c.middle_name
    ,c.last_name
    ,c.client_type_rcd
    ,ptr.client_type_name
    ,c.client_nationality_rcd
    ,nr.client_nationality_name
    ,c.client_gender_rcd
    ,gr.client_gender_name
    ,c.client_title_rcd
    ,tr.client_title_name
    ,c.user_id
    ,du.default_user_name
    ,c.date_time
    ,c.client_id
    ,c.user_id as client_user_id
from client as c
inner join default_user as du on du.default_user_id = c.user_id
left join client_type_ref as ptr on ptr.client_type_rcd = c.client_type_rcd
left join client_nationality_ref as nr on nr.client_nationality_rcd = c.client_nationality_rcd
left join client_gender_ref as gr on gr.client_gender_rcd = c.client_gender_rcd
left join client_title_ref as tr on tr.client_title_rcd = c.client_title_rcd
left join client_type_ref as ctr on ctr.client_type_rcd = c.client_type_rcd
";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (SqlCommand command = new SqlCommand(sql, conn)) {
                    //command.Parameters.Add("@last_name", SqlDbType.NVarChar).Value = lastName;
                    //command.Parameters.Add("@client_type_rcd", SqlDbType.NVarChar).Value = clientTypeRcd;

                    Logging log = Logging.PerformanceTimeStart("GetClientWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    GetClientWithFilterDataOrdinals ordinals = new GetClientWithFilterDataOrdinals(reader);

                    while (reader.Read()) {
                        GetClientWithFilterData data = new GetClientWithFilterData();
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
