/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:32:42 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialVoucherController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialVoucherIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialVoucher/CrudeFinancialVoucherIndex.cshtml",
                new CrudeFinancialVoucherServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialVoucherByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialVoucher/CrudeFinancialVoucherIndex.cshtml",
                new CrudeFinancialVoucherServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialVoucherDetails(System.Guid financialVoucherId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialVoucher/CrudeFinancialVoucherDetails.cshtml",
                new CrudeFinancialVoucherServiceClient().FetchByFinancialVoucherId(financialVoucherId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialVoucherEdit(
            System.Guid financialVoucherId
            ) {

            CrudeFinancialVoucherContract contract = new CrudeFinancialVoucherServiceClient().FetchByFinancialVoucherId(financialVoucherId);
            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.FinancialVoucherTypeRcd =
                new SelectList( new CrudeFinancialVoucherTypeRefServiceClient().FetchAll(),
                                "FinancialVoucherTypeRcd",
                                "FinancialVoucherTypeName",
                                contract.FinancialVoucherTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialVoucher/CrudeFinancialVoucherEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialVoucherEdit([Bind()] CrudeFinancialVoucherContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialVoucherServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialVoucherIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialVoucher/CrudeFinancialVoucherEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialVoucherCreate(System.Guid? userId, System.Guid? financialCurrencyId) {
            var contract = new CrudeFinancialVoucherContract();
            if (userId != null) contract.UserId = (System.Guid) userId;
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            contract.ValidFromDateTime = DateTime.UtcNow;

            contract.ValidUntilDateTime = DateTime.UtcNow;

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.FinancialVoucherTypeRcd =
                new SelectList( new CrudeFinancialVoucherTypeRefServiceClient().FetchAll(),
                                "FinancialVoucherTypeRcd",
                                "FinancialVoucherTypeName",
                                contract.FinancialVoucherTypeRcd
                                );


            return View(
                "~/Views/Crude/Financial/CrudeFinancialVoucher/CrudeFinancialVoucherCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialVoucherCreate([Bind()] CrudeFinancialVoucherContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialVoucherServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialVoucherIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialVoucher/CrudeFinancialVoucherCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialVoucherDelete(
            System.Guid financialVoucherId
            ) {
            new CrudeFinancialVoucherServiceClient().Delete(financialVoucherId);

            return RedirectToAction("CrudeFinancialVoucherIndex");
        }
    }
}
