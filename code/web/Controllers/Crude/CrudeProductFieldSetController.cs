using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductFieldSetController : Controller {

        [HttpGet]
        public ActionResult CrudeProductFieldSetIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductFieldSet", "CrudeProductFieldSetIndex"),
                new CrudeProductFieldSetService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductFieldSetDetails(System.Guid productFieldSetId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductFieldSet", "CrudeProductFieldSetDetails"),
                new CrudeProductFieldSetService().FetchByProductFieldSetId(productFieldSetId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductFieldSetEdit(System.Guid productFieldSetId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductFieldSet", "CrudeProductFieldSetEdit"),
                new CrudeProductFieldSetService().FetchByProductFieldSetId(productFieldSetId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductFieldSetEdit([Bind()] CrudeProductFieldSetContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductFieldSetService().Update(contract);

                return RedirectToAction("CrudeProductFieldSetIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductFieldSet", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductFieldSetCreate() {
            var contract = new CrudeProductFieldSetContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductFieldSet", "CrudeProductFieldSetCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductFieldSetCreate([Bind()] CrudeProductFieldSetContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductFieldSetService().Insert(contract);

                return RedirectToAction("CrudeProductFieldSetIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductFieldSet", "CrudeProductFieldSetCreate"),
                contract
                );
        }
    }
}
