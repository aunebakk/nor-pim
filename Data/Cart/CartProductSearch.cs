/*  
  SQL2X Generated ASP .NET Core C# Data Access code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2x.azurewebsites.net/
  Generated Date: 12/19/2017 01:58:40
  Template: TemplateDotNetCoreGeneratorApiDurian
*/
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.DataAccessLayer {
    /// <domain>Cart</domain>
    public partial class CartProductSearch {

        /// <summary>Get Cart Product</summary>
        /// <cardinality>Many</cardinality>
        /// <template>WithDurian</template>
        public List<GetCartProductData> GetCartProduct(
             System.Guid clientId
            ,System.Guid productId
            ,System.Guid financialCurrencyId
            ,System.Guid userId
            ,System.Guid cartProductId
            ,string sessionIdentificator
            ) {
            var ret = new List<GetCartProductData>();
            string sql = @"
select 
     c.first_name
    ,c.middle_name
    ,c.last_name
    ,c.client_nationality_rcd
    ,c.client_gender_rcd
    ,c.client_title_rcd
    ,c.client_type_rcd
    ,cp.client_id
    ,p.product_name
    ,p.state_rcd as product_state_rcd
    ,cp.product_id
    ,fc.financial_currency_type_rcd
    ,fc.financial_currency_against_financial_currency_type_rcd
    ,fc.financial_currency_type_code
    ,fc.financial_currency_type_name
    ,cp.financial_currency_id
    ,cp.amount
    ,cp.state_rcd as cart_product_state_rcd
    ,c.image_blob_filename
    ,cp.user_id
    ,du.default_user_name
    ,cp.date_time
    ,cp.cart_product_id
    ,cp.session_identificator
from cart_product as cp
inner join client as c on c.client_id = cp.client_id
inner join product as p on p.product_id = cp.product_id
inner join financial_currency as fc on fc.financial_currency_id = cp.financial_currency_id
inner join default_user as du on du.default_user_id = cp.user_id
  and cp.state_rcd = @state_ref_created
where 1 = 1
";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@state_ref_created", SqlDbType.VarChar).Value = (System.String) DefaultStateRef.Created;

                    if (clientId != Guid.Empty) {
                        command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) clientId;
                        sql += " and cp.client_id = @client_id";
                    }
                    if (productId != Guid.Empty) {
                        command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) productId;
                        sql += " and cp.product_id = @product_id";
                    }
                    if (financialCurrencyId != Guid.Empty) {
                        command.Parameters.Add("@financial_currency_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) financialCurrencyId;
                        sql += " and cp.financial_currency_id = @financial_currency_id";
                    }
                    if (userId != Guid.Empty) {
                        command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) userId;
                        sql += " and cp.user_id = @user_id";
                    }
                    if (cartProductId != Guid.Empty) {
                        command.Parameters.Add("@cart_product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid) cartProductId;
                        sql += " and cp.cart_product_id = @cart_product_id";
                    }
                    if (!string.IsNullOrEmpty( sessionIdentificator ) ) {
                        command.Parameters.Add("@session_identificator",SqlDbType.NVarChar).Value = sessionIdentificator;
                        sql += " and cp.session_identificator = @session_identificator";
                    }

                    command.CommandText = sql;

                    // Logging log = Logging.PerformanceTimeStart("GetCartProduct");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    // log.PerformanceTimeStop(sql, command);

                    var ordinals = new GetCartProductDataOrdinals(reader);

                    while (reader.Read()) {
                        var data = new GetCartProductData();
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
