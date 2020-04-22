/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:37:58 AM
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
    [Route("api/1/crudeproductattributeunitref")]
    public class CrudeProductAttributeUnitRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductAttributeUnitRefHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductAttributeUnitRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductAttributeUnitRefModel> CrudeProductAttributeUnitRefFetchAll() {

            List<CrudeProductAttributeUnitRefModel> productAttributeUnitRefs = 
                new CrudeProductAttributeUnitRefBusiness().FetchAll();

            return productAttributeUnitRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductAttributeUnitRefFetchAllCount() {

            return new CrudeProductAttributeUnitRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductAttributeUnitRefModel> CrudeProductAttributeUnitRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductAttributeUnitRefModel> productAttributeUnitRefs = 
                new CrudeProductAttributeUnitRefBusiness().FetchAllWithLimit(limit);

            return productAttributeUnitRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductAttributeUnitRefModel> CrudeProductAttributeUnitRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductAttributeUnitRefModel> productAttributeUnitRefs = 
                new CrudeProductAttributeUnitRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productAttributeUnitRefs;
        }

        [HttpGet("fetchbyproductattributeunitrcd/{productattributeunitrcd?}")]
        public CrudeProductAttributeUnitRefModel CrudeProductAttributeUnitRefFetchByProductAttributeUnitRcd(System.String productattributeunitrcd) {

            CrudeProductAttributeUnitRefModel productAttributeUnitRef = 
                new CrudeProductAttributeUnitRefBusiness().FetchByProductAttributeUnitRcd(productattributeunitrcd);

            return productAttributeUnitRef;
        }

        [HttpPost("crudeproductattributeunitrefcreate")]
        public CrudeProductAttributeUnitRefModel CrudeProductAttributeUnitRefCreate([Bind()] CrudeProductAttributeUnitRefModel productAttributeUnitRef) {

            new CrudeProductAttributeUnitRefBusiness().Insert(productAttributeUnitRef);

            return productAttributeUnitRef;
        }

        [HttpGet("createtest")]
        public string CrudeProductAttributeUnitRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductAttributeUnitRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductAttributeUnitName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 5:37:58 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefCreate/", content).Result;

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

        [HttpPut("crudeproductattributeunitrefupdate")]
        public CrudeProductAttributeUnitRefModel CrudeProductAttributeUnitRefUpdate([Bind()] CrudeProductAttributeUnitRefModel productAttributeUnitRef) {

            new CrudeProductAttributeUnitRefBusiness().Update(productAttributeUnitRef);

            return productAttributeUnitRef;
        }

        [HttpGet("updatetest")]
        public string CrudeProductAttributeUnitRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductAttributeUnitRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductAttributeUnitName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 5:37:58 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefUpdate/", content).Result;

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

        [HttpDelete("productattributeunitrefdelete/{productattributeunitrcd?}")]
        public void CrudeProductAttributeUnitRefDelete(System.String productAttributeUnitRcd) {

            new CrudeProductAttributeUnitRefBusiness().Delete(productAttributeUnitRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeProductAttributeUnitRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductAttributeUnitRef/CrudeProductAttributeUnitRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
