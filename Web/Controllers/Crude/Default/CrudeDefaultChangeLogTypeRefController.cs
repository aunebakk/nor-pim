/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 6:12:34 AM
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
    public class CrudeDefaultChangeLogTypeRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultChangeLogTypeRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLogTypeRef/CrudeDefaultChangeLogTypeRefIndex.cshtml",
                new CrudeDefaultChangeLogTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultChangeLogTypeRefDetails(System.String defaultChangeLogTypeRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLogTypeRef/CrudeDefaultChangeLogTypeRefDetails.cshtml",
                new CrudeDefaultChangeLogTypeRefServiceClient().FetchByDefaultChangeLogTypeRcd(defaultChangeLogTypeRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultChangeLogTypeRefEdit(
            System.String defaultChangeLogTypeRcd
            ) {

            CrudeDefaultChangeLogTypeRefContract contract = new CrudeDefaultChangeLogTypeRefServiceClient().FetchByDefaultChangeLogTypeRcd(defaultChangeLogTypeRcd);

            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLogTypeRef/CrudeDefaultChangeLogTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultChangeLogTypeRefEdit([Bind()] CrudeDefaultChangeLogTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeDefaultChangeLogTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultChangeLogTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLogTypeRef/CrudeDefaultChangeLogTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultChangeLogTypeRefCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultChangeLogTypeRefContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLogTypeRef/CrudeDefaultChangeLogTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultChangeLogTypeRefCreate([Bind()] CrudeDefaultChangeLogTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultChangeLogTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultChangeLogTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultChangeLogTypeRef/CrudeDefaultChangeLogTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultChangeLogTypeRefDelete(
            System.String defaultChangeLogTypeRcd
            ) {
            new CrudeDefaultChangeLogTypeRefServiceClient().Delete(defaultChangeLogTypeRcd);

            return RedirectToAction("CrudeDefaultChangeLogTypeRefIndex");
        }
    }
}
