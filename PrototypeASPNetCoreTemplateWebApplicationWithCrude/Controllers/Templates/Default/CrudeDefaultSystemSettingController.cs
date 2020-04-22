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
    [Route("api/1/crudedefaultsystemsetting")]
    public class CrudeDefaultSystemSettingController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultSystemSettingHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultSystemSetting.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultSystemSettingModel> CrudeDefaultSystemSettingFetchAll() {

            List<CrudeDefaultSystemSettingModel> defaultSystemSettings = 
                new CrudeDefaultSystemSettingBusiness().FetchAll();

            return defaultSystemSettings;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultSystemSettingFetchAllCount() {

            return new CrudeDefaultSystemSettingBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultSystemSettingModel> CrudeDefaultSystemSettingFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultSystemSettingModel> defaultSystemSettings = 
                new CrudeDefaultSystemSettingBusiness().FetchAllWithLimit(limit);

            return defaultSystemSettings;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultSystemSettingModel> CrudeDefaultSystemSettingFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultSystemSettingModel> defaultSystemSettings = 
                new CrudeDefaultSystemSettingBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultSystemSettings;
        }

        [HttpGet("fetchbydefaultsystemsettingid/{defaultsystemsettingid?}")]
        public CrudeDefaultSystemSettingModel CrudeDefaultSystemSettingFetchByDefaultSystemSettingId(System.Guid defaultsystemsettingid) {

            CrudeDefaultSystemSettingModel defaultSystemSetting = 
                new CrudeDefaultSystemSettingBusiness().FetchByDefaultSystemSettingId(defaultsystemsettingid);

            return defaultSystemSetting;
        }

        [HttpGet("fetchbydefaultsystemsettingrcd/{defaultsystemsettingrcd?}")]
        public IEnumerable<CrudeDefaultSystemSettingModel> CrudeDefaultSystemSettingFetchByDefaultSystemSettingRcd(System.String defaultsystemsettingrcd) {

            List<CrudeDefaultSystemSettingModel> defaultSystemSetting = 
                new CrudeDefaultSystemSettingBusiness().FetchByDefaultSystemSettingRcd(defaultsystemsettingrcd);

            return defaultSystemSetting;
        }

        [HttpPost("crudedefaultsystemsettingcreate")]
        public CrudeDefaultSystemSettingModel CrudeDefaultSystemSettingCreate([Bind()] CrudeDefaultSystemSettingModel defaultSystemSetting) {

            new CrudeDefaultSystemSettingBusiness().Insert(defaultSystemSetting);

            return defaultSystemSetting;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultSystemSettingCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemSettingRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemSettingValue" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 5:37:58 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultSystemSetting/CrudeDefaultSystemSettingCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultSystemSetting/CrudeDefaultSystemSettingCreate/", content).Result;

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

        [HttpPut("crudedefaultsystemsettingupdate")]
        public CrudeDefaultSystemSettingModel CrudeDefaultSystemSettingUpdate([Bind()] CrudeDefaultSystemSettingModel defaultSystemSetting) {

            new CrudeDefaultSystemSettingBusiness().Update(defaultSystemSetting);

            return defaultSystemSetting;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultSystemSettingUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemSettingRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemSettingValue" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 5:37:58 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultSystemSetting/CrudeDefaultSystemSettingUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultSystemSetting/CrudeDefaultSystemSettingUpdate/", content).Result;

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

        [HttpDelete("defaultsystemsettingdelete/{defaultsystemsettingid?}")]
        public void CrudeDefaultSystemSettingDelete(System.Guid defaultSystemSettingId) {

            new CrudeDefaultSystemSettingBusiness().Delete(defaultSystemSettingId);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultSystemSettingDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultSystemSetting/CrudeDefaultSystemSettingDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
