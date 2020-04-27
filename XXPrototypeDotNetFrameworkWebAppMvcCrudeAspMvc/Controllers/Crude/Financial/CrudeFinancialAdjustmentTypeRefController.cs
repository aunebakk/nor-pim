/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:44:02 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialAdjustmentTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialAdjustmentTypeRefIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialAdjustmentTypeRef/CrudeFinancialAdjustmentTypeRefIndex.cshtml",
                new CrudeFinancialAdjustmentTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialAdjustmentTypeRefDetails(System.String financialAdjustmentTypeRcd) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialAdjustmentTypeRef/CrudeFinancialAdjustmentTypeRefDetails.cshtml",
                new CrudeFinancialAdjustmentTypeRefServiceClient().FetchByFinancialAdjustmentTypeRcd(financialAdjustmentTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialAdjustmentTypeRefEdit(
            System.String financialAdjustmentTypeRcd
            ) {

            CrudeFinancialAdjustmentTypeRefContract contract = new CrudeFinancialAdjustmentTypeRefServiceClient().FetchByFinancialAdjustmentTypeRcd(financialAdjustmentTypeRcd);

            return View(
                "~/Views/Crude/Financial/CrudeFinancialAdjustmentTypeRef/CrudeFinancialAdjustmentTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialAdjustmentTypeRefEdit([Bind()] CrudeFinancialAdjustmentTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialAdjustmentTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialAdjustmentTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialAdjustmentTypeRef/CrudeFinancialAdjustmentTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialAdjustmentTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeFinancialAdjustmentTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialAdjustmentTypeRef/CrudeFinancialAdjustmentTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialAdjustmentTypeRefCreate([Bind()] CrudeFinancialAdjustmentTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialAdjustmentTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialAdjustmentTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialAdjustmentTypeRef/CrudeFinancialAdjustmentTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialAdjustmentTypeRefDelete(
            System.String financialAdjustmentTypeRcd
            ) {
            new CrudeFinancialAdjustmentTypeRefServiceClient().Delete(financialAdjustmentTypeRcd);

            return RedirectToAction("CrudeFinancialAdjustmentTypeRefIndex");
        }
    }
}
