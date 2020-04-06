/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:41:21 PM
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
    [Route("api/1/crudefinancialorderevent")]
    public class CrudeFinancialOrderEventController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialOrderEventHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialOrderEvent.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialOrderEventModel> CrudeFinancialOrderEventFetchAll() {

            List<CrudeFinancialOrderEventModel> financialOrderEvents = 
                new CrudeFinancialOrderEventBusiness().FetchAll();

            return financialOrderEvents;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialOrderEventFetchAllCount() {

            return new CrudeFinancialOrderEventBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialOrderEventModel> CrudeFinancialOrderEventFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialOrderEventModel> financialOrderEvents = 
                new CrudeFinancialOrderEventBusiness().FetchAllWithLimit(limit);

            return financialOrderEvents;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialOrderEventModel> CrudeFinancialOrderEventFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialOrderEventModel> financialOrderEvents = 
                new CrudeFinancialOrderEventBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialOrderEvents;
        }

        [HttpGet("fetchbyfiancialordereventid/{fiancialordereventid?}")]
        public CrudeFinancialOrderEventModel CrudeFinancialOrderEventFetchByFiancialOrderEventId(System.Guid fiancialordereventid) {

            CrudeFinancialOrderEventModel financialOrderEvent = 
                new CrudeFinancialOrderEventBusiness().FetchByFiancialOrderEventId(fiancialordereventid);

            return financialOrderEvent;
        }

        [HttpGet("fetchbyfinancialorderid/{financialorderid?}")]
        public IEnumerable<CrudeFinancialOrderEventModel> CrudeFinancialOrderEventFetchByFinancialOrderId(System.Guid financialorderid) {

            List<CrudeFinancialOrderEventModel> financialOrderEvent = 
                new CrudeFinancialOrderEventBusiness().FetchByFinancialOrderId(financialorderid);

            return financialOrderEvent;
        }

        [HttpGet("fetchbyfinancialordereventtypercd/{financialordereventtypercd?}")]
        public IEnumerable<CrudeFinancialOrderEventModel> CrudeFinancialOrderEventFetchByFinancialOrderEventTypeRcd(System.String financialordereventtypercd) {

            List<CrudeFinancialOrderEventModel> financialOrderEvent = 
                new CrudeFinancialOrderEventBusiness().FetchByFinancialOrderEventTypeRcd(financialordereventtypercd);

            return financialOrderEvent;
        }

        [HttpPost("crudefinancialordereventcreate")]
        public CrudeFinancialOrderEventModel CrudeFinancialOrderEventCreate([Bind()] CrudeFinancialOrderEventModel financialOrderEvent) {

            new CrudeFinancialOrderEventBusiness().Insert(financialOrderEvent);

            return financialOrderEvent;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialOrderEventCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/6/2020 4:41:21 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderEventTypeRcd" , "create" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderEvent/CrudeFinancialOrderEventCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrderEvent/CrudeFinancialOrderEventCreate/", content).Result;

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

        [HttpPut("crudefinancialordereventupdate")]
        public CrudeFinancialOrderEventModel CrudeFinancialOrderEventUpdate([Bind()] CrudeFinancialOrderEventModel financialOrderEvent) {

            new CrudeFinancialOrderEventBusiness().Update(financialOrderEvent);

            return financialOrderEvent;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialOrderEventUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/6/2020 4:41:21 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderEventTypeRcd" , "update" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderEvent/CrudeFinancialOrderEventUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrderEvent/CrudeFinancialOrderEventUpdate/", content).Result;

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

        [HttpDelete("financialordereventdelete/{fiancialordereventid?}")]
        public void CrudeFinancialOrderEventDelete(System.Guid fiancialOrderEventId) {

            new CrudeFinancialOrderEventBusiness().Delete(fiancialOrderEventId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialOrderEventDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderEvent/CrudeFinancialOrderEventDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
