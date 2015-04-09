using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class UserActivityGroupedByAddressController : Controller {

        [HttpGet]
        public ActionResult UserActivityGroupedByAddressIndex() {
            return View(
                MVCHelper.ResolveDurian(Request, "UserActivitySearch", "UserActivityGroupedByAddress", "UserActivityGroupedByAddressIndex"),
                new UserActivitySearchService().UserActivityGroupedByAddress()
                );
        }

    }
}
