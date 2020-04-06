/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:41:20 PM
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
    [Route("api/1/crudedefaultuseractivity")]
    public class CrudeDefaultUserActivityController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultUserActivityHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultUserActivity.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultUserActivityModel> CrudeDefaultUserActivityFetchAll() {

            List<CrudeDefaultUserActivityModel> defaultUserActivitys = 
                new CrudeDefaultUserActivityBusiness().FetchAll();

            return defaultUserActivitys;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultUserActivityFetchAllCount() {

            return new CrudeDefaultUserActivityBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultUserActivityModel> CrudeDefaultUserActivityFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultUserActivityModel> defaultUserActivitys = 
                new CrudeDefaultUserActivityBusiness().FetchAllWithLimit(limit);

            return defaultUserActivitys;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultUserActivityModel> CrudeDefaultUserActivityFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultUserActivityModel> defaultUserActivitys = 
                new CrudeDefaultUserActivityBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultUserActivitys;
        }

        [HttpGet("fetchbydefaultuseractivityid/{defaultuseractivityid?}")]
        public CrudeDefaultUserActivityModel CrudeDefaultUserActivityFetchByDefaultUserActivityId(System.Guid defaultuseractivityid) {

            CrudeDefaultUserActivityModel defaultUserActivity = 
                new CrudeDefaultUserActivityBusiness().FetchByDefaultUserActivityId(defaultuseractivityid);

            return defaultUserActivity;
        }

        [HttpGet("fetchbydefaultuseractivitytypercd/{defaultuseractivitytypercd?}")]
        public IEnumerable<CrudeDefaultUserActivityModel> CrudeDefaultUserActivityFetchByDefaultUserActivityTypeRcd(System.String defaultuseractivitytypercd) {

            List<CrudeDefaultUserActivityModel> defaultUserActivity = 
                new CrudeDefaultUserActivityBusiness().FetchByDefaultUserActivityTypeRcd(defaultuseractivitytypercd);

            return defaultUserActivity;
        }

        [HttpGet("fetchbydefaultuserid/{defaultuserid?}")]
        public IEnumerable<CrudeDefaultUserActivityModel> CrudeDefaultUserActivityFetchByDefaultUserId(System.Guid defaultuserid) {

            List<CrudeDefaultUserActivityModel> defaultUserActivity = 
                new CrudeDefaultUserActivityBusiness().FetchByDefaultUserId(defaultuserid);

            return defaultUserActivity;
        }

        [HttpPost("crudedefaultuseractivitycreate")]
        public CrudeDefaultUserActivityModel CrudeDefaultUserActivityCreate([Bind()] CrudeDefaultUserActivityModel defaultUserActivity) {

            new CrudeDefaultUserActivityBusiness().Insert(defaultUserActivity);

            return defaultUserActivity;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultUserActivityCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultUserActivityTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "UserActivityNote" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "OriginatingAddress" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Referrer" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/6/2020 4:41:20 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultUserActivity/CrudeDefaultUserActivityCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultUserActivity/CrudeDefaultUserActivityCreate/", content).Result;

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

        [HttpPut("crudedefaultuseractivityupdate")]
        public CrudeDefaultUserActivityModel CrudeDefaultUserActivityUpdate([Bind()] CrudeDefaultUserActivityModel defaultUserActivity) {

            new CrudeDefaultUserActivityBusiness().Update(defaultUserActivity);

            return defaultUserActivity;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultUserActivityUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultUserActivityTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "UserActivityNote" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "OriginatingAddress" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Referrer" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/6/2020 4:41:20 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultUserActivity/CrudeDefaultUserActivityUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultUserActivity/CrudeDefaultUserActivityUpdate/", content).Result;

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

        [HttpDelete("defaultuseractivitydelete/{defaultuseractivityid?}")]
        public void CrudeDefaultUserActivityDelete(System.Guid defaultUserActivityId) {

            new CrudeDefaultUserActivityBusiness().Delete(defaultUserActivityId);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultUserActivityDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultUserActivity/CrudeDefaultUserActivityDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
