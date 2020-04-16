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
    public class CrudeFinancialOrderIdentifierController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialOrderIdentifierIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderIdentifier/CrudeFinancialOrderIdentifierIndex.cshtml",
                new CrudeFinancialOrderIdentifierServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderIdentifierDetails(System.Guid financialOrderIdentifierId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderIdentifier/CrudeFinancialOrderIdentifierDetails.cshtml",
                new CrudeFinancialOrderIdentifierServiceClient().FetchByFinancialOrderIdentifierId(financialOrderIdentifierId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderIdentifierEdit(
            System.Guid financialOrderIdentifierId
            ) {

            CrudeFinancialOrderIdentifierContract contract = new CrudeFinancialOrderIdentifierServiceClient().FetchByFinancialOrderIdentifierId(financialOrderIdentifierId);
            ViewBag.FinancialOrderIdentifierTypeRcd =
                new SelectList( new CrudeFinancialOrderIdentifierTypeRefServiceClient().FetchAll(),
                                "FinancialOrderIdentifierTypeRcd",
                                "FinancialOrderIdentifierTypeName",
                                contract.FinancialOrderIdentifierTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderIdentifier/CrudeFinancialOrderIdentifierEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderIdentifierEdit([Bind()] CrudeFinancialOrderIdentifierContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialOrderIdentifierServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialOrderIdentifierIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderIdentifier/CrudeFinancialOrderIdentifierEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderIdentifierCreate(System.Guid? financialOrderId, System.Guid? userId) {
            var contract = new CrudeFinancialOrderIdentifierContract();
            if (financialOrderId != null) contract.FinancialOrderId = (System.Guid) financialOrderId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.FinancialOrderIdentifierTypeRcd =
                new SelectList( new CrudeFinancialOrderIdentifierTypeRefServiceClient().FetchAll(),
                                "FinancialOrderIdentifierTypeRcd",
                                "FinancialOrderIdentifierTypeName",
                                contract.FinancialOrderIdentifierTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderIdentifier/CrudeFinancialOrderIdentifierCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderIdentifierCreate([Bind()] CrudeFinancialOrderIdentifierContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialOrderIdentifierServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialOrderIdentifierIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderIdentifier/CrudeFinancialOrderIdentifierCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderIdentifierDelete(
            System.Guid financialOrderIdentifierId
            ) {
            new CrudeFinancialOrderIdentifierServiceClient().Delete(financialOrderIdentifierId);

            return RedirectToAction("CrudeFinancialOrderIdentifierIndex");
        }
    }
}
