using System;
using System.Web.Mvc;
using norpim.BusinessLogicLayer;

namespace norpim.mvc.Controllers {

    public class HomeController : Controller {
        public ActionResult Index() {
            Logging.ActionLog(Request, "HomePage Index (http://norpim.azurewebsites.net/)");
            return View();
        }

        public ActionResult Interface() {
            Logging.ActionLog(Request, "HomePage Interface (http://norpim.azurewebsites.net/)");
            return View();
        }

        public ActionResult Business() {
            Logging.ActionLog(Request, "HomePage Business (http://norpim.azurewebsites.net/)");

            return View();
        }

        public ActionResult Data() {
            Logging.ActionLog(Request, "HomePage Data (http://norpim.azurewebsites.net/)");

            return View();
        }
    }
}