/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 8:35:39 PM
  From Machine: DESKTOP-517I8BU
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
