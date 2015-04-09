using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductInfoController : Controller {

        [HttpGet]
        public ActionResult CrudeProductInfoIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductInfo", "CrudeProductInfoIndex"),
                new CrudeProductInfoService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductInfoDetails(System.Guid productInfoId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductInfo", "CrudeProductInfoDetails"),
                new CrudeProductInfoService().FetchByProductInfoId(productInfoId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductInfoEdit(System.Guid productInfoId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductInfo", "CrudeProductInfoEdit"),
                new CrudeProductInfoService().FetchByProductInfoId(productInfoId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductInfoEdit([Bind()] CrudeProductInfoContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductInfoService().Update(contract);

                return RedirectToAction("CrudeProductInfoIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductInfo", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductInfoCreate() {
            var contract = new CrudeProductInfoContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductInfo", "CrudeProductInfoCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductInfoCreate([Bind()] CrudeProductInfoContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductInfoService().Insert(contract);

                return RedirectToAction("CrudeProductInfoIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductInfo", "CrudeProductInfoCreate"),
                contract
                );
        }
    }
}
