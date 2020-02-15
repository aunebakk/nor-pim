/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:16 AM
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
    [Route("api/1/crudecartproductprice")]
    public class CrudeCartProductPriceController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeCartProductPriceHelp(
            ) {

            return View(@"Views\Templates\Cart\CrudeCartProductPrice.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeCartProductPriceModel> CrudeCartProductPriceFetchAll() {

            List<CrudeCartProductPriceModel> cartProductPrices = 
                new CrudeCartProductPriceBusiness().FetchAll();

            return cartProductPrices;
        }

        [HttpGet("fetchallcount")]
        public int CrudeCartProductPriceFetchAllCount() {

            return new CrudeCartProductPriceBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeCartProductPriceModel> CrudeCartProductPriceFetchAllWithLimit(
                string limit
                ) {

            List<CrudeCartProductPriceModel> cartProductPrices = 
                new CrudeCartProductPriceBusiness().FetchAllWithLimit(limit);

            return cartProductPrices;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeCartProductPriceModel> CrudeCartProductPriceFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeCartProductPriceModel> cartProductPrices = 
                new CrudeCartProductPriceBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return cartProductPrices;
        }

        [HttpGet("fetchbycartproductpriceid/{cartproductpriceid?}")]
        public CrudeCartProductPriceModel CrudeCartProductPriceFetchByCartProductPriceId(System.Guid cartproductpriceid) {

            CrudeCartProductPriceModel cartProductPrice = 
                new CrudeCartProductPriceBusiness().FetchByCartProductPriceId(cartproductpriceid);

            return cartProductPrice;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeCartProductPriceModel> CrudeCartProductPriceFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeCartProductPriceModel> cartProductPrice = 
                new CrudeCartProductPriceBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return cartProductPrice;
        }

        [HttpGet("fetchbyproductid/{productid?}")]
        public IEnumerable<CrudeCartProductPriceModel> CrudeCartProductPriceFetchByProductId(System.Guid productid) {

            List<CrudeCartProductPriceModel> cartProductPrice = 
                new CrudeCartProductPriceBusiness().FetchByProductId(productid);

            return cartProductPrice;
        }

        [HttpPost("crudecartproductpricecreate")]
        public CrudeCartProductPriceModel CrudeCartProductPriceCreate([Bind()] CrudeCartProductPriceModel cartProductPrice) {

            new CrudeCartProductPriceBusiness().Insert(cartProductPrice);

            return cartProductPrice;
        }

        [HttpGet("createtest")]
        public string CrudeCartProductPriceCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "StateRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:16 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeCartProductPrice/CrudeCartProductPriceCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeCartProductPrice/CrudeCartProductPriceCreate/", content).Result;

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

        [HttpPut("crudecartproductpriceupdate")]
        public CrudeCartProductPriceModel CrudeCartProductPriceUpdate([Bind()] CrudeCartProductPriceModel cartProductPrice) {

            new CrudeCartProductPriceBusiness().Update(cartProductPrice);

            return cartProductPrice;
        }

        [HttpGet("updatetest")]
        public string CrudeCartProductPriceUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "StateRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:16 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeCartProductPrice/CrudeCartProductPriceUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeCartProductPrice/CrudeCartProductPriceUpdate/", content).Result;

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

        [HttpDelete("cartproductpricedelete/{cartproductpriceid?}")]
        public void CrudeCartProductPriceDelete(System.Guid cartProductPriceId) {

            new CrudeCartProductPriceBusiness().Delete(cartProductPriceId);
        }

        [HttpGet("deletetest")]
        public string CrudeCartProductPriceDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeCartProductPrice/CrudeCartProductPriceDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
