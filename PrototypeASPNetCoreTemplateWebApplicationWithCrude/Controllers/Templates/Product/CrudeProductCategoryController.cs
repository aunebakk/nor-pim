/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:44:10 PM
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
    [Route("api/1/crudeproductcategory")]
    public class CrudeProductCategoryController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductCategoryHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductCategory.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductCategoryModel> CrudeProductCategoryFetchAll() {

            List<CrudeProductCategoryModel> productCategorys = 
                new CrudeProductCategoryBusiness().FetchAll();

            return productCategorys;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductCategoryFetchAllCount() {

            return new CrudeProductCategoryBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductCategoryModel> CrudeProductCategoryFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductCategoryModel> productCategorys = 
                new CrudeProductCategoryBusiness().FetchAllWithLimit(limit);

            return productCategorys;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductCategoryModel> CrudeProductCategoryFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductCategoryModel> productCategorys = 
                new CrudeProductCategoryBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productCategorys;
        }

        [HttpGet("fetchbyproductcategoryid/{productcategoryid?}")]
        public CrudeProductCategoryModel CrudeProductCategoryFetchByProductCategoryId(System.Guid productcategoryid) {

            CrudeProductCategoryModel productCategory = 
                new CrudeProductCategoryBusiness().FetchByProductCategoryId(productcategoryid);

            return productCategory;
        }

        [HttpGet("fetchbyproductcategoryname/{productcategoryname?}")]
        public CrudeProductCategoryModel CrudeProductCategoryFetchByProductCategoryName(System.String productcategoryname) {

            CrudeProductCategoryModel productCategory = 
                new CrudeProductCategoryBusiness().FetchByProductCategoryName(productcategoryname);

            return productCategory;
        }

        [HttpGet("fetchbyproductcategorybecameid/{productcategorybecameid?}")]
        public IEnumerable<CrudeProductCategoryModel> CrudeProductCategoryFetchByProductCategoryBecameId(System.Guid productcategorybecameid) {

            List<CrudeProductCategoryModel> productCategory = 
                new CrudeProductCategoryBusiness().FetchByProductCategoryBecameId(productcategorybecameid);

            return productCategory;
        }

        [HttpGet("fetchbyproductcategoryparentid/{productcategoryparentid?}")]
        public IEnumerable<CrudeProductCategoryModel> CrudeProductCategoryFetchByProductCategoryParentId(System.Guid productcategoryparentid) {

            List<CrudeProductCategoryModel> productCategory = 
                new CrudeProductCategoryBusiness().FetchByProductCategoryParentId(productcategoryparentid);

            return productCategory;
        }

        [HttpPost("crudeproductcategorycreate")]
        public CrudeProductCategoryModel CrudeProductCategoryCreate([Bind()] CrudeProductCategoryModel productCategory) {

            new CrudeProductCategoryBusiness().Insert(productCategory);

            return productCategory;
        }

        [HttpGet("createtest")]
        public string CrudeProductCategoryCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryPosition" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StateRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/12/2020 12:44:10 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductCategory/CrudeProductCategoryCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductCategory/CrudeProductCategoryCreate/", content).Result;

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

        [HttpPut("crudeproductcategoryupdate")]
        public CrudeProductCategoryModel CrudeProductCategoryUpdate([Bind()] CrudeProductCategoryModel productCategory) {

            new CrudeProductCategoryBusiness().Update(productCategory);

            return productCategory;
        }

        [HttpGet("updatetest")]
        public string CrudeProductCategoryUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryPosition" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StateRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/12/2020 12:44:10 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductCategory/CrudeProductCategoryUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductCategory/CrudeProductCategoryUpdate/", content).Result;

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

        [HttpDelete("productcategorydelete/{productcategoryid?}")]
        public void CrudeProductCategoryDelete(System.Guid productCategoryId) {

            new CrudeProductCategoryBusiness().Delete(productCategoryId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductCategoryDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductCategory/CrudeProductCategoryDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
