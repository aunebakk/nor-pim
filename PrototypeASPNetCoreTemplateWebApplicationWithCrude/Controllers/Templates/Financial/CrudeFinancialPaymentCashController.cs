/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:29:04 AM
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
    [Route("api/1/crudefinancialpaymentcash")]
    public class CrudeFinancialPaymentCashController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialPaymentCashHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialPaymentCash.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialPaymentCashModel> CrudeFinancialPaymentCashFetchAll() {

            List<CrudeFinancialPaymentCashModel> financialPaymentCashs = 
                new CrudeFinancialPaymentCashBusiness().FetchAll();

            return financialPaymentCashs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialPaymentCashFetchAllCount() {

            return new CrudeFinancialPaymentCashBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialPaymentCashModel> CrudeFinancialPaymentCashFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialPaymentCashModel> financialPaymentCashs = 
                new CrudeFinancialPaymentCashBusiness().FetchAllWithLimit(limit);

            return financialPaymentCashs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialPaymentCashModel> CrudeFinancialPaymentCashFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialPaymentCashModel> financialPaymentCashs = 
                new CrudeFinancialPaymentCashBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialPaymentCashs;
        }

        [HttpGet("fetchbyfinancialpaymentcashid/{financialpaymentcashid?}")]
        public CrudeFinancialPaymentCashModel CrudeFinancialPaymentCashFetchByFinancialPaymentCashId(System.Guid financialpaymentcashid) {

            CrudeFinancialPaymentCashModel financialPaymentCash = 
                new CrudeFinancialPaymentCashBusiness().FetchByFinancialPaymentCashId(financialpaymentcashid);

            return financialPaymentCash;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialPaymentCashModel> CrudeFinancialPaymentCashFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialPaymentCashModel> financialPaymentCash = 
                new CrudeFinancialPaymentCashBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialPaymentCash;
        }

        [HttpPost("crudefinancialpaymentcashcreate")]
        public CrudeFinancialPaymentCashModel CrudeFinancialPaymentCashCreate([Bind()] CrudeFinancialPaymentCashModel financialPaymentCash) {

            new CrudeFinancialPaymentCashBusiness().Insert(financialPaymentCash);

            return financialPaymentCash;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialPaymentCashCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:29:04 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentCash/CrudeFinancialPaymentCashCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPaymentCash/CrudeFinancialPaymentCashCreate/", content).Result;

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

        [HttpPut("crudefinancialpaymentcashupdate")]
        public CrudeFinancialPaymentCashModel CrudeFinancialPaymentCashUpdate([Bind()] CrudeFinancialPaymentCashModel financialPaymentCash) {

            new CrudeFinancialPaymentCashBusiness().Update(financialPaymentCash);

            return financialPaymentCash;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialPaymentCashUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:29:04 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentCash/CrudeFinancialPaymentCashUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPaymentCash/CrudeFinancialPaymentCashUpdate/", content).Result;

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

        [HttpDelete("financialpaymentcashdelete/{financialpaymentcashid?}")]
        public void CrudeFinancialPaymentCashDelete(System.Guid financialPaymentCashId) {

            new CrudeFinancialPaymentCashBusiness().Delete(financialPaymentCashId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialPaymentCashDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentCash/CrudeFinancialPaymentCashDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
