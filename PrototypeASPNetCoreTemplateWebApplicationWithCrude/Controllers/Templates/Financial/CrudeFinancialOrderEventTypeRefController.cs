/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 7:01:23 AM
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
    [Route("api/1/crudefinancialordereventtyperef")]
    public class CrudeFinancialOrderEventTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialOrderEventTypeRefHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialOrderEventTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialOrderEventTypeRefModel> CrudeFinancialOrderEventTypeRefFetchAll() {

            List<CrudeFinancialOrderEventTypeRefModel> financialOrderEventTypeRefs = 
                new CrudeFinancialOrderEventTypeRefBusiness().FetchAll();

            return financialOrderEventTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialOrderEventTypeRefFetchAllCount() {

            return new CrudeFinancialOrderEventTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialOrderEventTypeRefModel> CrudeFinancialOrderEventTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialOrderEventTypeRefModel> financialOrderEventTypeRefs = 
                new CrudeFinancialOrderEventTypeRefBusiness().FetchAllWithLimit(limit);

            return financialOrderEventTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialOrderEventTypeRefModel> CrudeFinancialOrderEventTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialOrderEventTypeRefModel> financialOrderEventTypeRefs = 
                new CrudeFinancialOrderEventTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialOrderEventTypeRefs;
        }

        [HttpGet("fetchbyfinancialordereventtypercd/{financialordereventtypercd?}")]
        public CrudeFinancialOrderEventTypeRefModel CrudeFinancialOrderEventTypeRefFetchByFinancialOrderEventTypeRcd(System.String financialordereventtypercd) {

            CrudeFinancialOrderEventTypeRefModel financialOrderEventTypeRef = 
                new CrudeFinancialOrderEventTypeRefBusiness().FetchByFinancialOrderEventTypeRcd(financialordereventtypercd);

            return financialOrderEventTypeRef;
        }

        [HttpPost("crudefinancialordereventtyperefcreate")]
        public CrudeFinancialOrderEventTypeRefModel CrudeFinancialOrderEventTypeRefCreate([Bind()] CrudeFinancialOrderEventTypeRefModel financialOrderEventTypeRef) {

            new CrudeFinancialOrderEventTypeRefBusiness().Insert(financialOrderEventTypeRef);

            return financialOrderEventTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialOrderEventTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderEventTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderEventTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 7:01:23 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderEventTypeRef/CrudeFinancialOrderEventTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrderEventTypeRef/CrudeFinancialOrderEventTypeRefCreate/", content).Result;

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

        [HttpPut("crudefinancialordereventtyperefupdate")]
        public CrudeFinancialOrderEventTypeRefModel CrudeFinancialOrderEventTypeRefUpdate([Bind()] CrudeFinancialOrderEventTypeRefModel financialOrderEventTypeRef) {

            new CrudeFinancialOrderEventTypeRefBusiness().Update(financialOrderEventTypeRef);

            return financialOrderEventTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialOrderEventTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderEventTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderEventTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 7:01:23 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderEventTypeRef/CrudeFinancialOrderEventTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrderEventTypeRef/CrudeFinancialOrderEventTypeRefUpdate/", content).Result;

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

        [HttpDelete("financialordereventtyperefdelete/{financialordereventtypercd?}")]
        public void CrudeFinancialOrderEventTypeRefDelete(System.String financialOrderEventTypeRcd) {

            new CrudeFinancialOrderEventTypeRefBusiness().Delete(financialOrderEventTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialOrderEventTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderEventTypeRef/CrudeFinancialOrderEventTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
