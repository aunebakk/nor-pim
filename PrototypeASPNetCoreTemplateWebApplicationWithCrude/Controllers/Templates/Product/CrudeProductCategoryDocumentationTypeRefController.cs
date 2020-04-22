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
    [Route("api/1/crudeproductcategorydocumentationtyperef")]
    public class CrudeProductCategoryDocumentationTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductCategoryDocumentationTypeRefHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductCategoryDocumentationTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductCategoryDocumentationTypeRefModel> CrudeProductCategoryDocumentationTypeRefFetchAll() {

            List<CrudeProductCategoryDocumentationTypeRefModel> productCategoryDocumentationTypeRefs = 
                new CrudeProductCategoryDocumentationTypeRefBusiness().FetchAll();

            return productCategoryDocumentationTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductCategoryDocumentationTypeRefFetchAllCount() {

            return new CrudeProductCategoryDocumentationTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductCategoryDocumentationTypeRefModel> CrudeProductCategoryDocumentationTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductCategoryDocumentationTypeRefModel> productCategoryDocumentationTypeRefs = 
                new CrudeProductCategoryDocumentationTypeRefBusiness().FetchAllWithLimit(limit);

            return productCategoryDocumentationTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductCategoryDocumentationTypeRefModel> CrudeProductCategoryDocumentationTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductCategoryDocumentationTypeRefModel> productCategoryDocumentationTypeRefs = 
                new CrudeProductCategoryDocumentationTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productCategoryDocumentationTypeRefs;
        }

        [HttpGet("fetchbyproductcategorydocumentationtypercd/{productcategorydocumentationtypercd?}")]
        public CrudeProductCategoryDocumentationTypeRefModel CrudeProductCategoryDocumentationTypeRefFetchByProductCategoryDocumentationTypeRcd(System.String productcategorydocumentationtypercd) {

            CrudeProductCategoryDocumentationTypeRefModel productCategoryDocumentationTypeRef = 
                new CrudeProductCategoryDocumentationTypeRefBusiness().FetchByProductCategoryDocumentationTypeRcd(productcategorydocumentationtypercd);

            return productCategoryDocumentationTypeRef;
        }

        [HttpPost("crudeproductcategorydocumentationtyperefcreate")]
        public CrudeProductCategoryDocumentationTypeRefModel CrudeProductCategoryDocumentationTypeRefCreate([Bind()] CrudeProductCategoryDocumentationTypeRefModel productCategoryDocumentationTypeRef) {

            new CrudeProductCategoryDocumentationTypeRefBusiness().Insert(productCategoryDocumentationTypeRef);

            return productCategoryDocumentationTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeProductCategoryDocumentationTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryDocumentationTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryDocumentationTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 7:01:24 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefCreate/", content).Result;

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

        [HttpPut("crudeproductcategorydocumentationtyperefupdate")]
        public CrudeProductCategoryDocumentationTypeRefModel CrudeProductCategoryDocumentationTypeRefUpdate([Bind()] CrudeProductCategoryDocumentationTypeRefModel productCategoryDocumentationTypeRef) {

            new CrudeProductCategoryDocumentationTypeRefBusiness().Update(productCategoryDocumentationTypeRef);

            return productCategoryDocumentationTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeProductCategoryDocumentationTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryDocumentationTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryDocumentationTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 7:01:24 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefUpdate/", content).Result;

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

        [HttpDelete("productcategorydocumentationtyperefdelete/{productcategorydocumentationtypercd?}")]
        public void CrudeProductCategoryDocumentationTypeRefDelete(System.String productCategoryDocumentationTypeRcd) {

            new CrudeProductCategoryDocumentationTypeRefBusiness().Delete(productCategoryDocumentationTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeProductCategoryDocumentationTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductCategoryDocumentationTypeRef/CrudeProductCategoryDocumentationTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
