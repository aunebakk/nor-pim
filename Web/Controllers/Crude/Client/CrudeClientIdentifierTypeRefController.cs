/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 8:04:37 PM
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
    public class CrudeClientIdentifierTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientIdentifierTypeRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefIndex.cshtml",
                new CrudeClientIdentifierTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientIdentifierTypeRefDetails(System.String clientIdentifierTypeRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefDetails.cshtml",
                new CrudeClientIdentifierTypeRefServiceClient().FetchByClientIdentifierTypeRcd(clientIdentifierTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeClientIdentifierTypeRefEdit(
            System.String clientIdentifierTypeRcd
            ) {

            CrudeClientIdentifierTypeRefContract contract = new CrudeClientIdentifierTypeRefServiceClient().FetchByClientIdentifierTypeRcd(clientIdentifierTypeRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientIdentifierTypeRefEdit([Bind()] CrudeClientIdentifierTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientIdentifierTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientIdentifierTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeClientIdentifierTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeClientIdentifierTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientIdentifierTypeRefCreate([Bind()] CrudeClientIdentifierTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientIdentifierTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientIdentifierTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientIdentifierTypeRefDelete(
            System.String clientIdentifierTypeRcd
            ) {
            new CrudeClientIdentifierTypeRefServiceClient().Delete(clientIdentifierTypeRcd);

            return RedirectToAction("CrudeClientIdentifierTypeRefIndex");
        }
    }
}
