/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:23 PM
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
    [Route("api/1/crudeclientcontactmethodref")]
    public class CrudeClientContactMethodRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientContactMethodRefHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientContactMethodRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientContactMethodRefModel> CrudeClientContactMethodRefFetchAll() {

            List<CrudeClientContactMethodRefModel> clientContactMethodRefs = 
                new CrudeClientContactMethodRefBusiness().FetchAll();

            return clientContactMethodRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientContactMethodRefFetchAllCount() {

            return new CrudeClientContactMethodRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientContactMethodRefModel> CrudeClientContactMethodRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientContactMethodRefModel> clientContactMethodRefs = 
                new CrudeClientContactMethodRefBusiness().FetchAllWithLimit(limit);

            return clientContactMethodRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientContactMethodRefModel> CrudeClientContactMethodRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientContactMethodRefModel> clientContactMethodRefs = 
                new CrudeClientContactMethodRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientContactMethodRefs;
        }

        [HttpGet("fetchbyclientcontactmethodrcd/{clientcontactmethodrcd?}")]
        public CrudeClientContactMethodRefModel CrudeClientContactMethodRefFetchByClientContactMethodRcd(System.String clientcontactmethodrcd) {

            CrudeClientContactMethodRefModel clientContactMethodRef = 
                new CrudeClientContactMethodRefBusiness().FetchByClientContactMethodRcd(clientcontactmethodrcd);

            return clientContactMethodRef;
        }

        [HttpPost("crudeclientcontactmethodrefcreate")]
        public CrudeClientContactMethodRefModel CrudeClientContactMethodRefCreate([Bind()] CrudeClientContactMethodRefModel clientContactMethodRef) {

            new CrudeClientContactMethodRefBusiness().Insert(clientContactMethodRef);

            return clientContactMethodRef;
        }

        [HttpGet("createtest")]
        public string CrudeClientContactMethodRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientContactMethodRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientContactMethodName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientContactMethodDescription" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 3:02:23 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientContactMethodRef/CrudeClientContactMethodRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientContactMethodRef/CrudeClientContactMethodRefCreate/", content).Result;

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

        [HttpPut("crudeclientcontactmethodrefupdate")]
        public CrudeClientContactMethodRefModel CrudeClientContactMethodRefUpdate([Bind()] CrudeClientContactMethodRefModel clientContactMethodRef) {

            new CrudeClientContactMethodRefBusiness().Update(clientContactMethodRef);

            return clientContactMethodRef;
        }

        [HttpGet("updatetest")]
        public string CrudeClientContactMethodRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientContactMethodRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientContactMethodName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ClientContactMethodDescription" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "SortOrder" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 3:02:23 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientContactMethodRef/CrudeClientContactMethodRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeClientContactMethodRef/CrudeClientContactMethodRefUpdate/", content).Result;

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

        [HttpDelete("clientcontactmethodrefdelete/{clientcontactmethodrcd?}")]
        public void CrudeClientContactMethodRefDelete(System.String clientContactMethodRcd) {

            new CrudeClientContactMethodRefBusiness().Delete(clientContactMethodRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeClientContactMethodRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientContactMethodRef/CrudeClientContactMethodRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
