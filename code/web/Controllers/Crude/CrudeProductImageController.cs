using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductImageController : Controller {

        [HttpGet]
        public ActionResult CrudeProductImageIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductImage", "CrudeProductImageIndex"),
                new CrudeProductImageService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductImageDetails(System.Guid productImageId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductImage", "CrudeProductImageDetails"),
                new CrudeProductImageService().FetchByProductImageId(productImageId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductImageEdit(System.Guid productImageId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductImage", "CrudeProductImageEdit"),
                new CrudeProductImageService().FetchByProductImageId(productImageId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductImageEdit([Bind()] CrudeProductImageContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductImageService().Update(contract);

                return RedirectToAction("CrudeProductImageIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductImage", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductImageCreate() {
            var contract = new CrudeProductImageContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductImage", "CrudeProductImageCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductImageCreate([Bind()] CrudeProductImageContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductImageService().Insert(contract);

                return RedirectToAction("CrudeProductImageIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductImage", "CrudeProductImageCreate"),
                contract
                );
        }
    }
}
