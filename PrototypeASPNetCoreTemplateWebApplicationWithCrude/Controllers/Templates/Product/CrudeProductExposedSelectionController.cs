/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:47:59 AM
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
    [Route("api/1/crudeproductexposedselection")]
    public class CrudeProductExposedSelectionController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductExposedSelectionHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductExposedSelection.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductExposedSelectionModel> CrudeProductExposedSelectionFetchAll() {

            List<CrudeProductExposedSelectionModel> productExposedSelections = 
                new CrudeProductExposedSelectionBusiness().FetchAll();

            return productExposedSelections;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductExposedSelectionFetchAllCount() {

            return new CrudeProductExposedSelectionBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductExposedSelectionModel> CrudeProductExposedSelectionFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductExposedSelectionModel> productExposedSelections = 
                new CrudeProductExposedSelectionBusiness().FetchAllWithLimit(limit);

            return productExposedSelections;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductExposedSelectionModel> CrudeProductExposedSelectionFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductExposedSelectionModel> productExposedSelections = 
                new CrudeProductExposedSelectionBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productExposedSelections;
        }

        [HttpGet("fetchbyproductexposedselectionid/{productexposedselectionid?}")]
        public CrudeProductExposedSelectionModel CrudeProductExposedSelectionFetchByProductExposedSelectionId(System.Guid productexposedselectionid) {

            CrudeProductExposedSelectionModel productExposedSelection = 
                new CrudeProductExposedSelectionBusiness().FetchByProductExposedSelectionId(productexposedselectionid);

            return productExposedSelection;
        }

        [HttpGet("fetchbyproductexposeid/{productexposeid?}")]
        public IEnumerable<CrudeProductExposedSelectionModel> CrudeProductExposedSelectionFetchByProductExposeId(System.Guid productexposeid) {

            List<CrudeProductExposedSelectionModel> productExposedSelection = 
                new CrudeProductExposedSelectionBusiness().FetchByProductExposeId(productexposeid);

            return productExposedSelection;
        }

        [HttpPost("crudeproductexposedselectioncreate")]
        public CrudeProductExposedSelectionModel CrudeProductExposedSelectionCreate([Bind()] CrudeProductExposedSelectionModel productExposedSelection) {

            new CrudeProductExposedSelectionBusiness().Insert(productExposedSelection);

            return productExposedSelection;
        }

        [HttpGet("createtest")]
        public string CrudeProductExposedSelectionCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 10:47:59 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductExposedSelection/CrudeProductExposedSelectionCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductExposedSelection/CrudeProductExposedSelectionCreate/", content).Result;

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

        [HttpPut("crudeproductexposedselectionupdate")]
        public CrudeProductExposedSelectionModel CrudeProductExposedSelectionUpdate([Bind()] CrudeProductExposedSelectionModel productExposedSelection) {

            new CrudeProductExposedSelectionBusiness().Update(productExposedSelection);

            return productExposedSelection;
        }

        [HttpGet("updatetest")]
        public string CrudeProductExposedSelectionUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 10:47:59 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductExposedSelection/CrudeProductExposedSelectionUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductExposedSelection/CrudeProductExposedSelectionUpdate/", content).Result;

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

        [HttpDelete("productexposedselectiondelete/{productexposedselectionid?}")]
        public void CrudeProductExposedSelectionDelete(System.Guid productExposedSelectionId) {

            new CrudeProductExposedSelectionBusiness().Delete(productExposedSelectionId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductExposedSelectionDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductExposedSelection/CrudeProductExposedSelectionDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
