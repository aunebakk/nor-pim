/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 9:47:10 AM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateByServiceTableCrudGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public partial class ProductReferenceAttributeUnitController : Controller {

        [HttpGet]
        public ActionResult ProductReferenceAttributeUnitIndex() {

            return RedirectToAction(
                    "ProductReferenceAttributeUnitEdit",
                    new {    productAttributeUnitRcd = String.Empty    }
                    );
        }

        [HttpGet]
        public ActionResult ProductReferenceAttributeUnitCreate(System.Guid? userId) {
            var productContract = new ProductReferenceAttributeUnitContract();
            productContract.ProductAttributeUnitRefNew = new CrudeProductAttributeUnitRefContract();
            if (userId != null) productContract.ProductAttributeUnitRefNew.UserId = (System.Guid) userId;

            if (userId == null)
                productContract.ProductAttributeUnitRefNew.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            productContract.ProductAttributeUnitRefNew.DateTime = DateTime.UtcNow;

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceAttributeUnit/ProductReferenceAttributeUnitCreate.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductReferenceAttributeUnitCreate([Bind()] ProductReferenceAttributeUnitContract productContract) {
            if (ModelState.IsValid) {

                new CrudeProductAttributeUnitRefServiceClient().Insert(productContract.ProductAttributeUnitRefNew);

                return RedirectToAction(
                        "ProductReferenceAttributeUnitEdit",
                        new {    productAttributeUnitRcd = String.Empty}
                        );
            }

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceAttributeUnit/ProductReferenceAttributeUnitCreate.cshtml",
                productContract
                );
        }

    }
}
