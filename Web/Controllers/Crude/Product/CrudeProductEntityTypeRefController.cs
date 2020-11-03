/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:04:01 AM
  From Machine: DESKTOP-9A2DH39
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
    public class CrudeProductEntityTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductEntityTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefIndex.cshtml",
                new CrudeProductEntityTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductEntityTypeRefDetails(System.String productEntityTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefDetails.cshtml",
                new CrudeProductEntityTypeRefServiceClient().FetchByProductEntityTypeRcd(productEntityTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductEntityTypeRefEdit(
            System.String productEntityTypeRcd
            ) {

            CrudeProductEntityTypeRefContract contract = new CrudeProductEntityTypeRefServiceClient().FetchByProductEntityTypeRcd(productEntityTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductEntityTypeRefEdit([Bind()] CrudeProductEntityTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductEntityTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductEntityTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductEntityTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductEntityTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductEntityTypeRefCreate([Bind()] CrudeProductEntityTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductEntityTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductEntityTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductEntityTypeRefDelete(
            System.String productEntityTypeRcd
            ) {
            new CrudeProductEntityTypeRefServiceClient().Delete(productEntityTypeRcd);

            return RedirectToAction("CrudeProductEntityTypeRefIndex");
        }
    }
}
