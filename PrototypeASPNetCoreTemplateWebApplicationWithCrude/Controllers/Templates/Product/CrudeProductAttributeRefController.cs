/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 7:01:24 AM
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
    [Route("api/1/crudeproductattributeref")]
    public class CrudeProductAttributeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductAttributeRefHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductAttributeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductAttributeRefModel> CrudeProductAttributeRefFetchAll() {

            List<CrudeProductAttributeRefModel> productAttributeRefs = 
                new CrudeProductAttributeRefBusiness().FetchAll();

            return productAttributeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductAttributeRefFetchAllCount() {

            return new CrudeProductAttributeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductAttributeRefModel> CrudeProductAttributeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductAttributeRefModel> productAttributeRefs = 
                new CrudeProductAttributeRefBusiness().FetchAllWithLimit(limit);

            return productAttributeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductAttributeRefModel> CrudeProductAttributeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductAttributeRefModel> productAttributeRefs = 
                new CrudeProductAttributeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productAttributeRefs;
        }

        [HttpGet("fetchbyproductattributercd/{productattributercd?}")]
        public CrudeProductAttributeRefModel CrudeProductAttributeRefFetchByProductAttributeRcd(System.String productattributercd) {

            CrudeProductAttributeRefModel productAttributeRef = 
                new CrudeProductAttributeRefBusiness().FetchByProductAttributeRcd(productattributercd);

            return productAttributeRef;
        }

        [HttpPost("crudeproductattributerefcreate")]
        public CrudeProductAttributeRefModel CrudeProductAttributeRefCreate([Bind()] CrudeProductAttributeRefModel productAttributeRef) {

            new CrudeProductAttributeRefBusiness().Insert(productAttributeRef);

            return productAttributeRef;
        }

        [HttpGet("createtest")]
        public string CrudeProductAttributeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductAttributeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductAttributeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 7:01:24 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductAttributeRef/CrudeProductAttributeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductAttributeRef/CrudeProductAttributeRefCreate/", content).Result;

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

        [HttpPut("crudeproductattributerefupdate")]
        public CrudeProductAttributeRefModel CrudeProductAttributeRefUpdate([Bind()] CrudeProductAttributeRefModel productAttributeRef) {

            new CrudeProductAttributeRefBusiness().Update(productAttributeRef);

            return productAttributeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeProductAttributeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductAttributeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductAttributeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 7:01:24 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductAttributeRef/CrudeProductAttributeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductAttributeRef/CrudeProductAttributeRefUpdate/", content).Result;

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

        [HttpDelete("productattributerefdelete/{productattributercd?}")]
        public void CrudeProductAttributeRefDelete(System.String productAttributeRcd) {

            new CrudeProductAttributeRefBusiness().Delete(productAttributeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeProductAttributeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductAttributeRef/CrudeProductAttributeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
