/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 5:56:07 PM
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
