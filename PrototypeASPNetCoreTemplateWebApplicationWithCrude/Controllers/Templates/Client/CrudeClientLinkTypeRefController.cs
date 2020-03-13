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
    [Route("api/1/crudeclientlinktyperef")]
    public class CrudeClientLinkTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientLinkTypeRefHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientLinkTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientLinkTypeRefModel> CrudeClientLinkTypeRefFetchAll() {

            List<CrudeClientLinkTypeRefModel> clientLinkTypeRefs = 
                new CrudeClientLinkTypeRefBusiness().FetchAll();

            return clientLinkTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientLinkTypeRefFetchAllCount() {

            return new CrudeClientLinkTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientLinkTypeRefModel> CrudeClientLinkTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientLinkTypeRefModel> clientLinkTypeRefs = 
                new CrudeClientLinkTypeRefBusiness().FetchAllWithLimit(limit);

            return clientLinkTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientLinkTypeRefModel> CrudeClientLinkTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientLinkTypeRefModel> clientLinkTypeRefs = 
                new CrudeClientLinkTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientLinkTypeRefs;
        }

        [HttpGet("fetchbyclientlinktypercd/{clientlinktypercd?}")]
        public CrudeClientLinkTypeRefModel CrudeClientLinkTypeRefFetchByClientLinkTypeRcd(System.String clientlinktypercd) {

            CrudeClientLinkTypeRefModel clientLinkTypeRef = 
                new CrudeClientLinkTypeRefBusiness().FetchByClientLinkTypeRcd(clientlinktypercd);

            return clientLinkTypeRef;
        }

        [HttpPost("crudeclientlinktyperefcreate")]
        public CrudeClientLinkTypeRefModel CrudeClientLinkTypeRefCreate([Bind()] CrudeClientLinkTypeRefModel clientLinkTypeRef) {

            new CrudeClientLinkTypeRefBusiness().Insert(clientLinkTypeRef);

            return clientLinkTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeClientLinkTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientLinkTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientLinkTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientLinkTypeDescription" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:45 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefCreate/", content).Result;

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

        [HttpPut("crudeclientlinktyperefupdate")]
        public CrudeClientLinkTypeRefModel CrudeClientLinkTypeRefUpdate([Bind()] CrudeClientLinkTypeRefModel clientLinkTypeRef) {

            new CrudeClientLinkTypeRefBusiness().Update(clientLinkTypeRef);

            return clientLinkTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeClientLinkTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientLinkTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientLinkTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientLinkTypeDescription" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:45 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefUpdate/", content).Result;

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

        [HttpDelete("clientlinktyperefdelete/{clientlinktypercd?}")]
        public void CrudeClientLinkTypeRefDelete(System.String clientLinkTypeRcd) {

            new CrudeClientLinkTypeRefBusiness().Delete(clientLinkTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeClientLinkTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientLinkTypeRef/CrudeClientLinkTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
