/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:21:10 PM
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultPerformanceTimeController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeIndex.cshtml",
                new CrudeDefaultPerformanceTimeServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeDetails(System.Guid defaultPerformanceTimeId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeDetails.cshtml",
                new CrudeDefaultPerformanceTimeServiceClient().FetchByDefaultPerformanceTimeId(defaultPerformanceTimeId)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeEdit(
            System.Guid defaultPerformanceTimeId
            ) {

            CrudeDefaultPerformanceTimeContract contract = new CrudeDefaultPerformanceTimeServiceClient().FetchByDefaultPerformanceTimeId(defaultPerformanceTimeId);

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultPerformanceTimeEdit([Bind()] CrudeDefaultPerformanceTimeContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultPerformanceTimeServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultPerformanceTimeIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultPerformanceTimeContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultPerformanceTimeCreate([Bind()] CrudeDefaultPerformanceTimeContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultPerformanceTimeServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultPerformanceTimeIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultPerformanceTimeDelete(
            System.Guid defaultPerformanceTimeId
            ) {
            new CrudeDefaultPerformanceTimeServiceClient().Delete(defaultPerformanceTimeId);

            return RedirectToAction("CrudeDefaultPerformanceTimeIndex");
        }
    }
}
