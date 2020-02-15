/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:22 AM
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
    [Route("api/1/crudefinancialpaymentaccounting")]
    public class CrudeFinancialPaymentAccountingController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialPaymentAccountingHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialPaymentAccounting.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialPaymentAccountingModel> CrudeFinancialPaymentAccountingFetchAll() {

            List<CrudeFinancialPaymentAccountingModel> financialPaymentAccountings = 
                new CrudeFinancialPaymentAccountingBusiness().FetchAll();

            return financialPaymentAccountings;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialPaymentAccountingFetchAllCount() {

            return new CrudeFinancialPaymentAccountingBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialPaymentAccountingModel> CrudeFinancialPaymentAccountingFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialPaymentAccountingModel> financialPaymentAccountings = 
                new CrudeFinancialPaymentAccountingBusiness().FetchAllWithLimit(limit);

            return financialPaymentAccountings;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialPaymentAccountingModel> CrudeFinancialPaymentAccountingFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialPaymentAccountingModel> financialPaymentAccountings = 
                new CrudeFinancialPaymentAccountingBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialPaymentAccountings;
        }

        [HttpGet("fetchbyfinancialpaymentaccountingid/{financialpaymentaccountingid?}")]
        public CrudeFinancialPaymentAccountingModel CrudeFinancialPaymentAccountingFetchByFinancialPaymentAccountingId(System.Guid financialpaymentaccountingid) {

            CrudeFinancialPaymentAccountingModel financialPaymentAccounting = 
                new CrudeFinancialPaymentAccountingBusiness().FetchByFinancialPaymentAccountingId(financialpaymentaccountingid);

            return financialPaymentAccounting;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialPaymentAccountingModel> CrudeFinancialPaymentAccountingFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialPaymentAccountingModel> financialPaymentAccounting = 
                new CrudeFinancialPaymentAccountingBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialPaymentAccounting;
        }

        [HttpPost("crudefinancialpaymentaccountingcreate")]
        public CrudeFinancialPaymentAccountingModel CrudeFinancialPaymentAccountingCreate([Bind()] CrudeFinancialPaymentAccountingModel financialPaymentAccounting) {

            new CrudeFinancialPaymentAccountingBusiness().Insert(financialPaymentAccounting);

            return financialPaymentAccounting;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialPaymentAccountingCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:22 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingCreate/", content).Result;

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

        [HttpPut("crudefinancialpaymentaccountingupdate")]
        public CrudeFinancialPaymentAccountingModel CrudeFinancialPaymentAccountingUpdate([Bind()] CrudeFinancialPaymentAccountingModel financialPaymentAccounting) {

            new CrudeFinancialPaymentAccountingBusiness().Update(financialPaymentAccounting);

            return financialPaymentAccounting;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialPaymentAccountingUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:22 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingUpdate/", content).Result;

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

        [HttpDelete("financialpaymentaccountingdelete/{financialpaymentaccountingid?}")]
        public void CrudeFinancialPaymentAccountingDelete(System.Guid financialPaymentAccountingId) {

            new CrudeFinancialPaymentAccountingBusiness().Delete(financialPaymentAccountingId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialPaymentAccountingDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentAccounting/CrudeFinancialPaymentAccountingDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
