/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 9:18:06 PM
  From Machine: DESKTOP-742U247
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
    public class CrudeDefaultTestRunController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultTestRunIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRun/CrudeDefaultTestRunIndex.cshtml",
                new CrudeDefaultTestRunServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeDefaultTestRunByDefaultTestIndex(System.Guid defaultTestId) {
            ViewBag.DefaultTestId = defaultTestId;

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRun/CrudeDefaultTestRunIndex.cshtml",
                new CrudeDefaultTestRunServiceClient().FetchByDefaultTestId(defaultTestId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultTestRunDetails(System.Guid defaultTestRunId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRun/CrudeDefaultTestRunDetails.cshtml",
                new CrudeDefaultTestRunServiceClient().FetchByDefaultTestRunId(defaultTestRunId)
                );
        }

        // edit details page
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

        // save detail page
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

        // add new entity page
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

        // add new detail page
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

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultTestRunDelete(
            System.Guid defaultTestRunId
            ) {
            new CrudeDefaultTestRunServiceClient().Delete(defaultTestRunId);

            return RedirectToAction("CrudeDefaultTestRunIndex");
        }
    }
}
