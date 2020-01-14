/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:47:55 AM
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
    [Route("api/1/crudelocationaddresstyperef")]
    public class CrudeLocationAddressTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeLocationAddressTypeRefHelp(
            ) {

            return View(@"Views\Templates\Location\CrudeLocationAddressTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeLocationAddressTypeRefModel> CrudeLocationAddressTypeRefFetchAll() {

            List<CrudeLocationAddressTypeRefModel> locationAddressTypeRefs = 
                new CrudeLocationAddressTypeRefBusiness().FetchAll();

            return locationAddressTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeLocationAddressTypeRefFetchAllCount() {

            return new CrudeLocationAddressTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeLocationAddressTypeRefModel> CrudeLocationAddressTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeLocationAddressTypeRefModel> locationAddressTypeRefs = 
                new CrudeLocationAddressTypeRefBusiness().FetchAllWithLimit(limit);

            return locationAddressTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeLocationAddressTypeRefModel> CrudeLocationAddressTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeLocationAddressTypeRefModel> locationAddressTypeRefs = 
                new CrudeLocationAddressTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return locationAddressTypeRefs;
        }

        [HttpGet("fetchbylocationaddresstypercd/{locationaddresstypercd?}")]
        public CrudeLocationAddressTypeRefModel CrudeLocationAddressTypeRefFetchByLocationAddressTypeRcd(System.String locationaddresstypercd) {

            CrudeLocationAddressTypeRefModel locationAddressTypeRef = 
                new CrudeLocationAddressTypeRefBusiness().FetchByLocationAddressTypeRcd(locationaddresstypercd);

            return locationAddressTypeRef;
        }

        [HttpPost("crudelocationaddresstyperefcreate")]
        public CrudeLocationAddressTypeRefModel CrudeLocationAddressTypeRefCreate([Bind()] CrudeLocationAddressTypeRefModel locationAddressTypeRef) {

            new CrudeLocationAddressTypeRefBusiness().Insert(locationAddressTypeRef);

            return locationAddressTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeLocationAddressTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "LocationAddressTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LocationAddressTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 10:47:55 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeLocationAddressTypeRef/CrudeLocationAddressTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeLocationAddressTypeRef/CrudeLocationAddressTypeRefCreate/", content).Result;

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

        [HttpPut("crudelocationaddresstyperefupdate")]
        public CrudeLocationAddressTypeRefModel CrudeLocationAddressTypeRefUpdate([Bind()] CrudeLocationAddressTypeRefModel locationAddressTypeRef) {

            new CrudeLocationAddressTypeRefBusiness().Update(locationAddressTypeRef);

            return locationAddressTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeLocationAddressTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "LocationAddressTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LocationAddressTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 10:47:55 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeLocationAddressTypeRef/CrudeLocationAddressTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeLocationAddressTypeRef/CrudeLocationAddressTypeRefUpdate/", content).Result;

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

        [HttpDelete("locationaddresstyperefdelete/{locationaddresstypercd?}")]
        public void CrudeLocationAddressTypeRefDelete(System.String locationAddressTypeRcd) {

            new CrudeLocationAddressTypeRefBusiness().Delete(locationAddressTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeLocationAddressTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeLocationAddressTypeRef/CrudeLocationAddressTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
