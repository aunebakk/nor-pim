/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:34:31 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialOrderTransactionController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialOrderTransactionIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderTransaction/CrudeFinancialOrderTransactionIndex.cshtml",
                new CrudeFinancialOrderTransactionServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderTransactionByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderTransaction/CrudeFinancialOrderTransactionIndex.cshtml",
                new CrudeFinancialOrderTransactionServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderTransactionByFinancialCostcentreIndex(System.Guid financialCostcentreId) {
            ViewBag.FinancialCostcentreId = financialCostcentreId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderTransaction/CrudeFinancialOrderTransactionIndex.cshtml",
                new CrudeFinancialOrderTransactionServiceClient().FetchByFinancialCostcentreId(financialCostcentreId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderTransactionDetails(System.Guid financialBookingTransactionId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderTransaction/CrudeFinancialOrderTransactionDetails.cshtml",
                new CrudeFinancialOrderTransactionServiceClient().FetchByFinancialBookingTransactionId(financialBookingTransactionId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderTransactionEdit(
            System.Guid financialBookingTransactionId
            ) {

            CrudeFinancialOrderTransactionContract contract = new CrudeFinancialOrderTransactionServiceClient().FetchByFinancialBookingTransactionId(financialBookingTransactionId);
            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );

            ViewBag.FinancialCostcentreId =
                new SelectList( new CrudeFinancialCostcentreServiceClient().FetchAll(),
                                "FinancialCostcentreId",
                                "FinancialCostcentreName",
                                contract.FinancialCostcentreId
                                );

            ViewBag.FinancialOrderTransactionTypeRcd =
                new SelectList( new CrudeFinancialOrderTransactionTypeRefServiceClient().FetchAll(),
                                "FinancialOrderTransactionTypeRcd",
                                "FinancialOrderTransactionTypeName",
                                contract.FinancialOrderTransactionTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderTransaction/CrudeFinancialOrderTransactionEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderTransactionEdit([Bind()] CrudeFinancialOrderTransactionContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialOrderTransactionServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialOrderTransactionIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderTransaction/CrudeFinancialOrderTransactionEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderTransactionCreate(System.Guid? userId, System.Guid? financialFeeId, System.Guid? financialTaxId, System.Guid? financialPaymentId, System.Guid? financialCurrencyId, System.Guid? financialCostcentreId, System.Guid? financialAdjustmentId, System.Guid? financialOrderId) {
            var contract = new CrudeFinancialOrderTransactionContract();
            if (userId != null) contract.UserId = (System.Guid) userId;
            if (financialFeeId != null) contract.FinancialFeeId = (System.Guid) financialFeeId;
            if (financialTaxId != null) contract.FinancialTaxId = (System.Guid) financialTaxId;
            if (financialPaymentId != null) contract.FinancialPaymentId = (System.Guid) financialPaymentId;
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;
            if (financialCostcentreId != null) contract.FinancialCostcentreId = (System.Guid) financialCostcentreId;
            if (financialAdjustmentId != null) contract.FinancialAdjustmentId = (System.Guid) financialAdjustmentId;
            if (financialOrderId != null) contract.FinancialOrderId = (System.Guid) financialOrderId;

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

            ViewBag.FinancialCostcentreId =
                new SelectList( new CrudeFinancialCostcentreServiceClient().FetchAll(),
                                "FinancialCostcentreId",
                                "FinancialCostcentreName",
                                contract.FinancialCostcentreId
                                );

            ViewBag.FinancialOrderTransactionTypeRcd =
                new SelectList( new CrudeFinancialOrderTransactionTypeRefServiceClient().FetchAll(),
                                "FinancialOrderTransactionTypeRcd",
                                "FinancialOrderTransactionTypeName",
                                contract.FinancialOrderTransactionTypeRcd
                                );


            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderTransaction/CrudeFinancialOrderTransactionCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderTransactionCreate([Bind()] CrudeFinancialOrderTransactionContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialOrderTransactionServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialOrderTransactionIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderTransaction/CrudeFinancialOrderTransactionCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderTransactionDelete(
            System.Guid financialBookingTransactionId
            ) {
            new CrudeFinancialOrderTransactionServiceClient().Delete(financialBookingTransactionId);

            return RedirectToAction("CrudeFinancialOrderTransactionIndex");
        }
    }
}
