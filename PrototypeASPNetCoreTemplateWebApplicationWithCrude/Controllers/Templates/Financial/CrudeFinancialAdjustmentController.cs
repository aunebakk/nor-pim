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
    [Route("api/1/crudefinancialadjustment")]
    public class CrudeFinancialAdjustmentController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialAdjustmentHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialAdjustment.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialAdjustmentModel> CrudeFinancialAdjustmentFetchAll() {

            List<CrudeFinancialAdjustmentModel> financialAdjustments = 
                new CrudeFinancialAdjustmentBusiness().FetchAll();

            return financialAdjustments;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialAdjustmentFetchAllCount() {

            return new CrudeFinancialAdjustmentBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialAdjustmentModel> CrudeFinancialAdjustmentFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialAdjustmentModel> financialAdjustments = 
                new CrudeFinancialAdjustmentBusiness().FetchAllWithLimit(limit);

            return financialAdjustments;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialAdjustmentModel> CrudeFinancialAdjustmentFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialAdjustmentModel> financialAdjustments = 
                new CrudeFinancialAdjustmentBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialAdjustments;
        }

        [HttpGet("fetchbyfinancialadjustmentid/{financialadjustmentid?}")]
        public CrudeFinancialAdjustmentModel CrudeFinancialAdjustmentFetchByFinancialAdjustmentId(System.Guid financialadjustmentid) {

            CrudeFinancialAdjustmentModel financialAdjustment = 
                new CrudeFinancialAdjustmentBusiness().FetchByFinancialAdjustmentId(financialadjustmentid);

            return financialAdjustment;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialAdjustmentModel> CrudeFinancialAdjustmentFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialAdjustmentModel> financialAdjustment = 
                new CrudeFinancialAdjustmentBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialAdjustment;
        }

        [HttpGet("fetchbyfinancialadjustmenttypercd/{financialadjustmenttypercd?}")]
        public IEnumerable<CrudeFinancialAdjustmentModel> CrudeFinancialAdjustmentFetchByFinancialAdjustmentTypeRcd(System.String financialadjustmenttypercd) {

            List<CrudeFinancialAdjustmentModel> financialAdjustment = 
                new CrudeFinancialAdjustmentBusiness().FetchByFinancialAdjustmentTypeRcd(financialadjustmenttypercd);

            return financialAdjustment;
        }

        [HttpPost("crudefinancialadjustmentcreate")]
        public CrudeFinancialAdjustmentModel CrudeFinancialAdjustmentCreate([Bind()] CrudeFinancialAdjustmentModel financialAdjustment) {

            new CrudeFinancialAdjustmentBusiness().Insert(financialAdjustment);

            return financialAdjustment;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialAdjustmentCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/23/2020 11:50:18 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialAdjustmentTypeRcd" , "create" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialAdjustment/CrudeFinancialAdjustmentCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialAdjustment/CrudeFinancialAdjustmentCreate/", content).Result;

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

        [HttpPut("crudefinancialadjustmentupdate")]
        public CrudeFinancialAdjustmentModel CrudeFinancialAdjustmentUpdate([Bind()] CrudeFinancialAdjustmentModel financialAdjustment) {

            new CrudeFinancialAdjustmentBusiness().Update(financialAdjustment);

            return financialAdjustment;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialAdjustmentUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/23/2020 11:50:18 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialAdjustmentTypeRcd" , "update" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialAdjustment/CrudeFinancialAdjustmentUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialAdjustment/CrudeFinancialAdjustmentUpdate/", content).Result;

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

        [HttpDelete("financialadjustmentdelete/{financialadjustmentid?}")]
        public void CrudeFinancialAdjustmentDelete(System.Guid financialAdjustmentId) {

            new CrudeFinancialAdjustmentBusiness().Delete(financialAdjustmentId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialAdjustmentDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialAdjustment/CrudeFinancialAdjustmentDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
