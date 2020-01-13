/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:44:44 PM
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
    [Route("api/1/crudelocationcity")]
    public class CrudeLocationCityController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeLocationCityHelp(
            ) {

            return View(@"Views\Templates\Location\CrudeLocationCity.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeLocationCityModel> CrudeLocationCityFetchAll() {

            List<CrudeLocationCityModel> locationCitys = 
                new CrudeLocationCityBusiness().FetchAll();

            return locationCitys;
        }

        [HttpGet("fetchallcount")]
        public int CrudeLocationCityFetchAllCount() {

            return new CrudeLocationCityBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeLocationCityModel> CrudeLocationCityFetchAllWithLimit(
                string limit
                ) {

            List<CrudeLocationCityModel> locationCitys = 
                new CrudeLocationCityBusiness().FetchAllWithLimit(limit);

            return locationCitys;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeLocationCityModel> CrudeLocationCityFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeLocationCityModel> locationCitys = 
                new CrudeLocationCityBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return locationCitys;
        }

        [HttpGet("fetchbylocationcityid/{locationcityid?}")]
        public CrudeLocationCityModel CrudeLocationCityFetchByLocationCityId(System.Guid locationcityid) {

            CrudeLocationCityModel locationCity = 
                new CrudeLocationCityBusiness().FetchByLocationCityId(locationcityid);

            return locationCity;
        }

        [HttpGet("fetchbylocationcityname/{locationcityname?}")]
        public CrudeLocationCityModel CrudeLocationCityFetchByLocationCityName(System.String locationcityname) {

            CrudeLocationCityModel locationCity = 
                new CrudeLocationCityBusiness().FetchByLocationCityName(locationcityname);

            return locationCity;
        }

        [HttpGet("fetchbylocationcountryid/{locationcountryid?}")]
        public IEnumerable<CrudeLocationCityModel> CrudeLocationCityFetchByLocationCountryId(System.Guid locationcountryid) {

            List<CrudeLocationCityModel> locationCity = 
                new CrudeLocationCityBusiness().FetchByLocationCountryId(locationcountryid);

            return locationCity;
        }

        [HttpPost("crudelocationcitycreate")]
        public CrudeLocationCityModel CrudeLocationCityCreate([Bind()] CrudeLocationCityModel locationCity) {

            new CrudeLocationCityBusiness().Insert(locationCity);

            return locationCity;
        }

        [HttpGet("createtest")]
        public string CrudeLocationCityCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "LocationCityCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LocationCityName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/13/2020 5:44:44 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeLocationCity/CrudeLocationCityCreate/", content).Result;
                // todo var response = client.PostAsync("http://localhost:5000/api/1/CrudeLocationCity/CrudeLocationCityCreate/", content).Result;

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

        [HttpPut("crudelocationcityupdate")]
        public CrudeLocationCityModel CrudeLocationCityUpdate([Bind()] CrudeLocationCityModel locationCity) {

            new CrudeLocationCityBusiness().Update(locationCity);

            return locationCity;
        }

        [HttpGet("updatetest")]
        public string CrudeLocationCityUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "LocationCityCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LocationCityName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/13/2020 5:44:44 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeLocationCity/CrudeLocationCityUpdate/", content).Result;
                // todo var response = client.PutAsync("http://localhost:5000/api/1/CrudeLocationCity/CrudeLocationCityUpdate/", content).Result;

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

        [HttpDelete("locationcitydelete/{locationcityid?}")]
        public void CrudeLocationCityDelete(System.Guid locationCityId) {

            new CrudeLocationCityBusiness().Delete(locationCityId);
        }

        [HttpGet("deletetest")]
        public string CrudeLocationCityDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeLocationCity/CrudeLocationCityDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
