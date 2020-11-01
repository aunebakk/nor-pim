/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 7:10:53 AM
  From Machine: DESKTOP-9A2DH39
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
