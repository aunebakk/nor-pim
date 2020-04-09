/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:26:50 AM
  Template: sql2x.TemplateDotNetCoreApiGenerator.ControllerBeginning
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using SolutionNorSolutionPim.BusinessLogicLayer.Models;
using System.Collections.Generic;
using System.Net.Http;
using System;
using Microsoft.AspNetCore.Mvc;

namespace SolutionNorSolutionPim.BusinessLogicLayer.Controllers {
    [Produces("application/json")]
    [Route("api/1/crudefinancialorder")]
    public class CrudeFinancialOrderController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialOrderHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialOrder.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialOrderModel> CrudeFinancialOrderFetchAll() {

            List<CrudeFinancialOrderModel> financialOrders = 
                new CrudeFinancialOrderBusiness().FetchAll();

            return financialOrders;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialOrderFetchAllCount() {

            return new CrudeFinancialOrderBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialOrderModel> CrudeFinancialOrderFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialOrderModel> financialOrders = 
                new CrudeFinancialOrderBusiness().FetchAllWithLimit(limit);

            return financialOrders;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialOrderModel> CrudeFinancialOrderFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialOrderModel> financialOrders = 
                new CrudeFinancialOrderBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialOrders;
        }

        [HttpGet("fetchbyfinancialorderid/{financialorderid?}")]
        public CrudeFinancialOrderModel CrudeFinancialOrderFetchByFinancialOrderId(System.Guid financialorderid) {

            CrudeFinancialOrderModel financialOrder = 
                new CrudeFinancialOrderBusiness().FetchByFinancialOrderId(financialorderid);

            return financialOrder;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialOrderModel> CrudeFinancialOrderFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialOrderModel> financialOrder = 
                new CrudeFinancialOrderBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialOrder;
        }

        [HttpGet("fetchbyfinancialordersourcercd/{financialordersourcercd?}")]
        public IEnumerable<CrudeFinancialOrderModel> CrudeFinancialOrderFetchByFinancialOrderSourceRcd(System.String financialordersourcercd) {

            List<CrudeFinancialOrderModel> financialOrder = 
                new CrudeFinancialOrderBusiness().FetchByFinancialOrderSourceRcd(financialordersourcercd);

            return financialOrder;
        }

        [HttpGet("fetchbyclientid/{clientid?}")]
        public IEnumerable<CrudeFinancialOrderModel> CrudeFinancialOrderFetchByClientId(System.Guid clientid) {

            List<CrudeFinancialOrderModel> financialOrder = 
                new CrudeFinancialOrderBusiness().FetchByClientId(clientid);

            return financialOrder;
        }

        [HttpPost("crudefinancialordercreate")]
        public CrudeFinancialOrderModel CrudeFinancialOrderCreate([Bind()] CrudeFinancialOrderModel financialOrder) {

            new CrudeFinancialOrderBusiness().Insert(financialOrder);

            return financialOrder;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialOrderCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/9/2020 7:26:50 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderSourceRcd" , "create" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrder/CrudeFinancialOrderCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrder/CrudeFinancialOrderCreate/", content).Result;

                // read/return reply
                if ( response.IsSuccessStatusCode )
                    result = response.Content.ReadAsStringAsync ().GetAwaiter ().GetResult ();
                else
                    result = response.ReasonPhrase;
            } catch ( System.Exception ex ) {
                result = "Exception: " + ex.Message;
            }

            return result;
        }

        [HttpPut("crudefinancialorderupdate")]
        public CrudeFinancialOrderModel CrudeFinancialOrderUpdate([Bind()] CrudeFinancialOrderModel financialOrder) {

            new CrudeFinancialOrderBusiness().Update(financialOrder);

            return financialOrder;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialOrderUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/9/2020 7:26:50 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderSourceRcd" , "update" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrder/CrudeFinancialOrderUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrder/CrudeFinancialOrderUpdate/", content).Result;

                // read/return reply
                if ( response.IsSuccessStatusCode )
                    result = response.Content.ReadAsStringAsync ().GetAwaiter ().GetResult ();
                else
                    result = response.ReasonPhrase;
            } catch ( System.Exception ex ) {
                result = "Exception: " + ex.Message;
            }

            return result;
        }

        [HttpDelete("financialorderdelete/{financialorderid?}")]
        public void CrudeFinancialOrderDelete(System.Guid financialOrderId) {

            new CrudeFinancialOrderBusiness().Delete(financialOrderId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialOrderDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrder/CrudeFinancialOrderDelete/00000000-0000-0000-0000-000000000001" ).Result;

                // read/return reply
                if ( response.IsSuccessStatusCode )
                    result = response.Content.ReadAsStringAsync ().GetAwaiter ().GetResult ();
                else
                    result = response.ReasonPhrase;
            } catch ( System.Exception ex ) {
                result = "Exception: " + ex.Message;
            }

            return result;
        }

    }
}
