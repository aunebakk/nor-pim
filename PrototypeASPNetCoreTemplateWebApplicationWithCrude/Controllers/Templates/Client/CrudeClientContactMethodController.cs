/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:44:29 PM
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
    [Route("api/1/crudeclientcontactmethod")]
    public class CrudeClientContactMethodController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeClientContactMethodHelp(
            ) {

            return View(@"Views\Templates\Client\CrudeClientContactMethod.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeClientContactMethodModel> CrudeClientContactMethodFetchAll() {

            List<CrudeClientContactMethodModel> clientContactMethods = 
                new CrudeClientContactMethodBusiness().FetchAll();

            return clientContactMethods;
        }

        [HttpGet("fetchallcount")]
        public int CrudeClientContactMethodFetchAllCount() {

            return new CrudeClientContactMethodBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeClientContactMethodModel> CrudeClientContactMethodFetchAllWithLimit(
                string limit
                ) {

            List<CrudeClientContactMethodModel> clientContactMethods = 
                new CrudeClientContactMethodBusiness().FetchAllWithLimit(limit);

            return clientContactMethods;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeClientContactMethodModel> CrudeClientContactMethodFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeClientContactMethodModel> clientContactMethods = 
                new CrudeClientContactMethodBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return clientContactMethods;
        }

        [HttpGet("fetchbyclientcontactmethodid/{clientcontactmethodid?}")]
        public CrudeClientContactMethodModel CrudeClientContactMethodFetchByClientContactMethodId(System.Guid clientcontactmethodid) {

            CrudeClientContactMethodModel clientContactMethod = 
                new CrudeClientContactMethodBusiness().FetchByClientContactMethodId(clientcontactmethodid);

            return clientContactMethod;
        }

        [HttpGet("fetchbyclientid/{clientid?}")]
        public IEnumerable<CrudeClientContactMethodModel> CrudeClientContactMethodFetchByClientId(System.Guid clientid) {

            List<CrudeClientContactMethodModel> clientContactMethod = 
                new CrudeClientContactMethodBusiness().FetchByClientId(clientid);

            return clientContactMethod;
        }

        [HttpGet("fetchbyclientcontactmethodrcd/{clientcontactmethodrcd?}")]
        public IEnumerable<CrudeClientContactMethodModel> CrudeClientContactMethodFetchByClientContactMethodRcd(System.String clientcontactmethodrcd) {

            List<CrudeClientContactMethodModel> clientContactMethod = 
                new CrudeClientContactMethodBusiness().FetchByClientContactMethodRcd(clientcontactmethodrcd);

            return clientContactMethod;
        }

        [HttpPost("crudeclientcontactmethodcreate")]
        public CrudeClientContactMethodModel CrudeClientContactMethodCreate([Bind()] CrudeClientContactMethodModel clientContactMethod) {

            new CrudeClientContactMethodBusiness().Insert(clientContactMethod);

            return clientContactMethod;
        }

        [HttpGet("createtest")]
        public string CrudeClientContactMethodCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientContactMethodRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ContactMethodWay" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/13/2020 5:44:29 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeClientContactMethod/CrudeClientContactMethodCreate/", content).Result;
                // todo var response = client.PostAsync("http://localhost:5000/api/1/CrudeClientContactMethod/CrudeClientContactMethodCreate/", content).Result;

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

        [HttpPut("crudeclientcontactmethodupdate")]
        public CrudeClientContactMethodModel CrudeClientContactMethodUpdate([Bind()] CrudeClientContactMethodModel clientContactMethod) {

            new CrudeClientContactMethodBusiness().Update(clientContactMethod);

            return clientContactMethod;
        }

        [HttpGet("updatetest")]
        public string CrudeClientContactMethodUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ClientContactMethodRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ContactMethodWay" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Comment" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/13/2020 5:44:29 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeClientContactMethod/CrudeClientContactMethodUpdate/", content).Result;
                // todo var response = client.PutAsync("http://localhost:5000/api/1/CrudeClientContactMethod/CrudeClientContactMethodUpdate/", content).Result;

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

        [HttpDelete("clientcontactmethoddelete/{clientcontactmethodid?}")]
        public void CrudeClientContactMethodDelete(System.Guid clientContactMethodId) {

            new CrudeClientContactMethodBusiness().Delete(clientContactMethodId);
        }

        [HttpGet("deletetest")]
        public string CrudeClientContactMethodDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeClientContactMethod/CrudeClientContactMethodDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
