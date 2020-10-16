using SolutionNorSolutionPim.BusinessLogicLayer;
using SolutionNorSolutionPim.mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XXPrototypeDotNetFrameworkWebAppMvcCrudeAspMvc.Controllers {
    [RequireHttps]
    public class HomeController : Controller {
        public ActionResult Index () {
            return View ();
        }

        public ActionResult Applications () {
            return View ();
        }

        public ActionResult About () {
            ViewBag.Message = "Your application description page.";

            return View ();
        }

        public ActionResult Splash () {
            Response.Redirect ( "~/Documentation/Splash2.html", true );

            return null;
        }

        public ActionResult API () {
            return View ();
        }

        public ActionResult CreateIssue () {
            Logging.ActionLog ( Request , "Create Issue" );

            // save result of call
            //new DefaultTestServiceClient ().
            //    AddTestRun (
            //        "SolutionNorPim" , "PIM" , "ASPMenu" ,
            //        Request.UrlReferrer.AbsoluteUri ,
            //        DateTime.UtcNow , DateTime.UtcNow ,
            //        1 ,
            //        DefaultTestRunResultRef.OK ,
            //        string.Empty ,
            //        Logging.UserId ( Request , ViewBag )
            //    );

            return RedirectToAction (
                "DefaultIssueCreateWithUrl" ,
                "DefaultIssue" ,
                new {
                    fromUrl = Request.UrlReferrer.AbsoluteUri ,
                    defaultUserId = Logging.UserId(User.Identity, ViewBag)
                }
                );
        }
    }
}
