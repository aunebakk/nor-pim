/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 5:25:13 AM
  From Machine: DESKTOP-742U247
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductSearchByCategoryType3Controller : Controller {

        [HttpGet]
        public ActionResult ProductSearchByCategoryType3Index(System.Guid productCategoryId,System.Boolean onParent) {

            return View(
                "~/Views/Durian/ProductSearch/ProductSearchByCategoryType3Index.cshtml",
                new ProductSearchService().ProductSearchByCategoryType3(productCategoryId,onParent)
                );
        }

    }
}
