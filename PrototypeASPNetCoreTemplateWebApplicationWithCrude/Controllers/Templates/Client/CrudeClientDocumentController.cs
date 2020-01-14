/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:29:01 AM
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
    [Route("api/1/crudeclientdocument")]
    public class CrudeClientDocumentController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientDocumentHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientDocument.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientDocumentModel> CrudeClientDocumentFetchAll() {

            List<CrudeClientDocumentModel> clientDocuments = 
                new CrudeClientDocumentBusiness().FetchAll();

            return clientDocuments;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientDocumentFetchAllCount() {

            return new CrudeClientDocumentBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientDocumentModel> CrudeClientDocumentFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientDocumentModel> clientDocuments = 
                new CrudeClientDocumentBusiness().FetchAllWithLimit(limit);

            return clientDocuments;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientDocumentModel> CrudeClientDocumentFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientDocumentModel> clientDocuments = 
                new CrudeClientDocumentBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientDocuments;
        }

        [HttpGet("fetchbyclientdocumentid/{clientdocumentid?}")]
        public CrudeClientDocumentModel CrudeClientDocumentFetchByClientDocumentId(System.Guid clientdocumentid) {

            CrudeClientDocumentModel clientDocument = 
                new CrudeClientDocumentBusiness().FetchByClientDocumentId(clientdocumentid);

            return clientDocument;
        }

        [HttpGet("fetchbydocumentname/{documentname?}")]
        public CrudeClientDocumentModel CrudeClientDocumentFetchByDocumentName(System.String documentname) {

            CrudeClientDocumentModel clientDocument = 
                new CrudeClientDocumentBusiness().FetchByDocumentName(documentname);

            return clientDocument;
        }

        [HttpGet("fetchbyclientid/{clientid?}")]
        public IEnumerable<CrudeClientDocumentModel> CrudeClientDocumentFetchByClientId(System.Guid clientid) {

            List<CrudeClientDocumentModel> clientDocument = 
                new CrudeClientDocumentBusiness().FetchByClientId(clientid);

            return clientDocument;
        }

        [HttpGet("fetchbyclientdocumenttypercd/{clientdocumenttypercd?}")]
        public IEnumerable<CrudeClientDocumentModel> CrudeClientDocumentFetchByClientDocumentTypeRcd(System.String clientdocumenttypercd) {

            List<CrudeClientDocumentModel> clientDocument = 
                new CrudeClientDocumentBusiness().FetchByClientDocumentTypeRcd(clientdocumenttypercd);

            return clientDocument;
        }

        [HttpPost("crudeclientdocumentcreate")]
        public CrudeClientDocumentModel CrudeClientDocumentCreate([Bind()] CrudeClientDocumentModel clientDocument) {

            new CrudeClientDocumentBusiness().Insert(clientDocument);

            return clientDocument;
        }

        [HttpGet("createtest")]
        public string CrudeClientDocumentCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientDocumentTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DocumentName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DocumentDateTime" , "1/14/2020 7:29:01 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ExpiryDateTime" , "1/14/2020 7:29:01 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:29:01 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientDocument/CrudeClientDocumentCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientDocument/CrudeClientDocumentCreate/", content).Result;

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

        [HttpPut("crudeclientdocumentupdate")]
        public CrudeClientDocumentModel CrudeClientDocumentUpdate([Bind()] CrudeClientDocumentModel clientDocument) {

            new CrudeClientDocumentBusiness().Update(clientDocument);

            return clientDocument;
        }

        [HttpGet("updatetest")]
        public string CrudeClientDocumentUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientDocumentTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DocumentName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DocumentDateTime" , "1/14/2020 7:29:01 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ExpiryDateTime" , "1/14/2020 7:29:01 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:29:01 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientDocument/CrudeClientDocumentUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientDocument/CrudeClientDocumentUpdate/", content).Result;

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

        [HttpDelete("clientdocumentdelete/{clientdocumentid?}")]
        public void CrudeClientDocumentDelete(System.Guid clientDocumentId) {

            new CrudeClientDocumentBusiness().Delete(clientDocumentId);
        }

        [HttpGet("deletetest")]
        public string CrudeClientDocumentDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientDocument/CrudeClientDocumentDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
