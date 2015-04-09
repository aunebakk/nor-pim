using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductCategoryImageTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductCategoryImageTypeRefIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryImageTypeRef", "CrudeProductCategoryImageTypeRefIndex"),
                new CrudeProductCategoryImageTypeRefService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryImageTypeRefDetails(System.String productCategoryImageTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryImageTypeRef", "CrudeProductCategoryImageTypeRefDetails"),
                new CrudeProductCategoryImageTypeRefService().FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryImageTypeRefEdit(System.String productCategoryImageTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryImageTypeRef", "CrudeProductCategoryImageTypeRefEdit"),
                new CrudeProductCategoryImageTypeRefService().FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryImageTypeRefEdit([Bind()] CrudeProductCategoryImageTypeRefContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductCategoryImageTypeRefService().Update(contract);

                return RedirectToAction("CrudeProductCategoryImageTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryImageTypeRef", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryImageTypeRefCreate() {
            var contract = new CrudeProductCategoryImageTypeRefContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryImageTypeRef", "CrudeProductCategoryImageTypeRefCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryImageTypeRefCreate([Bind()] CrudeProductCategoryImageTypeRefContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductCategoryImageTypeRefService().Insert(contract);

                return RedirectToAction("CrudeProductCategoryImageTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryImageTypeRef", "CrudeProductCategoryImageTypeRefCreate"),
                contract
                );
        }
    }
}
