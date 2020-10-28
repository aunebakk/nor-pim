/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 6:12:44 AM
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
    public class CrudeDefaultSystemReferenceTableController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultSystemReferenceTableIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableIndex.cshtml",
                new CrudeDefaultSystemReferenceTableServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultSystemReferenceTableDetails(System.Guid defaultSystemReferenceTableId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableDetails.cshtml",
                new CrudeDefaultSystemReferenceTableServiceClient().FetchByDefaultSystemReferenceTableId(defaultSystemReferenceTableId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultSystemReferenceTableEdit(
            System.Guid defaultSystemReferenceTableId
            ) {

            CrudeDefaultSystemReferenceTableContract contract = new CrudeDefaultSystemReferenceTableServiceClient().FetchByDefaultSystemReferenceTableId(defaultSystemReferenceTableId);

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultSystemReferenceTableEdit([Bind()] CrudeDefaultSystemReferenceTableContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultSystemReferenceTableServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultSystemReferenceTableIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultSystemReferenceTableCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultSystemReferenceTableContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultSystemReferenceTableCreate([Bind()] CrudeDefaultSystemReferenceTableContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultSystemReferenceTableServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultSystemReferenceTableIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultSystemReferenceTableDelete(
            System.Guid defaultSystemReferenceTableId
            ) {
            new CrudeDefaultSystemReferenceTableServiceClient().Delete(defaultSystemReferenceTableId);

            return RedirectToAction("CrudeDefaultSystemReferenceTableIndex");
        }
    }
}
