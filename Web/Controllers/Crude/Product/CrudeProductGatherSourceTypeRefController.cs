/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 4:14:02 AM
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
    public class CrudeProductGatherSourceTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductGatherSourceTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefIndex.cshtml",
                new CrudeProductGatherSourceTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductGatherSourceTypeRefDetails(System.String productGatherSourceTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefDetails.cshtml",
                new CrudeProductGatherSourceTypeRefServiceClient().FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductGatherSourceTypeRefEdit(
            System.String productGatherSourceTypeRcd
            ) {

            CrudeProductGatherSourceTypeRefContract contract = new CrudeProductGatherSourceTypeRefServiceClient().FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherSourceTypeRefEdit([Bind()] CrudeProductGatherSourceTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductGatherSourceTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductGatherSourceTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductGatherSourceTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductGatherSourceTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherSourceTypeRefCreate([Bind()] CrudeProductGatherSourceTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductGatherSourceTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductGatherSourceTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductGatherSourceTypeRefDelete(
            System.String productGatherSourceTypeRcd
            ) {
            new CrudeProductGatherSourceTypeRefServiceClient().Delete(productGatherSourceTypeRcd);

            return RedirectToAction("CrudeProductGatherSourceTypeRefIndex");
        }
    }
}
