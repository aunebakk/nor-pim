/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:45:43 AM
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
    [Route("api/1/crudeproductidentifierref")]
    public class CrudeProductIdentifierRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductIdentifierRefHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductIdentifierRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductIdentifierRefModel> CrudeProductIdentifierRefFetchAll() {

            List<CrudeProductIdentifierRefModel> productIdentifierRefs = 
                new CrudeProductIdentifierRefBusiness().FetchAll();

            return productIdentifierRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductIdentifierRefFetchAllCount() {

            return new CrudeProductIdentifierRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductIdentifierRefModel> CrudeProductIdentifierRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductIdentifierRefModel> productIdentifierRefs = 
                new CrudeProductIdentifierRefBusiness().FetchAllWithLimit(limit);

            return productIdentifierRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductIdentifierRefModel> CrudeProductIdentifierRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductIdentifierRefModel> productIdentifierRefs = 
                new CrudeProductIdentifierRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productIdentifierRefs;
        }

        [HttpGet("fetchbyproductidentifierrcd/{productidentifierrcd?}")]
        public CrudeProductIdentifierRefModel CrudeProductIdentifierRefFetchByProductIdentifierRcd(System.String productidentifierrcd) {

            CrudeProductIdentifierRefModel productIdentifierRef = 
                new CrudeProductIdentifierRefBusiness().FetchByProductIdentifierRcd(productidentifierrcd);

            return productIdentifierRef;
        }

        [HttpPost("crudeproductidentifierrefcreate")]
        public CrudeProductIdentifierRefModel CrudeProductIdentifierRefCreate([Bind()] CrudeProductIdentifierRefModel productIdentifierRef) {

            new CrudeProductIdentifierRefBusiness().Insert(productIdentifierRef);

            return productIdentifierRef;
        }

        [HttpGet("createtest")]
        public string CrudeProductIdentifierRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductIdentifierRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductIdentifierName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 9:45:43 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductIdentifierRef/CrudeProductIdentifierRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductIdentifierRef/CrudeProductIdentifierRefCreate/", content).Result;

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

        [HttpPut("crudeproductidentifierrefupdate")]
        public CrudeProductIdentifierRefModel CrudeProductIdentifierRefUpdate([Bind()] CrudeProductIdentifierRefModel productIdentifierRef) {

            new CrudeProductIdentifierRefBusiness().Update(productIdentifierRef);

            return productIdentifierRef;
        }

        [HttpGet("updatetest")]
        public string CrudeProductIdentifierRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductIdentifierRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductIdentifierName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 9:45:43 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductIdentifierRef/CrudeProductIdentifierRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductIdentifierRef/CrudeProductIdentifierRefUpdate/", content).Result;

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

        [HttpDelete("productidentifierrefdelete/{productidentifierrcd?}")]
        public void CrudeProductIdentifierRefDelete(System.String productIdentifierRcd) {

            new CrudeProductIdentifierRefBusiness().Delete(productIdentifierRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeProductIdentifierRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductIdentifierRef/CrudeProductIdentifierRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
