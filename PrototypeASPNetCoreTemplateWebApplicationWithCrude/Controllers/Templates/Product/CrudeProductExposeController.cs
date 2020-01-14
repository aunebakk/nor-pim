/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:29:06 AM
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
    [Route("api/1/crudeproductexpose")]
    public class CrudeProductExposeController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductExposeHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductExpose.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductExposeModel> CrudeProductExposeFetchAll() {

            List<CrudeProductExposeModel> productExposes = 
                new CrudeProductExposeBusiness().FetchAll();

            return productExposes;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductExposeFetchAllCount() {

            return new CrudeProductExposeBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductExposeModel> CrudeProductExposeFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductExposeModel> productExposes = 
                new CrudeProductExposeBusiness().FetchAllWithLimit(limit);

            return productExposes;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductExposeModel> CrudeProductExposeFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductExposeModel> productExposes = 
                new CrudeProductExposeBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productExposes;
        }

        [HttpGet("fetchbyproductexposeid/{productexposeid?}")]
        public CrudeProductExposeModel CrudeProductExposeFetchByProductExposeId(System.Guid productexposeid) {

            CrudeProductExposeModel productExpose = 
                new CrudeProductExposeBusiness().FetchByProductExposeId(productexposeid);

            return productExpose;
        }

        [HttpGet("fetchbyexposeproductid/{exposeproductid?}")]
        public IEnumerable<CrudeProductExposeModel> CrudeProductExposeFetchByExposeProductId(System.Guid exposeproductid) {

            List<CrudeProductExposeModel> productExpose = 
                new CrudeProductExposeBusiness().FetchByExposeProductId(exposeproductid);

            return productExpose;
        }

        [HttpGet("fetchbyexposebasedonproductid/{exposebasedonproductid?}")]
        public IEnumerable<CrudeProductExposeModel> CrudeProductExposeFetchByExposeBasedOnProductId(System.Guid exposebasedonproductid) {

            List<CrudeProductExposeModel> productExpose = 
                new CrudeProductExposeBusiness().FetchByExposeBasedOnProductId(exposebasedonproductid);

            return productExpose;
        }

        [HttpGet("fetchbyproductexposesetid/{productexposesetid?}")]
        public IEnumerable<CrudeProductExposeModel> CrudeProductExposeFetchByProductExposeSetId(System.Guid productexposesetid) {

            List<CrudeProductExposeModel> productExpose = 
                new CrudeProductExposeBusiness().FetchByProductExposeSetId(productexposesetid);

            return productExpose;
        }

        [HttpPost("crudeproductexposecreate")]
        public CrudeProductExposeModel CrudeProductExposeCreate([Bind()] CrudeProductExposeModel productExpose) {

            new CrudeProductExposeBusiness().Insert(productExpose);

            return productExpose;
        }

        [HttpGet("createtest")]
        public string CrudeProductExposeCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:29:06 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductExpose/CrudeProductExposeCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductExpose/CrudeProductExposeCreate/", content).Result;

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

        [HttpPut("crudeproductexposeupdate")]
        public CrudeProductExposeModel CrudeProductExposeUpdate([Bind()] CrudeProductExposeModel productExpose) {

            new CrudeProductExposeBusiness().Update(productExpose);

            return productExpose;
        }

        [HttpGet("updatetest")]
        public string CrudeProductExposeUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 7:29:06 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductExpose/CrudeProductExposeUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductExpose/CrudeProductExposeUpdate/", content).Result;

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

        [HttpDelete("productexposedelete/{productexposeid?}")]
        public void CrudeProductExposeDelete(System.Guid productExposeId) {

            new CrudeProductExposeBusiness().Delete(productExposeId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductExposeDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductExpose/CrudeProductExposeDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
