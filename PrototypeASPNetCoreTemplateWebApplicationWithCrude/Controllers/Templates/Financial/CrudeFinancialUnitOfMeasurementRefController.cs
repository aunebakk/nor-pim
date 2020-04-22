/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 7:01:24 AM
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
    [Route("api/1/crudefinancialunitofmeasurementref")]
    public class CrudeFinancialUnitOfMeasurementRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialUnitOfMeasurementRefHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialUnitOfMeasurementRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialUnitOfMeasurementRefModel> CrudeFinancialUnitOfMeasurementRefFetchAll() {

            List<CrudeFinancialUnitOfMeasurementRefModel> financialUnitOfMeasurementRefs = 
                new CrudeFinancialUnitOfMeasurementRefBusiness().FetchAll();

            return financialUnitOfMeasurementRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialUnitOfMeasurementRefFetchAllCount() {

            return new CrudeFinancialUnitOfMeasurementRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialUnitOfMeasurementRefModel> CrudeFinancialUnitOfMeasurementRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialUnitOfMeasurementRefModel> financialUnitOfMeasurementRefs = 
                new CrudeFinancialUnitOfMeasurementRefBusiness().FetchAllWithLimit(limit);

            return financialUnitOfMeasurementRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialUnitOfMeasurementRefModel> CrudeFinancialUnitOfMeasurementRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialUnitOfMeasurementRefModel> financialUnitOfMeasurementRefs = 
                new CrudeFinancialUnitOfMeasurementRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialUnitOfMeasurementRefs;
        }

        [HttpGet("fetchbyfinancialunitofmeasurementrcd/{financialunitofmeasurementrcd?}")]
        public CrudeFinancialUnitOfMeasurementRefModel CrudeFinancialUnitOfMeasurementRefFetchByFinancialUnitOfMeasurementRcd(System.String financialunitofmeasurementrcd) {

            CrudeFinancialUnitOfMeasurementRefModel financialUnitOfMeasurementRef = 
                new CrudeFinancialUnitOfMeasurementRefBusiness().FetchByFinancialUnitOfMeasurementRcd(financialunitofmeasurementrcd);

            return financialUnitOfMeasurementRef;
        }

        [HttpPost("crudefinancialunitofmeasurementrefcreate")]
        public CrudeFinancialUnitOfMeasurementRefModel CrudeFinancialUnitOfMeasurementRefCreate([Bind()] CrudeFinancialUnitOfMeasurementRefModel financialUnitOfMeasurementRef) {

            new CrudeFinancialUnitOfMeasurementRefBusiness().Insert(financialUnitOfMeasurementRef);

            return financialUnitOfMeasurementRef;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialUnitOfMeasurementRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialUnitOfMeasurementRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortSequenceNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StatusCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialUnitOfMeasurementName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialUnitOfMeasurementCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 7:01:24 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialUnitOfMeasurementRef/CrudeFinancialUnitOfMeasurementRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialUnitOfMeasurementRef/CrudeFinancialUnitOfMeasurementRefCreate/", content).Result;

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

        [HttpPut("crudefinancialunitofmeasurementrefupdate")]
        public CrudeFinancialUnitOfMeasurementRefModel CrudeFinancialUnitOfMeasurementRefUpdate([Bind()] CrudeFinancialUnitOfMeasurementRefModel financialUnitOfMeasurementRef) {

            new CrudeFinancialUnitOfMeasurementRefBusiness().Update(financialUnitOfMeasurementRef);

            return financialUnitOfMeasurementRef;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialUnitOfMeasurementRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialUnitOfMeasurementRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortSequenceNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StatusCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialUnitOfMeasurementName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialUnitOfMeasurementCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 7:01:24 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialUnitOfMeasurementRef/CrudeFinancialUnitOfMeasurementRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialUnitOfMeasurementRef/CrudeFinancialUnitOfMeasurementRefUpdate/", content).Result;

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

        [HttpDelete("financialunitofmeasurementrefdelete/{financialunitofmeasurementrcd?}")]
        public void CrudeFinancialUnitOfMeasurementRefDelete(System.String financialUnitOfMeasurementRcd) {

            new CrudeFinancialUnitOfMeasurementRefBusiness().Delete(financialUnitOfMeasurementRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialUnitOfMeasurementRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialUnitOfMeasurementRef/CrudeFinancialUnitOfMeasurementRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
