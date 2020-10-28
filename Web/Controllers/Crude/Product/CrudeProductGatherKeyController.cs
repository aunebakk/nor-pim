/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 10:10:23 PM
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
    public class CrudeProductGatherKeyController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductGatherKeyIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherKey/CrudeProductGatherKeyIndex.cshtml",
                new CrudeProductGatherKeyServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductGatherKeyDetails(System.Guid productGatherKeyId) {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherKey/CrudeProductGatherKeyDetails.cshtml",
                new CrudeProductGatherKeyServiceClient().FetchByProductGatherKeyId(productGatherKeyId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductGatherKeyEdit(
            System.Guid productGatherKeyId
            ) {

            CrudeProductGatherKeyContract contract = new CrudeProductGatherKeyServiceClient().FetchByProductGatherKeyId(productGatherKeyId);
            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductGatherKey/CrudeProductGatherKeyEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherKeyEdit([Bind()] CrudeProductGatherKeyContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductGatherKeyServiceClient().Update(contract);

                return RedirectToAction("CrudeProductGatherKeyIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherKey/CrudeProductGatherKeyEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductGatherKeyCreate(System.Guid? productGatherId, System.Guid? userId) {
            var contract = new CrudeProductGatherKeyContract();
            if (productGatherId != null) contract.ProductGatherId = (System.Guid) productGatherId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductGatherKey/CrudeProductGatherKeyCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherKeyCreate([Bind()] CrudeProductGatherKeyContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductGatherKeyServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductGatherKeyIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherKey/CrudeProductGatherKeyCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductGatherKeyDelete(
            System.Guid productGatherKeyId
            ) {
            new CrudeProductGatherKeyServiceClient().Delete(productGatherKeyId);

            return RedirectToAction("CrudeProductGatherKeyIndex");
        }
    }
}
