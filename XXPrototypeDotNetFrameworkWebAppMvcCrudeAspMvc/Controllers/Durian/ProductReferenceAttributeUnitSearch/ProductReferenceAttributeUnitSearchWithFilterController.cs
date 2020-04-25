/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:52:52 AM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductReferenceAttributeUnitSearchWithFilterController : Controller {

        [HttpGet]
        public ActionResult ProductReferenceAttributeUnitSearchWithFilterIndex() {

            return View(
                "~/Views/Durian/ProductReferenceAttributeUnitSearch/ProductReferenceAttributeUnitSearchWithFilterIndex.cshtml",
                new ProductReferenceAttributeUnitSearchService().ProductReferenceAttributeUnitSearchWithFilter()
                );
        }

    }
}
