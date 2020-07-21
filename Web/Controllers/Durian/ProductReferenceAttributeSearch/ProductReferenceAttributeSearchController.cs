/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:56:16 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc {
    public class ProductReferenceAttributeSearchController : Controller {

        [HttpGet]
        public ActionResult ProductReferenceAttributeSearchIndex() {

            return View(
                "~/Views/Durian/ProductReferenceAttributeSearch/ProductReferenceAttributeSearch.cshtml"
                );
        }

    }
}
