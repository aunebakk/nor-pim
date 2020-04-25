/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:24:19 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialOrderIdentifierTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialOrderIdentifierTypeRefIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderIdentifierTypeRef/CrudeFinancialOrderIdentifierTypeRefIndex.cshtml",
                new CrudeFinancialOrderIdentifierTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderIdentifierTypeRefDetails(System.String financialOrderIdentifierTypeRcd) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderIdentifierTypeRef/CrudeFinancialOrderIdentifierTypeRefDetails.cshtml",
                new CrudeFinancialOrderIdentifierTypeRefServiceClient().FetchByFinancialOrderIdentifierTypeRcd(financialOrderIdentifierTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderIdentifierTypeRefEdit(
            System.String financialOrderIdentifierTypeRcd
            ) {

            CrudeFinancialOrderIdentifierTypeRefContract contract = new CrudeFinancialOrderIdentifierTypeRefServiceClient().FetchByFinancialOrderIdentifierTypeRcd(financialOrderIdentifierTypeRcd);

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderIdentifierTypeRef/CrudeFinancialOrderIdentifierTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderIdentifierTypeRefEdit([Bind()] CrudeFinancialOrderIdentifierTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialOrderIdentifierTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialOrderIdentifierTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderIdentifierTypeRef/CrudeFinancialOrderIdentifierTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderIdentifierTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeFinancialOrderIdentifierTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderIdentifierTypeRef/CrudeFinancialOrderIdentifierTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderIdentifierTypeRefCreate([Bind()] CrudeFinancialOrderIdentifierTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialOrderIdentifierTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialOrderIdentifierTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderIdentifierTypeRef/CrudeFinancialOrderIdentifierTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderIdentifierTypeRefDelete(
            System.String financialOrderIdentifierTypeRcd
            ) {
            new CrudeFinancialOrderIdentifierTypeRefServiceClient().Delete(financialOrderIdentifierTypeRcd);

            return RedirectToAction("CrudeFinancialOrderIdentifierTypeRefIndex");
        }
    }
}
