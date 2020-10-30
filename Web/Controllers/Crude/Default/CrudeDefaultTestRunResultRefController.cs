/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 9:52:11 PM
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
    public class CrudeDefaultTestRunResultRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultTestRunResultRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefIndex.cshtml",
                new CrudeDefaultTestRunResultRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultTestRunResultRefDetails(System.String defaultTestRunResultRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefDetails.cshtml",
                new CrudeDefaultTestRunResultRefServiceClient().FetchByDefaultTestRunResultRcd(defaultTestRunResultRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultTestRunResultRefEdit(
            System.String defaultTestRunResultRcd
            ) {

            CrudeDefaultTestRunResultRefContract contract = new CrudeDefaultTestRunResultRefServiceClient().FetchByDefaultTestRunResultRcd(defaultTestRunResultRcd);

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultTestRunResultRefEdit([Bind()] CrudeDefaultTestRunResultRefContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeDefaultTestRunResultRefServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultTestRunResultRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultTestRunResultRefCreate(System.Guid? userId) {
            var contract = new CrudeDefaultTestRunResultRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultTestRunResultRefCreate([Bind()] CrudeDefaultTestRunResultRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultTestRunResultRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultTestRunResultRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultTestRunResultRefDelete(
            System.String defaultTestRunResultRcd
            ) {
            new CrudeDefaultTestRunResultRefServiceClient().Delete(defaultTestRunResultRcd);

            return RedirectToAction("CrudeDefaultTestRunResultRefIndex");
        }
    }
}
