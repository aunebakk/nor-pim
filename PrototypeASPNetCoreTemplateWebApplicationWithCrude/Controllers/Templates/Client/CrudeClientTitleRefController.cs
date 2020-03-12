/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:44:03 PM
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
    [Route("api/1/crudeclienttitleref")]
    public class CrudeClientTitleRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientTitleRefHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientTitleRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientTitleRefModel> CrudeClientTitleRefFetchAll() {

            List<CrudeClientTitleRefModel> clientTitleRefs = 
                new CrudeClientTitleRefBusiness().FetchAll();

            return clientTitleRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientTitleRefFetchAllCount() {

            return new CrudeClientTitleRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientTitleRefModel> CrudeClientTitleRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientTitleRefModel> clientTitleRefs = 
                new CrudeClientTitleRefBusiness().FetchAllWithLimit(limit);

            return clientTitleRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientTitleRefModel> CrudeClientTitleRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientTitleRefModel> clientTitleRefs = 
                new CrudeClientTitleRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientTitleRefs;
        }

        [HttpGet("fetchbyclienttitlercd/{clienttitlercd?}")]
        public CrudeClientTitleRefModel CrudeClientTitleRefFetchByClientTitleRcd(System.String clienttitlercd) {

            CrudeClientTitleRefModel clientTitleRef = 
                new CrudeClientTitleRefBusiness().FetchByClientTitleRcd(clienttitlercd);

            return clientTitleRef;
        }

        [HttpPost("crudeclienttitlerefcreate")]
        public CrudeClientTitleRefModel CrudeClientTitleRefCreate([Bind()] CrudeClientTitleRefModel clientTitleRef) {

            new CrudeClientTitleRefBusiness().Insert(clientTitleRef);

            return clientTitleRef;
        }

        [HttpGet("createtest")]
        public string CrudeClientTitleRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTitleRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTitleName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTitleDescription" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/12/2020 12:44:03 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientTitleRef/CrudeClientTitleRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientTitleRef/CrudeClientTitleRefCreate/", content).Result;

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

        [HttpPut("crudeclienttitlerefupdate")]
        public CrudeClientTitleRefModel CrudeClientTitleRefUpdate([Bind()] CrudeClientTitleRefModel clientTitleRef) {

            new CrudeClientTitleRefBusiness().Update(clientTitleRef);

            return clientTitleRef;
        }

        [HttpGet("updatetest")]
        public string CrudeClientTitleRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTitleRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTitleName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientTitleDescription" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/12/2020 12:44:03 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientTitleRef/CrudeClientTitleRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientTitleRef/CrudeClientTitleRefUpdate/", content).Result;

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

        [HttpDelete("clienttitlerefdelete/{clienttitlercd?}")]
        public void CrudeClientTitleRefDelete(System.String clientTitleRcd) {

            new CrudeClientTitleRefBusiness().Delete(clientTitleRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeClientTitleRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientTitleRef/CrudeClientTitleRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
