/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:45:10 PM
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
    [Route("api/1/crudeclient")]
    public class CrudeClientController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClient.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchAll() {

            List<CrudeClientModel> clients = 
                new CrudeClientBusiness().FetchAll();

            return clients;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientFetchAllCount() {

            return new CrudeClientBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientModel> clients = 
                new CrudeClientBusiness().FetchAllWithLimit(limit);

            return clients;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientModel> clients = 
                new CrudeClientBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clients;
        }

        [HttpGet("fetchbyclientid/{clientid?}")]
        public CrudeClientModel CrudeClientFetchByClientId(System.Guid clientid) {

            CrudeClientModel client = 
                new CrudeClientBusiness().FetchByClientId(clientid);

            return client;
        }

        [HttpGet("fetchbyfirstname/{firstname?}")]
        public CrudeClientModel CrudeClientFetchByFirstName(System.String firstname) {

            CrudeClientModel client = 
                new CrudeClientBusiness().FetchByFirstName(firstname);

            return client;
        }

        [HttpGet("fetchbyclienttypercd/{clienttypercd?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByClientTypeRcd(System.String clienttypercd) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByClientTypeRcd(clienttypercd);

            return client;
        }

        [HttpGet("fetchbyclientnationalityrcd/{clientnationalityrcd?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByClientNationalityRcd(System.String clientnationalityrcd) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByClientNationalityRcd(clientnationalityrcd);

            return client;
        }

        [HttpGet("fetchbyclientgenderrcd/{clientgenderrcd?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByClientGenderRcd(System.String clientgenderrcd) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByClientGenderRcd(clientgenderrcd);

            return client;
        }

        [HttpGet("fetchbyclienttitlercd/{clienttitlercd?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByClientTitleRcd(System.String clienttitlercd) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByClientTitleRcd(clienttitlercd);

            return client;
        }

        [HttpGet("fetchbyclientaddressid/{clientaddressid?}")]
        public IEnumerable<CrudeClientModel> CrudeClientFetchByClientAddressId(System.Guid clientaddressid) {

            List<CrudeClientModel> client = 
                new CrudeClientBusiness().FetchByClientAddressId(clientaddressid);

            return client;
        }

        [HttpPost("crudeclientcreate")]
        public CrudeClientModel CrudeClientCreate([Bind()] CrudeClientModel client) {

            new CrudeClientBusiness().Insert(client);

            return client;
        }

        [HttpGet("createtest")]
        public string CrudeClientCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientNationalityRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientGenderRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTitleRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FirstName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "MiddleName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LastName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ImageBlobFilename" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/27/2020 3:45:10 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClient/CrudeClientCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClient/CrudeClientCreate/", content).Result;

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

        [HttpPut("crudeclientupdate")]
        public CrudeClientModel CrudeClientUpdate([Bind()] CrudeClientModel client) {

            new CrudeClientBusiness().Update(client);

            return client;
        }

        [HttpGet("updatetest")]
        public string CrudeClientUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientNationalityRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientGenderRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTitleRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FirstName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "MiddleName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LastName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ImageBlobFilename" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/27/2020 3:45:10 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClient/CrudeClientUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClient/CrudeClientUpdate/", content).Result;

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

        [HttpDelete("clientdelete/{clientid?}")]
        public void CrudeClientDelete(System.Guid clientId) {

            new CrudeClientBusiness().Delete(clientId);
        }

        [HttpGet("deletetest")]
        public string CrudeClientDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClient/CrudeClientDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
