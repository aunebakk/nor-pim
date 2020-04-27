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
    public class CrudeFinancialCurrencyTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialCurrencyTypeRefIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrencyTypeRef/CrudeFinancialCurrencyTypeRefIndex.cshtml",
                new CrudeFinancialCurrencyTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCurrencyTypeRefDetails(System.String financialCurrencyTypeRcd) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrencyTypeRef/CrudeFinancialCurrencyTypeRefDetails.cshtml",
                new CrudeFinancialCurrencyTypeRefServiceClient().FetchByFinancialCurrencyTypeRcd(financialCurrencyTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCurrencyTypeRefEdit(
            System.String financialCurrencyTypeRcd
            ) {

            CrudeFinancialCurrencyTypeRefContract contract = new CrudeFinancialCurrencyTypeRefServiceClient().FetchByFinancialCurrencyTypeRcd(financialCurrencyTypeRcd);

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrencyTypeRef/CrudeFinancialCurrencyTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCurrencyTypeRefEdit([Bind()] CrudeFinancialCurrencyTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialCurrencyTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialCurrencyTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrencyTypeRef/CrudeFinancialCurrencyTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCurrencyTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeFinancialCurrencyTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrencyTypeRef/CrudeFinancialCurrencyTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCurrencyTypeRefCreate([Bind()] CrudeFinancialCurrencyTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialCurrencyTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialCurrencyTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrencyTypeRef/CrudeFinancialCurrencyTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCurrencyTypeRefDelete(
            System.String financialCurrencyTypeRcd
            ) {
            new CrudeFinancialCurrencyTypeRefServiceClient().Delete(financialCurrencyTypeRcd);

            return RedirectToAction("CrudeFinancialCurrencyTypeRefIndex");
        }
    }
}
