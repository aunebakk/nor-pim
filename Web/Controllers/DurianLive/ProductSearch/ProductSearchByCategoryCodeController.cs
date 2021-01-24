/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2x.azurewebsites.net/
  Generated Date: 2/21/2019 6:07:28 AM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductSearchByCategoryCodeLiveController : Controller {

        [HttpGet]
        public ActionResult ProductSearchByCategoryCodeIndex(System.String productCategoryCode,System.Boolean onParent) {

            return View(
                "~/Views/DurianLive/ProductSearch/ProductSearchByCategoryCodeIndex.cshtml",
                new ProductSearchServiceClient().ProductSearchByCategoryCode(productCategoryCode,onParent)
                );
        }

    }
}
