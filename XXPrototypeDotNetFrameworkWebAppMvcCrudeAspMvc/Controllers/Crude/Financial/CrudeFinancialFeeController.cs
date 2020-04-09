/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:36:51 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialFeeController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialFeeIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialFee/CrudeFinancialFeeIndex.cshtml",
                new CrudeFinancialFeeServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialFeeByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialFee/CrudeFinancialFeeIndex.cshtml",
                new CrudeFinancialFeeServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialFeeDetails(System.Guid financialFeeId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialFee/CrudeFinancialFeeDetails.cshtml",
                new CrudeFinancialFeeServiceClient().FetchByFinancialFeeId(financialFeeId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialFeeEdit(
            System.Guid financialFeeId
            ) {

            CrudeFinancialFeeContract contract = new CrudeFinancialFeeServiceClient().FetchByFinancialFeeId(financialFeeId);
            ViewBag.FinancialFeeTypeRcd =
                new SelectList( new CrudeFinancialFeeTypeRefServiceClient().FetchAll(),
                                "FinancialFeeTypeRcd",
                                "FinancialFeeTypeName",
                                contract.FinancialFeeTypeRcd
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
                "~/Views/Crude/Financial/CrudeFinancialFee/CrudeFinancialFeeEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialFeeEdit([Bind()] CrudeFinancialFeeContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialFeeServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialFeeIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialFee/CrudeFinancialFeeEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialFeeCreate(System.Guid? userId, System.Guid? financialCurrencyId) {
            var contract = new CrudeFinancialFeeContract();
            if (userId != null) contract.UserId = (System.Guid) userId;
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            ViewBag.FinancialFeeTypeRcd =
                new SelectList( new CrudeFinancialFeeTypeRefServiceClient().FetchAll(),
                                "FinancialFeeTypeRcd",
                                "FinancialFeeTypeName",
                                contract.FinancialFeeTypeRcd
                                );

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );


            return View(
                "~/Views/Crude/Financial/CrudeFinancialFee/CrudeFinancialFeeCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialFeeCreate([Bind()] CrudeFinancialFeeContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialFeeServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialFeeIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialFee/CrudeFinancialFeeCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialFeeDelete(
            System.Guid financialFeeId
            ) {
            new CrudeFinancialFeeServiceClient().Delete(financialFeeId);

            return RedirectToAction("CrudeFinancialFeeIndex");
        }
    }
}
