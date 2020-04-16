/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:35:21 PM
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
    [Route("api/1/crudeproductattribute")]
    public class CrudeProductAttributeController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductAttributeHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductAttribute.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductAttributeModel> CrudeProductAttributeFetchAll() {

            List<CrudeProductAttributeModel> productAttributes = 
                new CrudeProductAttributeBusiness().FetchAll();

            return productAttributes;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductAttributeFetchAllCount() {

            return new CrudeProductAttributeBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductAttributeModel> CrudeProductAttributeFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductAttributeModel> productAttributes = 
                new CrudeProductAttributeBusiness().FetchAllWithLimit(limit);

            return productAttributes;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductAttributeModel> CrudeProductAttributeFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductAttributeModel> productAttributes = 
                new CrudeProductAttributeBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productAttributes;
        }

        [HttpGet("fetchbyproductattributeid/{productattributeid?}")]
        public CrudeProductAttributeModel CrudeProductAttributeFetchByProductAttributeId(System.Guid productattributeid) {

            CrudeProductAttributeModel productAttribute = 
                new CrudeProductAttributeBusiness().FetchByProductAttributeId(productattributeid);

            return productAttribute;
        }

        [HttpGet("fetchbyproductid/{productid?}")]
        public IEnumerable<CrudeProductAttributeModel> CrudeProductAttributeFetchByProductId(System.Guid productid) {

            List<CrudeProductAttributeModel> productAttribute = 
                new CrudeProductAttributeBusiness().FetchByProductId(productid);

            return productAttribute;
        }

        [HttpGet("fetchbyproductattributercd/{productattributercd?}")]
        public IEnumerable<CrudeProductAttributeModel> CrudeProductAttributeFetchByProductAttributeRcd(System.String productattributercd) {

            List<CrudeProductAttributeModel> productAttribute = 
                new CrudeProductAttributeBusiness().FetchByProductAttributeRcd(productattributercd);

            return productAttribute;
        }

        [HttpGet("fetchbyproductattributeunitrcd/{productattributeunitrcd?}")]
        public IEnumerable<CrudeProductAttributeModel> CrudeProductAttributeFetchByProductAttributeUnitRcd(System.String productattributeunitrcd) {

            List<CrudeProductAttributeModel> productAttribute = 
                new CrudeProductAttributeBusiness().FetchByProductAttributeUnitRcd(productattributeunitrcd);

            return productAttribute;
        }

        [HttpPost("crudeproductattributecreate")]
        public CrudeProductAttributeModel CrudeProductAttributeCreate([Bind()] CrudeProductAttributeModel productAttribute) {

            new CrudeProductAttributeBusiness().Insert(productAttribute);

            return productAttribute;
        }

        [HttpGet("createtest")]
        public string CrudeProductAttributeCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductAttributeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductAttributeUnitRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Value" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/16/2020 8:35:21 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductAttribute/CrudeProductAttributeCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductAttribute/CrudeProductAttributeCreate/", content).Result;

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

        [HttpPut("crudeproductattributeupdate")]
        public CrudeProductAttributeModel CrudeProductAttributeUpdate([Bind()] CrudeProductAttributeModel productAttribute) {

            new CrudeProductAttributeBusiness().Update(productAttribute);

            return productAttribute;
        }

        [HttpGet("updatetest")]
        public string CrudeProductAttributeUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductAttributeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductAttributeUnitRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "Value" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/16/2020 8:35:21 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductAttribute/CrudeProductAttributeUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductAttribute/CrudeProductAttributeUpdate/", content).Result;

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

        [HttpDelete("productattributedelete/{productattributeid?}")]
        public void CrudeProductAttributeDelete(System.Guid productAttributeId) {

            new CrudeProductAttributeBusiness().Delete(productAttributeId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductAttributeDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductAttribute/CrudeProductAttributeDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
