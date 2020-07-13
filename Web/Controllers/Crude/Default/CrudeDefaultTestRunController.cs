/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:08:04 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultTestRunController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultTestRunIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRun/CrudeDefaultTestRunIndex.cshtml",
                new CrudeDefaultTestRunServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultTestRunByDefaultTestIndex(System.Guid defaultTestId) {
            ViewBag.DefaultTestId = defaultTestId;

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRun/CrudeDefaultTestRunIndex.cshtml",
                new CrudeDefaultTestRunServiceClient().FetchByDefaultTestId(defaultTestId)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultTestRunDetails(System.Guid defaultTestRunId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRun/CrudeDefaultTestRunDetails.cshtml",
                new CrudeDefaultTestRunServiceClient().FetchByDefaultTestRunId(defaultTestRunId)
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultTestRunEdit(
            System.Guid defaultTestRunId
            ) {

            CrudeDefaultTestRunContract contract = new CrudeDefaultTestRunServiceClient().FetchByDefaultTestRunId(defaultTestRunId);
            ViewBag.DefaultTestId =
                new SelectList( new CrudeDefaultTestServiceClient().FetchAll(),
                                "DefaultTestId",
                                "SystemName",
                                contract.DefaultTestId
                                );

            ViewBag.DefaultTestRunResultRcd =
                new SelectList( new CrudeDefaultTestRunResultRefServiceClient().FetchAll(),
                                "DefaultTestRunResultRcd",
                                "DefaultTestRunResultName",
                                contract.DefaultTestRunResultRcd
                                );


            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRun/CrudeDefaultTestRunEdit.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultTestRunEdit([Bind()] CrudeDefaultTestRunContract contract) {
            if (ModelState.IsValid) {
                new CrudeDefaultTestRunServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultTestRunIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRun/CrudeDefaultTestRunEdit.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultTestRunCreate(System.Guid? defaultTestId, System.Guid? userId) {
            var contract = new CrudeDefaultTestRunContract();
            if (defaultTestId != null) contract.DefaultTestId = (System.Guid) defaultTestId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.DefaultTestId =
                new SelectList( new CrudeDefaultTestServiceClient().FetchAll(),
                                "DefaultTestId",
                                "SystemName",
                                contract.DefaultTestId
                                );

            ViewBag.DefaultTestRunResultRcd =
                new SelectList( new CrudeDefaultTestRunResultRefServiceClient().FetchAll(),
                                "DefaultTestRunResultRcd",
                                "DefaultTestRunResultName",
                                contract.DefaultTestRunResultRcd
                                );

            contract.StartDateTime = DateTime.UtcNow;

            contract.EndDateTime = DateTime.UtcNow;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRun/CrudeDefaultTestRunCreate.cshtml",
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultTestRunCreate([Bind()] CrudeDefaultTestRunContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultTestRunServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultTestRunIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRun/CrudeDefaultTestRunCreate.cshtml",
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultTestRunDelete(
            System.Guid defaultTestRunId
            ) {
            new CrudeDefaultTestRunServiceClient().Delete(defaultTestRunId);

            return RedirectToAction("CrudeDefaultTestRunIndex");
        }
    }
}
