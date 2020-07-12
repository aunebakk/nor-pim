/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/12/2020 10:48:27 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.MVCDurianGenerator.MethodControllerCode
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPim.AspMvc.Controllers {
    public class GetFinancialOrderController : Controller {

        [HttpGet]
        public ActionResult GetFinancialOrderIndex(System.Guid clientId,System.Guid financialCurrencyId,System.Guid locationAddressId,System.String financialOrderSourceRcd,System.Guid userId,System.Guid financialOrderId) {

            return View(
                "~/Views/Durian/FinancialOrderSearch/GetFinancialOrderIndex.cshtml",
                new FinancialOrderSearchService().GetFinancialOrder(clientId,financialCurrencyId,locationAddressId,financialOrderSourceRcd,userId,financialOrderId)
                );
        }

    }
}
