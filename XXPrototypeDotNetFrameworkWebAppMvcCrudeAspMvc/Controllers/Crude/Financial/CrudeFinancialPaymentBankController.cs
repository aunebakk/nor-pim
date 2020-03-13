/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:43:51 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialPaymentBankController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialPaymentBankIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentBank/CrudeFinancialPaymentBankIndex.cshtml",
                new CrudeFinancialPaymentBankServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentBankByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentBank/CrudeFinancialPaymentBankIndex.cshtml",
                new CrudeFinancialPaymentBankServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentBankDetails(System.Guid financialPaymentBankId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentBank/CrudeFinancialPaymentBankDetails.cshtml",
                new CrudeFinancialPaymentBankServiceClient().FetchByFinancialPaymentBankId(financialPaymentBankId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentBankEdit(
            System.Guid financialPaymentBankId
            ) {

            CrudeFinancialPaymentBankContract contract = new CrudeFinancialPaymentBankServiceClient().FetchByFinancialPaymentBankId(financialPaymentBankId);
            ViewBag.FinancialBankAccountNumberTypeRcd =
                new SelectList( new CrudeFinancialBankAccountNumberTypeRefServiceClient().FetchAll(),
                                "FinancialBankAccountNumberTypeRcd",
                                "FinancialBankAccountNumberTypeName",
                                contract.FinancialBankAccountNumberTypeRcd
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
                "~/Views/Crude/Financial/CrudeFinancialPaymentBank/CrudeFinancialPaymentBankEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentBankEdit([Bind()] CrudeFinancialPaymentBankContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialPaymentBankServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialPaymentBankIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentBank/CrudeFinancialPaymentBankEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentBankCreate(System.Guid? userId, System.Guid? financialCurrencyId) {
            var contract = new CrudeFinancialPaymentBankContract();
            if (userId != null) contract.UserId = (System.Guid) userId;
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            ViewBag.FinancialBankAccountNumberTypeRcd =
                new SelectList( new CrudeFinancialBankAccountNumberTypeRefServiceClient().FetchAll(),
                                "FinancialBankAccountNumberTypeRcd",
                                "FinancialBankAccountNumberTypeName",
                                contract.FinancialBankAccountNumberTypeRcd
                                );

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );


            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentBank/CrudeFinancialPaymentBankCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentBankCreate([Bind()] CrudeFinancialPaymentBankContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialPaymentBankServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialPaymentBankIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentBank/CrudeFinancialPaymentBankCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentBankDelete(
            System.Guid financialPaymentBankId
            ) {
            new CrudeFinancialPaymentBankServiceClient().Delete(financialPaymentBankId);

            return RedirectToAction("CrudeFinancialPaymentBankIndex");
        }
    }
}
