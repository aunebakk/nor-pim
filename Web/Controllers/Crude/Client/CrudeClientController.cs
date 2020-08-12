/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:46 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientController : Controller {

        [HttpGet]
        public ActionResult CrudeClientIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientIndex.cshtml",
                new CrudeClientServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientByClientAddressIndex(System.Guid clientAddressId) {
            ViewBag.ClientAddressId = clientAddressId;

            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientIndex.cshtml",
                new CrudeClientServiceClient().FetchByClientAddressId(clientAddressId)
                );
        }

        [HttpGet]
        public ActionResult CrudeClientDetails(System.Guid clientId) {

            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientDetails.cshtml",
                new CrudeClientServiceClient().FetchByClientId(clientId)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeClientDelete(
            System.Guid clientId
            ) {
            new CrudeClientServiceClient().Delete(clientId);

            return RedirectToAction("CrudeClientIndex");
        }
    }
}
