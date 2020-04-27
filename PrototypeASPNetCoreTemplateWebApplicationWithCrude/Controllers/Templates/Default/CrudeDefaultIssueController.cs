/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:45:10 PM
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
    [Route("api/1/crudedefaultissue")]
    public class CrudeDefaultIssueController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultIssueHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultIssue.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultIssueModel> CrudeDefaultIssueFetchAll() {

            List<CrudeDefaultIssueModel> defaultIssues = 
                new CrudeDefaultIssueBusiness().FetchAll();

            return defaultIssues;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultIssueFetchAllCount() {

            return new CrudeDefaultIssueBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultIssueModel> CrudeDefaultIssueFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultIssueModel> defaultIssues = 
                new CrudeDefaultIssueBusiness().FetchAllWithLimit(limit);

            return defaultIssues;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultIssueModel> CrudeDefaultIssueFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultIssueModel> defaultIssues = 
                new CrudeDefaultIssueBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultIssues;
        }

        [HttpGet("fetchbydefaultissueid/{defaultissueid?}")]
        public CrudeDefaultIssueModel CrudeDefaultIssueFetchByDefaultIssueId(System.Guid defaultissueid) {

            CrudeDefaultIssueModel defaultIssue = 
                new CrudeDefaultIssueBusiness().FetchByDefaultIssueId(defaultissueid);

            return defaultIssue;
        }

        [HttpGet("fetchbyissuename/{issuename?}")]
        public CrudeDefaultIssueModel CrudeDefaultIssueFetchByIssueName(System.String issuename) {

            CrudeDefaultIssueModel defaultIssue = 
                new CrudeDefaultIssueBusiness().FetchByIssueName(issuename);

            return defaultIssue;
        }

        [HttpGet("fetchbydefaultissuetypercd/{defaultissuetypercd?}")]
        public IEnumerable<CrudeDefaultIssueModel> CrudeDefaultIssueFetchByDefaultIssueTypeRcd(System.String defaultissuetypercd) {

            List<CrudeDefaultIssueModel> defaultIssue = 
                new CrudeDefaultIssueBusiness().FetchByDefaultIssueTypeRcd(defaultissuetypercd);

            return defaultIssue;
        }

        [HttpGet("fetchbydefaultissuestatusrcd/{defaultissuestatusrcd?}")]
        public IEnumerable<CrudeDefaultIssueModel> CrudeDefaultIssueFetchByDefaultIssueStatusRcd(System.String defaultissuestatusrcd) {

            List<CrudeDefaultIssueModel> defaultIssue = 
                new CrudeDefaultIssueBusiness().FetchByDefaultIssueStatusRcd(defaultissuestatusrcd);

            return defaultIssue;
        }

        [HttpGet("fetchbydefaulterrorid/{defaulterrorid?}")]
        public IEnumerable<CrudeDefaultIssueModel> CrudeDefaultIssueFetchByDefaultErrorId(System.Guid defaulterrorid) {

            List<CrudeDefaultIssueModel> defaultIssue = 
                new CrudeDefaultIssueBusiness().FetchByDefaultErrorId(defaulterrorid);

            return defaultIssue;
        }

        [HttpGet("fetchbydefaultuserid/{defaultuserid?}")]
        public IEnumerable<CrudeDefaultIssueModel> CrudeDefaultIssueFetchByDefaultUserId(System.Guid defaultuserid) {

            List<CrudeDefaultIssueModel> defaultIssue = 
                new CrudeDefaultIssueBusiness().FetchByDefaultUserId(defaultuserid);

            return defaultIssue;
        }

        [HttpPost("crudedefaultissuecreate")]
        public CrudeDefaultIssueModel CrudeDefaultIssueCreate([Bind()] CrudeDefaultIssueModel defaultIssue) {

            new CrudeDefaultIssueBusiness().Insert(defaultIssue);

            return defaultIssue;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultIssueCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultIssueTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultIssueStatusRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "IssueName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "IssueDescription" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StepsToReproduce" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Link" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/27/2020 3:45:10 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FixedNote" , "create" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultIssue/CrudeDefaultIssueCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultIssue/CrudeDefaultIssueCreate/", content).Result;

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

        [HttpPut("crudedefaultissueupdate")]
        public CrudeDefaultIssueModel CrudeDefaultIssueUpdate([Bind()] CrudeDefaultIssueModel defaultIssue) {

            new CrudeDefaultIssueBusiness().Update(defaultIssue);

            return defaultIssue;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultIssueUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultIssueTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultIssueStatusRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "IssueName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "IssueDescription" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StepsToReproduce" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Link" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/27/2020 3:45:10 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FixedNote" , "update" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultIssue/CrudeDefaultIssueUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultIssue/CrudeDefaultIssueUpdate/", content).Result;

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

        [HttpDelete("defaultissuedelete/{defaultissueid?}")]
        public void CrudeDefaultIssueDelete(System.Guid defaultIssueId) {

            new CrudeDefaultIssueBusiness().Delete(defaultIssueId);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultIssueDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultIssue/CrudeDefaultIssueDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
