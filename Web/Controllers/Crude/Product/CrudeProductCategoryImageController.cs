/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 2:46:57 PM
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
    public class CrudeProductCategoryImageController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductCategoryImageIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageIndex.cshtml",
                new CrudeProductCategoryImageServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeProductCategoryImageByProductCategoryIndex(System.Guid productCategoryId) {
            ViewBag.ProductCategoryId = productCategoryId;

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageIndex.cshtml",
                new CrudeProductCategoryImageServiceClient().FetchByProductCategoryId(productCategoryId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductCategoryImageDetails(System.Guid productCategoryImageId) {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageDetails.cshtml",
                new CrudeProductCategoryImageServiceClient().FetchByProductCategoryImageId(productCategoryImageId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductCategoryImageEdit(
            System.Guid productCategoryImageId
            ) {

            CrudeProductCategoryImageContract contract = new CrudeProductCategoryImageServiceClient().FetchByProductCategoryImageId(productCategoryImageId);
            ViewBag.ProductCategoryId =
                new SelectList( new CrudeProductCategoryServiceClient().FetchAll(),
                                "ProductCategoryId",
                                "ProductCategoryName",
                                contract.ProductCategoryId
                                );

            ViewBag.ProductCategoryImageTypeRcd =
                new SelectList( new CrudeProductCategoryImageTypeRefServiceClient().FetchAll(),
                                "ProductCategoryImageTypeRcd",
                                "ProductCategoryImageTypeName",
                                contract.ProductCategoryImageTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryImageEdit([Bind()] CrudeProductCategoryImageContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductCategoryImageServiceClient().Update(contract);

                return RedirectToAction("CrudeProductCategoryImageIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductCategoryImageCreate(System.Guid? productCategoryId, System.Guid? userId) {
            var contract = new CrudeProductCategoryImageContract();
            if (productCategoryId != null) contract.ProductCategoryId = (System.Guid) productCategoryId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductCategoryId =
                new SelectList( new CrudeProductCategoryServiceClient().FetchAll(),
                                "ProductCategoryId",
                                "ProductCategoryName",
                                contract.ProductCategoryId
                                );

            ViewBag.ProductCategoryImageTypeRcd =
                new SelectList( new CrudeProductCategoryImageTypeRefServiceClient().FetchAll(),
                                "ProductCategoryImageTypeRcd",
                                "ProductCategoryImageTypeName",
                                contract.ProductCategoryImageTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryImageCreate([Bind()] CrudeProductCategoryImageContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductCategoryImageServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductCategoryImageIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductCategoryImageDelete(
            System.Guid productCategoryImageId
            ) {
            new CrudeProductCategoryImageServiceClient().Delete(productCategoryImageId);

            return RedirectToAction("CrudeProductCategoryImageIndex");
        }
    }
}
