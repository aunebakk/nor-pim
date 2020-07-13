/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:56:50 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientAddressController : Controller {

        [HttpGet]
        public ActionResult CrudeClientAddressIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientAddress/CrudeClientAddressIndex.cshtml",
                new CrudeClientAddressServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientAddressDetails(System.Guid clientAddressId) {

            return View(
                "~/Views/Crude/Client/CrudeClientAddress/CrudeClientAddressDetails.cshtml",
                new CrudeClientAddressServiceClient().FetchByClientAddressId(clientAddressId)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeClientAddressDelete(
            System.Guid clientAddressId
            ) {
            new CrudeClientAddressServiceClient().Delete(clientAddressId);

            return RedirectToAction("CrudeClientAddressIndex");
        }
    }
}
