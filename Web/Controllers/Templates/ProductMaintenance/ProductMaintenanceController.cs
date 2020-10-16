/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 7:09:01 AM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateWithDurianGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductMaintenanceController : Controller {

        [HttpGet]
        public ActionResult ProductMaintenanceIndex() {

            return View(
                "~/Views/Templates/ProductMaintenance/ProductMaintenance/ProductMaintenanceIndex.cshtml",
                new ProductMaintenanceSearchService().ProductMaintenanceIndex()
                );
        }

        [HttpGet]
        public ActionResult ProductMaintenanceEdit(
            System.Guid productId
            ) {

            ViewBag.ProductId = productId;

            var productContract = new ProductMaintenanceContract();

            productContract.Product =
                new CrudeProductServiceClient().FetchByProductId(productId);

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productContract.Product.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductMaintenance/ProductMaintenanceEdit.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductMaintenanceEdit([Bind()] ProductMaintenanceContract productContract) {
            if (ModelState.IsValid) {

                productContract.Product.DateTime = DateTime.UtcNow;

                new CrudeProductServiceClient().Update(productContract.Product);

                return RedirectToAction("ProductMaintenanceIndex");
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductMaintenance/ProductMaintenanceEdit.cshtml",
                productContract
                );
        }

        [HttpGet]
        public ActionResult ProductMaintenanceCreate(System.Guid? productBecameId, System.Guid? userId) {
            var productContract = new ProductMaintenanceContract();
            productContract.Product = new CrudeProductContract();
            if (productBecameId != null) productContract.Product.ProductBecameId = (System.Guid) productBecameId;
            if (userId != null) productContract.Product.UserId = (System.Guid) userId;

            if (userId == null)
                productContract.Product.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productContract.Product.UserId).DefaultUserName;

            productContract.Product.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/ProductMaintenance/ProductMaintenance/ProductMaintenanceCreate.cshtml",
                productContract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductMaintenanceCreate([Bind()] ProductMaintenanceContract productContract) {
            if (ModelState.IsValid) {

                new CrudeProductServiceClient().Insert(productContract.Product);

                return RedirectToAction("ProductMaintenanceIndex");
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductMaintenance/ProductMaintenanceCreate.cshtml",
                productContract
                );
        }

    }
}
