/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:21:11 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialPaymentAccountingController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialPaymentAccountingIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingIndex.cshtml",
                new CrudeFinancialPaymentAccountingServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentAccountingByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingIndex.cshtml",
                new CrudeFinancialPaymentAccountingServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentAccountingDetails(System.Guid financialPaymentAccountingId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingDetails.cshtml",
                new CrudeFinancialPaymentAccountingServiceClient().FetchByFinancialPaymentAccountingId(financialPaymentAccountingId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentAccountingEdit(
            System.Guid financialPaymentAccountingId
            ) {

            CrudeFinancialPaymentAccountingContract contract = new CrudeFinancialPaymentAccountingServiceClient().FetchByFinancialPaymentAccountingId(financialPaymentAccountingId);
            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentAccountingEdit([Bind()] CrudeFinancialPaymentAccountingContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialPaymentAccountingServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialPaymentAccountingIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentAccountingCreate(System.Guid? userId, System.Guid? financialCurrencyId) {
            var contract = new CrudeFinancialPaymentAccountingContract();
            if (userId != null) contract.UserId = (System.Guid) userId;
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );


            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentAccountingCreate([Bind()] CrudeFinancialPaymentAccountingContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialPaymentAccountingServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialPaymentAccountingIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentAccountingDelete(
            System.Guid financialPaymentAccountingId
            ) {
            new CrudeFinancialPaymentAccountingServiceClient().Delete(financialPaymentAccountingId);

            return RedirectToAction("CrudeFinancialPaymentAccountingIndex");
        }
    }
}
