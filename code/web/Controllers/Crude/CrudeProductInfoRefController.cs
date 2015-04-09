using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductInfoRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductInfoRefIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductInfoRef", "CrudeProductInfoRefIndex"),
                new CrudeProductInfoRefService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductInfoRefDetails(System.String productInfoRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductInfoRef", "CrudeProductInfoRefDetails"),
                new CrudeProductInfoRefService().FetchByProductInfoRcd(productInfoRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductInfoRefEdit(System.String productInfoRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductInfoRef", "CrudeProductInfoRefEdit"),
                new CrudeProductInfoRefService().FetchByProductInfoRcd(productInfoRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductInfoRefEdit([Bind()] CrudeProductInfoRefContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductInfoRefService().Update(contract);

                return RedirectToAction("CrudeProductInfoRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductInfoRef", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductInfoRefCreate() {
            var contract = new CrudeProductInfoRefContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductInfoRef", "CrudeProductInfoRefCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductInfoRefCreate([Bind()] CrudeProductInfoRefContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductInfoRefService().Insert(contract);

                return RedirectToAction("CrudeProductInfoRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductInfoRef", "CrudeProductInfoRefCreate"),
                contract
                );
        }
    }
}
