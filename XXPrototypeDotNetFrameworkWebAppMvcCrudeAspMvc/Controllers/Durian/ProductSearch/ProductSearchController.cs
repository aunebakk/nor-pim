﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:38:17 AM
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc {
    public class ProductSearchController : Controller {

        [HttpGet]
        public ActionResult ProductSearchIndex() {

            return View(
                "~/Views/Durian/ProductSearch/ProductSearch.cshtml"
                );
        }

    }
}
