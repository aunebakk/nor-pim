/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:26 PM
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
    [Route("api/1/crudedefaultperformancetimerollup")]
    public class CrudeDefaultPerformanceTimeRollupController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultPerformanceTimeRollupHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultPerformanceTimeRollup.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultPerformanceTimeRollupModel> CrudeDefaultPerformanceTimeRollupFetchAll() {

            List<CrudeDefaultPerformanceTimeRollupModel> defaultPerformanceTimeRollups = 
                new CrudeDefaultPerformanceTimeRollupBusiness().FetchAll();

            return defaultPerformanceTimeRollups;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultPerformanceTimeRollupFetchAllCount() {

            return new CrudeDefaultPerformanceTimeRollupBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultPerformanceTimeRollupModel> CrudeDefaultPerformanceTimeRollupFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultPerformanceTimeRollupModel> defaultPerformanceTimeRollups = 
                new CrudeDefaultPerformanceTimeRollupBusiness().FetchAllWithLimit(limit);

            return defaultPerformanceTimeRollups;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultPerformanceTimeRollupModel> CrudeDefaultPerformanceTimeRollupFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultPerformanceTimeRollupModel> defaultPerformanceTimeRollups = 
                new CrudeDefaultPerformanceTimeRollupBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultPerformanceTimeRollups;
        }

        [HttpGet("fetchbydefaultperformancetimerollupid/{defaultperformancetimerollupid?}")]
        public CrudeDefaultPerformanceTimeRollupModel CrudeDefaultPerformanceTimeRollupFetchByDefaultPerformanceTimeRollupId(System.Guid defaultperformancetimerollupid) {

            CrudeDefaultPerformanceTimeRollupModel defaultPerformanceTimeRollup = 
                new CrudeDefaultPerformanceTimeRollupBusiness().FetchByDefaultPerformanceTimeRollupId(defaultperformancetimerollupid);

            return defaultPerformanceTimeRollup;
        }

        [HttpGet("fetchbycommandname/{commandname?}")]
        public CrudeDefaultPerformanceTimeRollupModel CrudeDefaultPerformanceTimeRollupFetchByCommandName(System.String commandname) {

            CrudeDefaultPerformanceTimeRollupModel defaultPerformanceTimeRollup = 
                new CrudeDefaultPerformanceTimeRollupBusiness().FetchByCommandName(commandname);

            return defaultPerformanceTimeRollup;
        }

        [HttpPost("crudedefaultperformancetimerollupcreate")]
        public CrudeDefaultPerformanceTimeRollupModel CrudeDefaultPerformanceTimeRollupCreate([Bind()] CrudeDefaultPerformanceTimeRollupModel defaultPerformanceTimeRollup) {

            new CrudeDefaultPerformanceTimeRollupBusiness().Insert(defaultPerformanceTimeRollup);

            return defaultPerformanceTimeRollup;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultPerformanceTimeRollupCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "CommandName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Milliseconds" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Hits" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:23:26 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupCreate/", content).Result;

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

        [HttpPut("crudedefaultperformancetimerollupupdate")]
        public CrudeDefaultPerformanceTimeRollupModel CrudeDefaultPerformanceTimeRollupUpdate([Bind()] CrudeDefaultPerformanceTimeRollupModel defaultPerformanceTimeRollup) {

            new CrudeDefaultPerformanceTimeRollupBusiness().Update(defaultPerformanceTimeRollup);

            return defaultPerformanceTimeRollup;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultPerformanceTimeRollupUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "CommandName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Milliseconds" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Hits" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:23:26 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupUpdate/", content).Result;

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

        [HttpDelete("defaultperformancetimerollupdelete/{defaultperformancetimerollupid?}")]
        public void CrudeDefaultPerformanceTimeRollupDelete(System.Guid defaultPerformanceTimeRollupId) {

            new CrudeDefaultPerformanceTimeRollupBusiness().Delete(defaultPerformanceTimeRollupId);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultPerformanceTimeRollupDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultPerformanceTimeRollup/CrudeDefaultPerformanceTimeRollupDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
