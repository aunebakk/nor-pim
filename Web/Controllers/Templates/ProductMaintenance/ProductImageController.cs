/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:15:56 PM
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
    // ProductImage Controller
    // the ProductImage Controller contains pages for adding, editing and listing ProductImage's
    // links:
    //  client controller layer: https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/controllers-and-routing/aspnet-mvc-controllers-overview-cs
    //  docLink: http://sql2x.org/documentationLink/1d284965-6123-4b40-9d9b-e5f19f1e50c2
    public class ProductImageController : Controller {

        // Index page
        // Index page grid shows all displayable columns and includes methods for adding new, editing and deleting rows
        // links:
        //  Adding a view: https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/adding-a-view
        //  docLink: http://sql2x.org/documentationLink/0b59e863-a1c1-4fc9-ab6e-ad60cbcc6a78
        [HttpGet]
        public ActionResult ProductImageIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductImage/ProductImageIndex.cshtml",
                new ProductMaintenanceSearchService().ProductMaintenanceImageIndexWithFilter(productId)
                );
        }

        // Edit page GET
        // Edit page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/6da14593-42b2-455c-a2f4-45de6bcf8ab2
        [HttpGet]
        public ActionResult ProductImageEdit(
            System.Guid productImageId
            ) {

            ViewBag.ProductImageId = productImageId;

            var productImageContract = new ProductImageContract();

            productImageContract.ProductImage =
                new CrudeProductImageServiceClient().FetchByProductImageId(productImageId);

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productImageContract.ProductImage.ProductId
                                );

            ViewBag.ProductImageTypeRcd =
                new SelectList( new CrudeProductImageTypeRefServiceClient().FetchAll(),
                                "ProductImageTypeRcd",
                                "ProductImageTypeName",
                                productImageContract.ProductImage.ProductImageTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productImageContract.ProductImage.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductImage/ProductImageEdit.cshtml",
                productImageContract
                );
        }

        // Edit page POST
        // Edit page POST saves all displayable columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/28c3318f-58bb-471e-b8e4-1a72faccf2ee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductImageEdit([Bind()] ProductImageContract productImageContract, System.Guid productId,System.String productImageTypeRcd) {
            if (ModelState.IsValid) {

                productImageContract.ProductImage.ProductId = productId;
                productImageContract.ProductImage.ProductImageTypeRcd = productImageTypeRcd;
                productImageContract.ProductImage.DateTime = DateTime.UtcNow;

                new CrudeProductImageServiceClient().Update(productImageContract.ProductImage);

                return RedirectToAction("ProductImageIndex", new { productId = productImageContract.ProductImage.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductImage/ProductImageEdit.cshtml",
                productImageContract
                );
        }

        // Create page GET
        // Create page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/60c74316-26b9-494c-aee6-47941df0f62f
        [HttpGet]
        public ActionResult ProductImageCreate(System.Guid? productId, System.Guid? userId) {
            var productImageContract = new ProductImageContract();
            productImageContract.ProductImage = new CrudeProductImageContract();
            if (productId != null) productImageContract.ProductImage.ProductId = (System.Guid) productId;
            if (userId != null) productImageContract.ProductImage.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productImageContract.ProductImage.ProductId
                                );

            ViewBag.ProductImageTypeRcd =
                new SelectList( new CrudeProductImageTypeRefServiceClient().FetchAll(),
                                "ProductImageTypeRcd",
                                "ProductImageTypeName",
                                productImageContract.ProductImage.ProductImageTypeRcd
                                );

            if (userId == null)
                productImageContract.ProductImage.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productImageContract.ProductImage.UserId).DefaultUserName;

            productImageContract.ProductImage.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/ProductMaintenance/ProductImage/ProductImageCreate.cshtml",
                productImageContract
                );
        }

        // Create page POST
        // Create page POST fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/285009e7-641a-427d-866c-552a860daa7d
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductImageCreate([Bind()] ProductImageContract productImageContract, System.Guid productId,System.String productImageTypeRcd) {
            if (ModelState.IsValid) {

                productImageContract.ProductImage.ProductId = productId;
                productImageContract.ProductImage.ProductImageTypeRcd = productImageTypeRcd;
                new CrudeProductImageServiceClient().Insert(productImageContract.ProductImage);

                return RedirectToAction("ProductImageIndex", new { productId = productImageContract.ProductImage.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductImage/ProductImageCreate.cshtml",
                productImageContract
                );
        }

    }
}
