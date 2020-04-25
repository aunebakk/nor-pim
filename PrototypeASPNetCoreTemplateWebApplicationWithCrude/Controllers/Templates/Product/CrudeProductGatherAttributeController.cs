/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:25:17 PM
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
    [Route("api/1/crudeproductgatherattribute")]
    public class CrudeProductGatherAttributeController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductGatherAttributeHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductGatherAttribute.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductGatherAttributeModel> CrudeProductGatherAttributeFetchAll() {

            List<CrudeProductGatherAttributeModel> productGatherAttributes = 
                new CrudeProductGatherAttributeBusiness().FetchAll();

            return productGatherAttributes;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductGatherAttributeFetchAllCount() {

            return new CrudeProductGatherAttributeBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductGatherAttributeModel> CrudeProductGatherAttributeFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductGatherAttributeModel> productGatherAttributes = 
                new CrudeProductGatherAttributeBusiness().FetchAllWithLimit(limit);

            return productGatherAttributes;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductGatherAttributeModel> CrudeProductGatherAttributeFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductGatherAttributeModel> productGatherAttributes = 
                new CrudeProductGatherAttributeBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productGatherAttributes;
        }

        [HttpGet("fetchbyproductgatherattributeid/{productgatherattributeid?}")]
        public CrudeProductGatherAttributeModel CrudeProductGatherAttributeFetchByProductGatherAttributeId(System.Guid productgatherattributeid) {

            CrudeProductGatherAttributeModel productGatherAttribute = 
                new CrudeProductGatherAttributeBusiness().FetchByProductGatherAttributeId(productgatherattributeid);

            return productGatherAttribute;
        }

        [HttpGet("fetchbyproductgatherattributetypercd/{productgatherattributetypercd?}")]
        public IEnumerable<CrudeProductGatherAttributeModel> CrudeProductGatherAttributeFetchByProductGatherAttributeTypeRcd(System.String productgatherattributetypercd) {

            List<CrudeProductGatherAttributeModel> productGatherAttribute = 
                new CrudeProductGatherAttributeBusiness().FetchByProductGatherAttributeTypeRcd(productgatherattributetypercd);

            return productGatherAttribute;
        }

        [HttpGet("fetchbyproductgatherkeyid/{productgatherkeyid?}")]
        public IEnumerable<CrudeProductGatherAttributeModel> CrudeProductGatherAttributeFetchByProductGatherKeyId(System.Guid productgatherkeyid) {

            List<CrudeProductGatherAttributeModel> productGatherAttribute = 
                new CrudeProductGatherAttributeBusiness().FetchByProductGatherKeyId(productgatherkeyid);

            return productGatherAttribute;
        }

        [HttpPost("crudeproductgatherattributecreate")]
        public CrudeProductGatherAttributeModel CrudeProductGatherAttributeCreate([Bind()] CrudeProductGatherAttributeModel productGatherAttribute) {

            new CrudeProductGatherAttributeBusiness().Insert(productGatherAttribute);

            return productGatherAttribute;
        }

        [HttpGet("createtest")]
        public string CrudeProductGatherAttributeCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherAttributeValue" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherAttributeTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 12:25:17 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductGatherAttribute/CrudeProductGatherAttributeCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductGatherAttribute/CrudeProductGatherAttributeCreate/", content).Result;

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

        [HttpPut("crudeproductgatherattributeupdate")]
        public CrudeProductGatherAttributeModel CrudeProductGatherAttributeUpdate([Bind()] CrudeProductGatherAttributeModel productGatherAttribute) {

            new CrudeProductGatherAttributeBusiness().Update(productGatherAttribute);

            return productGatherAttribute;
        }

        [HttpGet("updatetest")]
        public string CrudeProductGatherAttributeUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherAttributeValue" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherAttributeTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 12:25:17 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductGatherAttribute/CrudeProductGatherAttributeUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductGatherAttribute/CrudeProductGatherAttributeUpdate/", content).Result;

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

        [HttpDelete("productgatherattributedelete/{productgatherattributeid?}")]
        public void CrudeProductGatherAttributeDelete(System.Guid productGatherAttributeId) {

            new CrudeProductGatherAttributeBusiness().Delete(productGatherAttributeId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductGatherAttributeDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductGatherAttribute/CrudeProductGatherAttributeDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
