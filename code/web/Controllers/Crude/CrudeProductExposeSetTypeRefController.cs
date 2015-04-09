using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductExposeSetTypeRefController : Controller {

        [HttpGet]
        public ActionResult CrudeProductExposeSetTypeRefIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposeSetTypeRef", "CrudeProductExposeSetTypeRefIndex"),
                new CrudeProductExposeSetTypeRefService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeSetTypeRefDetails(System.String productExposeSetTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposeSetTypeRef", "CrudeProductExposeSetTypeRefDetails"),
                new CrudeProductExposeSetTypeRefService().FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeSetTypeRefEdit(System.String productExposeSetTypeRcd) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposeSetTypeRef", "CrudeProductExposeSetTypeRefEdit"),
                new CrudeProductExposeSetTypeRefService().FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeSetTypeRefEdit([Bind()] CrudeProductExposeSetTypeRefContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductExposeSetTypeRefService().Update(contract);

                return RedirectToAction("CrudeProductExposeSetTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposeSetTypeRef", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeSetTypeRefCreate() {
            var contract = new CrudeProductExposeSetTypeRefContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposeSetTypeRef", "CrudeProductExposeSetTypeRefCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeSetTypeRefCreate([Bind()] CrudeProductExposeSetTypeRefContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductExposeSetTypeRefService().Insert(contract);

                return RedirectToAction("CrudeProductExposeSetTypeRefIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposeSetTypeRef", "CrudeProductExposeSetTypeRefCreate"),
                contract
                );
        }
    }
}
