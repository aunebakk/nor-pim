/*  
  SQL2X Generated ASP .NET Core C# REST code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2x.azurewebsites.net/
  Generated Date: 12/7/2017 8:13:10 PM
  Durian: RESTDurianGenerator
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using SolutionNorSolutionPim.BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SolutionNorSolutionPim.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/financial")]
    public class FinancialController : Controller {

        [HttpGet("orderview/{financialorderid?}")]
        public IActionResult OrderView (
            Guid financialorderid
            ) {

            var financialOrder = new CrudeFinancialOrderBusiness ( ).FetchByFinancialOrderId(financialorderid);
            var financialOrderLines = new CrudeFinancialOrderLineBusiness( ).FetchByFinancialOrderId(financialorderid);

            var order = new Tuple<CrudeFinancialOrderModel, List<CrudeFinancialOrderLineModel>>(financialOrder, financialOrderLines);

            return View (
                "~/Views/Financial/FinancialOrderMake.cshtml",
                order
                );
        }

        [HttpGet("ordermake")]
        public IActionResult OrderMake()
        {

            var financialOrder = new CrudeFinancialOrderModel();
            var financialOrderLines = new List<CrudeFinancialOrderLineModel>();

            financialOrder.FinancialOrderId = Guid.NewGuid();

            // client
            CrudeClientModel client = new CrudeClientBusiness().FetchAll()[0];
            financialOrder.ClientId = client.ClientId;

            // address
            CrudeLocationAddressModel address = new CrudeLocationAddressBusiness().FetchAll()[0];
            financialOrder.LocationAddressId = address.LocationAddressId;

            financialOrder.FinancialOrderSourceRcd = FinancialOrderSourceRef.InternalSystem;
            financialOrder.Comment = "Hi there, time is : " + DateTime.UtcNow;

            // currency
            CrudeFinancialCurrencyModel currency = new CrudeFinancialCurrencyBusiness().FetchAll()[0];
            financialOrder.FinancialCurrencyId = currency.FinancialCurrencyId;

            financialOrder.UserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
            financialOrder.DateTime = DateTime.UtcNow;
            new CrudeFinancialOrderBusiness().Insert(financialOrder);

            // order lines
            int line = 0;
            List<CrudeCartProductModel> cart = new CrudeCartProductBusiness().FetchByStateRcd(DefaultStateRef.Created);
            foreach (var cartItem in cart)
            {
                var financialOrderLine = new CrudeFinancialOrderLineModel();
                financialOrderLine.FinancialOrderLineId = Guid.NewGuid();
                financialOrderLine.FinancialOrderId = financialOrder.FinancialOrderId;
                financialOrderLine.ProductId = cartItem.ProductId;
                financialOrderLine.FinancialUnitOfMeasurementRcd = FinancialUnitOfMeasurementRef.Pieces;
                financialOrderLine.QuantityNumber = 1;
                financialOrderLine.Amount = cartItem.Amount;
                financialOrderLine.FinancialCurrencyId = currency.FinancialCurrencyId;
                financialOrderLine.LineNumber = ++line;
                financialOrderLine.Comment = financialOrder.Comment;
                financialOrderLine.UserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                financialOrderLine.DateTime = DateTime.UtcNow;
                financialOrderLines.Add(financialOrderLine);

                // insert new order line
                new CrudeFinancialOrderLineBusiness().Insert(financialOrderLine);

                // inactivate cart 
                cartItem.StateRcd = DefaultStateRef.Invalidated;
                cartItem.UserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
                cartItem.DateTime = DateTime.UtcNow;

                new CrudeCartProductBusiness().Update(cartItem);
            }

            var order = new Tuple<CrudeFinancialOrderModel, List<CrudeFinancialOrderLineModel>>(financialOrder, financialOrderLines);

            return View(
                "~/Views/Financial/FinancialOrderMake.cshtml",
                order
                );
        }
    }
}
