using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductGatherAttributeTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeTypeRefIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherAttributeTypeRef", "CrudeProductGatherAttributeTypeRefIndex"),
                new CrudeProductGatherAttributeTypeRefService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeTypeRefDetails(System.String productGatherAttributeTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherAttributeTypeRef", "CrudeProductGatherAttributeTypeRefDetails"),
                new CrudeProductGatherAttributeTypeRefService().FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeTypeRefEdit(System.String productGatherAttributeTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherAttributeTypeRef", "CrudeProductGatherAttributeTypeRefEdit"),
                new CrudeProductGatherAttributeTypeRefService().FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherAttributeTypeRefEdit([Bind()] CrudeProductGatherAttributeTypeRefContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductGatherAttributeTypeRefService().Update(contract);

                return RedirectToAction("CrudeProductGatherAttributeTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherAttributeTypeRef", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeTypeRefCreate() {
            var contract = new CrudeProductGatherAttributeTypeRefContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherAttributeTypeRef", "CrudeProductGatherAttributeTypeRefCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherAttributeTypeRefCreate([Bind()] CrudeProductGatherAttributeTypeRefContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductGatherAttributeTypeRefService().Insert(contract);

                return RedirectToAction("CrudeProductGatherAttributeTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherAttributeTypeRef", "CrudeProductGatherAttributeTypeRefCreate"),
                contract
                );
        }
    }
}
