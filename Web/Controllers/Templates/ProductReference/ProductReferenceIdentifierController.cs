/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 9:10:43 AM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateByServiceTableCrudGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public partial class ProductReferenceIdentifierController : Controller {

        [HttpGet]
        public ActionResult ProductReferenceIdentifierIndex() {

            return RedirectToAction(
                    "ProductReferenceIdentifierEdit",
                    new {    productIdentifierId = Guid.Empty    }
                    );
        }

        [HttpGet]
        public ActionResult ProductReferenceIdentifierCreate(System.Guid? productId, System.Guid? userId) {
            var productContract = new ProductReferenceIdentifierContract();
            productContract.ProductIdentifierNew = new CrudeProductIdentifierContract();
            if (productId != null) productContract.ProductIdentifierNew.ProductId = (System.Guid) productId;
            if (userId != null) productContract.ProductIdentifierNew.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productContract.ProductIdentifierNew.ProductId
                                );

            ViewBag.ProductIdentifierRcd =
                new SelectList( new CrudeProductIdentifierRefServiceClient().FetchAll(),
                                "ProductIdentifierRcd",
                                "ProductIdentifierName",
                                productContract.ProductIdentifierNew.ProductIdentifierRcd
                                );

            if (userId == null)
                productContract.ProductIdentifierNew.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productContract.ProductIdentifierNew.UserId).DefaultUserName;

            productContract.ProductIdentifierNew.DateTime = DateTime.UtcNow;

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceIdentifier/ProductReferenceIdentifierCreate.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductReferenceIdentifierCreate([Bind()] ProductReferenceIdentifierContract productContract, System.Guid productId,System.String productIdentifierRcd) {
            if (ModelState.IsValid) {

                productContract.ProductIdentifierNew.ProductId = productId;
                productContract.ProductIdentifierNew.ProductIdentifierRcd = productIdentifierRcd;
                new CrudeProductIdentifierServiceClient().Insert(productContract.ProductIdentifierNew);

                return RedirectToAction(
                        "ProductReferenceIdentifierEdit",
                        new {    productIdentifierId = Guid.Empty}
                        );
            }

            return View(
                "~/Views/Templates/ProductReference/ProductReferenceIdentifier/ProductReferenceIdentifierCreate.cshtml",
                productContract
                );
        }

    }
}
