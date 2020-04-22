/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:53:33 AM
  Template: sql2x.TemplateByServiceTableCrudGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public partial class CartProductController : Controller {

        [HttpGet]
        public ActionResult CartProductIndex() {

            return RedirectToAction(
                    "CartProductEdit",
                    new {    cartProductId = Guid.Empty    }
                    );
        }

        [HttpGet]
        public ActionResult CartProductEdit(
            ) {

            CartProductContract cartProductContract =
                new CartProductServiceClient().
                        CartProductCompleteGet(
                            Guid.Empty,
                            new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
                            );


            return View(
                "~/Views/Templates/Cart/CartProduct/CartProductEdit.cshtml",
                cartProductContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CartProductEdit(
            [Bind()] CartProductContract cartProductContract
            ) {
            new CartProductServiceClient().
                    CartProductCompleteUpdate(
                        Guid.Empty,
                        cartProductContract,
                        new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
                        );

            return RedirectToAction(
                    "CartProductEdit",
                    new {    cartProductId = Guid.Empty}
                    );
        }

        [HttpGet]
        public ActionResult CartProductCreate(System.Guid? clientId, System.Guid? productId, System.Guid? financialCurrencyId, System.Guid? userId) {
            var cartProductContract = new CartProductContract();
            cartProductContract.CartProductNew = new CrudeCartProductContract();
            if (clientId != null) cartProductContract.CartProductNew.ClientId = (System.Guid) clientId;
            if (productId != null) cartProductContract.CartProductNew.ProductId = (System.Guid) productId;
            if (financialCurrencyId != null) cartProductContract.CartProductNew.FinancialCurrencyId = (System.Guid) financialCurrencyId;
            if (userId != null) cartProductContract.CartProductNew.UserId = (System.Guid) userId;

            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                cartProductContract.CartProductNew.ClientId
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                cartProductContract.CartProductNew.ProductId
                                );

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                cartProductContract.CartProductNew.FinancialCurrencyId
                                );

            if (userId == null)
                cartProductContract.CartProductNew.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(cartProductContract.CartProductNew.UserId).DefaultUserName;

            cartProductContract.CartProductNew.DateTime = DateTime.UtcNow;

            return View(
                "~/Views/Templates/Cart/CartProduct/CartProductCreate.cshtml",
                cartProductContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CartProductCreate([Bind()] CartProductContract cartProductContract, System.Guid clientId,System.Guid productId,System.Guid financialCurrencyId) {
            if (ModelState.IsValid) {

                cartProductContract.CartProductNew.ClientId = clientId;
                cartProductContract.CartProductNew.ProductId = productId;
                cartProductContract.CartProductNew.FinancialCurrencyId = financialCurrencyId;
                new CrudeCartProductServiceClient().Insert(cartProductContract.CartProductNew);

                return RedirectToAction(
                        "CartProductEdit",
                        new {    cartProductId = Guid.Empty}
                        );
            }

            return View(
                "~/Views/Templates/Cart/CartProduct/CartProductCreate.cshtml",
                cartProductContract
                );
        }

    }
}
