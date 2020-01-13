/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:44:40 PM
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
    [Route("api/1/crudefinancialorderline")]
    public class CrudeFinancialOrderLineController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialOrderLineHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialOrderLine.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialOrderLineModel> CrudeFinancialOrderLineFetchAll() {

            List<CrudeFinancialOrderLineModel> financialOrderLines = 
                new CrudeFinancialOrderLineBusiness().FetchAll();

            return financialOrderLines;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialOrderLineFetchAllCount() {

            return new CrudeFinancialOrderLineBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialOrderLineModel> CrudeFinancialOrderLineFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialOrderLineModel> financialOrderLines = 
                new CrudeFinancialOrderLineBusiness().FetchAllWithLimit(limit);

            return financialOrderLines;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialOrderLineModel> CrudeFinancialOrderLineFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialOrderLineModel> financialOrderLines = 
                new CrudeFinancialOrderLineBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialOrderLines;
        }

        [HttpGet("fetchbyfinancialorderlineid/{financialorderlineid?}")]
        public CrudeFinancialOrderLineModel CrudeFinancialOrderLineFetchByFinancialOrderLineId(System.Guid financialorderlineid) {

            CrudeFinancialOrderLineModel financialOrderLine = 
                new CrudeFinancialOrderLineBusiness().FetchByFinancialOrderLineId(financialorderlineid);

            return financialOrderLine;
        }

        [HttpGet("fetchbyfinancialorderid/{financialorderid?}")]
        public IEnumerable<CrudeFinancialOrderLineModel> CrudeFinancialOrderLineFetchByFinancialOrderId(System.Guid financialorderid) {

            List<CrudeFinancialOrderLineModel> financialOrderLine = 
                new CrudeFinancialOrderLineBusiness().FetchByFinancialOrderId(financialorderid);

            return financialOrderLine;
        }

        [HttpGet("fetchbyfinancialunitofmeasurementrcd/{financialunitofmeasurementrcd?}")]
        public IEnumerable<CrudeFinancialOrderLineModel> CrudeFinancialOrderLineFetchByFinancialUnitOfMeasurementRcd(System.String financialunitofmeasurementrcd) {

            List<CrudeFinancialOrderLineModel> financialOrderLine = 
                new CrudeFinancialOrderLineBusiness().FetchByFinancialUnitOfMeasurementRcd(financialunitofmeasurementrcd);

            return financialOrderLine;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialOrderLineModel> CrudeFinancialOrderLineFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialOrderLineModel> financialOrderLine = 
                new CrudeFinancialOrderLineBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialOrderLine;
        }

        [HttpPost("crudefinancialorderlinecreate")]
        public CrudeFinancialOrderLineModel CrudeFinancialOrderLineCreate([Bind()] CrudeFinancialOrderLineModel financialOrderLine) {

            new CrudeFinancialOrderLineBusiness().Insert(financialOrderLine);

            return financialOrderLine;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialOrderLineCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/13/2020 5:44:40 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LineNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialUnitOfMeasurementRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "QuantityNumber" , "1" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderLine/CrudeFinancialOrderLineCreate/", content).Result;
                // todo var response = client.PostAsync("http://localhost:5000/api/1/CrudeFinancialOrderLine/CrudeFinancialOrderLineCreate/", content).Result;

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

        [HttpPut("crudefinancialorderlineupdate")]
        public CrudeFinancialOrderLineModel CrudeFinancialOrderLineUpdate([Bind()] CrudeFinancialOrderLineModel financialOrderLine) {

            new CrudeFinancialOrderLineBusiness().Update(financialOrderLine);

            return financialOrderLine;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialOrderLineUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/13/2020 5:44:40 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LineNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialUnitOfMeasurementRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "QuantityNumber" , "1" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderLine/CrudeFinancialOrderLineUpdate/", content).Result;
                // todo var response = client.PutAsync("http://localhost:5000/api/1/CrudeFinancialOrderLine/CrudeFinancialOrderLineUpdate/", content).Result;

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

        [HttpDelete("financialorderlinedelete/{financialorderlineid?}")]
        public void CrudeFinancialOrderLineDelete(System.Guid financialOrderLineId) {

            new CrudeFinancialOrderLineBusiness().Delete(financialOrderLineId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialOrderLineDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderLine/CrudeFinancialOrderLineDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
