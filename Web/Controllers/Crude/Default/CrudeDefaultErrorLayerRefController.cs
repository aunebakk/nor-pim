/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/25/2020 9:15:34 AM
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
    public class CrudeDefaultErrorLayerRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultErrorLayerRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefIndex.cshtml",
                new CrudeDefaultErrorLayerRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultErrorLayerRefDetails(System.String defaultErrorLayerRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefDetails.cshtml",
                new CrudeDefaultErrorLayerRefServiceClient().FetchByDefaultErrorLayerRcd(defaultErrorLayerRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultErrorLayerRefEdit(
            System.String defaultErrorLayerRcd
            ) {

            CrudeDefaultErrorLayerRefContract contract = new CrudeDefaultErrorLayerRefServiceClient().FetchByDefaultErrorLayerRcd(defaultErrorLayerRcd);

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultErrorLayerRefEdit([Bind()] CrudeDefaultErrorLayerRefContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeDefaultErrorLayerRefServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultErrorLayerRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultErrorLayerRefCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultErrorLayerRefContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultErrorLayerRefCreate([Bind()] CrudeDefaultErrorLayerRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultErrorLayerRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultErrorLayerRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultErrorLayerRefDelete(
            System.String defaultErrorLayerRcd
            ) {
            new CrudeDefaultErrorLayerRefServiceClient().Delete(defaultErrorLayerRcd);

            return RedirectToAction("CrudeDefaultErrorLayerRefIndex");
        }
    }
}
