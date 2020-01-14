/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:21:17 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialTaxTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialTaxTypeRefIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialTaxTypeRef/CrudeFinancialTaxTypeRefIndex.cshtml",
                new CrudeFinancialTaxTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialTaxTypeRefDetails(System.String financialTaxTypeRcd) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialTaxTypeRef/CrudeFinancialTaxTypeRefDetails.cshtml",
                new CrudeFinancialTaxTypeRefServiceClient().FetchByFinancialTaxTypeRcd(financialTaxTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialTaxTypeRefEdit(
            System.String financialTaxTypeRcd
            ) {

            CrudeFinancialTaxTypeRefContract contract = new CrudeFinancialTaxTypeRefServiceClient().FetchByFinancialTaxTypeRcd(financialTaxTypeRcd);

            return View(
                "~/Views/Crude/Financial/CrudeFinancialTaxTypeRef/CrudeFinancialTaxTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialTaxTypeRefEdit([Bind()] CrudeFinancialTaxTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialTaxTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialTaxTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialTaxTypeRef/CrudeFinancialTaxTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialTaxTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeFinancialTaxTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialTaxTypeRef/CrudeFinancialTaxTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialTaxTypeRefCreate([Bind()] CrudeFinancialTaxTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialTaxTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialTaxTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialTaxTypeRef/CrudeFinancialTaxTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialTaxTypeRefDelete(
            System.String financialTaxTypeRcd
            ) {
            new CrudeFinancialTaxTypeRefServiceClient().Delete(financialTaxTypeRcd);

            return RedirectToAction("CrudeFinancialTaxTypeRefIndex");
        }
    }
}
