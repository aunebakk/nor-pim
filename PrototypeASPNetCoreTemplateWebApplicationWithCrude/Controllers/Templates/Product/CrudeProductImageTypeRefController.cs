/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:48:00 AM
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
    [Route("api/1/crudeproductimagetyperef")]
    public class CrudeProductImageTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductImageTypeRefHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductImageTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductImageTypeRefModel> CrudeProductImageTypeRefFetchAll() {

            List<CrudeProductImageTypeRefModel> productImageTypeRefs = 
                new CrudeProductImageTypeRefBusiness().FetchAll();

            return productImageTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductImageTypeRefFetchAllCount() {

            return new CrudeProductImageTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductImageTypeRefModel> CrudeProductImageTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductImageTypeRefModel> productImageTypeRefs = 
                new CrudeProductImageTypeRefBusiness().FetchAllWithLimit(limit);

            return productImageTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductImageTypeRefModel> CrudeProductImageTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductImageTypeRefModel> productImageTypeRefs = 
                new CrudeProductImageTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productImageTypeRefs;
        }

        [HttpGet("fetchbyproductimagetypercd/{productimagetypercd?}")]
        public CrudeProductImageTypeRefModel CrudeProductImageTypeRefFetchByProductImageTypeRcd(System.String productimagetypercd) {

            CrudeProductImageTypeRefModel productImageTypeRef = 
                new CrudeProductImageTypeRefBusiness().FetchByProductImageTypeRcd(productimagetypercd);

            return productImageTypeRef;
        }

        [HttpPost("crudeproductimagetyperefcreate")]
        public CrudeProductImageTypeRefModel CrudeProductImageTypeRefCreate([Bind()] CrudeProductImageTypeRefModel productImageTypeRef) {

            new CrudeProductImageTypeRefBusiness().Insert(productImageTypeRef);

            return productImageTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeProductImageTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductImageTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductImageTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 10:48:00 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductImageTypeRef/CrudeProductImageTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductImageTypeRef/CrudeProductImageTypeRefCreate/", content).Result;

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

        [HttpPut("crudeproductimagetyperefupdate")]
        public CrudeProductImageTypeRefModel CrudeProductImageTypeRefUpdate([Bind()] CrudeProductImageTypeRefModel productImageTypeRef) {

            new CrudeProductImageTypeRefBusiness().Update(productImageTypeRef);

            return productImageTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeProductImageTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductImageTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductImageTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 10:48:00 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductImageTypeRef/CrudeProductImageTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductImageTypeRef/CrudeProductImageTypeRefUpdate/", content).Result;

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

        [HttpDelete("productimagetyperefdelete/{productimagetypercd?}")]
        public void CrudeProductImageTypeRefDelete(System.String productImageTypeRcd) {

            new CrudeProductImageTypeRefBusiness().Delete(productImageTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeProductImageTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductImageTypeRef/CrudeProductImageTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
