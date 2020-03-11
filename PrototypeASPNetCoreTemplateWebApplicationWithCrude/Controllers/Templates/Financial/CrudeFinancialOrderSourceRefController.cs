/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:38:01 PM
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
    [Route("api/1/crudefinancialordersourceref")]
    public class CrudeFinancialOrderSourceRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialOrderSourceRefHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialOrderSourceRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialOrderSourceRefModel> CrudeFinancialOrderSourceRefFetchAll() {

            List<CrudeFinancialOrderSourceRefModel> financialOrderSourceRefs = 
                new CrudeFinancialOrderSourceRefBusiness().FetchAll();

            return financialOrderSourceRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialOrderSourceRefFetchAllCount() {

            return new CrudeFinancialOrderSourceRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialOrderSourceRefModel> CrudeFinancialOrderSourceRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialOrderSourceRefModel> financialOrderSourceRefs = 
                new CrudeFinancialOrderSourceRefBusiness().FetchAllWithLimit(limit);

            return financialOrderSourceRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialOrderSourceRefModel> CrudeFinancialOrderSourceRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialOrderSourceRefModel> financialOrderSourceRefs = 
                new CrudeFinancialOrderSourceRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialOrderSourceRefs;
        }

        [HttpGet("fetchbyfinancialordersourcercd/{financialordersourcercd?}")]
        public CrudeFinancialOrderSourceRefModel CrudeFinancialOrderSourceRefFetchByFinancialOrderSourceRcd(System.String financialordersourcercd) {

            CrudeFinancialOrderSourceRefModel financialOrderSourceRef = 
                new CrudeFinancialOrderSourceRefBusiness().FetchByFinancialOrderSourceRcd(financialordersourcercd);

            return financialOrderSourceRef;
        }

        [HttpPost("crudefinancialordersourcerefcreate")]
        public CrudeFinancialOrderSourceRefModel CrudeFinancialOrderSourceRefCreate([Bind()] CrudeFinancialOrderSourceRefModel financialOrderSourceRef) {

            new CrudeFinancialOrderSourceRefBusiness().Insert(financialOrderSourceRef);

            return financialOrderSourceRef;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialOrderSourceRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderSourceRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderSourceName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderSourceCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortSequenceNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StatusCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:38:01 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderSourceRef/CrudeFinancialOrderSourceRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrderSourceRef/CrudeFinancialOrderSourceRefCreate/", content).Result;

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

        [HttpPut("crudefinancialordersourcerefupdate")]
        public CrudeFinancialOrderSourceRefModel CrudeFinancialOrderSourceRefUpdate([Bind()] CrudeFinancialOrderSourceRefModel financialOrderSourceRef) {

            new CrudeFinancialOrderSourceRefBusiness().Update(financialOrderSourceRef);

            return financialOrderSourceRef;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialOrderSourceRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderSourceRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderSourceName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderSourceCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortSequenceNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StatusCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:38:01 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderSourceRef/CrudeFinancialOrderSourceRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrderSourceRef/CrudeFinancialOrderSourceRefUpdate/", content).Result;

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

        [HttpDelete("financialordersourcerefdelete/{financialordersourcercd?}")]
        public void CrudeFinancialOrderSourceRefDelete(System.String financialOrderSourceRcd) {

            new CrudeFinancialOrderSourceRefBusiness().Delete(financialOrderSourceRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialOrderSourceRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderSourceRef/CrudeFinancialOrderSourceRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
