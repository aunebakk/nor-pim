/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 7:49:49 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultStatisticsTop5Controller : Controller {

        [HttpGet]
        public ActionResult DefaultStatisticsTop5Index() {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultStatisticsTop5Index.cshtml",
                new DefaultSearchService().DefaultStatisticsTop5()
                );
        }

    }
}
