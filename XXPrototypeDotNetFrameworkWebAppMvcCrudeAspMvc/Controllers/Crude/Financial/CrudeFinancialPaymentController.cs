/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:20:35 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialPaymentController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialPaymentIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentIndex.cshtml",
                new CrudeFinancialPaymentServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentByFinancialPaymentBankIndex(System.Guid financialPaymentBankId) {
            ViewBag.FinancialPaymentBankId = financialPaymentBankId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentIndex.cshtml",
                new CrudeFinancialPaymentServiceClient().FetchByFinancialPaymentBankId(financialPaymentBankId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentByFinancialPaymentCardIndex(System.Guid financialPaymentCardId) {
            ViewBag.FinancialPaymentCardId = financialPaymentCardId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentIndex.cshtml",
                new CrudeFinancialPaymentServiceClient().FetchByFinancialPaymentCardId(financialPaymentCardId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentDetails(System.Guid financialPaymentId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentDetails.cshtml",
                new CrudeFinancialPaymentServiceClient().FetchByFinancialPaymentId(financialPaymentId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentEdit(
            System.Guid financialPaymentId
            ) {

            CrudeFinancialPaymentContract contract = new CrudeFinancialPaymentServiceClient().FetchByFinancialPaymentId(financialPaymentId);
            ViewBag.FinancialPaymentTypeRcd =
                new SelectList( new CrudeFinancialPaymentTypeRefServiceClient().FetchAll(),
                                "FinancialPaymentTypeRcd",
                                "FinancialPaymentTypeName",
                                contract.FinancialPaymentTypeRcd
                                );

            ViewBag.FinancialPaymentBankId =
                new SelectList( new CrudeFinancialPaymentBankServiceClient().FetchAll(),
                                "FinancialPaymentBankId",
                                "BankName",
                                contract.FinancialPaymentBankId
                                );

            ViewBag.FinancialPaymentCardId =
                new SelectList( new CrudeFinancialPaymentCardServiceClient().FetchAll(),
                                "FinancialPaymentCardId",
                                "NameOnCard",
                                contract.FinancialPaymentCardId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentEdit([Bind()] CrudeFinancialPaymentContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialPaymentServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialPaymentIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCreate(System.Guid? userId, System.Guid? financialPaymentAccountingId, System.Guid? financialPaymentBankId, System.Guid? financialPaymentVoucherId, System.Guid? financialPaymentCardId, System.Guid? financialPaymentCashId, System.Guid? financialPaymentCouponId) {
            var contract = new CrudeFinancialPaymentContract();
            if (userId != null) contract.UserId = (System.Guid) userId;
            if (financialPaymentAccountingId != null) contract.FinancialPaymentAccountingId = (System.Guid) financialPaymentAccountingId;
            if (financialPaymentBankId != null) contract.FinancialPaymentBankId = (System.Guid) financialPaymentBankId;
            if (financialPaymentVoucherId != null) contract.FinancialPaymentVoucherId = (System.Guid) financialPaymentVoucherId;
            if (financialPaymentCardId != null) contract.FinancialPaymentCardId = (System.Guid) financialPaymentCardId;
            if (financialPaymentCashId != null) contract.FinancialPaymentCashId = (System.Guid) financialPaymentCashId;
            if (financialPaymentCouponId != null) contract.FinancialPaymentCouponId = (System.Guid) financialPaymentCouponId;

            ViewBag.FinancialPaymentTypeRcd =
                new SelectList( new CrudeFinancialPaymentTypeRefServiceClient().FetchAll(),
                                "FinancialPaymentTypeRcd",
                                "FinancialPaymentTypeName",
                                contract.FinancialPaymentTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            ViewBag.FinancialPaymentBankId =
                new SelectList( new CrudeFinancialPaymentBankServiceClient().FetchAll(),
                                "FinancialPaymentBankId",
                                "BankName",
                                contract.FinancialPaymentBankId
                                );

            ViewBag.FinancialPaymentCardId =
                new SelectList( new CrudeFinancialPaymentCardServiceClient().FetchAll(),
                                "FinancialPaymentCardId",
                                "NameOnCard",
                                contract.FinancialPaymentCardId
                                );


            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentCreate([Bind()] CrudeFinancialPaymentContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialPaymentServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialPaymentIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPayment/CrudeFinancialPaymentCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentDelete(
            System.Guid financialPaymentId
            ) {
            new CrudeFinancialPaymentServiceClient().Delete(financialPaymentId);

            return RedirectToAction("CrudeFinancialPaymentIndex");
        }
    }
}
