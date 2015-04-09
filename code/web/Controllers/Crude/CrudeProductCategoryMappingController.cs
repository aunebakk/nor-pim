using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductCategoryMappingController : Controller {

        [HttpGet]
        public ActionResult CrudeProductCategoryMappingIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryMapping", "CrudeProductCategoryMappingIndex"),
                new CrudeProductCategoryMappingService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryMappingDetails(System.Guid productCategoryMappingId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryMapping", "CrudeProductCategoryMappingDetails"),
                new CrudeProductCategoryMappingService().FetchByProductCategoryMappingId(productCategoryMappingId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryMappingEdit(System.Guid productCategoryMappingId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryMapping", "CrudeProductCategoryMappingEdit"),
                new CrudeProductCategoryMappingService().FetchByProductCategoryMappingId(productCategoryMappingId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryMappingEdit([Bind()] CrudeProductCategoryMappingContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductCategoryMappingService().Update(contract);

                return RedirectToAction("CrudeProductCategoryMappingIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryMapping", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryMappingCreate() {
            var contract = new CrudeProductCategoryMappingContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryMapping", "CrudeProductCategoryMappingCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryMappingCreate([Bind()] CrudeProductCategoryMappingContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductCategoryMappingService().Insert(contract);

                return RedirectToAction("CrudeProductCategoryMappingIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryMapping", "CrudeProductCategoryMappingCreate"),
                contract
                );
        }
    }
}
