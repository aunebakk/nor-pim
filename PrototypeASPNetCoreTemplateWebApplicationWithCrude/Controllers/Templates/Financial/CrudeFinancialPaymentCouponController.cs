/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:38:09 PM
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
    [Route("api/1/crudefinancialpaymentcoupon")]
    public class CrudeFinancialPaymentCouponController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialPaymentCouponHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialPaymentCoupon.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialPaymentCouponModel> CrudeFinancialPaymentCouponFetchAll() {

            List<CrudeFinancialPaymentCouponModel> financialPaymentCoupons = 
                new CrudeFinancialPaymentCouponBusiness().FetchAll();

            return financialPaymentCoupons;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialPaymentCouponFetchAllCount() {

            return new CrudeFinancialPaymentCouponBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialPaymentCouponModel> CrudeFinancialPaymentCouponFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialPaymentCouponModel> financialPaymentCoupons = 
                new CrudeFinancialPaymentCouponBusiness().FetchAllWithLimit(limit);

            return financialPaymentCoupons;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialPaymentCouponModel> CrudeFinancialPaymentCouponFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialPaymentCouponModel> financialPaymentCoupons = 
                new CrudeFinancialPaymentCouponBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialPaymentCoupons;
        }

        [HttpGet("fetchbyfinancialpaymentcouponid/{financialpaymentcouponid?}")]
        public CrudeFinancialPaymentCouponModel CrudeFinancialPaymentCouponFetchByFinancialPaymentCouponId(System.Guid financialpaymentcouponid) {

            CrudeFinancialPaymentCouponModel financialPaymentCoupon = 
                new CrudeFinancialPaymentCouponBusiness().FetchByFinancialPaymentCouponId(financialpaymentcouponid);

            return financialPaymentCoupon;
        }

        [HttpGet("fetchbyfinancialcouponid/{financialcouponid?}")]
        public IEnumerable<CrudeFinancialPaymentCouponModel> CrudeFinancialPaymentCouponFetchByFinancialCouponId(System.Guid financialcouponid) {

            List<CrudeFinancialPaymentCouponModel> financialPaymentCoupon = 
                new CrudeFinancialPaymentCouponBusiness().FetchByFinancialCouponId(financialcouponid);

            return financialPaymentCoupon;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialPaymentCouponModel> CrudeFinancialPaymentCouponFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialPaymentCouponModel> financialPaymentCoupon = 
                new CrudeFinancialPaymentCouponBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialPaymentCoupon;
        }

        [HttpPost("crudefinancialpaymentcouponcreate")]
        public CrudeFinancialPaymentCouponModel CrudeFinancialPaymentCouponCreate([Bind()] CrudeFinancialPaymentCouponModel financialPaymentCoupon) {

            new CrudeFinancialPaymentCouponBusiness().Insert(financialPaymentCoupon);

            return financialPaymentCoupon;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialPaymentCouponCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:38:09 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentCoupon/CrudeFinancialPaymentCouponCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPaymentCoupon/CrudeFinancialPaymentCouponCreate/", content).Result;

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

        [HttpPut("crudefinancialpaymentcouponupdate")]
        public CrudeFinancialPaymentCouponModel CrudeFinancialPaymentCouponUpdate([Bind()] CrudeFinancialPaymentCouponModel financialPaymentCoupon) {

            new CrudeFinancialPaymentCouponBusiness().Update(financialPaymentCoupon);

            return financialPaymentCoupon;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialPaymentCouponUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:38:09 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentCoupon/CrudeFinancialPaymentCouponUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPaymentCoupon/CrudeFinancialPaymentCouponUpdate/", content).Result;

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

        [HttpDelete("financialpaymentcoupondelete/{financialpaymentcouponid?}")]
        public void CrudeFinancialPaymentCouponDelete(System.Guid financialPaymentCouponId) {

            new CrudeFinancialPaymentCouponBusiness().Delete(financialPaymentCouponId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialPaymentCouponDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentCoupon/CrudeFinancialPaymentCouponDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
