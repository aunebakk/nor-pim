/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:21:09 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialOrderTransactionTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialOrderTransactionTypeRefIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderTransactionTypeRef/CrudeFinancialOrderTransactionTypeRefIndex.cshtml",
                new CrudeFinancialOrderTransactionTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderTransactionTypeRefDetails(System.String financialOrderTransactionTypeRcd) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderTransactionTypeRef/CrudeFinancialOrderTransactionTypeRefDetails.cshtml",
                new CrudeFinancialOrderTransactionTypeRefServiceClient().FetchByFinancialOrderTransactionTypeRcd(financialOrderTransactionTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderTransactionTypeRefEdit(
            System.String financialOrderTransactionTypeRcd
            ) {

            CrudeFinancialOrderTransactionTypeRefContract contract = new CrudeFinancialOrderTransactionTypeRefServiceClient().FetchByFinancialOrderTransactionTypeRcd(financialOrderTransactionTypeRcd);

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderTransactionTypeRef/CrudeFinancialOrderTransactionTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderTransactionTypeRefEdit([Bind()] CrudeFinancialOrderTransactionTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialOrderTransactionTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialOrderTransactionTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderTransactionTypeRef/CrudeFinancialOrderTransactionTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderTransactionTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeFinancialOrderTransactionTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderTransactionTypeRef/CrudeFinancialOrderTransactionTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderTransactionTypeRefCreate([Bind()] CrudeFinancialOrderTransactionTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialOrderTransactionTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialOrderTransactionTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderTransactionTypeRef/CrudeFinancialOrderTransactionTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderTransactionTypeRefDelete(
            System.String financialOrderTransactionTypeRcd
            ) {
            new CrudeFinancialOrderTransactionTypeRefServiceClient().Delete(financialOrderTransactionTypeRcd);

            return RedirectToAction("CrudeFinancialOrderTransactionTypeRefIndex");
        }
    }
}
