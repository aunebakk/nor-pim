/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:22:56 PM
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
    [Route("api/1/crudefinancialadjustmenttyperef")]
    public class CrudeFinancialAdjustmentTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialAdjustmentTypeRefHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialAdjustmentTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialAdjustmentTypeRefModel> CrudeFinancialAdjustmentTypeRefFetchAll() {

            List<CrudeFinancialAdjustmentTypeRefModel> financialAdjustmentTypeRefs = 
                new CrudeFinancialAdjustmentTypeRefBusiness().FetchAll();

            return financialAdjustmentTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialAdjustmentTypeRefFetchAllCount() {

            return new CrudeFinancialAdjustmentTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialAdjustmentTypeRefModel> CrudeFinancialAdjustmentTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialAdjustmentTypeRefModel> financialAdjustmentTypeRefs = 
                new CrudeFinancialAdjustmentTypeRefBusiness().FetchAllWithLimit(limit);

            return financialAdjustmentTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialAdjustmentTypeRefModel> CrudeFinancialAdjustmentTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialAdjustmentTypeRefModel> financialAdjustmentTypeRefs = 
                new CrudeFinancialAdjustmentTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialAdjustmentTypeRefs;
        }

        [HttpGet("fetchbyfinancialadjustmenttypercd/{financialadjustmenttypercd?}")]
        public CrudeFinancialAdjustmentTypeRefModel CrudeFinancialAdjustmentTypeRefFetchByFinancialAdjustmentTypeRcd(System.String financialadjustmenttypercd) {

            CrudeFinancialAdjustmentTypeRefModel financialAdjustmentTypeRef = 
                new CrudeFinancialAdjustmentTypeRefBusiness().FetchByFinancialAdjustmentTypeRcd(financialadjustmenttypercd);

            return financialAdjustmentTypeRef;
        }

        [HttpPost("crudefinancialadjustmenttyperefcreate")]
        public CrudeFinancialAdjustmentTypeRefModel CrudeFinancialAdjustmentTypeRefCreate([Bind()] CrudeFinancialAdjustmentTypeRefModel financialAdjustmentTypeRef) {

            new CrudeFinancialAdjustmentTypeRefBusiness().Insert(financialAdjustmentTypeRef);

            return financialAdjustmentTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialAdjustmentTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialAdjustmentTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialAdjustmentTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 8:22:56 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialAdjustmentTypeRef/CrudeFinancialAdjustmentTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialAdjustmentTypeRef/CrudeFinancialAdjustmentTypeRefCreate/", content).Result;

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

        [HttpPut("crudefinancialadjustmenttyperefupdate")]
        public CrudeFinancialAdjustmentTypeRefModel CrudeFinancialAdjustmentTypeRefUpdate([Bind()] CrudeFinancialAdjustmentTypeRefModel financialAdjustmentTypeRef) {

            new CrudeFinancialAdjustmentTypeRefBusiness().Update(financialAdjustmentTypeRef);

            return financialAdjustmentTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialAdjustmentTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialAdjustmentTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialAdjustmentTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 8:22:56 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialAdjustmentTypeRef/CrudeFinancialAdjustmentTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialAdjustmentTypeRef/CrudeFinancialAdjustmentTypeRefUpdate/", content).Result;

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

        [HttpDelete("financialadjustmenttyperefdelete/{financialadjustmenttypercd?}")]
        public void CrudeFinancialAdjustmentTypeRefDelete(System.String financialAdjustmentTypeRcd) {

            new CrudeFinancialAdjustmentTypeRefBusiness().Delete(financialAdjustmentTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialAdjustmentTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialAdjustmentTypeRef/CrudeFinancialAdjustmentTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
