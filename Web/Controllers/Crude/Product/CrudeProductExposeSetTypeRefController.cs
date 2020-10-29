/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:46:06 PM
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
    public class CrudeProductExposeSetTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductExposeSetTypeRefIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefIndex.cshtml",
                new CrudeProductExposeSetTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductExposeSetTypeRefDetails(System.String productExposeSetTypeRcd) {

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefDetails.cshtml",
                new CrudeProductExposeSetTypeRefServiceClient().FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductExposeSetTypeRefEdit(
            System.String productExposeSetTypeRcd
            ) {

            CrudeProductExposeSetTypeRefContract contract = new CrudeProductExposeSetTypeRefServiceClient().FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd);

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeSetTypeRefEdit([Bind()] CrudeProductExposeSetTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeProductExposeSetTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeProductExposeSetTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductExposeSetTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeProductExposeSetTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeSetTypeRefCreate([Bind()] CrudeProductExposeSetTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductExposeSetTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductExposeSetTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductExposeSetTypeRefDelete(
            System.String productExposeSetTypeRcd
            ) {
            new CrudeProductExposeSetTypeRefServiceClient().Delete(productExposeSetTypeRcd);

            return RedirectToAction("CrudeProductExposeSetTypeRefIndex");
        }
    }
}
