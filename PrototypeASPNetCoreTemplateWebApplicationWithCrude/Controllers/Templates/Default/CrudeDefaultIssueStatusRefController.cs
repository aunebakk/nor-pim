/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:19 AM
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
    [Route("api/1/crudedefaultissuestatusref")]
    public class CrudeDefaultIssueStatusRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultIssueStatusRefHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultIssueStatusRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultIssueStatusRefModel> CrudeDefaultIssueStatusRefFetchAll() {

            List<CrudeDefaultIssueStatusRefModel> defaultIssueStatusRefs = 
                new CrudeDefaultIssueStatusRefBusiness().FetchAll();

            return defaultIssueStatusRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultIssueStatusRefFetchAllCount() {

            return new CrudeDefaultIssueStatusRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultIssueStatusRefModel> CrudeDefaultIssueStatusRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultIssueStatusRefModel> defaultIssueStatusRefs = 
                new CrudeDefaultIssueStatusRefBusiness().FetchAllWithLimit(limit);

            return defaultIssueStatusRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultIssueStatusRefModel> CrudeDefaultIssueStatusRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultIssueStatusRefModel> defaultIssueStatusRefs = 
                new CrudeDefaultIssueStatusRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultIssueStatusRefs;
        }

        [HttpGet("fetchbydefaultissuestatusrcd/{defaultissuestatusrcd?}")]
        public CrudeDefaultIssueStatusRefModel CrudeDefaultIssueStatusRefFetchByDefaultIssueStatusRcd(System.String defaultissuestatusrcd) {

            CrudeDefaultIssueStatusRefModel defaultIssueStatusRef = 
                new CrudeDefaultIssueStatusRefBusiness().FetchByDefaultIssueStatusRcd(defaultissuestatusrcd);

            return defaultIssueStatusRef;
        }

        [HttpGet("fetchbydefaultuserid/{defaultuserid?}")]
        public IEnumerable<CrudeDefaultIssueStatusRefModel> CrudeDefaultIssueStatusRefFetchByDefaultUserId(System.Guid defaultuserid) {

            List<CrudeDefaultIssueStatusRefModel> defaultIssueStatusRef = 
                new CrudeDefaultIssueStatusRefBusiness().FetchByDefaultUserId(defaultuserid);

            return defaultIssueStatusRef;
        }

        [HttpPost("crudedefaultissuestatusrefcreate")]
        public CrudeDefaultIssueStatusRefModel CrudeDefaultIssueStatusRefCreate([Bind()] CrudeDefaultIssueStatusRefModel defaultIssueStatusRef) {

            new CrudeDefaultIssueStatusRefBusiness().Insert(defaultIssueStatusRef);

            return defaultIssueStatusRef;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultIssueStatusRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultIssueStatusRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultIssueStatusName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:19 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultIssueStatusRef/CrudeDefaultIssueStatusRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultIssueStatusRef/CrudeDefaultIssueStatusRefCreate/", content).Result;

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

        [HttpPut("crudedefaultissuestatusrefupdate")]
        public CrudeDefaultIssueStatusRefModel CrudeDefaultIssueStatusRefUpdate([Bind()] CrudeDefaultIssueStatusRefModel defaultIssueStatusRef) {

            new CrudeDefaultIssueStatusRefBusiness().Update(defaultIssueStatusRef);

            return defaultIssueStatusRef;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultIssueStatusRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultIssueStatusRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultIssueStatusName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:19 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultIssueStatusRef/CrudeDefaultIssueStatusRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultIssueStatusRef/CrudeDefaultIssueStatusRefUpdate/", content).Result;

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

        [HttpDelete("defaultissuestatusrefdelete/{defaultissuestatusrcd?}")]
        public void CrudeDefaultIssueStatusRefDelete(System.String defaultIssueStatusRcd) {

            new CrudeDefaultIssueStatusRefBusiness().Delete(defaultIssueStatusRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultIssueStatusRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultIssueStatusRef/CrudeDefaultIssueStatusRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
