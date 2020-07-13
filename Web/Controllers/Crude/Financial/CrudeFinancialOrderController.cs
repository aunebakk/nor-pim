/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 2:50:49 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialOrderController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialOrderIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrder/CrudeFinancialOrderIndex.cshtml",
                new CrudeFinancialOrderServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderDetails(System.Guid financialOrderId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrder/CrudeFinancialOrderDetails.cshtml",
                new CrudeFinancialOrderServiceClient().FetchByFinancialOrderId(financialOrderId)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeFinancialOrderDelete(
            System.Guid financialOrderId
            ) {
            new CrudeFinancialOrderServiceClient().Delete(financialOrderId);

            return RedirectToAction("CrudeFinancialOrderIndex");
        }
    }
}
