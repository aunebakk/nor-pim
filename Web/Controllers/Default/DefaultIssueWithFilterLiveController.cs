using System.Web.Mvc;
using SolutionNorSolutionPim.BusinessLogicLayer;
using SolutionNorSolutionPim.mvc.Controllers;

namespace SolutionNorSolutionPim.Controllers.Default
{
    public class DefaultIssueWithFilterLiveController : Controller
    {
        [HttpGet]
        public ActionResult DefaultIssueWithFilterLiveIndex(
            string defaultIssueTypeRcd,
            string defaultIssueStatusRcd
            )
        {
            if (defaultIssueStatusRcd == null)
                defaultIssueStatusRcd = DefaultIssueStatusRef.ToBeResolved;

            ViewBag.DefaultIssueStatusRcd =
                new SelectList(
                    new CrudeDefaultIssueStatusRefServiceClient().FetchAll(),
                    "DefaultIssueStatusRcd",
                    "DefaultIssueStatusName",
                    defaultIssueStatusRcd
                    );

            Logging.ActionLog(
                Request,
                "Default" + " DefaultIssueWithFilterLive" + " DefaultIssueWithFilterLiveIndex" + " ( ASP MVC WCF )"
                );

            return View(
                "~/Views/Default/DefaultIssueWithFilterLive/DefaultIssueWithFilterLiveIndex.cshtml",
                new DefaultSearchServiceClient().DefaultIssueWithFilter(defaultIssueTypeRcd, defaultIssueStatusRcd)
                );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DefaultIssueWithFilterLiveIndex(
            [Bind] DefaultIssueWithFilterContract contract,
            string defaultIssueTypeRcd,
            string defaultIssueStatusRcd
            )
        {
            ViewBag.DefaultIssueStatusRcd =
                new SelectList(
                    new CrudeDefaultIssueStatusRefServiceClient().FetchAll(),
                    "DefaultIssueStatusRcd",
                    "DefaultIssueStatusName"
                    );

            return View(
                "~/Views/Default/DefaultIssueWithFilterLive/DefaultIssueWithFilterLiveIndex.cshtml",
                new DefaultSearchServiceClient().DefaultIssueWithFilter(defaultIssueTypeRcd, defaultIssueStatusRcd)
                );
        }
    }
}
