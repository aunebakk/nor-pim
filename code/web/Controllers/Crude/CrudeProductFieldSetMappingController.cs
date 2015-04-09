using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductFieldSetMappingController : Controller {

        [HttpGet]
        public ActionResult CrudeProductFieldSetMappingIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductFieldSetMapping", "CrudeProductFieldSetMappingIndex"),
                new CrudeProductFieldSetMappingService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductFieldSetMappingDetails(System.Guid productFieldSetMappingId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductFieldSetMapping", "CrudeProductFieldSetMappingDetails"),
                new CrudeProductFieldSetMappingService().FetchByProductFieldSetMappingId(productFieldSetMappingId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductFieldSetMappingEdit(System.Guid productFieldSetMappingId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductFieldSetMapping", "CrudeProductFieldSetMappingEdit"),
                new CrudeProductFieldSetMappingService().FetchByProductFieldSetMappingId(productFieldSetMappingId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductFieldSetMappingEdit([Bind()] CrudeProductFieldSetMappingContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductFieldSetMappingService().Update(contract);

                return RedirectToAction("CrudeProductFieldSetMappingIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductFieldSetMapping", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductFieldSetMappingCreate() {
            var contract = new CrudeProductFieldSetMappingContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductFieldSetMapping", "CrudeProductFieldSetMappingCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductFieldSetMappingCreate([Bind()] CrudeProductFieldSetMappingContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductFieldSetMappingService().Insert(contract);

                return RedirectToAction("CrudeProductFieldSetMappingIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductFieldSetMapping", "CrudeProductFieldSetMappingCreate"),
                contract
                );
        }
    }
}
