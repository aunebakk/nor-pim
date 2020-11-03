/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:48:38 AM
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
    public class CrudeDefaultUserActivityTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultUserActivityTypeRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefIndex.cshtml",
                new CrudeDefaultUserActivityTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultUserActivityTypeRefDetails(System.String defaultUserActivityTypeRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefDetails.cshtml",
                new CrudeDefaultUserActivityTypeRefServiceClient().FetchByDefaultUserActivityTypeRcd(defaultUserActivityTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultUserActivityTypeRefEdit(
            System.String defaultUserActivityTypeRcd
            ) {

            CrudeDefaultUserActivityTypeRefContract contract = new CrudeDefaultUserActivityTypeRefServiceClient().FetchByDefaultUserActivityTypeRcd(defaultUserActivityTypeRcd);

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultUserActivityTypeRefEdit([Bind()] CrudeDefaultUserActivityTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeDefaultUserActivityTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultUserActivityTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultUserActivityTypeRefCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultUserActivityTypeRefContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultUserActivityTypeRefCreate([Bind()] CrudeDefaultUserActivityTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultUserActivityTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultUserActivityTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultUserActivityTypeRefDelete(
            System.String defaultUserActivityTypeRcd
            ) {
            new CrudeDefaultUserActivityTypeRefServiceClient().Delete(defaultUserActivityTypeRcd);

            return RedirectToAction("CrudeDefaultUserActivityTypeRefIndex");
        }
    }
}
