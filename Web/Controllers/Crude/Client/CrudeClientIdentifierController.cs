/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:56:56 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientIdentifierController : Controller {

        [HttpGet]
        public ActionResult CrudeClientIdentifierIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifier/CrudeClientIdentifierIndex.cshtml",
                new CrudeClientIdentifierServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientIdentifierByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifier/CrudeClientIdentifierIndex.cshtml",
                new CrudeClientIdentifierServiceClient().FetchByClientId(clientId)
                );
        }

        [HttpGet]
        public ActionResult CrudeClientIdentifierDetails(System.Guid clientIdentifierId) {

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifier/CrudeClientIdentifierDetails.cshtml",
                new CrudeClientIdentifierServiceClient().FetchByClientIdentifierId(clientIdentifierId)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeClientIdentifierDelete(
            System.Guid clientIdentifierId
            ) {
            new CrudeClientIdentifierServiceClient().Delete(clientIdentifierId);

            return RedirectToAction("CrudeClientIdentifierIndex");
        }
    }
}
