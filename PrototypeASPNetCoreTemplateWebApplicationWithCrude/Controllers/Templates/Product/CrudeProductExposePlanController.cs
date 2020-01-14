/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:31 PM
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
    [Route("api/1/crudeproductexposeplan")]
    public class CrudeProductExposePlanController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductExposePlanHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductExposePlan.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductExposePlanModel> CrudeProductExposePlanFetchAll() {

            List<CrudeProductExposePlanModel> productExposePlans = 
                new CrudeProductExposePlanBusiness().FetchAll();

            return productExposePlans;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductExposePlanFetchAllCount() {

            return new CrudeProductExposePlanBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductExposePlanModel> CrudeProductExposePlanFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductExposePlanModel> productExposePlans = 
                new CrudeProductExposePlanBusiness().FetchAllWithLimit(limit);

            return productExposePlans;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductExposePlanModel> CrudeProductExposePlanFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductExposePlanModel> productExposePlans = 
                new CrudeProductExposePlanBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productExposePlans;
        }

        [HttpGet("fetchbyproductexposeplanid/{productexposeplanid?}")]
        public CrudeProductExposePlanModel CrudeProductExposePlanFetchByProductExposePlanId(System.Guid productexposeplanid) {

            CrudeProductExposePlanModel productExposePlan = 
                new CrudeProductExposePlanBusiness().FetchByProductExposePlanId(productexposeplanid);

            return productExposePlan;
        }

        [HttpGet("fetchbyproductid/{productid?}")]
        public IEnumerable<CrudeProductExposePlanModel> CrudeProductExposePlanFetchByProductId(System.Guid productid) {

            List<CrudeProductExposePlanModel> productExposePlan = 
                new CrudeProductExposePlanBusiness().FetchByProductId(productid);

            return productExposePlan;
        }

        [HttpGet("fetchbyproductexposesettypercd/{productexposesettypercd?}")]
        public IEnumerable<CrudeProductExposePlanModel> CrudeProductExposePlanFetchByProductExposeSetTypeRcd(System.String productexposesettypercd) {

            List<CrudeProductExposePlanModel> productExposePlan = 
                new CrudeProductExposePlanBusiness().FetchByProductExposeSetTypeRcd(productexposesettypercd);

            return productExposePlan;
        }

        [HttpPost("crudeproductexposeplancreate")]
        public CrudeProductExposePlanModel CrudeProductExposePlanCreate([Bind()] CrudeProductExposePlanModel productExposePlan) {

            new CrudeProductExposePlanBusiness().Insert(productExposePlan);

            return productExposePlan;
        }

        [HttpGet("createtest")]
        public string CrudeProductExposePlanCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductExposeSetTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:23:31 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductExposePlan/CrudeProductExposePlanCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductExposePlan/CrudeProductExposePlanCreate/", content).Result;

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

        [HttpPut("crudeproductexposeplanupdate")]
        public CrudeProductExposePlanModel CrudeProductExposePlanUpdate([Bind()] CrudeProductExposePlanModel productExposePlan) {

            new CrudeProductExposePlanBusiness().Update(productExposePlan);

            return productExposePlan;
        }

        [HttpGet("updatetest")]
        public string CrudeProductExposePlanUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductExposeSetTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:23:31 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductExposePlan/CrudeProductExposePlanUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductExposePlan/CrudeProductExposePlanUpdate/", content).Result;

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

        [HttpDelete("productexposeplandelete/{productexposeplanid?}")]
        public void CrudeProductExposePlanDelete(System.Guid productExposePlanId) {

            new CrudeProductExposePlanBusiness().Delete(productExposePlanId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductExposePlanDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductExposePlan/CrudeProductExposePlanDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
