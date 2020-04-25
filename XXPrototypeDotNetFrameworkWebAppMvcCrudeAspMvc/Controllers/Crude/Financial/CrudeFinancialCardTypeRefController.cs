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
    public class CrudeFinancialCardTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialCardTypeRefIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCardTypeRef/CrudeFinancialCardTypeRefIndex.cshtml",
                new CrudeFinancialCardTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCardTypeRefDetails(System.String financialCardTypeRcd) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCardTypeRef/CrudeFinancialCardTypeRefDetails.cshtml",
                new CrudeFinancialCardTypeRefServiceClient().FetchByFinancialCardTypeRcd(financialCardTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCardTypeRefEdit(
            System.String financialCardTypeRcd
            ) {

            CrudeFinancialCardTypeRefContract contract = new CrudeFinancialCardTypeRefServiceClient().FetchByFinancialCardTypeRcd(financialCardTypeRcd);

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCardTypeRef/CrudeFinancialCardTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCardTypeRefEdit([Bind()] CrudeFinancialCardTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialCardTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialCardTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCardTypeRef/CrudeFinancialCardTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCardTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeFinancialCardTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialCardTypeRef/CrudeFinancialCardTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCardTypeRefCreate([Bind()] CrudeFinancialCardTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialCardTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialCardTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCardTypeRef/CrudeFinancialCardTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCardTypeRefDelete(
            System.String financialCardTypeRcd
            ) {
            new CrudeFinancialCardTypeRefServiceClient().Delete(financialCardTypeRcd);

            return RedirectToAction("CrudeFinancialCardTypeRefIndex");
        }
    }
}
