/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:26:18 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductSearchByIdController : Controller {

        [HttpGet]
        public ActionResult ProductSearchByIdIndex(System.Guid productId) {

            return View(
                "~/Views/Durian/ProductSearch/ProductSearchByIdIndex.cshtml",
                new ProductSearchService().ProductSearchById(productId)
                );
        }

    }
}
