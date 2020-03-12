/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:41:57 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialCouponTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialCouponTypeRefIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCouponTypeRef/CrudeFinancialCouponTypeRefIndex.cshtml",
                new CrudeFinancialCouponTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCouponTypeRefDetails(System.String financialCouponTypeRcd) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCouponTypeRef/CrudeFinancialCouponTypeRefDetails.cshtml",
                new CrudeFinancialCouponTypeRefServiceClient().FetchByFinancialCouponTypeRcd(financialCouponTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCouponTypeRefEdit(
            System.String financialCouponTypeRcd
            ) {

            CrudeFinancialCouponTypeRefContract contract = new CrudeFinancialCouponTypeRefServiceClient().FetchByFinancialCouponTypeRcd(financialCouponTypeRcd);

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCouponTypeRef/CrudeFinancialCouponTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCouponTypeRefEdit([Bind()] CrudeFinancialCouponTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialCouponTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialCouponTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCouponTypeRef/CrudeFinancialCouponTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCouponTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeFinancialCouponTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialCouponTypeRef/CrudeFinancialCouponTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCouponTypeRefCreate([Bind()] CrudeFinancialCouponTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialCouponTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialCouponTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCouponTypeRef/CrudeFinancialCouponTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCouponTypeRefDelete(
            System.String financialCouponTypeRcd
            ) {
            new CrudeFinancialCouponTypeRefServiceClient().Delete(financialCouponTypeRcd);

            return RedirectToAction("CrudeFinancialCouponTypeRefIndex");
        }
    }
}
