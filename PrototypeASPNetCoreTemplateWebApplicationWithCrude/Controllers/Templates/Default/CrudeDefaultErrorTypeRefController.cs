/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:22:53 PM
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
    [Route("api/1/crudedefaulterrortyperef")]
    public class CrudeDefaultErrorTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultErrorTypeRefHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultErrorTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultErrorTypeRefModel> CrudeDefaultErrorTypeRefFetchAll() {

            List<CrudeDefaultErrorTypeRefModel> defaultErrorTypeRefs = 
                new CrudeDefaultErrorTypeRefBusiness().FetchAll();

            return defaultErrorTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultErrorTypeRefFetchAllCount() {

            return new CrudeDefaultErrorTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultErrorTypeRefModel> CrudeDefaultErrorTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultErrorTypeRefModel> defaultErrorTypeRefs = 
                new CrudeDefaultErrorTypeRefBusiness().FetchAllWithLimit(limit);

            return defaultErrorTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultErrorTypeRefModel> CrudeDefaultErrorTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultErrorTypeRefModel> defaultErrorTypeRefs = 
                new CrudeDefaultErrorTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultErrorTypeRefs;
        }

        [HttpGet("fetchbydefaulterrortypercd/{defaulterrortypercd?}")]
        public CrudeDefaultErrorTypeRefModel CrudeDefaultErrorTypeRefFetchByDefaultErrorTypeRcd(System.String defaulterrortypercd) {

            CrudeDefaultErrorTypeRefModel defaultErrorTypeRef = 
                new CrudeDefaultErrorTypeRefBusiness().FetchByDefaultErrorTypeRcd(defaulterrortypercd);

            return defaultErrorTypeRef;
        }

        [HttpPost("crudedefaulterrortyperefcreate")]
        public CrudeDefaultErrorTypeRefModel CrudeDefaultErrorTypeRefCreate([Bind()] CrudeDefaultErrorTypeRefModel defaultErrorTypeRef) {

            new CrudeDefaultErrorTypeRefBusiness().Insert(defaultErrorTypeRef);

            return defaultErrorTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultErrorTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultErrorTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultErrorTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 8:22:53 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefCreate/", content).Result;

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

        [HttpPut("crudedefaulterrortyperefupdate")]
        public CrudeDefaultErrorTypeRefModel CrudeDefaultErrorTypeRefUpdate([Bind()] CrudeDefaultErrorTypeRefModel defaultErrorTypeRef) {

            new CrudeDefaultErrorTypeRefBusiness().Update(defaultErrorTypeRef);

            return defaultErrorTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultErrorTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultErrorTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultErrorTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 8:22:53 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefUpdate/", content).Result;

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

        [HttpDelete("defaulterrortyperefdelete/{defaulterrortypercd?}")]
        public void CrudeDefaultErrorTypeRefDelete(System.String defaultErrorTypeRcd) {

            new CrudeDefaultErrorTypeRefBusiness().Delete(defaultErrorTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultErrorTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultErrorTypeRef/CrudeDefaultErrorTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
