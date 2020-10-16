using SolutionNorSolutionPim.BusinessLogicLayer;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.mvc.Controllers {
    public class DashboardController : Controller {
        public ActionResult Dashboard() {
            return View();
        }

        public ActionResult DashboardApplications() {
            return View();
        }

        public ActionResult DashboardInfo() {
            return View();
        }

        public ActionResult DashboardWhiteboard() {
            return View();
        }

        public ActionResult Splash() {
            return View();
        }

        // new template as of 2016.07.28 ( templateChapterIndex )
        public ActionResult TemplateChapterIndex() {
            Logging.ActionLog(Request, "TemplateChapterIndex", ViewBag);

            // fetch products
            var productCategory = new CrudeProductCategoryServiceClient();
            var productCategoryContracts = productCategory.FetchAll();

            return View(
                productCategoryContracts
                );
        }
    }
}
