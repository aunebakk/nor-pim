/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 8:04:22 PM
  From Machine: DESKTOP-517I8BU
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
    public class CrudeClientContactMethodController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientContactMethodIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodIndex.cshtml",
                new CrudeClientContactMethodServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeClientContactMethodByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodIndex.cshtml",
                new CrudeClientContactMethodServiceClient().FetchByClientId(clientId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientContactMethodDetails(System.Guid clientContactMethodId) {

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodDetails.cshtml",
                new CrudeClientContactMethodServiceClient().FetchByClientContactMethodId(clientContactMethodId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeClientContactMethodEdit(
            System.Guid clientContactMethodId
            ) {

            CrudeClientContactMethodContract contract = new CrudeClientContactMethodServiceClient().FetchByClientContactMethodId(clientContactMethodId);
            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );

            ViewBag.ClientContactMethodRcd =
                new SelectList( new CrudeClientContactMethodRefServiceClient().FetchAll(),
                                "ClientContactMethodRcd",
                                "ClientContactMethodName",
                                contract.ClientContactMethodRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientContactMethodEdit([Bind()] CrudeClientContactMethodContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeClientContactMethodServiceClient().Update(contract);

                return RedirectToAction("CrudeClientContactMethodIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeClientContactMethodCreate(System.Guid? clientId, System.Guid? userId) {
            var contract = new CrudeClientContactMethodContract();
            if (clientId != null) contract.ClientId = (System.Guid) clientId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ClientId =
                new SelectList( new CrudeClientServiceClient().FetchAll(),
                                "ClientId",
                                "FirstName",
                                contract.ClientId
                                );

            ViewBag.ClientContactMethodRcd =
                new SelectList( new CrudeClientContactMethodRefServiceClient().FetchAll(),
                                "ClientContactMethodRcd",
                                "ClientContactMethodName",
                                contract.ClientContactMethodRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientContactMethodCreate([Bind()] CrudeClientContactMethodContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientContactMethodServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientContactMethodIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientContactMethodDelete(
            System.Guid clientContactMethodId
            ) {
            new CrudeClientContactMethodServiceClient().Delete(clientContactMethodId);

            return RedirectToAction("CrudeClientContactMethodIndex");
        }
    }
}
