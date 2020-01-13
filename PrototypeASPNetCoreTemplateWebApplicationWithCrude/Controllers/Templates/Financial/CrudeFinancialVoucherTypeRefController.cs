/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:44:43 PM
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
    [Route("api/1/crudefinancialvouchertyperef")]
    public class CrudeFinancialVoucherTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialVoucherTypeRefHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialVoucherTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialVoucherTypeRefModel> CrudeFinancialVoucherTypeRefFetchAll() {

            List<CrudeFinancialVoucherTypeRefModel> financialVoucherTypeRefs = 
                new CrudeFinancialVoucherTypeRefBusiness().FetchAll();

            return financialVoucherTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialVoucherTypeRefFetchAllCount() {

            return new CrudeFinancialVoucherTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialVoucherTypeRefModel> CrudeFinancialVoucherTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialVoucherTypeRefModel> financialVoucherTypeRefs = 
                new CrudeFinancialVoucherTypeRefBusiness().FetchAllWithLimit(limit);

            return financialVoucherTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialVoucherTypeRefModel> CrudeFinancialVoucherTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialVoucherTypeRefModel> financialVoucherTypeRefs = 
                new CrudeFinancialVoucherTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialVoucherTypeRefs;
        }

        [HttpGet("fetchbyfinancialvouchertypercd/{financialvouchertypercd?}")]
        public CrudeFinancialVoucherTypeRefModel CrudeFinancialVoucherTypeRefFetchByFinancialVoucherTypeRcd(System.String financialvouchertypercd) {

            CrudeFinancialVoucherTypeRefModel financialVoucherTypeRef = 
                new CrudeFinancialVoucherTypeRefBusiness().FetchByFinancialVoucherTypeRcd(financialvouchertypercd);

            return financialVoucherTypeRef;
        }

        [HttpPost("crudefinancialvouchertyperefcreate")]
        public CrudeFinancialVoucherTypeRefModel CrudeFinancialVoucherTypeRefCreate([Bind()] CrudeFinancialVoucherTypeRefModel financialVoucherTypeRef) {

            new CrudeFinancialVoucherTypeRefBusiness().Insert(financialVoucherTypeRef);

            return financialVoucherTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialVoucherTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialVoucherTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialVoucherTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/13/2020 5:44:43 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialVoucherTypeRef/CrudeFinancialVoucherTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://localhost:5000/api/1/CrudeFinancialVoucherTypeRef/CrudeFinancialVoucherTypeRefCreate/", content).Result;

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

        [HttpPut("crudefinancialvouchertyperefupdate")]
        public CrudeFinancialVoucherTypeRefModel CrudeFinancialVoucherTypeRefUpdate([Bind()] CrudeFinancialVoucherTypeRefModel financialVoucherTypeRef) {

            new CrudeFinancialVoucherTypeRefBusiness().Update(financialVoucherTypeRef);

            return financialVoucherTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialVoucherTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialVoucherTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialVoucherTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/13/2020 5:44:43 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialVoucherTypeRef/CrudeFinancialVoucherTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://localhost:5000/api/1/CrudeFinancialVoucherTypeRef/CrudeFinancialVoucherTypeRefUpdate/", content).Result;

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

        [HttpDelete("financialvouchertyperefdelete/{financialvouchertypercd?}")]
        public void CrudeFinancialVoucherTypeRefDelete(System.String financialVoucherTypeRcd) {

            new CrudeFinancialVoucherTypeRefBusiness().Delete(financialVoucherTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialVoucherTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialVoucherTypeRef/CrudeFinancialVoucherTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
