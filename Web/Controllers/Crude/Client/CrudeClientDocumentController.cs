/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:04:53 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  client winform layer: https://docs.microsoft.com/en-us/dotnet/framework/winforms/
//  docLink: http://sql2x.org/documentationLink/f4564569-78eb-4ce4-99f3-6ace286090c3
namespace SolutionNorSolutionPim.AspMvc.Controllers {

    // this class serves as Controller to the data access layer between c# and sql server
    //  primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with an to REST API Contract through the JSON string format
    //  this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  MVC ( Model View Controller): https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93controller
    //  REST ( REpresentational State Transfer ): https://en.wikipedia.org/wiki/REST
    //  JSON ( JavaScript Object Notation ): https://en.wikipedia.org/wiki/JSON
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeClientDocumentController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeClientDocumentIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientDocument/CrudeClientDocumentIndex.cshtml",
                new CrudeClientDocumentServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeClientDocumentByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;

            return View(
                "~/Views/Crude/Client/CrudeClientDocument/CrudeClientDocumentIndex.cshtml",
                new CrudeClientDocumentServiceClient().FetchByClientId(clientId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeClientDocumentDetails(System.Guid clientDocumentId) {

            return View(
                "~/Views/Crude/Client/CrudeClientDocument/CrudeClientDocumentDetails.cshtml",
                new CrudeClientDocumentServiceClient().FetchByClientDocumentId(clientDocumentId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeClientDocumentEdit(
            System.Guid clientDocumentId
            ) {

            CrudeClientDocumentContract contract = new CrudeClientDocumentServiceClient().FetchByClientDocumentId(clientDocumentId);
            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );

            ViewBag.ClientDocumentTypeRcd =
                new SelectList( new CrudeClientDocumentTypeRefServiceClient().FetchAll(),
                                "ClientDocumentTypeRcd",
                                "ClientDocumentTypeName",
                                contract.ClientDocumentTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Client/CrudeClientDocument/CrudeClientDocumentEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientDocumentEdit([Bind()] CrudeClientDocumentContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeClientDocumentServiceClient().Update(contract);

                return RedirectToAction("CrudeClientDocumentIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientDocument/CrudeClientDocumentEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeClientDocumentCreate(System.Guid? clientId, System.Guid? userId) {
            var contract = new CrudeClientDocumentContract();
            if (clientId != null) contract.ClientId = (System.Guid) clientId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );

            ViewBag.ClientDocumentTypeRcd =
                new SelectList( new CrudeClientDocumentTypeRefServiceClient().FetchAll(),
                                "ClientDocumentTypeRcd",
                                "ClientDocumentTypeName",
                                contract.ClientDocumentTypeRcd
                                );

            contract.DocumentDateTime = DateTime.UtcNow;

            contract.ExpiryDateTime = DateTime.UtcNow;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientDocument/CrudeClientDocumentCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientDocumentCreate([Bind()] CrudeClientDocumentContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientDocumentServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientDocumentIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientDocument/CrudeClientDocumentCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeClientDocumentDelete(
            System.Guid clientDocumentId
            ) {
            new CrudeClientDocumentServiceClient().Delete(clientDocumentId);

            return RedirectToAction("CrudeClientDocumentIndex");
        }
    }
}
