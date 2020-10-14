/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 2:46:53 PM
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
    public class CrudeProductAttributeUnitRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductAttributeUnitRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefIndex.cshtml",
                new CrudeProductAttributeUnitRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductAttributeUnitRefDetails(System.String productAttributeUnitRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefDetails.cshtml",
                new CrudeProductAttributeUnitRefServiceClient().FetchByProductAttributeUnitRcd(productAttributeUnitRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductAttributeUnitRefEdit(
            System.String productAttributeUnitRcd
            ) {

            CrudeProductAttributeUnitRefContract contract = new CrudeProductAttributeUnitRefServiceClient().FetchByProductAttributeUnitRcd(productAttributeUnitRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeUnitRefEdit([Bind()] CrudeProductAttributeUnitRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductAttributeUnitRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductAttributeUnitRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductAttributeUnitRefCreate(System.Guid? userId) {
            var contract = new CrudeProductAttributeUnitRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeUnitRefCreate([Bind()] CrudeProductAttributeUnitRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductAttributeUnitRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductAttributeUnitRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductAttributeUnitRefDelete(
            System.String productAttributeUnitRcd
            ) {
            new CrudeProductAttributeUnitRefServiceClient().Delete(productAttributeUnitRcd);

            return RedirectToAction("CrudeProductAttributeUnitRefIndex");
        }
    }
}
