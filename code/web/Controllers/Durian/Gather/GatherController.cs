using System;
using System.Web.Mvc;
using norpim.BusinessLogicLayer;

namespace norpim.mvc.Controllers {
    public class GatherController : Controller {
        [HttpGet]
        public ActionResult GatherSearch() {
            return View(    
                MVCHelper.Resolve(Request, "Durian", "Gather", "GatherSearch"), 
                new GatherSearchService().GatherOverview()
                );
        }
    }
}