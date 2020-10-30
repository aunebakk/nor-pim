/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 11:00:50 AM
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
    public class CrudeClientController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientIndex.cshtml",
                new CrudeClientServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeClientByClientAddressIndex(System.Guid clientAddressId) {
            ViewBag.ClientAddressId = clientAddressId;

            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientIndex.cshtml",
                new CrudeClientServiceClient().FetchByClientAddressId(clientAddressId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientDetails(System.Guid clientId) {

            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientDetails.cshtml",
                new CrudeClientServiceClient().FetchByClientId(clientId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeClientEdit(
            System.Guid clientId
            ) {

            CrudeClientContract contract = new CrudeClientServiceClient().FetchByClientId(clientId);
            ViewBag.ClientTypeRcd =
                new SelectList( new CrudeClientTypeRefServiceClient().FetchAll(),
                                "ClientTypeRcd",
                                "ClientTypeName",
                                contract.ClientTypeRcd
                                );

            ViewBag.ClientNationalityRcd =
                new SelectList( new CrudeClientNationalityRefServiceClient().FetchAll(),
                                "ClientNationalityRcd",
                                "ClientNationalityName",
                                contract.ClientNationalityRcd
                                );

            ViewBag.ClientGenderRcd =
                new SelectList( new CrudeClientGenderRefServiceClient().FetchAll(),
                                "ClientGenderRcd",
                                "ClientGenderName",
                                contract.ClientGenderRcd
                                );

            ViewBag.ClientTitleRcd =
                new SelectList( new CrudeClientTitleRefServiceClient().FetchAll(),
                                "ClientTitleRcd",
                                "ClientTitleName",
                                contract.ClientTitleRcd
                                );

            ViewBag.ClientAddressId =
                new SelectList( new CrudeClientAddressServiceClient().FetchAll(),
                                "ClientAddressId",
                                "AddressLineOneName",
                                contract.ClientAddressId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientEdit([Bind()] CrudeClientContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeClientServiceClient().Update(contract);

                return RedirectToAction("CrudeClientIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeClientCreate(System.Guid? clientAddressId, System.Guid? userId) {
            var contract = new CrudeClientContract();
            if (clientAddressId != null) contract.ClientAddressId = (System.Guid) clientAddressId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ClientTypeRcd =
                new SelectList( new CrudeClientTypeRefServiceClient().FetchAll(),
                                "ClientTypeRcd",
                                "ClientTypeName",
                                contract.ClientTypeRcd
                                );

            ViewBag.ClientNationalityRcd =
                new SelectList( new CrudeClientNationalityRefServiceClient().FetchAll(),
                                "ClientNationalityRcd",
                                "ClientNationalityName",
                                contract.ClientNationalityRcd
                                );

            ViewBag.ClientGenderRcd =
                new SelectList( new CrudeClientGenderRefServiceClient().FetchAll(),
                                "ClientGenderRcd",
                                "ClientGenderName",
                                contract.ClientGenderRcd
                                );

            ViewBag.ClientTitleRcd =
                new SelectList( new CrudeClientTitleRefServiceClient().FetchAll(),
                                "ClientTitleRcd",
                                "ClientTitleName",
                                contract.ClientTitleRcd
                                );

            ViewBag.ClientAddressId =
                new SelectList( new CrudeClientAddressServiceClient().FetchAll(),
                                "ClientAddressId",
                                "AddressLineOneName",
                                contract.ClientAddressId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientCreate([Bind()] CrudeClientContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientDelete(
            System.Guid clientId
            ) {
            new CrudeClientServiceClient().Delete(clientId);

            return RedirectToAction("CrudeClientIndex");
        }
    }
}
