/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:40:49 PM
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
    [Route("api/1/crudeproductinforef")]
    public class CrudeProductInfoRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductInfoRefHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductInfoRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductInfoRefModel> CrudeProductInfoRefFetchAll() {

            List<CrudeProductInfoRefModel> productInfoRefs = 
                new CrudeProductInfoRefBusiness().FetchAll();

            return productInfoRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductInfoRefFetchAllCount() {

            return new CrudeProductInfoRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductInfoRefModel> CrudeProductInfoRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductInfoRefModel> productInfoRefs = 
                new CrudeProductInfoRefBusiness().FetchAllWithLimit(limit);

            return productInfoRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductInfoRefModel> CrudeProductInfoRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductInfoRefModel> productInfoRefs = 
                new CrudeProductInfoRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productInfoRefs;
        }

        [HttpGet("fetchbyproductinforcd/{productinforcd?}")]
        public CrudeProductInfoRefModel CrudeProductInfoRefFetchByProductInfoRcd(System.String productinforcd) {

            CrudeProductInfoRefModel productInfoRef = 
                new CrudeProductInfoRefBusiness().FetchByProductInfoRcd(productinforcd);

            return productInfoRef;
        }

        [HttpPost("crudeproductinforefcreate")]
        public CrudeProductInfoRefModel CrudeProductInfoRefCreate([Bind()] CrudeProductInfoRefModel productInfoRef) {

            new CrudeProductInfoRefBusiness().Insert(productInfoRef);

            return productInfoRef;
        }

        [HttpGet("createtest")]
        public string CrudeProductInfoRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductInfoRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductInfoName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:40:49 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductInfoRef/CrudeProductInfoRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductInfoRef/CrudeProductInfoRefCreate/", content).Result;

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

        [HttpPut("crudeproductinforefupdate")]
        public CrudeProductInfoRefModel CrudeProductInfoRefUpdate([Bind()] CrudeProductInfoRefModel productInfoRef) {

            new CrudeProductInfoRefBusiness().Update(productInfoRef);

            return productInfoRef;
        }

        [HttpGet("updatetest")]
        public string CrudeProductInfoRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductInfoRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductInfoName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:40:49 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductInfoRef/CrudeProductInfoRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductInfoRef/CrudeProductInfoRefUpdate/", content).Result;

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

        [HttpDelete("productinforefdelete/{productinforcd?}")]
        public void CrudeProductInfoRefDelete(System.String productInfoRcd) {

            new CrudeProductInfoRefBusiness().Delete(productInfoRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeProductInfoRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductInfoRef/CrudeProductInfoRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
