/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:38:53 AM
  Template: sql2x.RESTDurianGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using SolutionNorSolutionPim.BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SolutionNorSolutionPim.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/financialordersearchservice")]
    public class GetFinancialOrderController : Controller {

        [HttpGet("getfinancialorder")]
        public IEnumerable<GetFinancialOrderModel> GetFinancialOrder() {

            List<GetFinancialOrderModel> durian = 
                new FinancialOrderSearchService().GetFinancialOrder(Guid.Empty,Guid.Empty,Guid.Empty,String.Empty,Guid.Empty,Guid.Empty);

            return durian;
        }

        [HttpGet("getfinancialordertypescript")]
        public IActionResult GetFinancialOrderTypeScript() {

            List<GetFinancialOrderModel> durian = 
                new FinancialOrderSearchService().GetFinancialOrder(Guid.Empty,Guid.Empty,Guid.Empty,String.Empty,Guid.Empty,Guid.Empty);

            return View(
                "~/Views/Durian/FinancialOrderSearch/GetFinancialOrderIndexTypeScript.cshtml",
                durian
                );
        }

    }
}
