/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 12:42:15 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CrudeDefaultSystemSettingRefController : Controller {

        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingRefIndex() {

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefIndex.cshtml",
                new CrudeDefaultSystemSettingRefServiceClient().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingRefDetails(System.String defaultSystemSettingRcd) {

            return View(
                "~/Views/Crude/Default/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefDetails.cshtml",
                new CrudeDefaultSystemSettingRefServiceClient().FetchByDefaultSystemSettingRcd(defaultSystemSettingRcd)
                );
        }

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

        [HttpGet]
        public ActionResult CrudeDefaultSystemSettingRefDelete(
            System.String defaultSystemSettingRcd
            ) {
            new CrudeDefaultSystemSettingRefServiceClient().Delete(defaultSystemSettingRcd);

            return RedirectToAction("CrudeDefaultSystemSettingRefIndex");
        }
    }
}
