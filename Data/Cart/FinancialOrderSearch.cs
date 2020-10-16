/*  
  SQL2X Generated ASP .NET Core C# Data Access code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2x.azurewebsites.net/
  Generated Date: 12/20/2017 19:41:36
  Template: TemplateDotNetCoreGeneratorApiDurian
*/
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.DataAccessLayer {
    /// <domain>Cart</domain>
    public partial class FinancialOrderSearch {

        /// <summary>Get Financial Order</summary>
        /// <cardinality>Many</cardinality>
        /// <template>WithDurian</template>
        public List<GetFinancialOrderData> GetFinancialOrder(
             System.Guid clientId
            , System.Guid financialCurrencyId
            , System.Guid locationAddressId
            , string financialOrderSourceRcd
            , System.Guid userId
            , System.Guid financialOrderId
            ) {
            List<GetFinancialOrderData> ret = new List<GetFinancialOrderData>();
            string sql = @"
select 
     c.first_name
    ,c.middle_name
    ,c.last_name
    ,c.client_nationality_rcd
    ,c.client_gender_rcd
    ,c.client_title_rcd
    ,c.client_type_rcd
    ,fo.client_id
    ,fc.financial_currency_type_rcd
    ,fc.financial_currency_against_financial_currency_type_rcd
    ,fc.financial_currency_type_code
    ,fc.financial_currency_type_name
    ,fo.financial_currency_id
--    ,la.location_address_type_rcd
--    ,la.address_one
--    ,la.address_two
--    ,la.address_three
--    ,la.city
--    ,la.street
--    ,la.state
--    ,la.district
--    ,la.province
--    ,la.zip_code
--    ,la.po_box
--    ,la.comment as location_address_comment
--    ,fo.location_address_id
--    ,fo.financial_order_source_rcd
    ,c.image_blob_filename
--    ,fosr.financial_order_source_name
    ,fo.comment
    ,fo.comment as financial_order_comment
    ,fo.user_id
    ,du.default_user_name
    ,fo.date_time
    ,fo.financial_order_id
from financial_order as fo
inner join client as c on c.client_id = fo.client_id
inner join financial_currency as fc on fc.financial_currency_id = fo.financial_currency_id
--left join location_address as la on la.location_address_id = fo.location_address_id
--inner join financial_order_source_ref as fosr on fosr.financial_order_source_rcd = fo.financial_order_source_rcd
inner join default_user as du on du.default_user_id = fo.user_id

where 1 = 1

order by fo.date_time desc

";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (SqlCommand command = new SqlCommand(sql, conn)) {
                    if (clientId != Guid.Empty) {
                        command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;
                        sql += " and fo.client_id = @client_id";
                    }
                    if (financialCurrencyId != Guid.Empty) {
                        command.Parameters.Add("@financial_currency_id", SqlDbType.UniqueIdentifier).Value = financialCurrencyId;
                        sql += " and fo.financial_currency_id = @financial_currency_id";
                    }
                    if (locationAddressId != Guid.Empty) {
                        command.Parameters.Add("@location_address_id", SqlDbType.UniqueIdentifier).Value = locationAddressId;
                        sql += " and fo.location_address_id = @location_address_id";
                    }
                    if (!string.IsNullOrEmpty(financialOrderSourceRcd)) {
                        command.Parameters.Add("@financial_order_source_rcd", SqlDbType.NVarChar).Value = financialOrderSourceRcd;
                        sql += " and fo.financial_order_source_rcd = @financial_order_source_rcd";
                    }
                    if (userId != Guid.Empty) {
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                        sql += " and fo.user_id = @user_id";
                    }
                    if (financialOrderId != Guid.Empty) {
                        command.Parameters.Add("@financial_order_id", SqlDbType.UniqueIdentifier).Value = financialOrderId;
                        sql += " and fo.financial_order_id = @financial_order_id";
                    }

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("GetFinancialOrder");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    GetFinancialOrderDataOrdinals ordinals = new GetFinancialOrderDataOrdinals(reader);

                    while (reader.Read()) {
                        GetFinancialOrderData data = new GetFinancialOrderData();
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
