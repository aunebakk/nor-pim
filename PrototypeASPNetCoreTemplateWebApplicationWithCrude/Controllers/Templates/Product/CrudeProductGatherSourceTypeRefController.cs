/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:31 PM
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
    [Route("api/1/crudeproductgathersourcetyperef")]
    public class CrudeProductGatherSourceTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductGatherSourceTypeRefHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductGatherSourceTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductGatherSourceTypeRefModel> CrudeProductGatherSourceTypeRefFetchAll() {

            List<CrudeProductGatherSourceTypeRefModel> productGatherSourceTypeRefs = 
                new CrudeProductGatherSourceTypeRefBusiness().FetchAll();

            return productGatherSourceTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductGatherSourceTypeRefFetchAllCount() {

            return new CrudeProductGatherSourceTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductGatherSourceTypeRefModel> CrudeProductGatherSourceTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductGatherSourceTypeRefModel> productGatherSourceTypeRefs = 
                new CrudeProductGatherSourceTypeRefBusiness().FetchAllWithLimit(limit);

            return productGatherSourceTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductGatherSourceTypeRefModel> CrudeProductGatherSourceTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductGatherSourceTypeRefModel> productGatherSourceTypeRefs = 
                new CrudeProductGatherSourceTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productGatherSourceTypeRefs;
        }

        [HttpGet("fetchbyproductgathersourcetypercd/{productgathersourcetypercd?}")]
        public CrudeProductGatherSourceTypeRefModel CrudeProductGatherSourceTypeRefFetchByProductGatherSourceTypeRcd(System.String productgathersourcetypercd) {

            CrudeProductGatherSourceTypeRefModel productGatherSourceTypeRef = 
                new CrudeProductGatherSourceTypeRefBusiness().FetchByProductGatherSourceTypeRcd(productgathersourcetypercd);

            return productGatherSourceTypeRef;
        }

        [HttpPost("crudeproductgathersourcetyperefcreate")]
        public CrudeProductGatherSourceTypeRefModel CrudeProductGatherSourceTypeRefCreate([Bind()] CrudeProductGatherSourceTypeRefModel productGatherSourceTypeRef) {

            new CrudeProductGatherSourceTypeRefBusiness().Insert(productGatherSourceTypeRef);

            return productGatherSourceTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeProductGatherSourceTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherSourceTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherSourceTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:23:31 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefCreate/", content).Result;

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

        [HttpPut("crudeproductgathersourcetyperefupdate")]
        public CrudeProductGatherSourceTypeRefModel CrudeProductGatherSourceTypeRefUpdate([Bind()] CrudeProductGatherSourceTypeRefModel productGatherSourceTypeRef) {

            new CrudeProductGatherSourceTypeRefBusiness().Update(productGatherSourceTypeRef);

            return productGatherSourceTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeProductGatherSourceTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherSourceTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherSourceTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:23:31 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefUpdate/", content).Result;

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

        [HttpDelete("productgathersourcetyperefdelete/{productgathersourcetypercd?}")]
        public void CrudeProductGatherSourceTypeRefDelete(System.String productGatherSourceTypeRcd) {

            new CrudeProductGatherSourceTypeRefBusiness().Delete(productGatherSourceTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeProductGatherSourceTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductGatherSourceTypeRef/CrudeProductGatherSourceTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
