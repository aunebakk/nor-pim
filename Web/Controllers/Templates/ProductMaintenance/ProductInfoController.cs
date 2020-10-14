/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:20:30 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateWithDurianGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductInfoController : Controller {

        [HttpGet]
        public ActionResult ProductInfoIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductInfo/ProductInfoIndex.cshtml",
                new ProductMaintenanceSearchService().ProductMaintenanceInfoIndexWithFilter(productId)
                );
        }

        [HttpGet]
        public ActionResult ProductInfoEdit(
            System.Guid productInfoId
            ) {

            ViewBag.ProductInfoId = productInfoId;

            var productInfoContract = new ProductInfoContract();

            productInfoContract.ProductInfo =
                new CrudeProductInfoServiceClient().FetchByProductInfoId(productInfoId);

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productInfoContract.ProductInfo.ProductId
                                );

            ViewBag.ProductInfoRcd =
                new SelectList( new CrudeProductInfoRefServiceClient().FetchAll(),
                                "ProductInfoRcd",
                                "ProductInfoName",
                                productInfoContract.ProductInfo.ProductInfoRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productInfoContract.ProductInfo.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductInfo/ProductInfoEdit.cshtml",
                productInfoContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductInfoEdit([Bind()] ProductInfoContract productInfoContract, System.Guid productId,System.String productInfoRcd) {
            if (ModelState.IsValid) {

                productInfoContract.ProductInfo.ProductId = productId;
                productInfoContract.ProductInfo.ProductInfoRcd = productInfoRcd;
                productInfoContract.ProductInfo.DateTime = DateTime.UtcNow;

                new CrudeProductInfoServiceClient().Update(productInfoContract.ProductInfo);

                return RedirectToAction("ProductInfoIndex", new { productId = productInfoContract.ProductInfo.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductInfo/ProductInfoEdit.cshtml",
                productInfoContract
                );
        }

        [HttpGet]
        public ActionResult ProductInfoCreate(System.Guid? productId, System.Guid? userId) {
            var productInfoContract = new ProductInfoContract();
            productInfoContract.ProductInfo = new CrudeProductInfoContract();
            if (productId != null) productInfoContract.ProductInfo.ProductId = (System.Guid) productId;
            if (userId != null) productInfoContract.ProductInfo.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productInfoContract.ProductInfo.ProductId
                                );

            ViewBag.ProductInfoRcd =
                new SelectList( new CrudeProductInfoRefServiceClient().FetchAll(),
                                "ProductInfoRcd",
                                "ProductInfoName",
                                productInfoContract.ProductInfo.ProductInfoRcd
                                );

            if (userId == null)
                productInfoContract.ProductInfo.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productInfoContract.ProductInfo.UserId).DefaultUserName;

            productInfoContract.ProductInfo.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/ProductMaintenance/ProductInfo/ProductInfoCreate.cshtml",
                productInfoContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductInfoCreate([Bind()] ProductInfoContract productInfoContract, System.Guid productId,System.String productInfoRcd) {
            if (ModelState.IsValid) {

                productInfoContract.ProductInfo.ProductId = productId;
                productInfoContract.ProductInfo.ProductInfoRcd = productInfoRcd;
                new CrudeProductInfoServiceClient().Insert(productInfoContract.ProductInfo);

                return RedirectToAction("ProductInfoIndex", new { productId = productInfoContract.ProductInfo.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductInfo/ProductInfoCreate.cshtml",
                productInfoContract
                );
        }

    }
}
