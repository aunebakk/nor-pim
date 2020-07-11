using System.Web.Mvc;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.Controllers
{
    public class DefaultUserActivityGroupedByAddressLiveController : Controller
    {
        [HttpGet]
        public ActionResult DefaultUserActivityGroupedByAddressLiveIndex()
        {
            return View(
                "~/Views/Durian/DefaultSearch/DefaultUserActivityGroupedByAddressLiveIndex.cshtml",
                new DefaultSearchService().DefaultUserActivityGroupedByAddress()
                );
        }
    }
}
