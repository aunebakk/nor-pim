using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductExposedSelectionController : Controller {

        [HttpGet]
        public ActionResult CrudeProductExposedSelectionIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposedSelection", "CrudeProductExposedSelectionIndex"),
                new CrudeProductExposedSelectionService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposedSelectionDetails(System.Guid productExposedSelectionId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposedSelection", "CrudeProductExposedSelectionDetails"),
                new CrudeProductExposedSelectionService().FetchByProductExposedSelectionId(productExposedSelectionId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposedSelectionEdit(System.Guid productExposedSelectionId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposedSelection", "CrudeProductExposedSelectionEdit"),
                new CrudeProductExposedSelectionService().FetchByProductExposedSelectionId(productExposedSelectionId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposedSelectionEdit([Bind()] CrudeProductExposedSelectionContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductExposedSelectionService().Update(contract);

                return RedirectToAction("CrudeProductExposedSelectionIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposedSelection", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposedSelectionCreate() {
            var contract = new CrudeProductExposedSelectionContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposedSelection", "CrudeProductExposedSelectionCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposedSelectionCreate([Bind()] CrudeProductExposedSelectionContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductExposedSelectionService().Insert(contract);

                return RedirectToAction("CrudeProductExposedSelectionIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposedSelection", "CrudeProductExposedSelectionCreate"),
                contract
                );
        }
    }
}
