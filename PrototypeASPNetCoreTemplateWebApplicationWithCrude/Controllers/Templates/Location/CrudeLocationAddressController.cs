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
    [Route("api/1/crudelocationaddress")]
    public class CrudeLocationAddressController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeLocationAddressHelp(
            ) {

            return View(@"Views\Templates\Location\CrudeLocationAddress.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeLocationAddressModel> CrudeLocationAddressFetchAll() {

            List<CrudeLocationAddressModel> locationAddresss = 
                new CrudeLocationAddressBusiness().FetchAll();

            return locationAddresss;
        }

        [HttpGet("fetchallcount")]
        public int CrudeLocationAddressFetchAllCount() {

            return new CrudeLocationAddressBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeLocationAddressModel> CrudeLocationAddressFetchAllWithLimit(
                string limit
                ) {

            List<CrudeLocationAddressModel> locationAddresss = 
                new CrudeLocationAddressBusiness().FetchAllWithLimit(limit);

            return locationAddresss;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeLocationAddressModel> CrudeLocationAddressFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeLocationAddressModel> locationAddresss = 
                new CrudeLocationAddressBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return locationAddresss;
        }

        [HttpGet("fetchbylocationaddressid/{locationaddressid?}")]
        public CrudeLocationAddressModel CrudeLocationAddressFetchByLocationAddressId(System.Guid locationaddressid) {

            CrudeLocationAddressModel locationAddress = 
                new CrudeLocationAddressBusiness().FetchByLocationAddressId(locationaddressid);

            return locationAddress;
        }

        [HttpGet("fetchbylocationaddresstypercd/{locationaddresstypercd?}")]
        public IEnumerable<CrudeLocationAddressModel> CrudeLocationAddressFetchByLocationAddressTypeRcd(System.String locationaddresstypercd) {

            List<CrudeLocationAddressModel> locationAddress = 
                new CrudeLocationAddressBusiness().FetchByLocationAddressTypeRcd(locationaddresstypercd);

            return locationAddress;
        }

        [HttpGet("fetchbylocationcountryid/{locationcountryid?}")]
        public IEnumerable<CrudeLocationAddressModel> CrudeLocationAddressFetchByLocationCountryId(System.Guid locationcountryid) {

            List<CrudeLocationAddressModel> locationAddress = 
                new CrudeLocationAddressBusiness().FetchByLocationCountryId(locationcountryid);

            return locationAddress;
        }

        [HttpPost("crudelocationaddresscreate")]
        public CrudeLocationAddressModel CrudeLocationAddressCreate([Bind()] CrudeLocationAddressModel locationAddress) {

            new CrudeLocationAddressBusiness().Insert(locationAddress);

            return locationAddress;
        }

        [HttpGet("createtest")]
        public string CrudeLocationAddressCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "LocationAddressTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AddressOne" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AddressTwo" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AddressThree" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "City" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Street" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "State" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "District" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Province" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ZipCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "PoBox" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:51 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeLocationAddress/CrudeLocationAddressCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeLocationAddress/CrudeLocationAddressCreate/", content).Result;

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

        [HttpPut("crudelocationaddressupdate")]
        public CrudeLocationAddressModel CrudeLocationAddressUpdate([Bind()] CrudeLocationAddressModel locationAddress) {

            new CrudeLocationAddressBusiness().Update(locationAddress);

            return locationAddress;
        }

        [HttpGet("updatetest")]
        public string CrudeLocationAddressUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "LocationAddressTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AddressOne" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AddressTwo" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AddressThree" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "City" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Street" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "State" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "District" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Province" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ZipCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "PoBox" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:51 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeLocationAddress/CrudeLocationAddressUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeLocationAddress/CrudeLocationAddressUpdate/", content).Result;

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

        [HttpDelete("locationaddressdelete/{locationaddressid?}")]
        public void CrudeLocationAddressDelete(System.Guid locationAddressId) {

            new CrudeLocationAddressBusiness().Delete(locationAddressId);
        }

        [HttpGet("deletetest")]
        public string CrudeLocationAddressDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeLocationAddress/CrudeLocationAddressDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
