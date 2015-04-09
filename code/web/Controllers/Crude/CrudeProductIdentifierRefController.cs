using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductIdentifierRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductIdentifierRefIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductIdentifierRef", "CrudeProductIdentifierRefIndex"),
                new CrudeProductIdentifierRefService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductIdentifierRefDetails(System.String productIdentifierRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductIdentifierRef", "CrudeProductIdentifierRefDetails"),
                new CrudeProductIdentifierRefService().FetchByProductIdentifierRcd(productIdentifierRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductIdentifierRefEdit(System.String productIdentifierRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductIdentifierRef", "CrudeProductIdentifierRefEdit"),
                new CrudeProductIdentifierRefService().FetchByProductIdentifierRcd(productIdentifierRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductIdentifierRefEdit([Bind()] CrudeProductIdentifierRefContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductIdentifierRefService().Update(contract);

                return RedirectToAction("CrudeProductIdentifierRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductIdentifierRef", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductIdentifierRefCreate() {
            var contract = new CrudeProductIdentifierRefContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductIdentifierRef", "CrudeProductIdentifierRefCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductIdentifierRefCreate([Bind()] CrudeProductIdentifierRefContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductIdentifierRefService().Insert(contract);

                return RedirectToAction("CrudeProductIdentifierRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductIdentifierRef", "CrudeProductIdentifierRefCreate"),
                contract
                );
        }
    }
}
