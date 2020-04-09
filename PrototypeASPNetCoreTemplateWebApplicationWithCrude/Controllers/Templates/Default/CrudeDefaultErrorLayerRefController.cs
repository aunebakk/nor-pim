/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:38:52 PM
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
    [Route("api/1/crudedefaulterrorlayerref")]
    public class CrudeDefaultErrorLayerRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultErrorLayerRefHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultErrorLayerRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultErrorLayerRefModel> CrudeDefaultErrorLayerRefFetchAll() {

            List<CrudeDefaultErrorLayerRefModel> defaultErrorLayerRefs = 
                new CrudeDefaultErrorLayerRefBusiness().FetchAll();

            return defaultErrorLayerRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultErrorLayerRefFetchAllCount() {

            return new CrudeDefaultErrorLayerRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultErrorLayerRefModel> CrudeDefaultErrorLayerRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultErrorLayerRefModel> defaultErrorLayerRefs = 
                new CrudeDefaultErrorLayerRefBusiness().FetchAllWithLimit(limit);

            return defaultErrorLayerRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultErrorLayerRefModel> CrudeDefaultErrorLayerRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultErrorLayerRefModel> defaultErrorLayerRefs = 
                new CrudeDefaultErrorLayerRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultErrorLayerRefs;
        }

        [HttpGet("fetchbydefaulterrorlayerrcd/{defaulterrorlayerrcd?}")]
        public CrudeDefaultErrorLayerRefModel CrudeDefaultErrorLayerRefFetchByDefaultErrorLayerRcd(System.String defaulterrorlayerrcd) {

            CrudeDefaultErrorLayerRefModel defaultErrorLayerRef = 
                new CrudeDefaultErrorLayerRefBusiness().FetchByDefaultErrorLayerRcd(defaulterrorlayerrcd);

            return defaultErrorLayerRef;
        }

        [HttpPost("crudedefaulterrorlayerrefcreate")]
        public CrudeDefaultErrorLayerRefModel CrudeDefaultErrorLayerRefCreate([Bind()] CrudeDefaultErrorLayerRefModel defaultErrorLayerRef) {

            new CrudeDefaultErrorLayerRefBusiness().Insert(defaultErrorLayerRef);

            return defaultErrorLayerRef;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultErrorLayerRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultErrorLayerRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultErrorLayerName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/9/2020 5:38:52 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefCreate/", content).Result;

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

        [HttpPut("crudedefaulterrorlayerrefupdate")]
        public CrudeDefaultErrorLayerRefModel CrudeDefaultErrorLayerRefUpdate([Bind()] CrudeDefaultErrorLayerRefModel defaultErrorLayerRef) {

            new CrudeDefaultErrorLayerRefBusiness().Update(defaultErrorLayerRef);

            return defaultErrorLayerRef;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultErrorLayerRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultErrorLayerRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultErrorLayerName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/9/2020 5:38:52 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefUpdate/", content).Result;

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

        [HttpDelete("defaulterrorlayerrefdelete/{defaulterrorlayerrcd?}")]
        public void CrudeDefaultErrorLayerRefDelete(System.String defaultErrorLayerRcd) {

            new CrudeDefaultErrorLayerRefBusiness().Delete(defaultErrorLayerRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultErrorLayerRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultErrorLayerRef/CrudeDefaultErrorLayerRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
