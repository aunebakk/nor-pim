using SolutionNorSolutionPim.BusinessLogicLayer;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.Controllers {
    public class DefaultUserActivityGroupedLiveController : Controller {
        [HttpGet]
        public ActionResult DefaultUserActivityGroupedLiveIndex() {
            return View(
                "~/Views/Durian/" + "DefaultSearch" + "/" + "DefaultUserActivityGroupedLiveIndex" + ".cshtml",
                new DefaultSearchService().DefaultUserActivityGrouped()
                );
        }
    }
}
