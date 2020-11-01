/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 5:02:30 PM
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
    public class CrudeProductDocumentationTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductDocumentationTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefIndex.cshtml",
                new CrudeProductDocumentationTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductDocumentationTypeRefDetails(System.String productDocumentationTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefDetails.cshtml",
                new CrudeProductDocumentationTypeRefServiceClient().FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductDocumentationTypeRefEdit(
            System.String productDocumentationTypeRcd
            ) {

            CrudeProductDocumentationTypeRefContract contract = new CrudeProductDocumentationTypeRefServiceClient().FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductDocumentationTypeRefEdit([Bind()] CrudeProductDocumentationTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductDocumentationTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductDocumentationTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductDocumentationTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductDocumentationTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductDocumentationTypeRefCreate([Bind()] CrudeProductDocumentationTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductDocumentationTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductDocumentationTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductDocumentationTypeRefDelete(
            System.String productDocumentationTypeRcd
            ) {
            new CrudeProductDocumentationTypeRefServiceClient().Delete(productDocumentationTypeRcd);

            return RedirectToAction("CrudeProductDocumentationTypeRefIndex");
        }
    }
}
