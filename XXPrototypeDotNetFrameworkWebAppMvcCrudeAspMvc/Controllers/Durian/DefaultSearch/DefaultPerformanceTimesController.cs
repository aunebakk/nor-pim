/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:44:31 PM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultPerformanceTimesController : Controller {

        [HttpGet]
        public ActionResult DefaultPerformanceTimesIndex(System.String commandName) {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultPerformanceTimesIndex.cshtml",
                new DefaultSearchService().DefaultPerformanceTimes(commandName)
                );
        }

    }
}
