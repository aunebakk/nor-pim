/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 7:42:48 AM
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
    public class CrudeDefaultVersionController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultVersionIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultVersion/CrudeDefaultVersionIndex.cshtml",
                new CrudeDefaultVersionServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultVersionDetails(System.Guid defaultVersionId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultVersion/CrudeDefaultVersionDetails.cshtml",
                new CrudeDefaultVersionServiceClient().FetchByDefaultVersionId(defaultVersionId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultVersionEdit(
            System.Guid defaultVersionId
            ) {

            CrudeDefaultVersionContract contract = new CrudeDefaultVersionServiceClient().FetchByDefaultVersionId(defaultVersionId);

            return View(
                "~/Views/Crude/Default/CrudeDefaultVersion/CrudeDefaultVersionEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultVersionEdit([Bind()] CrudeDefaultVersionContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultVersionServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultVersionIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultVersion/CrudeDefaultVersionEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultVersionCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultVersionContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultVersion/CrudeDefaultVersionCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultVersionCreate([Bind()] CrudeDefaultVersionContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultVersionServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultVersionIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultVersion/CrudeDefaultVersionCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultVersionDelete(
            System.Guid defaultVersionId
            ) {
            new CrudeDefaultVersionServiceClient().Delete(defaultVersionId);

            return RedirectToAction("CrudeDefaultVersionIndex");
        }
    }
}
