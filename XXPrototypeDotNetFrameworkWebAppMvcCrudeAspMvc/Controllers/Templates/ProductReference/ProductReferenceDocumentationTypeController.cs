/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:49:43 PM
  Template: sql2x.TemplateByServiceTableCrudGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public partial class ProductReferenceDocumentationTypeController : Controller {

        [HttpGet]
        public ActionResult ProductReferenceDocumentationTypeIndex() {

            return RedirectToAction(
                    "ProductReferenceDocumentationTypeEdit",
                    new {    productDocumentationTypeRcd = String.Empty    }
                    );
        }

        [HttpGet]
        public ActionResult ProductReferenceDocumentationTypeEdit(
            ) {

            ProductReferenceDocumentationTypeContract productContract =
                new ProductReferenceDocumentationTypeServiceClient().
                        ProductReferenceDocumentationTypeCompleteGet(
                            String.Empty,
                            new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
                            );


            return View(
                "~/Views/Templates/ProductReference/ProductReferenceDocumentationType/ProductReferenceDocumentationTypeEdit.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductReferenceDocumentationTypeEdit(
            [Bind()] ProductReferenceDocumentationTypeContract productContract
            ) {
            new ProductReferenceDocumentationTypeServiceClient().
                    ProductReferenceDocumentationTypeCompleteUpdate(
                        String.Empty,
                        productContract,
                        new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
                        );

            return RedirectToAction(
                    "ProductReferenceDocumentationTypeEdit",
                    new {    productDocumentationTypeRcd = String.Empty}
                    );
        }

        [HttpGet]
        public ActionResult ProductReferenceDocumentationTypeCreate(System.Guid? userId) {
            var productContract = new ProductReferenceDocumentationTypeContract();
            productContract.ProductDocumentationTypeRefNew = new CrudeProductDocumentationTypeRefContract();
            if (userId != null) productContract.ProductDocumentationTypeRefNew.UserId = (System.Guid) userId;

            if (userId == null)
                productContract.ProductDocumentationTypeRefNew.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            productContract.ProductDocumentationTypeRefNew.DateTime = DateTime.UtcNow;

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceDocumentationType/ProductReferenceDocumentationTypeCreate.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductReferenceDocumentationTypeCreate([Bind()] ProductReferenceDocumentationTypeContract productContract) {
            if (ModelState.IsValid) {

                new CrudeProductDocumentationTypeRefServiceClient().Insert(productContract.ProductDocumentationTypeRefNew);

                return RedirectToAction(
                        "ProductReferenceDocumentationTypeEdit",
                        new {    productDocumentationTypeRcd = String.Empty}
                        );
            }

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceDocumentationType/ProductReferenceDocumentationTypeCreate.cshtml",
                productContract
                );
        }

    }
}
