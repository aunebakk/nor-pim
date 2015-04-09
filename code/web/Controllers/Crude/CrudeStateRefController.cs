using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeStateRefController : Controller {

        [HttpGet]
        public ActionResult CrudeStateRefIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeStateRef", "CrudeStateRefIndex"),
                new CrudeStateRefService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeStateRefDetails(System.String stateRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeStateRef", "CrudeStateRefDetails"),
                new CrudeStateRefService().FetchByStateRcd(stateRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeStateRefEdit(System.String stateRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeStateRef", "CrudeStateRefEdit"),
                new CrudeStateRefService().FetchByStateRcd(stateRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeStateRefEdit([Bind()] CrudeStateRefContract contract) {
            if (ModelState.IsValid) {
                new CrudeStateRefService().Update(contract);

                return RedirectToAction("CrudeStateRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeStateRef", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeStateRefCreate() {
            var contract = new CrudeStateRefContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeStateRef", "CrudeStateRefCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeStateRefCreate([Bind()] CrudeStateRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeStateRefService().Insert(contract);

                return RedirectToAction("CrudeStateRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeStateRef", "CrudeStateRefCreate"),
                contract
                );
        }
    }
}
