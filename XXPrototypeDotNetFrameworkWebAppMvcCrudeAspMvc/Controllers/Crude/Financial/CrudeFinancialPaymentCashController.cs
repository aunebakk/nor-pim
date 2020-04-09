/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:37:05 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialPaymentCashController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCashIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCash/CrudeFinancialPaymentCashIndex.cshtml",
                new CrudeFinancialPaymentCashServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCashByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCash/CrudeFinancialPaymentCashIndex.cshtml",
                new CrudeFinancialPaymentCashServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCashDetails(System.Guid financialPaymentCashId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCash/CrudeFinancialPaymentCashDetails.cshtml",
                new CrudeFinancialPaymentCashServiceClient().FetchByFinancialPaymentCashId(financialPaymentCashId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCashEdit(
            System.Guid financialPaymentCashId
            ) {

            CrudeFinancialPaymentCashContract contract = new CrudeFinancialPaymentCashServiceClient().FetchByFinancialPaymentCashId(financialPaymentCashId);
            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCash/CrudeFinancialPaymentCashEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentCashEdit([Bind()] CrudeFinancialPaymentCashContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialPaymentCashServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialPaymentCashIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCash/CrudeFinancialPaymentCashEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCashCreate(System.Guid? userId, System.Guid? financialCurrencyId) {
            var contract = new CrudeFinancialPaymentCashContract();
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
                "~/Views/Crude/Financial/CrudeFinancialPaymentCash/CrudeFinancialPaymentCashCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentCashCreate([Bind()] CrudeFinancialPaymentCashContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialPaymentCashServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialPaymentCashIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCash/CrudeFinancialPaymentCashCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCashDelete(
            System.Guid financialPaymentCashId
            ) {
            new CrudeFinancialPaymentCashServiceClient().Delete(financialPaymentCashId);

            return RedirectToAction("CrudeFinancialPaymentCashIndex");
        }
    }
}
