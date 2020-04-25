/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:25:17 PM
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
    [Route("api/1/crudedefaultchangelog")]
    public class CrudeDefaultChangeLogController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultChangeLogHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultChangeLog.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultChangeLogModel> CrudeDefaultChangeLogFetchAll() {

            List<CrudeDefaultChangeLogModel> defaultChangeLogs = 
                new CrudeDefaultChangeLogBusiness().FetchAll();

            return defaultChangeLogs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultChangeLogFetchAllCount() {

            return new CrudeDefaultChangeLogBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultChangeLogModel> CrudeDefaultChangeLogFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultChangeLogModel> defaultChangeLogs = 
                new CrudeDefaultChangeLogBusiness().FetchAllWithLimit(limit);

            return defaultChangeLogs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultChangeLogModel> CrudeDefaultChangeLogFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultChangeLogModel> defaultChangeLogs = 
                new CrudeDefaultChangeLogBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultChangeLogs;
        }

        [HttpGet("fetchbydefaultchangelogid/{defaultchangelogid?}")]
        public CrudeDefaultChangeLogModel CrudeDefaultChangeLogFetchByDefaultChangeLogId(System.Guid defaultchangelogid) {

            CrudeDefaultChangeLogModel defaultChangeLog = 
                new CrudeDefaultChangeLogBusiness().FetchByDefaultChangeLogId(defaultchangelogid);

            return defaultChangeLog;
        }

        [HttpGet("fetchbydefaultchangename/{defaultchangename?}")]
        public CrudeDefaultChangeLogModel CrudeDefaultChangeLogFetchByDefaultChangeName(System.String defaultchangename) {

            CrudeDefaultChangeLogModel defaultChangeLog = 
                new CrudeDefaultChangeLogBusiness().FetchByDefaultChangeName(defaultchangename);

            return defaultChangeLog;
        }

        [HttpGet("fetchbydefaultuserid/{defaultuserid?}")]
        public IEnumerable<CrudeDefaultChangeLogModel> CrudeDefaultChangeLogFetchByDefaultUserId(System.Guid defaultuserid) {

            List<CrudeDefaultChangeLogModel> defaultChangeLog = 
                new CrudeDefaultChangeLogBusiness().FetchByDefaultUserId(defaultuserid);

            return defaultChangeLog;
        }

        [HttpGet("fetchbydefaultchangelogtypercd/{defaultchangelogtypercd?}")]
        public IEnumerable<CrudeDefaultChangeLogModel> CrudeDefaultChangeLogFetchByDefaultChangeLogTypeRcd(System.String defaultchangelogtypercd) {

            List<CrudeDefaultChangeLogModel> defaultChangeLog = 
                new CrudeDefaultChangeLogBusiness().FetchByDefaultChangeLogTypeRcd(defaultchangelogtypercd);

            return defaultChangeLog;
        }

        [HttpGet("fetchbydefaultissueid/{defaultissueid?}")]
        public IEnumerable<CrudeDefaultChangeLogModel> CrudeDefaultChangeLogFetchByDefaultIssueId(System.Guid defaultissueid) {

            List<CrudeDefaultChangeLogModel> defaultChangeLog = 
                new CrudeDefaultChangeLogBusiness().FetchByDefaultIssueId(defaultissueid);

            return defaultChangeLog;
        }

        [HttpPost("crudedefaultchangelogcreate")]
        public CrudeDefaultChangeLogModel CrudeDefaultChangeLogCreate([Bind()] CrudeDefaultChangeLogModel defaultChangeLog) {

            new CrudeDefaultChangeLogBusiness().Insert(defaultChangeLog);

            return defaultChangeLog;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultChangeLogCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultChangeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultChangeDescription" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 12:25:17 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultChangeLogTypeRcd" , "create" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultChangeLog/CrudeDefaultChangeLogCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultChangeLog/CrudeDefaultChangeLogCreate/", content).Result;

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

        [HttpPut("crudedefaultchangelogupdate")]
        public CrudeDefaultChangeLogModel CrudeDefaultChangeLogUpdate([Bind()] CrudeDefaultChangeLogModel defaultChangeLog) {

            new CrudeDefaultChangeLogBusiness().Update(defaultChangeLog);

            return defaultChangeLog;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultChangeLogUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultChangeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultChangeDescription" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 12:25:17 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultChangeLogTypeRcd" , "update" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultChangeLog/CrudeDefaultChangeLogUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultChangeLog/CrudeDefaultChangeLogUpdate/", content).Result;

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

        [HttpDelete("defaultchangelogdelete/{defaultchangelogid?}")]
        public void CrudeDefaultChangeLogDelete(System.Guid defaultChangeLogId) {

            new CrudeDefaultChangeLogBusiness().Delete(defaultChangeLogId);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultChangeLogDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultChangeLog/CrudeDefaultChangeLogDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
