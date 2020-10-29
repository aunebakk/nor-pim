/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:45:23 PM
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
    public class CrudeClientAddressController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientAddressIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientAddress/CrudeClientAddressIndex.cshtml",
                new CrudeClientAddressServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientAddressDetails(System.Guid clientAddressId) {

            return View(
                "~/Views/Crude/Client/CrudeClientAddress/CrudeClientAddressDetails.cshtml",
                new CrudeClientAddressServiceClient().FetchByClientAddressId(clientAddressId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeClientAddressEdit(
            System.Guid clientAddressId
            ) {

            CrudeClientAddressContract contract = new CrudeClientAddressServiceClient().FetchByClientAddressId(clientAddressId);
            ViewBag.ClientAddressTypeRcd =
                new SelectList( new CrudeClientAddressTypeRefServiceClient().FetchAll(),
                                "ClientAddressTypeRcd",
                                "ClientAddressTypeName",
                                contract.ClientAddressTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Client/CrudeClientAddress/CrudeClientAddressEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientAddressEdit([Bind()] CrudeClientAddressContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeClientAddressServiceClient().Update(contract);

                return RedirectToAction("CrudeClientAddressIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientAddress/CrudeClientAddressEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeClientAddressCreate(System.Guid? clientId, System.Guid? userId) {
            var contract = new CrudeClientAddressContract();
            if (clientId != null) contract.ClientId = (System.Guid) clientId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ClientAddressTypeRcd =
                new SelectList( new CrudeClientAddressTypeRefServiceClient().FetchAll(),
                                "ClientAddressTypeRcd",
                                "ClientAddressTypeName",
                                contract.ClientAddressTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientAddress/CrudeClientAddressCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientAddressCreate([Bind()] CrudeClientAddressContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientAddressServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientAddressIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientAddress/CrudeClientAddressCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientAddressDelete(
            System.Guid clientAddressId
            ) {
            new CrudeClientAddressServiceClient().Delete(clientAddressId);

            return RedirectToAction("CrudeClientAddressIndex");
        }
    }
}
