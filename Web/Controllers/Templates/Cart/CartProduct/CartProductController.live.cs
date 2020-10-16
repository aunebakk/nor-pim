/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 6/24/2020 4:42:04 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateWithDurianByTypescriptGenerator.ControllerBeginning
*/
using Microsoft.AspNet.Identity;
using SolutionNorSolutionPim.BusinessLogicLayer;
using SolutionNorSolutionPim.mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public partial class CartProductController : Controller {

        [HttpGet]
        public ActionResult CartProductIndexLive() {
            Guid userId = Logging.UserId(User.Identity, ViewBag);

            List<GetCartProductContract> cart_product = null;

            if (!string.IsNullOrEmpty(User.Identity.GetUserId())) {
                cart_product =
                    new CartProductSearchService().GetCartProduct(
                            clientId: userId,
                            productId: Guid.Empty,
                            financialCurrencyId: Guid.Empty,
                            userId: Guid.Empty,
                            cartProductId: Guid.Empty,
                            sessionIdentificator: string.Empty
                        );
            } else {
                cart_product =
                    new CartProductSearchService().GetCartProduct(
                            clientId: Guid.Empty,
                            productId: Guid.Empty,
                            financialCurrencyId: Guid.Empty,
                            userId: Guid.Empty,
                            cartProductId: Guid.Empty,
                            sessionIdentificator: Session.SessionID
                        );
            }

            return View(
                "~/Views/Templates/Cart/CartProduct/CartProductIndex.cshtml",
                cart_product
                );
        }

    }
}
