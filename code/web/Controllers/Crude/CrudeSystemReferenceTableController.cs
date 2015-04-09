using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeSystemReferenceTableController : Controller {

        [HttpGet]
        public ActionResult CrudeSystemReferenceTableIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemReferenceTable", "CrudeSystemReferenceTableIndex"),
                new CrudeSystemReferenceTableService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeSystemReferenceTableDetails(System.Guid systemReferenceTableId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemReferenceTable", "CrudeSystemReferenceTableDetails"),
                new CrudeSystemReferenceTableService().FetchBySystemReferenceTableId(systemReferenceTableId)
                );
        }

        [HttpGet]
        public ActionResult CrudeSystemReferenceTableEdit(System.Guid systemReferenceTableId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemReferenceTable", "CrudeSystemReferenceTableEdit"),
                new CrudeSystemReferenceTableService().FetchBySystemReferenceTableId(systemReferenceTableId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeSystemReferenceTableEdit([Bind()] CrudeSystemReferenceTableContract contract) {
            if (ModelState.IsValid) {
                new CrudeSystemReferenceTableService().Update(contract);

                return RedirectToAction("CrudeSystemReferenceTableIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemReferenceTable", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeSystemReferenceTableCreate() {
            var contract = new CrudeSystemReferenceTableContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemReferenceTable", "CrudeSystemReferenceTableCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeSystemReferenceTableCreate([Bind()] CrudeSystemReferenceTableContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeSystemReferenceTableService().Insert(contract);

                return RedirectToAction("CrudeSystemReferenceTableIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeSystemReferenceTable", "CrudeSystemReferenceTableCreate"),
                contract
                );
        }
    }
}
