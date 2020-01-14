/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:00:22 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeFinancialOrderEventController : Controller {

        [HttpGet]
        public ActionResult CrudeFinancialOrderEventIndex() {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderEvent/CrudeFinancialOrderEventIndex.cshtml",
                new CrudeFinancialOrderEventServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderEventDetails(System.Guid fiancialOrderEventId) {

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderEvent/CrudeFinancialOrderEventDetails.cshtml",
                new CrudeFinancialOrderEventServiceClient().FetchByFiancialOrderEventId(fiancialOrderEventId)
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderEventEdit(
            System.Guid fiancialOrderEventId
            ) {

            CrudeFinancialOrderEventContract contract = new CrudeFinancialOrderEventServiceClient().FetchByFiancialOrderEventId(fiancialOrderEventId);
            ViewBag.FinancialOrderEventTypeRcd =
                new SelectList( new CrudeFinancialOrderEventTypeRefServiceClient().FetchAll(),
                                "FinancialOrderEventTypeRcd",
                                "FinancialOrderEventTypeName",
                                contract.FinancialOrderEventTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderEvent/CrudeFinancialOrderEventEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderEventEdit([Bind()] CrudeFinancialOrderEventContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeFinancialOrderEventServiceClient().Update(contract);

                return RedirectToAction("CrudeFinancialOrderEventIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderEvent/CrudeFinancialOrderEventEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderEventCreate(System.Guid? financialOrderId, System.Guid? userId) {
            var contract = new CrudeFinancialOrderEventContract();
            if (financialOrderId != null) contract.FinancialOrderId = (System.Guid) financialOrderId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;

            ViewBag.FinancialOrderEventTypeRcd =
                new SelectList( new CrudeFinancialOrderEventTypeRefServiceClient().FetchAll(),
                                "FinancialOrderEventTypeRcd",
                                "FinancialOrderEventTypeName",
                                contract.FinancialOrderEventTypeRcd
                                );


            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderEvent/CrudeFinancialOrderEventCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeFinancialOrderEventCreate([Bind()] CrudeFinancialOrderEventContract contract) {
            if (ModelState.IsValid) {

                new CrudeFinancialOrderEventServiceClient().Insert(contract);

                return RedirectToAction("CrudeFinancialOrderEventIndex");
            }

            return View(
                "~/Views/Crude/Financial/CrudeFinancialOrderEvent/CrudeFinancialOrderEventCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeFinancialOrderEventDelete(
            System.Guid fiancialOrderEventId
            ) {
            new CrudeFinancialOrderEventServiceClient().Delete(fiancialOrderEventId);

            return RedirectToAction("CrudeFinancialOrderEventIndex");
        }
    }
}
