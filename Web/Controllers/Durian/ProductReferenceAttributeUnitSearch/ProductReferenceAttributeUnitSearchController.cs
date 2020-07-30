/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/30/2020 6:49:17 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc {
    public class ProductReferenceAttributeUnitSearchController : Controller {

        [HttpGet]
        public ActionResult ProductReferenceAttributeUnitSearchIndex() {

            return View(
                "~/Views/Durian/ProductReferenceAttributeUnitSearch/ProductReferenceAttributeUnitSearch.cshtml"
                );
        }

    }
}
