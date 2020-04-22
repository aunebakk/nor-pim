/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:37:57 AM
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
    [Route("api/1/crudeclientaddresstyperef")]
    public class CrudeClientAddressTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientAddressTypeRefHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientAddressTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientAddressTypeRefModel> CrudeClientAddressTypeRefFetchAll() {

            List<CrudeClientAddressTypeRefModel> clientAddressTypeRefs = 
                new CrudeClientAddressTypeRefBusiness().FetchAll();

            return clientAddressTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientAddressTypeRefFetchAllCount() {

            return new CrudeClientAddressTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientAddressTypeRefModel> CrudeClientAddressTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientAddressTypeRefModel> clientAddressTypeRefs = 
                new CrudeClientAddressTypeRefBusiness().FetchAllWithLimit(limit);

            return clientAddressTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientAddressTypeRefModel> CrudeClientAddressTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientAddressTypeRefModel> clientAddressTypeRefs = 
                new CrudeClientAddressTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientAddressTypeRefs;
        }

        [HttpGet("fetchbyclientaddresstypercd/{clientaddresstypercd?}")]
        public CrudeClientAddressTypeRefModel CrudeClientAddressTypeRefFetchByClientAddressTypeRcd(System.String clientaddresstypercd) {

            CrudeClientAddressTypeRefModel clientAddressTypeRef = 
                new CrudeClientAddressTypeRefBusiness().FetchByClientAddressTypeRcd(clientaddresstypercd);

            return clientAddressTypeRef;
        }

        [HttpPost("crudeclientaddresstyperefcreate")]
        public CrudeClientAddressTypeRefModel CrudeClientAddressTypeRefCreate([Bind()] CrudeClientAddressTypeRefModel clientAddressTypeRef) {

            new CrudeClientAddressTypeRefBusiness().Insert(clientAddressTypeRef);

            return clientAddressTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeClientAddressTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientAddressTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientAddressTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientAddressTypeDescription" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 5:37:57 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientAddressTypeRef/CrudeClientAddressTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientAddressTypeRef/CrudeClientAddressTypeRefCreate/", content).Result;

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

        [HttpPut("crudeclientaddresstyperefupdate")]
        public CrudeClientAddressTypeRefModel CrudeClientAddressTypeRefUpdate([Bind()] CrudeClientAddressTypeRefModel clientAddressTypeRef) {

            new CrudeClientAddressTypeRefBusiness().Update(clientAddressTypeRef);

            return clientAddressTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeClientAddressTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientAddressTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientAddressTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientAddressTypeDescription" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 5:37:57 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientAddressTypeRef/CrudeClientAddressTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientAddressTypeRef/CrudeClientAddressTypeRefUpdate/", content).Result;

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

        [HttpDelete("clientaddresstyperefdelete/{clientaddresstypercd?}")]
        public void CrudeClientAddressTypeRefDelete(System.String clientAddressTypeRcd) {

            new CrudeClientAddressTypeRefBusiness().Delete(clientAddressTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeClientAddressTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientAddressTypeRef/CrudeClientAddressTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
