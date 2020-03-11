/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:38:10 PM
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
    [Route("api/1/crudefinancialpaymenttyperef")]
    public class CrudeFinancialPaymentTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialPaymentTypeRefHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialPaymentTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialPaymentTypeRefModel> CrudeFinancialPaymentTypeRefFetchAll() {

            List<CrudeFinancialPaymentTypeRefModel> financialPaymentTypeRefs = 
                new CrudeFinancialPaymentTypeRefBusiness().FetchAll();

            return financialPaymentTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialPaymentTypeRefFetchAllCount() {

            return new CrudeFinancialPaymentTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialPaymentTypeRefModel> CrudeFinancialPaymentTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialPaymentTypeRefModel> financialPaymentTypeRefs = 
                new CrudeFinancialPaymentTypeRefBusiness().FetchAllWithLimit(limit);

            return financialPaymentTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialPaymentTypeRefModel> CrudeFinancialPaymentTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialPaymentTypeRefModel> financialPaymentTypeRefs = 
                new CrudeFinancialPaymentTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialPaymentTypeRefs;
        }

        [HttpGet("fetchbyfinancialpaymenttypercd/{financialpaymenttypercd?}")]
        public CrudeFinancialPaymentTypeRefModel CrudeFinancialPaymentTypeRefFetchByFinancialPaymentTypeRcd(System.String financialpaymenttypercd) {

            CrudeFinancialPaymentTypeRefModel financialPaymentTypeRef = 
                new CrudeFinancialPaymentTypeRefBusiness().FetchByFinancialPaymentTypeRcd(financialpaymenttypercd);

            return financialPaymentTypeRef;
        }

        [HttpPost("crudefinancialpaymenttyperefcreate")]
        public CrudeFinancialPaymentTypeRefModel CrudeFinancialPaymentTypeRefCreate([Bind()] CrudeFinancialPaymentTypeRefModel financialPaymentTypeRef) {

            new CrudeFinancialPaymentTypeRefBusiness().Insert(financialPaymentTypeRef);

            return financialPaymentTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialPaymentTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialPaymentTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialPaymentTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:38:10 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefCreate/", content).Result;

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

        [HttpPut("crudefinancialpaymenttyperefupdate")]
        public CrudeFinancialPaymentTypeRefModel CrudeFinancialPaymentTypeRefUpdate([Bind()] CrudeFinancialPaymentTypeRefModel financialPaymentTypeRef) {

            new CrudeFinancialPaymentTypeRefBusiness().Update(financialPaymentTypeRef);

            return financialPaymentTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialPaymentTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialPaymentTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialPaymentTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:38:10 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefUpdate/", content).Result;

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

        [HttpDelete("financialpaymenttyperefdelete/{financialpaymenttypercd?}")]
        public void CrudeFinancialPaymentTypeRefDelete(System.String financialPaymentTypeRcd) {

            new CrudeFinancialPaymentTypeRefBusiness().Delete(financialPaymentTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialPaymentTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentTypeRef/CrudeFinancialPaymentTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
