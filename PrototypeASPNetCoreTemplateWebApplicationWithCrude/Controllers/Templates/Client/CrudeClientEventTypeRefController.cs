/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:17 AM
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
    [Route("api/1/crudeclienteventtyperef")]
    public class CrudeClientEventTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientEventTypeRefHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientEventTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientEventTypeRefModel> CrudeClientEventTypeRefFetchAll() {

            List<CrudeClientEventTypeRefModel> clientEventTypeRefs = 
                new CrudeClientEventTypeRefBusiness().FetchAll();

            return clientEventTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientEventTypeRefFetchAllCount() {

            return new CrudeClientEventTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientEventTypeRefModel> CrudeClientEventTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientEventTypeRefModel> clientEventTypeRefs = 
                new CrudeClientEventTypeRefBusiness().FetchAllWithLimit(limit);

            return clientEventTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientEventTypeRefModel> CrudeClientEventTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientEventTypeRefModel> clientEventTypeRefs = 
                new CrudeClientEventTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientEventTypeRefs;
        }

        [HttpGet("fetchbyclienteventtypercd/{clienteventtypercd?}")]
        public CrudeClientEventTypeRefModel CrudeClientEventTypeRefFetchByClientEventTypeRcd(System.String clienteventtypercd) {

            CrudeClientEventTypeRefModel clientEventTypeRef = 
                new CrudeClientEventTypeRefBusiness().FetchByClientEventTypeRcd(clienteventtypercd);

            return clientEventTypeRef;
        }

        [HttpPost("crudeclienteventtyperefcreate")]
        public CrudeClientEventTypeRefModel CrudeClientEventTypeRefCreate([Bind()] CrudeClientEventTypeRefModel clientEventTypeRef) {

            new CrudeClientEventTypeRefBusiness().Insert(clientEventTypeRef);

            return clientEventTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeClientEventTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientEventTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientEventTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientEventTypeDescription" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:17 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientEventTypeRef/CrudeClientEventTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientEventTypeRef/CrudeClientEventTypeRefCreate/", content).Result;

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

        [HttpPut("crudeclienteventtyperefupdate")]
        public CrudeClientEventTypeRefModel CrudeClientEventTypeRefUpdate([Bind()] CrudeClientEventTypeRefModel clientEventTypeRef) {

            new CrudeClientEventTypeRefBusiness().Update(clientEventTypeRef);

            return clientEventTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeClientEventTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientEventTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientEventTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientEventTypeDescription" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:17 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientEventTypeRef/CrudeClientEventTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientEventTypeRef/CrudeClientEventTypeRefUpdate/", content).Result;

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

        [HttpDelete("clienteventtyperefdelete/{clienteventtypercd?}")]
        public void CrudeClientEventTypeRefDelete(System.String clientEventTypeRcd) {

            new CrudeClientEventTypeRefBusiness().Delete(clientEventTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeClientEventTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientEventTypeRef/CrudeClientEventTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
