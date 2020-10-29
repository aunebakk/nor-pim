/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 9:55:49 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class GetCartProductController : Controller {

        [HttpGet]
        public ActionResult GetCartProductIndex(System.Guid clientId,System.Guid productId,System.Guid financialCurrencyId,System.Guid userId,System.Guid cartProductId,System.String sessionIdentificator) {

            return View(
                "~/Views/Durian/CartProductSearch/GetCartProductIndex.cshtml",
                new CartProductSearchService().GetCartProduct(clientId,productId,financialCurrencyId,userId,cartProductId,sessionIdentificator)
                );
        }

    }
}
