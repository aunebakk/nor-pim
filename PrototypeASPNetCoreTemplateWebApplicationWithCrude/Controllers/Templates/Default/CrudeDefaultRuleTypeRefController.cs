/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:37:33 PM
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
    [Route("api/1/crudedefaultruletyperef")]
    public class CrudeDefaultRuleTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultRuleTypeRefHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultRuleTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultRuleTypeRefModel> CrudeDefaultRuleTypeRefFetchAll() {

            List<CrudeDefaultRuleTypeRefModel> defaultRuleTypeRefs = 
                new CrudeDefaultRuleTypeRefBusiness().FetchAll();

            return defaultRuleTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultRuleTypeRefFetchAllCount() {

            return new CrudeDefaultRuleTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultRuleTypeRefModel> CrudeDefaultRuleTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultRuleTypeRefModel> defaultRuleTypeRefs = 
                new CrudeDefaultRuleTypeRefBusiness().FetchAllWithLimit(limit);

            return defaultRuleTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultRuleTypeRefModel> CrudeDefaultRuleTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultRuleTypeRefModel> defaultRuleTypeRefs = 
                new CrudeDefaultRuleTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultRuleTypeRefs;
        }

        [HttpGet("fetchbydefaultruletypercd/{defaultruletypercd?}")]
        public CrudeDefaultRuleTypeRefModel CrudeDefaultRuleTypeRefFetchByDefaultRuleTypeRcd(System.String defaultruletypercd) {

            CrudeDefaultRuleTypeRefModel defaultRuleTypeRef = 
                new CrudeDefaultRuleTypeRefBusiness().FetchByDefaultRuleTypeRcd(defaultruletypercd);

            return defaultRuleTypeRef;
        }

        [HttpPost("crudedefaultruletyperefcreate")]
        public CrudeDefaultRuleTypeRefModel CrudeDefaultRuleTypeRefCreate([Bind()] CrudeDefaultRuleTypeRefModel defaultRuleTypeRef) {

            new CrudeDefaultRuleTypeRefBusiness().Insert(defaultRuleTypeRef);

            return defaultRuleTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultRuleTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultRuleTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultRuleTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:37:33 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultRuleTypeRef/CrudeDefaultRuleTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultRuleTypeRef/CrudeDefaultRuleTypeRefCreate/", content).Result;

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

        [HttpPut("crudedefaultruletyperefupdate")]
        public CrudeDefaultRuleTypeRefModel CrudeDefaultRuleTypeRefUpdate([Bind()] CrudeDefaultRuleTypeRefModel defaultRuleTypeRef) {

            new CrudeDefaultRuleTypeRefBusiness().Update(defaultRuleTypeRef);

            return defaultRuleTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultRuleTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultRuleTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultRuleTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:37:33 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultRuleTypeRef/CrudeDefaultRuleTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultRuleTypeRef/CrudeDefaultRuleTypeRefUpdate/", content).Result;

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

        [HttpDelete("defaultruletyperefdelete/{defaultruletypercd?}")]
        public void CrudeDefaultRuleTypeRefDelete(System.String defaultRuleTypeRcd) {

            new CrudeDefaultRuleTypeRefBusiness().Delete(defaultRuleTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultRuleTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultRuleTypeRef/CrudeDefaultRuleTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
