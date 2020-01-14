/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:46:26 AM
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
    [Route("api/1/crudedefaulttestrun")]
    public class CrudeDefaultTestRunController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultTestRunHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultTestRun.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultTestRunModel> CrudeDefaultTestRunFetchAll() {

            List<CrudeDefaultTestRunModel> defaultTestRuns = 
                new CrudeDefaultTestRunBusiness().FetchAll();

            return defaultTestRuns;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultTestRunFetchAllCount() {

            return new CrudeDefaultTestRunBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultTestRunModel> CrudeDefaultTestRunFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultTestRunModel> defaultTestRuns = 
                new CrudeDefaultTestRunBusiness().FetchAllWithLimit(limit);

            return defaultTestRuns;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultTestRunModel> CrudeDefaultTestRunFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultTestRunModel> defaultTestRuns = 
                new CrudeDefaultTestRunBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultTestRuns;
        }

        [HttpGet("fetchbydefaulttestrunid/{defaulttestrunid?}")]
        public CrudeDefaultTestRunModel CrudeDefaultTestRunFetchByDefaultTestRunId(System.Guid defaulttestrunid) {

            CrudeDefaultTestRunModel defaultTestRun = 
                new CrudeDefaultTestRunBusiness().FetchByDefaultTestRunId(defaulttestrunid);

            return defaultTestRun;
        }

        [HttpGet("fetchbydefaulttestid/{defaulttestid?}")]
        public IEnumerable<CrudeDefaultTestRunModel> CrudeDefaultTestRunFetchByDefaultTestId(System.Guid defaulttestid) {

            List<CrudeDefaultTestRunModel> defaultTestRun = 
                new CrudeDefaultTestRunBusiness().FetchByDefaultTestId(defaulttestid);

            return defaultTestRun;
        }

        [HttpGet("fetchbydefaulttestrunresultrcd/{defaulttestrunresultrcd?}")]
        public IEnumerable<CrudeDefaultTestRunModel> CrudeDefaultTestRunFetchByDefaultTestRunResultRcd(System.String defaulttestrunresultrcd) {

            List<CrudeDefaultTestRunModel> defaultTestRun = 
                new CrudeDefaultTestRunBusiness().FetchByDefaultTestRunResultRcd(defaulttestrunresultrcd);

            return defaultTestRun;
        }

        [HttpPost("crudedefaulttestruncreate")]
        public CrudeDefaultTestRunModel CrudeDefaultTestRunCreate([Bind()] CrudeDefaultTestRunModel defaultTestRun) {

            new CrudeDefaultTestRunBusiness().Insert(defaultTestRun);

            return defaultTestRun;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultTestRunCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultTestRunResultRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Result" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StartDateTime" , "1/14/2020 9:46:26 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "EndDateTime" , "1/14/2020 9:46:26 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ElapsedMilliseconds" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 9:46:26 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultTestRun/CrudeDefaultTestRunCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultTestRun/CrudeDefaultTestRunCreate/", content).Result;

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

        [HttpPut("crudedefaulttestrunupdate")]
        public CrudeDefaultTestRunModel CrudeDefaultTestRunUpdate([Bind()] CrudeDefaultTestRunModel defaultTestRun) {

            new CrudeDefaultTestRunBusiness().Update(defaultTestRun);

            return defaultTestRun;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultTestRunUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultTestRunResultRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Result" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StartDateTime" , "1/14/2020 9:46:26 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "EndDateTime" , "1/14/2020 9:46:26 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ElapsedMilliseconds" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 9:46:26 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultTestRun/CrudeDefaultTestRunUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultTestRun/CrudeDefaultTestRunUpdate/", content).Result;

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

        [HttpDelete("defaulttestrundelete/{defaulttestrunid?}")]
        public void CrudeDefaultTestRunDelete(System.Guid defaultTestRunId) {

            new CrudeDefaultTestRunBusiness().Delete(defaultTestRunId);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultTestRunDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultTestRun/CrudeDefaultTestRunDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
