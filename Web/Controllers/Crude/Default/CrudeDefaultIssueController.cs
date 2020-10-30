/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 4:38:31 AM
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
    public class CrudeDefaultIssueController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultIssueIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssue/CrudeDefaultIssueIndex.cshtml",
                new CrudeDefaultIssueServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeDefaultIssueByDefaultErrorIndex(System.Guid defaultErrorId) {
            ViewBag.DefaultErrorId = defaultErrorId;

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssue/CrudeDefaultIssueIndex.cshtml",
                new CrudeDefaultIssueServiceClient().FetchByDefaultErrorId(defaultErrorId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultIssueDetails(System.Guid defaultIssueId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssue/CrudeDefaultIssueDetails.cshtml",
                new CrudeDefaultIssueServiceClient().FetchByDefaultIssueId(defaultIssueId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultIssueEdit(
            System.Guid defaultIssueId
            ) {

            CrudeDefaultIssueContract contract = new CrudeDefaultIssueServiceClient().FetchByDefaultIssueId(defaultIssueId);
            ViewBag.DefaultIssueTypeRcd =
                new SelectList( new CrudeDefaultIssueTypeRefServiceClient().FetchAll(),
                                "DefaultIssueTypeRcd",
                                "DefaultIssueTypeName",
                                contract.DefaultIssueTypeRcd
                                );

            ViewBag.DefaultIssueStatusRcd =
                new SelectList( new CrudeDefaultIssueStatusRefServiceClient().FetchAll(),
                                "DefaultIssueStatusRcd",
                                "DefaultIssueStatusName",
                                contract.DefaultIssueStatusRcd
                                );

            ViewBag.DefaultErrorId =
                new SelectList( new CrudeDefaultErrorServiceClient().FetchAll(),
                                "DefaultErrorId",
                                "MethodName",
                                contract.DefaultErrorId
                                );


            return View(
                "~/Views/Crude/Default/CrudeDefaultIssue/CrudeDefaultIssueEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultIssueEdit([Bind()] CrudeDefaultIssueContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultIssueServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultIssueIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssue/CrudeDefaultIssueEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultIssueCreate(System.Guid? defaultErrorId, System.Guid? defaultUserId) {
            var contract = new CrudeDefaultIssueContract();
            if (defaultErrorId != null) contract.DefaultErrorId = (System.Guid) defaultErrorId;
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            ViewBag.DefaultIssueTypeRcd =
                new SelectList( new CrudeDefaultIssueTypeRefServiceClient().FetchAll(),
                                "DefaultIssueTypeRcd",
                                "DefaultIssueTypeName",
                                contract.DefaultIssueTypeRcd
                                );

            ViewBag.DefaultIssueStatusRcd =
                new SelectList( new CrudeDefaultIssueStatusRefServiceClient().FetchAll(),
                                "DefaultIssueStatusRcd",
                                "DefaultIssueStatusName",
                                contract.DefaultIssueStatusRcd
                                );

            ViewBag.DefaultErrorId =
                new SelectList( new CrudeDefaultErrorServiceClient().FetchAll(),
                                "DefaultErrorId",
                                "MethodName",
                                contract.DefaultErrorId
                                );

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultIssue/CrudeDefaultIssueCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultIssueCreate([Bind()] CrudeDefaultIssueContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultIssueServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultIssueIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssue/CrudeDefaultIssueCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultIssueDelete(
            System.Guid defaultIssueId
            ) {
            new CrudeDefaultIssueServiceClient().Delete(defaultIssueId);

            return RedirectToAction("CrudeDefaultIssueIndex");
        }
    }
}
