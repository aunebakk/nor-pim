/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:49 PM
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
    [Route("api/1/crudeproductcategoryimagetyperef")]
    public class CrudeProductCategoryImageTypeRefController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductCategoryImageTypeRefHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductCategoryImageTypeRef.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductCategoryImageTypeRefModel> CrudeProductCategoryImageTypeRefFetchAll() {

            List<CrudeProductCategoryImageTypeRefModel> productCategoryImageTypeRefs = 
                new CrudeProductCategoryImageTypeRefBusiness().FetchAll();

            return productCategoryImageTypeRefs;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductCategoryImageTypeRefFetchAllCount() {

            return new CrudeProductCategoryImageTypeRefBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductCategoryImageTypeRefModel> CrudeProductCategoryImageTypeRefFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductCategoryImageTypeRefModel> productCategoryImageTypeRefs = 
                new CrudeProductCategoryImageTypeRefBusiness().FetchAllWithLimit(limit);

            return productCategoryImageTypeRefs;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductCategoryImageTypeRefModel> CrudeProductCategoryImageTypeRefFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductCategoryImageTypeRefModel> productCategoryImageTypeRefs = 
                new CrudeProductCategoryImageTypeRefBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productCategoryImageTypeRefs;
        }

        [HttpGet("fetchbyproductcategoryimagetypercd/{productcategoryimagetypercd?}")]
        public CrudeProductCategoryImageTypeRefModel CrudeProductCategoryImageTypeRefFetchByProductCategoryImageTypeRcd(System.String productcategoryimagetypercd) {

            CrudeProductCategoryImageTypeRefModel productCategoryImageTypeRef = 
                new CrudeProductCategoryImageTypeRefBusiness().FetchByProductCategoryImageTypeRcd(productcategoryimagetypercd);

            return productCategoryImageTypeRef;
        }

        [HttpPost("crudeproductcategoryimagetyperefcreate")]
        public CrudeProductCategoryImageTypeRefModel CrudeProductCategoryImageTypeRefCreate([Bind()] CrudeProductCategoryImageTypeRefModel productCategoryImageTypeRef) {

            new CrudeProductCategoryImageTypeRefBusiness().Insert(productCategoryImageTypeRef);

            return productCategoryImageTypeRef;
        }

        [HttpGet("createtest")]
        public string CrudeProductCategoryImageTypeRefCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryImageTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryImageTypeName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/6/2020 12:33:49 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefCreate/", content).Result;

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

        [HttpPut("crudeproductcategoryimagetyperefupdate")]
        public CrudeProductCategoryImageTypeRefModel CrudeProductCategoryImageTypeRefUpdate([Bind()] CrudeProductCategoryImageTypeRefModel productCategoryImageTypeRef) {

            new CrudeProductCategoryImageTypeRefBusiness().Update(productCategoryImageTypeRef);

            return productCategoryImageTypeRef;
        }

        [HttpGet("updatetest")]
        public string CrudeProductCategoryImageTypeRefUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryImageTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryImageTypeName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/6/2020 12:33:49 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefUpdate/", content).Result;

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

        [HttpDelete("productcategoryimagetyperefdelete/{productcategoryimagetypercd?}")]
        public void CrudeProductCategoryImageTypeRefDelete(System.String productCategoryImageTypeRcd) {

            new CrudeProductCategoryImageTypeRefBusiness().Delete(productCategoryImageTypeRcd);
        }

        [HttpGet("deletetest")]
        public string CrudeProductCategoryImageTypeRefDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductCategoryImageTypeRef/CrudeProductCategoryImageTypeRefDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
