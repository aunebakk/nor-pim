/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:47:51 AM
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
    [Route("api/1/crudefinancialcurrencytyperef")]
    public class CrudeFinancialCurrencyTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialCurrencyTypeRefHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialCurrencyTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialCurrencyTypeRefModel> CrudeFinancialCurrencyTypeRefFetchAll() {

            List<CrudeFinancialCurrencyTypeRefModel> financialCurrencyTypeRefs = 
                new CrudeFinancialCurrencyTypeRefBusiness().FetchAll();

            return financialCurrencyTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialCurrencyTypeRefFetchAllCount() {

            return new CrudeFinancialCurrencyTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialCurrencyTypeRefModel> CrudeFinancialCurrencyTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialCurrencyTypeRefModel> financialCurrencyTypeRefs = 
                new CrudeFinancialCurrencyTypeRefBusiness().FetchAllWithLimit(limit);

            return financialCurrencyTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialCurrencyTypeRefModel> CrudeFinancialCurrencyTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialCurrencyTypeRefModel> financialCurrencyTypeRefs = 
                new CrudeFinancialCurrencyTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialCurrencyTypeRefs;
        }

        [HttpGet("fetchbyfinancialcurrencytypercd/{financialcurrencytypercd?}")]
        public CrudeFinancialCurrencyTypeRefModel CrudeFinancialCurrencyTypeRefFetchByFinancialCurrencyTypeRcd(System.String financialcurrencytypercd) {

            CrudeFinancialCurrencyTypeRefModel financialCurrencyTypeRef = 
                new CrudeFinancialCurrencyTypeRefBusiness().FetchByFinancialCurrencyTypeRcd(financialcurrencytypercd);

            return financialCurrencyTypeRef;
        }

        [HttpPost("crudefinancialcurrencytyperefcreate")]
        public CrudeFinancialCurrencyTypeRefModel CrudeFinancialCurrencyTypeRefCreate([Bind()] CrudeFinancialCurrencyTypeRefModel financialCurrencyTypeRef) {

            new CrudeFinancialCurrencyTypeRefBusiness().Insert(financialCurrencyTypeRef);

            return financialCurrencyTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialCurrencyTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCurrencyTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCurrencyTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 10:47:51 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DecimalCount" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCurrencyTypeCode" , "create" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialCurrencyTypeRef/CrudeFinancialCurrencyTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialCurrencyTypeRef/CrudeFinancialCurrencyTypeRefCreate/", content).Result;

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

        [HttpPut("crudefinancialcurrencytyperefupdate")]
        public CrudeFinancialCurrencyTypeRefModel CrudeFinancialCurrencyTypeRefUpdate([Bind()] CrudeFinancialCurrencyTypeRefModel financialCurrencyTypeRef) {

            new CrudeFinancialCurrencyTypeRefBusiness().Update(financialCurrencyTypeRef);

            return financialCurrencyTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialCurrencyTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCurrencyTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCurrencyTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 10:47:51 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DecimalCount" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCurrencyTypeCode" , "update" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialCurrencyTypeRef/CrudeFinancialCurrencyTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialCurrencyTypeRef/CrudeFinancialCurrencyTypeRefUpdate/", content).Result;

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

        [HttpDelete("financialcurrencytyperefdelete/{financialcurrencytypercd?}")]
        public void CrudeFinancialCurrencyTypeRefDelete(System.String financialCurrencyTypeRcd) {

            new CrudeFinancialCurrencyTypeRefBusiness().Delete(financialCurrencyTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialCurrencyTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialCurrencyTypeRef/CrudeFinancialCurrencyTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
