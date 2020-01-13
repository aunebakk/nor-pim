/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:44:48 PM
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
    [Route("api/1/crudeproductfieldsetmapping")]
    public class CrudeProductFieldSetMappingController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductFieldSetMappingHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductFieldSetMapping.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductFieldSetMappingModel> CrudeProductFieldSetMappingFetchAll() {

            List<CrudeProductFieldSetMappingModel> productFieldSetMappings = 
                new CrudeProductFieldSetMappingBusiness().FetchAll();

            return productFieldSetMappings;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductFieldSetMappingFetchAllCount() {

            return new CrudeProductFieldSetMappingBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductFieldSetMappingModel> CrudeProductFieldSetMappingFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductFieldSetMappingModel> productFieldSetMappings = 
                new CrudeProductFieldSetMappingBusiness().FetchAllWithLimit(limit);

            return productFieldSetMappings;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductFieldSetMappingModel> CrudeProductFieldSetMappingFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductFieldSetMappingModel> productFieldSetMappings = 
                new CrudeProductFieldSetMappingBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productFieldSetMappings;
        }

        [HttpGet("fetchbyproductfieldsetmappingid/{productfieldsetmappingid?}")]
        public CrudeProductFieldSetMappingModel CrudeProductFieldSetMappingFetchByProductFieldSetMappingId(System.Guid productfieldsetmappingid) {

            CrudeProductFieldSetMappingModel productFieldSetMapping = 
                new CrudeProductFieldSetMappingBusiness().FetchByProductFieldSetMappingId(productfieldsetmappingid);

            return productFieldSetMapping;
        }

        [HttpGet("fetchbyproductfieldsetid/{productfieldsetid?}")]
        public IEnumerable<CrudeProductFieldSetMappingModel> CrudeProductFieldSetMappingFetchByProductFieldSetId(System.Guid productfieldsetid) {

            List<CrudeProductFieldSetMappingModel> productFieldSetMapping = 
                new CrudeProductFieldSetMappingBusiness().FetchByProductFieldSetId(productfieldsetid);

            return productFieldSetMapping;
        }

        [HttpGet("fetchbyproductidentifierrcd/{productidentifierrcd?}")]
        public IEnumerable<CrudeProductFieldSetMappingModel> CrudeProductFieldSetMappingFetchByProductIdentifierRcd(System.String productidentifierrcd) {

            List<CrudeProductFieldSetMappingModel> productFieldSetMapping = 
                new CrudeProductFieldSetMappingBusiness().FetchByProductIdentifierRcd(productidentifierrcd);

            return productFieldSetMapping;
        }

        [HttpGet("fetchbyproductattributercd/{productattributercd?}")]
        public IEnumerable<CrudeProductFieldSetMappingModel> CrudeProductFieldSetMappingFetchByProductAttributeRcd(System.String productattributercd) {

            List<CrudeProductFieldSetMappingModel> productFieldSetMapping = 
                new CrudeProductFieldSetMappingBusiness().FetchByProductAttributeRcd(productattributercd);

            return productFieldSetMapping;
        }

        [HttpGet("fetchbyproductinforcd/{productinforcd?}")]
        public IEnumerable<CrudeProductFieldSetMappingModel> CrudeProductFieldSetMappingFetchByProductInfoRcd(System.String productinforcd) {

            List<CrudeProductFieldSetMappingModel> productFieldSetMapping = 
                new CrudeProductFieldSetMappingBusiness().FetchByProductInfoRcd(productinforcd);

            return productFieldSetMapping;
        }

        [HttpGet("fetchbyproductimagetypercd/{productimagetypercd?}")]
        public IEnumerable<CrudeProductFieldSetMappingModel> CrudeProductFieldSetMappingFetchByProductImageTypeRcd(System.String productimagetypercd) {

            List<CrudeProductFieldSetMappingModel> productFieldSetMapping = 
                new CrudeProductFieldSetMappingBusiness().FetchByProductImageTypeRcd(productimagetypercd);

            return productFieldSetMapping;
        }

        [HttpGet("fetchbyproductdocumentationtypercd/{productdocumentationtypercd?}")]
        public IEnumerable<CrudeProductFieldSetMappingModel> CrudeProductFieldSetMappingFetchByProductDocumentationTypeRcd(System.String productdocumentationtypercd) {

            List<CrudeProductFieldSetMappingModel> productFieldSetMapping = 
                new CrudeProductFieldSetMappingBusiness().FetchByProductDocumentationTypeRcd(productdocumentationtypercd);

            return productFieldSetMapping;
        }

        [HttpPost("crudeproductfieldsetmappingcreate")]
        public CrudeProductFieldSetMappingModel CrudeProductFieldSetMappingCreate([Bind()] CrudeProductFieldSetMappingModel productFieldSetMapping) {

            new CrudeProductFieldSetMappingBusiness().Insert(productFieldSetMapping);

            return productFieldSetMapping;
        }

        [HttpGet("createtest")]
        public string CrudeProductFieldSetMappingCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductIdentifierRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductAttributeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductInfoRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductImageTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductDocumentationTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/13/2020 5:44:48 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductFieldSetMapping/CrudeProductFieldSetMappingCreate/", content).Result;
                // todo var response = client.PostAsync("http://localhost:5000/api/1/CrudeProductFieldSetMapping/CrudeProductFieldSetMappingCreate/", content).Result;

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

        [HttpPut("crudeproductfieldsetmappingupdate")]
        public CrudeProductFieldSetMappingModel CrudeProductFieldSetMappingUpdate([Bind()] CrudeProductFieldSetMappingModel productFieldSetMapping) {

            new CrudeProductFieldSetMappingBusiness().Update(productFieldSetMapping);

            return productFieldSetMapping;
        }

        [HttpGet("updatetest")]
        public string CrudeProductFieldSetMappingUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductIdentifierRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductAttributeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductInfoRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductImageTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductDocumentationTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/13/2020 5:44:48 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductFieldSetMapping/CrudeProductFieldSetMappingUpdate/", content).Result;
                // todo var response = client.PutAsync("http://localhost:5000/api/1/CrudeProductFieldSetMapping/CrudeProductFieldSetMappingUpdate/", content).Result;

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

        [HttpDelete("productfieldsetmappingdelete/{productfieldsetmappingid?}")]
        public void CrudeProductFieldSetMappingDelete(System.Guid productFieldSetMappingId) {

            new CrudeProductFieldSetMappingBusiness().Delete(productFieldSetMappingId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductFieldSetMappingDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductFieldSetMapping/CrudeProductFieldSetMappingDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
