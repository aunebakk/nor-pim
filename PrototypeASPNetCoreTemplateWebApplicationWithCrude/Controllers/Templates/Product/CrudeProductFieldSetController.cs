/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:50:18 AM
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
    [Route("api/1/crudeproductfieldset")]
    public class CrudeProductFieldSetController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductFieldSetHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductFieldSet.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductFieldSetModel> CrudeProductFieldSetFetchAll() {

            List<CrudeProductFieldSetModel> productFieldSets = 
                new CrudeProductFieldSetBusiness().FetchAll();

            return productFieldSets;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductFieldSetFetchAllCount() {

            return new CrudeProductFieldSetBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductFieldSetModel> CrudeProductFieldSetFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductFieldSetModel> productFieldSets = 
                new CrudeProductFieldSetBusiness().FetchAllWithLimit(limit);

            return productFieldSets;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductFieldSetModel> CrudeProductFieldSetFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductFieldSetModel> productFieldSets = 
                new CrudeProductFieldSetBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productFieldSets;
        }

        [HttpGet("fetchbyproductfieldsetid/{productfieldsetid?}")]
        public CrudeProductFieldSetModel CrudeProductFieldSetFetchByProductFieldSetId(System.Guid productfieldsetid) {

            CrudeProductFieldSetModel productFieldSet = 
                new CrudeProductFieldSetBusiness().FetchByProductFieldSetId(productfieldsetid);

            return productFieldSet;
        }

        [HttpGet("fetchbyproductfieldsetname/{productfieldsetname?}")]
        public CrudeProductFieldSetModel CrudeProductFieldSetFetchByProductFieldSetName(System.String productfieldsetname) {

            CrudeProductFieldSetModel productFieldSet = 
                new CrudeProductFieldSetBusiness().FetchByProductFieldSetName(productfieldsetname);

            return productFieldSet;
        }

        [HttpPost("crudeproductfieldsetcreate")]
        public CrudeProductFieldSetModel CrudeProductFieldSetCreate([Bind()] CrudeProductFieldSetModel productFieldSet) {

            new CrudeProductFieldSetBusiness().Insert(productFieldSet);

            return productFieldSet;
        }

        [HttpGet("createtest")]
        public string CrudeProductFieldSetCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductFieldSetName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/23/2020 11:50:18 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductFieldSet/CrudeProductFieldSetCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductFieldSet/CrudeProductFieldSetCreate/", content).Result;

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

        [HttpPut("crudeproductfieldsetupdate")]
        public CrudeProductFieldSetModel CrudeProductFieldSetUpdate([Bind()] CrudeProductFieldSetModel productFieldSet) {

            new CrudeProductFieldSetBusiness().Update(productFieldSet);

            return productFieldSet;
        }

        [HttpGet("updatetest")]
        public string CrudeProductFieldSetUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductFieldSetName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/23/2020 11:50:18 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductFieldSet/CrudeProductFieldSetUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductFieldSet/CrudeProductFieldSetUpdate/", content).Result;

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

        [HttpDelete("productfieldsetdelete/{productfieldsetid?}")]
        public void CrudeProductFieldSetDelete(System.Guid productFieldSetId) {

            new CrudeProductFieldSetBusiness().Delete(productFieldSetId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductFieldSetDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductFieldSet/CrudeProductFieldSetDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
