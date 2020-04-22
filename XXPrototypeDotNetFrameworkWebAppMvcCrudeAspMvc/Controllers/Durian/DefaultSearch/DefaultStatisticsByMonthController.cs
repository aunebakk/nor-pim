/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:51:46 AM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultStatisticsByMonthController : Controller {

        [HttpGet]
        public ActionResult DefaultStatisticsByMonthIndex() {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultStatisticsByMonthIndex.cshtml",
                new DefaultSearchService().DefaultStatisticsByMonth()
                );
        }

    }
}
