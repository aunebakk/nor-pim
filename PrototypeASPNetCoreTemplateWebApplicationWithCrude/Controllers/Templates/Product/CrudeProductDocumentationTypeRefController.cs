/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:44:10 PM
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
    [Route("api/1/crudeproductdocumentationtyperef")]
    public class CrudeProductDocumentationTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductDocumentationTypeRefHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductDocumentationTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductDocumentationTypeRefModel> CrudeProductDocumentationTypeRefFetchAll() {

            List<CrudeProductDocumentationTypeRefModel> productDocumentationTypeRefs = 
                new CrudeProductDocumentationTypeRefBusiness().FetchAll();

            return productDocumentationTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductDocumentationTypeRefFetchAllCount() {

            return new CrudeProductDocumentationTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductDocumentationTypeRefModel> CrudeProductDocumentationTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductDocumentationTypeRefModel> productDocumentationTypeRefs = 
                new CrudeProductDocumentationTypeRefBusiness().FetchAllWithLimit(limit);

            return productDocumentationTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductDocumentationTypeRefModel> CrudeProductDocumentationTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductDocumentationTypeRefModel> productDocumentationTypeRefs = 
                new CrudeProductDocumentationTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productDocumentationTypeRefs;
        }

        [HttpGet("fetchbyproductdocumentationtypercd/{productdocumentationtypercd?}")]
        public CrudeProductDocumentationTypeRefModel CrudeProductDocumentationTypeRefFetchByProductDocumentationTypeRcd(System.String productdocumentationtypercd) {

            CrudeProductDocumentationTypeRefModel productDocumentationTypeRef = 
                new CrudeProductDocumentationTypeRefBusiness().FetchByProductDocumentationTypeRcd(productdocumentationtypercd);

            return productDocumentationTypeRef;
        }

        [HttpPost("crudeproductdocumentationtyperefcreate")]
        public CrudeProductDocumentationTypeRefModel CrudeProductDocumentationTypeRefCreate([Bind()] CrudeProductDocumentationTypeRefModel productDocumentationTypeRef) {

            new CrudeProductDocumentationTypeRefBusiness().Insert(productDocumentationTypeRef);

            return productDocumentationTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeProductDocumentationTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductDocumentationTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductDocumentationTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/12/2020 12:44:10 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefCreate/", content).Result;

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

        [HttpPut("crudeproductdocumentationtyperefupdate")]
        public CrudeProductDocumentationTypeRefModel CrudeProductDocumentationTypeRefUpdate([Bind()] CrudeProductDocumentationTypeRefModel productDocumentationTypeRef) {

            new CrudeProductDocumentationTypeRefBusiness().Update(productDocumentationTypeRef);

            return productDocumentationTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeProductDocumentationTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductDocumentationTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductDocumentationTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/12/2020 12:44:10 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefUpdate/", content).Result;

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

        [HttpDelete("productdocumentationtyperefdelete/{productdocumentationtypercd?}")]
        public void CrudeProductDocumentationTypeRefDelete(System.String productDocumentationTypeRcd) {

            new CrudeProductDocumentationTypeRefBusiness().Delete(productDocumentationTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeProductDocumentationTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductDocumentationTypeRef/CrudeProductDocumentationTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
