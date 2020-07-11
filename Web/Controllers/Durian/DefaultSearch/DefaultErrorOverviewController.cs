/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 12:48:41 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultErrorOverviewController : Controller {

        [HttpGet]
        public ActionResult DefaultErrorOverviewIndex() {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultErrorOverviewIndex.cshtml",
                new DefaultSearchService().DefaultErrorOverview()
                );
        }

    }
}
