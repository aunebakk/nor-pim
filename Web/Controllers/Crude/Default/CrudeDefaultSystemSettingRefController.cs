/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:10:18 PM
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
    public class CrudeDefaultSystemSettingRefController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefIndex.cshtml",
                new CrudeDefaultSystemSettingRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingRefDetails(System.String defaultSystemSettingRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefDetails.cshtml",
                new CrudeDefaultSystemSettingRefServiceClient().FetchByDefaultSystemSettingRcd(defaultSystemSettingRcd)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingRefEdit(
            System.String defaultSystemSettingRcd
            ) {

            CrudeDefaultSystemSettingRefContract contract = new CrudeDefaultSystemSettingRefServiceClient().FetchByDefaultSystemSettingRcd(defaultSystemSettingRcd);

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultSystemSettingRefEdit([Bind()] CrudeDefaultSystemSettingRefContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeDefaultSystemSettingRefServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultSystemSettingRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingRefCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultSystemSettingRefContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultSystemSettingRefCreate([Bind()] CrudeDefaultSystemSettingRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultSystemSettingRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultSystemSettingRefIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingRefDelete(
            System.String defaultSystemSettingRcd
            ) {
            new CrudeDefaultSystemSettingRefServiceClient().Delete(defaultSystemSettingRcd);

            return RedirectToAction("CrudeDefaultSystemSettingRefIndex");
        }
    }
}
