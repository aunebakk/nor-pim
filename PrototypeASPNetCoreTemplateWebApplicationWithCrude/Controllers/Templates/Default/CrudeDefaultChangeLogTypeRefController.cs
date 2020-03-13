/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:45:46 AM
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
    [Route("api/1/crudedefaultchangelogtyperef")]
    public class CrudeDefaultChangeLogTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultChangeLogTypeRefHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultChangeLogTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultChangeLogTypeRefModel> CrudeDefaultChangeLogTypeRefFetchAll() {

            List<CrudeDefaultChangeLogTypeRefModel> defaultChangeLogTypeRefs = 
                new CrudeDefaultChangeLogTypeRefBusiness().FetchAll();

            return defaultChangeLogTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultChangeLogTypeRefFetchAllCount() {

            return new CrudeDefaultChangeLogTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultChangeLogTypeRefModel> CrudeDefaultChangeLogTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultChangeLogTypeRefModel> defaultChangeLogTypeRefs = 
                new CrudeDefaultChangeLogTypeRefBusiness().FetchAllWithLimit(limit);

            return defaultChangeLogTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultChangeLogTypeRefModel> CrudeDefaultChangeLogTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultChangeLogTypeRefModel> defaultChangeLogTypeRefs = 
                new CrudeDefaultChangeLogTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultChangeLogTypeRefs;
        }

        [HttpGet("fetchbydefaultchangelogtypercd/{defaultchangelogtypercd?}")]
        public CrudeDefaultChangeLogTypeRefModel CrudeDefaultChangeLogTypeRefFetchByDefaultChangeLogTypeRcd(System.String defaultchangelogtypercd) {

            CrudeDefaultChangeLogTypeRefModel defaultChangeLogTypeRef = 
                new CrudeDefaultChangeLogTypeRefBusiness().FetchByDefaultChangeLogTypeRcd(defaultchangelogtypercd);

            return defaultChangeLogTypeRef;
        }

        [HttpGet("fetchbydefaultuserid/{defaultuserid?}")]
        public IEnumerable<CrudeDefaultChangeLogTypeRefModel> CrudeDefaultChangeLogTypeRefFetchByDefaultUserId(System.Guid defaultuserid) {

            List<CrudeDefaultChangeLogTypeRefModel> defaultChangeLogTypeRef = 
                new CrudeDefaultChangeLogTypeRefBusiness().FetchByDefaultUserId(defaultuserid);

            return defaultChangeLogTypeRef;
        }

        [HttpPost("crudedefaultchangelogtyperefcreate")]
        public CrudeDefaultChangeLogTypeRefModel CrudeDefaultChangeLogTypeRefCreate([Bind()] CrudeDefaultChangeLogTypeRefModel defaultChangeLogTypeRef) {

            new CrudeDefaultChangeLogTypeRefBusiness().Insert(defaultChangeLogTypeRef);

            return defaultChangeLogTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultChangeLogTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultChangeLogTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultChangeLogTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:46 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultChangeLogTypeRef/CrudeDefaultChangeLogTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultChangeLogTypeRef/CrudeDefaultChangeLogTypeRefCreate/", content).Result;

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

        [HttpPut("crudedefaultchangelogtyperefupdate")]
        public CrudeDefaultChangeLogTypeRefModel CrudeDefaultChangeLogTypeRefUpdate([Bind()] CrudeDefaultChangeLogTypeRefModel defaultChangeLogTypeRef) {

            new CrudeDefaultChangeLogTypeRefBusiness().Update(defaultChangeLogTypeRef);

            return defaultChangeLogTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultChangeLogTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultChangeLogTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultChangeLogTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:46 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultChangeLogTypeRef/CrudeDefaultChangeLogTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultChangeLogTypeRef/CrudeDefaultChangeLogTypeRefUpdate/", content).Result;

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

        [HttpDelete("defaultchangelogtyperefdelete/{defaultchangelogtypercd?}")]
        public void CrudeDefaultChangeLogTypeRefDelete(System.String defaultChangeLogTypeRcd) {

            new CrudeDefaultChangeLogTypeRefBusiness().Delete(defaultChangeLogTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultChangeLogTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultChangeLogTypeRef/CrudeDefaultChangeLogTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
