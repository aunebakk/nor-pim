using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductGatherSourceController : Controller {

        [HttpGet]
        public ActionResult CrudeProductGatherSourceIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherSource", "CrudeProductGatherSourceIndex"),
                new CrudeProductGatherSourceService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherSourceDetails(System.Guid productGatherSourceId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherSource", "CrudeProductGatherSourceDetails"),
                new CrudeProductGatherSourceService().FetchByProductGatherSourceId(productGatherSourceId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherSourceEdit(System.Guid productGatherSourceId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherSource", "CrudeProductGatherSourceEdit"),
                new CrudeProductGatherSourceService().FetchByProductGatherSourceId(productGatherSourceId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherSourceEdit([Bind()] CrudeProductGatherSourceContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductGatherSourceService().Update(contract);

                return RedirectToAction("CrudeProductGatherSourceIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherSource", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherSourceCreate() {
            var contract = new CrudeProductGatherSourceContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherSource", "CrudeProductGatherSourceCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherSourceCreate([Bind()] CrudeProductGatherSourceContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductGatherSourceService().Insert(contract);

                return RedirectToAction("CrudeProductGatherSourceIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherSource", "CrudeProductGatherSourceCreate"),
                contract
                );
        }
    }
}
