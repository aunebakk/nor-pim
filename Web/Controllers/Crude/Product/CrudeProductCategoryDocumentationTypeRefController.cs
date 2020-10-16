/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:59:17 AM
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
    public class CrudeProductCategoryDocumentationTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefIndex.cshtml",
                new CrudeProductCategoryDocumentationTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationTypeRefDetails(System.String productCategoryDocumentationTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefDetails.cshtml",
                new CrudeProductCategoryDocumentationTypeRefServiceClient().FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationTypeRefEdit(
            System.String productCategoryDocumentationTypeRcd
            ) {

            CrudeProductCategoryDocumentationTypeRefContract contract = new CrudeProductCategoryDocumentationTypeRefServiceClient().FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryDocumentationTypeRefEdit([Bind()] CrudeProductCategoryDocumentationTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductCategoryDocumentationTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductCategoryDocumentationTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductCategoryDocumentationTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryDocumentationTypeRefCreate([Bind()] CrudeProductCategoryDocumentationTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductCategoryDocumentationTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductCategoryDocumentationTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationTypeRefDelete(
            System.String productCategoryDocumentationTypeRcd
            ) {
            new CrudeProductCategoryDocumentationTypeRefServiceClient().Delete(productCategoryDocumentationTypeRcd);

            return RedirectToAction("CrudeProductCategoryDocumentationTypeRefIndex");
        }
    }
}
