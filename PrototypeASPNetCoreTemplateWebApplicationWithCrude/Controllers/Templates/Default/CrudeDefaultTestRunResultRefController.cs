/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:22:56 PM
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
    [Route("api/1/crudedefaulttestrunresultref")]
    public class CrudeDefaultTestRunResultRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultTestRunResultRefHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultTestRunResultRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultTestRunResultRefModel> CrudeDefaultTestRunResultRefFetchAll() {

            List<CrudeDefaultTestRunResultRefModel> defaultTestRunResultRefs = 
                new CrudeDefaultTestRunResultRefBusiness().FetchAll();

            return defaultTestRunResultRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultTestRunResultRefFetchAllCount() {

            return new CrudeDefaultTestRunResultRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultTestRunResultRefModel> CrudeDefaultTestRunResultRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultTestRunResultRefModel> defaultTestRunResultRefs = 
                new CrudeDefaultTestRunResultRefBusiness().FetchAllWithLimit(limit);

            return defaultTestRunResultRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultTestRunResultRefModel> CrudeDefaultTestRunResultRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultTestRunResultRefModel> defaultTestRunResultRefs = 
                new CrudeDefaultTestRunResultRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultTestRunResultRefs;
        }

        [HttpGet("fetchbydefaulttestrunresultrcd/{defaulttestrunresultrcd?}")]
        public CrudeDefaultTestRunResultRefModel CrudeDefaultTestRunResultRefFetchByDefaultTestRunResultRcd(System.String defaulttestrunresultrcd) {

            CrudeDefaultTestRunResultRefModel defaultTestRunResultRef = 
                new CrudeDefaultTestRunResultRefBusiness().FetchByDefaultTestRunResultRcd(defaulttestrunresultrcd);

            return defaultTestRunResultRef;
        }

        [HttpPost("crudedefaulttestrunresultrefcreate")]
        public CrudeDefaultTestRunResultRefModel CrudeDefaultTestRunResultRefCreate([Bind()] CrudeDefaultTestRunResultRefModel defaultTestRunResultRef) {

            new CrudeDefaultTestRunResultRefBusiness().Insert(defaultTestRunResultRef);

            return defaultTestRunResultRef;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultTestRunResultRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultTestRunResultRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultTestRunResultName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 8:22:56 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefCreate/", content).Result;

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

        [HttpPut("crudedefaulttestrunresultrefupdate")]
        public CrudeDefaultTestRunResultRefModel CrudeDefaultTestRunResultRefUpdate([Bind()] CrudeDefaultTestRunResultRefModel defaultTestRunResultRef) {

            new CrudeDefaultTestRunResultRefBusiness().Update(defaultTestRunResultRef);

            return defaultTestRunResultRef;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultTestRunResultRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultTestRunResultRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultTestRunResultName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 8:22:56 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefUpdate/", content).Result;

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

        [HttpDelete("defaulttestrunresultrefdelete/{defaulttestrunresultrcd?}")]
        public void CrudeDefaultTestRunResultRefDelete(System.String defaultTestRunResultRcd) {

            new CrudeDefaultTestRunResultRefBusiness().Delete(defaultTestRunResultRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultTestRunResultRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultTestRunResultRef/CrudeDefaultTestRunResultRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
