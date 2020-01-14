/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:29:03 AM
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
    [Route("api/1/crudefinancialcoupon")]
    public class CrudeFinancialCouponController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialCouponHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialCoupon.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialCouponModel> CrudeFinancialCouponFetchAll() {

            List<CrudeFinancialCouponModel> financialCoupons = 
                new CrudeFinancialCouponBusiness().FetchAll();

            return financialCoupons;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialCouponFetchAllCount() {

            return new CrudeFinancialCouponBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialCouponModel> CrudeFinancialCouponFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialCouponModel> financialCoupons = 
                new CrudeFinancialCouponBusiness().FetchAllWithLimit(limit);

            return financialCoupons;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialCouponModel> CrudeFinancialCouponFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialCouponModel> financialCoupons = 
                new CrudeFinancialCouponBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialCoupons;
        }

        [HttpGet("fetchbyfinancialcouponid/{financialcouponid?}")]
        public CrudeFinancialCouponModel CrudeFinancialCouponFetchByFinancialCouponId(System.Guid financialcouponid) {

            CrudeFinancialCouponModel financialCoupon = 
                new CrudeFinancialCouponBusiness().FetchByFinancialCouponId(financialcouponid);

            return financialCoupon;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialCouponModel> CrudeFinancialCouponFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialCouponModel> financialCoupon = 
                new CrudeFinancialCouponBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialCoupon;
        }

        [HttpGet("fetchbyfinancialcoupontypercd/{financialcoupontypercd?}")]
        public IEnumerable<CrudeFinancialCouponModel> CrudeFinancialCouponFetchByFinancialCouponTypeRcd(System.String financialcoupontypercd) {

            List<CrudeFinancialCouponModel> financialCoupon = 
                new CrudeFinancialCouponBusiness().FetchByFinancialCouponTypeRcd(financialcoupontypercd);

            return financialCoupon;
        }

        [HttpPost("crudefinancialcouponcreate")]
        public CrudeFinancialCouponModel CrudeFinancialCouponCreate([Bind()] CrudeFinancialCouponModel financialCoupon) {

            new CrudeFinancialCouponBusiness().Insert(financialCoupon);

            return financialCoupon;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialCouponCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "CouponNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ValidFromDateTime" , "1/14/2020 7:29:03 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ValidUntilDateTime" , "1/14/2020 7:29:03 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "CouponDescription" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:29:03 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCouponTypeRcd" , "create" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialCoupon/CrudeFinancialCouponCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialCoupon/CrudeFinancialCouponCreate/", content).Result;

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

        [HttpPut("crudefinancialcouponupdate")]
        public CrudeFinancialCouponModel CrudeFinancialCouponUpdate([Bind()] CrudeFinancialCouponModel financialCoupon) {

            new CrudeFinancialCouponBusiness().Update(financialCoupon);

            return financialCoupon;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialCouponUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "CouponNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ValidFromDateTime" , "1/14/2020 7:29:03 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ValidUntilDateTime" , "1/14/2020 7:29:03 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "CouponDescription" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:29:03 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCouponTypeRcd" , "update" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialCoupon/CrudeFinancialCouponUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialCoupon/CrudeFinancialCouponUpdate/", content).Result;

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

        [HttpDelete("financialcoupondelete/{financialcouponid?}")]
        public void CrudeFinancialCouponDelete(System.Guid financialCouponId) {

            new CrudeFinancialCouponBusiness().Delete(financialCouponId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialCouponDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialCoupon/CrudeFinancialCouponDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
