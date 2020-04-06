/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:33 PM
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
    [Route("api/1/crudeclientnationalityref")]
    public class CrudeClientNationalityRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientNationalityRefHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientNationalityRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientNationalityRefModel> CrudeClientNationalityRefFetchAll() {

            List<CrudeClientNationalityRefModel> clientNationalityRefs = 
                new CrudeClientNationalityRefBusiness().FetchAll();

            return clientNationalityRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientNationalityRefFetchAllCount() {

            return new CrudeClientNationalityRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientNationalityRefModel> CrudeClientNationalityRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientNationalityRefModel> clientNationalityRefs = 
                new CrudeClientNationalityRefBusiness().FetchAllWithLimit(limit);

            return clientNationalityRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientNationalityRefModel> CrudeClientNationalityRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientNationalityRefModel> clientNationalityRefs = 
                new CrudeClientNationalityRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientNationalityRefs;
        }

        [HttpGet("fetchbyclientnationalityrcd/{clientnationalityrcd?}")]
        public CrudeClientNationalityRefModel CrudeClientNationalityRefFetchByClientNationalityRcd(System.String clientnationalityrcd) {

            CrudeClientNationalityRefModel clientNationalityRef = 
                new CrudeClientNationalityRefBusiness().FetchByClientNationalityRcd(clientnationalityrcd);

            return clientNationalityRef;
        }

        [HttpPost("crudeclientnationalityrefcreate")]
        public CrudeClientNationalityRefModel CrudeClientNationalityRefCreate([Bind()] CrudeClientNationalityRefModel clientNationalityRef) {

            new CrudeClientNationalityRefBusiness().Insert(clientNationalityRef);

            return clientNationalityRef;
        }

        [HttpGet("createtest")]
        public string CrudeClientNationalityRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientNationalityRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientNationalityName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientNationalityDescription" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/6/2020 12:33:33 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientNationalityRef/CrudeClientNationalityRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientNationalityRef/CrudeClientNationalityRefCreate/", content).Result;

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

        [HttpPut("crudeclientnationalityrefupdate")]
        public CrudeClientNationalityRefModel CrudeClientNationalityRefUpdate([Bind()] CrudeClientNationalityRefModel clientNationalityRef) {

            new CrudeClientNationalityRefBusiness().Update(clientNationalityRef);

            return clientNationalityRef;
        }

        [HttpGet("updatetest")]
        public string CrudeClientNationalityRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientNationalityRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientNationalityName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientNationalityDescription" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/6/2020 12:33:33 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientNationalityRef/CrudeClientNationalityRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientNationalityRef/CrudeClientNationalityRefUpdate/", content).Result;

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

        [HttpDelete("clientnationalityrefdelete/{clientnationalityrcd?}")]
        public void CrudeClientNationalityRefDelete(System.String clientNationalityRcd) {

            new CrudeClientNationalityRefBusiness().Delete(clientNationalityRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeClientNationalityRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientNationalityRef/CrudeClientNationalityRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
