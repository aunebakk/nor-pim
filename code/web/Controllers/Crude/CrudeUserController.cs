using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class CrudeUserController : Controller {

        [HttpGet]
        public ActionResult CrudeUserIndex() {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUser", "CrudeUserIndex"),
                new CrudeUserService().FetchAll()
                );
        }

        [HttpGet]
        public ActionResult CrudeUserDetails(System.Guid userId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUser", "CrudeUserDetails"),
                new CrudeUserService().FetchByUserId(userId)
                );
        }

        [HttpGet]
        public ActionResult CrudeUserEdit(System.Guid userId) {
            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUser", "CrudeUserEdit"),
                new CrudeUserService().FetchByUserId(userId)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeUserEdit([Bind()] CrudeUserContract contract) {
            if (ModelState.IsValid) {
                new CrudeUserService().Update(contract);

                return RedirectToAction("CrudeUserIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUser", "Edit"),
                contract
                );
        }

        [HttpGet]
        public ActionResult CrudeUserCreate() {
            var contract = new CrudeUserContract();

            contract.DateTime = DateTime.UtcNow;

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUser", "CrudeUserCreate"),
                contract
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeUserCreate([Bind()] CrudeUserContract contract) {
            if (ModelState.IsValid) {

                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                new CrudeUserService().Insert(contract);

                return RedirectToAction("CrudeUserIndex");
            }

            return View(
                MVCHelper.ResolveCrude(Request, "CrudeUser", "CrudeUserCreate"),
                contract
                );
        }
    }
}
