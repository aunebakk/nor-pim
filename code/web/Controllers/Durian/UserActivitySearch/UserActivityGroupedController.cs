using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class UserActivityGroupedController : Controller {

        [HttpGet]
        public ActionResult UserActivityGroupedIndex() {
            return View(
                MVCHelper.ResolveDurian(Request, "UserActivitySearch", "UserActivityGrouped", "UserActivityGroupedIndex"),
                new UserActivitySearchService().UserActivityGrouped()
                );
        }

    }
}
