/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2x.azurewebsites.net/
  Generated Date: 2/21/2019 6:07:23 AM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductSearchByCategoryLiveController : Controller {

        [HttpGet]
        public ActionResult ProductSearchByCategoryIndex(System.Guid productCategoryId,System.Boolean onParent) {

            return View(
                "~/Views/DurianLive/ProductSearch/ProductSearchByCategoryIndex.cshtml",
                new ProductSearchServiceClient().ProductSearchByCategory(productCategoryId,onParent)
                );
        }

    }
}
