using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductGatherAttributeController : Controller {

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherAttribute", "CrudeProductGatherAttributeIndex"),
                new CrudeProductGatherAttributeService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeDetails(System.Guid productGatherAttributeId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherAttribute", "CrudeProductGatherAttributeDetails"),
                new CrudeProductGatherAttributeService().FetchByProductGatherAttributeId(productGatherAttributeId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeEdit(System.Guid productGatherAttributeId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherAttribute", "CrudeProductGatherAttributeEdit"),
                new CrudeProductGatherAttributeService().FetchByProductGatherAttributeId(productGatherAttributeId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherAttributeEdit([Bind()] CrudeProductGatherAttributeContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductGatherAttributeService().Update(contract);

                return RedirectToAction("CrudeProductGatherAttributeIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherAttribute", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductGatherAttributeCreate() {
            var contract = new CrudeProductGatherAttributeContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherAttribute", "CrudeProductGatherAttributeCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductGatherAttributeCreate([Bind()] CrudeProductGatherAttributeContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductGatherAttributeService().Insert(contract);

                return RedirectToAction("CrudeProductGatherAttributeIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductGatherAttribute", "CrudeProductGatherAttributeCreate"),
                contract
                );
        }
    }
}
