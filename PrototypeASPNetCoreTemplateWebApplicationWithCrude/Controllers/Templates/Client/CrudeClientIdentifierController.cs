/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:35:20 PM
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
    [Route("api/1/crudeclientidentifier")]
    public class CrudeClientIdentifierController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientIdentifierHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientIdentifier.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientIdentifierModel> CrudeClientIdentifierFetchAll() {

            List<CrudeClientIdentifierModel> clientIdentifiers = 
                new CrudeClientIdentifierBusiness().FetchAll();

            return clientIdentifiers;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientIdentifierFetchAllCount() {

            return new CrudeClientIdentifierBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientIdentifierModel> CrudeClientIdentifierFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientIdentifierModel> clientIdentifiers = 
                new CrudeClientIdentifierBusiness().FetchAllWithLimit(limit);

            return clientIdentifiers;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientIdentifierModel> CrudeClientIdentifierFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientIdentifierModel> clientIdentifiers = 
                new CrudeClientIdentifierBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientIdentifiers;
        }

        [HttpGet("fetchbyclientidentifierid/{clientidentifierid?}")]
        public CrudeClientIdentifierModel CrudeClientIdentifierFetchByClientIdentifierId(System.Guid clientidentifierid) {

            CrudeClientIdentifierModel clientIdentifier = 
                new CrudeClientIdentifierBusiness().FetchByClientIdentifierId(clientidentifierid);

            return clientIdentifier;
        }

        [HttpGet("fetchbyclientid/{clientid?}")]
        public IEnumerable<CrudeClientIdentifierModel> CrudeClientIdentifierFetchByClientId(System.Guid clientid) {

            List<CrudeClientIdentifierModel> clientIdentifier = 
                new CrudeClientIdentifierBusiness().FetchByClientId(clientid);

            return clientIdentifier;
        }

        [HttpGet("fetchbyclientidentifiertypercd/{clientidentifiertypercd?}")]
        public IEnumerable<CrudeClientIdentifierModel> CrudeClientIdentifierFetchByClientIdentifierTypeRcd(System.String clientidentifiertypercd) {

            List<CrudeClientIdentifierModel> clientIdentifier = 
                new CrudeClientIdentifierBusiness().FetchByClientIdentifierTypeRcd(clientidentifiertypercd);

            return clientIdentifier;
        }

        [HttpPost("crudeclientidentifiercreate")]
        public CrudeClientIdentifierModel CrudeClientIdentifierCreate([Bind()] CrudeClientIdentifierModel clientIdentifier) {

            new CrudeClientIdentifierBusiness().Insert(clientIdentifier);

            return clientIdentifier;
        }

        [HttpGet("createtest")]
        public string CrudeClientIdentifierCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientIdentifierTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientIdentifierCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/16/2020 8:35:20 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientIdentifier/CrudeClientIdentifierCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientIdentifier/CrudeClientIdentifierCreate/", content).Result;

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

        [HttpPut("crudeclientidentifierupdate")]
        public CrudeClientIdentifierModel CrudeClientIdentifierUpdate([Bind()] CrudeClientIdentifierModel clientIdentifier) {

            new CrudeClientIdentifierBusiness().Update(clientIdentifier);

            return clientIdentifier;
        }

        [HttpGet("updatetest")]
        public string CrudeClientIdentifierUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientIdentifierTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientIdentifierCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/16/2020 8:35:20 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientIdentifier/CrudeClientIdentifierUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientIdentifier/CrudeClientIdentifierUpdate/", content).Result;

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

        [HttpDelete("clientidentifierdelete/{clientidentifierid?}")]
        public void CrudeClientIdentifierDelete(System.Guid clientIdentifierId) {

            new CrudeClientIdentifierBusiness().Delete(clientIdentifierId);
        }

        [HttpGet("deletetest")]
        public string CrudeClientIdentifierDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientIdentifier/CrudeClientIdentifierDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
