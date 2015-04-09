using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeSystemSettingController : Controller {

        [HttpGet]
        public ActionResult CrudeSystemSettingIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemSetting", "CrudeSystemSettingIndex"),
                new CrudeSystemSettingService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeSystemSettingDetails(System.Guid systemSettingId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemSetting", "CrudeSystemSettingDetails"),
                new CrudeSystemSettingService().FetchBySystemSettingId(systemSettingId)
                );
        }

        [HttpGet]
        public ActionResult CrudeSystemSettingEdit(System.Guid systemSettingId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemSetting", "CrudeSystemSettingEdit"),
                new CrudeSystemSettingService().FetchBySystemSettingId(systemSettingId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeSystemSettingEdit([Bind()] CrudeSystemSettingContract contract) {
            if (ModelState.IsValid) {
                new CrudeSystemSettingService().Update(contract);

                return RedirectToAction("CrudeSystemSettingIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemSetting", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeSystemSettingCreate() {
            var contract = new CrudeSystemSettingContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemSetting", "CrudeSystemSettingCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeSystemSettingCreate([Bind()] CrudeSystemSettingContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeSystemSettingService().Insert(contract);

                return RedirectToAction("CrudeSystemSettingIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemSetting", "CrudeSystemSettingCreate"),
                contract
                );
        }
    }
}
