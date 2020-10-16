/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 5:53:59 PM
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
    public class CrudeDefaultStateRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultStateRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultStateRef/CrudeDefaultStateRefIndex.cshtml",
                new CrudeDefaultStateRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultStateRefDetails(string defaultStateRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultStateRef/CrudeDefaultStateRefDetails.cshtml",
                new CrudeDefaultStateRefServiceClient().FetchByDefaultStateRcd(defaultStateRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultStateRefEdit(
            string defaultStateRcd
            ) {

            CrudeDefaultStateRefContract contract = new CrudeDefaultStateRefServiceClient().FetchByDefaultStateRcd(defaultStateRcd);

            return View(
                "~/Views/Crude/Default/CrudeDefaultStateRef/CrudeDefaultStateRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultStateRefEdit([Bind()] CrudeDefaultStateRefContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeDefaultStateRefServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultStateRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultStateRef/CrudeDefaultStateRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultStateRefCreate(System.Guid? defaultUserId) {
            CrudeDefaultStateRefContract contract = new CrudeDefaultStateRefContract();
            if (defaultUserId != null) {
                contract.DefaultUserId = (System.Guid)defaultUserId;
            }

            if (defaultUserId == null) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
            }

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultStateRef/CrudeDefaultStateRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultStateRefCreate([Bind()] CrudeDefaultStateRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultStateRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultStateRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultStateRef/CrudeDefaultStateRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultStateRefDelete(
            string defaultStateRcd
            ) {
            new CrudeDefaultStateRefServiceClient().Delete(defaultStateRcd);

            return RedirectToAction("CrudeDefaultStateRefIndex");
        }
    }
}
