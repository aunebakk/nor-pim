/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:45:11 PM
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
    [Route("api/1/crudefinancialfeetyperef")]
    public class CrudeFinancialFeeTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialFeeTypeRefHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialFeeTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialFeeTypeRefModel> CrudeFinancialFeeTypeRefFetchAll() {

            List<CrudeFinancialFeeTypeRefModel> financialFeeTypeRefs = 
                new CrudeFinancialFeeTypeRefBusiness().FetchAll();

            return financialFeeTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialFeeTypeRefFetchAllCount() {

            return new CrudeFinancialFeeTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialFeeTypeRefModel> CrudeFinancialFeeTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialFeeTypeRefModel> financialFeeTypeRefs = 
                new CrudeFinancialFeeTypeRefBusiness().FetchAllWithLimit(limit);

            return financialFeeTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialFeeTypeRefModel> CrudeFinancialFeeTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialFeeTypeRefModel> financialFeeTypeRefs = 
                new CrudeFinancialFeeTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialFeeTypeRefs;
        }

        [HttpGet("fetchbyfinancialfeetypercd/{financialfeetypercd?}")]
        public CrudeFinancialFeeTypeRefModel CrudeFinancialFeeTypeRefFetchByFinancialFeeTypeRcd(System.String financialfeetypercd) {

            CrudeFinancialFeeTypeRefModel financialFeeTypeRef = 
                new CrudeFinancialFeeTypeRefBusiness().FetchByFinancialFeeTypeRcd(financialfeetypercd);

            return financialFeeTypeRef;
        }

        [HttpPost("crudefinancialfeetyperefcreate")]
        public CrudeFinancialFeeTypeRefModel CrudeFinancialFeeTypeRefCreate([Bind()] CrudeFinancialFeeTypeRefModel financialFeeTypeRef) {

            new CrudeFinancialFeeTypeRefBusiness().Insert(financialFeeTypeRef);

            return financialFeeTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialFeeTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialFeeTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialFeeTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/27/2020 3:45:11 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialFeeTypeRef/CrudeFinancialFeeTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialFeeTypeRef/CrudeFinancialFeeTypeRefCreate/", content).Result;

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

        [HttpPut("crudefinancialfeetyperefupdate")]
        public CrudeFinancialFeeTypeRefModel CrudeFinancialFeeTypeRefUpdate([Bind()] CrudeFinancialFeeTypeRefModel financialFeeTypeRef) {

            new CrudeFinancialFeeTypeRefBusiness().Update(financialFeeTypeRef);

            return financialFeeTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialFeeTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialFeeTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialFeeTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/27/2020 3:45:11 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialFeeTypeRef/CrudeFinancialFeeTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialFeeTypeRef/CrudeFinancialFeeTypeRefUpdate/", content).Result;

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

        [HttpDelete("financialfeetyperefdelete/{financialfeetypercd?}")]
        public void CrudeFinancialFeeTypeRefDelete(System.String financialFeeTypeRcd) {

            new CrudeFinancialFeeTypeRefBusiness().Delete(financialFeeTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialFeeTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialFeeTypeRef/CrudeFinancialFeeTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
