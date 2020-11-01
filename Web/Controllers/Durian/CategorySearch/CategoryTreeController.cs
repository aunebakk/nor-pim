/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 4:20:33 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class CategoryTreeController : Controller {

        [HttpGet]
        public ActionResult CategoryTreeIndex() {

            return View(
                "~/Views/Durian/CategorySearch/CategoryTreeIndex.cshtml",
                new CategorySearchService().CategoryTree()
                );
        }

    }
}
