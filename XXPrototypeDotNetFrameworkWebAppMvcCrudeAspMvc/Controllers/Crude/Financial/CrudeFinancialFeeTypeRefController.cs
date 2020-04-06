/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:29:37 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialFeeTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialFeeTypeRefIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialFeeTypeRef/CrudeFinancialFeeTypeRefIndex.cshtml",
                new CrudeFinancialFeeTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialFeeTypeRefDetails(System.String financialFeeTypeRcd) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialFeeTypeRef/CrudeFinancialFeeTypeRefDetails.cshtml",
                new CrudeFinancialFeeTypeRefServiceClient().FetchByFinancialFeeTypeRcd(financialFeeTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialFeeTypeRefEdit(
            System.String financialFeeTypeRcd
            ) {

            CrudeFinancialFeeTypeRefContract contract = new CrudeFinancialFeeTypeRefServiceClient().FetchByFinancialFeeTypeRcd(financialFeeTypeRcd);

            return View(
                "~/Views/Crude/Financial/CrudeFinancialFeeTypeRef/CrudeFinancialFeeTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialFeeTypeRefEdit([Bind()] CrudeFinancialFeeTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialFeeTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialFeeTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialFeeTypeRef/CrudeFinancialFeeTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialFeeTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeFinancialFeeTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialFeeTypeRef/CrudeFinancialFeeTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialFeeTypeRefCreate([Bind()] CrudeFinancialFeeTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialFeeTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialFeeTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialFeeTypeRef/CrudeFinancialFeeTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialFeeTypeRefDelete(
            System.String financialFeeTypeRcd
            ) {
            new CrudeFinancialFeeTypeRefServiceClient().Delete(financialFeeTypeRcd);

            return RedirectToAction("CrudeFinancialFeeTypeRefIndex");
        }
    }
}
