/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:38:55 PM
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
    [Route("api/1/crudeproductdocumentation")]
    public class CrudeProductDocumentationController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductDocumentationHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductDocumentation.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductDocumentationModel> CrudeProductDocumentationFetchAll() {

            List<CrudeProductDocumentationModel> productDocumentations = 
                new CrudeProductDocumentationBusiness().FetchAll();

            return productDocumentations;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductDocumentationFetchAllCount() {

            return new CrudeProductDocumentationBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductDocumentationModel> CrudeProductDocumentationFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductDocumentationModel> productDocumentations = 
                new CrudeProductDocumentationBusiness().FetchAllWithLimit(limit);

            return productDocumentations;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductDocumentationModel> CrudeProductDocumentationFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductDocumentationModel> productDocumentations = 
                new CrudeProductDocumentationBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productDocumentations;
        }

        [HttpGet("fetchbyproductdocumentationid/{productdocumentationid?}")]
        public CrudeProductDocumentationModel CrudeProductDocumentationFetchByProductDocumentationId(System.Guid productdocumentationid) {

            CrudeProductDocumentationModel productDocumentation = 
                new CrudeProductDocumentationBusiness().FetchByProductDocumentationId(productdocumentationid);

            return productDocumentation;
        }

        [HttpGet("fetchbyproductid/{productid?}")]
        public IEnumerable<CrudeProductDocumentationModel> CrudeProductDocumentationFetchByProductId(System.Guid productid) {

            List<CrudeProductDocumentationModel> productDocumentation = 
                new CrudeProductDocumentationBusiness().FetchByProductId(productid);

            return productDocumentation;
        }

        [HttpGet("fetchbyproductdocumentationtypercd/{productdocumentationtypercd?}")]
        public IEnumerable<CrudeProductDocumentationModel> CrudeProductDocumentationFetchByProductDocumentationTypeRcd(System.String productdocumentationtypercd) {

            List<CrudeProductDocumentationModel> productDocumentation = 
                new CrudeProductDocumentationBusiness().FetchByProductDocumentationTypeRcd(productdocumentationtypercd);

            return productDocumentation;
        }

        [HttpPost("crudeproductdocumentationcreate")]
        public CrudeProductDocumentationModel CrudeProductDocumentationCreate([Bind()] CrudeProductDocumentationModel productDocumentation) {

            new CrudeProductDocumentationBusiness().Insert(productDocumentation);

            return productDocumentation;
        }

        [HttpGet("createtest")]
        public string CrudeProductDocumentationCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductDocumentationTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Documentation" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/9/2020 5:38:55 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductDocumentation/CrudeProductDocumentationCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductDocumentation/CrudeProductDocumentationCreate/", content).Result;

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

        [HttpPut("crudeproductdocumentationupdate")]
        public CrudeProductDocumentationModel CrudeProductDocumentationUpdate([Bind()] CrudeProductDocumentationModel productDocumentation) {

            new CrudeProductDocumentationBusiness().Update(productDocumentation);

            return productDocumentation;
        }

        [HttpGet("updatetest")]
        public string CrudeProductDocumentationUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductDocumentationTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Documentation" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/9/2020 5:38:55 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductDocumentation/CrudeProductDocumentationUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductDocumentation/CrudeProductDocumentationUpdate/", content).Result;

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

        [HttpDelete("productdocumentationdelete/{productdocumentationid?}")]
        public void CrudeProductDocumentationDelete(System.Guid productDocumentationId) {

            new CrudeProductDocumentationBusiness().Delete(productDocumentationId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductDocumentationDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductDocumentation/CrudeProductDocumentationDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
