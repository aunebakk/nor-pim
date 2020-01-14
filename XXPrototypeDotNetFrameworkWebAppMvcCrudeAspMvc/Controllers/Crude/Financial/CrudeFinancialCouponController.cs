/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:21:27 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialCouponController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialCouponIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCoupon/CrudeFinancialCouponIndex.cshtml",
                new CrudeFinancialCouponServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCouponByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCoupon/CrudeFinancialCouponIndex.cshtml",
                new CrudeFinancialCouponServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCouponDetails(System.Guid financialCouponId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCoupon/CrudeFinancialCouponDetails.cshtml",
                new CrudeFinancialCouponServiceClient().FetchByFinancialCouponId(financialCouponId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCouponEdit(
            System.Guid financialCouponId
            ) {

            CrudeFinancialCouponContract contract = new CrudeFinancialCouponServiceClient().FetchByFinancialCouponId(financialCouponId);
            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.FinancialCouponTypeRcd =
                new SelectList( new CrudeFinancialCouponTypeRefServiceClient().FetchAll(),
                                "FinancialCouponTypeRcd",
                                "FinancialCouponTypeName",
                                contract.FinancialCouponTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialCoupon/CrudeFinancialCouponEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCouponEdit([Bind()] CrudeFinancialCouponContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialCouponServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialCouponIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCoupon/CrudeFinancialCouponEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCouponCreate(System.Guid? financialCurrencyId, System.Guid? userId) {
            var contract = new CrudeFinancialCouponContract();
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            contract.ValidFromDateTime = DateTime.UtcNow;

            contract.ValidUntilDateTime = DateTime.UtcNow;

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            ViewBag.FinancialCouponTypeRcd =
                new SelectList( new CrudeFinancialCouponTypeRefServiceClient().FetchAll(),
                                "FinancialCouponTypeRcd",
                                "FinancialCouponTypeName",
                                contract.FinancialCouponTypeRcd
                                );


            return View(
                "~/Views/Crude/Financial/CrudeFinancialCoupon/CrudeFinancialCouponCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCouponCreate([Bind()] CrudeFinancialCouponContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialCouponServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialCouponIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCoupon/CrudeFinancialCouponCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCouponDelete(
            System.Guid financialCouponId
            ) {
            new CrudeFinancialCouponServiceClient().Delete(financialCouponId);

            return RedirectToAction("CrudeFinancialCouponIndex");
        }
    }
}
