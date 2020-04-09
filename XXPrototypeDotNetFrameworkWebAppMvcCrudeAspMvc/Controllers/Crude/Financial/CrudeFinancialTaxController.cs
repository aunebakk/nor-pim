/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:37:09 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialTaxController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialTaxIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialTax/CrudeFinancialTaxIndex.cshtml",
                new CrudeFinancialTaxServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialTaxByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialTax/CrudeFinancialTaxIndex.cshtml",
                new CrudeFinancialTaxServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialTaxDetails(System.Guid financialTaxId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialTax/CrudeFinancialTaxDetails.cshtml",
                new CrudeFinancialTaxServiceClient().FetchByFinancialTaxId(financialTaxId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialTaxEdit(
            System.Guid financialTaxId
            ) {

            CrudeFinancialTaxContract contract = new CrudeFinancialTaxServiceClient().FetchByFinancialTaxId(financialTaxId);
            ViewBag.FinancialTaxTypeRcd =
                new SelectList( new CrudeFinancialTaxTypeRefServiceClient().FetchAll(),
                                "FinancialTaxTypeRcd",
                                "FinancialTaxTypeName",
                                contract.FinancialTaxTypeRcd
                                );

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialTax/CrudeFinancialTaxEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialTaxEdit([Bind()] CrudeFinancialTaxContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialTaxServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialTaxIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialTax/CrudeFinancialTaxEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialTaxCreate(System.Guid? userId, System.Guid? financialCurrencyId) {
            var contract = new CrudeFinancialTaxContract();
            if (userId != null) contract.UserId = (System.Guid) userId;
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;

            ViewBag.FinancialTaxTypeRcd =
                new SelectList( new CrudeFinancialTaxTypeRefServiceClient().FetchAll(),
                                "FinancialTaxTypeRcd",
                                "FinancialTaxTypeName",
                                contract.FinancialTaxTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );


            return View(
                "~/Views/Crude/Financial/CrudeFinancialTax/CrudeFinancialTaxCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialTaxCreate([Bind()] CrudeFinancialTaxContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialTaxServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialTaxIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialTax/CrudeFinancialTaxCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialTaxDelete(
            System.Guid financialTaxId
            ) {
            new CrudeFinancialTaxServiceClient().Delete(financialTaxId);

            return RedirectToAction("CrudeFinancialTaxIndex");
        }
    }
}
