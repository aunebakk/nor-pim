/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:35:20 PM
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
    [Route("api/1/crudeproductcategorymapping")]
    public class CrudeProductCategoryMappingController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductCategoryMappingHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductCategoryMapping.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductCategoryMappingModel> CrudeProductCategoryMappingFetchAll() {

            List<CrudeProductCategoryMappingModel> productCategoryMappings = 
                new CrudeProductCategoryMappingBusiness().FetchAll();

            return productCategoryMappings;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductCategoryMappingFetchAllCount() {

            return new CrudeProductCategoryMappingBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductCategoryMappingModel> CrudeProductCategoryMappingFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductCategoryMappingModel> productCategoryMappings = 
                new CrudeProductCategoryMappingBusiness().FetchAllWithLimit(limit);

            return productCategoryMappings;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductCategoryMappingModel> CrudeProductCategoryMappingFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductCategoryMappingModel> productCategoryMappings = 
                new CrudeProductCategoryMappingBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productCategoryMappings;
        }

        [HttpGet("fetchbyproductcategorymappingid/{productcategorymappingid?}")]
        public CrudeProductCategoryMappingModel CrudeProductCategoryMappingFetchByProductCategoryMappingId(System.Guid productcategorymappingid) {

            CrudeProductCategoryMappingModel productCategoryMapping = 
                new CrudeProductCategoryMappingBusiness().FetchByProductCategoryMappingId(productcategorymappingid);

            return productCategoryMapping;
        }

        [HttpGet("fetchbyproductcategoryid/{productcategoryid?}")]
        public IEnumerable<CrudeProductCategoryMappingModel> CrudeProductCategoryMappingFetchByProductCategoryId(System.Guid productcategoryid) {

            List<CrudeProductCategoryMappingModel> productCategoryMapping = 
                new CrudeProductCategoryMappingBusiness().FetchByProductCategoryId(productcategoryid);

            return productCategoryMapping;
        }

        [HttpGet("fetchbyproductid/{productid?}")]
        public IEnumerable<CrudeProductCategoryMappingModel> CrudeProductCategoryMappingFetchByProductId(System.Guid productid) {

            List<CrudeProductCategoryMappingModel> productCategoryMapping = 
                new CrudeProductCategoryMappingBusiness().FetchByProductId(productid);

            return productCategoryMapping;
        }

        [HttpPost("crudeproductcategorymappingcreate")]
        public CrudeProductCategoryMappingModel CrudeProductCategoryMappingCreate([Bind()] CrudeProductCategoryMappingModel productCategoryMapping) {

            new CrudeProductCategoryMappingBusiness().Insert(productCategoryMapping);

            return productCategoryMapping;
        }

        [HttpGet("createtest")]
        public string CrudeProductCategoryMappingCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 9:35:20 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductCategoryMapping/CrudeProductCategoryMappingCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductCategoryMapping/CrudeProductCategoryMappingCreate/", content).Result;

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

        [HttpPut("crudeproductcategorymappingupdate")]
        public CrudeProductCategoryMappingModel CrudeProductCategoryMappingUpdate([Bind()] CrudeProductCategoryMappingModel productCategoryMapping) {

            new CrudeProductCategoryMappingBusiness().Update(productCategoryMapping);

            return productCategoryMapping;
        }

        [HttpGet("updatetest")]
        public string CrudeProductCategoryMappingUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 9:35:20 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductCategoryMapping/CrudeProductCategoryMappingUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductCategoryMapping/CrudeProductCategoryMappingUpdate/", content).Result;

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

        [HttpDelete("productcategorymappingdelete/{productcategorymappingid?}")]
        public void CrudeProductCategoryMappingDelete(System.Guid productCategoryMappingId) {

            new CrudeProductCategoryMappingBusiness().Delete(productCategoryMappingId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductCategoryMappingDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductCategoryMapping/CrudeProductCategoryMappingDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
