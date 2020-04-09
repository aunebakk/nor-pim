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
    [Route("api/1/crudeproduct")]
    public class CrudeProductController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProduct.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductModel> CrudeProductFetchAll() {

            List<CrudeProductModel> products = 
                new CrudeProductBusiness().FetchAll();

            return products;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductFetchAllCount() {

            return new CrudeProductBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductModel> CrudeProductFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductModel> products = 
                new CrudeProductBusiness().FetchAllWithLimit(limit);

            return products;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductModel> CrudeProductFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductModel> products = 
                new CrudeProductBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return products;
        }

        [HttpGet("fetchbyproductid/{productid?}")]
        public CrudeProductModel CrudeProductFetchByProductId(System.Guid productid) {

            CrudeProductModel product = 
                new CrudeProductBusiness().FetchByProductId(productid);

            return product;
        }

        [HttpGet("fetchbyproductname/{productname?}")]
        public CrudeProductModel CrudeProductFetchByProductName(System.String productname) {

            CrudeProductModel product = 
                new CrudeProductBusiness().FetchByProductName(productname);

            return product;
        }

        [HttpGet("fetchbyproductbecameid/{productbecameid?}")]
        public IEnumerable<CrudeProductModel> CrudeProductFetchByProductBecameId(System.Guid productbecameid) {

            List<CrudeProductModel> product = 
                new CrudeProductBusiness().FetchByProductBecameId(productbecameid);

            return product;
        }

        [HttpPost("crudeproductcreate")]
        public CrudeProductModel CrudeProductCreate([Bind()] CrudeProductModel product) {

            new CrudeProductBusiness().Insert(product);

            return product;
        }

        [HttpGet("createtest")]
        public string CrudeProductCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StateRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/9/2020 5:38:55 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProduct/CrudeProductCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProduct/CrudeProductCreate/", content).Result;

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

        [HttpPut("crudeproductupdate")]
        public CrudeProductModel CrudeProductUpdate([Bind()] CrudeProductModel product) {

            new CrudeProductBusiness().Update(product);

            return product;
        }

        [HttpGet("updatetest")]
        public string CrudeProductUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "StateRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/9/2020 5:38:55 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProduct/CrudeProductUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProduct/CrudeProductUpdate/", content).Result;

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

        [HttpDelete("productdelete/{productid?}")]
        public void CrudeProductDelete(System.Guid productId) {

            new CrudeProductBusiness().Delete(productId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProduct/CrudeProductDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
