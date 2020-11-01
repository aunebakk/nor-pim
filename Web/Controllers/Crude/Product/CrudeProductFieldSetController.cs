/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 7:04:18 AM
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
    public class CrudeProductFieldSetController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeProductFieldSetIndex() {

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSet/CrudeProductFieldSetIndex.cshtml",
                new CrudeProductFieldSetServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeProductFieldSetDetails(System.Guid productFieldSetId) {

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSet/CrudeProductFieldSetDetails.cshtml",
                new CrudeProductFieldSetServiceClient().FetchByProductFieldSetId(productFieldSetId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeProductFieldSetEdit(
            System.Guid productFieldSetId
            ) {

            CrudeProductFieldSetContract contract = new CrudeProductFieldSetServiceClient().FetchByProductFieldSetId(productFieldSetId);
            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Product/CrudeProductFieldSet/CrudeProductFieldSetEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductFieldSetEdit([Bind()] CrudeProductFieldSetContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeProductFieldSetServiceClient().Update(contract);

                return RedirectToAction("CrudeProductFieldSetIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSet/CrudeProductFieldSetEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeProductFieldSetCreate(System.Guid? userId) {
            var contract = new CrudeProductFieldSetContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Product/CrudeProductFieldSet/CrudeProductFieldSetCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductFieldSetCreate([Bind()] CrudeProductFieldSetContract contract) {
            if (ModelState.IsValid) {

                new CrudeProductFieldSetServiceClient().Insert(contract);

                return RedirectToAction("CrudeProductFieldSetIndex");
            }

            return View(
                "~/Views/Crude/Product/CrudeProductFieldSet/CrudeProductFieldSetCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeProductFieldSetDelete(
            System.Guid productFieldSetId
            ) {
            new CrudeProductFieldSetServiceClient().Delete(productFieldSetId);

            return RedirectToAction("CrudeProductFieldSetIndex");
        }
    }
}
