/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:43:46 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialOrderLineController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialOrderLineIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderLine/CrudeFinancialOrderLineIndex.cshtml",
                new CrudeFinancialOrderLineServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderLineByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderLine/CrudeFinancialOrderLineIndex.cshtml",
                new CrudeFinancialOrderLineServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderLineDetails(System.Guid financialOrderLineId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderLine/CrudeFinancialOrderLineDetails.cshtml",
                new CrudeFinancialOrderLineServiceClient().FetchByFinancialOrderLineId(financialOrderLineId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderLineEdit(
            System.Guid financialOrderLineId
            ) {

            CrudeFinancialOrderLineContract contract = new CrudeFinancialOrderLineServiceClient().FetchByFinancialOrderLineId(financialOrderLineId);
            ViewBag.FinancialUnitOfMeasurementRcd =
                new SelectList( new CrudeFinancialUnitOfMeasurementRefServiceClient().FetchAll(),
                                "FinancialUnitOfMeasurementRcd",
                                "FinancialUnitOfMeasurementName",
                                contract.FinancialUnitOfMeasurementRcd
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
                "~/Views/Crude/Financial/CrudeFinancialOrderLine/CrudeFinancialOrderLineEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderLineEdit([Bind()] CrudeFinancialOrderLineContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialOrderLineServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialOrderLineIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderLine/CrudeFinancialOrderLineEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderLineCreate(System.Guid? financialOrderId, System.Guid? productId, System.Guid? userId, System.Guid? financialCurrencyId) {
            var contract = new CrudeFinancialOrderLineContract();
            if (financialOrderId != null) contract.FinancialOrderId = (System.Guid) financialOrderId;
            if (productId != null) contract.ProductId = (System.Guid) productId;
            if (userId != null) contract.UserId = (System.Guid) userId;
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            ViewBag.FinancialUnitOfMeasurementRcd =
                new SelectList( new CrudeFinancialUnitOfMeasurementRefServiceClient().FetchAll(),
                                "FinancialUnitOfMeasurementRcd",
                                "FinancialUnitOfMeasurementName",
                                contract.FinancialUnitOfMeasurementRcd
                                );

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );


            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderLine/CrudeFinancialOrderLineCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderLineCreate([Bind()] CrudeFinancialOrderLineContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialOrderLineServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialOrderLineIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderLine/CrudeFinancialOrderLineCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderLineDelete(
            System.Guid financialOrderLineId
            ) {
            new CrudeFinancialOrderLineServiceClient().Delete(financialOrderLineId);

            return RedirectToAction("CrudeFinancialOrderLineIndex");
        }
    }
}
