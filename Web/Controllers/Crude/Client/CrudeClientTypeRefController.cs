/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 4:13:06 AM
  From Machine: DESKTOP-742U247
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
    public class CrudeClientTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeClientTypeRefIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClientTypeRef/CrudeClientTypeRefIndex.cshtml",
                new CrudeClientTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeClientTypeRefDetails(System.String clientTypeRcd) {

            return View(
                "~/Views/Crude/Client/CrudeClientTypeRef/CrudeClientTypeRefDetails.cshtml",
                new CrudeClientTypeRefServiceClient().FetchByClientTypeRcd(clientTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeClientTypeRefEdit(
            System.String clientTypeRcd
            ) {

            CrudeClientTypeRefContract contract = new CrudeClientTypeRefServiceClient().FetchByClientTypeRcd(clientTypeRcd);

            return View(
                "~/Views/Crude/Client/CrudeClientTypeRef/CrudeClientTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientTypeRefEdit([Bind()] CrudeClientTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeClientTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeClientTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientTypeRef/CrudeClientTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeClientTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeClientTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClientTypeRef/CrudeClientTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientTypeRefCreate([Bind()] CrudeClientTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClientTypeRef/CrudeClientTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeClientTypeRefDelete(
            System.String clientTypeRcd
            ) {
            new CrudeClientTypeRefServiceClient().Delete(clientTypeRcd);

            return RedirectToAction("CrudeClientTypeRefIndex");
        }
    }
}
