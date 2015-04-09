using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductDocumentationTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductDocumentationTypeRefIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductDocumentationTypeRef", "CrudeProductDocumentationTypeRefIndex"),
                new CrudeProductDocumentationTypeRefService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDocumentationTypeRefDetails(System.String productDocumentationTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductDocumentationTypeRef", "CrudeProductDocumentationTypeRefDetails"),
                new CrudeProductDocumentationTypeRefService().FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDocumentationTypeRefEdit(System.String productDocumentationTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductDocumentationTypeRef", "CrudeProductDocumentationTypeRefEdit"),
                new CrudeProductDocumentationTypeRefService().FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductDocumentationTypeRefEdit([Bind()] CrudeProductDocumentationTypeRefContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductDocumentationTypeRefService().Update(contract);

                return RedirectToAction("CrudeProductDocumentationTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductDocumentationTypeRef", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductDocumentationTypeRefCreate() {
            var contract = new CrudeProductDocumentationTypeRefContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductDocumentationTypeRef", "CrudeProductDocumentationTypeRefCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductDocumentationTypeRefCreate([Bind()] CrudeProductDocumentationTypeRefContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductDocumentationTypeRefService().Insert(contract);

                return RedirectToAction("CrudeProductDocumentationTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductDocumentationTypeRef", "CrudeProductDocumentationTypeRefCreate"),
                contract
                );
        }
    }
}
