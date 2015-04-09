using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductExposeController : Controller {

        [HttpGet]
        public ActionResult CrudeProductExposeIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExpose", "CrudeProductExposeIndex"),
                new CrudeProductExposeService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeDetails(System.Guid productExposeId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExpose", "CrudeProductExposeDetails"),
                new CrudeProductExposeService().FetchByProductExposeId(productExposeId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeEdit(System.Guid productExposeId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExpose", "CrudeProductExposeEdit"),
                new CrudeProductExposeService().FetchByProductExposeId(productExposeId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeEdit([Bind()] CrudeProductExposeContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductExposeService().Update(contract);

                return RedirectToAction("CrudeProductExposeIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExpose", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductExposeCreate() {
            var contract = new CrudeProductExposeContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExpose", "CrudeProductExposeCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductExposeCreate([Bind()] CrudeProductExposeContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductExposeService().Insert(contract);

                return RedirectToAction("CrudeProductExposeIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductExpose", "CrudeProductExposeCreate"),
                contract
                );
        }
    }
}
