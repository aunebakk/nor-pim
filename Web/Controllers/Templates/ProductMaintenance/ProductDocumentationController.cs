/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/27/2020 8:29:52 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateWithDurianGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductDocumentationController : Controller {

        [HttpGet]
        public ActionResult ProductDocumentationIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductDocumentation/ProductDocumentationIndex.cshtml",
                new ProductMaintenanceSearchService().ProductMaintenanceDocumentationIndexWithFilter(productId)
                );
        }

        [HttpGet]
        public ActionResult ProductDocumentationEdit(
            System.Guid productDocumentationId
            ) {

            ViewBag.ProductDocumentationId = productDocumentationId;

            var productDocumentationContract = new ProductDocumentationContract();

            productDocumentationContract.ProductDocumentation =
                new CrudeProductDocumentationServiceClient().FetchByProductDocumentationId(productDocumentationId);

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productDocumentationContract.ProductDocumentation.ProductId
                                );

            ViewBag.ProductDocumentationTypeRcd =
                new SelectList( new CrudeProductDocumentationTypeRefServiceClient().FetchAll(),
                                "ProductDocumentationTypeRcd",
                                "ProductDocumentationTypeName",
                                productDocumentationContract.ProductDocumentation.ProductDocumentationTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productDocumentationContract.ProductDocumentation.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductDocumentation/ProductDocumentationEdit.cshtml",
                productDocumentationContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductDocumentationEdit([Bind()] ProductDocumentationContract productDocumentationContract, System.Guid productId,System.String productDocumentationTypeRcd) {
            if (ModelState.IsValid) {

                productDocumentationContract.ProductDocumentation.ProductId = productId;
                productDocumentationContract.ProductDocumentation.ProductDocumentationTypeRcd = productDocumentationTypeRcd;
                productDocumentationContract.ProductDocumentation.DateTime = DateTime.UtcNow;

                new CrudeProductDocumentationServiceClient().Update(productDocumentationContract.ProductDocumentation);

                return RedirectToAction("ProductDocumentationIndex", new { productId = productDocumentationContract.ProductDocumentation.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductDocumentation/ProductDocumentationEdit.cshtml",
                productDocumentationContract
                );
        }

        [HttpGet]
        public ActionResult ProductDocumentationCreate(System.Guid? productId, System.Guid? userId) {
            var productDocumentationContract = new ProductDocumentationContract();
            productDocumentationContract.ProductDocumentation = new CrudeProductDocumentationContract();
            if (productId != null) productDocumentationContract.ProductDocumentation.ProductId = (System.Guid) productId;
            if (userId != null) productDocumentationContract.ProductDocumentation.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productDocumentationContract.ProductDocumentation.ProductId
                                );

            ViewBag.ProductDocumentationTypeRcd =
                new SelectList( new CrudeProductDocumentationTypeRefServiceClient().FetchAll(),
                                "ProductDocumentationTypeRcd",
                                "ProductDocumentationTypeName",
                                productDocumentationContract.ProductDocumentation.ProductDocumentationTypeRcd
                                );

            if (userId == null)
                productDocumentationContract.ProductDocumentation.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productDocumentationContract.ProductDocumentation.UserId).DefaultUserName;

            productDocumentationContract.ProductDocumentation.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/ProductMaintenance/ProductDocumentation/ProductDocumentationCreate.cshtml",
                productDocumentationContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductDocumentationCreate([Bind()] ProductDocumentationContract productDocumentationContract, System.Guid productId,System.String productDocumentationTypeRcd) {
            if (ModelState.IsValid) {

                productDocumentationContract.ProductDocumentation.ProductId = productId;
                productDocumentationContract.ProductDocumentation.ProductDocumentationTypeRcd = productDocumentationTypeRcd;
                new CrudeProductDocumentationServiceClient().Insert(productDocumentationContract.ProductDocumentation);

                return RedirectToAction("ProductDocumentationIndex", new { productId = productDocumentationContract.ProductDocumentation.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductDocumentation/ProductDocumentationCreate.cshtml",
                productDocumentationContract
                );
        }

    }
}
