/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 9:17:40 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.AspMvc.Controllers {

    // controller class for mvc
    public class CrudeCartProductController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeCartProductIndex() {

            return View(
                "~/Views/Crude/Cart/CrudeCartProduct/CrudeCartProductIndex.cshtml",
                new CrudeCartProductServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeCartProductByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;

            return View(
                "~/Views/Crude/Cart/CrudeCartProduct/CrudeCartProductIndex.cshtml",
                new CrudeCartProductServiceClient().FetchByClientId(clientId)
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeCartProductByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Cart/CrudeCartProduct/CrudeCartProductIndex.cshtml",
                new CrudeCartProductServiceClient().FetchByProductId(productId)
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeCartProductByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Cart/CrudeCartProduct/CrudeCartProductIndex.cshtml",
                new CrudeCartProductServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeCartProductDetails(System.Guid cartProductId) {

            return View(
                "~/Views/Crude/Cart/CrudeCartProduct/CrudeCartProductDetails.cshtml",
                new CrudeCartProductServiceClient().FetchByCartProductId(cartProductId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeCartProductEdit(
            System.Guid cartProductId
            ) {

            CrudeCartProductContract contract = new CrudeCartProductServiceClient().FetchByCartProductId(cartProductId);
            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Cart/CrudeCartProduct/CrudeCartProductEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeCartProductEdit([Bind()] CrudeCartProductContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeCartProductServiceClient().Update(contract);

                return RedirectToAction("CrudeCartProductIndex");
            }

            return View(
                "~/Views/Crude/Cart/CrudeCartProduct/CrudeCartProductEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeCartProductCreate(System.Guid? clientId, System.Guid? productId, System.Guid? financialCurrencyId, System.Guid? sessionId, System.Guid? aspId, System.Guid? userId) {
            var contract = new CrudeCartProductContract();
            if (clientId != null) contract.ClientId = (System.Guid) clientId;
            if (productId != null) contract.ProductId = (System.Guid) productId;
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;
            if (sessionId != null) contract.SessionId = (System.Guid) sessionId;
            if (aspId != null) contract.AspId = (System.Guid) aspId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Cart/CrudeCartProduct/CrudeCartProductCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeCartProductCreate([Bind()] CrudeCartProductContract contract) {
            if (ModelState.IsValid) {

                new CrudeCartProductServiceClient().Insert(contract);

                return RedirectToAction("CrudeCartProductIndex");
            }

            return View(
                "~/Views/Crude/Cart/CrudeCartProduct/CrudeCartProductCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeCartProductDelete(
            System.Guid cartProductId
            ) {
            new CrudeCartProductServiceClient().Delete(cartProductId);

            return RedirectToAction("CrudeCartProductIndex");
        }
    }
}
