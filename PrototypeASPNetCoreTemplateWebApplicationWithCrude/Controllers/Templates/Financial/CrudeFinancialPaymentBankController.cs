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
    [Route("api/1/crudefinancialpaymentbank")]
    public class CrudeFinancialPaymentBankController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialPaymentBankHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialPaymentBank.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialPaymentBankModel> CrudeFinancialPaymentBankFetchAll() {

            List<CrudeFinancialPaymentBankModel> financialPaymentBanks = 
                new CrudeFinancialPaymentBankBusiness().FetchAll();

            return financialPaymentBanks;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialPaymentBankFetchAllCount() {

            return new CrudeFinancialPaymentBankBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialPaymentBankModel> CrudeFinancialPaymentBankFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialPaymentBankModel> financialPaymentBanks = 
                new CrudeFinancialPaymentBankBusiness().FetchAllWithLimit(limit);

            return financialPaymentBanks;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialPaymentBankModel> CrudeFinancialPaymentBankFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialPaymentBankModel> financialPaymentBanks = 
                new CrudeFinancialPaymentBankBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialPaymentBanks;
        }

        [HttpGet("fetchbyfinancialpaymentbankid/{financialpaymentbankid?}")]
        public CrudeFinancialPaymentBankModel CrudeFinancialPaymentBankFetchByFinancialPaymentBankId(System.Guid financialpaymentbankid) {

            CrudeFinancialPaymentBankModel financialPaymentBank = 
                new CrudeFinancialPaymentBankBusiness().FetchByFinancialPaymentBankId(financialpaymentbankid);

            return financialPaymentBank;
        }

        [HttpGet("fetchbybankname/{bankname?}")]
        public CrudeFinancialPaymentBankModel CrudeFinancialPaymentBankFetchByBankName(System.String bankname) {

            CrudeFinancialPaymentBankModel financialPaymentBank = 
                new CrudeFinancialPaymentBankBusiness().FetchByBankName(bankname);

            return financialPaymentBank;
        }

        [HttpGet("fetchbyfinancialbankaccountnumbertypercd/{financialbankaccountnumbertypercd?}")]
        public IEnumerable<CrudeFinancialPaymentBankModel> CrudeFinancialPaymentBankFetchByFinancialBankAccountNumberTypeRcd(System.String financialbankaccountnumbertypercd) {

            List<CrudeFinancialPaymentBankModel> financialPaymentBank = 
                new CrudeFinancialPaymentBankBusiness().FetchByFinancialBankAccountNumberTypeRcd(financialbankaccountnumbertypercd);

            return financialPaymentBank;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialPaymentBankModel> CrudeFinancialPaymentBankFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialPaymentBankModel> financialPaymentBank = 
                new CrudeFinancialPaymentBankBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialPaymentBank;
        }

        [HttpPost("crudefinancialpaymentbankcreate")]
        public CrudeFinancialPaymentBankModel CrudeFinancialPaymentBankCreate([Bind()] CrudeFinancialPaymentBankModel financialPaymentBank) {

            new CrudeFinancialPaymentBankBusiness().Insert(financialPaymentBank);

            return financialPaymentBank;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialPaymentBankCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:22 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BankName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BankAccount" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BankNumber" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialBankAccountNumberTypeRcd" , "create" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentBank/CrudeFinancialPaymentBankCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPaymentBank/CrudeFinancialPaymentBankCreate/", content).Result;

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

        [HttpPut("crudefinancialpaymentbankupdate")]
        public CrudeFinancialPaymentBankModel CrudeFinancialPaymentBankUpdate([Bind()] CrudeFinancialPaymentBankModel financialPaymentBank) {

            new CrudeFinancialPaymentBankBusiness().Update(financialPaymentBank);

            return financialPaymentBank;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialPaymentBankUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:22 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BankName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BankAccount" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BankNumber" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialBankAccountNumberTypeRcd" , "update" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentBank/CrudeFinancialPaymentBankUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPaymentBank/CrudeFinancialPaymentBankUpdate/", content).Result;

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

        [HttpDelete("financialpaymentbankdelete/{financialpaymentbankid?}")]
        public void CrudeFinancialPaymentBankDelete(System.Guid financialPaymentBankId) {

            new CrudeFinancialPaymentBankBusiness().Delete(financialPaymentBankId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialPaymentBankDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentBank/CrudeFinancialPaymentBankDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
