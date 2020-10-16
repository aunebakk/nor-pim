/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:03:39 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateWithDurianByTypescriptGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public partial class CartProductController : Controller {

        [HttpGet]
        public ActionResult CartProductIndex(System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, System.Guid userId, System.Guid cartProductId, string sessionIdentificator) {

            List<GetCartProductContract> cart_product =
                new CartProductSearchService().GetCartProduct(clientId, productId, financialCurrencyId, userId, cartProductId, sessionIdentificator);

            return View(
                "~/Views/Templates/Cart/CartProduct/CartProductIndex.cshtml",
                cart_product
                );
        }

    }
}
