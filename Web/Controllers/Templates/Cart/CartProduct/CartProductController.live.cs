/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 6/24/2020 4:42:04 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateWithDurianByTypescriptGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;
using System.Collections.Generic;
using SolutionNorSolutionPim.mvc.Controllers;
using Microsoft.AspNet.Identity;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public partial class CartProductController : Controller {

        [HttpGet]
        public ActionResult CartProductIndexLive() {
            Guid userId = Logging.UserId(User.Identity, ViewBag);

            List<GetCartProductContract> cart_product = null;

            if (!string.IsNullOrEmpty(User.Identity.GetUserId())) 
                cart_product = 
                    new CartProductSearchServiceClient().GetCartProduct(
                            clientId : userId, 
                            productId : Guid.Empty, 
                            financialCurrencyId: Guid.Empty, 
                            userId : Guid.Empty, 
                            cartProductId : Guid.Empty,
                            sessionIdentificator : string.Empty
                        );
            else
                cart_product = 
                    new CartProductSearchServiceClient().GetCartProduct(
                            clientId : Guid.Empty,
                            productId : Guid.Empty, 
                            financialCurrencyId: Guid.Empty, 
                            userId : Guid.Empty, 
                            cartProductId : Guid.Empty,
                            sessionIdentificator : Session.SessionID
                        );

            return View(
                "~/Views/Templates/Cart/CartProduct/CartProductIndex.cshtml",
                cart_product
                );
        }

    }
}
