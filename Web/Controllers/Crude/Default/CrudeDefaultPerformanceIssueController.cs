/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 9:49:12 PM
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
    public class CrudeDefaultPerformanceIssueController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultPerformanceIssueIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceIssue/CrudeDefaultPerformanceIssueIndex.cshtml",
                new CrudeDefaultPerformanceIssueServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultPerformanceIssueDetails(System.Guid defaultPerformanceIssueId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceIssue/CrudeDefaultPerformanceIssueDetails.cshtml",
                new CrudeDefaultPerformanceIssueServiceClient().FetchByDefaultPerformanceIssueId(defaultPerformanceIssueId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultPerformanceIssueEdit(
            System.Guid defaultPerformanceIssueId
            ) {

            CrudeDefaultPerformanceIssueContract contract = new CrudeDefaultPerformanceIssueServiceClient().FetchByDefaultPerformanceIssueId(defaultPerformanceIssueId);

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceIssue/CrudeDefaultPerformanceIssueEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultPerformanceIssueEdit([Bind()] CrudeDefaultPerformanceIssueContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultPerformanceIssueServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultPerformanceIssueIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceIssue/CrudeDefaultPerformanceIssueEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultPerformanceIssueCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultPerformanceIssueContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceIssue/CrudeDefaultPerformanceIssueCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultPerformanceIssueCreate([Bind()] CrudeDefaultPerformanceIssueContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultPerformanceIssueServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultPerformanceIssueIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceIssue/CrudeDefaultPerformanceIssueCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultPerformanceIssueDelete(
            System.Guid defaultPerformanceIssueId
            ) {
            new CrudeDefaultPerformanceIssueServiceClient().Delete(defaultPerformanceIssueId);

            return RedirectToAction("CrudeDefaultPerformanceIssueIndex");
        }
    }
}
