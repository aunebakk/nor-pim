/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:56:35 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductMaintenanceImageIndexWithFilterController : Controller {

        [HttpGet]
        public ActionResult ProductMaintenanceImageIndexWithFilterIndex(System.Guid productId) {

            return View(
                "~/Views/Durian/ProductMaintenanceSearch/ProductMaintenanceImageIndexWithFilterIndex.cshtml",
                new ProductMaintenanceSearchService().ProductMaintenanceImageIndexWithFilter(productId)
                );
        }

    }
}
