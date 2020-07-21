/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:58:22 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateWithDurianByTypescriptGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public partial class ProductSearchController : Controller {

        [HttpGet]
        public ActionResult ProductSearchIndex(System.Guid productCategoryId,System.Boolean onParent) {

            List<ProductSearchByCategoryContract> productSearch = 
                new ProductSearchService().ProductSearchByCategory(productCategoryId,onParent);

            return View(
                "~/Views/Templates/Product/ProductSearch/ProductSearchIndex.cshtml",
                productSearch
                );
        }

    }
}
