/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:54:07 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateWithDurianGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client ASP Controller
// the Client ASP Controller Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/4fbcc19b-c130-4190-b31b-e28bc3aaf29f
namespace SolutionNorSolutionPim.AspMvc.Controllers {
    // ProductAttribute Controller
    // the ProductAttribute Controller contains pages for adding, editing and listing ProductAttribute's
    // links:
    //  docLink: http://sql2x.org/documentationLink/1d284965-6123-4b40-9d9b-e5f19f1e50c2
    public class ProductAttributeController : Controller {

        // Index page
        // Index page grid shows all displayable columns and includes methods for adding new, editing and deleting rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b59e863-a1c1-4fc9-ab6e-ad60cbcc6a78
        [HttpGet]
        public ActionResult ProductAttributeIndex(System.Guid productId) {
            ViewBag.ProductId = productId;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductAttribute/ProductAttributeIndex.cshtml",
                new ProductMaintenanceSearchServiceClient().ProductMaintenanceAttributeIndexWithFilter(productId)
                );
        }

        // Edit page GET
        // Edit page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/6da14593-42b2-455c-a2f4-45de6bcf8ab2
        [HttpGet]
        public ActionResult ProductAttributeEdit(
            System.Guid productAttributeId
            ) {

            ViewBag.ProductAttributeId = productAttributeId;

            var productAttributeContract = new ProductAttributeContract();

            productAttributeContract.ProductAttribute =
                new CrudeProductAttributeServiceClient().FetchByProductAttributeId(productAttributeId);

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productAttributeContract.ProductAttribute.ProductId
                                );

            ViewBag.ProductAttributeRcd =
                new SelectList( new CrudeProductAttributeRefServiceClient().FetchAll(),
                                "ProductAttributeRcd",
                                "ProductAttributeName",
                                productAttributeContract.ProductAttribute.ProductAttributeRcd
                                );

            ViewBag.ProductAttributeUnitRcd =
                new SelectList( new CrudeProductAttributeUnitRefServiceClient().FetchAll(),
                                "ProductAttributeUnitRcd",
                                "ProductAttributeUnitName",
                                productAttributeContract.ProductAttribute.ProductAttributeUnitRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productAttributeContract.ProductAttribute.UserId).DefaultUserName;

            return View(
                "~/Views/Templates/ProductMaintenance/ProductAttribute/ProductAttributeEdit.cshtml",
                productAttributeContract
                );
        }

        // Edit page POST
        // Edit page POST saves all displayable columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/28c3318f-58bb-471e-b8e4-1a72faccf2ee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductAttributeEdit([Bind()] ProductAttributeContract productAttributeContract, System.Guid productId,System.String productAttributeRcd,System.String productAttributeUnitRcd) {
            if (ModelState.IsValid) {

                productAttributeContract.ProductAttribute.ProductId = productId;
                productAttributeContract.ProductAttribute.ProductAttributeRcd = productAttributeRcd;
                productAttributeContract.ProductAttribute.ProductAttributeUnitRcd = productAttributeUnitRcd;
                productAttributeContract.ProductAttribute.DateTime = DateTime.UtcNow;

                new CrudeProductAttributeServiceClient().Update(productAttributeContract.ProductAttribute);

                return RedirectToAction("ProductAttributeIndex", new { productId = productAttributeContract.ProductAttribute.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductAttribute/ProductAttributeEdit.cshtml",
                productAttributeContract
                );
        }

        // Create page GET
        // Create page GET fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/60c74316-26b9-494c-aee6-47941df0f62f
        [HttpGet]
        public ActionResult ProductAttributeCreate(System.Guid? productId, System.Guid? userId) {
            var productAttributeContract = new ProductAttributeContract();
            productAttributeContract.ProductAttribute = new CrudeProductAttributeContract();
            if (productId != null) productAttributeContract.ProductAttribute.ProductId = (System.Guid) productId;
            if (userId != null) productAttributeContract.ProductAttribute.UserId = (System.Guid) userId;

            ViewBag.ProductId =
                new SelectList( new CrudeProductServiceClient().FetchAll(),
                                "ProductId",
                                "ProductName",
                                productAttributeContract.ProductAttribute.ProductId
                                );

            ViewBag.ProductAttributeRcd =
                new SelectList( new CrudeProductAttributeRefServiceClient().FetchAll(),
                                "ProductAttributeRcd",
                                "ProductAttributeName",
                                productAttributeContract.ProductAttribute.ProductAttributeRcd
                                );

            ViewBag.ProductAttributeUnitRcd =
                new SelectList( new CrudeProductAttributeUnitRefServiceClient().FetchAll(),
                                "ProductAttributeUnitRcd",
                                "ProductAttributeUnitName",
                                productAttributeContract.ProductAttribute.ProductAttributeUnitRcd
                                );

            if (userId == null)
                productAttributeContract.ProductAttribute.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(productAttributeContract.ProductAttribute.UserId).DefaultUserName;

            productAttributeContract.ProductAttribute.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Templates/ProductMaintenance/ProductAttribute/ProductAttributeCreate.cshtml",
                productAttributeContract
                );
        }

        // Create page POST
        // Create page POST fetches all displayable columns for editing in a view
        // links:
        //  docLink: http://sql2x.org/documentationLink/285009e7-641a-427d-866c-552a860daa7d
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductAttributeCreate([Bind()] ProductAttributeContract productAttributeContract, System.Guid productId,System.String productAttributeRcd,System.String productAttributeUnitRcd) {
            if (ModelState.IsValid) {

                productAttributeContract.ProductAttribute.ProductId = productId;
                productAttributeContract.ProductAttribute.ProductAttributeRcd = productAttributeRcd;
                productAttributeContract.ProductAttribute.ProductAttributeUnitRcd = productAttributeUnitRcd;
                new CrudeProductAttributeServiceClient().Insert(productAttributeContract.ProductAttribute);

                return RedirectToAction("ProductAttributeIndex", new { productId = productAttributeContract.ProductAttribute.ProductId} );
            }

            return View(
                "~/Views/Templates/ProductMaintenance/ProductAttribute/ProductAttributeCreate.cshtml",
                productAttributeContract
                );
        }

    }
}
