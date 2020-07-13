﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:22:34 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class ProductSearchByCategoryCodeController : Controller {

        [HttpGet]
        public ActionResult ProductSearchByCategoryCodeIndex(System.String productCategoryCode,System.Boolean onParent) {

            return View(
                "~/Views/Durian/ProductSearch/ProductSearchByCategoryCodeIndex.cshtml",
                new ProductSearchService().ProductSearchByCategoryCode(productCategoryCode,onParent)
                );
        }

    }
}