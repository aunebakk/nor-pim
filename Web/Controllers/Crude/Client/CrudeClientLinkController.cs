/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 8:05:39 PM
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
    public class CrudeClientLinkController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientLinkIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientLink/CrudeClientLinkIndex.cshtml",
                new CrudeClientLinkServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeClientLinkByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;

            return View(
                "~/Views/Crude/Client/CrudeClientLink/CrudeClientLinkIndex.cshtml",
                new CrudeClientLinkServiceClient().FetchByClientId(clientId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientLinkDetails(System.Guid clientLinkId) {

            return View(
                "~/Views/Crude/Client/CrudeClientLink/CrudeClientLinkDetails.cshtml",
                new CrudeClientLinkServiceClient().FetchByClientLinkId(clientLinkId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeClientLinkEdit(
            System.Guid clientLinkId
            ) {

            CrudeClientLinkContract contract = new CrudeClientLinkServiceClient().FetchByClientLinkId(clientLinkId);
            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );

            ViewBag.ClientLinkTypeRcd =
                new SelectList( new CrudeClientLinkTypeRefServiceClient().FetchAll(),
                                "ClientLinkTypeRcd",
                                "ClientLinkTypeName",
                                contract.ClientLinkTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Client/CrudeClientLink/CrudeClientLinkEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientLinkEdit([Bind()] CrudeClientLinkContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeClientLinkServiceClient().Update(contract);

                return RedirectToAction("CrudeClientLinkIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientLink/CrudeClientLinkEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeClientLinkCreate(System.Guid? clientId, System.Guid? userId) {
            var contract = new CrudeClientLinkContract();
            if (clientId != null) contract.ClientId = (System.Guid) clientId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );

            ViewBag.ClientLinkTypeRcd =
                new SelectList( new CrudeClientLinkTypeRefServiceClient().FetchAll(),
                                "ClientLinkTypeRcd",
                                "ClientLinkTypeName",
                                contract.ClientLinkTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientLink/CrudeClientLinkCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientLinkCreate([Bind()] CrudeClientLinkContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientLinkServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientLinkIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientLink/CrudeClientLinkCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientLinkDelete(
            System.Guid clientLinkId
            ) {
            new CrudeClientLinkServiceClient().Delete(clientLinkId);

            return RedirectToAction("CrudeClientLinkIndex");
        }
    }
}
