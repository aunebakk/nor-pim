/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 5:49:26 PM
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
    public class CrudeDefaultChangeLogController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultChangeLogIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLog/CrudeDefaultChangeLogIndex.cshtml",
                new CrudeDefaultChangeLogServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeDefaultChangeLogByDefaultIssueIndex(System.Guid defaultIssueId) {
            ViewBag.DefaultIssueId = defaultIssueId;

            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLog/CrudeDefaultChangeLogIndex.cshtml",
                new CrudeDefaultChangeLogServiceClient().FetchByDefaultIssueId(defaultIssueId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultChangeLogDetails(System.Guid defaultChangeLogId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLog/CrudeDefaultChangeLogDetails.cshtml",
                new CrudeDefaultChangeLogServiceClient().FetchByDefaultChangeLogId(defaultChangeLogId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultChangeLogEdit(
            System.Guid defaultChangeLogId
            ) {

            CrudeDefaultChangeLogContract contract = new CrudeDefaultChangeLogServiceClient().FetchByDefaultChangeLogId(defaultChangeLogId);
            ViewBag.DefaultChangeLogTypeRcd =
                new SelectList( new CrudeDefaultChangeLogTypeRefServiceClient().FetchAll(),
                                "DefaultChangeLogTypeRcd",
                                "DefaultChangeLogTypeName",
                                contract.DefaultChangeLogTypeRcd
                                );

            ViewBag.DefaultIssueId =
                new SelectList( new CrudeDefaultIssueServiceClient().FetchAll(),
                                "DefaultIssueId",
                                "IssueName",
                                contract.DefaultIssueId
                                );


            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLog/CrudeDefaultChangeLogEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultChangeLogEdit([Bind()] CrudeDefaultChangeLogContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultChangeLogServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultChangeLogIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLog/CrudeDefaultChangeLogEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultChangeLogCreate(System.Guid? defaultUserId, System.Guid? defaultIssueId) {
            var contract = new CrudeDefaultChangeLogContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;
            if (defaultIssueId != null) contract.DefaultIssueId = (System.Guid) defaultIssueId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;

            ViewBag.DefaultChangeLogTypeRcd =
                new SelectList( new CrudeDefaultChangeLogTypeRefServiceClient().FetchAll(),
                                "DefaultChangeLogTypeRcd",
                                "DefaultChangeLogTypeName",
                                contract.DefaultChangeLogTypeRcd
                                );

            ViewBag.DefaultIssueId =
                new SelectList( new CrudeDefaultIssueServiceClient().FetchAll(),
                                "DefaultIssueId",
                                "IssueName",
                                contract.DefaultIssueId
                                );


            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLog/CrudeDefaultChangeLogCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultChangeLogCreate([Bind()] CrudeDefaultChangeLogContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultChangeLogServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultChangeLogIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLog/CrudeDefaultChangeLogCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultChangeLogDelete(
            System.Guid defaultChangeLogId
            ) {
            new CrudeDefaultChangeLogServiceClient().Delete(defaultChangeLogId);

            return RedirectToAction("CrudeDefaultChangeLogIndex");
        }
    }
}
