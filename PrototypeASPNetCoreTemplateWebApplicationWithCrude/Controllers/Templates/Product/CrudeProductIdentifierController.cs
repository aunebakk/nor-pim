/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:29 PM
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
    [Route("api/1/crudeproductidentifier")]
    public class CrudeProductIdentifierController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductIdentifierHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductIdentifier.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductIdentifierModel> CrudeProductIdentifierFetchAll() {

            List<CrudeProductIdentifierModel> productIdentifiers = 
                new CrudeProductIdentifierBusiness().FetchAll();

            return productIdentifiers;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductIdentifierFetchAllCount() {

            return new CrudeProductIdentifierBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductIdentifierModel> CrudeProductIdentifierFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductIdentifierModel> productIdentifiers = 
                new CrudeProductIdentifierBusiness().FetchAllWithLimit(limit);

            return productIdentifiers;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductIdentifierModel> CrudeProductIdentifierFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductIdentifierModel> productIdentifiers = 
                new CrudeProductIdentifierBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productIdentifiers;
        }

        [HttpGet("fetchbyproductidentifierid/{productidentifierid?}")]
        public CrudeProductIdentifierModel CrudeProductIdentifierFetchByProductIdentifierId(System.Guid productidentifierid) {

            CrudeProductIdentifierModel productIdentifier = 
                new CrudeProductIdentifierBusiness().FetchByProductIdentifierId(productidentifierid);

            return productIdentifier;
        }

        [HttpGet("fetchbyproductid/{productid?}")]
        public IEnumerable<CrudeProductIdentifierModel> CrudeProductIdentifierFetchByProductId(System.Guid productid) {

            List<CrudeProductIdentifierModel> productIdentifier = 
                new CrudeProductIdentifierBusiness().FetchByProductId(productid);

            return productIdentifier;
        }

        [HttpGet("fetchbyproductidentifierrcd/{productidentifierrcd?}")]
        public IEnumerable<CrudeProductIdentifierModel> CrudeProductIdentifierFetchByProductIdentifierRcd(System.String productidentifierrcd) {

            List<CrudeProductIdentifierModel> productIdentifier = 
                new CrudeProductIdentifierBusiness().FetchByProductIdentifierRcd(productidentifierrcd);

            return productIdentifier;
        }

        [HttpPost("crudeproductidentifiercreate")]
        public CrudeProductIdentifierModel CrudeProductIdentifierCreate([Bind()] CrudeProductIdentifierModel productIdentifier) {

            new CrudeProductIdentifierBusiness().Insert(productIdentifier);

            return productIdentifier;
        }

        [HttpGet("createtest")]
        public string CrudeProductIdentifierCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductIdentifierRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Identifier" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 3:02:29 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductIdentifier/CrudeProductIdentifierCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductIdentifier/CrudeProductIdentifierCreate/", content).Result;

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

        [HttpPut("crudeproductidentifierupdate")]
        public CrudeProductIdentifierModel CrudeProductIdentifierUpdate([Bind()] CrudeProductIdentifierModel productIdentifier) {

            new CrudeProductIdentifierBusiness().Update(productIdentifier);

            return productIdentifier;
        }

        [HttpGet("updatetest")]
        public string CrudeProductIdentifierUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductIdentifierRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Identifier" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 3:02:29 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductIdentifier/CrudeProductIdentifierUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductIdentifier/CrudeProductIdentifierUpdate/", content).Result;

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

        [HttpDelete("productidentifierdelete/{productidentifierid?}")]
        public void CrudeProductIdentifierDelete(System.Guid productIdentifierId) {

            new CrudeProductIdentifierBusiness().Delete(productIdentifierId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductIdentifierDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductIdentifier/CrudeProductIdentifierDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
