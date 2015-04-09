using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductAttributeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductAttributeRefIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttributeRef", "CrudeProductAttributeRefIndex"),
                new CrudeProductAttributeRefService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeRefDetails(System.String productAttributeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttributeRef", "CrudeProductAttributeRefDetails"),
                new CrudeProductAttributeRefService().FetchByProductAttributeRcd(productAttributeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeRefEdit(System.String productAttributeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttributeRef", "CrudeProductAttributeRefEdit"),
                new CrudeProductAttributeRefService().FetchByProductAttributeRcd(productAttributeRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeRefEdit([Bind()] CrudeProductAttributeRefContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductAttributeRefService().Update(contract);

                return RedirectToAction("CrudeProductAttributeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttributeRef", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductAttributeRefCreate() {
            var contract = new CrudeProductAttributeRefContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttributeRef", "CrudeProductAttributeRefCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductAttributeRefCreate([Bind()] CrudeProductAttributeRefContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductAttributeRefService().Insert(contract);

                return RedirectToAction("CrudeProductAttributeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductAttributeRef", "CrudeProductAttributeRefCreate"),
                contract
                );
        }
    }
}
