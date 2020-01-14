/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:55:53 AM
  Template: sql2x.TemplateByServiceTableCrudGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public partial class ProductReferenceInfoController : Controller {

        [HttpGet]
        public ActionResult ProductReferenceInfoIndex() {

            return RedirectToAction(
                    "ProductReferenceInfoEdit",
                    new {    productInfoRcd = String.Empty    }
                    );
        }

        [HttpGet]
        public ActionResult ProductReferenceInfoEdit(
            ) {

            ProductReferenceInfoContract productContract =
                new ProductReferenceInfoServiceClient().
                        ProductReferenceInfoCompleteGet(
                            String.Empty,
                            new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
                            );


            return View(
                "~/Views/Templates/ProductReference/ProductReferenceInfo/ProductReferenceInfoEdit.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductReferenceInfoEdit(
            [Bind()] ProductReferenceInfoContract productContract
            ) {
            new ProductReferenceInfoServiceClient().
                    ProductReferenceInfoCompleteUpdate(
                        String.Empty,
                        productContract,
                        new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}")
                        );

            return RedirectToAction(
                    "ProductReferenceInfoEdit",
                    new {    productInfoRcd = String.Empty}
                    );
        }

        [HttpGet]
        public ActionResult ProductReferenceInfoCreate(System.Guid? userId) {
            var productContract = new ProductReferenceInfoContract();
            productContract.ProductInfoRefNew = new CrudeProductInfoRefContract();
            if (userId != null) productContract.ProductInfoRefNew.UserId = (System.Guid) userId;

            if (userId == null)
                productContract.ProductInfoRefNew.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            productContract.ProductInfoRefNew.DateTime = DateTime.UtcNow;

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceInfo/ProductReferenceInfoCreate.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductReferenceInfoCreate([Bind()] ProductReferenceInfoContract productContract) {
            if (ModelState.IsValid) {

                new CrudeProductInfoRefServiceClient().Insert(productContract.ProductInfoRefNew);

                return RedirectToAction(
                        "ProductReferenceInfoEdit",
                        new {    productInfoRcd = String.Empty}
                        );
            }

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceInfo/ProductReferenceInfoCreate.cshtml",
                productContract
                );
        }

    }
}
