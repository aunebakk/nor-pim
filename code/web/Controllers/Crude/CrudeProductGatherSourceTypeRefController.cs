using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductGatherSourceTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductGatherSourceTypeRefIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherSourceTypeRef", "CrudeProductGatherSourceTypeRefIndex"),
                new CrudeProductGatherSourceTypeRefService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherSourceTypeRefDetails(System.String productGatherSourceTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherSourceTypeRef", "CrudeProductGatherSourceTypeRefDetails"),
                new CrudeProductGatherSourceTypeRefService().FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherSourceTypeRefEdit(System.String productGatherSourceTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherSourceTypeRef", "CrudeProductGatherSourceTypeRefEdit"),
                new CrudeProductGatherSourceTypeRefService().FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherSourceTypeRefEdit([Bind()] CrudeProductGatherSourceTypeRefContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductGatherSourceTypeRefService().Update(contract);

                return RedirectToAction("CrudeProductGatherSourceTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherSourceTypeRef", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherSourceTypeRefCreate() {
            var contract = new CrudeProductGatherSourceTypeRefContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherSourceTypeRef", "CrudeProductGatherSourceTypeRefCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherSourceTypeRefCreate([Bind()] CrudeProductGatherSourceTypeRefContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductGatherSourceTypeRefService().Insert(contract);

                return RedirectToAction("CrudeProductGatherSourceTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherSourceTypeRef", "CrudeProductGatherSourceTypeRefCreate"),
                contract
                );
        }
    }
}
