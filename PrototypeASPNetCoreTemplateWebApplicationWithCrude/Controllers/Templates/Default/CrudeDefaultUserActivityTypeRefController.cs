/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 7:01:22 AM
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
    [Route("api/1/crudedefaultuseractivitytyperef")]
    public class CrudeDefaultUserActivityTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultUserActivityTypeRefHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultUserActivityTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultUserActivityTypeRefModel> CrudeDefaultUserActivityTypeRefFetchAll() {

            List<CrudeDefaultUserActivityTypeRefModel> defaultUserActivityTypeRefs = 
                new CrudeDefaultUserActivityTypeRefBusiness().FetchAll();

            return defaultUserActivityTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultUserActivityTypeRefFetchAllCount() {

            return new CrudeDefaultUserActivityTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultUserActivityTypeRefModel> CrudeDefaultUserActivityTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultUserActivityTypeRefModel> defaultUserActivityTypeRefs = 
                new CrudeDefaultUserActivityTypeRefBusiness().FetchAllWithLimit(limit);

            return defaultUserActivityTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultUserActivityTypeRefModel> CrudeDefaultUserActivityTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultUserActivityTypeRefModel> defaultUserActivityTypeRefs = 
                new CrudeDefaultUserActivityTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultUserActivityTypeRefs;
        }

        [HttpGet("fetchbydefaultuseractivitytypercd/{defaultuseractivitytypercd?}")]
        public CrudeDefaultUserActivityTypeRefModel CrudeDefaultUserActivityTypeRefFetchByDefaultUserActivityTypeRcd(System.String defaultuseractivitytypercd) {

            CrudeDefaultUserActivityTypeRefModel defaultUserActivityTypeRef = 
                new CrudeDefaultUserActivityTypeRefBusiness().FetchByDefaultUserActivityTypeRcd(defaultuseractivitytypercd);

            return defaultUserActivityTypeRef;
        }

        [HttpPost("crudedefaultuseractivitytyperefcreate")]
        public CrudeDefaultUserActivityTypeRefModel CrudeDefaultUserActivityTypeRefCreate([Bind()] CrudeDefaultUserActivityTypeRefModel defaultUserActivityTypeRef) {

            new CrudeDefaultUserActivityTypeRefBusiness().Insert(defaultUserActivityTypeRef);

            return defaultUserActivityTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultUserActivityTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultUserActivityTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultUserActivityTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 7:01:22 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefCreate/", content).Result;

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

        [HttpPut("crudedefaultuseractivitytyperefupdate")]
        public CrudeDefaultUserActivityTypeRefModel CrudeDefaultUserActivityTypeRefUpdate([Bind()] CrudeDefaultUserActivityTypeRefModel defaultUserActivityTypeRef) {

            new CrudeDefaultUserActivityTypeRefBusiness().Update(defaultUserActivityTypeRef);

            return defaultUserActivityTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultUserActivityTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultUserActivityTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultUserActivityTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 7:01:22 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefUpdate/", content).Result;

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

        [HttpDelete("defaultuseractivitytyperefdelete/{defaultuseractivitytypercd?}")]
        public void CrudeDefaultUserActivityTypeRefDelete(System.String defaultUserActivityTypeRcd) {

            new CrudeDefaultUserActivityTypeRefBusiness().Delete(defaultUserActivityTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultUserActivityTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultUserActivityTypeRef/CrudeDefaultUserActivityTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
