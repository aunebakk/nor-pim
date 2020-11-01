/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 5:02:18 PM
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
    public class CrudeFinancialCurrencyController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeFinancialCurrencyIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrency/CrudeFinancialCurrencyIndex.cshtml",
                new CrudeFinancialCurrencyServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeFinancialCurrencyDetails(System.Guid financialCurrencyId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrency/CrudeFinancialCurrencyDetails.cshtml",
                new CrudeFinancialCurrencyServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeFinancialCurrencyEdit(
            System.Guid financialCurrencyId
            ) {

            CrudeFinancialCurrencyContract contract = new CrudeFinancialCurrencyServiceClient().FetchByFinancialCurrencyId(financialCurrencyId);
            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrency/CrudeFinancialCurrencyEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCurrencyEdit([Bind()] CrudeFinancialCurrencyContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialCurrencyServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialCurrencyIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrency/CrudeFinancialCurrencyEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeFinancialCurrencyCreate(System.Guid? userId) {
            var contract = new CrudeFinancialCurrencyContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            contract.ValidFromDateTime = DateTime.UtcNow;

            contract.ValidUntilDateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrency/CrudeFinancialCurrencyCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCurrencyCreate([Bind()] CrudeFinancialCurrencyContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialCurrencyServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialCurrencyIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrency/CrudeFinancialCurrencyCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeFinancialCurrencyDelete(
            System.Guid financialCurrencyId
            ) {
            new CrudeFinancialCurrencyServiceClient().Delete(financialCurrencyId);

            return RedirectToAction("CrudeFinancialCurrencyIndex");
        }
    }
}
