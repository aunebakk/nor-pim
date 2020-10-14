/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 5:49:34 PM
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
    public class CrudeProductExposeSetController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductExposeSetIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSet/CrudeProductExposeSetIndex.cshtml",
                new CrudeProductExposeSetServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductExposeSetDetails(System.Guid productExposeSetId) {

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSet/CrudeProductExposeSetDetails.cshtml",
                new CrudeProductExposeSetServiceClient().FetchByProductExposeSetId(productExposeSetId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductExposeSetEdit(
            System.Guid productExposeSetId
            ) {

            CrudeProductExposeSetContract contract = new CrudeProductExposeSetServiceClient().FetchByProductExposeSetId(productExposeSetId);
            ViewBag.ProductExposeSetTypeRcd =
                new SelectList( new CrudeProductExposeSetTypeRefServiceClient().FetchAll(),
                                "ProductExposeSetTypeRcd",
                                "ProductExposeSetTypeName",
                                contract.ProductExposeSetTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductExposeSet/CrudeProductExposeSetEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeSetEdit([Bind()] CrudeProductExposeSetContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductExposeSetServiceClient().Update(contract);

                return RedirectToAction("CrudeProductExposeSetIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSet/CrudeProductExposeSetEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductExposeSetCreate(System.Guid? userId) {
            var contract = new CrudeProductExposeSetContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.ProductExposeSetTypeRcd =
                new SelectList( new CrudeProductExposeSetTypeRefServiceClient().FetchAll(),
                                "ProductExposeSetTypeRcd",
                                "ProductExposeSetTypeName",
                                contract.ProductExposeSetTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductExposeSet/CrudeProductExposeSetCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeSetCreate([Bind()] CrudeProductExposeSetContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductExposeSetServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductExposeSetIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductExposeSet/CrudeProductExposeSetCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductExposeSetDelete(
            System.Guid productExposeSetId
            ) {
            new CrudeProductExposeSetServiceClient().Delete(productExposeSetId);

            return RedirectToAction("CrudeProductExposeSetIndex");
        }
    }
}
