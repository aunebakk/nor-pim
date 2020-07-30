/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/30/2020 6:41:20 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultSystemSettingController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSetting/CrudeDefaultSystemSettingIndex.cshtml",
                new CrudeDefaultSystemSettingServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingDetails(System.Guid defaultSystemSettingId) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSetting/CrudeDefaultSystemSettingDetails.cshtml",
                new CrudeDefaultSystemSettingServiceClient().FetchByDefaultSystemSettingId(defaultSystemSettingId)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingDelete(
            System.Guid defaultSystemSettingId
            ) {
            new CrudeDefaultSystemSettingServiceClient().Delete(defaultSystemSettingId);

            return RedirectToAction("CrudeDefaultSystemSettingIndex");
        }
    }
}
