/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:22:59 AM
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
    [Route("api/1/crudeproductgather")]
    public class CrudeProductGatherController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductGatherHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductGather.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductGatherModel> CrudeProductGatherFetchAll() {

            List<CrudeProductGatherModel> productGathers = 
                new CrudeProductGatherBusiness().FetchAll();

            return productGathers;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductGatherFetchAllCount() {

            return new CrudeProductGatherBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductGatherModel> CrudeProductGatherFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductGatherModel> productGathers = 
                new CrudeProductGatherBusiness().FetchAllWithLimit(limit);

            return productGathers;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductGatherModel> CrudeProductGatherFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductGatherModel> productGathers = 
                new CrudeProductGatherBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productGathers;
        }

        [HttpGet("fetchbyproductgatherid/{productgatherid?}")]
        public CrudeProductGatherModel CrudeProductGatherFetchByProductGatherId(System.Guid productgatherid) {

            CrudeProductGatherModel productGather = 
                new CrudeProductGatherBusiness().FetchByProductGatherId(productgatherid);

            return productGather;
        }

        [HttpPost("crudeproductgathercreate")]
        public CrudeProductGatherModel CrudeProductGatherCreate([Bind()] CrudeProductGatherModel productGather) {

            new CrudeProductGatherBusiness().Insert(productGather);

            return productGather;
        }

        [HttpGet("createtest")]
        public string CrudeProductGatherCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "StartDateTime" , "4/25/2020 8:22:59 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinishDateTime" , "4/25/2020 8:22:59 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 8:22:59 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductGather/CrudeProductGatherCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductGather/CrudeProductGatherCreate/", content).Result;

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

        [HttpPut("crudeproductgatherupdate")]
        public CrudeProductGatherModel CrudeProductGatherUpdate([Bind()] CrudeProductGatherModel productGather) {

            new CrudeProductGatherBusiness().Update(productGather);

            return productGather;
        }

        [HttpGet("updatetest")]
        public string CrudeProductGatherUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "StartDateTime" , "4/25/2020 8:22:59 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinishDateTime" , "4/25/2020 8:22:59 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 8:22:59 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductGather/CrudeProductGatherUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductGather/CrudeProductGatherUpdate/", content).Result;

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

        [HttpDelete("productgatherdelete/{productgatherid?}")]
        public void CrudeProductGatherDelete(System.Guid productGatherId) {

            new CrudeProductGatherBusiness().Delete(productGatherId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductGatherDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductGather/CrudeProductGatherDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
