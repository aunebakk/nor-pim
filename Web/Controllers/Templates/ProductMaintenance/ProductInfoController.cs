/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:16:00 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateWithDurianGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client ASP Controller
// the Client ASP Controller Layer uses the Proxy Layer to tie into SOAP services
// links:
//  client controller layer: https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/controllers-and-routing/aspnet-mvc-controllers-overview-cs
//  docLink: http://sql2x.org/documentationLink/4fbcc19b-c130-4190-b31b-e28bc3aaf29f
namespace SolutionNorSolutionPim.AspMvc.Controllers {
    // ProductInfo Controller
    // the ProductInfo Controller contains pages for adding, editing and listing ProductInfo's
    // links:
    //  client controller layer: https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/controllers-and-routing/aspnet-mvc-controllers-overview-cs
    //  docLink: http://sql2x.org/documentationLink/1d284965-6123-4b40-9d9b-e5f19f1e50c2
    public class ProductInfoController : Controller {

        // Index page
        // Index page grid shows all displayable columns and includes methods for adding new, editing and deleting rows
        // links:
        //  Adding a view: https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/adding-a-view
        //  docLink: http://sql2x.org/documentationLink/0b59e863-a1c1-4fc9-ab6e-ad60cbcc6a78
        [HttpGet]
        public ActionResult ProductInfoIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductInfo/ProductInfoIndex.cshtml",
                new ProductMaintenanceSearchService().ProductMaintenanceInfoIndexWithFilter(productId)
                );
        }

        // Edit page GET
        // Edit page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/6da14593-42b2-455c-a2f4-45de6bcf8ab2
        [HttpGet]
        public ActionResult ProductInfoEdit(
            System.Guid productInfoId
            ) {

            ViewBag.ProductInfoId = productInfoId;

            var productInfoContract = new ProductInfoContract();

            productInfoContract.ProductInfo =
                new CrudeProductInfoServiceClient().FetchByProductInfoId(productInfoId);

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productInfoContract.ProductInfo.ProductId
                                );

            ViewBag.ProductInfoRcd =
                new SelectList( new CrudeProductInfoRefServiceClient().FetchAll(),
                                "ProductInfoRcd",
                                "ProductInfoName",
                                productInfoContract.ProductInfo.ProductInfoRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productInfoContract.ProductInfo.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductInfo/ProductInfoEdit.cshtml",
                productInfoContract
                );
        }

        // Edit page POST
        // Edit page POST saves all displayable columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/28c3318f-58bb-471e-b8e4-1a72faccf2ee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductInfoEdit([Bind()] ProductInfoContract productInfoContract, System.Guid productId,System.String productInfoRcd) {
            if (ModelState.IsValid) {

                productInfoContract.ProductInfo.ProductId = productId;
                productInfoContract.ProductInfo.ProductInfoRcd = productInfoRcd;
                productInfoContract.ProductInfo.DateTime = DateTime.UtcNow;

                new CrudeProductInfoServiceClient().Update(productInfoContract.ProductInfo);

                return RedirectToAction("ProductInfoIndex", new { productId = productInfoContract.ProductInfo.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductInfo/ProductInfoEdit.cshtml",
                productInfoContract
                );
        }

        // Create page GET
        // Create page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/60c74316-26b9-494c-aee6-47941df0f62f
        [HttpGet]
        public ActionResult ProductInfoCreate(System.Guid? productId, System.Guid? userId) {
            var productInfoContract = new ProductInfoContract();
            productInfoContract.ProductInfo = new CrudeProductInfoContract();
            if (productId != null) productInfoContract.ProductInfo.ProductId = (System.Guid) productId;
            if (userId != null) productInfoContract.ProductInfo.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productInfoContract.ProductInfo.ProductId
                                );

            ViewBag.ProductInfoRcd =
                new SelectList( new CrudeProductInfoRefServiceClient().FetchAll(),
                                "ProductInfoRcd",
                                "ProductInfoName",
                                productInfoContract.ProductInfo.ProductInfoRcd
                                );

            if (userId == null)
                productInfoContract.ProductInfo.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productInfoContract.ProductInfo.UserId).DefaultUserName;

            productInfoContract.ProductInfo.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/ProductMaintenance/ProductInfo/ProductInfoCreate.cshtml",
                productInfoContract
                );
        }

        // Create page POST
        // Create page POST fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/285009e7-641a-427d-866c-552a860daa7d
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductInfoCreate([Bind()] ProductInfoContract productInfoContract, System.Guid productId,System.String productInfoRcd) {
            if (ModelState.IsValid) {

                productInfoContract.ProductInfo.ProductId = productId;
                productInfoContract.ProductInfo.ProductInfoRcd = productInfoRcd;
                new CrudeProductInfoServiceClient().Insert(productInfoContract.ProductInfo);

                return RedirectToAction("ProductInfoIndex", new { productId = productInfoContract.ProductInfo.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductInfo/ProductInfoCreate.cshtml",
                productInfoContract
                );
        }

    }
}
