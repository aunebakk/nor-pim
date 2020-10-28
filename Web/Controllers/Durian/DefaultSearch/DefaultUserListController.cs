/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 6:20:15 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultUserListController : Controller {

        [HttpGet]
        public ActionResult DefaultUserListIndex() {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultUserListIndex.cshtml",
                new DefaultSearchService().DefaultUserList()
                );
        }

    }
}
