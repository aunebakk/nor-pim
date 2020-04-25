/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:25:17 PM
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
    [Route("api/1/crudefinancialtaxtyperef")]
    public class CrudeFinancialTaxTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialTaxTypeRefHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialTaxTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialTaxTypeRefModel> CrudeFinancialTaxTypeRefFetchAll() {

            List<CrudeFinancialTaxTypeRefModel> financialTaxTypeRefs = 
                new CrudeFinancialTaxTypeRefBusiness().FetchAll();

            return financialTaxTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialTaxTypeRefFetchAllCount() {

            return new CrudeFinancialTaxTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialTaxTypeRefModel> CrudeFinancialTaxTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialTaxTypeRefModel> financialTaxTypeRefs = 
                new CrudeFinancialTaxTypeRefBusiness().FetchAllWithLimit(limit);

            return financialTaxTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialTaxTypeRefModel> CrudeFinancialTaxTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialTaxTypeRefModel> financialTaxTypeRefs = 
                new CrudeFinancialTaxTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialTaxTypeRefs;
        }

        [HttpGet("fetchbyfinancialtaxtypercd/{financialtaxtypercd?}")]
        public CrudeFinancialTaxTypeRefModel CrudeFinancialTaxTypeRefFetchByFinancialTaxTypeRcd(System.String financialtaxtypercd) {

            CrudeFinancialTaxTypeRefModel financialTaxTypeRef = 
                new CrudeFinancialTaxTypeRefBusiness().FetchByFinancialTaxTypeRcd(financialtaxtypercd);

            return financialTaxTypeRef;
        }

        [HttpPost("crudefinancialtaxtyperefcreate")]
        public CrudeFinancialTaxTypeRefModel CrudeFinancialTaxTypeRefCreate([Bind()] CrudeFinancialTaxTypeRefModel financialTaxTypeRef) {

            new CrudeFinancialTaxTypeRefBusiness().Insert(financialTaxTypeRef);

            return financialTaxTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialTaxTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialTaxTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialTaxTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 12:25:17 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialTaxTypeRef/CrudeFinancialTaxTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialTaxTypeRef/CrudeFinancialTaxTypeRefCreate/", content).Result;

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

        [HttpPut("crudefinancialtaxtyperefupdate")]
        public CrudeFinancialTaxTypeRefModel CrudeFinancialTaxTypeRefUpdate([Bind()] CrudeFinancialTaxTypeRefModel financialTaxTypeRef) {

            new CrudeFinancialTaxTypeRefBusiness().Update(financialTaxTypeRef);

            return financialTaxTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialTaxTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialTaxTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialTaxTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 12:25:17 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialTaxTypeRef/CrudeFinancialTaxTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialTaxTypeRef/CrudeFinancialTaxTypeRefUpdate/", content).Result;

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

        [HttpDelete("financialtaxtyperefdelete/{financialtaxtypercd?}")]
        public void CrudeFinancialTaxTypeRefDelete(System.String financialTaxTypeRcd) {

            new CrudeFinancialTaxTypeRefBusiness().Delete(financialTaxTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialTaxTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialTaxTypeRef/CrudeFinancialTaxTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
