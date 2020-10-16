/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 5:54:44 PM
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
    public class CrudeProductInfoRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductInfoRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductInfoRef/CrudeProductInfoRefIndex.cshtml",
                new CrudeProductInfoRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductInfoRefDetails(string productInfoRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductInfoRef/CrudeProductInfoRefDetails.cshtml",
                new CrudeProductInfoRefServiceClient().FetchByProductInfoRcd(productInfoRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductInfoRefEdit(
            string productInfoRcd
            ) {

            CrudeProductInfoRefContract contract = new CrudeProductInfoRefServiceClient().FetchByProductInfoRcd(productInfoRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductInfoRef/CrudeProductInfoRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductInfoRefEdit([Bind()] CrudeProductInfoRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductInfoRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductInfoRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductInfoRef/CrudeProductInfoRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductInfoRefCreate(System.Guid? userId) {
            CrudeProductInfoRefContract contract = new CrudeProductInfoRefContract();
            if (userId != null) {
                contract.UserId = (System.Guid)userId;
            }

            if (userId == null) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
            }

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductInfoRef/CrudeProductInfoRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductInfoRefCreate([Bind()] CrudeProductInfoRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductInfoRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductInfoRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductInfoRef/CrudeProductInfoRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductInfoRefDelete(
            string productInfoRcd
            ) {
            new CrudeProductInfoRefServiceClient().Delete(productInfoRcd);

            return RedirectToAction("CrudeProductInfoRefIndex");
        }
    }
}
