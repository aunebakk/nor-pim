/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 7:07:30 AM
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
    public class CrudeProductIdentifierRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductIdentifierRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductIdentifierRef/CrudeProductIdentifierRefIndex.cshtml",
                new CrudeProductIdentifierRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductIdentifierRefDetails(System.String productIdentifierRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductIdentifierRef/CrudeProductIdentifierRefDetails.cshtml",
                new CrudeProductIdentifierRefServiceClient().FetchByProductIdentifierRcd(productIdentifierRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductIdentifierRefEdit(
            System.String productIdentifierRcd
            ) {

            CrudeProductIdentifierRefContract contract = new CrudeProductIdentifierRefServiceClient().FetchByProductIdentifierRcd(productIdentifierRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductIdentifierRef/CrudeProductIdentifierRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductIdentifierRefEdit([Bind()] CrudeProductIdentifierRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductIdentifierRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductIdentifierRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductIdentifierRef/CrudeProductIdentifierRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductIdentifierRefCreate(System.Guid? userId) {
            var contract = new CrudeProductIdentifierRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductIdentifierRef/CrudeProductIdentifierRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductIdentifierRefCreate([Bind()] CrudeProductIdentifierRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductIdentifierRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductIdentifierRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductIdentifierRef/CrudeProductIdentifierRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductIdentifierRefDelete(
            System.String productIdentifierRcd
            ) {
            new CrudeProductIdentifierRefServiceClient().Delete(productIdentifierRcd);

            return RedirectToAction("CrudeProductIdentifierRefIndex");
        }
    }
}
