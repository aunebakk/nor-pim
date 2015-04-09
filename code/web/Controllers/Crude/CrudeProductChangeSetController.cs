using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeProductChangeSetController : Controller {

        [HttpGet]
        public ActionResult CrudeProductChangeSetIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductChangeSet", "CrudeProductChangeSetIndex"),
                new CrudeProductChangeSetService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeProductChangeSetDetails(System.Guid productChangeSetId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductChangeSet", "CrudeProductChangeSetDetails"),
                new CrudeProductChangeSetService().FetchByProductChangeSetId(productChangeSetId)
                );
        }

        [HttpGet]
        public ActionResult CrudeProductChangeSetEdit(System.Guid productChangeSetId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductChangeSet", "CrudeProductChangeSetEdit"),
                new CrudeProductChangeSetService().FetchByProductChangeSetId(productChangeSetId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductChangeSetEdit([Bind()] CrudeProductChangeSetContract contract) {
            if (ModelState.IsValid) {
                new CrudeProductChangeSetService().Update(contract);

                return RedirectToAction("CrudeProductChangeSetIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductChangeSet", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeProductChangeSetCreate() {
            var contract = new CrudeProductChangeSetContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductChangeSet", "CrudeProductChangeSetCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeProductChangeSetCreate([Bind()] CrudeProductChangeSetContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeProductChangeSetService().Insert(contract);

                return RedirectToAction("CrudeProductChangeSetIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeProductChangeSet", "CrudeProductChangeSetCreate"),
                contract
                );
        }
    }
}
