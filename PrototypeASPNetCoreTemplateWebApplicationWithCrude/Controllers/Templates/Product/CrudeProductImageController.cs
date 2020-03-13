/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:45:53 AM
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
    [Route("api/1/crudeproductimage")]
    public class CrudeProductImageController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeProductImageHelp(
            ) {

            return View(@"Views\Templates\Product\CrudeProductImage.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeProductImageModel> CrudeProductImageFetchAll() {

            List<CrudeProductImageModel> productImages = 
                new CrudeProductImageBusiness().FetchAll();

            return productImages;
        }

        [HttpGet("fetchallcount")]
        public int CrudeProductImageFetchAllCount() {

            return new CrudeProductImageBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeProductImageModel> CrudeProductImageFetchAllWithLimit(
                string limit
                ) {

            List<CrudeProductImageModel> productImages = 
                new CrudeProductImageBusiness().FetchAllWithLimit(limit);

            return productImages;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeProductImageModel> CrudeProductImageFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeProductImageModel> productImages = 
                new CrudeProductImageBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return productImages;
        }

        [HttpGet("fetchbyproductimageid/{productimageid?}")]
        public CrudeProductImageModel CrudeProductImageFetchByProductImageId(System.Guid productimageid) {

            CrudeProductImageModel productImage = 
                new CrudeProductImageBusiness().FetchByProductImageId(productimageid);

            return productImage;
        }

        [HttpGet("fetchbyimagefilename/{imagefilename?}")]
        public CrudeProductImageModel CrudeProductImageFetchByImageFileName(System.String imagefilename) {

            CrudeProductImageModel productImage = 
                new CrudeProductImageBusiness().FetchByImageFileName(imagefilename);

            return productImage;
        }

        [HttpGet("fetchbyproductid/{productid?}")]
        public IEnumerable<CrudeProductImageModel> CrudeProductImageFetchByProductId(System.Guid productid) {

            List<CrudeProductImageModel> productImage = 
                new CrudeProductImageBusiness().FetchByProductId(productid);

            return productImage;
        }

        [HttpGet("fetchbyproductimagetypercd/{productimagetypercd?}")]
        public IEnumerable<CrudeProductImageModel> CrudeProductImageFetchByProductImageTypeRcd(System.String productimagetypercd) {

            List<CrudeProductImageModel> productImage = 
                new CrudeProductImageBusiness().FetchByProductImageTypeRcd(productimagetypercd);

            return productImage;
        }

        [HttpPost("crudeproductimagecreate")]
        public CrudeProductImageModel CrudeProductImageCreate([Bind()] CrudeProductImageModel productImage) {

            new CrudeProductImageBusiness().Insert(productImage);

            return productImage;
        }

        [HttpGet("createtest")]
        public string CrudeProductImageCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductImageTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ImageFileName" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:53 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeProductImage/CrudeProductImageCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductImage/CrudeProductImageCreate/", content).Result;

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

        [HttpPut("crudeproductimageupdate")]
        public CrudeProductImageModel CrudeProductImageUpdate([Bind()] CrudeProductImageModel productImage) {

            new CrudeProductImageBusiness().Update(productImage);

            return productImage;
        }

        [HttpGet("updatetest")]
        public string CrudeProductImageUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "ProductImageTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ImageFileName" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "3/13/2020 10:45:53 AM" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeProductImage/CrudeProductImageUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeProductImage/CrudeProductImageUpdate/", content).Result;

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

        [HttpDelete("productimagedelete/{productimageid?}")]
        public void CrudeProductImageDelete(System.Guid productImageId) {

            new CrudeProductImageBusiness().Delete(productImageId);
        }

        [HttpGet("deletetest")]
        public string CrudeProductImageDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeProductImage/CrudeProductImageDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
