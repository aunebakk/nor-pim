/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:50:18 AM
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
    [Route("api/1/crudefinancialtax")]
    public class CrudeFinancialTaxController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialTaxHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialTax.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialTaxModel> CrudeFinancialTaxFetchAll() {

            List<CrudeFinancialTaxModel> financialTaxs = 
                new CrudeFinancialTaxBusiness().FetchAll();

            return financialTaxs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialTaxFetchAllCount() {

            return new CrudeFinancialTaxBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialTaxModel> CrudeFinancialTaxFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialTaxModel> financialTaxs = 
                new CrudeFinancialTaxBusiness().FetchAllWithLimit(limit);

            return financialTaxs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialTaxModel> CrudeFinancialTaxFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialTaxModel> financialTaxs = 
                new CrudeFinancialTaxBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialTaxs;
        }

        [HttpGet("fetchbyfinancialtaxid/{financialtaxid?}")]
        public CrudeFinancialTaxModel CrudeFinancialTaxFetchByFinancialTaxId(System.Guid financialtaxid) {

            CrudeFinancialTaxModel financialTax = 
                new CrudeFinancialTaxBusiness().FetchByFinancialTaxId(financialtaxid);

            return financialTax;
        }

        [HttpGet("fetchbyfinancialtaxtypercd/{financialtaxtypercd?}")]
        public IEnumerable<CrudeFinancialTaxModel> CrudeFinancialTaxFetchByFinancialTaxTypeRcd(System.String financialtaxtypercd) {

            List<CrudeFinancialTaxModel> financialTax = 
                new CrudeFinancialTaxBusiness().FetchByFinancialTaxTypeRcd(financialtaxtypercd);

            return financialTax;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialTaxModel> CrudeFinancialTaxFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialTaxModel> financialTax = 
                new CrudeFinancialTaxBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialTax;
        }

        [HttpPost("crudefinancialtaxcreate")]
        public CrudeFinancialTaxModel CrudeFinancialTaxCreate([Bind()] CrudeFinancialTaxModel financialTax) {

            new CrudeFinancialTaxBusiness().Insert(financialTax);

            return financialTax;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialTaxCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialTaxTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/23/2020 11:50:18 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialTax/CrudeFinancialTaxCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialTax/CrudeFinancialTaxCreate/", content).Result;

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

        [HttpPut("crudefinancialtaxupdate")]
        public CrudeFinancialTaxModel CrudeFinancialTaxUpdate([Bind()] CrudeFinancialTaxModel financialTax) {

            new CrudeFinancialTaxBusiness().Update(financialTax);

            return financialTax;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialTaxUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialTaxTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/23/2020 11:50:18 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialTax/CrudeFinancialTaxUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialTax/CrudeFinancialTaxUpdate/", content).Result;

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

        [HttpDelete("financialtaxdelete/{financialtaxid?}")]
        public void CrudeFinancialTaxDelete(System.Guid financialTaxId) {

            new CrudeFinancialTaxBusiness().Delete(financialTaxId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialTaxDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialTax/CrudeFinancialTaxDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
