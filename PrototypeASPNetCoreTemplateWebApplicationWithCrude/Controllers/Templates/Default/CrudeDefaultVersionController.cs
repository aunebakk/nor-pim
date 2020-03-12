/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:44:06 PM
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
    [Route("api/1/crudedefaultversion")]
    public class CrudeDefaultVersionController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultVersionHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultVersion.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultVersionModel> CrudeDefaultVersionFetchAll() {

            List<CrudeDefaultVersionModel> defaultVersions = 
                new CrudeDefaultVersionBusiness().FetchAll();

            return defaultVersions;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultVersionFetchAllCount() {

            return new CrudeDefaultVersionBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultVersionModel> CrudeDefaultVersionFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultVersionModel> defaultVersions = 
                new CrudeDefaultVersionBusiness().FetchAllWithLimit(limit);

            return defaultVersions;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultVersionModel> CrudeDefaultVersionFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultVersionModel> defaultVersions = 
                new CrudeDefaultVersionBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultVersions;
        }

        [HttpGet("fetchbydefaultversionid/{defaultversionid?}")]
        public CrudeDefaultVersionModel CrudeDefaultVersionFetchByDefaultVersionId(System.Guid defaultversionid) {

            CrudeDefaultVersionModel defaultVersion = 
                new CrudeDefaultVersionBusiness().FetchByDefaultVersionId(defaultversionid);

            return defaultVersion;
        }

        [HttpPost("crudedefaultversioncreate")]
        public CrudeDefaultVersionModel CrudeDefaultVersionCreate([Bind()] CrudeDefaultVersionModel defaultVersion) {

            new CrudeDefaultVersionBusiness().Insert(defaultVersion);

            return defaultVersion;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultVersionCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FunVersion" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Number" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "MajorNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "MinorNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SequenceNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/12/2020 12:44:06 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultVersion/CrudeDefaultVersionCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultVersion/CrudeDefaultVersionCreate/", content).Result;

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

        [HttpPut("crudedefaultversionupdate")]
        public CrudeDefaultVersionModel CrudeDefaultVersionUpdate([Bind()] CrudeDefaultVersionModel defaultVersion) {

            new CrudeDefaultVersionBusiness().Update(defaultVersion);

            return defaultVersion;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultVersionUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FunVersion" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Number" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "MajorNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "MinorNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SequenceNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/12/2020 12:44:06 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultVersion/CrudeDefaultVersionUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultVersion/CrudeDefaultVersionUpdate/", content).Result;

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

        [HttpDelete("defaultversiondelete/{defaultversionid?}")]
        public void CrudeDefaultVersionDelete(System.Guid defaultVersionId) {

            new CrudeDefaultVersionBusiness().Delete(defaultVersionId);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultVersionDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultVersion/CrudeDefaultVersionDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
