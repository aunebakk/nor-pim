/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:27 AM
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
    [Route("api/1/crudeproductexposeset")]
    public class CrudeProductExposeSetController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductExposeSetHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductExposeSet.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductExposeSetModel> CrudeProductExposeSetFetchAll() {

            List<CrudeProductExposeSetModel> productExposeSets = 
                new CrudeProductExposeSetBusiness().FetchAll();

            return productExposeSets;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductExposeSetFetchAllCount() {

            return new CrudeProductExposeSetBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductExposeSetModel> CrudeProductExposeSetFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductExposeSetModel> productExposeSets = 
                new CrudeProductExposeSetBusiness().FetchAllWithLimit(limit);

            return productExposeSets;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductExposeSetModel> CrudeProductExposeSetFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductExposeSetModel> productExposeSets = 
                new CrudeProductExposeSetBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productExposeSets;
        }

        [HttpGet("fetchbyproductexposesetid/{productexposesetid?}")]
        public CrudeProductExposeSetModel CrudeProductExposeSetFetchByProductExposeSetId(System.Guid productexposesetid) {

            CrudeProductExposeSetModel productExposeSet = 
                new CrudeProductExposeSetBusiness().FetchByProductExposeSetId(productexposesetid);

            return productExposeSet;
        }

        [HttpGet("fetchbyproductexposesetname/{productexposesetname?}")]
        public CrudeProductExposeSetModel CrudeProductExposeSetFetchByProductExposeSetName(System.String productexposesetname) {

            CrudeProductExposeSetModel productExposeSet = 
                new CrudeProductExposeSetBusiness().FetchByProductExposeSetName(productexposesetname);

            return productExposeSet;
        }

        [HttpGet("fetchbyproductexposesettypercd/{productexposesettypercd?}")]
        public IEnumerable<CrudeProductExposeSetModel> CrudeProductExposeSetFetchByProductExposeSetTypeRcd(System.String productexposesettypercd) {

            List<CrudeProductExposeSetModel> productExposeSet = 
                new CrudeProductExposeSetBusiness().FetchByProductExposeSetTypeRcd(productexposesettypercd);

            return productExposeSet;
        }

        [HttpPost("crudeproductexposesetcreate")]
        public CrudeProductExposeSetModel CrudeProductExposeSetCreate([Bind()] CrudeProductExposeSetModel productExposeSet) {

            new CrudeProductExposeSetBusiness().Insert(productExposeSet);

            return productExposeSet;
        }

        [HttpGet("createtest")]
        public string CrudeProductExposeSetCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductExposeSetTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductExposeSetName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:27 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductExposeSet/CrudeProductExposeSetCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductExposeSet/CrudeProductExposeSetCreate/", content).Result;

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

        [HttpPut("crudeproductexposesetupdate")]
        public CrudeProductExposeSetModel CrudeProductExposeSetUpdate([Bind()] CrudeProductExposeSetModel productExposeSet) {

            new CrudeProductExposeSetBusiness().Update(productExposeSet);

            return productExposeSet;
        }

        [HttpGet("updatetest")]
        public string CrudeProductExposeSetUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductExposeSetTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductExposeSetName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:27 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductExposeSet/CrudeProductExposeSetUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductExposeSet/CrudeProductExposeSetUpdate/", content).Result;

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

        [HttpDelete("productexposesetdelete/{productexposesetid?}")]
        public void CrudeProductExposeSetDelete(System.Guid productExposeSetId) {

            new CrudeProductExposeSetBusiness().Delete(productExposeSetId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductExposeSetDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductExposeSet/CrudeProductExposeSetDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
