/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:42:13 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialPaymentVoucherController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialPaymentVoucherIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentVoucher/CrudeFinancialPaymentVoucherIndex.cshtml",
                new CrudeFinancialPaymentVoucherServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentVoucherByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentVoucher/CrudeFinancialPaymentVoucherIndex.cshtml",
                new CrudeFinancialPaymentVoucherServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentVoucherDetails(System.Guid financialPaymentVoucherId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentVoucher/CrudeFinancialPaymentVoucherDetails.cshtml",
                new CrudeFinancialPaymentVoucherServiceClient().FetchByFinancialPaymentVoucherId(financialPaymentVoucherId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentVoucherEdit(
            System.Guid financialPaymentVoucherId
            ) {

            CrudeFinancialPaymentVoucherContract contract = new CrudeFinancialPaymentVoucherServiceClient().FetchByFinancialPaymentVoucherId(financialPaymentVoucherId);
            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentVoucher/CrudeFinancialPaymentVoucherEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentVoucherEdit([Bind()] CrudeFinancialPaymentVoucherContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialPaymentVoucherServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialPaymentVoucherIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentVoucher/CrudeFinancialPaymentVoucherEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentVoucherCreate(System.Guid? userId, System.Guid? financialVoucherId, System.Guid? financialCurrencyId) {
            var contract = new CrudeFinancialPaymentVoucherContract();
            if (userId != null) contract.UserId = (System.Guid) userId;
            if (financialVoucherId != null) contract.FinancialVoucherId = (System.Guid) financialVoucherId;
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
                "~/Views/Crude/Financial/CrudeFinancialPaymentVoucher/CrudeFinancialPaymentVoucherCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentVoucherCreate([Bind()] CrudeFinancialPaymentVoucherContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialPaymentVoucherServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialPaymentVoucherIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentVoucher/CrudeFinancialPaymentVoucherCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentVoucherDelete(
            System.Guid financialPaymentVoucherId
            ) {
            new CrudeFinancialPaymentVoucherServiceClient().Delete(financialPaymentVoucherId);

            return RedirectToAction("CrudeFinancialPaymentVoucherIndex");
        }
    }
}
