﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 7:16:57 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultUserActivityRecentController : Controller {

        [HttpGet]
        public ActionResult DefaultUserActivityRecentIndex(System.Guid defaultUserId) {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultUserActivityRecentIndex.cshtml",
                new DefaultSearchService().DefaultUserActivityRecent(defaultUserId)
                );
        }

    }
}
