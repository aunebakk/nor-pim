/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:37:58 AM
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
    [Route("api/1/crudedefaulttest")]
    public class CrudeDefaultTestController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultTestHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultTest.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultTestModel> CrudeDefaultTestFetchAll() {

            List<CrudeDefaultTestModel> defaultTests = 
                new CrudeDefaultTestBusiness().FetchAll();

            return defaultTests;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultTestFetchAllCount() {

            return new CrudeDefaultTestBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultTestModel> CrudeDefaultTestFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultTestModel> defaultTests = 
                new CrudeDefaultTestBusiness().FetchAllWithLimit(limit);

            return defaultTests;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultTestModel> CrudeDefaultTestFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultTestModel> defaultTests = 
                new CrudeDefaultTestBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultTests;
        }

        [HttpGet("fetchbydefaulttestid/{defaulttestid?}")]
        public CrudeDefaultTestModel CrudeDefaultTestFetchByDefaultTestId(System.Guid defaulttestid) {

            CrudeDefaultTestModel defaultTest = 
                new CrudeDefaultTestBusiness().FetchByDefaultTestId(defaulttestid);

            return defaultTest;
        }

        [HttpGet("fetchbysystemname/{systemname?}")]
        public CrudeDefaultTestModel CrudeDefaultTestFetchBySystemName(System.String systemname) {

            CrudeDefaultTestModel defaultTest = 
                new CrudeDefaultTestBusiness().FetchBySystemName(systemname);

            return defaultTest;
        }

        [HttpPost("crudedefaulttestcreate")]
        public CrudeDefaultTestModel CrudeDefaultTestCreate([Bind()] CrudeDefaultTestModel defaultTest) {

            new CrudeDefaultTestBusiness().Insert(defaultTest);

            return defaultTest;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultTestCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "SystemName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "TestArea" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "TestSubArea" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "TestAddress" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 5:37:58 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultTest/CrudeDefaultTestCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultTest/CrudeDefaultTestCreate/", content).Result;

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

        [HttpPut("crudedefaulttestupdate")]
        public CrudeDefaultTestModel CrudeDefaultTestUpdate([Bind()] CrudeDefaultTestModel defaultTest) {

            new CrudeDefaultTestBusiness().Update(defaultTest);

            return defaultTest;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultTestUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "SystemName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "TestArea" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "TestSubArea" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "TestAddress" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 5:37:58 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultTest/CrudeDefaultTestUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultTest/CrudeDefaultTestUpdate/", content).Result;

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

        [HttpDelete("defaulttestdelete/{defaulttestid?}")]
        public void CrudeDefaultTestDelete(System.Guid defaultTestId) {

            new CrudeDefaultTestBusiness().Delete(defaultTestId);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultTestDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultTest/CrudeDefaultTestDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
