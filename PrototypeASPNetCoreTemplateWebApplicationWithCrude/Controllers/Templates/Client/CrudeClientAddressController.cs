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
    [Route("api/1/crudeclientaddress")]
    public class CrudeClientAddressController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientAddressHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientAddress.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientAddressModel> CrudeClientAddressFetchAll() {

            List<CrudeClientAddressModel> clientAddresss = 
                new CrudeClientAddressBusiness().FetchAll();

            return clientAddresss;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientAddressFetchAllCount() {

            return new CrudeClientAddressBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientAddressModel> CrudeClientAddressFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientAddressModel> clientAddresss = 
                new CrudeClientAddressBusiness().FetchAllWithLimit(limit);

            return clientAddresss;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientAddressModel> CrudeClientAddressFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientAddressModel> clientAddresss = 
                new CrudeClientAddressBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientAddresss;
        }

        [HttpGet("fetchbyclientaddressid/{clientaddressid?}")]
        public CrudeClientAddressModel CrudeClientAddressFetchByClientAddressId(System.Guid clientaddressid) {

            CrudeClientAddressModel clientAddress = 
                new CrudeClientAddressBusiness().FetchByClientAddressId(clientaddressid);

            return clientAddress;
        }

        [HttpGet("fetchbyaddresslineonename/{addresslineonename?}")]
        public CrudeClientAddressModel CrudeClientAddressFetchByAddressLineOneName(System.String addresslineonename) {

            CrudeClientAddressModel clientAddress = 
                new CrudeClientAddressBusiness().FetchByAddressLineOneName(addresslineonename);

            return clientAddress;
        }

        [HttpGet("fetchbyclientaddresstypercd/{clientaddresstypercd?}")]
        public IEnumerable<CrudeClientAddressModel> CrudeClientAddressFetchByClientAddressTypeRcd(System.String clientaddresstypercd) {

            List<CrudeClientAddressModel> clientAddress = 
                new CrudeClientAddressBusiness().FetchByClientAddressTypeRcd(clientaddresstypercd);

            return clientAddress;
        }

        [HttpPost("crudeclientaddresscreate")]
        public CrudeClientAddressModel CrudeClientAddressCreate([Bind()] CrudeClientAddressModel clientAddress) {

            new CrudeClientAddressBusiness().Insert(clientAddress);

            return clientAddress;
        }

        [HttpGet("createtest")]
        public string CrudeClientAddressCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientAddressTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AddressLineOneName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AddressLineTwoName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AddressLineThreeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "CityName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StreetName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StateName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DistrictName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProvinceName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ZipCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "PoBox" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 8:22:58 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientAddress/CrudeClientAddressCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientAddress/CrudeClientAddressCreate/", content).Result;

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

        [HttpPut("crudeclientaddressupdate")]
        public CrudeClientAddressModel CrudeClientAddressUpdate([Bind()] CrudeClientAddressModel clientAddress) {

            new CrudeClientAddressBusiness().Update(clientAddress);

            return clientAddress;
        }

        [HttpGet("updatetest")]
        public string CrudeClientAddressUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientAddressTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AddressLineOneName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AddressLineTwoName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AddressLineThreeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "CityName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StreetName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StateName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DistrictName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProvinceName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ZipCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "PoBox" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 8:22:58 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientAddress/CrudeClientAddressUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientAddress/CrudeClientAddressUpdate/", content).Result;

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

        [HttpDelete("clientaddressdelete/{clientaddressid?}")]
        public void CrudeClientAddressDelete(System.Guid clientAddressId) {

            new CrudeClientAddressBusiness().Delete(clientAddressId);
        }

        [HttpGet("deletetest")]
        public string CrudeClientAddressDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientAddress/CrudeClientAddressDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
