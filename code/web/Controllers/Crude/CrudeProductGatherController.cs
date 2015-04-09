using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductGatherController : Controller {

        [HttpGet]
        public ActionResult CrudeProductGatherIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGather", "CrudeProductGatherIndex"),
                new CrudeProductGatherService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherDetails(System.Guid productGatherId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGather", "CrudeProductGatherDetails"),
                new CrudeProductGatherService().FetchByProductGatherId(productGatherId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherEdit(System.Guid productGatherId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGather", "CrudeProductGatherEdit"),
                new CrudeProductGatherService().FetchByProductGatherId(productGatherId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherEdit([Bind()] CrudeProductGatherContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductGatherService().Update(contract);

                return RedirectToAction("CrudeProductGatherIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGather", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherCreate() {
            var contract = new CrudeProductGatherContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGather", "CrudeProductGatherCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherCreate([Bind()] CrudeProductGatherContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductGatherService().Insert(contract);

                return RedirectToAction("CrudeProductGatherIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGather", "CrudeProductGatherCreate"),
                contract
                );
        }
    }
}
