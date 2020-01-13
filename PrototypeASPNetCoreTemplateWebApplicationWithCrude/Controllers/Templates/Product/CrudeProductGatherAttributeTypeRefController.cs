/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:44:48 PM
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
    [Route("api/1/crudeproductgatherattributetyperef")]
    public class CrudeProductGatherAttributeTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductGatherAttributeTypeRefHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductGatherAttributeTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductGatherAttributeTypeRefModel> CrudeProductGatherAttributeTypeRefFetchAll() {

            List<CrudeProductGatherAttributeTypeRefModel> productGatherAttributeTypeRefs = 
                new CrudeProductGatherAttributeTypeRefBusiness().FetchAll();

            return productGatherAttributeTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductGatherAttributeTypeRefFetchAllCount() {

            return new CrudeProductGatherAttributeTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductGatherAttributeTypeRefModel> CrudeProductGatherAttributeTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductGatherAttributeTypeRefModel> productGatherAttributeTypeRefs = 
                new CrudeProductGatherAttributeTypeRefBusiness().FetchAllWithLimit(limit);

            return productGatherAttributeTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductGatherAttributeTypeRefModel> CrudeProductGatherAttributeTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductGatherAttributeTypeRefModel> productGatherAttributeTypeRefs = 
                new CrudeProductGatherAttributeTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productGatherAttributeTypeRefs;
        }

        [HttpGet("fetchbyproductgatherattributetypercd/{productgatherattributetypercd?}")]
        public CrudeProductGatherAttributeTypeRefModel CrudeProductGatherAttributeTypeRefFetchByProductGatherAttributeTypeRcd(System.String productgatherattributetypercd) {

            CrudeProductGatherAttributeTypeRefModel productGatherAttributeTypeRef = 
                new CrudeProductGatherAttributeTypeRefBusiness().FetchByProductGatherAttributeTypeRcd(productgatherattributetypercd);

            return productGatherAttributeTypeRef;
        }

        [HttpPost("crudeproductgatherattributetyperefcreate")]
        public CrudeProductGatherAttributeTypeRefModel CrudeProductGatherAttributeTypeRefCreate([Bind()] CrudeProductGatherAttributeTypeRefModel productGatherAttributeTypeRef) {

            new CrudeProductGatherAttributeTypeRefBusiness().Insert(productGatherAttributeTypeRef);

            return productGatherAttributeTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeProductGatherAttributeTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherAttributeTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherAttributeTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/13/2020 5:44:48 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://localhost:5000/api/1/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefCreate/", content).Result;

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

        [HttpPut("crudeproductgatherattributetyperefupdate")]
        public CrudeProductGatherAttributeTypeRefModel CrudeProductGatherAttributeTypeRefUpdate([Bind()] CrudeProductGatherAttributeTypeRefModel productGatherAttributeTypeRef) {

            new CrudeProductGatherAttributeTypeRefBusiness().Update(productGatherAttributeTypeRef);

            return productGatherAttributeTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeProductGatherAttributeTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherAttributeTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductGatherAttributeTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/13/2020 5:44:48 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://localhost:5000/api/1/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefUpdate/", content).Result;

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

        [HttpDelete("productgatherattributetyperefdelete/{productgatherattributetypercd?}")]
        public void CrudeProductGatherAttributeTypeRefDelete(System.String productGatherAttributeTypeRcd) {

            new CrudeProductGatherAttributeTypeRefBusiness().Delete(productGatherAttributeTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeProductGatherAttributeTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductGatherAttributeTypeRef/CrudeProductGatherAttributeTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
