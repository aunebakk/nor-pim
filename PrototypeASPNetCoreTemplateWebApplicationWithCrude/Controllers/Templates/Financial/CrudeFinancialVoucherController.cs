/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:45:43 AM
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
    [Route("api/1/crudefinancialvoucher")]
    public class CrudeFinancialVoucherController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialVoucherHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialVoucher.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialVoucherModel> CrudeFinancialVoucherFetchAll() {

            List<CrudeFinancialVoucherModel> financialVouchers = 
                new CrudeFinancialVoucherBusiness().FetchAll();

            return financialVouchers;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialVoucherFetchAllCount() {

            return new CrudeFinancialVoucherBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialVoucherModel> CrudeFinancialVoucherFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialVoucherModel> financialVouchers = 
                new CrudeFinancialVoucherBusiness().FetchAllWithLimit(limit);

            return financialVouchers;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialVoucherModel> CrudeFinancialVoucherFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialVoucherModel> financialVouchers = 
                new CrudeFinancialVoucherBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialVouchers;
        }

        [HttpGet("fetchbyfinancialvoucherid/{financialvoucherid?}")]
        public CrudeFinancialVoucherModel CrudeFinancialVoucherFetchByFinancialVoucherId(System.Guid financialvoucherid) {

            CrudeFinancialVoucherModel financialVoucher = 
                new CrudeFinancialVoucherBusiness().FetchByFinancialVoucherId(financialvoucherid);

            return financialVoucher;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialVoucherModel> CrudeFinancialVoucherFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialVoucherModel> financialVoucher = 
                new CrudeFinancialVoucherBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialVoucher;
        }

        [HttpGet("fetchbyfinancialvouchertypercd/{financialvouchertypercd?}")]
        public IEnumerable<CrudeFinancialVoucherModel> CrudeFinancialVoucherFetchByFinancialVoucherTypeRcd(System.String financialvouchertypercd) {

            List<CrudeFinancialVoucherModel> financialVoucher = 
                new CrudeFinancialVoucherBusiness().FetchByFinancialVoucherTypeRcd(financialvouchertypercd);

            return financialVoucher;
        }

        [HttpPost("crudefinancialvouchercreate")]
        public CrudeFinancialVoucherModel CrudeFinancialVoucherCreate([Bind()] CrudeFinancialVoucherModel financialVoucher) {

            new CrudeFinancialVoucherBusiness().Insert(financialVoucher);

            return financialVoucher;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialVoucherCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 9:45:43 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ValidFromDateTime" , "4/25/2020 9:45:43 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ValidUntilDateTime" , "4/25/2020 9:45:43 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "VoucherNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "VoucherDescription" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialVoucherTypeRcd" , "create" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialVoucher/CrudeFinancialVoucherCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialVoucher/CrudeFinancialVoucherCreate/", content).Result;

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

        [HttpPut("crudefinancialvoucherupdate")]
        public CrudeFinancialVoucherModel CrudeFinancialVoucherUpdate([Bind()] CrudeFinancialVoucherModel financialVoucher) {

            new CrudeFinancialVoucherBusiness().Update(financialVoucher);

            return financialVoucher;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialVoucherUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 9:45:43 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ValidFromDateTime" , "4/25/2020 9:45:43 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ValidUntilDateTime" , "4/25/2020 9:45:43 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "VoucherNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "VoucherDescription" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialVoucherTypeRcd" , "update" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialVoucher/CrudeFinancialVoucherUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialVoucher/CrudeFinancialVoucherUpdate/", content).Result;

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

        [HttpDelete("financialvoucherdelete/{financialvoucherid?}")]
        public void CrudeFinancialVoucherDelete(System.Guid financialVoucherId) {

            new CrudeFinancialVoucherBusiness().Delete(financialVoucherId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialVoucherDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialVoucher/CrudeFinancialVoucherDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
