/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 3:40:56 PM
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
    public class CrudeDefaultPerformanceTimeRollupController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeRollupIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupIndex.cshtml",
                new CrudeDefaultPerformanceTimeRollupServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeRollupDetails(System.Guid defaultPerformanceTimeRollupId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupDetails.cshtml",
                new CrudeDefaultPerformanceTimeRollupServiceClient().FetchByDefaultPerformanceTimeRollupId(defaultPerformanceTimeRollupId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeRollupEdit(
            System.Guid defaultPerformanceTimeRollupId
            ) {

            CrudeDefaultPerformanceTimeRollupContract contract = new CrudeDefaultPerformanceTimeRollupServiceClient().FetchByDefaultPerformanceTimeRollupId(defaultPerformanceTimeRollupId);

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultPerformanceTimeRollupEdit([Bind()] CrudeDefaultPerformanceTimeRollupContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultPerformanceTimeRollupServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultPerformanceTimeRollupIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeRollupCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultPerformanceTimeRollupContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultPerformanceTimeRollupCreate([Bind()] CrudeDefaultPerformanceTimeRollupContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultPerformanceTimeRollupServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultPerformanceTimeRollupIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeRollupDelete(
            System.Guid defaultPerformanceTimeRollupId
            ) {
            new CrudeDefaultPerformanceTimeRollupServiceClient().Delete(defaultPerformanceTimeRollupId);

            return RedirectToAction("CrudeDefaultPerformanceTimeRollupIndex");
        }
    }
}
