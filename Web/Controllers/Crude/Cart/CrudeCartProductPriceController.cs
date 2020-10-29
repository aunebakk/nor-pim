/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 4:19:01 PM
  From Machine: DESKTOP-9A2DH39
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
    public class CrudeCartProductPriceController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeCartProductPriceIndex() {

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceIndex.cshtml",
                new CrudeCartProductPriceServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeCartProductPriceByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceIndex.cshtml",
                new CrudeCartProductPriceServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeCartProductPriceByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceIndex.cshtml",
                new CrudeCartProductPriceServiceClient().FetchByProductId(productId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeCartProductPriceDetails(System.Guid cartProductPriceId) {

            return View(
                "~/Views/Crude/Cart/CrudeCartProductPrice/CrudeCartProductPriceDetails.cshtml",
                new CrudeCartProductPriceServiceClient().FetchByCartProductPriceId(cartProductPriceId)
                );
        }

        // edit details page
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

        // save detail page
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

        // add new entity page
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

        // add new detail page
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

        // delete entity page
        [HttpGet]
        public ActionResult CrudeCartProductPriceDelete(
            System.Guid cartProductPriceId
            ) {
            new CrudeCartProductPriceServiceClient().Delete(cartProductPriceId);

            return RedirectToAction("CrudeCartProductPriceIndex");
        }
    }
}
