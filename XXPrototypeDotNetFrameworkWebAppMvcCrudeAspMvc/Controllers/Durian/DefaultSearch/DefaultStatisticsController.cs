﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:28:50 PM
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class DefaultStatisticsController : Controller {

        [HttpGet]
        public ActionResult DefaultStatisticsIndex() {

            return View(
                "~/Views/Durian/DefaultSearch/DefaultStatisticsIndex.cshtml",
                new DefaultSearchService().DefaultStatistics()
                );
        }

    }
}