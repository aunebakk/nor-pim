/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:32:42 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultChangeLogController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultChangeLogIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLog/CrudeDefaultChangeLogIndex.cshtml",
                new CrudeDefaultChangeLogServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultChangeLogByDefaultIssueIndex(System.Guid defaultIssueId) {
            ViewBag.DefaultIssueId = defaultIssueId;

            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLog/CrudeDefaultChangeLogIndex.cshtml",
                new CrudeDefaultChangeLogServiceClient().FetchByDefaultIssueId(defaultIssueId)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultChangeLogDetails(System.Guid defaultChangeLogId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLog/CrudeDefaultChangeLogDetails.cshtml",
                new CrudeDefaultChangeLogServiceClient().FetchByDefaultChangeLogId(defaultChangeLogId)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeDefaultChangeLogDelete(
            System.Guid defaultChangeLogId
            ) {
            new CrudeDefaultChangeLogServiceClient().Delete(defaultChangeLogId);

            return RedirectToAction("CrudeDefaultChangeLogIndex");
        }
    }
}
