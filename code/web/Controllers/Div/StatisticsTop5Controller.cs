using norpim.BusinessLogicLayer;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class StatisticsTop5Controller : Controller {

        [HttpGet]
        public ActionResult Index() {
            return View(
                MVCHelper.ResolveDiv(Request, "StatisticsTop5", "Index"), 
                new StatisticsSearchService().ProductStatisticsTop5()
                );
        }
    }
}