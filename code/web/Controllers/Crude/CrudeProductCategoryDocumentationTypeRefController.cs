using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductCategoryDocumentationTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationTypeRefIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryDocumentationTypeRef", "CrudeProductCategoryDocumentationTypeRefIndex"),
                new CrudeProductCategoryDocumentationTypeRefService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationTypeRefDetails(System.String productCategoryDocumentationTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryDocumentationTypeRef", "CrudeProductCategoryDocumentationTypeRefDetails"),
                new CrudeProductCategoryDocumentationTypeRefService().FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationTypeRefEdit(System.String productCategoryDocumentationTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryDocumentationTypeRef", "CrudeProductCategoryDocumentationTypeRefEdit"),
                new CrudeProductCategoryDocumentationTypeRefService().FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryDocumentationTypeRefEdit([Bind()] CrudeProductCategoryDocumentationTypeRefContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductCategoryDocumentationTypeRefService().Update(contract);

                return RedirectToAction("CrudeProductCategoryDocumentationTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryDocumentationTypeRef", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationTypeRefCreate() {
            var contract = new CrudeProductCategoryDocumentationTypeRefContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryDocumentationTypeRef", "CrudeProductCategoryDocumentationTypeRefCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryDocumentationTypeRefCreate([Bind()] CrudeProductCategoryDocumentationTypeRefContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductCategoryDocumentationTypeRefService().Insert(contract);

                return RedirectToAction("CrudeProductCategoryDocumentationTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryDocumentationTypeRef", "CrudeProductCategoryDocumentationTypeRefCreate"),
                contract
                );
        }
    }
}
