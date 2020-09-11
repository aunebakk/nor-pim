/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:46:59 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class GetClientWithFilterController : Controller {

        [HttpGet]
        public ActionResult GetClientWithFilterIndex(System.String lastName,System.String clientTypeRcd) {

            return View(
                "~/Views/Durian/ClientSearch/GetClientWithFilterIndex.cshtml",
                new ClientSearchService().GetClientWithFilter(lastName,clientTypeRcd)
                );
        }

    }
}
