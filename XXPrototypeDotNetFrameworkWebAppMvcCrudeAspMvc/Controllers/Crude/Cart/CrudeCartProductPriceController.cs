/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:46:47 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeCartProductPriceController : Controller {

        [HttpGet]
        public ActionResult CrudeCartProductPriceIndex() {

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceIndex.cshtml",
                new CrudeCartProductPriceServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeCartProductPriceByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceIndex.cshtml",
                new CrudeCartProductPriceServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeCartProductPriceByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceIndex.cshtml",
                new CrudeCartProductPriceServiceClient().FetchByProductId(productId)
                );
        }

        [HttpGet]
        public ActionResult CrudeCartProductPriceDetails(System.Guid cartProductPriceId) {

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceDetails.cshtml",
                new CrudeCartProductPriceServiceClient().FetchByCartProductPriceId(cartProductPriceId)
                );
        }

        [HttpGet]
        public ActionResult CrudeCartProductPriceEdit(
            System.Guid cartProductPriceId
            ) {

            CrudeCartProductPriceContract contract = new CrudeCartProductPriceServiceClient().FetchByCartProductPriceId(cartProductPriceId);
            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeCartProductPriceEdit([Bind()] CrudeCartProductPriceContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeCartProductPriceServiceClient().Update(contract);

                return RedirectToAction("CrudeCartProductPriceIndex");
            }

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeCartProductPriceCreate(System.Guid? financialCurrencyId, System.Guid? userId, System.Guid? productId) {
            var contract = new CrudeCartProductPriceContract();
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;
            if (userId != null) contract.UserId = (System.Guid) userId;
            if (productId != null) contract.ProductId = (System.Guid) productId;

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

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );


            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeCartProductPriceCreate([Bind()] CrudeCartProductPriceContract contract) {
            if (ModelState.IsValid) {

                new CrudeCartProductPriceServiceClient().Insert(contract);

                return RedirectToAction("CrudeCartProductPriceIndex");
            }

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeCartProductPriceDelete(
            System.Guid cartProductPriceId
            ) {
            new CrudeCartProductPriceServiceClient().Delete(cartProductPriceId);

            return RedirectToAction("CrudeCartProductPriceIndex");
        }
    }
}
