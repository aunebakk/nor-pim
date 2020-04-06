/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:29:43 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialOrderEventTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialOrderEventTypeRefIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderEventTypeRef/CrudeFinancialOrderEventTypeRefIndex.cshtml",
                new CrudeFinancialOrderEventTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderEventTypeRefDetails(System.String financialOrderEventTypeRcd) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderEventTypeRef/CrudeFinancialOrderEventTypeRefDetails.cshtml",
                new CrudeFinancialOrderEventTypeRefServiceClient().FetchByFinancialOrderEventTypeRcd(financialOrderEventTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderEventTypeRefEdit(
            System.String financialOrderEventTypeRcd
            ) {

            CrudeFinancialOrderEventTypeRefContract contract = new CrudeFinancialOrderEventTypeRefServiceClient().FetchByFinancialOrderEventTypeRcd(financialOrderEventTypeRcd);

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderEventTypeRef/CrudeFinancialOrderEventTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderEventTypeRefEdit([Bind()] CrudeFinancialOrderEventTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialOrderEventTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialOrderEventTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderEventTypeRef/CrudeFinancialOrderEventTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderEventTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeFinancialOrderEventTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderEventTypeRef/CrudeFinancialOrderEventTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderEventTypeRefCreate([Bind()] CrudeFinancialOrderEventTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialOrderEventTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialOrderEventTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderEventTypeRef/CrudeFinancialOrderEventTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderEventTypeRefDelete(
            System.String financialOrderEventTypeRcd
            ) {
            new CrudeFinancialOrderEventTypeRefServiceClient().Delete(financialOrderEventTypeRcd);

            return RedirectToAction("CrudeFinancialOrderEventTypeRefIndex");
        }
    }
}
