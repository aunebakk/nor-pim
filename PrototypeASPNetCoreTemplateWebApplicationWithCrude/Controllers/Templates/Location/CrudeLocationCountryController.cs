/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:45:51 AM
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
    [Route("api/1/crudelocationcountry")]
    public class CrudeLocationCountryController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeLocationCountryHelp(
            ) {

            return View(@"Views\Templates\Location\CrudeLocationCountry.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeLocationCountryModel> CrudeLocationCountryFetchAll() {

            List<CrudeLocationCountryModel> locationCountrys = 
                new CrudeLocationCountryBusiness().FetchAll();

            return locationCountrys;
        }

        [HttpGet("fetchallcount")]
        public int CrudeLocationCountryFetchAllCount() {

            return new CrudeLocationCountryBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeLocationCountryModel> CrudeLocationCountryFetchAllWithLimit(
                string limit
                ) {

            List<CrudeLocationCountryModel> locationCountrys = 
                new CrudeLocationCountryBusiness().FetchAllWithLimit(limit);

            return locationCountrys;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeLocationCountryModel> CrudeLocationCountryFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeLocationCountryModel> locationCountrys = 
                new CrudeLocationCountryBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return locationCountrys;
        }

        [HttpGet("fetchbylocationcountryid/{locationcountryid?}")]
        public CrudeLocationCountryModel CrudeLocationCountryFetchByLocationCountryId(System.Guid locationcountryid) {

            CrudeLocationCountryModel locationCountry = 
                new CrudeLocationCountryBusiness().FetchByLocationCountryId(locationcountryid);

            return locationCountry;
        }

        [HttpGet("fetchbylocationcountryname/{locationcountryname?}")]
        public CrudeLocationCountryModel CrudeLocationCountryFetchByLocationCountryName(System.String locationcountryname) {

            CrudeLocationCountryModel locationCountry = 
                new CrudeLocationCountryBusiness().FetchByLocationCountryName(locationcountryname);

            return locationCountry;
        }

        [HttpPost("crudelocationcountrycreate")]
        public CrudeLocationCountryModel CrudeLocationCountryCreate([Bind()] CrudeLocationCountryModel locationCountry) {

            new CrudeLocationCountryBusiness().Insert(locationCountry);

            return locationCountry;
        }

        [HttpGet("createtest")]
        public string CrudeLocationCountryCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "LocationCountryCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LocationCountryName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:51 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeLocationCountry/CrudeLocationCountryCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeLocationCountry/CrudeLocationCountryCreate/", content).Result;

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

        [HttpPut("crudelocationcountryupdate")]
        public CrudeLocationCountryModel CrudeLocationCountryUpdate([Bind()] CrudeLocationCountryModel locationCountry) {

            new CrudeLocationCountryBusiness().Update(locationCountry);

            return locationCountry;
        }

        [HttpGet("updatetest")]
        public string CrudeLocationCountryUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "LocationCountryCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LocationCountryName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:51 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeLocationCountry/CrudeLocationCountryUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeLocationCountry/CrudeLocationCountryUpdate/", content).Result;

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

        [HttpDelete("locationcountrydelete/{locationcountryid?}")]
        public void CrudeLocationCountryDelete(System.Guid locationCountryId) {

            new CrudeLocationCountryBusiness().Delete(locationCountryId);
        }

        [HttpGet("deletetest")]
        public string CrudeLocationCountryDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeLocationCountry/CrudeLocationCountryDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
