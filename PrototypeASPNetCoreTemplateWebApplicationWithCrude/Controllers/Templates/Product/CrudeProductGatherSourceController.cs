/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:39:49 PM
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
    [Route("api/1/crudeproductgathersource")]
    public class CrudeProductGatherSourceController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductGatherSourceHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductGatherSource.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductGatherSourceModel> CrudeProductGatherSourceFetchAll() {

            List<CrudeProductGatherSourceModel> productGatherSources = 
                new CrudeProductGatherSourceBusiness().FetchAll();

            return productGatherSources;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductGatherSourceFetchAllCount() {

            return new CrudeProductGatherSourceBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductGatherSourceModel> CrudeProductGatherSourceFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductGatherSourceModel> productGatherSources = 
                new CrudeProductGatherSourceBusiness().FetchAllWithLimit(limit);

            return productGatherSources;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductGatherSourceModel> CrudeProductGatherSourceFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductGatherSourceModel> productGatherSources = 
                new CrudeProductGatherSourceBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productGatherSources;
        }

        [HttpGet("fetchbyproductgathersourceid/{productgathersourceid?}")]
        public CrudeProductGatherSourceModel CrudeProductGatherSourceFetchByProductGatherSourceId(System.Guid productgathersourceid) {

            CrudeProductGatherSourceModel productGatherSource = 
                new CrudeProductGatherSourceBusiness().FetchByProductGatherSourceId(productgathersourceid);

            return productGatherSource;
        }

        [HttpGet("fetchbyproductgatherid/{productgatherid?}")]
        public IEnumerable<CrudeProductGatherSourceModel> CrudeProductGatherSourceFetchByProductGatherId(System.Guid productgatherid) {

            List<CrudeProductGatherSourceModel> productGatherSource = 
                new CrudeProductGatherSourceBusiness().FetchByProductGatherId(productgatherid);

            return productGatherSource;
        }

        [HttpGet("fetchbyproductgathersourcetypercd/{productgathersourcetypercd?}")]
        public IEnumerable<CrudeProductGatherSourceModel> CrudeProductGatherSourceFetchByProductGatherSourceTypeRcd(System.String productgathersourcetypercd) {

            List<CrudeProductGatherSourceModel> productGatherSource = 
                new CrudeProductGatherSourceBusiness().FetchByProductGatherSourceTypeRcd(productgathersourcetypercd);

            return productGatherSource;
        }

        [HttpPost("crudeproductgathersourcecreate")]
        public CrudeProductGatherSourceModel CrudeProductGatherSourceCreate([Bind()] CrudeProductGatherSourceModel productGatherSource) {

            new CrudeProductGatherSourceBusiness().Insert(productGatherSource);

            return productGatherSource;
        }

        [HttpGet("createtest")]
        public string CrudeProductGatherSourceCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherSourceTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:39:49 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductGatherSource/CrudeProductGatherSourceCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductGatherSource/CrudeProductGatherSourceCreate/", content).Result;

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

        [HttpPut("crudeproductgathersourceupdate")]
        public CrudeProductGatherSourceModel CrudeProductGatherSourceUpdate([Bind()] CrudeProductGatherSourceModel productGatherSource) {

            new CrudeProductGatherSourceBusiness().Update(productGatherSource);

            return productGatherSource;
        }

        [HttpGet("updatetest")]
        public string CrudeProductGatherSourceUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherSourceTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:39:49 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductGatherSource/CrudeProductGatherSourceUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductGatherSource/CrudeProductGatherSourceUpdate/", content).Result;

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

        [HttpDelete("productgathersourcedelete/{productgathersourceid?}")]
        public void CrudeProductGatherSourceDelete(System.Guid productGatherSourceId) {

            new CrudeProductGatherSourceBusiness().Delete(productGatherSourceId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductGatherSourceDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductGatherSource/CrudeProductGatherSourceDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
