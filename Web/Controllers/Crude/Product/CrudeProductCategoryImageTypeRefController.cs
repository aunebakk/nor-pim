/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 6:16:28 PM
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
    public class CrudeProductCategoryImageTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductCategoryImageTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefIndex.cshtml",
                new CrudeProductCategoryImageTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductCategoryImageTypeRefDetails(System.String productCategoryImageTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefDetails.cshtml",
                new CrudeProductCategoryImageTypeRefServiceClient().FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductCategoryImageTypeRefEdit(
            System.String productCategoryImageTypeRcd
            ) {

            CrudeProductCategoryImageTypeRefContract contract = new CrudeProductCategoryImageTypeRefServiceClient().FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryImageTypeRefEdit([Bind()] CrudeProductCategoryImageTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductCategoryImageTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductCategoryImageTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductCategoryImageTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductCategoryImageTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryImageTypeRefCreate([Bind()] CrudeProductCategoryImageTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductCategoryImageTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductCategoryImageTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductCategoryImageTypeRefDelete(
            System.String productCategoryImageTypeRcd
            ) {
            new CrudeProductCategoryImageTypeRefServiceClient().Delete(productCategoryImageTypeRcd);

            return RedirectToAction("CrudeProductCategoryImageTypeRefIndex");
        }
    }
}
