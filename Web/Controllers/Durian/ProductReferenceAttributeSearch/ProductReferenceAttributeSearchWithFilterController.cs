/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 5:25:20 AM
  From Machine: DESKTOP-742U247
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductReferenceAttributeSearchWithFilterController : Controller {

        [HttpGet]
        public ActionResult ProductReferenceAttributeSearchWithFilterIndex() {

            return View(
                "~/Views/Durian/ProductReferenceAttributeSearch/ProductReferenceAttributeSearchWithFilterIndex.cshtml",
                new ProductReferenceAttributeSearchService().ProductReferenceAttributeSearchWithFilter()
                );
        }

    }
}
