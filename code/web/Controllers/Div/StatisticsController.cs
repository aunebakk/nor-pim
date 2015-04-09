using norpim.BusinessLogicLayer;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class StatisticsController : Controller {
        
        [HttpGet]
        public ActionResult Index() {
            return View(
                MVCHelper.ResolveDiv(Request, "Statistics", "Index"), 
                new StatisticsSearchService().ProductStatistics()
                );
        }
    }
}