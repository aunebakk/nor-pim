/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:26:53 AM
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
    [Route("api/1/crudeproductchangeset")]
    public class CrudeProductChangeSetController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductChangeSetHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductChangeSet.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductChangeSetModel> CrudeProductChangeSetFetchAll() {

            List<CrudeProductChangeSetModel> productChangeSets = 
                new CrudeProductChangeSetBusiness().FetchAll();

            return productChangeSets;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductChangeSetFetchAllCount() {

            return new CrudeProductChangeSetBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductChangeSetModel> CrudeProductChangeSetFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductChangeSetModel> productChangeSets = 
                new CrudeProductChangeSetBusiness().FetchAllWithLimit(limit);

            return productChangeSets;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductChangeSetModel> CrudeProductChangeSetFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductChangeSetModel> productChangeSets = 
                new CrudeProductChangeSetBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productChangeSets;
        }

        [HttpGet("fetchbyproductchangesetid/{productchangesetid?}")]
        public CrudeProductChangeSetModel CrudeProductChangeSetFetchByProductChangeSetId(System.Guid productchangesetid) {

            CrudeProductChangeSetModel productChangeSet = 
                new CrudeProductChangeSetBusiness().FetchByProductChangeSetId(productchangesetid);

            return productChangeSet;
        }

        [HttpGet("fetchbyproductid/{productid?}")]
        public IEnumerable<CrudeProductChangeSetModel> CrudeProductChangeSetFetchByProductId(System.Guid productid) {

            List<CrudeProductChangeSetModel> productChangeSet = 
                new CrudeProductChangeSetBusiness().FetchByProductId(productid);

            return productChangeSet;
        }

        [HttpGet("fetchbyproductgatherkeyid/{productgatherkeyid?}")]
        public IEnumerable<CrudeProductChangeSetModel> CrudeProductChangeSetFetchByProductGatherKeyId(System.Guid productgatherkeyid) {

            List<CrudeProductChangeSetModel> productChangeSet = 
                new CrudeProductChangeSetBusiness().FetchByProductGatherKeyId(productgatherkeyid);

            return productChangeSet;
        }

        [HttpPost("crudeproductchangesetcreate")]
        public CrudeProductChangeSetModel CrudeProductChangeSetCreate([Bind()] CrudeProductChangeSetModel productChangeSet) {

            new CrudeProductChangeSetBusiness().Insert(productChangeSet);

            return productChangeSet;
        }

        [HttpGet("createtest")]
        public string CrudeProductChangeSetCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/9/2020 7:26:53 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductChangeSet/CrudeProductChangeSetCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductChangeSet/CrudeProductChangeSetCreate/", content).Result;

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

        [HttpPut("crudeproductchangesetupdate")]
        public CrudeProductChangeSetModel CrudeProductChangeSetUpdate([Bind()] CrudeProductChangeSetModel productChangeSet) {

            new CrudeProductChangeSetBusiness().Update(productChangeSet);

            return productChangeSet;
        }

        [HttpGet("updatetest")]
        public string CrudeProductChangeSetUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/9/2020 7:26:53 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductChangeSet/CrudeProductChangeSetUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductChangeSet/CrudeProductChangeSetUpdate/", content).Result;

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

        [HttpDelete("productchangesetdelete/{productchangesetid?}")]
        public void CrudeProductChangeSetDelete(System.Guid productChangeSetId) {

            new CrudeProductChangeSetBusiness().Delete(productChangeSetId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductChangeSetDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductChangeSet/CrudeProductChangeSetDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
