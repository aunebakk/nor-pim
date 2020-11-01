/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 7:03:38 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.AspMvc.Controllers {

    // controller class for mvc
    public class CrudeClientEventController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientEventIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientEvent/CrudeClientEventIndex.cshtml",
                new CrudeClientEventServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeClientEventByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;

            return View(
                "~/Views/Crude/Client/CrudeClientEvent/CrudeClientEventIndex.cshtml",
                new CrudeClientEventServiceClient().FetchByClientId(clientId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientEventDetails(System.Guid clientEventId) {

            return View(
                "~/Views/Crude/Client/CrudeClientEvent/CrudeClientEventDetails.cshtml",
                new CrudeClientEventServiceClient().FetchByClientEventId(clientEventId)
                );
        }

        // edit details page
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

        // save detail page
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

        // add new entity page
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

        // add new detail page
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

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientEventDelete(
            System.Guid clientEventId
            ) {
            new CrudeClientEventServiceClient().Delete(clientEventId);

            return RedirectToAction("CrudeClientEventIndex");
        }
    }
}
