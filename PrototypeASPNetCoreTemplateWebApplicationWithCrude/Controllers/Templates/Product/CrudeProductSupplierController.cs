/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:40:54 PM
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
    [Route("api/1/crudeproductsupplier")]
    public class CrudeProductSupplierController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductSupplierHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductSupplier.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductSupplierModel> CrudeProductSupplierFetchAll() {

            List<CrudeProductSupplierModel> productSuppliers = 
                new CrudeProductSupplierBusiness().FetchAll();

            return productSuppliers;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductSupplierFetchAllCount() {

            return new CrudeProductSupplierBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductSupplierModel> CrudeProductSupplierFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductSupplierModel> productSuppliers = 
                new CrudeProductSupplierBusiness().FetchAllWithLimit(limit);

            return productSuppliers;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductSupplierModel> CrudeProductSupplierFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductSupplierModel> productSuppliers = 
                new CrudeProductSupplierBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productSuppliers;
        }

        [HttpGet("fetchbyproductsupplierid/{productsupplierid?}")]
        public CrudeProductSupplierModel CrudeProductSupplierFetchByProductSupplierId(System.Guid productsupplierid) {

            CrudeProductSupplierModel productSupplier = 
                new CrudeProductSupplierBusiness().FetchByProductSupplierId(productsupplierid);

            return productSupplier;
        }

        [HttpGet("fetchbysuppliername/{suppliername?}")]
        public CrudeProductSupplierModel CrudeProductSupplierFetchBySupplierName(System.String suppliername) {

            CrudeProductSupplierModel productSupplier = 
                new CrudeProductSupplierBusiness().FetchBySupplierName(suppliername);

            return productSupplier;
        }

        [HttpGet("fetchbyproductid/{productid?}")]
        public IEnumerable<CrudeProductSupplierModel> CrudeProductSupplierFetchByProductId(System.Guid productid) {

            List<CrudeProductSupplierModel> productSupplier = 
                new CrudeProductSupplierBusiness().FetchByProductId(productid);

            return productSupplier;
        }

        [HttpPost("crudeproductsuppliercreate")]
        public CrudeProductSupplierModel CrudeProductSupplierCreate([Bind()] CrudeProductSupplierModel productSupplier) {

            new CrudeProductSupplierBusiness().Insert(productSupplier);

            return productSupplier;
        }

        [HttpGet("createtest")]
        public string CrudeProductSupplierCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "SupplierName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:40:54 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductSupplier/CrudeProductSupplierCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductSupplier/CrudeProductSupplierCreate/", content).Result;

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

        [HttpPut("crudeproductsupplierupdate")]
        public CrudeProductSupplierModel CrudeProductSupplierUpdate([Bind()] CrudeProductSupplierModel productSupplier) {

            new CrudeProductSupplierBusiness().Update(productSupplier);

            return productSupplier;
        }

        [HttpGet("updatetest")]
        public string CrudeProductSupplierUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "SupplierName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/11/2020 1:40:54 PM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductSupplier/CrudeProductSupplierUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductSupplier/CrudeProductSupplierUpdate/", content).Result;

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

        [HttpDelete("productsupplierdelete/{productsupplierid?}")]
        public void CrudeProductSupplierDelete(System.Guid productSupplierId) {

            new CrudeProductSupplierBusiness().Delete(productSupplierId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductSupplierDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductSupplier/CrudeProductSupplierDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
