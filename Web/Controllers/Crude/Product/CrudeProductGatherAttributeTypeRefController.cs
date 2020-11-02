/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 8:06:19 PM
  From Machine: DESKTOP-517I8BU
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
    public class CrudeProductGatherAttributeTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductGatherAttributeTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefIndex.cshtml",
                new CrudeProductGatherAttributeTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductGatherAttributeTypeRefDetails(System.String productGatherAttributeTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefDetails.cshtml",
                new CrudeProductGatherAttributeTypeRefServiceClient().FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductGatherAttributeTypeRefEdit(
            System.String productGatherAttributeTypeRcd
            ) {

            CrudeProductGatherAttributeTypeRefContract contract = new CrudeProductGatherAttributeTypeRefServiceClient().FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherAttributeTypeRefEdit([Bind()] CrudeProductGatherAttributeTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductGatherAttributeTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductGatherAttributeTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductGatherAttributeTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductGatherAttributeTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherAttributeTypeRefCreate([Bind()] CrudeProductGatherAttributeTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductGatherAttributeTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductGatherAttributeTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductGatherAttributeTypeRefDelete(
            System.String productGatherAttributeTypeRcd
            ) {
            new CrudeProductGatherAttributeTypeRefServiceClient().Delete(productGatherAttributeTypeRcd);

            return RedirectToAction("CrudeProductGatherAttributeTypeRefIndex");
        }
    }
}
