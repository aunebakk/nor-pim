/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:45:38 PM
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
    public class CrudeDefaultIssueStatusRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultIssueStatusRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueStatusRef/CrudeDefaultIssueStatusRefIndex.cshtml",
                new CrudeDefaultIssueStatusRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultIssueStatusRefDetails(System.String defaultIssueStatusRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueStatusRef/CrudeDefaultIssueStatusRefDetails.cshtml",
                new CrudeDefaultIssueStatusRefServiceClient().FetchByDefaultIssueStatusRcd(defaultIssueStatusRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultIssueStatusRefEdit(
            System.String defaultIssueStatusRcd
            ) {

            CrudeDefaultIssueStatusRefContract contract = new CrudeDefaultIssueStatusRefServiceClient().FetchByDefaultIssueStatusRcd(defaultIssueStatusRcd);

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueStatusRef/CrudeDefaultIssueStatusRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultIssueStatusRefEdit([Bind()] CrudeDefaultIssueStatusRefContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeDefaultIssueStatusRefServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultIssueStatusRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueStatusRef/CrudeDefaultIssueStatusRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultIssueStatusRefCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultIssueStatusRefContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueStatusRef/CrudeDefaultIssueStatusRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultIssueStatusRefCreate([Bind()] CrudeDefaultIssueStatusRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultIssueStatusRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultIssueStatusRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueStatusRef/CrudeDefaultIssueStatusRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultIssueStatusRefDelete(
            System.String defaultIssueStatusRcd
            ) {
            new CrudeDefaultIssueStatusRefServiceClient().Delete(defaultIssueStatusRcd);

            return RedirectToAction("CrudeDefaultIssueStatusRefIndex");
        }
    }
}
