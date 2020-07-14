/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 6:12:59 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultPerformanceTimeRollupController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeRollupIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupIndex.cshtml",
                new CrudeDefaultPerformanceTimeRollupServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeRollupDetails(System.Guid defaultPerformanceTimeRollupId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupDetails.cshtml",
                new CrudeDefaultPerformanceTimeRollupServiceClient().FetchByDefaultPerformanceTimeRollupId(defaultPerformanceTimeRollupId)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeRollupEdit(
            System.Guid defaultPerformanceTimeRollupId
            ) {

            CrudeDefaultPerformanceTimeRollupContract contract = new CrudeDefaultPerformanceTimeRollupServiceClient().FetchByDefaultPerformanceTimeRollupId(defaultPerformanceTimeRollupId);

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultPerformanceTimeRollupEdit([Bind()] CrudeDefaultPerformanceTimeRollupContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultPerformanceTimeRollupServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultPerformanceTimeRollupIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeRollupCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultPerformanceTimeRollupContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultPerformanceTimeRollupCreate([Bind()] CrudeDefaultPerformanceTimeRollupContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultPerformanceTimeRollupServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultPerformanceTimeRollupIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeRollupDelete(
            System.Guid defaultPerformanceTimeRollupId
            ) {
            new CrudeDefaultPerformanceTimeRollupServiceClient().Delete(defaultPerformanceTimeRollupId);

            return RedirectToAction("CrudeDefaultPerformanceTimeRollupIndex");
        }
    }
}
