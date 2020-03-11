/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:27:32 PM
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
    [Route("api/1/crudefinancialcurrency")]
    public class CrudeFinancialCurrencyController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialCurrencyHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialCurrency.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialCurrencyModel> CrudeFinancialCurrencyFetchAll() {

            List<CrudeFinancialCurrencyModel> financialCurrencys = 
                new CrudeFinancialCurrencyBusiness().FetchAll();

            return financialCurrencys;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialCurrencyFetchAllCount() {

            return new CrudeFinancialCurrencyBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialCurrencyModel> CrudeFinancialCurrencyFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialCurrencyModel> financialCurrencys = 
                new CrudeFinancialCurrencyBusiness().FetchAllWithLimit(limit);

            return financialCurrencys;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialCurrencyModel> CrudeFinancialCurrencyFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialCurrencyModel> financialCurrencys = 
                new CrudeFinancialCurrencyBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialCurrencys;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public CrudeFinancialCurrencyModel CrudeFinancialCurrencyFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            CrudeFinancialCurrencyModel financialCurrency = 
                new CrudeFinancialCurrencyBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialCurrency;
        }

        [HttpGet("fetchbyfinancialcurrencytypename/{financialcurrencytypename?}")]
        public CrudeFinancialCurrencyModel CrudeFinancialCurrencyFetchByFinancialCurrencyTypeName(System.String financialcurrencytypename) {

            CrudeFinancialCurrencyModel financialCurrency = 
                new CrudeFinancialCurrencyBusiness().FetchByFinancialCurrencyTypeName(financialcurrencytypename);

            return financialCurrency;
        }

        [HttpGet("fetchbyfinancialcurrencytypercd/{financialcurrencytypercd?}")]
        public IEnumerable<CrudeFinancialCurrencyModel> CrudeFinancialCurrencyFetchByFinancialCurrencyTypeRcd(System.String financialcurrencytypercd) {

            List<CrudeFinancialCurrencyModel> financialCurrency = 
                new CrudeFinancialCurrencyBusiness().FetchByFinancialCurrencyTypeRcd(financialcurrencytypercd);

            return financialCurrency;
        }

        [HttpGet("fetchbyfinancialcurrencyagainstfinancialcurrencytypercd/{financialcurrencyagainstfinancialcurrencytypercd?}")]
        public IEnumerable<CrudeFinancialCurrencyModel> CrudeFinancialCurrencyFetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(System.String financialcurrencyagainstfinancialcurrencytypercd) {

            List<CrudeFinancialCurrencyModel> financialCurrency = 
                new CrudeFinancialCurrencyBusiness().FetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(financialcurrencyagainstfinancialcurrencytypercd);

            return financialCurrency;
        }

        [HttpPost("crudefinancialcurrencycreate")]
        public CrudeFinancialCurrencyModel CrudeFinancialCurrencyCreate([Bind()] CrudeFinancialCurrencyModel financialCurrency) {

            new CrudeFinancialCurrencyBusiness().Insert(financialCurrency);

            return financialCurrency;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialCurrencyCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCurrencyTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCurrencyAgainstFinancialCurrencyTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 9:27:32 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ValidFromDateTime" , "3/11/2020 9:27:32 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ValidUntilDateTime" , "3/11/2020 9:27:32 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DecimalCount" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCurrencyTypeCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCurrencyTypeName" , "create" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialCurrency/CrudeFinancialCurrencyCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialCurrency/CrudeFinancialCurrencyCreate/", content).Result;

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

        [HttpPut("crudefinancialcurrencyupdate")]
        public CrudeFinancialCurrencyModel CrudeFinancialCurrencyUpdate([Bind()] CrudeFinancialCurrencyModel financialCurrency) {

            new CrudeFinancialCurrencyBusiness().Update(financialCurrency);

            return financialCurrency;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialCurrencyUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCurrencyTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCurrencyAgainstFinancialCurrencyTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 9:27:32 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ValidFromDateTime" , "3/11/2020 9:27:32 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ValidUntilDateTime" , "3/11/2020 9:27:32 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DecimalCount" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCurrencyTypeCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCurrencyTypeName" , "update" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialCurrency/CrudeFinancialCurrencyUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialCurrency/CrudeFinancialCurrencyUpdate/", content).Result;

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

        [HttpDelete("financialcurrencydelete/{financialcurrencyid?}")]
        public void CrudeFinancialCurrencyDelete(System.Guid financialCurrencyId) {

            new CrudeFinancialCurrencyBusiness().Delete(financialCurrencyId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialCurrencyDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialCurrency/CrudeFinancialCurrencyDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
