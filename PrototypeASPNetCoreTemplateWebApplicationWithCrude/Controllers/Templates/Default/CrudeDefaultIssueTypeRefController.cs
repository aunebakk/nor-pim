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
    [Route("api/1/crudedefaultissuetyperef")]
    public class CrudeDefaultIssueTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultIssueTypeRefHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultIssueTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultIssueTypeRefModel> CrudeDefaultIssueTypeRefFetchAll() {

            List<CrudeDefaultIssueTypeRefModel> defaultIssueTypeRefs = 
                new CrudeDefaultIssueTypeRefBusiness().FetchAll();

            return defaultIssueTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultIssueTypeRefFetchAllCount() {

            return new CrudeDefaultIssueTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultIssueTypeRefModel> CrudeDefaultIssueTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultIssueTypeRefModel> defaultIssueTypeRefs = 
                new CrudeDefaultIssueTypeRefBusiness().FetchAllWithLimit(limit);

            return defaultIssueTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultIssueTypeRefModel> CrudeDefaultIssueTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultIssueTypeRefModel> defaultIssueTypeRefs = 
                new CrudeDefaultIssueTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultIssueTypeRefs;
        }

        [HttpGet("fetchbydefaultissuetypercd/{defaultissuetypercd?}")]
        public CrudeDefaultIssueTypeRefModel CrudeDefaultIssueTypeRefFetchByDefaultIssueTypeRcd(System.String defaultissuetypercd) {

            CrudeDefaultIssueTypeRefModel defaultIssueTypeRef = 
                new CrudeDefaultIssueTypeRefBusiness().FetchByDefaultIssueTypeRcd(defaultissuetypercd);

            return defaultIssueTypeRef;
        }

        [HttpGet("fetchbydefaultuserid/{defaultuserid?}")]
        public IEnumerable<CrudeDefaultIssueTypeRefModel> CrudeDefaultIssueTypeRefFetchByDefaultUserId(System.Guid defaultuserid) {

            List<CrudeDefaultIssueTypeRefModel> defaultIssueTypeRef = 
                new CrudeDefaultIssueTypeRefBusiness().FetchByDefaultUserId(defaultuserid);

            return defaultIssueTypeRef;
        }

        [HttpPost("crudedefaultissuetyperefcreate")]
        public CrudeDefaultIssueTypeRefModel CrudeDefaultIssueTypeRefCreate([Bind()] CrudeDefaultIssueTypeRefModel defaultIssueTypeRef) {

            new CrudeDefaultIssueTypeRefBusiness().Insert(defaultIssueTypeRef);

            return defaultIssueTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultIssueTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultIssueTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultIssueTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/27/2020 3:45:10 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultIssueTypeRef/CrudeDefaultIssueTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultIssueTypeRef/CrudeDefaultIssueTypeRefCreate/", content).Result;

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

        [HttpPut("crudedefaultissuetyperefupdate")]
        public CrudeDefaultIssueTypeRefModel CrudeDefaultIssueTypeRefUpdate([Bind()] CrudeDefaultIssueTypeRefModel defaultIssueTypeRef) {

            new CrudeDefaultIssueTypeRefBusiness().Update(defaultIssueTypeRef);

            return defaultIssueTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultIssueTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultIssueTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultIssueTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/27/2020 3:45:10 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultIssueTypeRef/CrudeDefaultIssueTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultIssueTypeRef/CrudeDefaultIssueTypeRefUpdate/", content).Result;

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

        [HttpDelete("defaultissuetyperefdelete/{defaultissuetypercd?}")]
        public void CrudeDefaultIssueTypeRefDelete(System.String defaultIssueTypeRcd) {

            new CrudeDefaultIssueTypeRefBusiness().Delete(defaultIssueTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultIssueTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultIssueTypeRef/CrudeDefaultIssueTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
