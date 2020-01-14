/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:46:28 AM
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
    [Route("api/1/crudefinancialordertransaction")]
    public class CrudeFinancialOrderTransactionController : Controller {

        [HttpGet("help/")]
        public IActionResult CrudeFinancialOrderTransactionHelp(
            ) {

            return View(@"Views\Templates\Financial\CrudeFinancialOrderTransaction.cshtml");
        }

        [HttpGet("fetchall")]
        public IEnumerable<CrudeFinancialOrderTransactionModel> CrudeFinancialOrderTransactionFetchAll() {

            List<CrudeFinancialOrderTransactionModel> financialOrderTransactions = 
                new CrudeFinancialOrderTransactionBusiness().FetchAll();

            return financialOrderTransactions;
        }

        [HttpGet("fetchallcount")]
        public int CrudeFinancialOrderTransactionFetchAllCount() {

            return new CrudeFinancialOrderTransactionBusiness().FetchAllCount();
        }

        [HttpGet("fetchallwithlimit/{limit?}")]
        public IEnumerable<CrudeFinancialOrderTransactionModel> CrudeFinancialOrderTransactionFetchAllWithLimit(
                string limit
                ) {

            List<CrudeFinancialOrderTransactionModel> financialOrderTransactions = 
                new CrudeFinancialOrderTransactionBusiness().FetchAllWithLimit(limit);

            return financialOrderTransactions;
        }

        [HttpGet("fetchallwithlimitandoffset/{limit?}/{offset?}")]
        public IEnumerable<CrudeFinancialOrderTransactionModel> CrudeFinancialOrderTransactionFetchAllWithLimitAndOffset(
                string limit,
                string offset
                ) {

            List<CrudeFinancialOrderTransactionModel> financialOrderTransactions = 
                new CrudeFinancialOrderTransactionBusiness().FetchAllWithLimitAndOffset(limit, offset);

            return financialOrderTransactions;
        }

        [HttpGet("fetchbyfinancialbookingtransactionid/{financialbookingtransactionid?}")]
        public CrudeFinancialOrderTransactionModel CrudeFinancialOrderTransactionFetchByFinancialBookingTransactionId(System.Guid financialbookingtransactionid) {

            CrudeFinancialOrderTransactionModel financialOrderTransaction = 
                new CrudeFinancialOrderTransactionBusiness().FetchByFinancialBookingTransactionId(financialbookingtransactionid);

            return financialOrderTransaction;
        }

        [HttpGet("fetchbyfinancialfeeid/{financialfeeid?}")]
        public IEnumerable<CrudeFinancialOrderTransactionModel> CrudeFinancialOrderTransactionFetchByFinancialFeeId(System.Guid financialfeeid) {

            List<CrudeFinancialOrderTransactionModel> financialOrderTransaction = 
                new CrudeFinancialOrderTransactionBusiness().FetchByFinancialFeeId(financialfeeid);

            return financialOrderTransaction;
        }

        [HttpGet("fetchbyfinancialtaxid/{financialtaxid?}")]
        public IEnumerable<CrudeFinancialOrderTransactionModel> CrudeFinancialOrderTransactionFetchByFinancialTaxId(System.Guid financialtaxid) {

            List<CrudeFinancialOrderTransactionModel> financialOrderTransaction = 
                new CrudeFinancialOrderTransactionBusiness().FetchByFinancialTaxId(financialtaxid);

            return financialOrderTransaction;
        }

        [HttpGet("fetchbyfinancialpaymentid/{financialpaymentid?}")]
        public IEnumerable<CrudeFinancialOrderTransactionModel> CrudeFinancialOrderTransactionFetchByFinancialPaymentId(System.Guid financialpaymentid) {

            List<CrudeFinancialOrderTransactionModel> financialOrderTransaction = 
                new CrudeFinancialOrderTransactionBusiness().FetchByFinancialPaymentId(financialpaymentid);

            return financialOrderTransaction;
        }

        [HttpGet("fetchbyfinancialcurrencyid/{financialcurrencyid?}")]
        public IEnumerable<CrudeFinancialOrderTransactionModel> CrudeFinancialOrderTransactionFetchByFinancialCurrencyId(System.Guid financialcurrencyid) {

            List<CrudeFinancialOrderTransactionModel> financialOrderTransaction = 
                new CrudeFinancialOrderTransactionBusiness().FetchByFinancialCurrencyId(financialcurrencyid);

            return financialOrderTransaction;
        }

        [HttpGet("fetchbyfinancialcostcentreid/{financialcostcentreid?}")]
        public IEnumerable<CrudeFinancialOrderTransactionModel> CrudeFinancialOrderTransactionFetchByFinancialCostcentreId(System.Guid financialcostcentreid) {

            List<CrudeFinancialOrderTransactionModel> financialOrderTransaction = 
                new CrudeFinancialOrderTransactionBusiness().FetchByFinancialCostcentreId(financialcostcentreid);

            return financialOrderTransaction;
        }

        [HttpGet("fetchbyfinancialadjustmentid/{financialadjustmentid?}")]
        public IEnumerable<CrudeFinancialOrderTransactionModel> CrudeFinancialOrderTransactionFetchByFinancialAdjustmentId(System.Guid financialadjustmentid) {

            List<CrudeFinancialOrderTransactionModel> financialOrderTransaction = 
                new CrudeFinancialOrderTransactionBusiness().FetchByFinancialAdjustmentId(financialadjustmentid);

            return financialOrderTransaction;
        }

        [HttpGet("fetchbyfinancialordertransactiontypercd/{financialordertransactiontypercd?}")]
        public IEnumerable<CrudeFinancialOrderTransactionModel> CrudeFinancialOrderTransactionFetchByFinancialOrderTransactionTypeRcd(System.String financialordertransactiontypercd) {

            List<CrudeFinancialOrderTransactionModel> financialOrderTransaction = 
                new CrudeFinancialOrderTransactionBusiness().FetchByFinancialOrderTransactionTypeRcd(financialordertransactiontypercd);

            return financialOrderTransaction;
        }

        [HttpGet("fetchbyfinancialorderid/{financialorderid?}")]
        public IEnumerable<CrudeFinancialOrderTransactionModel> CrudeFinancialOrderTransactionFetchByFinancialOrderId(System.Guid financialorderid) {

            List<CrudeFinancialOrderTransactionModel> financialOrderTransaction = 
                new CrudeFinancialOrderTransactionBusiness().FetchByFinancialOrderId(financialorderid);

            return financialOrderTransaction;
        }

        [HttpPost("crudefinancialordertransactioncreate")]
        public CrudeFinancialOrderTransactionModel CrudeFinancialOrderTransactionCreate([Bind()] CrudeFinancialOrderTransactionModel financialOrderTransaction) {

            new CrudeFinancialOrderTransactionBusiness().Insert(financialOrderTransaction);

            return financialOrderTransaction;
        }

        [HttpGet("createtest")]
        public string CrudeFinancialOrderTransactionCreateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 9:46:28 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "TransactionNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderTransactionTypeRcd" , "create" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // POST model to myself
                var client = new HttpClient ();
                var response = client.PostAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderTransaction/CrudeFinancialOrderTransactionCreate/", content).Result;
                // todo var response = client.PostAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrderTransaction/CrudeFinancialOrderTransactionCreate/", content).Result;

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

        [HttpPut("crudefinancialordertransactionupdate")]
        public CrudeFinancialOrderTransactionModel CrudeFinancialOrderTransactionUpdate([Bind()] CrudeFinancialOrderTransactionModel financialOrderTransaction) {

            new CrudeFinancialOrderTransactionBusiness().Update(financialOrderTransaction);

            return financialOrderTransaction;
        }

        [HttpGet("updatetest")]
        public string CrudeFinancialOrderTransactionUpdateTest() {
            string result = string.Empty;

            try {
                // pair name and value from model
                var pairs = new List<KeyValuePair<string , string>> ();
                pairs.Add ( new KeyValuePair<string , string> ( "DateTime" , "1/14/2020 9:46:28 AM" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "TransactionNumber" , "1" ) );
                pairs.Add ( new KeyValuePair<string , string> ( "FinancialOrderTransactionTypeRcd" , "update" ) );
                var content = new FormUrlEncodedContent ( pairs );

                // PUT model to myself
                var client = new HttpClient ();
                var response = client.PutAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderTransaction/CrudeFinancialOrderTransactionUpdate/", content).Result;
                // todo var response = client.PutAsync("http://NorSolutionPimCore.azurewebsites.net/api/1/CrudeFinancialOrderTransaction/CrudeFinancialOrderTransactionUpdate/", content).Result;

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

        [HttpDelete("financialordertransactiondelete/{financialbookingtransactionid?}")]
        public void CrudeFinancialOrderTransactionDelete(System.Guid financialBookingTransactionId) {

            new CrudeFinancialOrderTransactionBusiness().Delete(financialBookingTransactionId);
        }

        [HttpGet("deletetest")]
        public string CrudeFinancialOrderTransactionDeleteTest() {
            string result = string.Empty;

            try {
                var client = new HttpClient ();
                var response = client.DeleteAsync("http://.azurewebsites.net//api/1/CrudeFinancialOrderTransaction/CrudeFinancialOrderTransactionDelete/00000000-0000-0000-0000-000000000001" ).Result;

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
