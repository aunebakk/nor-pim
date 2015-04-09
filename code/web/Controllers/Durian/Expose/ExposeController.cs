using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class ExposeController : Controller {
        [HttpGet]
        public ActionResult ExposeSearch() {
            return View(    
                MVCHelper.Resolve(Request, "Durian", "Expose", "ExposeSearch"), 
                new ExposeSearchService().ExposeProductDetails(Guid.Empty)
                );
        }
    }
}