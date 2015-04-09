using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductCategoryController : Controller {

        [HttpGet]
        public ActionResult CrudeProductCategoryIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategory", "CrudeProductCategoryIndex"),
                new CrudeProductCategoryService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDetails(System.Guid productCategoryId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategory", "CrudeProductCategoryDetails"),
                new CrudeProductCategoryService().FetchByProductCategoryId(productCategoryId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryEdit(System.Guid productCategoryId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategory", "CrudeProductCategoryEdit"),
                new CrudeProductCategoryService().FetchByProductCategoryId(productCategoryId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryEdit([Bind()] CrudeProductCategoryContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductCategoryService().Update(contract);

                return RedirectToAction("CrudeProductCategoryIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategory", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryCreate() {
            var contract = new CrudeProductCategoryContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategory", "CrudeProductCategoryCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryCreate([Bind()] CrudeProductCategoryContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductCategoryService().Insert(contract);

                return RedirectToAction("CrudeProductCategoryIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategory", "CrudeProductCategoryCreate"),
                contract
                );
        }
    }
}
