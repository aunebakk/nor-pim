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
    public class CrudeFinancialOrderSourceRefController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialOrderSourceRefIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderSourceRef/CrudeFinancialOrderSourceRefIndex.cshtml",
                new CrudeFinancialOrderSourceRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderSourceRefDetails(System.String financialOrderSourceRcd) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderSourceRef/CrudeFinancialOrderSourceRefDetails.cshtml",
                new CrudeFinancialOrderSourceRefServiceClient().FetchByFinancialOrderSourceRcd(financialOrderSourceRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderSourceRefEdit(
            System.String financialOrderSourceRcd
            ) {

            CrudeFinancialOrderSourceRefContract contract = new CrudeFinancialOrderSourceRefServiceClient().FetchByFinancialOrderSourceRcd(financialOrderSourceRcd);

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderSourceRef/CrudeFinancialOrderSourceRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderSourceRefEdit([Bind()] CrudeFinancialOrderSourceRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialOrderSourceRefServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialOrderSourceRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderSourceRef/CrudeFinancialOrderSourceRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderSourceRefCreate(System.Guid? userId) {
            var contract = new CrudeFinancialOrderSourceRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderSourceRef/CrudeFinancialOrderSourceRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderSourceRefCreate([Bind()] CrudeFinancialOrderSourceRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialOrderSourceRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialOrderSourceRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderSourceRef/CrudeFinancialOrderSourceRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderSourceRefDelete(
            System.String financialOrderSourceRcd
            ) {
            new CrudeFinancialOrderSourceRefServiceClient().Delete(financialOrderSourceRcd);

            return RedirectToAction("CrudeFinancialOrderSourceRefIndex");
        }
    }
}
