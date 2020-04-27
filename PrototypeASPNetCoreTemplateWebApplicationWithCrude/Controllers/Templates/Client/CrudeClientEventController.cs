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
    [Route("api/1/crudeclientevent")]
    public class CrudeClientEventController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientEventHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientEvent.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientEventModel> CrudeClientEventFetchAll() {

            List<CrudeClientEventModel> clientEvents = 
                new CrudeClientEventBusiness().FetchAll();

            return clientEvents;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientEventFetchAllCount() {

            return new CrudeClientEventBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientEventModel> CrudeClientEventFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientEventModel> clientEvents = 
                new CrudeClientEventBusiness().FetchAllWithLimit(limit);

            return clientEvents;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientEventModel> CrudeClientEventFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientEventModel> clientEvents = 
                new CrudeClientEventBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientEvents;
        }

        [HttpGet("fetchbyclienteventid/{clienteventid?}")]
        public CrudeClientEventModel CrudeClientEventFetchByClientEventId(System.Guid clienteventid) {

            CrudeClientEventModel clientEvent = 
                new CrudeClientEventBusiness().FetchByClientEventId(clienteventid);

            return clientEvent;
        }

        [HttpGet("fetchbyclientid/{clientid?}")]
        public IEnumerable<CrudeClientEventModel> CrudeClientEventFetchByClientId(System.Guid clientid) {

            List<CrudeClientEventModel> clientEvent = 
                new CrudeClientEventBusiness().FetchByClientId(clientid);

            return clientEvent;
        }

        [HttpGet("fetchbyclienteventtypercd/{clienteventtypercd?}")]
        public IEnumerable<CrudeClientEventModel> CrudeClientEventFetchByClientEventTypeRcd(System.String clienteventtypercd) {

            List<CrudeClientEventModel> clientEvent = 
                new CrudeClientEventBusiness().FetchByClientEventTypeRcd(clienteventtypercd);

            return clientEvent;
        }

        [HttpPost("crudeclienteventcreate")]
        public CrudeClientEventModel CrudeClientEventCreate([Bind()] CrudeClientEventModel clientEvent) {

            new CrudeClientEventBusiness().Insert(clientEvent);

            return clientEvent;
        }

        [HttpGet("createtest")]
        public string CrudeClientEventCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientEventTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/27/2020 3:45:10 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientEvent/CrudeClientEventCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientEvent/CrudeClientEventCreate/", content).Result;

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

        [HttpPut("crudeclienteventupdate")]
        public CrudeClientEventModel CrudeClientEventUpdate([Bind()] CrudeClientEventModel clientEvent) {

            new CrudeClientEventBusiness().Update(clientEvent);

            return clientEvent;
        }

        [HttpGet("updatetest")]
        public string CrudeClientEventUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientEventTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/27/2020 3:45:10 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientEvent/CrudeClientEventUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientEvent/CrudeClientEventUpdate/", content).Result;

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

        [HttpDelete("clienteventdelete/{clienteventid?}")]
        public void CrudeClientEventDelete(System.Guid clientEventId) {

            new CrudeClientEventBusiness().Delete(clientEventId);
        }

        [HttpGet("deletetest")]
        public string CrudeClientEventDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientEvent/CrudeClientEventDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
