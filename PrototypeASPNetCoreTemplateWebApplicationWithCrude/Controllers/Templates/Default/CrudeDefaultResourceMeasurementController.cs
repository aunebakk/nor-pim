/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:24 PM
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
    [Route("api/1/crudedefaultresourcemeasurement")]
    public class CrudeDefaultResourceMeasurementController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultResourceMeasurementHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultResourceMeasurement.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultResourceMeasurementModel> CrudeDefaultResourceMeasurementFetchAll() {

            List<CrudeDefaultResourceMeasurementModel> defaultResourceMeasurements = 
                new CrudeDefaultResourceMeasurementBusiness().FetchAll();

            return defaultResourceMeasurements;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultResourceMeasurementFetchAllCount() {

            return new CrudeDefaultResourceMeasurementBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultResourceMeasurementModel> CrudeDefaultResourceMeasurementFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultResourceMeasurementModel> defaultResourceMeasurements = 
                new CrudeDefaultResourceMeasurementBusiness().FetchAllWithLimit(limit);

            return defaultResourceMeasurements;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultResourceMeasurementModel> CrudeDefaultResourceMeasurementFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultResourceMeasurementModel> defaultResourceMeasurements = 
                new CrudeDefaultResourceMeasurementBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultResourceMeasurements;
        }

        [HttpGet("fetchbydefaultresourcemeasurementid/{defaultresourcemeasurementid?}")]
        public CrudeDefaultResourceMeasurementModel CrudeDefaultResourceMeasurementFetchByDefaultResourceMeasurementId(System.Guid defaultresourcemeasurementid) {

            CrudeDefaultResourceMeasurementModel defaultResourceMeasurement = 
                new CrudeDefaultResourceMeasurementBusiness().FetchByDefaultResourceMeasurementId(defaultresourcemeasurementid);

            return defaultResourceMeasurement;
        }

        [HttpPost("crudedefaultresourcemeasurementcreate")]
        public CrudeDefaultResourceMeasurementModel CrudeDefaultResourceMeasurementCreate([Bind()] CrudeDefaultResourceMeasurementModel defaultResourceMeasurement) {

            new CrudeDefaultResourceMeasurementBusiness().Insert(defaultResourceMeasurement);

            return defaultResourceMeasurement;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultResourceMeasurementCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientWorkingsetBytes" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BusinessWorkingsetBytes" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DatabaseSizeBytes" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 3:02:24 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultResourceMeasurement/CrudeDefaultResourceMeasurementCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultResourceMeasurement/CrudeDefaultResourceMeasurementCreate/", content).Result;

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

        [HttpPut("crudedefaultresourcemeasurementupdate")]
        public CrudeDefaultResourceMeasurementModel CrudeDefaultResourceMeasurementUpdate([Bind()] CrudeDefaultResourceMeasurementModel defaultResourceMeasurement) {

            new CrudeDefaultResourceMeasurementBusiness().Update(defaultResourceMeasurement);

            return defaultResourceMeasurement;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultResourceMeasurementUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientWorkingsetBytes" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "BusinessWorkingsetBytes" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DatabaseSizeBytes" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 3:02:24 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultResourceMeasurement/CrudeDefaultResourceMeasurementUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultResourceMeasurement/CrudeDefaultResourceMeasurementUpdate/", content).Result;

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

        [HttpDelete("defaultresourcemeasurementdelete/{defaultresourcemeasurementid?}")]
        public void CrudeDefaultResourceMeasurementDelete(System.Guid defaultResourceMeasurementId) {

            new CrudeDefaultResourceMeasurementBusiness().Delete(defaultResourceMeasurementId);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultResourceMeasurementDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultResourceMeasurement/CrudeDefaultResourceMeasurementDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
