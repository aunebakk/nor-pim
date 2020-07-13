/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:58:32 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductHistoryController : Controller {

        [HttpGet]
        public ActionResult ProductHistoryIndex(System.Guid productId) {

            return View(
                "~/Views/Durian/ProductSearch/ProductHistoryIndex.cshtml",
                new ProductSearchService().ProductHistory(productId)
                );
        }

    }
}
