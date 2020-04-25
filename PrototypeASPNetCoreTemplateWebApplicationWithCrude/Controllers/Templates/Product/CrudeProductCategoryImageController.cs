/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:22:59 AM
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
    [Route("api/1/crudeproductcategoryimage")]
    public class CrudeProductCategoryImageController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductCategoryImageHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductCategoryImage.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductCategoryImageModel> CrudeProductCategoryImageFetchAll() {

            List<CrudeProductCategoryImageModel> productCategoryImages = 
                new CrudeProductCategoryImageBusiness().FetchAll();

            return productCategoryImages;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductCategoryImageFetchAllCount() {

            return new CrudeProductCategoryImageBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductCategoryImageModel> CrudeProductCategoryImageFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductCategoryImageModel> productCategoryImages = 
                new CrudeProductCategoryImageBusiness().FetchAllWithLimit(limit);

            return productCategoryImages;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductCategoryImageModel> CrudeProductCategoryImageFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductCategoryImageModel> productCategoryImages = 
                new CrudeProductCategoryImageBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productCategoryImages;
        }

        [HttpGet("fetchbyproductcategoryimageid/{productcategoryimageid?}")]
        public CrudeProductCategoryImageModel CrudeProductCategoryImageFetchByProductCategoryImageId(System.Guid productcategoryimageid) {

            CrudeProductCategoryImageModel productCategoryImage = 
                new CrudeProductCategoryImageBusiness().FetchByProductCategoryImageId(productcategoryimageid);

            return productCategoryImage;
        }

        [HttpGet("fetchbyproductcategoryid/{productcategoryid?}")]
        public IEnumerable<CrudeProductCategoryImageModel> CrudeProductCategoryImageFetchByProductCategoryId(System.Guid productcategoryid) {

            List<CrudeProductCategoryImageModel> productCategoryImage = 
                new CrudeProductCategoryImageBusiness().FetchByProductCategoryId(productcategoryid);

            return productCategoryImage;
        }

        [HttpGet("fetchbyproductcategoryimagetypercd/{productcategoryimagetypercd?}")]
        public IEnumerable<CrudeProductCategoryImageModel> CrudeProductCategoryImageFetchByProductCategoryImageTypeRcd(System.String productcategoryimagetypercd) {

            List<CrudeProductCategoryImageModel> productCategoryImage = 
                new CrudeProductCategoryImageBusiness().FetchByProductCategoryImageTypeRcd(productcategoryimagetypercd);

            return productCategoryImage;
        }

        [HttpPost("crudeproductcategoryimagecreate")]
        public CrudeProductCategoryImageModel CrudeProductCategoryImageCreate([Bind()] CrudeProductCategoryImageModel productCategoryImage) {

            new CrudeProductCategoryImageBusiness().Insert(productCategoryImage);

            return productCategoryImage;
        }

        [HttpGet("createtest")]
        public string CrudeProductCategoryImageCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryImageTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 8:22:59 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductCategoryImage/CrudeProductCategoryImageCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductCategoryImage/CrudeProductCategoryImageCreate/", content).Result;

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

        [HttpPut("crudeproductcategoryimageupdate")]
        public CrudeProductCategoryImageModel CrudeProductCategoryImageUpdate([Bind()] CrudeProductCategoryImageModel productCategoryImage) {

            new CrudeProductCategoryImageBusiness().Update(productCategoryImage);

            return productCategoryImage;
        }

        [HttpGet("updatetest")]
        public string CrudeProductCategoryImageUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductCategoryImageTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/25/2020 8:22:59 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductCategoryImage/CrudeProductCategoryImageUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductCategoryImage/CrudeProductCategoryImageUpdate/", content).Result;

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

        [HttpDelete("productcategoryimagedelete/{productcategoryimageid?}")]
        public void CrudeProductCategoryImageDelete(System.Guid productCategoryImageId) {

            new CrudeProductCategoryImageBusiness().Delete(productCategoryImageId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductCategoryImageDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductCategoryImage/CrudeProductCategoryImageDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
