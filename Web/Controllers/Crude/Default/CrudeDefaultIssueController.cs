/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:26:39 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultIssueController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultIssueIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssue/CrudeDefaultIssueIndex.cshtml",
                new CrudeDefaultIssueServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultIssueByDefaultErrorIndex(System.Guid defaultErrorId) {
            ViewBag.DefaultErrorId = defaultErrorId;

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssue/CrudeDefaultIssueIndex.cshtml",
                new CrudeDefaultIssueServiceClient().FetchByDefaultErrorId(defaultErrorId)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultIssueDetails(System.Guid defaultIssueId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssue/CrudeDefaultIssueDetails.cshtml",
                new CrudeDefaultIssueServiceClient().FetchByDefaultIssueId(defaultIssueId)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeDefaultIssueDelete(
            System.Guid defaultIssueId
            ) {
            new CrudeDefaultIssueServiceClient().Delete(defaultIssueId);

            return RedirectToAction("CrudeDefaultIssueIndex");
        }
    }
}
