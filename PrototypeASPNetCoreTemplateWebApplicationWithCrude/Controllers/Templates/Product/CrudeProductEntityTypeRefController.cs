/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:41:24 PM
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
    [Route("api/1/crudeproductentitytyperef")]
    public class CrudeProductEntityTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductEntityTypeRefHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductEntityTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductEntityTypeRefModel> CrudeProductEntityTypeRefFetchAll() {

            List<CrudeProductEntityTypeRefModel> productEntityTypeRefs = 
                new CrudeProductEntityTypeRefBusiness().FetchAll();

            return productEntityTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductEntityTypeRefFetchAllCount() {

            return new CrudeProductEntityTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductEntityTypeRefModel> CrudeProductEntityTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductEntityTypeRefModel> productEntityTypeRefs = 
                new CrudeProductEntityTypeRefBusiness().FetchAllWithLimit(limit);

            return productEntityTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductEntityTypeRefModel> CrudeProductEntityTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductEntityTypeRefModel> productEntityTypeRefs = 
                new CrudeProductEntityTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productEntityTypeRefs;
        }

        [HttpGet("fetchbyproductentitytypercd/{productentitytypercd?}")]
        public CrudeProductEntityTypeRefModel CrudeProductEntityTypeRefFetchByProductEntityTypeRcd(System.String productentitytypercd) {

            CrudeProductEntityTypeRefModel productEntityTypeRef = 
                new CrudeProductEntityTypeRefBusiness().FetchByProductEntityTypeRcd(productentitytypercd);

            return productEntityTypeRef;
        }

        [HttpPost("crudeproductentitytyperefcreate")]
        public CrudeProductEntityTypeRefModel CrudeProductEntityTypeRefCreate([Bind()] CrudeProductEntityTypeRefModel productEntityTypeRef) {

            new CrudeProductEntityTypeRefBusiness().Insert(productEntityTypeRef);

            return productEntityTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeProductEntityTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductEntityTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductEntityTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/6/2020 4:41:24 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefCreate/", content).Result;

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

        [HttpPut("crudeproductentitytyperefupdate")]
        public CrudeProductEntityTypeRefModel CrudeProductEntityTypeRefUpdate([Bind()] CrudeProductEntityTypeRefModel productEntityTypeRef) {

            new CrudeProductEntityTypeRefBusiness().Update(productEntityTypeRef);

            return productEntityTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeProductEntityTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductEntityTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductEntityTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/6/2020 4:41:24 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefUpdate/", content).Result;

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

        [HttpDelete("productentitytyperefdelete/{productentitytypercd?}")]
        public void CrudeProductEntityTypeRefDelete(System.String productEntityTypeRcd) {

            new CrudeProductEntityTypeRefBusiness().Delete(productEntityTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeProductEntityTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductEntityTypeRef/CrudeProductEntityTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
