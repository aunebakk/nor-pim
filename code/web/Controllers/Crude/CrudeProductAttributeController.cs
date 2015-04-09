using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductAttributeController : Controller {

        [HttpGet]
        public ActionResult CrudeProductAttributeIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttribute", "CrudeProductAttributeIndex"),
                new CrudeProductAttributeService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeDetails(System.Guid productAttributeId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttribute", "CrudeProductAttributeDetails"),
                new CrudeProductAttributeService().FetchByProductAttributeId(productAttributeId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeEdit(System.Guid productAttributeId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttribute", "CrudeProductAttributeEdit"),
                new CrudeProductAttributeService().FetchByProductAttributeId(productAttributeId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeEdit([Bind()] CrudeProductAttributeContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductAttributeService().Update(contract);

                return RedirectToAction("CrudeProductAttributeIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttribute", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeCreate() {
            var contract = new CrudeProductAttributeContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttribute", "CrudeProductAttributeCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeCreate([Bind()] CrudeProductAttributeContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductAttributeService().Insert(contract);

                return RedirectToAction("CrudeProductAttributeIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttribute", "CrudeProductAttributeCreate"),
                contract
                );
        }
    }
}
