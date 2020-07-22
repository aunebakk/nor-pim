/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/22/2020 9:34:38 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateWithDurianGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductImageController : Controller {

        [HttpGet]
        public ActionResult ProductImageIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductImage/ProductImageIndex.cshtml",
                new ProductMaintenanceSearchService().ProductMaintenanceImageIndexWithFilter(productId)
                );
        }

        [HttpGet]
        public ActionResult ProductImageEdit(
            System.Guid productImageId
            ) {

            ViewBag.ProductImageId = productImageId;

            var productImageContract = new ProductImageContract();

            productImageContract.ProductImage =
                new CrudeProductImageServiceClient().FetchByProductImageId(productImageId);

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productImageContract.ProductImage.ProductId
                                );

            ViewBag.ProductImageTypeRcd =
                new SelectList( new CrudeProductImageTypeRefServiceClient().FetchAll(),
                                "ProductImageTypeRcd",
                                "ProductImageTypeName",
                                productImageContract.ProductImage.ProductImageTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productImageContract.ProductImage.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductImage/ProductImageEdit.cshtml",
                productImageContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductImageEdit([Bind()] ProductImageContract productImageContract, System.Guid productId,System.String productImageTypeRcd) {
            if (ModelState.IsValid) {

                productImageContract.ProductImage.ProductId = productId;
                productImageContract.ProductImage.ProductImageTypeRcd = productImageTypeRcd;
                productImageContract.ProductImage.DateTime = DateTime.UtcNow;

                new CrudeProductImageServiceClient().Update(productImageContract.ProductImage);

                return RedirectToAction("ProductImageIndex", new { productId = productImageContract.ProductImage.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductImage/ProductImageEdit.cshtml",
                productImageContract
                );
        }

        [HttpGet]
        public ActionResult ProductImageCreate(System.Guid? productId, System.Guid? userId) {
            var productImageContract = new ProductImageContract();
            productImageContract.ProductImage = new CrudeProductImageContract();
            if (productId != null) productImageContract.ProductImage.ProductId = (System.Guid) productId;
            if (userId != null) productImageContract.ProductImage.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productImageContract.ProductImage.ProductId
                                );

            ViewBag.ProductImageTypeRcd =
                new SelectList( new CrudeProductImageTypeRefServiceClient().FetchAll(),
                                "ProductImageTypeRcd",
                                "ProductImageTypeName",
                                productImageContract.ProductImage.ProductImageTypeRcd
                                );

            if (userId == null)
                productImageContract.ProductImage.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productImageContract.ProductImage.UserId).DefaultUserName;

            productImageContract.ProductImage.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/ProductMaintenance/ProductImage/ProductImageCreate.cshtml",
                productImageContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductImageCreate([Bind()] ProductImageContract productImageContract, System.Guid productId,System.String productImageTypeRcd) {
            if (ModelState.IsValid) {

                productImageContract.ProductImage.ProductId = productId;
                productImageContract.ProductImage.ProductImageTypeRcd = productImageTypeRcd;
                new CrudeProductImageServiceClient().Insert(productImageContract.ProductImage);

                return RedirectToAction("ProductImageIndex", new { productId = productImageContract.ProductImage.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductImage/ProductImageCreate.cshtml",
                productImageContract
                );
        }

    }
}
