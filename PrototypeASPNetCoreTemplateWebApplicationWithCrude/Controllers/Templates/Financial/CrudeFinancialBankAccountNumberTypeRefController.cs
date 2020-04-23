/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:50:18 AM
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
    [Route("api/1/crudefinancialbankaccountnumbertyperef")]
    public class CrudeFinancialBankAccountNumberTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialBankAccountNumberTypeRefHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialBankAccountNumberTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialBankAccountNumberTypeRefModel> CrudeFinancialBankAccountNumberTypeRefFetchAll() {

            List<CrudeFinancialBankAccountNumberTypeRefModel> financialBankAccountNumberTypeRefs = 
                new CrudeFinancialBankAccountNumberTypeRefBusiness().FetchAll();

            return financialBankAccountNumberTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialBankAccountNumberTypeRefFetchAllCount() {

            return new CrudeFinancialBankAccountNumberTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialBankAccountNumberTypeRefModel> CrudeFinancialBankAccountNumberTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialBankAccountNumberTypeRefModel> financialBankAccountNumberTypeRefs = 
                new CrudeFinancialBankAccountNumberTypeRefBusiness().FetchAllWithLimit(limit);

            return financialBankAccountNumberTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialBankAccountNumberTypeRefModel> CrudeFinancialBankAccountNumberTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialBankAccountNumberTypeRefModel> financialBankAccountNumberTypeRefs = 
                new CrudeFinancialBankAccountNumberTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialBankAccountNumberTypeRefs;
        }

        [HttpGet("fetchbyfinancialbankaccountnumbertypercd/{financialbankaccountnumbertypercd?}")]
        public CrudeFinancialBankAccountNumberTypeRefModel CrudeFinancialBankAccountNumberTypeRefFetchByFinancialBankAccountNumberTypeRcd(System.String financialbankaccountnumbertypercd) {

            CrudeFinancialBankAccountNumberTypeRefModel financialBankAccountNumberTypeRef = 
                new CrudeFinancialBankAccountNumberTypeRefBusiness().FetchByFinancialBankAccountNumberTypeRcd(financialbankaccountnumbertypercd);

            return financialBankAccountNumberTypeRef;
        }

        [HttpPost("crudefinancialbankaccountnumbertyperefcreate")]
        public CrudeFinancialBankAccountNumberTypeRefModel CrudeFinancialBankAccountNumberTypeRefCreate([Bind()] CrudeFinancialBankAccountNumberTypeRefModel financialBankAccountNumberTypeRef) {

            new CrudeFinancialBankAccountNumberTypeRefBusiness().Insert(financialBankAccountNumberTypeRef);

            return financialBankAccountNumberTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialBankAccountNumberTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialBankAccountNumberTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialBankAccountNumberTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/23/2020 11:50:18 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialBankAccountNumberTypeRef/CrudeFinancialBankAccountNumberTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialBankAccountNumberTypeRef/CrudeFinancialBankAccountNumberTypeRefCreate/", content).Result;

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

        [HttpPut("crudefinancialbankaccountnumbertyperefupdate")]
        public CrudeFinancialBankAccountNumberTypeRefModel CrudeFinancialBankAccountNumberTypeRefUpdate([Bind()] CrudeFinancialBankAccountNumberTypeRefModel financialBankAccountNumberTypeRef) {

            new CrudeFinancialBankAccountNumberTypeRefBusiness().Update(financialBankAccountNumberTypeRef);

            return financialBankAccountNumberTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialBankAccountNumberTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialBankAccountNumberTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialBankAccountNumberTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/23/2020 11:50:18 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialBankAccountNumberTypeRef/CrudeFinancialBankAccountNumberTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialBankAccountNumberTypeRef/CrudeFinancialBankAccountNumberTypeRefUpdate/", content).Result;

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

        [HttpDelete("financialbankaccountnumbertyperefdelete/{financialbankaccountnumbertypercd?}")]
        public void CrudeFinancialBankAccountNumberTypeRefDelete(System.String financialBankAccountNumberTypeRcd) {

            new CrudeFinancialBankAccountNumberTypeRefBusiness().Delete(financialBankAccountNumberTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialBankAccountNumberTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialBankAccountNumberTypeRef/CrudeFinancialBankAccountNumberTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
