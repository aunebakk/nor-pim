/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:34:22 AM
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc {
    public class ProductMaintenanceSearchController : Controller {

        [HttpGet]
        public ActionResult ProductMaintenanceSearchIndex() {

            return View(
                "~/Views/Durian/ProductMaintenanceSearch/ProductMaintenanceSearch.cshtml"
                );
        }

    }
}
