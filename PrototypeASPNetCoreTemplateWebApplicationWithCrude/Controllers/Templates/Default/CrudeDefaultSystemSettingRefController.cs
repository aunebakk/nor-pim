/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:45:11 PM
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
    [Route("api/1/crudedefaultsystemsettingref")]
    public class CrudeDefaultSystemSettingRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultSystemSettingRefHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultSystemSettingRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultSystemSettingRefModel> CrudeDefaultSystemSettingRefFetchAll() {

            List<CrudeDefaultSystemSettingRefModel> defaultSystemSettingRefs = 
                new CrudeDefaultSystemSettingRefBusiness().FetchAll();

            return defaultSystemSettingRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultSystemSettingRefFetchAllCount() {

            return new CrudeDefaultSystemSettingRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultSystemSettingRefModel> CrudeDefaultSystemSettingRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultSystemSettingRefModel> defaultSystemSettingRefs = 
                new CrudeDefaultSystemSettingRefBusiness().FetchAllWithLimit(limit);

            return defaultSystemSettingRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultSystemSettingRefModel> CrudeDefaultSystemSettingRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultSystemSettingRefModel> defaultSystemSettingRefs = 
                new CrudeDefaultSystemSettingRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultSystemSettingRefs;
        }

        [HttpGet("fetchbydefaultsystemsettingrcd/{defaultsystemsettingrcd?}")]
        public CrudeDefaultSystemSettingRefModel CrudeDefaultSystemSettingRefFetchByDefaultSystemSettingRcd(System.String defaultsystemsettingrcd) {

            CrudeDefaultSystemSettingRefModel defaultSystemSettingRef = 
                new CrudeDefaultSystemSettingRefBusiness().FetchByDefaultSystemSettingRcd(defaultsystemsettingrcd);

            return defaultSystemSettingRef;
        }

        [HttpPost("crudedefaultsystemsettingrefcreate")]
        public CrudeDefaultSystemSettingRefModel CrudeDefaultSystemSettingRefCreate([Bind()] CrudeDefaultSystemSettingRefModel defaultSystemSettingRef) {

            new CrudeDefaultSystemSettingRefBusiness().Insert(defaultSystemSettingRef);

            return defaultSystemSettingRef;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultSystemSettingRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemSettingRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemSettingName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/27/2020 3:45:11 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefCreate/", content).Result;

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

        [HttpPut("crudedefaultsystemsettingrefupdate")]
        public CrudeDefaultSystemSettingRefModel CrudeDefaultSystemSettingRefUpdate([Bind()] CrudeDefaultSystemSettingRefModel defaultSystemSettingRef) {

            new CrudeDefaultSystemSettingRefBusiness().Update(defaultSystemSettingRef);

            return defaultSystemSettingRef;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultSystemSettingRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemSettingRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemSettingName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/27/2020 3:45:11 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefUpdate/", content).Result;

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

        [HttpDelete("defaultsystemsettingrefdelete/{defaultsystemsettingrcd?}")]
        public void CrudeDefaultSystemSettingRefDelete(System.String defaultSystemSettingRcd) {

            new CrudeDefaultSystemSettingRefBusiness().Delete(defaultSystemSettingRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultSystemSettingRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultSystemSettingRef/CrudeDefaultSystemSettingRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
