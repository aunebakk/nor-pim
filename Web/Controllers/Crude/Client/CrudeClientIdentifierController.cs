/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:02:43 AM
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
    public class CrudeClientIdentifierController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientIdentifierIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifier/CrudeClientIdentifierIndex.cshtml",
                new CrudeClientIdentifierServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeClientIdentifierByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifier/CrudeClientIdentifierIndex.cshtml",
                new CrudeClientIdentifierServiceClient().FetchByClientId(clientId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientIdentifierDetails(System.Guid clientIdentifierId) {

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifier/CrudeClientIdentifierDetails.cshtml",
                new CrudeClientIdentifierServiceClient().FetchByClientIdentifierId(clientIdentifierId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeClientIdentifierEdit(
            System.Guid clientIdentifierId
            ) {

            CrudeClientIdentifierContract contract = new CrudeClientIdentifierServiceClient().FetchByClientIdentifierId(clientIdentifierId);
            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );

            ViewBag.ClientIdentifierTypeRcd =
                new SelectList( new CrudeClientIdentifierTypeRefServiceClient().FetchAll(),
                                "ClientIdentifierTypeRcd",
                                "ClientIdentifierTypeName",
                                contract.ClientIdentifierTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Client/CrudeClientIdentifier/CrudeClientIdentifierEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientIdentifierEdit([Bind()] CrudeClientIdentifierContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeClientIdentifierServiceClient().Update(contract);

                return RedirectToAction("CrudeClientIdentifierIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifier/CrudeClientIdentifierEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeClientIdentifierCreate(System.Guid? clientId, System.Guid? userId) {
            var contract = new CrudeClientIdentifierContract();
            if (clientId != null) contract.ClientId = (System.Guid) clientId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );

            ViewBag.ClientIdentifierTypeRcd =
                new SelectList( new CrudeClientIdentifierTypeRefServiceClient().FetchAll(),
                                "ClientIdentifierTypeRcd",
                                "ClientIdentifierTypeName",
                                contract.ClientIdentifierTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientIdentifier/CrudeClientIdentifierCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientIdentifierCreate([Bind()] CrudeClientIdentifierContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientIdentifierServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientIdentifierIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifier/CrudeClientIdentifierCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientIdentifierDelete(
            System.Guid clientIdentifierId
            ) {
            new CrudeClientIdentifierServiceClient().Delete(clientIdentifierId);

            return RedirectToAction("CrudeClientIdentifierIndex");
        }
    }
}
