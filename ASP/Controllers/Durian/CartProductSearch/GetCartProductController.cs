/*  
  SQL2X Generated ASP .NET Core C# REST code based on a SQL Server Schema
  SQL2X Version: 0.c
  http://sql2x.azurewebsites.net/
  Generated Date: 10/12/2017 3:42:31 PM
  Durian: RESTDurianGenerator
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using SolutionNorSolutionPim.BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SolutionNorSolutionPim.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/cartproductsearchservice")]
    public class GetCartProductController : Controller {

        [HttpGet("ordermake")]
        public IActionResult OrderMake() {

            List<CrudeCartProductModel> cart = new CrudeCartProductBusiness().FetchAll();
            CrudeFinancialCurrencyModel currency = new CrudeFinancialCurrencyBusiness().FetchAll()[0];

            foreach (var cartItem in cart) {

                var financialOrder = new CrudeFinancialOrderModel();

                financialOrder.FinancialOrderId = Guid.NewGuid();
                financialOrder.FinancialOrderSourceRcd = FinancialOrderSourceRef.InternalSystem;
                financialOrder.Comment = "Hi there";
                financialOrder.FinancialCurrencyId = currency.FinancialCurrencyId;
                //financialOrder.LocationAddressId = 
                financialOrder.UserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                financialOrder.DateTime = DateTime.UtcNow;

                new CrudeFinancialOrderBusiness().Insert(financialOrder);
            }

            return View(
                "~/Views/Durian/Cart/GetCartProductOrderMake.cshtml"
                );
        }

        [HttpGet("getcartproduct")]
        public IEnumerable<GetCartProductModel> GetCartProduct() {

            List<GetCartProductModel> durian =
                new CartProductSearchService().GetCartProduct(Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty);

            return durian;
        }

        [HttpGet("getcartproducttypescript")]
        public IActionResult GetCartProductTypeScript() {

            List<GetCartProductModel> durian =
                new CartProductSearchService().GetCartProduct(Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty);

            return View(
                "~/Views/Durian/Cart/GetCartProductIndexTypeScript.cshtml",
                durian
                );
        }

    }
}
