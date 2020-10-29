/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 7:45:09 PM
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
    public class CrudeDefaultErrorTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultErrorTypeRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefIndex.cshtml",
                new CrudeDefaultErrorTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultErrorTypeRefDetails(System.String defaultErrorTypeRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefDetails.cshtml",
                new CrudeDefaultErrorTypeRefServiceClient().FetchByDefaultErrorTypeRcd(defaultErrorTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultErrorTypeRefEdit(
            System.String defaultErrorTypeRcd
            ) {

            CrudeDefaultErrorTypeRefContract contract = new CrudeDefaultErrorTypeRefServiceClient().FetchByDefaultErrorTypeRcd(defaultErrorTypeRcd);

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultErrorTypeRefEdit([Bind()] CrudeDefaultErrorTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeDefaultErrorTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultErrorTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultErrorTypeRefCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultErrorTypeRefContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultErrorTypeRefCreate([Bind()] CrudeDefaultErrorTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultErrorTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultErrorTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultErrorTypeRefDelete(
            System.String defaultErrorTypeRcd
            ) {
            new CrudeDefaultErrorTypeRefServiceClient().Delete(defaultErrorTypeRcd);

            return RedirectToAction("CrudeDefaultErrorTypeRefIndex");
        }
    }
}
