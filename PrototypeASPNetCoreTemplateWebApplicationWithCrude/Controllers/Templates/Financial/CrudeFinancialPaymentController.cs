/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:45:49 AM
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
    [Route("api/1/crudefinancialpayment")]
    public class CrudeFinancialPaymentController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialPaymentHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialPayment.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialPaymentModel> CrudeFinancialPaymentFetchAll() {

            List<CrudeFinancialPaymentModel> financialPayments = 
                new CrudeFinancialPaymentBusiness().FetchAll();

            return financialPayments;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialPaymentFetchAllCount() {

            return new CrudeFinancialPaymentBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialPaymentModel> CrudeFinancialPaymentFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialPaymentModel> financialPayments = 
                new CrudeFinancialPaymentBusiness().FetchAllWithLimit(limit);

            return financialPayments;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialPaymentModel> CrudeFinancialPaymentFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialPaymentModel> financialPayments = 
                new CrudeFinancialPaymentBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialPayments;
        }

        [HttpGet("fetchbyfinancialpaymentid/{financialpaymentid?}")]
        public CrudeFinancialPaymentModel CrudeFinancialPaymentFetchByFinancialPaymentId(System.Guid financialpaymentid) {

            CrudeFinancialPaymentModel financialPayment = 
                new CrudeFinancialPaymentBusiness().FetchByFinancialPaymentId(financialpaymentid);

            return financialPayment;
        }

        [HttpGet("fetchbyfinancialpaymenttypercd/{financialpaymenttypercd?}")]
        public IEnumerable<CrudeFinancialPaymentModel> CrudeFinancialPaymentFetchByFinancialPaymentTypeRcd(System.String financialpaymenttypercd) {

            List<CrudeFinancialPaymentModel> financialPayment = 
                new CrudeFinancialPaymentBusiness().FetchByFinancialPaymentTypeRcd(financialpaymenttypercd);

            return financialPayment;
        }

        [HttpGet("fetchbyfinancialpaymentaccountingid/{financialpaymentaccountingid?}")]
        public IEnumerable<CrudeFinancialPaymentModel> CrudeFinancialPaymentFetchByFinancialPaymentAccountingId(System.Guid financialpaymentaccountingid) {

            List<CrudeFinancialPaymentModel> financialPayment = 
                new CrudeFinancialPaymentBusiness().FetchByFinancialPaymentAccountingId(financialpaymentaccountingid);

            return financialPayment;
        }

        [HttpGet("fetchbyfinancialpaymentbankid/{financialpaymentbankid?}")]
        public IEnumerable<CrudeFinancialPaymentModel> CrudeFinancialPaymentFetchByFinancialPaymentBankId(System.Guid financialpaymentbankid) {

            List<CrudeFinancialPaymentModel> financialPayment = 
                new CrudeFinancialPaymentBusiness().FetchByFinancialPaymentBankId(financialpaymentbankid);

            return financialPayment;
        }

        [HttpGet("fetchbyfinancialpaymentvoucherid/{financialpaymentvoucherid?}")]
        public IEnumerable<CrudeFinancialPaymentModel> CrudeFinancialPaymentFetchByFinancialPaymentVoucherId(System.Guid financialpaymentvoucherid) {

            List<CrudeFinancialPaymentModel> financialPayment = 
                new CrudeFinancialPaymentBusiness().FetchByFinancialPaymentVoucherId(financialpaymentvoucherid);

            return financialPayment;
        }

        [HttpGet("fetchbyfinancialpaymentcardid/{financialpaymentcardid?}")]
        public IEnumerable<CrudeFinancialPaymentModel> CrudeFinancialPaymentFetchByFinancialPaymentCardId(System.Guid financialpaymentcardid) {

            List<CrudeFinancialPaymentModel> financialPayment = 
                new CrudeFinancialPaymentBusiness().FetchByFinancialPaymentCardId(financialpaymentcardid);

            return financialPayment;
        }

        [HttpGet("fetchbyfinancialpaymentcashid/{financialpaymentcashid?}")]
        public IEnumerable<CrudeFinancialPaymentModel> CrudeFinancialPaymentFetchByFinancialPaymentCashId(System.Guid financialpaymentcashid) {

            List<CrudeFinancialPaymentModel> financialPayment = 
                new CrudeFinancialPaymentBusiness().FetchByFinancialPaymentCashId(financialpaymentcashid);

            return financialPayment;
        }

        [HttpGet("fetchbyfinancialpaymentcouponid/{financialpaymentcouponid?}")]
        public IEnumerable<CrudeFinancialPaymentModel> CrudeFinancialPaymentFetchByFinancialPaymentCouponId(System.Guid financialpaymentcouponid) {

            List<CrudeFinancialPaymentModel> financialPayment = 
                new CrudeFinancialPaymentBusiness().FetchByFinancialPaymentCouponId(financialpaymentcouponid);

            return financialPayment;
        }

        [HttpPost("crudefinancialpaymentcreate")]
        public CrudeFinancialPaymentModel CrudeFinancialPaymentCreate([Bind()] CrudeFinancialPaymentModel financialPayment) {

            new CrudeFinancialPaymentBusiness().Insert(financialPayment);

            return financialPayment;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialPaymentCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialPaymentTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:49 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialPayment/CrudeFinancialPaymentCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPayment/CrudeFinancialPaymentCreate/", content).Result;

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

        [HttpPut("crudefinancialpaymentupdate")]
        public CrudeFinancialPaymentModel CrudeFinancialPaymentUpdate([Bind()] CrudeFinancialPaymentModel financialPayment) {

            new CrudeFinancialPaymentBusiness().Update(financialPayment);

            return financialPayment;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialPaymentUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialPaymentTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:49 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialPayment/CrudeFinancialPaymentUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPayment/CrudeFinancialPaymentUpdate/", content).Result;

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

        [HttpDelete("financialpaymentdelete/{financialpaymentid?}")]
        public void CrudeFinancialPaymentDelete(System.Guid financialPaymentId) {

            new CrudeFinancialPaymentBusiness().Delete(financialPaymentId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialPaymentDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialPayment/CrudeFinancialPaymentDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
