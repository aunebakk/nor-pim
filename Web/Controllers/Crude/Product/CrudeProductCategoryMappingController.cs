/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 2:16:21 PM
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
    public class CrudeProductCategoryMappingController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductCategoryMappingIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingIndex.cshtml",
                new CrudeProductCategoryMappingServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeProductCategoryMappingByProductCategoryIndex(System.Guid productCategoryId) {
            ViewBag.ProductCategoryId = productCategoryId;

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingIndex.cshtml",
                new CrudeProductCategoryMappingServiceClient().FetchByProductCategoryId(productCategoryId)
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeProductCategoryMappingByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingIndex.cshtml",
                new CrudeProductCategoryMappingServiceClient().FetchByProductId(productId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductCategoryMappingDetails(System.Guid productCategoryMappingId) {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingDetails.cshtml",
                new CrudeProductCategoryMappingServiceClient().FetchByProductCategoryMappingId(productCategoryMappingId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductCategoryMappingEdit(
            System.Guid productCategoryMappingId
            ) {

            CrudeProductCategoryMappingContract contract = new CrudeProductCategoryMappingServiceClient().FetchByProductCategoryMappingId(productCategoryMappingId);
            ViewBag.ProductCategoryId =
                new SelectList( new CrudeProductCategoryServiceClient().FetchAll(),
                                "ProductCategoryId",
                                "ProductCategoryName",
                                contract.ProductCategoryId
                                );

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryMappingEdit([Bind()] CrudeProductCategoryMappingContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductCategoryMappingServiceClient().Update(contract);

                return RedirectToAction("CrudeProductCategoryMappingIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductCategoryMappingCreate(System.Guid? productCategoryId, System.Guid? productId, System.Guid? userId) {
            var contract = new CrudeProductCategoryMappingContract();
            if (productCategoryId != null) contract.ProductCategoryId = (System.Guid) productCategoryId;
            if (productId != null) contract.ProductId = (System.Guid) productId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductCategoryId =
                new SelectList( new CrudeProductCategoryServiceClient().FetchAll(),
                                "ProductCategoryId",
                                "ProductCategoryName",
                                contract.ProductCategoryId
                                );

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
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryMappingCreate([Bind()] CrudeProductCategoryMappingContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductCategoryMappingServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductCategoryMappingIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryMapping/CrudeProductCategoryMappingCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductCategoryMappingDelete(
            System.Guid productCategoryMappingId
            ) {
            new CrudeProductCategoryMappingServiceClient().Delete(productCategoryMappingId);

            return RedirectToAction("CrudeProductCategoryMappingIndex");
        }
    }
}
