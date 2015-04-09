using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductCategoryImageController : Controller {

        [HttpGet]
        public ActionResult CrudeProductCategoryImageIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryImage", "CrudeProductCategoryImageIndex"),
                new CrudeProductCategoryImageService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryImageDetails(System.Guid productCategoryImageId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryImage", "CrudeProductCategoryImageDetails"),
                new CrudeProductCategoryImageService().FetchByProductCategoryImageId(productCategoryImageId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryImageEdit(System.Guid productCategoryImageId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryImage", "CrudeProductCategoryImageEdit"),
                new CrudeProductCategoryImageService().FetchByProductCategoryImageId(productCategoryImageId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryImageEdit([Bind()] CrudeProductCategoryImageContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductCategoryImageService().Update(contract);

                return RedirectToAction("CrudeProductCategoryImageIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryImage", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryImageCreate() {
            var contract = new CrudeProductCategoryImageContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryImage", "CrudeProductCategoryImageCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryImageCreate([Bind()] CrudeProductCategoryImageContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductCategoryImageService().Insert(contract);

                return RedirectToAction("CrudeProductCategoryImageIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryImage", "CrudeProductCategoryImageCreate"),
                contract
                );
        }
    }
}
