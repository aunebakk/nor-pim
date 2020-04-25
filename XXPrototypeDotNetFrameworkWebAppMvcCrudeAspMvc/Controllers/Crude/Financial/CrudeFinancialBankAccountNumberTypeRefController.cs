/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:44:40 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialBankAccountNumberTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialBankAccountNumberTypeRefIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialBankAccountNumberTypeRef/CrudeFinancialBankAccountNumberTypeRefIndex.cshtml",
                new CrudeFinancialBankAccountNumberTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialBankAccountNumberTypeRefDetails(System.String financialBankAccountNumberTypeRcd) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialBankAccountNumberTypeRef/CrudeFinancialBankAccountNumberTypeRefDetails.cshtml",
                new CrudeFinancialBankAccountNumberTypeRefServiceClient().FetchByFinancialBankAccountNumberTypeRcd(financialBankAccountNumberTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialBankAccountNumberTypeRefEdit(
            System.String financialBankAccountNumberTypeRcd
            ) {

            CrudeFinancialBankAccountNumberTypeRefContract contract = new CrudeFinancialBankAccountNumberTypeRefServiceClient().FetchByFinancialBankAccountNumberTypeRcd(financialBankAccountNumberTypeRcd);

            return View(
                "~/Views/Crude/Financial/CrudeFinancialBankAccountNumberTypeRef/CrudeFinancialBankAccountNumberTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialBankAccountNumberTypeRefEdit([Bind()] CrudeFinancialBankAccountNumberTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialBankAccountNumberTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialBankAccountNumberTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialBankAccountNumberTypeRef/CrudeFinancialBankAccountNumberTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialBankAccountNumberTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeFinancialBankAccountNumberTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialBankAccountNumberTypeRef/CrudeFinancialBankAccountNumberTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialBankAccountNumberTypeRefCreate([Bind()] CrudeFinancialBankAccountNumberTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialBankAccountNumberTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialBankAccountNumberTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialBankAccountNumberTypeRef/CrudeFinancialBankAccountNumberTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialBankAccountNumberTypeRefDelete(
            System.String financialBankAccountNumberTypeRcd
            ) {
            new CrudeFinancialBankAccountNumberTypeRefServiceClient().Delete(financialBankAccountNumberTypeRcd);

            return RedirectToAction("CrudeFinancialBankAccountNumberTypeRefIndex");
        }
    }
}
