/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 9:53:57 AM
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
    public class CrudeProductChangeSetController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductChangeSetIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductChangeSet/CrudeProductChangeSetIndex.cshtml",
                new CrudeProductChangeSetServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeProductChangeSetByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Product/CrudeProductChangeSet/CrudeProductChangeSetIndex.cshtml",
                new CrudeProductChangeSetServiceClient().FetchByProductId(productId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductChangeSetDetails(System.Guid productChangeSetId) {

            return View(
                "~/Views/Crude/Product/CrudeProductChangeSet/CrudeProductChangeSetDetails.cshtml",
                new CrudeProductChangeSetServiceClient().FetchByProductChangeSetId(productChangeSetId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductChangeSetEdit(
            System.Guid productChangeSetId
            ) {

            CrudeProductChangeSetContract contract = new CrudeProductChangeSetServiceClient().FetchByProductChangeSetId(productChangeSetId);
            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductChangeSet/CrudeProductChangeSetEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductChangeSetEdit([Bind()] CrudeProductChangeSetContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductChangeSetServiceClient().Update(contract);

                return RedirectToAction("CrudeProductChangeSetIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductChangeSet/CrudeProductChangeSetEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductChangeSetCreate(System.Guid? productId, System.Guid? productGatherKeyId, System.Guid? userId) {
            var contract = new CrudeProductChangeSetContract();
            if (productId != null) contract.ProductId = (System.Guid) productId;
            if (productGatherKeyId != null) contract.ProductGatherKeyId = (System.Guid) productGatherKeyId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductChangeSet/CrudeProductChangeSetCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductChangeSetCreate([Bind()] CrudeProductChangeSetContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductChangeSetServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductChangeSetIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductChangeSet/CrudeProductChangeSetCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductChangeSetDelete(
            System.Guid productChangeSetId
            ) {
            new CrudeProductChangeSetServiceClient().Delete(productChangeSetId);

            return RedirectToAction("CrudeProductChangeSetIndex");
        }
    }
}
