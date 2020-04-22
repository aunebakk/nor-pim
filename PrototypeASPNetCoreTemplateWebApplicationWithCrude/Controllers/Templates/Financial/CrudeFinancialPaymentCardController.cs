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
    [Route("api/1/crudefinancialpaymentcard")]
    public class CrudeFinancialPaymentCardController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialPaymentCardHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialPaymentCard.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialPaymentCardModel> CrudeFinancialPaymentCardFetchAll() {

            List<CrudeFinancialPaymentCardModel> financialPaymentCards = 
                new CrudeFinancialPaymentCardBusiness().FetchAll();

            return financialPaymentCards;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialPaymentCardFetchAllCount() {

            return new CrudeFinancialPaymentCardBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialPaymentCardModel> CrudeFinancialPaymentCardFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialPaymentCardModel> financialPaymentCards = 
                new CrudeFinancialPaymentCardBusiness().FetchAllWithLimit(limit);

            return financialPaymentCards;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialPaymentCardModel> CrudeFinancialPaymentCardFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialPaymentCardModel> financialPaymentCards = 
                new CrudeFinancialPaymentCardBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialPaymentCards;
        }

        [HttpGet("fetchbyfinancialpaymentcardid/{financialpaymentcardid?}")]
        public CrudeFinancialPaymentCardModel CrudeFinancialPaymentCardFetchByFinancialPaymentCardId(System.Guid financialpaymentcardid) {

            CrudeFinancialPaymentCardModel financialPaymentCard = 
                new CrudeFinancialPaymentCardBusiness().FetchByFinancialPaymentCardId(financialpaymentcardid);

            return financialPaymentCard;
        }

        [HttpGet("fetchbyfinancialcardtypercd/{financialcardtypercd?}")]
        public IEnumerable<CrudeFinancialPaymentCardModel> CrudeFinancialPaymentCardFetchByFinancialCardTypeRcd(System.String financialcardtypercd) {

            List<CrudeFinancialPaymentCardModel> financialPaymentCard = 
                new CrudeFinancialPaymentCardBusiness().FetchByFinancialCardTypeRcd(financialcardtypercd);

            return financialPaymentCard;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialPaymentCardModel> CrudeFinancialPaymentCardFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialPaymentCardModel> financialPaymentCard = 
                new CrudeFinancialPaymentCardBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialPaymentCard;
        }

        [HttpPost("crudefinancialpaymentcardcreate")]
        public CrudeFinancialPaymentCardModel CrudeFinancialPaymentCardCreate([Bind()] CrudeFinancialPaymentCardModel financialPaymentCard) {

            new CrudeFinancialPaymentCardBusiness().Insert(financialPaymentCard);

            return financialPaymentCard;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialPaymentCardCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 5:37:58 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "CardNumber" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "NameOnCard" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ExpiryYear" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ExpiryMonth" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCardTypeRcd" , "create" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "CardVerificationValue" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "IssuedMonth" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "IssuedYear" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AddressVerificationCode" , "create" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentCard/CrudeFinancialPaymentCardCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPaymentCard/CrudeFinancialPaymentCardCreate/", content).Result;

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

        [HttpPut("crudefinancialpaymentcardupdate")]
        public CrudeFinancialPaymentCardModel CrudeFinancialPaymentCardUpdate([Bind()] CrudeFinancialPaymentCardModel financialPaymentCard) {

            new CrudeFinancialPaymentCardBusiness().Update(financialPaymentCard);

            return financialPaymentCard;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialPaymentCardUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "4/22/2020 5:37:58 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "CardNumber" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "NameOnCard" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ExpiryYear" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "ExpiryMonth" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialCardTypeRcd" , "update" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "CardVerificationValue" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "IssuedMonth" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "IssuedYear" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "AddressVerificationCode" , "update" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentCard/CrudeFinancialPaymentCardUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialPaymentCard/CrudeFinancialPaymentCardUpdate/", content).Result;

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

        [HttpDelete("financialpaymentcarddelete/{financialpaymentcardid?}")]
        public void CrudeFinancialPaymentCardDelete(System.Guid financialPaymentCardId) {

            new CrudeFinancialPaymentCardBusiness().Delete(financialPaymentCardId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialPaymentCardDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialPaymentCard/CrudeFinancialPaymentCardDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
