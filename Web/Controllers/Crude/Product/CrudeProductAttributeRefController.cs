/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:59:13 AM
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
    public class CrudeProductAttributeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductAttributeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeRef/CrudeProductAttributeRefIndex.cshtml",
                new CrudeProductAttributeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductAttributeRefDetails(System.String productAttributeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeRef/CrudeProductAttributeRefDetails.cshtml",
                new CrudeProductAttributeRefServiceClient().FetchByProductAttributeRcd(productAttributeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductAttributeRefEdit(
            System.String productAttributeRcd
            ) {

            CrudeProductAttributeRefContract contract = new CrudeProductAttributeRefServiceClient().FetchByProductAttributeRcd(productAttributeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeRef/CrudeProductAttributeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeRefEdit([Bind()] CrudeProductAttributeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductAttributeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductAttributeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeRef/CrudeProductAttributeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductAttributeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductAttributeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductAttributeRef/CrudeProductAttributeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeRefCreate([Bind()] CrudeProductAttributeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductAttributeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductAttributeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductAttributeRef/CrudeProductAttributeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductAttributeRefDelete(
            System.String productAttributeRcd
            ) {
            new CrudeProductAttributeRefServiceClient().Delete(productAttributeRcd);

            return RedirectToAction("CrudeProductAttributeRefIndex");
        }
    }
}
