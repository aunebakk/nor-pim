/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 2:47:19 PM
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
    public class CrudeProductImageTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductImageTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductImageTypeRef/CrudeProductImageTypeRefIndex.cshtml",
                new CrudeProductImageTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductImageTypeRefDetails(System.String productImageTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductImageTypeRef/CrudeProductImageTypeRefDetails.cshtml",
                new CrudeProductImageTypeRefServiceClient().FetchByProductImageTypeRcd(productImageTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductImageTypeRefEdit(
            System.String productImageTypeRcd
            ) {

            CrudeProductImageTypeRefContract contract = new CrudeProductImageTypeRefServiceClient().FetchByProductImageTypeRcd(productImageTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductImageTypeRef/CrudeProductImageTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductImageTypeRefEdit([Bind()] CrudeProductImageTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductImageTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductImageTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductImageTypeRef/CrudeProductImageTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductImageTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductImageTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductImageTypeRef/CrudeProductImageTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductImageTypeRefCreate([Bind()] CrudeProductImageTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductImageTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductImageTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductImageTypeRef/CrudeProductImageTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductImageTypeRefDelete(
            System.String productImageTypeRcd
            ) {
            new CrudeProductImageTypeRefServiceClient().Delete(productImageTypeRcd);

            return RedirectToAction("CrudeProductImageTypeRefIndex");
        }
    }
}
