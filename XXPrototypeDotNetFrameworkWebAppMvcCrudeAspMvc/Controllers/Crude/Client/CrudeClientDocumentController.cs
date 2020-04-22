/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 6:56:00 AM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientDocumentController : Controller {

        [HttpGet]
        public ActionResult CrudeClientDocumentIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientDocument/CrudeClientDocumentIndex.cshtml",
                new CrudeClientDocumentServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientDocumentByClientIndex(System.Guid clientId) {
            ViewBag.ClientId = clientId;

            return View(
                "~/Views/Crude/Client/CrudeClientDocument/CrudeClientDocumentIndex.cshtml",
                new CrudeClientDocumentServiceClient().FetchByClientId(clientId)
                );
        }

        [HttpGet]
        public ActionResult CrudeClientDocumentDetails(System.Guid clientDocumentId) {

            return View(
                "~/Views/Crude/Client/CrudeClientDocument/CrudeClientDocumentDetails.cshtml",
                new CrudeClientDocumentServiceClient().FetchByClientDocumentId(clientDocumentId)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeClientDocumentDelete(
            System.Guid clientDocumentId
            ) {
            new CrudeClientDocumentServiceClient().Delete(clientDocumentId);

            return RedirectToAction("CrudeClientDocumentIndex");
        }
    }
}
