/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 2:54:32 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultUserActivityGroupedByAddressController : Controller {

        [HttpGet]
        public ActionResult DefaultUserActivityGroupedByAddressIndex() {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultUserActivityGroupedByAddressIndex.cshtml",
                new DefaultSearchService().DefaultUserActivityGroupedByAddress()
                );
        }

    }
}
