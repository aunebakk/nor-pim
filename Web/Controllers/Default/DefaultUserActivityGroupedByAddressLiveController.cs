using SolutionNorSolutionPim.BusinessLogicLayer;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.Controllers {
    public class DefaultUserActivityGroupedByAddressLiveController : Controller {
        [HttpGet]
        public ActionResult DefaultUserActivityGroupedByAddressLiveIndex() {
            return View(
                "~/Views/Durian/DefaultSearch/DefaultUserActivityGroupedByAddressLiveIndex.cshtml",
                new DefaultSearchService().DefaultUserActivityGroupedByAddress()
                );
        }
    }
}
