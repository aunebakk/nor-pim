/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 4:21:57 AM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc {
    public class CategorySearchController : Controller {

        [HttpGet]
        public ActionResult CategorySearchIndex() {

            return View(
                "~/Views/Durian/CategorySearch/CategorySearch.cshtml"
                );
        }

    }
}
