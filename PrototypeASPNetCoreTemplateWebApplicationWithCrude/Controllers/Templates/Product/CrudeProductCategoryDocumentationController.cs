/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:50:18 AM
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
    [Route("api/1/crudeproductcategorydocumentation")]
    public class CrudeProductCategoryDocumentationController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductCategoryDocumentationHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductCategoryDocumentation.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductCategoryDocumentationModel> CrudeProductCategoryDocumentationFetchAll() {

            List<CrudeProductCategoryDocumentationModel> productCategoryDocumentations = 
                new CrudeProductCategoryDocumentationBusiness().FetchAll();

            return productCategoryDocumentations;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductCategoryDocumentationFetchAllCount() {

            return new CrudeProductCategoryDocumentationBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductCategoryDocumentationModel> CrudeProductCategoryDocumentationFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductCategoryDocumentationModel> productCategoryDocumentations = 
                new CrudeProductCategoryDocumentationBusiness().FetchAllWithLimit(limit);

            return productCategoryDocumentations;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductCategoryDocumentationModel> CrudeProductCategoryDocumentationFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductCategoryDocumentationModel> productCategoryDocumentations = 
                new CrudeProductCategoryDocumentationBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productCategoryDocumentations;
        }

        [HttpGet("fetchbyproductcategorydocumentationid/{productcategorydocumentationid?}")]
        public CrudeProductCategoryDocumentationModel CrudeProductCategoryDocumentationFetchByProductCategoryDocumentationId(System.Guid productcategorydocumentationid) {

            CrudeProductCategoryDocumentationModel productCategoryDocumentation = 
                new CrudeProductCategoryDocumentationBusiness().FetchByProductCategoryDocumentationId(productcategorydocumentationid);

            return productCategoryDocumentation;
        }

        [HttpGet("fetchbyproductcategorydocumentationtypercd/{productcategorydocumentationtypercd?}")]
        public IEnumerable<CrudeProductCategoryDocumentationModel> CrudeProductCategoryDocumentationFetchByProductCategoryDocumentationTypeRcd(System.String productcategorydocumentationtypercd) {

            List<CrudeProductCategoryDocumentationModel> productCategoryDocumentation = 
                new CrudeProductCategoryDocumentationBusiness().FetchByProductCategoryDocumentationTypeRcd(productcategorydocumentationtypercd);

            return productCategoryDocumentation;
        }

        [HttpGet("fetchbyproductcategoryid/{productcategoryid?}")]
        public IEnumerable<CrudeProductCategoryDocumentationModel> CrudeProductCategoryDocumentationFetchByProductCategoryId(System.Guid productcategoryid) {

            List<CrudeProductCategoryDocumentationModel> productCategoryDocumentation = 
                new CrudeProductCategoryDocumentationBusiness().FetchByProductCategoryId(productcategoryid);

            return productCategoryDocumentation;
        }

        [HttpPost("crudeproductcategorydocumentationcreate")]
        public CrudeProductCategoryDocumentationModel CrudeProductCategoryDocumentationCreate([Bind()] CrudeProductCategoryDocumentationModel productCategoryDocumentation) {

            new CrudeProductCategoryDocumentationBusiness().Insert(productCategoryDocumentation);

            return productCategoryDocumentation;
        }

        [HttpGet("createtest")]
        public string CrudeProductCategoryDocumentationCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryDocumentationTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Documentation" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/23/2020 11:50:18 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationCreate/", content).Result;

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

        [HttpPut("crudeproductcategorydocumentationupdate")]
        public CrudeProductCategoryDocumentationModel CrudeProductCategoryDocumentationUpdate([Bind()] CrudeProductCategoryDocumentationModel productCategoryDocumentation) {

            new CrudeProductCategoryDocumentationBusiness().Update(productCategoryDocumentation);

            return productCategoryDocumentation;
        }

        [HttpGet("updatetest")]
        public string CrudeProductCategoryDocumentationUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryDocumentationTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Documentation" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/23/2020 11:50:18 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationUpdate/", content).Result;

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

        [HttpDelete("productcategorydocumentationdelete/{productcategorydocumentationid?}")]
        public void CrudeProductCategoryDocumentationDelete(System.Guid productCategoryDocumentationId) {

            new CrudeProductCategoryDocumentationBusiness().Delete(productCategoryDocumentationId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductCategoryDocumentationDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductCategoryDocumentation/CrudeProductCategoryDocumentationDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
