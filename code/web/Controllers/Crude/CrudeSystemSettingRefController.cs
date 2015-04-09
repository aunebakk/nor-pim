using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeSystemSettingRefController : Controller {

        [HttpGet]
        public ActionResult CrudeSystemSettingRefIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemSettingRef", "CrudeSystemSettingRefIndex"),
                new CrudeSystemSettingRefService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeSystemSettingRefDetails(System.String systemSettingRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemSettingRef", "CrudeSystemSettingRefDetails"),
                new CrudeSystemSettingRefService().FetchBySystemSettingRcd(systemSettingRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeSystemSettingRefEdit(System.String systemSettingRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemSettingRef", "CrudeSystemSettingRefEdit"),
                new CrudeSystemSettingRefService().FetchBySystemSettingRcd(systemSettingRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeSystemSettingRefEdit([Bind()] CrudeSystemSettingRefContract contract) {
            if (ModelState.IsValid) {
                new CrudeSystemSettingRefService().Update(contract);

                return RedirectToAction("CrudeSystemSettingRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemSettingRef", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeSystemSettingRefCreate() {
            var contract = new CrudeSystemSettingRefContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemSettingRef", "CrudeSystemSettingRefCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeSystemSettingRefCreate([Bind()] CrudeSystemSettingRefContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeSystemSettingRefService().Insert(contract);

                return RedirectToAction("CrudeSystemSettingRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemSettingRef", "CrudeSystemSettingRefCreate"),
                contract
                );
        }
    }
}
