/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:42:56 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialPaymentTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialPaymentTypeRefIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefIndex.cshtml",
                new CrudeFinancialPaymentTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentTypeRefDetails(System.String financialPaymentTypeRcd) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefDetails.cshtml",
                new CrudeFinancialPaymentTypeRefServiceClient().FetchByFinancialPaymentTypeRcd(financialPaymentTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentTypeRefEdit(
            System.String financialPaymentTypeRcd
            ) {

            CrudeFinancialPaymentTypeRefContract contract = new CrudeFinancialPaymentTypeRefServiceClient().FetchByFinancialPaymentTypeRcd(financialPaymentTypeRcd);

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentTypeRefEdit([Bind()] CrudeFinancialPaymentTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialPaymentTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialPaymentTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeFinancialPaymentTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentTypeRefCreate([Bind()] CrudeFinancialPaymentTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialPaymentTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialPaymentTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentTypeRefDelete(
            System.String financialPaymentTypeRcd
            ) {
            new CrudeFinancialPaymentTypeRefServiceClient().Delete(financialPaymentTypeRcd);

            return RedirectToAction("CrudeFinancialPaymentTypeRefIndex");
        }
    }
}
