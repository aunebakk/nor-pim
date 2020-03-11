/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:22:23 PM
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
    [Route("api/1/crudedefaultperformanceissue")]
    public class CrudeDefaultPerformanceIssueController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultPerformanceIssueHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultPerformanceIssue.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultPerformanceIssueModel> CrudeDefaultPerformanceIssueFetchAll() {

            List<CrudeDefaultPerformanceIssueModel> defaultPerformanceIssues = 
                new CrudeDefaultPerformanceIssueBusiness().FetchAll();

            return defaultPerformanceIssues;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultPerformanceIssueFetchAllCount() {

            return new CrudeDefaultPerformanceIssueBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultPerformanceIssueModel> CrudeDefaultPerformanceIssueFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultPerformanceIssueModel> defaultPerformanceIssues = 
                new CrudeDefaultPerformanceIssueBusiness().FetchAllWithLimit(limit);

            return defaultPerformanceIssues;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultPerformanceIssueModel> CrudeDefaultPerformanceIssueFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultPerformanceIssueModel> defaultPerformanceIssues = 
                new CrudeDefaultPerformanceIssueBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultPerformanceIssues;
        }

        [HttpGet("fetchbydefaultperformanceissueid/{defaultperformanceissueid?}")]
        public CrudeDefaultPerformanceIssueModel CrudeDefaultPerformanceIssueFetchByDefaultPerformanceIssueId(System.Guid defaultperformanceissueid) {

            CrudeDefaultPerformanceIssueModel defaultPerformanceIssue = 
                new CrudeDefaultPerformanceIssueBusiness().FetchByDefaultPerformanceIssueId(defaultperformanceissueid);

            return defaultPerformanceIssue;
        }

        [HttpGet("fetchbycommandname/{commandname?}")]
        public CrudeDefaultPerformanceIssueModel CrudeDefaultPerformanceIssueFetchByCommandName(System.String commandname) {

            CrudeDefaultPerformanceIssueModel defaultPerformanceIssue = 
                new CrudeDefaultPerformanceIssueBusiness().FetchByCommandName(commandname);

            return defaultPerformanceIssue;
        }

        [HttpGet("fetchbydefaultuserid/{defaultuserid?}")]
        public IEnumerable<CrudeDefaultPerformanceIssueModel> CrudeDefaultPerformanceIssueFetchByDefaultUserId(System.Guid defaultuserid) {

            List<CrudeDefaultPerformanceIssueModel> defaultPerformanceIssue = 
                new CrudeDefaultPerformanceIssueBusiness().FetchByDefaultUserId(defaultuserid);

            return defaultPerformanceIssue;
        }

        [HttpPost("crudedefaultperformanceissuecreate")]
        public CrudeDefaultPerformanceIssueModel CrudeDefaultPerformanceIssueCreate([Bind()] CrudeDefaultPerformanceIssueModel defaultPerformanceIssue) {

            new CrudeDefaultPerformanceIssueBusiness().Insert(defaultPerformanceIssue);

            return defaultPerformanceIssue;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultPerformanceIssueCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "CommandName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "CommandText" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Milliseconds" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 9:22:23 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultPerformanceIssue/CrudeDefaultPerformanceIssueCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultPerformanceIssue/CrudeDefaultPerformanceIssueCreate/", content).Result;

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

        [HttpPut("crudedefaultperformanceissueupdate")]
        public CrudeDefaultPerformanceIssueModel CrudeDefaultPerformanceIssueUpdate([Bind()] CrudeDefaultPerformanceIssueModel defaultPerformanceIssue) {

            new CrudeDefaultPerformanceIssueBusiness().Update(defaultPerformanceIssue);

            return defaultPerformanceIssue;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultPerformanceIssueUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "CommandName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "CommandText" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Milliseconds" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 9:22:23 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultPerformanceIssue/CrudeDefaultPerformanceIssueUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultPerformanceIssue/CrudeDefaultPerformanceIssueUpdate/", content).Result;

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

        [HttpDelete("defaultperformanceissuedelete/{defaultperformanceissueid?}")]
        public void CrudeDefaultPerformanceIssueDelete(System.Guid defaultPerformanceIssueId) {

            new CrudeDefaultPerformanceIssueBusiness().Delete(defaultPerformanceIssueId);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultPerformanceIssueDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultPerformanceIssue/CrudeDefaultPerformanceIssueDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
