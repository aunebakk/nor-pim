/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:23:52 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialAdjustmentController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialAdjustmentIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialAdjustment/CrudeFinancialAdjustmentIndex.cshtml",
                new CrudeFinancialAdjustmentServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialAdjustmentByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialAdjustment/CrudeFinancialAdjustmentIndex.cshtml",
                new CrudeFinancialAdjustmentServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialAdjustmentDetails(System.Guid financialAdjustmentId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialAdjustment/CrudeFinancialAdjustmentDetails.cshtml",
                new CrudeFinancialAdjustmentServiceClient().FetchByFinancialAdjustmentId(financialAdjustmentId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialAdjustmentEdit(
            System.Guid financialAdjustmentId
            ) {

            CrudeFinancialAdjustmentContract contract = new CrudeFinancialAdjustmentServiceClient().FetchByFinancialAdjustmentId(financialAdjustmentId);
            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.FinancialAdjustmentTypeRcd =
                new SelectList( new CrudeFinancialAdjustmentTypeRefServiceClient().FetchAll(),
                                "FinancialAdjustmentTypeRcd",
                                "FinancialAdjustmentTypeName",
                                contract.FinancialAdjustmentTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialAdjustment/CrudeFinancialAdjustmentEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialAdjustmentEdit([Bind()] CrudeFinancialAdjustmentContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialAdjustmentServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialAdjustmentIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialAdjustment/CrudeFinancialAdjustmentEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialAdjustmentCreate(System.Guid? financialCurrencyId, System.Guid? userId) {
            var contract = new CrudeFinancialAdjustmentContract();
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            ViewBag.FinancialAdjustmentTypeRcd =
                new SelectList( new CrudeFinancialAdjustmentTypeRefServiceClient().FetchAll(),
                                "FinancialAdjustmentTypeRcd",
                                "FinancialAdjustmentTypeName",
                                contract.FinancialAdjustmentTypeRcd
                                );


            return View(
                "~/Views/Crude/Financial/CrudeFinancialAdjustment/CrudeFinancialAdjustmentCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialAdjustmentCreate([Bind()] CrudeFinancialAdjustmentContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialAdjustmentServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialAdjustmentIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialAdjustment/CrudeFinancialAdjustmentCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialAdjustmentDelete(
            System.Guid financialAdjustmentId
            ) {
            new CrudeFinancialAdjustmentServiceClient().Delete(financialAdjustmentId);

            return RedirectToAction("CrudeFinancialAdjustmentIndex");
        }
    }
}
