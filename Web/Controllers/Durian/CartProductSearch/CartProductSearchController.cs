/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:45:18 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc {
    public class CartProductSearchController : Controller {

        [HttpGet]
        public ActionResult CartProductSearchIndex() {

            return View(
                "~/Views/Durian/CartProductSearch/CartProductSearch.cshtml"
                );
        }

    }
}
