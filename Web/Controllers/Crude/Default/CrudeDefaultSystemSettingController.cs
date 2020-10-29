/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:45:46 PM
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
    public class CrudeDefaultSystemSettingController : Controller {

        // index page for controller
        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSetting/CrudeDefaultSystemSettingIndex.cshtml",
                new CrudeDefaultSystemSettingServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingDetails(System.Guid defaultSystemSettingId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSetting/CrudeDefaultSystemSettingDetails.cshtml",
                new CrudeDefaultSystemSettingServiceClient().FetchByDefaultSystemSettingId(defaultSystemSettingId)
                );
        }

        // edit details page
        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingEdit(
            System.Guid defaultSystemSettingId
            ) {

            CrudeDefaultSystemSettingContract contract = new CrudeDefaultSystemSettingServiceClient().FetchByDefaultSystemSettingId(defaultSystemSettingId);
            ViewBag.DefaultSystemSettingRcd =
                new SelectList( new CrudeDefaultSystemSettingRefServiceClient().FetchAll(),
                                "DefaultSystemSettingRcd",
                                "DefaultSystemSettingName",
                                contract.DefaultSystemSettingRcd
                                );


            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSetting/CrudeDefaultSystemSettingEdit.cshtml",
                contract
                );
        }

        // save detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultSystemSettingEdit([Bind()] CrudeDefaultSystemSettingContract contract) {
            if (ModelState.IsValid) {
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeDefaultSystemSettingServiceClient().Update(contract);

                return RedirectToAction("CrudeDefaultSystemSettingIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSetting/CrudeDefaultSystemSettingEdit.cshtml",
                contract
                );
        }

        // add new entity page
        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingCreate(System.Guid? defaultUserId) {
            var contract = new CrudeDefaultSystemSettingContract();
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;

            ViewBag.DefaultSystemSettingRcd =
                new SelectList( new CrudeDefaultSystemSettingRefServiceClient().FetchAll(),
                                "DefaultSystemSettingRcd",
                                "DefaultSystemSettingName",
                                contract.DefaultSystemSettingRcd
                                );

            if (defaultUserId == null)
                contract.DefaultUserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSetting/CrudeDefaultSystemSettingCreate.cshtml",
                contract
                );
        }

        // add new detail page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeDefaultSystemSettingCreate([Bind()] CrudeDefaultSystemSettingContract contract) {
            if (ModelState.IsValid) {

                new CrudeDefaultSystemSettingServiceClient().Insert(contract);

                return RedirectToAction("CrudeDefaultSystemSettingIndex");
            }

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSetting/CrudeDefaultSystemSettingCreate.cshtml",
                contract
                );
        }

        // delete entity page
        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingDelete(
            System.Guid defaultSystemSettingId
            ) {
            new CrudeDefaultSystemSettingServiceClient().Delete(defaultSystemSettingId);

            return RedirectToAction("CrudeDefaultSystemSettingIndex");
        }
    }
}
