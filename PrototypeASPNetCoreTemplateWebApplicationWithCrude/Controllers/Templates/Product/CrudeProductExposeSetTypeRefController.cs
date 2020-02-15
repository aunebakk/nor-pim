/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:27 AM
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
    [Route("api/1/crudeproductexposesettyperef")]
    public class CrudeProductExposeSetTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductExposeSetTypeRefHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductExposeSetTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductExposeSetTypeRefModel> CrudeProductExposeSetTypeRefFetchAll() {

            List<CrudeProductExposeSetTypeRefModel> productExposeSetTypeRefs = 
                new CrudeProductExposeSetTypeRefBusiness().FetchAll();

            return productExposeSetTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductExposeSetTypeRefFetchAllCount() {

            return new CrudeProductExposeSetTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductExposeSetTypeRefModel> CrudeProductExposeSetTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductExposeSetTypeRefModel> productExposeSetTypeRefs = 
                new CrudeProductExposeSetTypeRefBusiness().FetchAllWithLimit(limit);

            return productExposeSetTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductExposeSetTypeRefModel> CrudeProductExposeSetTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductExposeSetTypeRefModel> productExposeSetTypeRefs = 
                new CrudeProductExposeSetTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productExposeSetTypeRefs;
        }

        [HttpGet("fetchbyproductexposesettypercd/{productexposesettypercd?}")]
        public CrudeProductExposeSetTypeRefModel CrudeProductExposeSetTypeRefFetchByProductExposeSetTypeRcd(System.String productexposesettypercd) {

            CrudeProductExposeSetTypeRefModel productExposeSetTypeRef = 
                new CrudeProductExposeSetTypeRefBusiness().FetchByProductExposeSetTypeRcd(productexposesettypercd);

            return productExposeSetTypeRef;
        }

        [HttpPost("crudeproductexposesettyperefcreate")]
        public CrudeProductExposeSetTypeRefModel CrudeProductExposeSetTypeRefCreate([Bind()] CrudeProductExposeSetTypeRefModel productExposeSetTypeRef) {

            new CrudeProductExposeSetTypeRefBusiness().Insert(productExposeSetTypeRef);

            return productExposeSetTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeProductExposeSetTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductExposeSetTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductExposeSetTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:27 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefCreate/", content).Result;

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

        [HttpPut("crudeproductexposesettyperefupdate")]
        public CrudeProductExposeSetTypeRefModel CrudeProductExposeSetTypeRefUpdate([Bind()] CrudeProductExposeSetTypeRefModel productExposeSetTypeRef) {

            new CrudeProductExposeSetTypeRefBusiness().Update(productExposeSetTypeRef);

            return productExposeSetTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeProductExposeSetTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductExposeSetTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductExposeSetTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "2/15/2020 3:45:27 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefUpdate/", content).Result;

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

        [HttpDelete("productexposesettyperefdelete/{productexposesettypercd?}")]
        public void CrudeProductExposeSetTypeRefDelete(System.String productExposeSetTypeRcd) {

            new CrudeProductExposeSetTypeRefBusiness().Delete(productExposeSetTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeProductExposeSetTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductExposeSetTypeRef/CrudeProductExposeSetTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
