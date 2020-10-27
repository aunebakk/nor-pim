/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/27/2020 8:22:06 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.AspMvc.Controllers {

    // controller class for mvc
    public class CrudeProductCategoryDocumentationController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationIndex.cshtml",
                new CrudeProductCategoryDocumentationServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationByProductCategoryIndex(System.Guid productCategoryId) {
            ViewBag.ProductCategoryId = productCategoryId;

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationIndex.cshtml",
                new CrudeProductCategoryDocumentationServiceClient().FetchByProductCategoryId(productCategoryId)
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationDetails(System.Guid productCategoryDocumentationId) {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationDetails.cshtml",
                new CrudeProductCategoryDocumentationServiceClient().FetchByProductCategoryDocumentationId(productCategoryDocumentationId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationEdit(
            System.Guid productCategoryDocumentationId
            ) {

            CrudeProductCategoryDocumentationContract contract = new CrudeProductCategoryDocumentationServiceClient().FetchByProductCategoryDocumentationId(productCategoryDocumentationId);
            ViewBag.ProductCategoryDocumentationTypeRcd =
                new SelectList( new CrudeProductCategoryDocumentationTypeRefServiceClient().FetchAll(),
                                "ProductCategoryDocumentationTypeRcd",
                                "ProductCategoryDocumentationTypeName",
                                contract.ProductCategoryDocumentationTypeRcd
                                );

            ViewBag.ProductCategoryId =
                new SelectList( new CrudeProductCategoryServiceClient().FetchAll(),
                                "ProductCategoryId",
                                "ProductCategoryName",
                                contract.ProductCategoryId
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryDocumentationEdit([Bind()] CrudeProductCategoryDocumentationContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductCategoryDocumentationServiceClient().Update(contract);

                return RedirectToAction("CrudeProductCategoryDocumentationIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationCreate(System.Guid? productCategoryId, System.Guid? userId) {
            var contract = new CrudeProductCategoryDocumentationContract();
            if (productCategoryId != null) contract.ProductCategoryId = (System.Guid) productCategoryId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductCategoryDocumentationTypeRcd =
                new SelectList( new CrudeProductCategoryDocumentationTypeRefServiceClient().FetchAll(),
                                "ProductCategoryDocumentationTypeRcd",
                                "ProductCategoryDocumentationTypeName",
                                contract.ProductCategoryDocumentationTypeRcd
                                );

            ViewBag.ProductCategoryId =
                new SelectList( new CrudeProductCategoryServiceClient().FetchAll(),
                                "ProductCategoryId",
                                "ProductCategoryName",
                                contract.ProductCategoryId
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryDocumentationCreate([Bind()] CrudeProductCategoryDocumentationContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductCategoryDocumentationServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductCategoryDocumentationIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationDelete(
            System.Guid productCategoryDocumentationId
            ) {
            new CrudeProductCategoryDocumentationServiceClient().Delete(productCategoryDocumentationId);

            return RedirectToAction("CrudeProductCategoryDocumentationIndex");
        }
    }
}
