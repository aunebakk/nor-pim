using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductCategoryDocumentationController : Controller {

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryDocumentation", "CrudeProductCategoryDocumentationIndex"),
                new CrudeProductCategoryDocumentationService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationDetails(System.Guid productCategoryDocumentationId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryDocumentation", "CrudeProductCategoryDocumentationDetails"),
                new CrudeProductCategoryDocumentationService().FetchByProductCategoryDocumentationId(productCategoryDocumentationId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationEdit(System.Guid productCategoryDocumentationId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryDocumentation", "CrudeProductCategoryDocumentationEdit"),
                new CrudeProductCategoryDocumentationService().FetchByProductCategoryDocumentationId(productCategoryDocumentationId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryDocumentationEdit([Bind()] CrudeProductCategoryDocumentationContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductCategoryDocumentationService().Update(contract);

                return RedirectToAction("CrudeProductCategoryDocumentationIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryDocumentation", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductCategoryDocumentationCreate() {
            var contract = new CrudeProductCategoryDocumentationContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryDocumentation", "CrudeProductCategoryDocumentationCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductCategoryDocumentationCreate([Bind()] CrudeProductCategoryDocumentationContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductCategoryDocumentationService().Insert(contract);

                return RedirectToAction("CrudeProductCategoryDocumentationIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductCategoryDocumentation", "CrudeProductCategoryDocumentationCreate"),
                contract
                );
        }
    }
}
