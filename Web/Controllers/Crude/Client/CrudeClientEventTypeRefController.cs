/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 1:31:50 PM
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
    public class CrudeClientEventTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientEventTypeRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientEventTypeRef/CrudeClientEventTypeRefIndex.cshtml",
                new CrudeClientEventTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientEventTypeRefDetails(System.String clientEventTypeRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientEventTypeRef/CrudeClientEventTypeRefDetails.cshtml",
                new CrudeClientEventTypeRefServiceClient().FetchByClientEventTypeRcd(clientEventTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeClientEventTypeRefEdit(
            System.String clientEventTypeRcd
            ) {

            CrudeClientEventTypeRefContract contract = new CrudeClientEventTypeRefServiceClient().FetchByClientEventTypeRcd(clientEventTypeRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientEventTypeRef/CrudeClientEventTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientEventTypeRefEdit([Bind()] CrudeClientEventTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientEventTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientEventTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientEventTypeRef/CrudeClientEventTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeClientEventTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeClientEventTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientEventTypeRef/CrudeClientEventTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientEventTypeRefCreate([Bind()] CrudeClientEventTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientEventTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientEventTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientEventTypeRef/CrudeClientEventTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientEventTypeRefDelete(
            System.String clientEventTypeRcd
            ) {
            new CrudeClientEventTypeRefServiceClient().Delete(clientEventTypeRcd);

            return RedirectToAction("CrudeClientEventTypeRefIndex");
        }
    }
}
