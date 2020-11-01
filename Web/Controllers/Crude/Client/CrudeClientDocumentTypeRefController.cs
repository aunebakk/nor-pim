/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 4:12:25 PM
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
    public class CrudeClientDocumentTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientDocumentTypeRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientDocumentTypeRef/CrudeClientDocumentTypeRefIndex.cshtml",
                new CrudeClientDocumentTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientDocumentTypeRefDetails(System.String clientDocumentTypeRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientDocumentTypeRef/CrudeClientDocumentTypeRefDetails.cshtml",
                new CrudeClientDocumentTypeRefServiceClient().FetchByClientDocumentTypeRcd(clientDocumentTypeRcd)
                );
        }

        // edit details page
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

        // save detail page
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

        // add new entity page
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

        // add new detail page
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

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientDocumentTypeRefDelete(
            System.String clientDocumentTypeRcd
            ) {
            new CrudeClientDocumentTypeRefServiceClient().Delete(clientDocumentTypeRcd);

            return RedirectToAction("CrudeClientDocumentTypeRefIndex");
        }
    }
}
