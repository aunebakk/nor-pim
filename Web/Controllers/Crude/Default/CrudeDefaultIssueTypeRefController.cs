/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 4:12:38 PM
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
    public class CrudeDefaultIssueTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultIssueTypeRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueTypeRef/CrudeDefaultIssueTypeRefIndex.cshtml",
                new CrudeDefaultIssueTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultIssueTypeRefDetails(System.String defaultIssueTypeRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueTypeRef/CrudeDefaultIssueTypeRefDetails.cshtml",
                new CrudeDefaultIssueTypeRefServiceClient().FetchByDefaultIssueTypeRcd(defaultIssueTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultIssueTypeRefEdit(
            System.String defaultIssueTypeRcd
            ) {

            CrudeDefaultIssueTypeRefContract contract = new CrudeDefaultIssueTypeRefServiceClient().FetchByDefaultIssueTypeRcd(defaultIssueTypeRcd);

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueTypeRef/CrudeDefaultIssueTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultIssueTypeRefEdit([Bind()] CrudeDefaultIssueTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeDefaultIssueTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultIssueTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueTypeRef/CrudeDefaultIssueTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultIssueTypeRefCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultIssueTypeRefContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueTypeRef/CrudeDefaultIssueTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultIssueTypeRefCreate([Bind()] CrudeDefaultIssueTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultIssueTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultIssueTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueTypeRef/CrudeDefaultIssueTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultIssueTypeRefDelete(
            System.String defaultIssueTypeRcd
            ) {
            new CrudeDefaultIssueTypeRefServiceClient().Delete(defaultIssueTypeRcd);

            return RedirectToAction("CrudeDefaultIssueTypeRefIndex");
        }
    }
}
