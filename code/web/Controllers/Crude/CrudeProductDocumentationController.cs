using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductDocumentationController : Controller {

        [HttpGet]
        public ActionResult CrudeProductDocumentationIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductDocumentation", "CrudeProductDocumentationIndex"),
                new CrudeProductDocumentationService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDocumentationDetails(System.Guid productDocumentationId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductDocumentation", "CrudeProductDocumentationDetails"),
                new CrudeProductDocumentationService().FetchByProductDocumentationId(productDocumentationId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDocumentationEdit(System.Guid productDocumentationId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductDocumentation", "CrudeProductDocumentationEdit"),
                new CrudeProductDocumentationService().FetchByProductDocumentationId(productDocumentationId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductDocumentationEdit([Bind()] CrudeProductDocumentationContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductDocumentationService().Update(contract);

                return RedirectToAction("CrudeProductDocumentationIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductDocumentation", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDocumentationCreate() {
            var contract = new CrudeProductDocumentationContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductDocumentation", "CrudeProductDocumentationCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductDocumentationCreate([Bind()] CrudeProductDocumentationContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductDocumentationService().Insert(contract);

                return RedirectToAction("CrudeProductDocumentationIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductDocumentation", "CrudeProductDocumentationCreate"),
                contract
                );
        }
    }
}
