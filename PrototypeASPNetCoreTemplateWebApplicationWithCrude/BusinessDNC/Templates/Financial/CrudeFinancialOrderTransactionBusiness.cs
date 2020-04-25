/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:22:59 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreBusiness
*/
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using SolutionNorSolutionPim.BusinessLogicLayer;
using SolutionNorSolutionPim.BusinessLogicLayer.Models;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class CrudeFinancialOrderTransactionBusiness {
        
        public CrudeFinancialOrderTransactionModel FetchByFinancialBookingTransactionId(System.Guid financialBookingTransactionId) {
            var dataAccessLayer = new CrudeFinancialOrderTransactionData();
            var model = new CrudeFinancialOrderTransactionModel();

            dataAccessLayer.FetchByFinancialBookingTransactionId(financialBookingTransactionId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialOrderTransactionModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialOrderTransactionData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialOrderTransactionModel> FetchByFinancialFeeId(System.Guid financialFeeId) {
            return DataListToModelList(CrudeFinancialOrderTransactionData.FetchByFinancialFeeId(financialFeeId));
        }
        
        public List<CrudeFinancialOrderTransactionModel> FetchByFinancialTaxId(System.Guid financialTaxId) {
            return DataListToModelList(CrudeFinancialOrderTransactionData.FetchByFinancialTaxId(financialTaxId));
        }
        
        public List<CrudeFinancialOrderTransactionModel> FetchByFinancialPaymentId(System.Guid financialPaymentId) {
            return DataListToModelList(CrudeFinancialOrderTransactionData.FetchByFinancialPaymentId(financialPaymentId));
        }
        
        public List<CrudeFinancialOrderTransactionModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialOrderTransactionData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeFinancialOrderTransactionModel> FetchByFinancialCostcentreId(System.Guid financialCostcentreId) {
            return DataListToModelList(CrudeFinancialOrderTransactionData.FetchByFinancialCostcentreId(financialCostcentreId));
        }
        
        public List<CrudeFinancialOrderTransactionModel> FetchByFinancialAdjustmentId(System.Guid financialAdjustmentId) {
            return DataListToModelList(CrudeFinancialOrderTransactionData.FetchByFinancialAdjustmentId(financialAdjustmentId));
        }
        
        public List<CrudeFinancialOrderTransactionModel> FetchByFinancialOrderTransactionTypeRcd(string financialOrderTransactionTypeRcd) {
            return DataListToModelList(CrudeFinancialOrderTransactionData.FetchByFinancialOrderTransactionTypeRcd(financialOrderTransactionTypeRcd));
        }
        
        public List<CrudeFinancialOrderTransactionModel> FetchByFinancialOrderId(System.Guid financialOrderId) {
            return DataListToModelList(CrudeFinancialOrderTransactionData.FetchByFinancialOrderId(financialOrderId));
        }
        
        public static List<CrudeFinancialOrderTransactionModel> DataListToModelList(List<CrudeFinancialOrderTransactionData> dataList) {
            var modelList = new List<CrudeFinancialOrderTransactionModel>();

            foreach (CrudeFinancialOrderTransactionData data in dataList) {
                var model = new CrudeFinancialOrderTransactionModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialOrderTransactionModel> modelList, List<CrudeFinancialOrderTransactionData> dataList) {
            foreach (CrudeFinancialOrderTransactionModel model in modelList) {
                var data = new CrudeFinancialOrderTransactionData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderTransactionModel> FetchAll() {
            var list = new List<CrudeFinancialOrderTransactionModel>();
            List<CrudeFinancialOrderTransactionData> dataList = CrudeFinancialOrderTransactionData.FetchAll();

            foreach (CrudeFinancialOrderTransactionData crudeFinancialOrderTransactionBusiness in dataList) {
                var model = new CrudeFinancialOrderTransactionModel();
                DataToModel(crudeFinancialOrderTransactionBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderTransactionModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialOrderTransactionModel>();
            List<CrudeFinancialOrderTransactionData> dataList = CrudeFinancialOrderTransactionData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialOrderTransactionData crudeFinancialOrderTransactionBusiness in dataList) {
                var model = new CrudeFinancialOrderTransactionModel();
                DataToModel(crudeFinancialOrderTransactionBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderTransactionModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialOrderTransactionModel>();
            List<CrudeFinancialOrderTransactionData> dataList = CrudeFinancialOrderTransactionData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialOrderTransactionData crudeFinancialOrderTransactionBusiness in dataList) {
                var model = new CrudeFinancialOrderTransactionModel();
                DataToModel(crudeFinancialOrderTransactionBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderTransactionData.FetchAllCount();

        }
        
        public List<CrudeFinancialOrderTransactionModel> FetchWithFilter(System.Guid financialBookingTransactionId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialFeeId, System.Guid financialTaxId, System.Guid financialPaymentId, System.Guid financialCurrencyId, int transactionNumber, System.Guid financialCostcentreId, System.Guid financialAdjustmentId, string financialOrderTransactionTypeRcd, System.Guid financialOrderId) {
            var list = new List<CrudeFinancialOrderTransactionModel>();
            List<CrudeFinancialOrderTransactionData> dataList = CrudeFinancialOrderTransactionData.FetchWithFilter(financialBookingTransactionId,userId,dateTime,amount,financialFeeId,financialTaxId,financialPaymentId,financialCurrencyId,transactionNumber,financialCostcentreId,financialAdjustmentId,financialOrderTransactionTypeRcd,financialOrderId);

            foreach (CrudeFinancialOrderTransactionData data in dataList) {
                var crudeFinancialOrderTransactionBusinessModel = new CrudeFinancialOrderTransactionModel();
                DataToModel(data, crudeFinancialOrderTransactionBusinessModel);
                list.Add(crudeFinancialOrderTransactionBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderTransactionModel model) {
            var data = new CrudeFinancialOrderTransactionData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderTransactionModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderTransactionData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderTransactionModel model) {
            var data = new CrudeFinancialOrderTransactionData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderTransactionModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderTransactionData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialBookingTransactionId) {
            CrudeFinancialOrderTransactionData.Delete(financialBookingTransactionId);
        }
        
        public static void ModelToData(CrudeFinancialOrderTransactionModel model, CrudeFinancialOrderTransactionData data) {
            data.FinancialBookingTransactionId = model.FinancialBookingTransactionId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.Amount = model.Amount;
            data.FinancialFeeId = model.FinancialFeeId;
            data.FinancialTaxId = model.FinancialTaxId;
            data.FinancialPaymentId = model.FinancialPaymentId;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
            data.TransactionNumber = model.TransactionNumber;
            data.FinancialCostcentreId = model.FinancialCostcentreId;
            data.FinancialAdjustmentId = model.FinancialAdjustmentId;
            data.FinancialOrderTransactionTypeRcd = model.FinancialOrderTransactionTypeRcd;
            data.FinancialOrderId = model.FinancialOrderId;
        }
        
        public static void DataToModel(CrudeFinancialOrderTransactionData data, CrudeFinancialOrderTransactionModel model) {
            model.FinancialBookingTransactionId = data.FinancialBookingTransactionId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.Amount = data.Amount;
            model.FinancialFeeId = data.FinancialFeeId;
            model.FinancialTaxId = data.FinancialTaxId;
            model.FinancialPaymentId = data.FinancialPaymentId;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
            model.TransactionNumber = data.TransactionNumber;
            model.FinancialCostcentreId = data.FinancialCostcentreId;
            model.FinancialAdjustmentId = data.FinancialAdjustmentId;
            model.FinancialOrderTransactionTypeRcd = data.FinancialOrderTransactionTypeRcd;
            model.FinancialOrderId = data.FinancialOrderId;
        }
    }
}
