using System.Web.Mvc;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.Controllers
{
    public class DefaultUserActivityGroupedLiveController : Controller
    {
        [HttpGet]
        public ActionResult DefaultUserActivityGroupedLiveIndex()
        {
            return View(
                "~/Views/Durian/" + "DefaultSearch" + "/" + "DefaultUserActivityGroupedLiveIndex" + ".cshtml",
                new DefaultSearchServiceClient().DefaultUserActivityGrouped()
                );
        }
    }
}
