/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:51:34 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultPerformanceIssueController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultPerformanceIssueIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceIssue/CrudeDefaultPerformanceIssueIndex.cshtml",
                new CrudeDefaultPerformanceIssueServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultPerformanceIssueDetails(System.Guid defaultPerformanceIssueId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceIssue/CrudeDefaultPerformanceIssueDetails.cshtml",
                new CrudeDefaultPerformanceIssueServiceClient().FetchByDefaultPerformanceIssueId(defaultPerformanceIssueId)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeDefaultPerformanceIssueDelete(
            System.Guid defaultPerformanceIssueId
            ) {
            new CrudeDefaultPerformanceIssueServiceClient().Delete(defaultPerformanceIssueId);

            return RedirectToAction("CrudeDefaultPerformanceIssueIndex");
        }
    }
}
