/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:05:14 PM
  From Machine: DESKTOP-742U247
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
                    new { productCategoryDocumentationTypeRcd = string.Empty }
                    );
        }

        [HttpGet]
        public ActionResult ProductReferenceCategoryDocumentationTypeCreate(System.Guid? userId) {
            ProductReferenceCategoryDocumentationTypeContract productContract = new ProductReferenceCategoryDocumentationTypeContract {
                ProductCategoryDocumentationTypeRefNew = new CrudeProductCategoryDocumentationTypeRefContract()
            };
            if (userId != null) {
                productContract.ProductCategoryDocumentationTypeRefNew.UserId = (System.Guid)userId;
            }

            if (userId == null) {
                productContract.ProductCategoryDocumentationTypeRefNew.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
            }

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
                        new { productCategoryDocumentationTypeRcd = string.Empty }
                        );
            }

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceCategoryDocumentationType/ProductReferenceCategoryDocumentationTypeCreate.cshtml",
                productContract
                );
        }

    }
}
