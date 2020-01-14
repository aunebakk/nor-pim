/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:59:41 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeClientDocumentTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeClientDocumentTypeRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientDocumentTypeRef/CrudeClientDocumentTypeRefIndex.cshtml",
                new CrudeClientDocumentTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeClientDocumentTypeRefDetails(System.String clientDocumentTypeRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientDocumentTypeRef/CrudeClientDocumentTypeRefDetails.cshtml",
                new CrudeClientDocumentTypeRefServiceClient().FetchByClientDocumentTypeRcd(clientDocumentTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeClientDocumentTypeRefEdit(
            System.String clientDocumentTypeRcd
            ) {

            CrudeClientDocumentTypeRefContract contract = new CrudeClientDocumentTypeRefServiceClient().FetchByClientDocumentTypeRcd(clientDocumentTypeRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientDocumentTypeRef/CrudeClientDocumentTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientDocumentTypeRefEdit([Bind()] CrudeClientDocumentTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientDocumentTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientDocumentTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientDocumentTypeRef/CrudeClientDocumentTypeRefEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientDocumentTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeClientDocumentTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientDocumentTypeRef/CrudeClientDocumentTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientDocumentTypeRefCreate([Bind()] CrudeClientDocumentTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientDocumentTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientDocumentTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientDocumentTypeRef/CrudeClientDocumentTypeRefCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeClientDocumentTypeRefDelete(
            System.String clientDocumentTypeRcd
            ) {
            new CrudeClientDocumentTypeRefServiceClient().Delete(clientDocumentTypeRcd);

            return RedirectToAction("CrudeClientDocumentTypeRefIndex");
        }
    }
}
