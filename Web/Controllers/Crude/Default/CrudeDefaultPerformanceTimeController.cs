/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 2:56:25 PM
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
    public class CrudeDefaultPerformanceTimeController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeIndex.cshtml",
                new CrudeDefaultPerformanceTimeServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeDetails(System.Guid defaultPerformanceTimeId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeDetails.cshtml",
                new CrudeDefaultPerformanceTimeServiceClient().FetchByDefaultPerformanceTimeId(defaultPerformanceTimeId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeEdit(
            System.Guid defaultPerformanceTimeId
            ) {

            CrudeDefaultPerformanceTimeContract contract = new CrudeDefaultPerformanceTimeServiceClient().FetchByDefaultPerformanceTimeId(defaultPerformanceTimeId);

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultPerformanceTimeEdit([Bind()] CrudeDefaultPerformanceTimeContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultPerformanceTimeServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultPerformanceTimeIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultPerformanceTimeContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultPerformanceTimeCreate([Bind()] CrudeDefaultPerformanceTimeContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultPerformanceTimeServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultPerformanceTimeIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeDelete(
            System.Guid defaultPerformanceTimeId
            ) {
            new CrudeDefaultPerformanceTimeServiceClient().Delete(defaultPerformanceTimeId);

            return RedirectToAction("CrudeDefaultPerformanceTimeIndex");
        }
    }
}
