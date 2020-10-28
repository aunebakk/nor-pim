/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 8:06:25 PM
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
    public class CrudeProductImageController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductImageIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductImage/CrudeProductImageIndex.cshtml",
                new CrudeProductImageServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeProductImageByProductIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Crude/Product/CrudeProductImage/CrudeProductImageIndex.cshtml",
                new CrudeProductImageServiceClient().FetchByProductId(productId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductImageDetails(System.Guid productImageId) {

            return View(
                "~/Views/Crude/Product/CrudeProductImage/CrudeProductImageDetails.cshtml",
                new CrudeProductImageServiceClient().FetchByProductImageId(productImageId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductImageEdit(
            System.Guid productImageId
            ) {

            CrudeProductImageContract contract = new CrudeProductImageServiceClient().FetchByProductImageId(productImageId);
            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.ProductImageTypeRcd =
                new SelectList( new CrudeProductImageTypeRefServiceClient().FetchAll(),
                                "ProductImageTypeRcd",
                                "ProductImageTypeName",
                                contract.ProductImageTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductImage/CrudeProductImageEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductImageEdit([Bind()] CrudeProductImageContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductImageServiceClient().Update(contract);

                return RedirectToAction("CrudeProductImageIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductImage/CrudeProductImageEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductImageCreate(System.Guid? productId, System.Guid? userId) {
            var contract = new CrudeProductImageContract();
            if (productId != null) contract.ProductId = (System.Guid) productId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                contract.ProductId
                                );

            ViewBag.ProductImageTypeRcd =
                new SelectList( new CrudeProductImageTypeRefServiceClient().FetchAll(),
                                "ProductImageTypeRcd",
                                "ProductImageTypeName",
                                contract.ProductImageTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductImage/CrudeProductImageCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductImageCreate([Bind()] CrudeProductImageContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductImageServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductImageIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductImage/CrudeProductImageCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductImageDelete(
            System.Guid productImageId
            ) {
            new CrudeProductImageServiceClient().Delete(productImageId);

            return RedirectToAction("CrudeProductImageIndex");
        }
    }
}
