/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:55:31 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultResourceStatisticsController : Controller {

        [HttpGet]
        public ActionResult DefaultResourceStatisticsIndex() {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultResourceStatisticsIndex.cshtml",
                new DefaultSearchService().DefaultResourceStatistics()
                );
        }

    }
}
