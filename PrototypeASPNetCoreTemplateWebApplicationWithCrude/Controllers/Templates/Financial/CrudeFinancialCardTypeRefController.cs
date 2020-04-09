/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:38:53 PM
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
    [Route("api/1/crudefinancialcardtyperef")]
    public class CrudeFinancialCardTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialCardTypeRefHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialCardTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialCardTypeRefModel> CrudeFinancialCardTypeRefFetchAll() {

            List<CrudeFinancialCardTypeRefModel> financialCardTypeRefs = 
                new CrudeFinancialCardTypeRefBusiness().FetchAll();

            return financialCardTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialCardTypeRefFetchAllCount() {

            return new CrudeFinancialCardTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialCardTypeRefModel> CrudeFinancialCardTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialCardTypeRefModel> financialCardTypeRefs = 
                new CrudeFinancialCardTypeRefBusiness().FetchAllWithLimit(limit);

            return financialCardTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialCardTypeRefModel> CrudeFinancialCardTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialCardTypeRefModel> financialCardTypeRefs = 
                new CrudeFinancialCardTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialCardTypeRefs;
        }

        [HttpGet("fetchbyfinancialcardtypercd/{financialcardtypercd?}")]
        public CrudeFinancialCardTypeRefModel CrudeFinancialCardTypeRefFetchByFinancialCardTypeRcd(System.String financialcardtypercd) {

            CrudeFinancialCardTypeRefModel financialCardTypeRef = 
                new CrudeFinancialCardTypeRefBusiness().FetchByFinancialCardTypeRcd(financialcardtypercd);

            return financialCardTypeRef;
        }

        [HttpPost("crudefinancialcardtyperefcreate")]
        public CrudeFinancialCardTypeRefModel CrudeFinancialCardTypeRefCreate([Bind()] CrudeFinancialCardTypeRefModel financialCardTypeRef) {

            new CrudeFinancialCardTypeRefBusiness().Insert(financialCardTypeRef);

            return financialCardTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialCardTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCardTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCardTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/9/2020 5:38:53 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialCardTypeRef/CrudeFinancialCardTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialCardTypeRef/CrudeFinancialCardTypeRefCreate/", content).Result;

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

        [HttpPut("crudefinancialcardtyperefupdate")]
        public CrudeFinancialCardTypeRefModel CrudeFinancialCardTypeRefUpdate([Bind()] CrudeFinancialCardTypeRefModel financialCardTypeRef) {

            new CrudeFinancialCardTypeRefBusiness().Update(financialCardTypeRef);

            return financialCardTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialCardTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCardTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCardTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/9/2020 5:38:53 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialCardTypeRef/CrudeFinancialCardTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialCardTypeRef/CrudeFinancialCardTypeRefUpdate/", content).Result;

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

        [HttpDelete("financialcardtyperefdelete/{financialcardtypercd?}")]
        public void CrudeFinancialCardTypeRefDelete(System.String financialCardTypeRcd) {

            new CrudeFinancialCardTypeRefBusiness().Delete(financialCardTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialCardTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialCardTypeRef/CrudeFinancialCardTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
