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
    public class CrudeFinancialPaymentCouponController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCouponIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCoupon/CrudeFinancialPaymentCouponIndex.cshtml",
                new CrudeFinancialPaymentCouponServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCouponByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCoupon/CrudeFinancialPaymentCouponIndex.cshtml",
                new CrudeFinancialPaymentCouponServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCouponDetails(System.Guid financialPaymentCouponId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCoupon/CrudeFinancialPaymentCouponDetails.cshtml",
                new CrudeFinancialPaymentCouponServiceClient().FetchByFinancialPaymentCouponId(financialPaymentCouponId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCouponEdit(
            System.Guid financialPaymentCouponId
            ) {

            CrudeFinancialPaymentCouponContract contract = new CrudeFinancialPaymentCouponServiceClient().FetchByFinancialPaymentCouponId(financialPaymentCouponId);
            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCoupon/CrudeFinancialPaymentCouponEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentCouponEdit([Bind()] CrudeFinancialPaymentCouponContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialPaymentCouponServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialPaymentCouponIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCoupon/CrudeFinancialPaymentCouponEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCouponCreate(System.Guid? financialCouponId, System.Guid? userId, System.Guid? financialCurrencyId) {
            var contract = new CrudeFinancialPaymentCouponContract();
            if (financialCouponId != null) contract.FinancialCouponId = (System.Guid) financialCouponId;
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
                "~/Views/Crude/Financial/CrudeFinancialPaymentCoupon/CrudeFinancialPaymentCouponCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentCouponCreate([Bind()] CrudeFinancialPaymentCouponContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialPaymentCouponServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialPaymentCouponIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCoupon/CrudeFinancialPaymentCouponCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCouponDelete(
            System.Guid financialPaymentCouponId
            ) {
            new CrudeFinancialPaymentCouponServiceClient().Delete(financialPaymentCouponId);

            return RedirectToAction("CrudeFinancialPaymentCouponIndex");
        }
    }
}
