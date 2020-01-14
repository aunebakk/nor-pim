/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:22:52 PM
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
    [Route("api/1/crudeclientdocumenttyperef")]
    public class CrudeClientDocumentTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientDocumentTypeRefHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientDocumentTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientDocumentTypeRefModel> CrudeClientDocumentTypeRefFetchAll() {

            List<CrudeClientDocumentTypeRefModel> clientDocumentTypeRefs = 
                new CrudeClientDocumentTypeRefBusiness().FetchAll();

            return clientDocumentTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientDocumentTypeRefFetchAllCount() {

            return new CrudeClientDocumentTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientDocumentTypeRefModel> CrudeClientDocumentTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientDocumentTypeRefModel> clientDocumentTypeRefs = 
                new CrudeClientDocumentTypeRefBusiness().FetchAllWithLimit(limit);

            return clientDocumentTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientDocumentTypeRefModel> CrudeClientDocumentTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientDocumentTypeRefModel> clientDocumentTypeRefs = 
                new CrudeClientDocumentTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientDocumentTypeRefs;
        }

        [HttpGet("fetchbyclientdocumenttypercd/{clientdocumenttypercd?}")]
        public CrudeClientDocumentTypeRefModel CrudeClientDocumentTypeRefFetchByClientDocumentTypeRcd(System.String clientdocumenttypercd) {

            CrudeClientDocumentTypeRefModel clientDocumentTypeRef = 
                new CrudeClientDocumentTypeRefBusiness().FetchByClientDocumentTypeRcd(clientdocumenttypercd);

            return clientDocumentTypeRef;
        }

        [HttpPost("crudeclientdocumenttyperefcreate")]
        public CrudeClientDocumentTypeRefModel CrudeClientDocumentTypeRefCreate([Bind()] CrudeClientDocumentTypeRefModel clientDocumentTypeRef) {

            new CrudeClientDocumentTypeRefBusiness().Insert(clientDocumentTypeRef);

            return clientDocumentTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeClientDocumentTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientDocumentTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientDocumentTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientDocumentTypeDescription" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 8:22:52 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientDocumentTypeRef/CrudeClientDocumentTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientDocumentTypeRef/CrudeClientDocumentTypeRefCreate/", content).Result;

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

        [HttpPut("crudeclientdocumenttyperefupdate")]
        public CrudeClientDocumentTypeRefModel CrudeClientDocumentTypeRefUpdate([Bind()] CrudeClientDocumentTypeRefModel clientDocumentTypeRef) {

            new CrudeClientDocumentTypeRefBusiness().Update(clientDocumentTypeRef);

            return clientDocumentTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeClientDocumentTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientDocumentTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientDocumentTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientDocumentTypeDescription" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 8:22:52 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientDocumentTypeRef/CrudeClientDocumentTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientDocumentTypeRef/CrudeClientDocumentTypeRefUpdate/", content).Result;

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

        [HttpDelete("clientdocumenttyperefdelete/{clientdocumenttypercd?}")]
        public void CrudeClientDocumentTypeRefDelete(System.String clientDocumentTypeRcd) {

            new CrudeClientDocumentTypeRefBusiness().Delete(clientDocumentTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeClientDocumentTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientDocumentTypeRef/CrudeClientDocumentTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
