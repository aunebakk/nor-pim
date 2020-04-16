/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:32:42 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientContactMethodController : Controller {

        [HttpGet]
        public ActionResult CrudeClientContactMethodIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodIndex.cshtml",
                new CrudeClientContactMethodServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientContactMethodByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodIndex.cshtml",
                new CrudeClientContactMethodServiceClient().FetchByClientId(clientId)
                );
        }

        [HttpGet]
        public ActionResult CrudeClientContactMethodDetails(System.Guid clientContactMethodId) {

            return View(
                "~/Views/Crude/Client/CrudeClientContactMethod/CrudeClientContactMethodDetails.cshtml",
                new CrudeClientContactMethodServiceClient().FetchByClientContactMethodId(clientContactMethodId)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeClientContactMethodDelete(
            System.Guid clientContactMethodId
            ) {
            new CrudeClientContactMethodServiceClient().Delete(clientContactMethodId);

            return RedirectToAction("CrudeClientContactMethodIndex");
        }
    }
}
