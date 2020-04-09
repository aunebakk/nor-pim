/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:46:51 PM
  Template: sql2x.TemplateByServiceTableCrudGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public partial class ProductReferenceCategoryController : Controller {

        [HttpGet]
        public ActionResult ProductReferenceCategoryIndex() {

            return RedirectToAction(
                    "ProductReferenceCategoryEdit",
                    new {    productCategoryId = Guid.Empty    }
                    );
        }

        [HttpGet]
        public ActionResult ProductReferenceCategoryEdit(
            ) {

            ProductReferenceCategoryContract productContract =
                new ProductReferenceCategoryServiceClient().
                        ProductReferenceCategoryCompleteGet(
                            Guid.Empty,
                            new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
                            );


            return View(
                "~/Views/Templates/ProductReference/ProductReferenceCategory/ProductReferenceCategoryEdit.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductReferenceCategoryEdit(
            [Bind()] ProductReferenceCategoryContract productContract
            ) {
            new ProductReferenceCategoryServiceClient().
                    ProductReferenceCategoryCompleteUpdate(
                        Guid.Empty,
                        productContract,
                        new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
                        );

            return RedirectToAction(
                    "ProductReferenceCategoryEdit",
                    new {    productCategoryId = Guid.Empty}
                    );
        }

        [HttpGet]
        public ActionResult ProductReferenceCategoryCreate(System.Guid? productCategoryBecameId, System.Guid? productCategoryParentId, System.Guid? userId) {
            var productContract = new ProductReferenceCategoryContract();
            productContract.ProductCategoryNew = new CrudeProductCategoryContract();
            if (productCategoryBecameId != null) productContract.ProductCategoryNew.ProductCategoryBecameId = (System.Guid) productCategoryBecameId;
            if (productCategoryParentId != null) productContract.ProductCategoryNew.ProductCategoryParentId = (System.Guid) productCategoryParentId;
            if (userId != null) productContract.ProductCategoryNew.UserId = (System.Guid) userId;

            if (userId == null)
                productContract.ProductCategoryNew.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productContract.ProductCategoryNew.UserId).DefaultUserName;

            productContract.ProductCategoryNew.DateTime = DateTime.UtcNow;

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceCategory/ProductReferenceCategoryCreate.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductReferenceCategoryCreate([Bind()] ProductReferenceCategoryContract productContract) {
            if (ModelState.IsValid) {

                new CrudeProductCategoryServiceClient().Insert(productContract.ProductCategoryNew);

                return RedirectToAction(
                        "ProductReferenceCategoryEdit",
                        new {    productCategoryId = Guid.Empty}
                        );
            }

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceCategory/ProductReferenceCategoryCreate.cshtml",
                productContract
                );
        }

    }
}
