/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:51:16 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductMaintenanceIndexController : Controller {

        [HttpGet]
        public ActionResult ProductMaintenanceIndexIndex() {

            return View(
                "~/Views/Durian/ProductMaintenanceSearch/ProductMaintenanceIndexIndex.cshtml",
                new ProductMaintenanceSearchService().ProductMaintenanceIndex()
                );
        }

    }
}
