/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:47:16 PM
  Template: sql2x.TemplateByServiceTableCrudGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public partial class ProductReferenceImageTypeController : Controller {

        [HttpGet]
        public ActionResult ProductReferenceImageTypeIndex() {

            return RedirectToAction(
                    "ProductReferenceImageTypeEdit",
                    new {    productImageTypeRcd = String.Empty    }
                    );
        }

        [HttpGet]
        public ActionResult ProductReferenceImageTypeEdit(
            ) {

            ProductReferenceImageTypeContract productContract =
                new ProductReferenceImageTypeServiceClient().
                        ProductReferenceImageTypeCompleteGet(
                            String.Empty,
                            new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
                            );


            return View(
                "~/Views/Templates/ProductReference/ProductReferenceImageType/ProductReferenceImageTypeEdit.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductReferenceImageTypeEdit(
            [Bind()] ProductReferenceImageTypeContract productContract
            ) {
            new ProductReferenceImageTypeServiceClient().
                    ProductReferenceImageTypeCompleteUpdate(
                        String.Empty,
                        productContract,
                        new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
                        );

            return RedirectToAction(
                    "ProductReferenceImageTypeEdit",
                    new {    productImageTypeRcd = String.Empty}
                    );
        }

        [HttpGet]
        public ActionResult ProductReferenceImageTypeCreate(System.Guid? userId) {
            var productContract = new ProductReferenceImageTypeContract();
            productContract.ProductImageTypeRefNew = new CrudeProductImageTypeRefContract();
            if (userId != null) productContract.ProductImageTypeRefNew.UserId = (System.Guid) userId;

            if (userId == null)
                productContract.ProductImageTypeRefNew.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            productContract.ProductImageTypeRefNew.DateTime = DateTime.UtcNow;

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceImageType/ProductReferenceImageTypeCreate.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductReferenceImageTypeCreate([Bind()] ProductReferenceImageTypeContract productContract) {
            if (ModelState.IsValid) {

                new CrudeProductImageTypeRefServiceClient().Insert(productContract.ProductImageTypeRefNew);

                return RedirectToAction(
                        "ProductReferenceImageTypeEdit",
                        new {    productImageTypeRcd = String.Empty}
                        );
            }

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceImageType/ProductReferenceImageTypeCreate.cshtml",
                productContract
                );
        }

    }
}
