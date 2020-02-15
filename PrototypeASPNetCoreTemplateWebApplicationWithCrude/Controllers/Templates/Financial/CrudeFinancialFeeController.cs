/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:21 AM
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
    [Route("api/1/crudefinancialfee")]
    public class CrudeFinancialFeeController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialFeeHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialFee.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialFeeModel> CrudeFinancialFeeFetchAll() {

            List<CrudeFinancialFeeModel> financialFees = 
                new CrudeFinancialFeeBusiness().FetchAll();

            return financialFees;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialFeeFetchAllCount() {

            return new CrudeFinancialFeeBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialFeeModel> CrudeFinancialFeeFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialFeeModel> financialFees = 
                new CrudeFinancialFeeBusiness().FetchAllWithLimit(limit);

            return financialFees;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialFeeModel> CrudeFinancialFeeFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialFeeModel> financialFees = 
                new CrudeFinancialFeeBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialFees;
        }

        [HttpGet("fetchbyfinancialfeeid/{financialfeeid?}")]
        public CrudeFinancialFeeModel CrudeFinancialFeeFetchByFinancialFeeId(System.Guid financialfeeid) {

            CrudeFinancialFeeModel financialFee = 
                new CrudeFinancialFeeBusiness().FetchByFinancialFeeId(financialfeeid);

            return financialFee;
        }

        [HttpGet("fetchbyfinancialfeetypercd/{financialfeetypercd?}")]
        public IEnumerable<CrudeFinancialFeeModel> CrudeFinancialFeeFetchByFinancialFeeTypeRcd(System.String financialfeetypercd) {

            List<CrudeFinancialFeeModel> financialFee = 
                new CrudeFinancialFeeBusiness().FetchByFinancialFeeTypeRcd(financialfeetypercd);

            return financialFee;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialFeeModel> CrudeFinancialFeeFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialFeeModel> financialFee = 
                new CrudeFinancialFeeBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialFee;
        }

        [HttpPost("crudefinancialfeecreate")]
        public CrudeFinancialFeeModel CrudeFinancialFeeCreate([Bind()] CrudeFinancialFeeModel financialFee) {

            new CrudeFinancialFeeBusiness().Insert(financialFee);

            return financialFee;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialFeeCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:21 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialFeeTypeRcd" , "create" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialFee/CrudeFinancialFeeCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialFee/CrudeFinancialFeeCreate/", content).Result;

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

        [HttpPut("crudefinancialfeeupdate")]
        public CrudeFinancialFeeModel CrudeFinancialFeeUpdate([Bind()] CrudeFinancialFeeModel financialFee) {

            new CrudeFinancialFeeBusiness().Update(financialFee);

            return financialFee;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialFeeUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:21 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialFeeTypeRcd" , "update" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialFee/CrudeFinancialFeeUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialFee/CrudeFinancialFeeUpdate/", content).Result;

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

        [HttpDelete("financialfeedelete/{financialfeeid?}")]
        public void CrudeFinancialFeeDelete(System.Guid financialFeeId) {

            new CrudeFinancialFeeBusiness().Delete(financialFeeId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialFeeDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialFee/CrudeFinancialFeeDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
