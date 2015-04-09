using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductExposeSetController : Controller {

        [HttpGet]
        public ActionResult CrudeProductExposeSetIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposeSet", "CrudeProductExposeSetIndex"),
                new CrudeProductExposeSetService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeSetDetails(System.Guid productExposeSetId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposeSet", "CrudeProductExposeSetDetails"),
                new CrudeProductExposeSetService().FetchByProductExposeSetId(productExposeSetId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeSetEdit(System.Guid productExposeSetId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposeSet", "CrudeProductExposeSetEdit"),
                new CrudeProductExposeSetService().FetchByProductExposeSetId(productExposeSetId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeSetEdit([Bind()] CrudeProductExposeSetContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductExposeSetService().Update(contract);

                return RedirectToAction("CrudeProductExposeSetIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposeSet", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeSetCreate() {
            var contract = new CrudeProductExposeSetContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposeSet", "CrudeProductExposeSetCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeSetCreate([Bind()] CrudeProductExposeSetContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductExposeSetService().Insert(contract);

                return RedirectToAction("CrudeProductExposeSetIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExposeSet", "CrudeProductExposeSetCreate"),
                contract
                );
        }
    }
}
