using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeUserActivityController : Controller {

        [HttpGet]
        public ActionResult CrudeUserActivityIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUserActivity", "CrudeUserActivityIndex"),
                new CrudeUserActivityService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeUserActivityDetails(System.Guid userActivityId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUserActivity", "CrudeUserActivityDetails"),
                new CrudeUserActivityService().FetchByUserActivityId(userActivityId)
                );
        }

        [HttpGet]
        public ActionResult CrudeUserActivityEdit(System.Guid userActivityId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUserActivity", "CrudeUserActivityEdit"),
                new CrudeUserActivityService().FetchByUserActivityId(userActivityId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeUserActivityEdit([Bind()] CrudeUserActivityContract contract) {
            if (ModelState.IsValid) {
                new CrudeUserActivityService().Update(contract);

                return RedirectToAction("CrudeUserActivityIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUserActivity", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeUserActivityCreate() {
            var contract = new CrudeUserActivityContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUserActivity", "CrudeUserActivityCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeUserActivityCreate([Bind()] CrudeUserActivityContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeUserActivityService().Insert(contract);

                return RedirectToAction("CrudeUserActivityIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUserActivity", "CrudeUserActivityCreate"),
                contract
                );
        }
    }
}
