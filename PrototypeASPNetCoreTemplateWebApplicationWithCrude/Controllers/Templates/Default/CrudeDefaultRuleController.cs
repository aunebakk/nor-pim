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
    [Route("api/1/crudedefaultrule")]
    public class CrudeDefaultRuleController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultRuleHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultRule.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultRuleModel> CrudeDefaultRuleFetchAll() {

            List<CrudeDefaultRuleModel> defaultRules = 
                new CrudeDefaultRuleBusiness().FetchAll();

            return defaultRules;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultRuleFetchAllCount() {

            return new CrudeDefaultRuleBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultRuleModel> CrudeDefaultRuleFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultRuleModel> defaultRules = 
                new CrudeDefaultRuleBusiness().FetchAllWithLimit(limit);

            return defaultRules;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultRuleModel> CrudeDefaultRuleFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultRuleModel> defaultRules = 
                new CrudeDefaultRuleBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultRules;
        }

        [HttpGet("fetchbydefaultruleid/{defaultruleid?}")]
        public CrudeDefaultRuleModel CrudeDefaultRuleFetchByDefaultRuleId(System.Guid defaultruleid) {

            CrudeDefaultRuleModel defaultRule = 
                new CrudeDefaultRuleBusiness().FetchByDefaultRuleId(defaultruleid);

            return defaultRule;
        }

        [HttpGet("fetchbydefaultruletypercd/{defaultruletypercd?}")]
        public IEnumerable<CrudeDefaultRuleModel> CrudeDefaultRuleFetchByDefaultRuleTypeRcd(System.String defaultruletypercd) {

            List<CrudeDefaultRuleModel> defaultRule = 
                new CrudeDefaultRuleBusiness().FetchByDefaultRuleTypeRcd(defaultruletypercd);

            return defaultRule;
        }

        [HttpPost("crudedefaultrulecreate")]
        public CrudeDefaultRuleModel CrudeDefaultRuleCreate([Bind()] CrudeDefaultRuleModel defaultRule) {

            new CrudeDefaultRuleBusiness().Insert(defaultRule);

            return defaultRule;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultRuleCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultRuleTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Address" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/23/2020 11:50:18 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultRule/CrudeDefaultRuleCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultRule/CrudeDefaultRuleCreate/", content).Result;

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

        [HttpPut("crudedefaultruleupdate")]
        public CrudeDefaultRuleModel CrudeDefaultRuleUpdate([Bind()] CrudeDefaultRuleModel defaultRule) {

            new CrudeDefaultRuleBusiness().Update(defaultRule);

            return defaultRule;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultRuleUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultRuleTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Address" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/23/2020 11:50:18 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultRule/CrudeDefaultRuleUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultRule/CrudeDefaultRuleUpdate/", content).Result;

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

        [HttpDelete("defaultruledelete/{defaultruleid?}")]
        public void CrudeDefaultRuleDelete(System.Guid defaultRuleId) {

            new CrudeDefaultRuleBusiness().Delete(defaultRuleId);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultRuleDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultRule/CrudeDefaultRuleDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
