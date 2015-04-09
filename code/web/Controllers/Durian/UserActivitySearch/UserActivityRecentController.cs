using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class UserActivityRecentController : Controller {

        [HttpGet]
        public ActionResult UserActivityRecentIndex() {
            return View(
                MVCHelper.ResolveDurian(Request, "UserActivitySearch", "UserActivityRecent", "UserActivityRecentIndex"),
                new UserActivitySearchService().UserActivityRecent()
                );
        }

    }
}
