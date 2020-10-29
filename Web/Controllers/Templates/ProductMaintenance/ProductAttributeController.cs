/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:15:26 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateWithDurianGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductAttributeController : Controller {

        [HttpGet]
        public ActionResult ProductAttributeIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductAttribute/ProductAttributeIndex.cshtml",
                new ProductMaintenanceSearchService().ProductMaintenanceAttributeIndexWithFilter(productId)
                );
        }

        [HttpGet]
        public ActionResult ProductAttributeEdit(
            System.Guid productAttributeId
            ) {

            ViewBag.ProductAttributeId = productAttributeId;

            var productAttributeContract = new ProductAttributeContract();

            productAttributeContract.ProductAttribute =
                new CrudeProductAttributeServiceClient().FetchByProductAttributeId(productAttributeId);

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productAttributeContract.ProductAttribute.ProductId
                                );

            ViewBag.ProductAttributeRcd =
                new SelectList( new CrudeProductAttributeRefServiceClient().FetchAll(),
                                "ProductAttributeRcd",
                                "ProductAttributeName",
                                productAttributeContract.ProductAttribute.ProductAttributeRcd
                                );

            ViewBag.ProductAttributeUnitRcd =
                new SelectList( new CrudeProductAttributeUnitRefServiceClient().FetchAll(),
                                "ProductAttributeUnitRcd",
                                "ProductAttributeUnitName",
                                productAttributeContract.ProductAttribute.ProductAttributeUnitRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productAttributeContract.ProductAttribute.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductAttribute/ProductAttributeEdit.cshtml",
                productAttributeContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductAttributeEdit([Bind()] ProductAttributeContract productAttributeContract, System.Guid productId,System.String productAttributeRcd,System.String productAttributeUnitRcd) {
            if (ModelState.IsValid) {

                productAttributeContract.ProductAttribute.ProductId = productId;
                productAttributeContract.ProductAttribute.ProductAttributeRcd = productAttributeRcd;
                productAttributeContract.ProductAttribute.ProductAttributeUnitRcd = productAttributeUnitRcd;
                productAttributeContract.ProductAttribute.DateTime = DateTime.UtcNow;

                new CrudeProductAttributeServiceClient().Update(productAttributeContract.ProductAttribute);

                return RedirectToAction("ProductAttributeIndex", new { productId = productAttributeContract.ProductAttribute.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductAttribute/ProductAttributeEdit.cshtml",
                productAttributeContract
                );
        }

        [HttpGet]
        public ActionResult ProductAttributeCreate(System.Guid? productId, System.Guid? userId) {
            var productAttributeContract = new ProductAttributeContract();
            productAttributeContract.ProductAttribute = new CrudeProductAttributeContract();
            if (productId != null) productAttributeContract.ProductAttribute.ProductId = (System.Guid) productId;
            if (userId != null) productAttributeContract.ProductAttribute.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productAttributeContract.ProductAttribute.ProductId
                                );

            ViewBag.ProductAttributeRcd =
                new SelectList( new CrudeProductAttributeRefServiceClient().FetchAll(),
                                "ProductAttributeRcd",
                                "ProductAttributeName",
                                productAttributeContract.ProductAttribute.ProductAttributeRcd
                                );

            ViewBag.ProductAttributeUnitRcd =
                new SelectList( new CrudeProductAttributeUnitRefServiceClient().FetchAll(),
                                "ProductAttributeUnitRcd",
                                "ProductAttributeUnitName",
                                productAttributeContract.ProductAttribute.ProductAttributeUnitRcd
                                );

            if (userId == null)
                productAttributeContract.ProductAttribute.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productAttributeContract.ProductAttribute.UserId).DefaultUserName;

            productAttributeContract.ProductAttribute.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/ProductMaintenance/ProductAttribute/ProductAttributeCreate.cshtml",
                productAttributeContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductAttributeCreate([Bind()] ProductAttributeContract productAttributeContract, System.Guid productId,System.String productAttributeRcd,System.String productAttributeUnitRcd) {
            if (ModelState.IsValid) {

                productAttributeContract.ProductAttribute.ProductId = productId;
                productAttributeContract.ProductAttribute.ProductAttributeRcd = productAttributeRcd;
                productAttributeContract.ProductAttribute.ProductAttributeUnitRcd = productAttributeUnitRcd;
                new CrudeProductAttributeServiceClient().Insert(productAttributeContract.ProductAttribute);

                return RedirectToAction("ProductAttributeIndex", new { productId = productAttributeContract.ProductAttribute.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductAttribute/ProductAttributeCreate.cshtml",
                productAttributeContract
                );
        }

    }
}
