using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.WebPages;

namespace Web {
    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            EvaluateDisplayMode(); //Evaluate incoming request and update Display Mode table
        }

        /// <summary>
        ///     Evaluates incoming request and determines and adds an entry into the Display mode table
        /// </summary>
        private static void EvaluateDisplayMode() {
            DisplayModeProvider.Instance.Modes.Insert(0,
                new DefaultDisplayMode("Phone") {
                    //...modify file (view that is served)
                    //Query condition
                    ContextCondition = ctx => (ctx.GetOverriddenUserAgent() != null) &&
                                              ( //...either iPhone or iPad                           
                                                  (ctx.GetOverriddenUserAgent()
                                                      .IndexOf("iPhone", StringComparison.OrdinalIgnoreCase) >= 0) ||
                                                  (ctx.GetOverriddenUserAgent()
                                                      .IndexOf("Android", StringComparison.OrdinalIgnoreCase) >= 0) ||
                                                  (ctx.GetOverriddenUserAgent()
                                                      .IndexOf("iPod", StringComparison.OrdinalIgnoreCase) >= 0)
                                                  )
                });

            DisplayModeProvider.Instance.Modes.Insert(0,
                new DefaultDisplayMode("Tablet") {
                    ContextCondition = ctx => (ctx.GetOverriddenUserAgent() != null) &&
                                              (
                                                  (ctx.GetOverriddenUserAgent()
                                                      .IndexOf("iPad", StringComparison.OrdinalIgnoreCase) >= 0) ||
                                                  (ctx.GetOverriddenUserAgent()
                                                      .IndexOf("Playbook", StringComparison.OrdinalIgnoreCase) >= 0)
                                                  )
                });
        }
    }
}
