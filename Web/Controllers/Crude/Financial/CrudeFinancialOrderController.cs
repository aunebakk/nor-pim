/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 9:08:06 PM
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
    public class CrudeFinancialOrderController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeFinancialOrderIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrder/CrudeFinancialOrderIndex.cshtml",
                new CrudeFinancialOrderServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeFinancialOrderDetails(System.Guid financialOrderId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrder/CrudeFinancialOrderDetails.cshtml",
                new CrudeFinancialOrderServiceClient().FetchByFinancialOrderId(financialOrderId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeFinancialOrderEdit(
            System.Guid financialOrderId
            ) {

            CrudeFinancialOrderContract contract = new CrudeFinancialOrderServiceClient().FetchByFinancialOrderId(financialOrderId);
            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrder/CrudeFinancialOrderEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderEdit([Bind()] CrudeFinancialOrderContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialOrderServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialOrderIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrder/CrudeFinancialOrderEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeFinancialOrderCreate(System.Guid? userId, System.Guid? locationAddressId, System.Guid? financialCurrencyId, System.Guid? clientId) {
            var contract = new CrudeFinancialOrderContract();
            if (userId != null) contract.UserId = (System.Guid) userId;
            if (locationAddressId != null) contract.LocationAddressId = (System.Guid) locationAddressId;
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;
            if (clientId != null) contract.ClientId = (System.Guid) clientId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrder/CrudeFinancialOrderCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderCreate([Bind()] CrudeFinancialOrderContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialOrderServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialOrderIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrder/CrudeFinancialOrderCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeFinancialOrderDelete(
            System.Guid financialOrderId
            ) {
            new CrudeFinancialOrderServiceClient().Delete(financialOrderId);

            return RedirectToAction("CrudeFinancialOrderIndex");
        }
    }
}
