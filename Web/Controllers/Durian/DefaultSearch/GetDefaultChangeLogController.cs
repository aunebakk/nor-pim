/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 5:57:12 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class GetDefaultChangeLogController : Controller {

        [HttpGet]
        public ActionResult GetDefaultChangeLogIndex(System.String defaultChangeName,System.String defaultChangeLogTypeRcd,System.Guid defaultIssueId,System.Guid defaultChangeLogId) {

            return View(
                "~/Views/Durian/DefaultSearch/GetDefaultChangeLogIndex.cshtml",
                new DefaultSearchService().GetDefaultChangeLog(defaultChangeName,defaultChangeLogTypeRcd,defaultIssueId,defaultChangeLogId)
                );
        }

    }
}
