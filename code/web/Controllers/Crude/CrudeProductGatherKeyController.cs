using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductGatherKeyController : Controller {

        [HttpGet]
        public ActionResult CrudeProductGatherKeyIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherKey", "CrudeProductGatherKeyIndex"),
                new CrudeProductGatherKeyService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherKeyDetails(System.Guid productGatherKeyId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherKey", "CrudeProductGatherKeyDetails"),
                new CrudeProductGatherKeyService().FetchByProductGatherKeyId(productGatherKeyId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherKeyEdit(System.Guid productGatherKeyId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherKey", "CrudeProductGatherKeyEdit"),
                new CrudeProductGatherKeyService().FetchByProductGatherKeyId(productGatherKeyId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherKeyEdit([Bind()] CrudeProductGatherKeyContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductGatherKeyService().Update(contract);

                return RedirectToAction("CrudeProductGatherKeyIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherKey", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherKeyCreate() {
            var contract = new CrudeProductGatherKeyContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherKey", "CrudeProductGatherKeyCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherKeyCreate([Bind()] CrudeProductGatherKeyContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductGatherKeyService().Insert(contract);

                return RedirectToAction("CrudeProductGatherKeyIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherKey", "CrudeProductGatherKeyCreate"),
                contract
                );
        }
    }
}
