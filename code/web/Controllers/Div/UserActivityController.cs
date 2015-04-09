using norpim.BusinessLogicLayer;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class UserActivityController : Controller {

        [HttpGet]
        public ActionResult Index() {
            return View(
                MVCHelper.ResolveDiv(Request, "UserActivity", "Index"), 
                new CrudeUserActivityService().FetchAll()
                );
        }
    }
}