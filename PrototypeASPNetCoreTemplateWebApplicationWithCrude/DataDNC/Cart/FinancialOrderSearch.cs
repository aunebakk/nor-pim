/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:37:28 AM
  Template: sql2x.TemplateDotNetCoreApiDurianWithTypeScript.DataBeginning
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    /// <domain>Cart</domain>
    public partial class FinancialOrderSearch {

        /// <summary>Get Financial Order</summary>
        /// <cardinality>Many</cardinality>
        /// <template>DotNetCoreApiDurian</template>
        public List<GetFinancialOrderData> GetFinancialOrder(
             System.Guid userId
            ,System.Guid financialCurrencyId
            ,System.String financialOrderSourceRcd
            ,System.Guid clientId
            ,System.Guid financialOrderId
            ,System.Guid locationAddressId
            ) {
            var ret = new List<GetFinancialOrderData>();
            string sql = @"
select 
     c.first_name
    ,c.middle_name
    ,c.last_name
    ,c.image_blob_filename
    ,du.default_user_name
    ,fc.financial_currency_type_name
    ,fosr.financial_order_source_name
    ,fo.user_id
    ,fo.date_time
    ,fo.comment
    ,fc.financial_currency_type_rcd
    ,fc.financial_currency_against_financial_currency_type_rcd
    ,fc.financial_currency_type_code
    ,fo.financial_currency_id
    ,fo.financial_order_source_rcd
    ,fo.client_id
    ,fo.financial_order_id
    ,fo.location_address_id
from financial_order as fo
inner join default_user as du on du.default_user_id = fo.user_id
inner join financial_currency as fc on fc.financial_currency_id = fo.financial_currency_id
inner join financial_order_source_ref as fosr on fosr.financial_order_source_rcd = fo.financial_order_source_rcd
inner join client as c on c.client_id = fo.client_id

where 1 = 1
";

            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (userId != Guid.Empty) {
                        command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) userId;
                        sql += " and fo.user_id = @user_id";
                    }
                    if (financialCurrencyId != Guid.Empty) {
                        command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) financialCurrencyId;
                        sql += " and fo.financial_currency_id = @financial_currency_id";
                    }
                    if (!String.IsNullOrEmpty(financialOrderSourceRcd)) {
                        command.Parameters.Add("@financial_order_source_rcd",SqlDbType.NVarChar).Value = (System.String) financialOrderSourceRcd;
                        sql += " and fo.financial_order_source_rcd = @financial_order_source_rcd";
                    }
                    if (clientId != Guid.Empty) {
                        command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) clientId;
                        sql += " and fo.client_id = @client_id";
                    }
                    if (financialOrderId != Guid.Empty) {
                        command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) financialOrderId;
                        sql += " and fo.financial_order_id = @financial_order_id";
                    }
                    if (locationAddressId != Guid.Empty) {
                        command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) locationAddressId;
                        sql += " and fo.location_address_id = @location_address_id";
                    }

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("GetFinancialOrder");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new GetFinancialOrderDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new GetFinancialOrderData();
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
