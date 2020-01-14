/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:55:33 AM
  Template: sql2x.TemplateByServiceTableCrudGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public partial class ProductReferenceCategoryDocumentationTypeController : Controller {

        [HttpGet]
        public ActionResult ProductReferenceCategoryDocumentationTypeIndex() {

            return RedirectToAction(
                    "ProductReferenceCategoryDocumentationTypeEdit",
                    new {    productCategoryDocumentationTypeRcd = String.Empty    }
                    );
        }

        [HttpGet]
        public ActionResult ProductReferenceCategoryDocumentationTypeEdit(
            ) {

            ProductReferenceCategoryDocumentationTypeContract productContract =
                new ProductReferenceCategoryDocumentationTypeServiceClient().
                        ProductReferenceCategoryDocumentationTypeCompleteGet(
                            String.Empty,
                            new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
                            );


            return View(
                "~/Views/Templates/ProductReference/ProductReferenceCategoryDocumentationType/ProductReferenceCategoryDocumentationTypeEdit.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductReferenceCategoryDocumentationTypeEdit(
            [Bind()] ProductReferenceCategoryDocumentationTypeContract productContract
            ) {
            new ProductReferenceCategoryDocumentationTypeServiceClient().
                    ProductReferenceCategoryDocumentationTypeCompleteUpdate(
                        String.Empty,
                        productContract,
                        new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
                        );

            return RedirectToAction(
                    "ProductReferenceCategoryDocumentationTypeEdit",
                    new {    productCategoryDocumentationTypeRcd = String.Empty}
                    );
        }

        [HttpGet]
        public ActionResult ProductReferenceCategoryDocumentationTypeCreate(System.Guid? userId) {
            var productContract = new ProductReferenceCategoryDocumentationTypeContract();
            productContract.ProductCategoryDocumentationTypeRefNew = new CrudeProductCategoryDocumentationTypeRefContract();
            if (userId != null) productContract.ProductCategoryDocumentationTypeRefNew.UserId = (System.Guid) userId;

            if (userId == null)
                productContract.ProductCategoryDocumentationTypeRefNew.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            productContract.ProductCategoryDocumentationTypeRefNew.DateTime = DateTime.UtcNow;

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceCategoryDocumentationType/ProductReferenceCategoryDocumentationTypeCreate.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductReferenceCategoryDocumentationTypeCreate([Bind()] ProductReferenceCategoryDocumentationTypeContract productContract) {
            if (ModelState.IsValid) {

                new CrudeProductCategoryDocumentationTypeRefServiceClient().Insert(productContract.ProductCategoryDocumentationTypeRefNew);

                return RedirectToAction(
                        "ProductReferenceCategoryDocumentationTypeEdit",
                        new {    productCategoryDocumentationTypeRcd = String.Empty}
                        );
            }

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceCategoryDocumentationType/ProductReferenceCategoryDocumentationTypeCreate.cshtml",
                productContract
                );
        }

    }
}
