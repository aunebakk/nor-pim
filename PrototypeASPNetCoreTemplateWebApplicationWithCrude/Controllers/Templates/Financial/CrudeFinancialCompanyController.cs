/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:47:50 AM
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
    [Route("api/1/crudefinancialcompany")]
    public class CrudeFinancialCompanyController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialCompanyHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialCompany.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialCompanyModel> CrudeFinancialCompanyFetchAll() {

            List<CrudeFinancialCompanyModel> financialCompanys = 
                new CrudeFinancialCompanyBusiness().FetchAll();

            return financialCompanys;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialCompanyFetchAllCount() {

            return new CrudeFinancialCompanyBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialCompanyModel> CrudeFinancialCompanyFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialCompanyModel> financialCompanys = 
                new CrudeFinancialCompanyBusiness().FetchAllWithLimit(limit);

            return financialCompanys;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialCompanyModel> CrudeFinancialCompanyFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialCompanyModel> financialCompanys = 
                new CrudeFinancialCompanyBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialCompanys;
        }

        [HttpGet("fetchbyfinancialcompanyid/{financialcompanyid?}")]
        public CrudeFinancialCompanyModel CrudeFinancialCompanyFetchByFinancialCompanyId(System.Guid financialcompanyid) {

            CrudeFinancialCompanyModel financialCompany = 
                new CrudeFinancialCompanyBusiness().FetchByFinancialCompanyId(financialcompanyid);

            return financialCompany;
        }

        [HttpGet("fetchbyfinancialcompanyname/{financialcompanyname?}")]
        public CrudeFinancialCompanyModel CrudeFinancialCompanyFetchByFinancialCompanyName(System.String financialcompanyname) {

            CrudeFinancialCompanyModel financialCompany = 
                new CrudeFinancialCompanyBusiness().FetchByFinancialCompanyName(financialcompanyname);

            return financialCompany;
        }

        [HttpPost("crudefinancialcompanycreate")]
        public CrudeFinancialCompanyModel CrudeFinancialCompanyCreate([Bind()] CrudeFinancialCompanyModel financialCompany) {

            new CrudeFinancialCompanyBusiness().Insert(financialCompany);

            return financialCompany;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialCompanyCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCompanyName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 10:47:50 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialCompany/CrudeFinancialCompanyCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialCompany/CrudeFinancialCompanyCreate/", content).Result;

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

        [HttpPut("crudefinancialcompanyupdate")]
        public CrudeFinancialCompanyModel CrudeFinancialCompanyUpdate([Bind()] CrudeFinancialCompanyModel financialCompany) {

            new CrudeFinancialCompanyBusiness().Update(financialCompany);

            return financialCompany;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialCompanyUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCompanyName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 10:47:50 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialCompany/CrudeFinancialCompanyUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialCompany/CrudeFinancialCompanyUpdate/", content).Result;

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

        [HttpDelete("financialcompanydelete/{financialcompanyid?}")]
        public void CrudeFinancialCompanyDelete(System.Guid financialCompanyId) {

            new CrudeFinancialCompanyBusiness().Delete(financialCompanyId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialCompanyDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialCompany/CrudeFinancialCompanyDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
