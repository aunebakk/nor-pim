/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:41:18 PM
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
    [Route("api/1/crudeclientidentifiertyperef")]
    public class CrudeClientIdentifierTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientIdentifierTypeRefHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientIdentifierTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientIdentifierTypeRefModel> CrudeClientIdentifierTypeRefFetchAll() {

            List<CrudeClientIdentifierTypeRefModel> clientIdentifierTypeRefs = 
                new CrudeClientIdentifierTypeRefBusiness().FetchAll();

            return clientIdentifierTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientIdentifierTypeRefFetchAllCount() {

            return new CrudeClientIdentifierTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientIdentifierTypeRefModel> CrudeClientIdentifierTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientIdentifierTypeRefModel> clientIdentifierTypeRefs = 
                new CrudeClientIdentifierTypeRefBusiness().FetchAllWithLimit(limit);

            return clientIdentifierTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientIdentifierTypeRefModel> CrudeClientIdentifierTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientIdentifierTypeRefModel> clientIdentifierTypeRefs = 
                new CrudeClientIdentifierTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientIdentifierTypeRefs;
        }

        [HttpGet("fetchbyclientidentifiertypercd/{clientidentifiertypercd?}")]
        public CrudeClientIdentifierTypeRefModel CrudeClientIdentifierTypeRefFetchByClientIdentifierTypeRcd(System.String clientidentifiertypercd) {

            CrudeClientIdentifierTypeRefModel clientIdentifierTypeRef = 
                new CrudeClientIdentifierTypeRefBusiness().FetchByClientIdentifierTypeRcd(clientidentifiertypercd);

            return clientIdentifierTypeRef;
        }

        [HttpPost("crudeclientidentifiertyperefcreate")]
        public CrudeClientIdentifierTypeRefModel CrudeClientIdentifierTypeRefCreate([Bind()] CrudeClientIdentifierTypeRefModel clientIdentifierTypeRef) {

            new CrudeClientIdentifierTypeRefBusiness().Insert(clientIdentifierTypeRef);

            return clientIdentifierTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeClientIdentifierTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientIdentifierTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientIdentifierTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientIdentifierTypeDescription" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/6/2020 4:41:18 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefCreate/", content).Result;

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

        [HttpPut("crudeclientidentifiertyperefupdate")]
        public CrudeClientIdentifierTypeRefModel CrudeClientIdentifierTypeRefUpdate([Bind()] CrudeClientIdentifierTypeRefModel clientIdentifierTypeRef) {

            new CrudeClientIdentifierTypeRefBusiness().Update(clientIdentifierTypeRef);

            return clientIdentifierTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeClientIdentifierTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientIdentifierTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientIdentifierTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientIdentifierTypeDescription" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/6/2020 4:41:18 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefUpdate/", content).Result;

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

        [HttpDelete("clientidentifiertyperefdelete/{clientidentifiertypercd?}")]
        public void CrudeClientIdentifierTypeRefDelete(System.String clientIdentifierTypeRcd) {

            new CrudeClientIdentifierTypeRefBusiness().Delete(clientIdentifierTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeClientIdentifierTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientIdentifierTypeRef/CrudeClientIdentifierTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
