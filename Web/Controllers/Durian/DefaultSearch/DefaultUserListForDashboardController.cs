﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 7:05:36 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultUserListForDashboardController : Controller {

        [HttpGet]
        public ActionResult DefaultUserListForDashboardIndex() {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultUserListForDashboardIndex.cshtml",
                new DefaultSearchService().DefaultUserListForDashboard()
                );
        }

    }
}
