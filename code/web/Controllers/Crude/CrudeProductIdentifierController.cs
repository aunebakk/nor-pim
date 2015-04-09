using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductIdentifierController : Controller {

        [HttpGet]
        public ActionResult CrudeProductIdentifierIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductIdentifier", "CrudeProductIdentifierIndex"),
                new CrudeProductIdentifierService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductIdentifierDetails(System.Guid productIdentifierId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductIdentifier", "CrudeProductIdentifierDetails"),
                new CrudeProductIdentifierService().FetchByProductIdentifierId(productIdentifierId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductIdentifierEdit(System.Guid productIdentifierId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductIdentifier", "CrudeProductIdentifierEdit"),
                new CrudeProductIdentifierService().FetchByProductIdentifierId(productIdentifierId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductIdentifierEdit([Bind()] CrudeProductIdentifierContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductIdentifierService().Update(contract);

                return RedirectToAction("CrudeProductIdentifierIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductIdentifier", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductIdentifierCreate() {
            var contract = new CrudeProductIdentifierContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductIdentifier", "CrudeProductIdentifierCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductIdentifierCreate([Bind()] CrudeProductIdentifierContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductIdentifierService().Insert(contract);

                return RedirectToAction("CrudeProductIdentifierIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductIdentifier", "CrudeProductIdentifierCreate"),
                contract
                );
        }
    }
}
