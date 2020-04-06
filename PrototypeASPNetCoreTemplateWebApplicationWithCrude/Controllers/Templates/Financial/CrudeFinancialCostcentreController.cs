/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:41:21 PM
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
    [Route("api/1/crudefinancialcostcentre")]
    public class CrudeFinancialCostcentreController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialCostcentreHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialCostcentre.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialCostcentreModel> CrudeFinancialCostcentreFetchAll() {

            List<CrudeFinancialCostcentreModel> financialCostcentres = 
                new CrudeFinancialCostcentreBusiness().FetchAll();

            return financialCostcentres;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialCostcentreFetchAllCount() {

            return new CrudeFinancialCostcentreBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialCostcentreModel> CrudeFinancialCostcentreFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialCostcentreModel> financialCostcentres = 
                new CrudeFinancialCostcentreBusiness().FetchAllWithLimit(limit);

            return financialCostcentres;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialCostcentreModel> CrudeFinancialCostcentreFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialCostcentreModel> financialCostcentres = 
                new CrudeFinancialCostcentreBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialCostcentres;
        }

        [HttpGet("fetchbyfinancialcostcentreid/{financialcostcentreid?}")]
        public CrudeFinancialCostcentreModel CrudeFinancialCostcentreFetchByFinancialCostcentreId(System.Guid financialcostcentreid) {

            CrudeFinancialCostcentreModel financialCostcentre = 
                new CrudeFinancialCostcentreBusiness().FetchByFinancialCostcentreId(financialcostcentreid);

            return financialCostcentre;
        }

        [HttpGet("fetchbyfinancialcostcentrename/{financialcostcentrename?}")]
        public CrudeFinancialCostcentreModel CrudeFinancialCostcentreFetchByFinancialCostcentreName(System.String financialcostcentrename) {

            CrudeFinancialCostcentreModel financialCostcentre = 
                new CrudeFinancialCostcentreBusiness().FetchByFinancialCostcentreName(financialcostcentrename);

            return financialCostcentre;
        }

        [HttpGet("fetchbyfinancialcompanyid/{financialcompanyid?}")]
        public IEnumerable<CrudeFinancialCostcentreModel> CrudeFinancialCostcentreFetchByFinancialCompanyId(System.Guid financialcompanyid) {

            List<CrudeFinancialCostcentreModel> financialCostcentre = 
                new CrudeFinancialCostcentreBusiness().FetchByFinancialCompanyId(financialcompanyid);

            return financialCostcentre;
        }

        [HttpPost("crudefinancialcostcentrecreate")]
        public CrudeFinancialCostcentreModel CrudeFinancialCostcentreCreate([Bind()] CrudeFinancialCostcentreModel financialCostcentre) {

            new CrudeFinancialCostcentreBusiness().Insert(financialCostcentre);

            return financialCostcentre;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialCostcentreCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCostcentreName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCostcentreCode" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/6/2020 4:41:21 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialCostcentre/CrudeFinancialCostcentreCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialCostcentre/CrudeFinancialCostcentreCreate/", content).Result;

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

        [HttpPut("crudefinancialcostcentreupdate")]
        public CrudeFinancialCostcentreModel CrudeFinancialCostcentreUpdate([Bind()] CrudeFinancialCostcentreModel financialCostcentre) {

            new CrudeFinancialCostcentreBusiness().Update(financialCostcentre);

            return financialCostcentre;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialCostcentreUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCostcentreName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCostcentreCode" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/6/2020 4:41:21 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialCostcentre/CrudeFinancialCostcentreUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialCostcentre/CrudeFinancialCostcentreUpdate/", content).Result;

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

        [HttpDelete("financialcostcentredelete/{financialcostcentreid?}")]
        public void CrudeFinancialCostcentreDelete(System.Guid financialCostcentreId) {

            new CrudeFinancialCostcentreBusiness().Delete(financialCostcentreId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialCostcentreDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialCostcentre/CrudeFinancialCostcentreDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
