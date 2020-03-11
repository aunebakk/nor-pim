/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:40:40 PM
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
    [Route("api/1/crudeproductinfo")]
    public class CrudeProductInfoController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductInfoHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductInfo.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductInfoModel> CrudeProductInfoFetchAll() {

            List<CrudeProductInfoModel> productInfos = 
                new CrudeProductInfoBusiness().FetchAll();

            return productInfos;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductInfoFetchAllCount() {

            return new CrudeProductInfoBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductInfoModel> CrudeProductInfoFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductInfoModel> productInfos = 
                new CrudeProductInfoBusiness().FetchAllWithLimit(limit);

            return productInfos;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductInfoModel> CrudeProductInfoFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductInfoModel> productInfos = 
                new CrudeProductInfoBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productInfos;
        }

        [HttpGet("fetchbyproductinfoid/{productinfoid?}")]
        public CrudeProductInfoModel CrudeProductInfoFetchByProductInfoId(System.Guid productinfoid) {

            CrudeProductInfoModel productInfo = 
                new CrudeProductInfoBusiness().FetchByProductInfoId(productinfoid);

            return productInfo;
        }

        [HttpGet("fetchbyproductid/{productid?}")]
        public IEnumerable<CrudeProductInfoModel> CrudeProductInfoFetchByProductId(System.Guid productid) {

            List<CrudeProductInfoModel> productInfo = 
                new CrudeProductInfoBusiness().FetchByProductId(productid);

            return productInfo;
        }

        [HttpGet("fetchbyproductinforcd/{productinforcd?}")]
        public IEnumerable<CrudeProductInfoModel> CrudeProductInfoFetchByProductInfoRcd(System.String productinforcd) {

            List<CrudeProductInfoModel> productInfo = 
                new CrudeProductInfoBusiness().FetchByProductInfoRcd(productinforcd);

            return productInfo;
        }

        [HttpPost("crudeproductinfocreate")]
        public CrudeProductInfoModel CrudeProductInfoCreate([Bind()] CrudeProductInfoModel productInfo) {

            new CrudeProductInfoBusiness().Insert(productInfo);

            return productInfo;
        }

        [HttpGet("createtest")]
        public string CrudeProductInfoCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductInfoRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductInfoValue" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:40:40 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductInfo/CrudeProductInfoCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductInfo/CrudeProductInfoCreate/", content).Result;

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

        [HttpPut("crudeproductinfoupdate")]
        public CrudeProductInfoModel CrudeProductInfoUpdate([Bind()] CrudeProductInfoModel productInfo) {

            new CrudeProductInfoBusiness().Update(productInfo);

            return productInfo;
        }

        [HttpGet("updatetest")]
        public string CrudeProductInfoUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductInfoRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductInfoValue" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:40:40 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductInfo/CrudeProductInfoUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductInfo/CrudeProductInfoUpdate/", content).Result;

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

        [HttpDelete("productinfodelete/{productinfoid?}")]
        public void CrudeProductInfoDelete(System.Guid productInfoId) {

            new CrudeProductInfoBusiness().Delete(productInfoId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductInfoDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductInfo/CrudeProductInfoDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
