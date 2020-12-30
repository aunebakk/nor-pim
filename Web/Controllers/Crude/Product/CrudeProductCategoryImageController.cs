/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:05:30 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  client winform layer: https://docs.microsoft.com/en-us/dotnet/framework/winforms/
//  docLink: http://sql2x.org/documentationLink/f4564569-78eb-4ce4-99f3-6ace286090c3
namespace SolutionNorSolutionPim.AspMvc.Controllers {

    // this class serves as Controller to the data access layer between c# and sql server
    //  primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with an to REST API Contract through the JSON string format
    //  this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  MVC ( Model View Controller): https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93controller
    //  REST ( REpresentational State Transfer ): https://en.wikipedia.org/wiki/REST
    //  JSON ( JavaScript Object Notation ): https://en.wikipedia.org/wiki/JSON
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeProductCategoryImageController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeProductCategoryImageIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageIndex.cshtml",
                new CrudeProductCategoryImageServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeProductCategoryImageByProductCategoryIndex(System.Guid productCategoryId) {
            ViewBag.ProductCategoryId = productCategoryId;

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageIndex.cshtml",
                new CrudeProductCategoryImageServiceClient().FetchByProductCategoryId(productCategoryId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeProductCategoryImageDetails(System.Guid productCategoryImageId) {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageDetails.cshtml",
                new CrudeProductCategoryImageServiceClient().FetchByProductCategoryImageId(productCategoryImageId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeProductCategoryImageEdit(
            System.Guid productCategoryImageId
            ) {

            CrudeProductCategoryImageContract contract = new CrudeProductCategoryImageServiceClient().FetchByProductCategoryImageId(productCategoryImageId);
            ViewBag.ProductCategoryId =
                new SelectList( new CrudeProductCategoryServiceClient().FetchAll(),
                                "ProductCategoryId",
                                "ProductCategoryName",
                                contract.ProductCategoryId
                                );

            ViewBag.ProductCategoryImageTypeRcd =
                new SelectList( new CrudeProductCategoryImageTypeRefServiceClient().FetchAll(),
                                "ProductCategoryImageTypeRcd",
                                "ProductCategoryImageTypeName",
                                contract.ProductCategoryImageTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryImageEdit([Bind()] CrudeProductCategoryImageContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductCategoryImageServiceClient().Update(contract);

                return RedirectToAction("CrudeProductCategoryImageIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeProductCategoryImageCreate(System.Guid? productCategoryId, System.Guid? userId) {
            var contract = new CrudeProductCategoryImageContract();
            if (productCategoryId != null) contract.ProductCategoryId = (System.Guid) productCategoryId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductCategoryId =
                new SelectList( new CrudeProductCategoryServiceClient().FetchAll(),
                                "ProductCategoryId",
                                "ProductCategoryName",
                                contract.ProductCategoryId
                                );

            ViewBag.ProductCategoryImageTypeRcd =
                new SelectList( new CrudeProductCategoryImageTypeRefServiceClient().FetchAll(),
                                "ProductCategoryImageTypeRcd",
                                "ProductCategoryImageTypeName",
                                contract.ProductCategoryImageTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryImageCreate([Bind()] CrudeProductCategoryImageContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductCategoryImageServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductCategoryImageIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImage/CrudeProductCategoryImageCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeProductCategoryImageDelete(
            System.Guid productCategoryImageId
            ) {
            new CrudeProductCategoryImageServiceClient().Delete(productCategoryImageId);

            return RedirectToAction("CrudeProductCategoryImageIndex");
        }
    }
}
