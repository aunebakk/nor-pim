using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductAttributeUnitRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductAttributeUnitRefIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttributeUnitRef", "CrudeProductAttributeUnitRefIndex"),
                new CrudeProductAttributeUnitRefService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeUnitRefDetails(System.String productAttributeUnitRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttributeUnitRef", "CrudeProductAttributeUnitRefDetails"),
                new CrudeProductAttributeUnitRefService().FetchByProductAttributeUnitRcd(productAttributeUnitRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeUnitRefEdit(System.String productAttributeUnitRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttributeUnitRef", "CrudeProductAttributeUnitRefEdit"),
                new CrudeProductAttributeUnitRefService().FetchByProductAttributeUnitRcd(productAttributeUnitRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeUnitRefEdit([Bind()] CrudeProductAttributeUnitRefContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductAttributeUnitRefService().Update(contract);

                return RedirectToAction("CrudeProductAttributeUnitRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttributeUnitRef", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeUnitRefCreate() {
            var contract = new CrudeProductAttributeUnitRefContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttributeUnitRef", "CrudeProductAttributeUnitRefCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeUnitRefCreate([Bind()] CrudeProductAttributeUnitRefContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductAttributeUnitRefService().Insert(contract);

                return RedirectToAction("CrudeProductAttributeUnitRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttributeUnitRef", "CrudeProductAttributeUnitRefCreate"),
                contract
                );
        }
    }
}
