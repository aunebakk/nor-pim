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
    public class CrudeFinancialVoucherTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialVoucherTypeRefIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialVoucherTypeRef/CrudeFinancialVoucherTypeRefIndex.cshtml",
                new CrudeFinancialVoucherTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialVoucherTypeRefDetails(System.String financialVoucherTypeRcd) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialVoucherTypeRef/CrudeFinancialVoucherTypeRefDetails.cshtml",
                new CrudeFinancialVoucherTypeRefServiceClient().FetchByFinancialVoucherTypeRcd(financialVoucherTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialVoucherTypeRefEdit(
            System.String financialVoucherTypeRcd
            ) {

            CrudeFinancialVoucherTypeRefContract contract = new CrudeFinancialVoucherTypeRefServiceClient().FetchByFinancialVoucherTypeRcd(financialVoucherTypeRcd);

            return View(
                "~/Views/Crude/Financial/CrudeFinancialVoucherTypeRef/CrudeFinancialVoucherTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialVoucherTypeRefEdit([Bind()] CrudeFinancialVoucherTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialVoucherTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialVoucherTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialVoucherTypeRef/CrudeFinancialVoucherTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialVoucherTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeFinancialVoucherTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialVoucherTypeRef/CrudeFinancialVoucherTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialVoucherTypeRefCreate([Bind()] CrudeFinancialVoucherTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialVoucherTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialVoucherTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialVoucherTypeRef/CrudeFinancialVoucherTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialVoucherTypeRefDelete(
            System.String financialVoucherTypeRcd
            ) {
            new CrudeFinancialVoucherTypeRefServiceClient().Delete(financialVoucherTypeRcd);

            return RedirectToAction("CrudeFinancialVoucherTypeRefIndex");
        }
    }
}
