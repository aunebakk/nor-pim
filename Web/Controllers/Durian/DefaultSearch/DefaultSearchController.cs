/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 4:20:30 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc {
    public class DefaultSearchController : Controller {

        [HttpGet]
        public ActionResult DefaultSearchIndex() {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultSearch.cshtml"
                );
        }

    }
}
