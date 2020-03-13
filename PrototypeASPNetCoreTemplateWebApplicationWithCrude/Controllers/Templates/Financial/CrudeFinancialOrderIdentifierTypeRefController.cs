/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:45:49 AM
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
    [Route("api/1/crudefinancialorderidentifiertyperef")]
    public class CrudeFinancialOrderIdentifierTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialOrderIdentifierTypeRefHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialOrderIdentifierTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialOrderIdentifierTypeRefModel> CrudeFinancialOrderIdentifierTypeRefFetchAll() {

            List<CrudeFinancialOrderIdentifierTypeRefModel> financialOrderIdentifierTypeRefs = 
                new CrudeFinancialOrderIdentifierTypeRefBusiness().FetchAll();

            return financialOrderIdentifierTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialOrderIdentifierTypeRefFetchAllCount() {

            return new CrudeFinancialOrderIdentifierTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialOrderIdentifierTypeRefModel> CrudeFinancialOrderIdentifierTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialOrderIdentifierTypeRefModel> financialOrderIdentifierTypeRefs = 
                new CrudeFinancialOrderIdentifierTypeRefBusiness().FetchAllWithLimit(limit);

            return financialOrderIdentifierTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialOrderIdentifierTypeRefModel> CrudeFinancialOrderIdentifierTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialOrderIdentifierTypeRefModel> financialOrderIdentifierTypeRefs = 
                new CrudeFinancialOrderIdentifierTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialOrderIdentifierTypeRefs;
        }

        [HttpGet("fetchbyfinancialorderidentifiertypercd/{financialorderidentifiertypercd?}")]
        public CrudeFinancialOrderIdentifierTypeRefModel CrudeFinancialOrderIdentifierTypeRefFetchByFinancialOrderIdentifierTypeRcd(System.String financialorderidentifiertypercd) {

            CrudeFinancialOrderIdentifierTypeRefModel financialOrderIdentifierTypeRef = 
                new CrudeFinancialOrderIdentifierTypeRefBusiness().FetchByFinancialOrderIdentifierTypeRcd(financialorderidentifiertypercd);

            return financialOrderIdentifierTypeRef;
        }

        [HttpPost("crudefinancialorderidentifiertyperefcreate")]
        public CrudeFinancialOrderIdentifierTypeRefModel CrudeFinancialOrderIdentifierTypeRefCreate([Bind()] CrudeFinancialOrderIdentifierTypeRefModel financialOrderIdentifierTypeRef) {

            new CrudeFinancialOrderIdentifierTypeRefBusiness().Insert(financialOrderIdentifierTypeRef);

            return financialOrderIdentifierTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialOrderIdentifierTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderIdentifierTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderIdentifierTypeCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderIdentifierTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortSequenceNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StatusCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:49 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderIdentifierTypeRef/CrudeFinancialOrderIdentifierTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrderIdentifierTypeRef/CrudeFinancialOrderIdentifierTypeRefCreate/", content).Result;

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

        [HttpPut("crudefinancialorderidentifiertyperefupdate")]
        public CrudeFinancialOrderIdentifierTypeRefModel CrudeFinancialOrderIdentifierTypeRefUpdate([Bind()] CrudeFinancialOrderIdentifierTypeRefModel financialOrderIdentifierTypeRef) {

            new CrudeFinancialOrderIdentifierTypeRefBusiness().Update(financialOrderIdentifierTypeRef);

            return financialOrderIdentifierTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialOrderIdentifierTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderIdentifierTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderIdentifierTypeCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderIdentifierTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortSequenceNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StatusCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:49 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderIdentifierTypeRef/CrudeFinancialOrderIdentifierTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrderIdentifierTypeRef/CrudeFinancialOrderIdentifierTypeRefUpdate/", content).Result;

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

        [HttpDelete("financialorderidentifiertyperefdelete/{financialorderidentifiertypercd?}")]
        public void CrudeFinancialOrderIdentifierTypeRefDelete(System.String financialOrderIdentifierTypeRcd) {

            new CrudeFinancialOrderIdentifierTypeRefBusiness().Delete(financialOrderIdentifierTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialOrderIdentifierTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderIdentifierTypeRef/CrudeFinancialOrderIdentifierTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
