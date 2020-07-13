/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 4:00:00 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateWithDurianGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductIdentifierController : Controller {

        [HttpGet]
        public ActionResult ProductIdentifierIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductIdentifier/ProductIdentifierIndex.cshtml",
                new ProductMaintenanceSearchService().ProductMaintenanceIdentifierIndexWithFilter(productId)
                );
        }

        [HttpGet]
        public ActionResult ProductIdentifierEdit(
            System.Guid productIdentifierId
            ) {

            ViewBag.ProductIdentifierId = productIdentifierId;

            var productIdentifierContract = new ProductIdentifierContract();

            productIdentifierContract.ProductIdentifier =
                new CrudeProductIdentifierServiceClient().FetchByProductIdentifierId(productIdentifierId);

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productIdentifierContract.ProductIdentifier.ProductId
                                );

            ViewBag.ProductIdentifierRcd =
                new SelectList( new CrudeProductIdentifierRefServiceClient().FetchAll(),
                                "ProductIdentifierRcd",
                                "ProductIdentifierName",
                                productIdentifierContract.ProductIdentifier.ProductIdentifierRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productIdentifierContract.ProductIdentifier.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductIdentifier/ProductIdentifierEdit.cshtml",
                productIdentifierContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductIdentifierEdit([Bind()] ProductIdentifierContract productIdentifierContract, System.Guid productId,System.String productIdentifierRcd) {
            if (ModelState.IsValid) {

                productIdentifierContract.ProductIdentifier.ProductId = productId;
                productIdentifierContract.ProductIdentifier.ProductIdentifierRcd = productIdentifierRcd;
                productIdentifierContract.ProductIdentifier.DateTime = DateTime.UtcNow;

                new CrudeProductIdentifierServiceClient().Update(productIdentifierContract.ProductIdentifier);

                return RedirectToAction("ProductIdentifierIndex", new { productId = productIdentifierContract.ProductIdentifier.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductIdentifier/ProductIdentifierEdit.cshtml",
                productIdentifierContract
                );
        }

        [HttpGet]
        public ActionResult ProductIdentifierCreate(System.Guid? productId, System.Guid? userId) {
            var productIdentifierContract = new ProductIdentifierContract();
            productIdentifierContract.ProductIdentifier = new CrudeProductIdentifierContract();
            if (productId != null) productIdentifierContract.ProductIdentifier.ProductId = (System.Guid) productId;
            if (userId != null) productIdentifierContract.ProductIdentifier.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productIdentifierContract.ProductIdentifier.ProductId
                                );

            ViewBag.ProductIdentifierRcd =
                new SelectList( new CrudeProductIdentifierRefServiceClient().FetchAll(),
                                "ProductIdentifierRcd",
                                "ProductIdentifierName",
                                productIdentifierContract.ProductIdentifier.ProductIdentifierRcd
                                );

            if (userId == null)
                productIdentifierContract.ProductIdentifier.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productIdentifierContract.ProductIdentifier.UserId).DefaultUserName;

            productIdentifierContract.ProductIdentifier.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/ProductMaintenance/ProductIdentifier/ProductIdentifierCreate.cshtml",
                productIdentifierContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductIdentifierCreate([Bind()] ProductIdentifierContract productIdentifierContract, System.Guid productId,System.String productIdentifierRcd) {
            if (ModelState.IsValid) {

                productIdentifierContract.ProductIdentifier.ProductId = productId;
                productIdentifierContract.ProductIdentifier.ProductIdentifierRcd = productIdentifierRcd;
                new CrudeProductIdentifierServiceClient().Insert(productIdentifierContract.ProductIdentifier);

                return RedirectToAction("ProductIdentifierIndex", new { productId = productIdentifierContract.ProductIdentifier.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductIdentifier/ProductIdentifierCreate.cshtml",
                productIdentifierContract
                );
        }

    }
}
