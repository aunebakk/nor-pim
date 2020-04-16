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
    [Route("api/1/crudefinancialorderidentifier")]
    public class CrudeFinancialOrderIdentifierController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialOrderIdentifierHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialOrderIdentifier.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialOrderIdentifierModel> CrudeFinancialOrderIdentifierFetchAll() {

            List<CrudeFinancialOrderIdentifierModel> financialOrderIdentifiers = 
                new CrudeFinancialOrderIdentifierBusiness().FetchAll();

            return financialOrderIdentifiers;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialOrderIdentifierFetchAllCount() {

            return new CrudeFinancialOrderIdentifierBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialOrderIdentifierModel> CrudeFinancialOrderIdentifierFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialOrderIdentifierModel> financialOrderIdentifiers = 
                new CrudeFinancialOrderIdentifierBusiness().FetchAllWithLimit(limit);

            return financialOrderIdentifiers;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialOrderIdentifierModel> CrudeFinancialOrderIdentifierFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialOrderIdentifierModel> financialOrderIdentifiers = 
                new CrudeFinancialOrderIdentifierBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialOrderIdentifiers;
        }

        [HttpGet("fetchbyfinancialorderidentifierid/{financialorderidentifierid?}")]
        public CrudeFinancialOrderIdentifierModel CrudeFinancialOrderIdentifierFetchByFinancialOrderIdentifierId(System.Guid financialorderidentifierid) {

            CrudeFinancialOrderIdentifierModel financialOrderIdentifier = 
                new CrudeFinancialOrderIdentifierBusiness().FetchByFinancialOrderIdentifierId(financialorderidentifierid);

            return financialOrderIdentifier;
        }

        [HttpGet("fetchbyfinancialorderid/{financialorderid?}")]
        public IEnumerable<CrudeFinancialOrderIdentifierModel> CrudeFinancialOrderIdentifierFetchByFinancialOrderId(System.Guid financialorderid) {

            List<CrudeFinancialOrderIdentifierModel> financialOrderIdentifier = 
                new CrudeFinancialOrderIdentifierBusiness().FetchByFinancialOrderId(financialorderid);

            return financialOrderIdentifier;
        }

        [HttpGet("fetchbyfinancialorderidentifiertypercd/{financialorderidentifiertypercd?}")]
        public IEnumerable<CrudeFinancialOrderIdentifierModel> CrudeFinancialOrderIdentifierFetchByFinancialOrderIdentifierTypeRcd(System.String financialorderidentifiertypercd) {

            List<CrudeFinancialOrderIdentifierModel> financialOrderIdentifier = 
                new CrudeFinancialOrderIdentifierBusiness().FetchByFinancialOrderIdentifierTypeRcd(financialorderidentifiertypercd);

            return financialOrderIdentifier;
        }

        [HttpPost("crudefinancialorderidentifiercreate")]
        public CrudeFinancialOrderIdentifierModel CrudeFinancialOrderIdentifierCreate([Bind()] CrudeFinancialOrderIdentifierModel financialOrderIdentifier) {

            new CrudeFinancialOrderIdentifierBusiness().Insert(financialOrderIdentifier);

            return financialOrderIdentifier;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialOrderIdentifierCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderIdentifierTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderIdentifierCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/16/2020 8:35:20 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderIdentifier/CrudeFinancialOrderIdentifierCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrderIdentifier/CrudeFinancialOrderIdentifierCreate/", content).Result;

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

        [HttpPut("crudefinancialorderidentifierupdate")]
        public CrudeFinancialOrderIdentifierModel CrudeFinancialOrderIdentifierUpdate([Bind()] CrudeFinancialOrderIdentifierModel financialOrderIdentifier) {

            new CrudeFinancialOrderIdentifierBusiness().Update(financialOrderIdentifier);

            return financialOrderIdentifier;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialOrderIdentifierUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderIdentifierTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderIdentifierCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/16/2020 8:35:20 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderIdentifier/CrudeFinancialOrderIdentifierUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrderIdentifier/CrudeFinancialOrderIdentifierUpdate/", content).Result;

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

        [HttpDelete("financialorderidentifierdelete/{financialorderidentifierid?}")]
        public void CrudeFinancialOrderIdentifierDelete(System.Guid financialOrderIdentifierId) {

            new CrudeFinancialOrderIdentifierBusiness().Delete(financialOrderIdentifierId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialOrderIdentifierDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderIdentifier/CrudeFinancialOrderIdentifierDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
