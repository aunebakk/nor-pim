/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:45:45 AM
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
    [Route("api/1/crudeclientgenderref")]
    public class CrudeClientGenderRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientGenderRefHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientGenderRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientGenderRefModel> CrudeClientGenderRefFetchAll() {

            List<CrudeClientGenderRefModel> clientGenderRefs = 
                new CrudeClientGenderRefBusiness().FetchAll();

            return clientGenderRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientGenderRefFetchAllCount() {

            return new CrudeClientGenderRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientGenderRefModel> CrudeClientGenderRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientGenderRefModel> clientGenderRefs = 
                new CrudeClientGenderRefBusiness().FetchAllWithLimit(limit);

            return clientGenderRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientGenderRefModel> CrudeClientGenderRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientGenderRefModel> clientGenderRefs = 
                new CrudeClientGenderRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientGenderRefs;
        }

        [HttpGet("fetchbyclientgenderrcd/{clientgenderrcd?}")]
        public CrudeClientGenderRefModel CrudeClientGenderRefFetchByClientGenderRcd(System.String clientgenderrcd) {

            CrudeClientGenderRefModel clientGenderRef = 
                new CrudeClientGenderRefBusiness().FetchByClientGenderRcd(clientgenderrcd);

            return clientGenderRef;
        }

        [HttpPost("crudeclientgenderrefcreate")]
        public CrudeClientGenderRefModel CrudeClientGenderRefCreate([Bind()] CrudeClientGenderRefModel clientGenderRef) {

            new CrudeClientGenderRefBusiness().Insert(clientGenderRef);

            return clientGenderRef;
        }

        [HttpGet("createtest")]
        public string CrudeClientGenderRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientGenderRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientGenderName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientGenderDescription" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:45 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientGenderRef/CrudeClientGenderRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientGenderRef/CrudeClientGenderRefCreate/", content).Result;

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

        [HttpPut("crudeclientgenderrefupdate")]
        public CrudeClientGenderRefModel CrudeClientGenderRefUpdate([Bind()] CrudeClientGenderRefModel clientGenderRef) {

            new CrudeClientGenderRefBusiness().Update(clientGenderRef);

            return clientGenderRef;
        }

        [HttpGet("updatetest")]
        public string CrudeClientGenderRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientGenderRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientGenderName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientGenderDescription" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:45 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientGenderRef/CrudeClientGenderRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientGenderRef/CrudeClientGenderRefUpdate/", content).Result;

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

        [HttpDelete("clientgenderrefdelete/{clientgenderrcd?}")]
        public void CrudeClientGenderRefDelete(System.String clientGenderRcd) {

            new CrudeClientGenderRefBusiness().Delete(clientGenderRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeClientGenderRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientGenderRef/CrudeClientGenderRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
