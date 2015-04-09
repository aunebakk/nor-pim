using norpim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace norpim.mvc.Controllers {
    public class OrganizeController : Controller {

        [HttpGet]
        public ActionResult Index() {
            return View(
                MVCHelper.ResolveDiv(Request, "Organize", "Index"), 
                new CategorySearchService().CategoryTree()
                );
        }

        [HttpGet]
        public ActionResult IndexChild(Guid productCategoryParentId) {
            ViewData["productCategoryParentId"] = productCategoryParentId;
            
            return View(
                MVCHelper.ResolveDiv(Request, "Organize", "IndexChild"), 
                new CategorySearchService().CategoryTree()
                );
        }

        [HttpGet]
        public ActionResult ProductCategoryImageDetails(Guid productCategoryId) {
            CrudeProductCategoryImageContract contract = new CrudeProductCategoryImageContract();
            
            CrudeProductCategoryImageContract[] contracts = 
                    new CrudeProductCategoryImageService().FetchByProductCategoryId(productCategoryId);

            if (contracts.Length > 0) {
                // get first image
                contract = contracts[0];
            } else { 
                // whatever
            }

            return View(
                MVCHelper.ResolveDiv(Request, "Organize", "ProductCategoryImageDetails"), 
                contract
                );
        }
    }
}