using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeUserActivityTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeUserActivityTypeRefIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUserActivityTypeRef", "CrudeUserActivityTypeRefIndex"),
                new CrudeUserActivityTypeRefService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeUserActivityTypeRefDetails(System.String userActivityTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUserActivityTypeRef", "CrudeUserActivityTypeRefDetails"),
                new CrudeUserActivityTypeRefService().FetchByUserActivityTypeRcd(userActivityTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeUserActivityTypeRefEdit(System.String userActivityTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUserActivityTypeRef", "CrudeUserActivityTypeRefEdit"),
                new CrudeUserActivityTypeRefService().FetchByUserActivityTypeRcd(userActivityTypeRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeUserActivityTypeRefEdit([Bind()] CrudeUserActivityTypeRefContract contract) {
            if (ModelState.IsValid) {
                new CrudeUserActivityTypeRefService().Update(contract);

                return RedirectToAction("CrudeUserActivityTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUserActivityTypeRef", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeUserActivityTypeRefCreate() {
            var contract = new CrudeUserActivityTypeRefContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUserActivityTypeRef", "CrudeUserActivityTypeRefCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeUserActivityTypeRefCreate([Bind()] CrudeUserActivityTypeRefContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeUserActivityTypeRefService().Insert(contract);

                return RedirectToAction("CrudeUserActivityTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUserActivityTypeRef", "CrudeUserActivityTypeRefCreate"),
                contract
                );
        }
    }
}
