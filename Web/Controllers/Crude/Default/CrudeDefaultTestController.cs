/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 7:45:20 PM
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
    public class CrudeDefaultTestController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultTestIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestIndex.cshtml",
                new CrudeDefaultTestServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultTestDetails(System.Guid defaultTestId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestDetails.cshtml",
                new CrudeDefaultTestServiceClient().FetchByDefaultTestId(defaultTestId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultTestEdit(
            System.Guid defaultTestId
            ) {

            CrudeDefaultTestContract contract = new CrudeDefaultTestServiceClient().FetchByDefaultTestId(defaultTestId);

            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultTestEdit([Bind()] CrudeDefaultTestContract contract) {
            if (ModelState.IsValid) {
                new CrudeDefaultTestServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultTestIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultTestCreate(System.Guid? userId) {
            var contract = new CrudeDefaultTestContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultTestCreate([Bind()] CrudeDefaultTestContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultTestServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultTestIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultTest/CrudeDefaultTestCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultTestDelete(
            System.Guid defaultTestId
            ) {
            new CrudeDefaultTestServiceClient().Delete(defaultTestId);

            return RedirectToAction("CrudeDefaultTestIndex");
        }
    }
}
