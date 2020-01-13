/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:54:54 PM
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
