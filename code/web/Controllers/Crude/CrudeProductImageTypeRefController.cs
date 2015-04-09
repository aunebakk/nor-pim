using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductImageTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductImageTypeRefIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductImageTypeRef", "CrudeProductImageTypeRefIndex"),
                new CrudeProductImageTypeRefService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductImageTypeRefDetails(System.String productImageTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductImageTypeRef", "CrudeProductImageTypeRefDetails"),
                new CrudeProductImageTypeRefService().FetchByProductImageTypeRcd(productImageTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductImageTypeRefEdit(System.String productImageTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductImageTypeRef", "CrudeProductImageTypeRefEdit"),
                new CrudeProductImageTypeRefService().FetchByProductImageTypeRcd(productImageTypeRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductImageTypeRefEdit([Bind()] CrudeProductImageTypeRefContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductImageTypeRefService().Update(contract);

                return RedirectToAction("CrudeProductImageTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductImageTypeRef", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductImageTypeRefCreate() {
            var contract = new CrudeProductImageTypeRefContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductImageTypeRef", "CrudeProductImageTypeRefCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductImageTypeRefCreate([Bind()] CrudeProductImageTypeRefContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductImageTypeRefService().Insert(contract);

                return RedirectToAction("CrudeProductImageTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductImageTypeRef", "CrudeProductImageTypeRefCreate"),
                contract
                );
        }
    }
}
