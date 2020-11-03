/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:48:54 AM
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
    public class CrudeProductExposedSelectionController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductExposedSelectionIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductExposedSelection/CrudeProductExposedSelectionIndex.cshtml",
                new CrudeProductExposedSelectionServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductExposedSelectionDetails(System.Guid productExposedSelectionId) {

            return View(
                "~/Views/Crude/Product/CrudeProductExposedSelection/CrudeProductExposedSelectionDetails.cshtml",
                new CrudeProductExposedSelectionServiceClient().FetchByProductExposedSelectionId(productExposedSelectionId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductExposedSelectionEdit(
            System.Guid productExposedSelectionId
            ) {

            CrudeProductExposedSelectionContract contract = new CrudeProductExposedSelectionServiceClient().FetchByProductExposedSelectionId(productExposedSelectionId);
            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductExposedSelection/CrudeProductExposedSelectionEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposedSelectionEdit([Bind()] CrudeProductExposedSelectionContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductExposedSelectionServiceClient().Update(contract);

                return RedirectToAction("CrudeProductExposedSelectionIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExposedSelection/CrudeProductExposedSelectionEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductExposedSelectionCreate(System.Guid? productExposeId, System.Guid? userId) {
            var contract = new CrudeProductExposedSelectionContract();
            if (productExposeId != null) contract.ProductExposeId = (System.Guid) productExposeId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductExposedSelection/CrudeProductExposedSelectionCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposedSelectionCreate([Bind()] CrudeProductExposedSelectionContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductExposedSelectionServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductExposedSelectionIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExposedSelection/CrudeProductExposedSelectionCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductExposedSelectionDelete(
            System.Guid productExposedSelectionId
            ) {
            new CrudeProductExposedSelectionServiceClient().Delete(productExposedSelectionId);

            return RedirectToAction("CrudeProductExposedSelectionIndex");
        }
    }
}
