/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/30/2020 6:40:52 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeCartProductController : Controller {

        [HttpGet]
        public ActionResult CrudeCartProductIndex() {

            return View(
                "~/Views/Crude/Cart/CrudeCartProduct/CrudeCartProductIndex.cshtml",
                new CrudeCartProductServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeCartProductByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;

            return View(
                "~/Views/Crude/Cart/CrudeCartProduct/CrudeCartProductIndex.cshtml",
                new CrudeCartProductServiceClient().FetchByClientId(clientId)
                );
        }

        [HttpGet]
        public ActionResult CrudeCartProductByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Cart/CrudeCartProduct/CrudeCartProductIndex.cshtml",
                new CrudeCartProductServiceClient().FetchByProductId(productId)
                );
        }

        [HttpGet]
        public ActionResult CrudeCartProductByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Cart/CrudeCartProduct/CrudeCartProductIndex.cshtml",
                new CrudeCartProductServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeCartProductDetails(System.Guid cartProductId) {

            return View(
                "~/Views/Crude/Cart/CrudeCartProduct/CrudeCartProductDetails.cshtml",
                new CrudeCartProductServiceClient().FetchByCartProductId(cartProductId)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeCartProductDelete(
            System.Guid cartProductId
            ) {
            new CrudeCartProductServiceClient().Delete(cartProductId);

            return RedirectToAction("CrudeCartProductIndex");
        }
    }
}
