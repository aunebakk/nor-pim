/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:32:42 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialPaymentCardController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCardIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCard/CrudeFinancialPaymentCardIndex.cshtml",
                new CrudeFinancialPaymentCardServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCardByFinancialCurrencyIndex(System.Guid financialCurrencyId) {
            ViewBag.FinancialCurrencyId = financialCurrencyId;

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCard/CrudeFinancialPaymentCardIndex.cshtml",
                new CrudeFinancialPaymentCardServiceClient().FetchByFinancialCurrencyId(financialCurrencyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCardDetails(System.Guid financialPaymentCardId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCard/CrudeFinancialPaymentCardDetails.cshtml",
                new CrudeFinancialPaymentCardServiceClient().FetchByFinancialPaymentCardId(financialPaymentCardId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCardEdit(
            System.Guid financialPaymentCardId
            ) {

            CrudeFinancialPaymentCardContract contract = new CrudeFinancialPaymentCardServiceClient().FetchByFinancialPaymentCardId(financialPaymentCardId);
            ViewBag.FinancialCardTypeRcd =
                new SelectList( new CrudeFinancialCardTypeRefServiceClient().FetchAll(),
                                "FinancialCardTypeRcd",
                                "FinancialCardTypeName",
                                contract.FinancialCardTypeRcd
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
                "~/Views/Crude/Financial/CrudeFinancialPaymentCard/CrudeFinancialPaymentCardEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentCardEdit([Bind()] CrudeFinancialPaymentCardContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialPaymentCardServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialPaymentCardIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCard/CrudeFinancialPaymentCardEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCardCreate(System.Guid? userId, System.Guid? financialCurrencyId) {
            var contract = new CrudeFinancialPaymentCardContract();
            if (userId != null) contract.UserId = (System.Guid) userId;
            if (financialCurrencyId != null) contract.FinancialCurrencyId = (System.Guid) financialCurrencyId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            ViewBag.FinancialCardTypeRcd =
                new SelectList( new CrudeFinancialCardTypeRefServiceClient().FetchAll(),
                                "FinancialCardTypeRcd",
                                "FinancialCardTypeName",
                                contract.FinancialCardTypeRcd
                                );

            ViewBag.FinancialCurrencyId =
                new SelectList( new CrudeFinancialCurrencyServiceClient().FetchAll(),
                                "FinancialCurrencyId",
                                "FinancialCurrencyTypeName",
                                contract.FinancialCurrencyId
                                );


            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCard/CrudeFinancialPaymentCardCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialPaymentCardCreate([Bind()] CrudeFinancialPaymentCardContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialPaymentCardServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialPaymentCardIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialPaymentCard/CrudeFinancialPaymentCardCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialPaymentCardDelete(
            System.Guid financialPaymentCardId
            ) {
            new CrudeFinancialPaymentCardServiceClient().Delete(financialPaymentCardId);

            return RedirectToAction("CrudeFinancialPaymentCardIndex");
        }
    }
}
