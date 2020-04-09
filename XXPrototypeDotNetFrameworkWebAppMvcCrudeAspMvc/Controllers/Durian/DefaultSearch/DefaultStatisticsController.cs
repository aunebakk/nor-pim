/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:44:09 PM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultStatisticsController : Controller {

        [HttpGet]
        public ActionResult DefaultStatisticsIndex() {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultStatisticsIndex.cshtml",
                new DefaultSearchService().DefaultStatistics()
                );
        }

    }
}
