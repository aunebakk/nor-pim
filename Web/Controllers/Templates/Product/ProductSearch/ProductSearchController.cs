/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:06:02 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateWithDurianByTypescriptGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public partial class ProductSearchController : Controller {

        [HttpGet]
        public ActionResult ProductSearchIndex(System.Guid productCategoryId, bool onParent) {

            List<ProductSearchByCategoryContract> productSearch =
                new ProductSearchService().ProductSearchByCategory(productCategoryId, onParent);

            return View(
                "~/Views/Templates/Product/ProductSearch/ProductSearchIndex.cshtml",
                productSearch
                );
        }

    }
}
