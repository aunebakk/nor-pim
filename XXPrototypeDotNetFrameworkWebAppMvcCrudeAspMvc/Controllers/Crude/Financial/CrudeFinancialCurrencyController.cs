/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:44:22 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialCurrencyController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialCurrencyIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrency/CrudeFinancialCurrencyIndex.cshtml",
                new CrudeFinancialCurrencyServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCurrencyDetails(System.Guid financialCurrencyId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrency/CrudeFinancialCurrencyDetails.cshtml",
                new CrudeFinancialCurrencyServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCurrencyEdit(
            System.Guid financialCurrencyId
            ) {

            CrudeFinancialCurrencyContract contract = new CrudeFinancialCurrencyServiceClient().FetchByFinancialCurrencyId(financialCurrencyId);
            ViewBag.FinancialCurrencyTypeRcd =
                new SelectList( new CrudeFinancialCurrencyTypeRefServiceClient().FetchAll(),
                                "FinancialCurrencyTypeRcd",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyTypeRcd
                                );

            ViewBag.FinancialCurrencyAgainstFinancialCurrencyTypeRcd =
                new SelectList( new CrudeFinancialCurrencyTypeRefServiceClient().FetchAll(),
                                "FinancialCurrencyTypeRcd",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrency/CrudeFinancialCurrencyEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCurrencyEdit([Bind()] CrudeFinancialCurrencyContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialCurrencyServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialCurrencyIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrency/CrudeFinancialCurrencyEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCurrencyCreate(System.Guid? userId) {
            var contract = new CrudeFinancialCurrencyContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.FinancialCurrencyTypeRcd =
                new SelectList( new CrudeFinancialCurrencyTypeRefServiceClient().FetchAll(),
                                "FinancialCurrencyTypeRcd",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyTypeRcd
                                );

            ViewBag.FinancialCurrencyAgainstFinancialCurrencyTypeRcd =
                new SelectList( new CrudeFinancialCurrencyTypeRefServiceClient().FetchAll(),
                                "FinancialCurrencyTypeRcd",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            contract.ValidFromDateTime = DateTime.UtcNow;

            contract.ValidUntilDateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrency/CrudeFinancialCurrencyCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialCurrencyCreate([Bind()] CrudeFinancialCurrencyContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialCurrencyServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialCurrencyIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialCurrency/CrudeFinancialCurrencyCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialCurrencyDelete(
            System.Guid financialCurrencyId
            ) {
            new CrudeFinancialCurrencyServiceClient().Delete(financialCurrencyId);

            return RedirectToAction("CrudeFinancialCurrencyIndex");
        }
    }
}
