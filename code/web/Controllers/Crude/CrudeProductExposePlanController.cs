using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductExposePlanController : Controller {

        [HttpGet]
        public ActionResult CrudeProductExposePlanIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposePlan", "CrudeProductExposePlanIndex"),
                new CrudeProductExposePlanService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposePlanDetails(System.Guid productExposePlanId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposePlan", "CrudeProductExposePlanDetails"),
                new CrudeProductExposePlanService().FetchByProductExposePlanId(productExposePlanId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposePlanEdit(System.Guid productExposePlanId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposePlan", "CrudeProductExposePlanEdit"),
                new CrudeProductExposePlanService().FetchByProductExposePlanId(productExposePlanId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposePlanEdit([Bind()] CrudeProductExposePlanContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductExposePlanService().Update(contract);

                return RedirectToAction("CrudeProductExposePlanIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposePlan", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposePlanCreate() {
            var contract = new CrudeProductExposePlanContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposePlan", "CrudeProductExposePlanCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposePlanCreate([Bind()] CrudeProductExposePlanContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductExposePlanService().Insert(contract);

                return RedirectToAction("CrudeProductExposePlanIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposePlan", "CrudeProductExposePlanCreate"),
                contract
                );
        }
    }
}
