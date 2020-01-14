/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:24 PM
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
    [Route("api/1/crudedefaultperformancetime")]
    public class CrudeDefaultPerformanceTimeController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultPerformanceTimeHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultPerformanceTime.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultPerformanceTimeModel> CrudeDefaultPerformanceTimeFetchAll() {

            List<CrudeDefaultPerformanceTimeModel> defaultPerformanceTimes = 
                new CrudeDefaultPerformanceTimeBusiness().FetchAll();

            return defaultPerformanceTimes;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultPerformanceTimeFetchAllCount() {

            return new CrudeDefaultPerformanceTimeBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultPerformanceTimeModel> CrudeDefaultPerformanceTimeFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultPerformanceTimeModel> defaultPerformanceTimes = 
                new CrudeDefaultPerformanceTimeBusiness().FetchAllWithLimit(limit);

            return defaultPerformanceTimes;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultPerformanceTimeModel> CrudeDefaultPerformanceTimeFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultPerformanceTimeModel> defaultPerformanceTimes = 
                new CrudeDefaultPerformanceTimeBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultPerformanceTimes;
        }

        [HttpGet("fetchbydefaultperformancetimeid/{defaultperformancetimeid?}")]
        public CrudeDefaultPerformanceTimeModel CrudeDefaultPerformanceTimeFetchByDefaultPerformanceTimeId(System.Guid defaultperformancetimeid) {

            CrudeDefaultPerformanceTimeModel defaultPerformanceTime = 
                new CrudeDefaultPerformanceTimeBusiness().FetchByDefaultPerformanceTimeId(defaultperformancetimeid);

            return defaultPerformanceTime;
        }

        [HttpGet("fetchbycommandname/{commandname?}")]
        public CrudeDefaultPerformanceTimeModel CrudeDefaultPerformanceTimeFetchByCommandName(System.String commandname) {

            CrudeDefaultPerformanceTimeModel defaultPerformanceTime = 
                new CrudeDefaultPerformanceTimeBusiness().FetchByCommandName(commandname);

            return defaultPerformanceTime;
        }

        [HttpGet("fetchbydefaultuserid/{defaultuserid?}")]
        public IEnumerable<CrudeDefaultPerformanceTimeModel> CrudeDefaultPerformanceTimeFetchByDefaultUserId(System.Guid defaultuserid) {

            List<CrudeDefaultPerformanceTimeModel> defaultPerformanceTime = 
                new CrudeDefaultPerformanceTimeBusiness().FetchByDefaultUserId(defaultuserid);

            return defaultPerformanceTime;
        }

        [HttpPost("crudedefaultperformancetimecreate")]
        public CrudeDefaultPerformanceTimeModel CrudeDefaultPerformanceTimeCreate([Bind()] CrudeDefaultPerformanceTimeModel defaultPerformanceTime) {

            new CrudeDefaultPerformanceTimeBusiness().Insert(defaultPerformanceTime);

            return defaultPerformanceTime;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultPerformanceTimeCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "CommandName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Milliseconds" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 3:02:24 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeCreate/", content).Result;

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

        [HttpPut("crudedefaultperformancetimeupdate")]
        public CrudeDefaultPerformanceTimeModel CrudeDefaultPerformanceTimeUpdate([Bind()] CrudeDefaultPerformanceTimeModel defaultPerformanceTime) {

            new CrudeDefaultPerformanceTimeBusiness().Update(defaultPerformanceTime);

            return defaultPerformanceTime;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultPerformanceTimeUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "CommandName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Milliseconds" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 3:02:24 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeUpdate/", content).Result;

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

        [HttpDelete("defaultperformancetimedelete/{defaultperformancetimeid?}")]
        public void CrudeDefaultPerformanceTimeDelete(System.Guid defaultPerformanceTimeId) {

            new CrudeDefaultPerformanceTimeBusiness().Delete(defaultPerformanceTimeId);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultPerformanceTimeDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultPerformanceTime/CrudeDefaultPerformanceTimeDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
