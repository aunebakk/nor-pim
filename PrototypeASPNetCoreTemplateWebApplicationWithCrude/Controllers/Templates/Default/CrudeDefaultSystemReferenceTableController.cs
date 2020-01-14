/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:47:48 AM
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
    [Route("api/1/crudedefaultsystemreferencetable")]
    public class CrudeDefaultSystemReferenceTableController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeDefaultSystemReferenceTableHelp(
            ) {

            return View(@"Views\Templates\Default\CrudeDefaultSystemReferenceTable.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeDefaultSystemReferenceTableModel> CrudeDefaultSystemReferenceTableFetchAll() {

            List<CrudeDefaultSystemReferenceTableModel> defaultSystemReferenceTables = 
                new CrudeDefaultSystemReferenceTableBusiness().FetchAll();

            return defaultSystemReferenceTables;
        }

        [HttpGet("fetchallcount")]
        public int CrudeDefaultSystemReferenceTableFetchAllCount() {

            return new CrudeDefaultSystemReferenceTableBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeDefaultSystemReferenceTableModel> CrudeDefaultSystemReferenceTableFetchAllWithLimit(
                string limit
                ) {

            List<CrudeDefaultSystemReferenceTableModel> defaultSystemReferenceTables = 
                new CrudeDefaultSystemReferenceTableBusiness().FetchAllWithLimit(limit);

            return defaultSystemReferenceTables;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeDefaultSystemReferenceTableModel> CrudeDefaultSystemReferenceTableFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeDefaultSystemReferenceTableModel> defaultSystemReferenceTables = 
                new CrudeDefaultSystemReferenceTableBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return defaultSystemReferenceTables;
        }

        [HttpGet("fetchbydefaultsystemreferencetableid/{defaultsystemreferencetableid?}")]
        public CrudeDefaultSystemReferenceTableModel CrudeDefaultSystemReferenceTableFetchByDefaultSystemReferenceTableId(System.Guid defaultsystemreferencetableid) {

            CrudeDefaultSystemReferenceTableModel defaultSystemReferenceTable = 
                new CrudeDefaultSystemReferenceTableBusiness().FetchByDefaultSystemReferenceTableId(defaultsystemreferencetableid);

            return defaultSystemReferenceTable;
        }

        [HttpGet("fetchbydefaultsystemreferencetablename/{defaultsystemreferencetablename?}")]
        public CrudeDefaultSystemReferenceTableModel CrudeDefaultSystemReferenceTableFetchByDefaultSystemReferenceTableName(System.String defaultsystemreferencetablename) {

            CrudeDefaultSystemReferenceTableModel defaultSystemReferenceTable = 
                new CrudeDefaultSystemReferenceTableBusiness().FetchByDefaultSystemReferenceTableName(defaultsystemreferencetablename);

            return defaultSystemReferenceTable;
        }

        [HttpGet("fetchbydefaultuserid/{defaultuserid?}")]
        public IEnumerable<CrudeDefaultSystemReferenceTableModel> CrudeDefaultSystemReferenceTableFetchByDefaultUserId(System.Guid defaultuserid) {

            List<CrudeDefaultSystemReferenceTableModel> defaultSystemReferenceTable = 
                new CrudeDefaultSystemReferenceTableBusiness().FetchByDefaultUserId(defaultuserid);

            return defaultSystemReferenceTable;
        }

        [HttpPost("crudedefaultsystemreferencetablecreate")]
        public CrudeDefaultSystemReferenceTableModel CrudeDefaultSystemReferenceTableCreate([Bind()] CrudeDefaultSystemReferenceTableModel defaultSystemReferenceTable) {

            new CrudeDefaultSystemReferenceTableBusiness().Insert(defaultSystemReferenceTable);

            return defaultSystemReferenceTable;
        }

        [HttpGet("createtest")]
        public string CrudeDefaultSystemReferenceTableCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemReferenceTableName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemReferenceDisplayName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 10:47:48 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableCreate/", content).Result;

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

        [HttpPut("crudedefaultsystemreferencetableupdate")]
        public CrudeDefaultSystemReferenceTableModel CrudeDefaultSystemReferenceTableUpdate([Bind()] CrudeDefaultSystemReferenceTableModel defaultSystemReferenceTable) {

            new CrudeDefaultSystemReferenceTableBusiness().Update(defaultSystemReferenceTable);

            return defaultSystemReferenceTable;
        }

        [HttpGet("updatetest")]
        public string CrudeDefaultSystemReferenceTableUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemReferenceTableName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DefaultSystemReferenceDisplayName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 10:47:48 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableUpdate/", content).Result;

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

        [HttpDelete("defaultsystemreferencetabledelete/{defaultsystemreferencetableid?}")]
        public void CrudeDefaultSystemReferenceTableDelete(System.Guid defaultSystemReferenceTableId) {

            new CrudeDefaultSystemReferenceTableBusiness().Delete(defaultSystemReferenceTableId);
        }

        [HttpGet("deletetest")]
        public string CrudeDefaultSystemReferenceTableDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeDefaultSystemReferenceTable/CrudeDefaultSystemReferenceTableDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
