/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:37:58 AM
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
    [Route("api/1/crudefinancialpaymentvoucher")]
    public class CrudeFinancialPaymentVoucherController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialPaymentVoucherHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialPaymentVoucher.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialPaymentVoucherModel> CrudeFinancialPaymentVoucherFetchAll() {

            List<CrudeFinancialPaymentVoucherModel> financialPaymentVouchers = 
                new CrudeFinancialPaymentVoucherBusiness().FetchAll();

            return financialPaymentVouchers;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialPaymentVoucherFetchAllCount() {

            return new CrudeFinancialPaymentVoucherBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialPaymentVoucherModel> CrudeFinancialPaymentVoucherFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialPaymentVoucherModel> financialPaymentVouchers = 
                new CrudeFinancialPaymentVoucherBusiness().FetchAllWithLimit(limit);

            return financialPaymentVouchers;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialPaymentVoucherModel> CrudeFinancialPaymentVoucherFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialPaymentVoucherModel> financialPaymentVouchers = 
                new CrudeFinancialPaymentVoucherBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialPaymentVouchers;
        }

        [HttpGet("fetchbyfinancialpaymentvoucherid/{financialpaymentvoucherid?}")]
        public CrudeFinancialPaymentVoucherModel CrudeFinancialPaymentVoucherFetchByFinancialPaymentVoucherId(System.Guid financialpaymentvoucherid) {

            CrudeFinancialPaymentVoucherModel financialPaymentVoucher = 
                new CrudeFinancialPaymentVoucherBusiness().FetchByFinancialPaymentVoucherId(financialpaymentvoucherid);

            return financialPaymentVoucher;
        }

        [HttpGet("fetchbyfinancialvoucherid/{financialvoucherid?}")]
        public IEnumerable<CrudeFinancialPaymentVoucherModel> CrudeFinancialPaymentVoucherFetchByFinancialVoucherId(System.Guid financialvoucherid) {

            List<CrudeFinancialPaymentVoucherModel> financialPaymentVoucher = 
                new CrudeFinancialPaymentVoucherBusiness().FetchByFinancialVoucherId(financialvoucherid);

            return financialPaymentVoucher;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialPaymentVoucherModel> CrudeFinancialPaymentVoucherFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialPaymentVoucherModel> financialPaymentVoucher = 
                new CrudeFinancialPaymentVoucherBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialPaymentVoucher;
        }

        [HttpPost("crudefinancialpaymentvouchercreate")]
        public CrudeFinancialPaymentVoucherModel CrudeFinancialPaymentVoucherCreate([Bind()] CrudeFinancialPaymentVoucherModel financialPaymentVoucher) {

            new CrudeFinancialPaymentVoucherBusiness().Insert(financialPaymentVoucher);

            return financialPaymentVoucher;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialPaymentVoucherCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 5:37:58 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentVoucher/CrudeFinancialPaymentVoucherCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPaymentVoucher/CrudeFinancialPaymentVoucherCreate/", content).Result;

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

        [HttpPut("crudefinancialpaymentvoucherupdate")]
        public CrudeFinancialPaymentVoucherModel CrudeFinancialPaymentVoucherUpdate([Bind()] CrudeFinancialPaymentVoucherModel financialPaymentVoucher) {

            new CrudeFinancialPaymentVoucherBusiness().Update(financialPaymentVoucher);

            return financialPaymentVoucher;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialPaymentVoucherUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 5:37:58 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentVoucher/CrudeFinancialPaymentVoucherUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPaymentVoucher/CrudeFinancialPaymentVoucherUpdate/", content).Result;

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

        [HttpDelete("financialpaymentvoucherdelete/{financialpaymentvoucherid?}")]
        public void CrudeFinancialPaymentVoucherDelete(System.Guid financialPaymentVoucherId) {

            new CrudeFinancialPaymentVoucherBusiness().Delete(financialPaymentVoucherId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialPaymentVoucherDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentVoucher/CrudeFinancialPaymentVoucherDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
