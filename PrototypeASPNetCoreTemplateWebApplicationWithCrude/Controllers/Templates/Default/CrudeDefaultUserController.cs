/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:25 PM
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
    [Route("api/1/crudedefaultuser")]
    public class CrudeDefaultUserController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultUserHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultUser.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultUserModel> CrudeDefaultUserFetchAll() {

            List<CrudeDefaultUserModel> defaultUsers = 
                new CrudeDefaultUserBusiness().FetchAll();

            return defaultUsers;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultUserFetchAllCount() {

            return new CrudeDefaultUserBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultUserModel> CrudeDefaultUserFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultUserModel> defaultUsers = 
                new CrudeDefaultUserBusiness().FetchAllWithLimit(limit);

            return defaultUsers;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultUserModel> CrudeDefaultUserFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultUserModel> defaultUsers = 
                new CrudeDefaultUserBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultUsers;
        }

        [HttpGet("fetchbydefaultuserid/{defaultuserid?}")]
        public CrudeDefaultUserModel CrudeDefaultUserFetchByDefaultUserId(System.Guid defaultuserid) {

            CrudeDefaultUserModel defaultUser = 
                new CrudeDefaultUserBusiness().FetchByDefaultUserId(defaultuserid);

            return defaultUser;
        }

        [HttpGet("fetchbydefaultusername/{defaultusername?}")]
        public CrudeDefaultUserModel CrudeDefaultUserFetchByDefaultUserName(System.String defaultusername) {

            CrudeDefaultUserModel defaultUser = 
                new CrudeDefaultUserBusiness().FetchByDefaultUserName(defaultusername);

            return defaultUser;
        }

        [HttpGet("fetchbydefaultstatercd/{defaultstatercd?}")]
        public IEnumerable<CrudeDefaultUserModel> CrudeDefaultUserFetchByDefaultStateRcd(System.String defaultstatercd) {

            List<CrudeDefaultUserModel> defaultUser = 
                new CrudeDefaultUserBusiness().FetchByDefaultStateRcd(defaultstatercd);

            return defaultUser;
        }

        [HttpGet("fetchbycreatedbydefaultuserid/{createdbydefaultuserid?}")]
        public IEnumerable<CrudeDefaultUserModel> CrudeDefaultUserFetchByCreatedByDefaultUserId(System.Guid createdbydefaultuserid) {

            List<CrudeDefaultUserModel> defaultUser = 
                new CrudeDefaultUserBusiness().FetchByCreatedByDefaultUserId(createdbydefaultuserid);

            return defaultUser;
        }

        [HttpPost("crudedefaultusercreate")]
        public CrudeDefaultUserModel CrudeDefaultUserCreate([Bind()] CrudeDefaultUserModel defaultUser) {

            new CrudeDefaultUserBusiness().Insert(defaultUser);

            return defaultUser;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultUserCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultUserCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultUserName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Email" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Password" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultStateRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 3:02:25 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LastActivityDateTime" , "1/14/2020 3:02:25 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultUser/CrudeDefaultUserCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultUser/CrudeDefaultUserCreate/", content).Result;

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

        [HttpPut("crudedefaultuserupdate")]
        public CrudeDefaultUserModel CrudeDefaultUserUpdate([Bind()] CrudeDefaultUserModel defaultUser) {

            new CrudeDefaultUserBusiness().Update(defaultUser);

            return defaultUser;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultUserUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultUserCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultUserName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Email" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Password" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultStateRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 3:02:25 PM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "LastActivityDateTime" , "1/14/2020 3:02:25 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultUser/CrudeDefaultUserUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultUser/CrudeDefaultUserUpdate/", content).Result;

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

        [HttpDelete("defaultuserdelete/{defaultuserid?}")]
        public void CrudeDefaultUserDelete(System.Guid defaultUserId) {

            new CrudeDefaultUserBusiness().Delete(defaultUserId);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultUserDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultUser/CrudeDefaultUserDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
