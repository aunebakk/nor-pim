/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:36:26 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultIssueTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultIssueTypeRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueTypeRef/CrudeDefaultIssueTypeRefIndex.cshtml",
                new CrudeDefaultIssueTypeRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultIssueTypeRefDetails(System.String defaultIssueTypeRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultIssueTypeRef/CrudeDefaultIssueTypeRefDetails.cshtml",
                new CrudeDefaultIssueTypeRefServiceClient().FetchByDefaultIssueTypeRcd(defaultIssueTypeRcd)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeDefaultIssueTypeRefDelete(
            System.String defaultIssueTypeRcd
            ) {
            new CrudeDefaultIssueTypeRefServiceClient().Delete(defaultIssueTypeRcd);

            return RedirectToAction("CrudeDefaultIssueTypeRefIndex");
        }
    }
}
