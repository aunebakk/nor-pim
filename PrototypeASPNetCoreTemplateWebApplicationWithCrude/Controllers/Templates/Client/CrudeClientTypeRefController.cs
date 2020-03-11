/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:20:52 PM
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
    [Route("api/1/crudeclienttyperef")]
    public class CrudeClientTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientTypeRefHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientTypeRefModel> CrudeClientTypeRefFetchAll() {

            List<CrudeClientTypeRefModel> clientTypeRefs = 
                new CrudeClientTypeRefBusiness().FetchAll();

            return clientTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientTypeRefFetchAllCount() {

            return new CrudeClientTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientTypeRefModel> CrudeClientTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientTypeRefModel> clientTypeRefs = 
                new CrudeClientTypeRefBusiness().FetchAllWithLimit(limit);

            return clientTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientTypeRefModel> CrudeClientTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientTypeRefModel> clientTypeRefs = 
                new CrudeClientTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientTypeRefs;
        }

        [HttpGet("fetchbyclienttypercd/{clienttypercd?}")]
        public CrudeClientTypeRefModel CrudeClientTypeRefFetchByClientTypeRcd(System.String clienttypercd) {

            CrudeClientTypeRefModel clientTypeRef = 
                new CrudeClientTypeRefBusiness().FetchByClientTypeRcd(clienttypercd);

            return clientTypeRef;
        }

        [HttpPost("crudeclienttyperefcreate")]
        public CrudeClientTypeRefModel CrudeClientTypeRefCreate([Bind()] CrudeClientTypeRefModel clientTypeRef) {

            new CrudeClientTypeRefBusiness().Insert(clientTypeRef);

            return clientTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeClientTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTypeDescription" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 9:20:52 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientTypeRef/CrudeClientTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientTypeRef/CrudeClientTypeRefCreate/", content).Result;

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

        [HttpPut("crudeclienttyperefupdate")]
        public CrudeClientTypeRefModel CrudeClientTypeRefUpdate([Bind()] CrudeClientTypeRefModel clientTypeRef) {

            new CrudeClientTypeRefBusiness().Update(clientTypeRef);

            return clientTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeClientTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTypeDescription" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 9:20:52 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientTypeRef/CrudeClientTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientTypeRef/CrudeClientTypeRefUpdate/", content).Result;

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

        [HttpDelete("clienttyperefdelete/{clienttypercd?}")]
        public void CrudeClientTypeRefDelete(System.String clientTypeRcd) {

            new CrudeClientTypeRefBusiness().Delete(clientTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeClientTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientTypeRef/CrudeClientTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
