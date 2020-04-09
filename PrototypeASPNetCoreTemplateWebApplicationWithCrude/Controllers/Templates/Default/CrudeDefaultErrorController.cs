/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:26:46 AM
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
    [Route("api/1/crudedefaulterror")]
    public class CrudeDefaultErrorController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultErrorHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultError.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultErrorModel> CrudeDefaultErrorFetchAll() {

            List<CrudeDefaultErrorModel> defaultErrors = 
                new CrudeDefaultErrorBusiness().FetchAll();

            return defaultErrors;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultErrorFetchAllCount() {

            return new CrudeDefaultErrorBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultErrorModel> CrudeDefaultErrorFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultErrorModel> defaultErrors = 
                new CrudeDefaultErrorBusiness().FetchAllWithLimit(limit);

            return defaultErrors;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultErrorModel> CrudeDefaultErrorFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultErrorModel> defaultErrors = 
                new CrudeDefaultErrorBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultErrors;
        }

        [HttpGet("fetchbydefaulterrorid/{defaulterrorid?}")]
        public CrudeDefaultErrorModel CrudeDefaultErrorFetchByDefaultErrorId(System.Guid defaulterrorid) {

            CrudeDefaultErrorModel defaultError = 
                new CrudeDefaultErrorBusiness().FetchByDefaultErrorId(defaulterrorid);

            return defaultError;
        }

        [HttpGet("fetchbymethodname/{methodname?}")]
        public CrudeDefaultErrorModel CrudeDefaultErrorFetchByMethodName(System.String methodname) {

            CrudeDefaultErrorModel defaultError = 
                new CrudeDefaultErrorBusiness().FetchByMethodName(methodname);

            return defaultError;
        }

        [HttpGet("fetchbydefaulterrorlayerrcd/{defaulterrorlayerrcd?}")]
        public IEnumerable<CrudeDefaultErrorModel> CrudeDefaultErrorFetchByDefaultErrorLayerRcd(System.String defaulterrorlayerrcd) {

            List<CrudeDefaultErrorModel> defaultError = 
                new CrudeDefaultErrorBusiness().FetchByDefaultErrorLayerRcd(defaulterrorlayerrcd);

            return defaultError;
        }

        [HttpGet("fetchbydefaulterrortypercd/{defaulterrortypercd?}")]
        public IEnumerable<CrudeDefaultErrorModel> CrudeDefaultErrorFetchByDefaultErrorTypeRcd(System.String defaulterrortypercd) {

            List<CrudeDefaultErrorModel> defaultError = 
                new CrudeDefaultErrorBusiness().FetchByDefaultErrorTypeRcd(defaulterrortypercd);

            return defaultError;
        }

        [HttpGet("fetchbydefaultuserid/{defaultuserid?}")]
        public IEnumerable<CrudeDefaultErrorModel> CrudeDefaultErrorFetchByDefaultUserId(System.Guid defaultuserid) {

            List<CrudeDefaultErrorModel> defaultError = 
                new CrudeDefaultErrorBusiness().FetchByDefaultUserId(defaultuserid);

            return defaultError;
        }

        [HttpPost("crudedefaulterrorcreate")]
        public CrudeDefaultErrorModel CrudeDefaultErrorCreate([Bind()] CrudeDefaultErrorModel defaultError) {

            new CrudeDefaultErrorBusiness().Insert(defaultError);

            return defaultError;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultErrorCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultErrorLayerRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultErrorTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LayerAddress" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ErrorMessage" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StackTrace" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "MethodName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DomainName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClassName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/9/2020 7:26:46 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultError/CrudeDefaultErrorCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultError/CrudeDefaultErrorCreate/", content).Result;

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

        [HttpPut("crudedefaulterrorupdate")]
        public CrudeDefaultErrorModel CrudeDefaultErrorUpdate([Bind()] CrudeDefaultErrorModel defaultError) {

            new CrudeDefaultErrorBusiness().Update(defaultError);

            return defaultError;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultErrorUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultErrorLayerRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultErrorTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LayerAddress" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ErrorMessage" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StackTrace" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "MethodName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DomainName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClassName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/9/2020 7:26:46 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultError/CrudeDefaultErrorUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultError/CrudeDefaultErrorUpdate/", content).Result;

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

        [HttpDelete("defaulterrordelete/{defaulterrorid?}")]
        public void CrudeDefaultErrorDelete(System.Guid defaultErrorId) {

            new CrudeDefaultErrorBusiness().Delete(defaultErrorId);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultErrorDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultError/CrudeDefaultErrorDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
