/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/30/2020 6:41:12 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultIssueStatusRefController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultIssueStatusRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueStatusRef/CrudeDefaultIssueStatusRefIndex.cshtml",
                new CrudeDefaultIssueStatusRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultIssueStatusRefDetails(System.String defaultIssueStatusRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueStatusRef/CrudeDefaultIssueStatusRefDetails.cshtml",
                new CrudeDefaultIssueStatusRefServiceClient().FetchByDefaultIssueStatusRcd(defaultIssueStatusRcd)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeDefaultIssueStatusRefDelete(
            System.String defaultIssueStatusRcd
            ) {
            new CrudeDefaultIssueStatusRefServiceClient().Delete(defaultIssueStatusRcd);

            return RedirectToAction("CrudeDefaultIssueStatusRefIndex");
        }
    }
}
