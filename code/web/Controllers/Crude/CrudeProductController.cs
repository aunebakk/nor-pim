using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductController : Controller {

        [HttpGet]
        public ActionResult CrudeProductIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProduct", "CrudeProductIndex"),
                new CrudeProductService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDetails(System.Guid productId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProduct", "CrudeProductDetails"),
                new CrudeProductService().FetchByProductId(productId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductEdit(System.Guid productId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProduct", "CrudeProductEdit"),
                new CrudeProductService().FetchByProductId(productId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductEdit([Bind()] CrudeProductContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductService().Update(contract);

                return RedirectToAction("CrudeProductIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProduct", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCreate() {
            var contract = new CrudeProductContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProduct", "CrudeProductCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCreate([Bind()] CrudeProductContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductService().Insert(contract);

                return RedirectToAction("CrudeProductIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProduct", "CrudeProductCreate"),
                contract
                );
        }
    }
}
