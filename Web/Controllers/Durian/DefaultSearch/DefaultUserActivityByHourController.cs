/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:39:41 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultUserActivityByHourController : Controller {

        [HttpGet]
        public ActionResult DefaultUserActivityByHourIndex() {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultUserActivityByHourIndex.cshtml",
                new DefaultSearchService().DefaultUserActivityByHour()
                );
        }

    }
}
