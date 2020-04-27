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
    [Route("api/1/crudeproductgatherkey")]
    public class CrudeProductGatherKeyController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductGatherKeyHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductGatherKey.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductGatherKeyModel> CrudeProductGatherKeyFetchAll() {

            List<CrudeProductGatherKeyModel> productGatherKeys = 
                new CrudeProductGatherKeyBusiness().FetchAll();

            return productGatherKeys;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductGatherKeyFetchAllCount() {

            return new CrudeProductGatherKeyBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductGatherKeyModel> CrudeProductGatherKeyFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductGatherKeyModel> productGatherKeys = 
                new CrudeProductGatherKeyBusiness().FetchAllWithLimit(limit);

            return productGatherKeys;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductGatherKeyModel> CrudeProductGatherKeyFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductGatherKeyModel> productGatherKeys = 
                new CrudeProductGatherKeyBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productGatherKeys;
        }

        [HttpGet("fetchbyproductgatherkeyid/{productgatherkeyid?}")]
        public CrudeProductGatherKeyModel CrudeProductGatherKeyFetchByProductGatherKeyId(System.Guid productgatherkeyid) {

            CrudeProductGatherKeyModel productGatherKey = 
                new CrudeProductGatherKeyBusiness().FetchByProductGatherKeyId(productgatherkeyid);

            return productGatherKey;
        }

        [HttpGet("fetchbyproductgatherid/{productgatherid?}")]
        public IEnumerable<CrudeProductGatherKeyModel> CrudeProductGatherKeyFetchByProductGatherId(System.Guid productgatherid) {

            List<CrudeProductGatherKeyModel> productGatherKey = 
                new CrudeProductGatherKeyBusiness().FetchByProductGatherId(productgatherid);

            return productGatherKey;
        }

        [HttpPost("crudeproductgatherkeycreate")]
        public CrudeProductGatherKeyModel CrudeProductGatherKeyCreate([Bind()] CrudeProductGatherKeyModel productGatherKey) {

            new CrudeProductGatherKeyBusiness().Insert(productGatherKey);

            return productGatherKey;
        }

        [HttpGet("createtest")]
        public string CrudeProductGatherKeyCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherKeyValue" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/27/2020 3:45:11 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductGatherKey/CrudeProductGatherKeyCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductGatherKey/CrudeProductGatherKeyCreate/", content).Result;

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

        [HttpPut("crudeproductgatherkeyupdate")]
        public CrudeProductGatherKeyModel CrudeProductGatherKeyUpdate([Bind()] CrudeProductGatherKeyModel productGatherKey) {

            new CrudeProductGatherKeyBusiness().Update(productGatherKey);

            return productGatherKey;
        }

        [HttpGet("updatetest")]
        public string CrudeProductGatherKeyUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherKeyValue" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/27/2020 3:45:11 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductGatherKey/CrudeProductGatherKeyUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductGatherKey/CrudeProductGatherKeyUpdate/", content).Result;

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

        [HttpDelete("productgatherkeydelete/{productgatherkeyid?}")]
        public void CrudeProductGatherKeyDelete(System.Guid productGatherKeyId) {

            new CrudeProductGatherKeyBusiness().Delete(productGatherKeyId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductGatherKeyDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductGatherKey/CrudeProductGatherKeyDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
