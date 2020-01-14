/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:28 PM
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
    [Route("api/1/crudefinancialordertransactiontyperef")]
    public class CrudeFinancialOrderTransactionTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialOrderTransactionTypeRefHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialOrderTransactionTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialOrderTransactionTypeRefModel> CrudeFinancialOrderTransactionTypeRefFetchAll() {

            List<CrudeFinancialOrderTransactionTypeRefModel> financialOrderTransactionTypeRefs = 
                new CrudeFinancialOrderTransactionTypeRefBusiness().FetchAll();

            return financialOrderTransactionTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialOrderTransactionTypeRefFetchAllCount() {

            return new CrudeFinancialOrderTransactionTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialOrderTransactionTypeRefModel> CrudeFinancialOrderTransactionTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialOrderTransactionTypeRefModel> financialOrderTransactionTypeRefs = 
                new CrudeFinancialOrderTransactionTypeRefBusiness().FetchAllWithLimit(limit);

            return financialOrderTransactionTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialOrderTransactionTypeRefModel> CrudeFinancialOrderTransactionTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialOrderTransactionTypeRefModel> financialOrderTransactionTypeRefs = 
                new CrudeFinancialOrderTransactionTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialOrderTransactionTypeRefs;
        }

        [HttpGet("fetchbyfinancialordertransactiontypercd/{financialordertransactiontypercd?}")]
        public CrudeFinancialOrderTransactionTypeRefModel CrudeFinancialOrderTransactionTypeRefFetchByFinancialOrderTransactionTypeRcd(System.String financialordertransactiontypercd) {

            CrudeFinancialOrderTransactionTypeRefModel financialOrderTransactionTypeRef = 
                new CrudeFinancialOrderTransactionTypeRefBusiness().FetchByFinancialOrderTransactionTypeRcd(financialordertransactiontypercd);

            return financialOrderTransactionTypeRef;
        }

        [HttpPost("crudefinancialordertransactiontyperefcreate")]
        public CrudeFinancialOrderTransactionTypeRefModel CrudeFinancialOrderTransactionTypeRefCreate([Bind()] CrudeFinancialOrderTransactionTypeRefModel financialOrderTransactionTypeRef) {

            new CrudeFinancialOrderTransactionTypeRefBusiness().Insert(financialOrderTransactionTypeRef);

            return financialOrderTransactionTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialOrderTransactionTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderTransactionTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderTransactionTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:23:28 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderTransactionTypeRef/CrudeFinancialOrderTransactionTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrderTransactionTypeRef/CrudeFinancialOrderTransactionTypeRefCreate/", content).Result;

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

        [HttpPut("crudefinancialordertransactiontyperefupdate")]
        public CrudeFinancialOrderTransactionTypeRefModel CrudeFinancialOrderTransactionTypeRefUpdate([Bind()] CrudeFinancialOrderTransactionTypeRefModel financialOrderTransactionTypeRef) {

            new CrudeFinancialOrderTransactionTypeRefBusiness().Update(financialOrderTransactionTypeRef);

            return financialOrderTransactionTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialOrderTransactionTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderTransactionTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderTransactionTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:23:28 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderTransactionTypeRef/CrudeFinancialOrderTransactionTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrderTransactionTypeRef/CrudeFinancialOrderTransactionTypeRefUpdate/", content).Result;

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

        [HttpDelete("financialordertransactiontyperefdelete/{financialordertransactiontypercd?}")]
        public void CrudeFinancialOrderTransactionTypeRefDelete(System.String financialOrderTransactionTypeRcd) {

            new CrudeFinancialOrderTransactionTypeRefBusiness().Delete(financialOrderTransactionTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialOrderTransactionTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderTransactionTypeRef/CrudeFinancialOrderTransactionTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
