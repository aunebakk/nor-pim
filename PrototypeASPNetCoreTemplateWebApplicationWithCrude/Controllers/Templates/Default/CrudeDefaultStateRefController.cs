/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:22:58 AM
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
    [Route("api/1/crudedefaultstateref")]
    public class CrudeDefaultStateRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultStateRefHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultStateRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultStateRefModel> CrudeDefaultStateRefFetchAll() {

            List<CrudeDefaultStateRefModel> defaultStateRefs = 
                new CrudeDefaultStateRefBusiness().FetchAll();

            return defaultStateRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultStateRefFetchAllCount() {

            return new CrudeDefaultStateRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultStateRefModel> CrudeDefaultStateRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultStateRefModel> defaultStateRefs = 
                new CrudeDefaultStateRefBusiness().FetchAllWithLimit(limit);

            return defaultStateRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultStateRefModel> CrudeDefaultStateRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultStateRefModel> defaultStateRefs = 
                new CrudeDefaultStateRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultStateRefs;
        }

        [HttpGet("fetchbydefaultstatercd/{defaultstatercd?}")]
        public CrudeDefaultStateRefModel CrudeDefaultStateRefFetchByDefaultStateRcd(System.String defaultstatercd) {

            CrudeDefaultStateRefModel defaultStateRef = 
                new CrudeDefaultStateRefBusiness().FetchByDefaultStateRcd(defaultstatercd);

            return defaultStateRef;
        }

        [HttpPost("crudedefaultstaterefcreate")]
        public CrudeDefaultStateRefModel CrudeDefaultStateRefCreate([Bind()] CrudeDefaultStateRefModel defaultStateRef) {

            new CrudeDefaultStateRefBusiness().Insert(defaultStateRef);

            return defaultStateRef;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultStateRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultStateRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultStateName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 8:22:58 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultStateRef/CrudeDefaultStateRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultStateRef/CrudeDefaultStateRefCreate/", content).Result;

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

        [HttpPut("crudedefaultstaterefupdate")]
        public CrudeDefaultStateRefModel CrudeDefaultStateRefUpdate([Bind()] CrudeDefaultStateRefModel defaultStateRef) {

            new CrudeDefaultStateRefBusiness().Update(defaultStateRef);

            return defaultStateRef;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultStateRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultStateRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultStateName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 8:22:58 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultStateRef/CrudeDefaultStateRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultStateRef/CrudeDefaultStateRefUpdate/", content).Result;

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

        [HttpDelete("defaultstaterefdelete/{defaultstatercd?}")]
        public void CrudeDefaultStateRefDelete(System.String defaultStateRcd) {

            new CrudeDefaultStateRefBusiness().Delete(defaultStateRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultStateRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultStateRef/CrudeDefaultStateRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
