/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 7:01:17 AM
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
    [Route("api/1/crudecartproduct")]
    public class CrudeCartProductController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeCartProductHelp(
            ) {

            return View(@"Views\Templates\Cart\CrudeCartProduct.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeCartProductModel> CrudeCartProductFetchAll() {

            List<CrudeCartProductModel> cartProducts = 
                new CrudeCartProductBusiness().FetchAll();

            return cartProducts;
        }

        [HttpGet("fetchallcount")]
        public int CrudeCartProductFetchAllCount() {

            return new CrudeCartProductBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeCartProductModel> CrudeCartProductFetchAllWithLimit(
                string limit
                ) {

            List<CrudeCartProductModel> cartProducts = 
                new CrudeCartProductBusiness().FetchAllWithLimit(limit);

            return cartProducts;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeCartProductModel> CrudeCartProductFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeCartProductModel> cartProducts = 
                new CrudeCartProductBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return cartProducts;
        }

        [HttpGet("fetchbycartproductid/{cartproductid?}")]
        public CrudeCartProductModel CrudeCartProductFetchByCartProductId(System.Guid cartproductid) {

            CrudeCartProductModel cartProduct = 
                new CrudeCartProductBusiness().FetchByCartProductId(cartproductid);

            return cartProduct;
        }

        [HttpGet("fetchbyclientid/{clientid?}")]
        public IEnumerable<CrudeCartProductModel> CrudeCartProductFetchByClientId(System.Guid clientid) {

            List<CrudeCartProductModel> cartProduct = 
                new CrudeCartProductBusiness().FetchByClientId(clientid);

            return cartProduct;
        }

        [HttpGet("fetchbyproductid/{productid?}")]
        public IEnumerable<CrudeCartProductModel> CrudeCartProductFetchByProductId(System.Guid productid) {

            List<CrudeCartProductModel> cartProduct = 
                new CrudeCartProductBusiness().FetchByProductId(productid);

            return cartProduct;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeCartProductModel> CrudeCartProductFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeCartProductModel> cartProduct = 
                new CrudeCartProductBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return cartProduct;
        }

        [HttpPost("crudecartproductcreate")]
        public CrudeCartProductModel CrudeCartProductCreate([Bind()] CrudeCartProductModel cartProduct) {

            new CrudeCartProductBusiness().Insert(cartProduct);

            return cartProduct;
        }

        [HttpGet("createtest")]
        public string CrudeCartProductCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "StateRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 7:01:17 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeCartProduct/CrudeCartProductCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeCartProduct/CrudeCartProductCreate/", content).Result;

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

        [HttpPut("crudecartproductupdate")]
        public CrudeCartProductModel CrudeCartProductUpdate([Bind()] CrudeCartProductModel cartProduct) {

            new CrudeCartProductBusiness().Update(cartProduct);

            return cartProduct;
        }

        [HttpGet("updatetest")]
        public string CrudeCartProductUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "StateRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 7:01:17 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeCartProduct/CrudeCartProductUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeCartProduct/CrudeCartProductUpdate/", content).Result;

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

        [HttpDelete("cartproductdelete/{cartproductid?}")]
        public void CrudeCartProductDelete(System.Guid cartProductId) {

            new CrudeCartProductBusiness().Delete(cartProductId);
        }

        [HttpGet("deletetest")]
        public string CrudeCartProductDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeCartProduct/CrudeCartProductDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
