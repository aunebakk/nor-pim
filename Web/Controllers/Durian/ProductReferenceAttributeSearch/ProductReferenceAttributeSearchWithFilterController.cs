/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/12/2020 5:12:10 AM
  From Machine: DESKTOP-LSRVP12
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
