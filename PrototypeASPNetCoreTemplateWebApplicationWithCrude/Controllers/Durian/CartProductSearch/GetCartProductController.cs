/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 7:32:08 AM
  Template: sql2x.RESTDurianGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using SolutionNorSolutionPim.BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SolutionNorSolutionPim.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/cartproductsearchservice")]
    public class GetCartProductController : Controller {

        [HttpGet("getcartproduct")]
        public IEnumerable<GetCartProductModel> GetCartProduct() {

            List<GetCartProductModel> durian = 
                new CartProductSearchService().GetCartProduct(Guid.Empty,Guid.Empty,Guid.Empty,Guid.Empty,Guid.Empty);

            return durian;
        }

        [HttpGet("getcartproducttypescript")]
        public IActionResult GetCartProductTypeScript() {

            List<GetCartProductModel> durian = 
                new CartProductSearchService().GetCartProduct(Guid.Empty,Guid.Empty,Guid.Empty,Guid.Empty,Guid.Empty);

            return View(
                "~/Views/Durian/CartProductSearch/GetCartProductIndexTypeScript.cshtml",
                durian
                );
        }

    }
}
