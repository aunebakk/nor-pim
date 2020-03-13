/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:43:57 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialUnitOfMeasurementRefController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialUnitOfMeasurementRefIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialUnitOfMeasurementRef/CrudeFinancialUnitOfMeasurementRefIndex.cshtml",
                new CrudeFinancialUnitOfMeasurementRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialUnitOfMeasurementRefDetails(System.String financialUnitOfMeasurementRcd) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialUnitOfMeasurementRef/CrudeFinancialUnitOfMeasurementRefDetails.cshtml",
                new CrudeFinancialUnitOfMeasurementRefServiceClient().FetchByFinancialUnitOfMeasurementRcd(financialUnitOfMeasurementRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialUnitOfMeasurementRefEdit(
            System.String financialUnitOfMeasurementRcd
            ) {

            CrudeFinancialUnitOfMeasurementRefContract contract = new CrudeFinancialUnitOfMeasurementRefServiceClient().FetchByFinancialUnitOfMeasurementRcd(financialUnitOfMeasurementRcd);

            return View(
                "~/Views/Crude/Financial/CrudeFinancialUnitOfMeasurementRef/CrudeFinancialUnitOfMeasurementRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialUnitOfMeasurementRefEdit([Bind()] CrudeFinancialUnitOfMeasurementRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialUnitOfMeasurementRefServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialUnitOfMeasurementRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialUnitOfMeasurementRef/CrudeFinancialUnitOfMeasurementRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialUnitOfMeasurementRefCreate(System.Guid? userId) {
            var contract = new CrudeFinancialUnitOfMeasurementRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialUnitOfMeasurementRef/CrudeFinancialUnitOfMeasurementRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialUnitOfMeasurementRefCreate([Bind()] CrudeFinancialUnitOfMeasurementRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialUnitOfMeasurementRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialUnitOfMeasurementRefIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialUnitOfMeasurementRef/CrudeFinancialUnitOfMeasurementRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialUnitOfMeasurementRefDelete(
            System.String financialUnitOfMeasurementRcd
            ) {
            new CrudeFinancialUnitOfMeasurementRefServiceClient().Delete(financialUnitOfMeasurementRcd);

            return RedirectToAction("CrudeFinancialUnitOfMeasurementRefIndex");
        }
    }
}
