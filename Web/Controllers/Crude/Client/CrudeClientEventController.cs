/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 10:53:53 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientEventController : Controller {

        [HttpGet]
        public ActionResult CrudeClientEventIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientEvent/CrudeClientEventIndex.cshtml",
                new CrudeClientEventServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientEventByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;

            return View(
                "~/Views/Crude/Client/CrudeClientEvent/CrudeClientEventIndex.cshtml",
                new CrudeClientEventServiceClient().FetchByClientId(clientId)
                );
        }

        [HttpGet]
        public ActionResult CrudeClientEventDetails(System.Guid clientEventId) {

            return View(
                "~/Views/Crude/Client/CrudeClientEvent/CrudeClientEventDetails.cshtml",
                new CrudeClientEventServiceClient().FetchByClientEventId(clientEventId)
                );
        }

        [HttpGet]
        public ActionResult CrudeClientEventEdit(
            System.Guid clientEventId
            ) {

            CrudeClientEventContract contract = new CrudeClientEventServiceClient().FetchByClientEventId(clientEventId);
            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );

            ViewBag.ClientEventTypeRcd =
                new SelectList( new CrudeClientEventTypeRefServiceClient().FetchAll(),
                                "ClientEventTypeRcd",
                                "ClientEventTypeName",
                                contract.ClientEventTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Client/CrudeClientEvent/CrudeClientEventEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientEventEdit([Bind()] CrudeClientEventContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeClientEventServiceClient().Update(contract);

                return RedirectToAction("CrudeClientEventIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientEvent/CrudeClientEventEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientEventCreate(System.Guid? clientId, System.Guid? userId) {
            var contract = new CrudeClientEventContract();
            if (clientId != null) contract.ClientId = (System.Guid) clientId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );

            ViewBag.ClientEventTypeRcd =
                new SelectList( new CrudeClientEventTypeRefServiceClient().FetchAll(),
                                "ClientEventTypeRcd",
                                "ClientEventTypeName",
                                contract.ClientEventTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientEvent/CrudeClientEventCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientEventCreate([Bind()] CrudeClientEventContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientEventServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientEventIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientEvent/CrudeClientEventCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientEventDelete(
            System.Guid clientEventId
            ) {
            new CrudeClientEventServiceClient().Delete(clientEventId);

            return RedirectToAction("CrudeClientEventIndex");
        }
    }
}
