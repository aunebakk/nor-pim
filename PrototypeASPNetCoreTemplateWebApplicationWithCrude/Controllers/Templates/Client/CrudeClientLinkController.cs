/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:35:20 PM
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
    [Route("api/1/crudeclientlink")]
    public class CrudeClientLinkController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientLinkHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientLink.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientLinkModel> CrudeClientLinkFetchAll() {

            List<CrudeClientLinkModel> clientLinks = 
                new CrudeClientLinkBusiness().FetchAll();

            return clientLinks;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientLinkFetchAllCount() {

            return new CrudeClientLinkBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientLinkModel> CrudeClientLinkFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientLinkModel> clientLinks = 
                new CrudeClientLinkBusiness().FetchAllWithLimit(limit);

            return clientLinks;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientLinkModel> CrudeClientLinkFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientLinkModel> clientLinks = 
                new CrudeClientLinkBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientLinks;
        }

        [HttpGet("fetchbyclientlinkid/{clientlinkid?}")]
        public CrudeClientLinkModel CrudeClientLinkFetchByClientLinkId(System.Guid clientlinkid) {

            CrudeClientLinkModel clientLink = 
                new CrudeClientLinkBusiness().FetchByClientLinkId(clientlinkid);

            return clientLink;
        }

        [HttpGet("fetchbylinkname/{linkname?}")]
        public CrudeClientLinkModel CrudeClientLinkFetchByLinkName(System.String linkname) {

            CrudeClientLinkModel clientLink = 
                new CrudeClientLinkBusiness().FetchByLinkName(linkname);

            return clientLink;
        }

        [HttpGet("fetchbyclientid/{clientid?}")]
        public IEnumerable<CrudeClientLinkModel> CrudeClientLinkFetchByClientId(System.Guid clientid) {

            List<CrudeClientLinkModel> clientLink = 
                new CrudeClientLinkBusiness().FetchByClientId(clientid);

            return clientLink;
        }

        [HttpGet("fetchbyclientlinktypercd/{clientlinktypercd?}")]
        public IEnumerable<CrudeClientLinkModel> CrudeClientLinkFetchByClientLinkTypeRcd(System.String clientlinktypercd) {

            List<CrudeClientLinkModel> clientLink = 
                new CrudeClientLinkBusiness().FetchByClientLinkTypeRcd(clientlinktypercd);

            return clientLink;
        }

        [HttpPost("crudeclientlinkcreate")]
        public CrudeClientLinkModel CrudeClientLinkCreate([Bind()] CrudeClientLinkModel clientLink) {

            new CrudeClientLinkBusiness().Insert(clientLink);

            return clientLink;
        }

        [HttpGet("createtest")]
        public string CrudeClientLinkCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientLinkTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LinkName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Link" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/16/2020 8:35:20 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientLink/CrudeClientLinkCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientLink/CrudeClientLinkCreate/", content).Result;

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

        [HttpPut("crudeclientlinkupdate")]
        public CrudeClientLinkModel CrudeClientLinkUpdate([Bind()] CrudeClientLinkModel clientLink) {

            new CrudeClientLinkBusiness().Update(clientLink);

            return clientLink;
        }

        [HttpGet("updatetest")]
        public string CrudeClientLinkUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientLinkTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LinkName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Link" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/16/2020 8:35:20 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientLink/CrudeClientLinkUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientLink/CrudeClientLinkUpdate/", content).Result;

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

        [HttpDelete("clientlinkdelete/{clientlinkid?}")]
        public void CrudeClientLinkDelete(System.Guid clientLinkId) {

            new CrudeClientLinkBusiness().Delete(clientLinkId);
        }

        [HttpGet("deletetest")]
        public string CrudeClientLinkDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientLink/CrudeClientLinkDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
