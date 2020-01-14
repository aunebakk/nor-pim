/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:46:27 AM
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
    [Route("api/1/crudefinancialcoupontyperef")]
    public class CrudeFinancialCouponTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialCouponTypeRefHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialCouponTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialCouponTypeRefModel> CrudeFinancialCouponTypeRefFetchAll() {

            List<CrudeFinancialCouponTypeRefModel> financialCouponTypeRefs = 
                new CrudeFinancialCouponTypeRefBusiness().FetchAll();

            return financialCouponTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialCouponTypeRefFetchAllCount() {

            return new CrudeFinancialCouponTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialCouponTypeRefModel> CrudeFinancialCouponTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialCouponTypeRefModel> financialCouponTypeRefs = 
                new CrudeFinancialCouponTypeRefBusiness().FetchAllWithLimit(limit);

            return financialCouponTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialCouponTypeRefModel> CrudeFinancialCouponTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialCouponTypeRefModel> financialCouponTypeRefs = 
                new CrudeFinancialCouponTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialCouponTypeRefs;
        }

        [HttpGet("fetchbyfinancialcoupontypercd/{financialcoupontypercd?}")]
        public CrudeFinancialCouponTypeRefModel CrudeFinancialCouponTypeRefFetchByFinancialCouponTypeRcd(System.String financialcoupontypercd) {

            CrudeFinancialCouponTypeRefModel financialCouponTypeRef = 
                new CrudeFinancialCouponTypeRefBusiness().FetchByFinancialCouponTypeRcd(financialcoupontypercd);

            return financialCouponTypeRef;
        }

        [HttpPost("crudefinancialcoupontyperefcreate")]
        public CrudeFinancialCouponTypeRefModel CrudeFinancialCouponTypeRefCreate([Bind()] CrudeFinancialCouponTypeRefModel financialCouponTypeRef) {

            new CrudeFinancialCouponTypeRefBusiness().Insert(financialCouponTypeRef);

            return financialCouponTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialCouponTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCouponTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCouponTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 9:46:27 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialCouponTypeRef/CrudeFinancialCouponTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialCouponTypeRef/CrudeFinancialCouponTypeRefCreate/", content).Result;

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

        [HttpPut("crudefinancialcoupontyperefupdate")]
        public CrudeFinancialCouponTypeRefModel CrudeFinancialCouponTypeRefUpdate([Bind()] CrudeFinancialCouponTypeRefModel financialCouponTypeRef) {

            new CrudeFinancialCouponTypeRefBusiness().Update(financialCouponTypeRef);

            return financialCouponTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialCouponTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCouponTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCouponTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 9:46:27 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialCouponTypeRef/CrudeFinancialCouponTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialCouponTypeRef/CrudeFinancialCouponTypeRefUpdate/", content).Result;

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

        [HttpDelete("financialcoupontyperefdelete/{financialcoupontypercd?}")]
        public void CrudeFinancialCouponTypeRefDelete(System.String financialCouponTypeRcd) {

            new CrudeFinancialCouponTypeRefBusiness().Delete(financialCouponTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialCouponTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialCouponTypeRef/CrudeFinancialCouponTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
