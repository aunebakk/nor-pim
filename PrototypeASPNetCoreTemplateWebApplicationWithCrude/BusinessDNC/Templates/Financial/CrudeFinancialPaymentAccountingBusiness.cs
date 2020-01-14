/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:26 PM
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
    
    
    public partial class CrudeFinancialPaymentAccountingBusiness {
        
        public CrudeFinancialPaymentAccountingModel FetchByFinancialPaymentAccountingId(System.Guid financialPaymentAccountingId) {
            var dataAccessLayer = new CrudeFinancialPaymentAccountingData();
            var model = new CrudeFinancialPaymentAccountingModel();

            dataAccessLayer.FetchByFinancialPaymentAccountingId(financialPaymentAccountingId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialPaymentAccountingModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialPaymentAccountingData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialPaymentAccountingModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialPaymentAccountingData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public static List<CrudeFinancialPaymentAccountingModel> DataListToModelList(List<CrudeFinancialPaymentAccountingData> dataList) {
            var modelList = new List<CrudeFinancialPaymentAccountingModel>();

            foreach (CrudeFinancialPaymentAccountingData data in dataList) {
                var model = new CrudeFinancialPaymentAccountingModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialPaymentAccountingModel> modelList, List<CrudeFinancialPaymentAccountingData> dataList) {
            foreach (CrudeFinancialPaymentAccountingModel model in modelList) {
                var data = new CrudeFinancialPaymentAccountingData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentAccountingModel> FetchAll() {
            var list = new List<CrudeFinancialPaymentAccountingModel>();
            List<CrudeFinancialPaymentAccountingData> dataList = CrudeFinancialPaymentAccountingData.FetchAll();

            foreach (CrudeFinancialPaymentAccountingData crudeFinancialPaymentAccountingBusiness in dataList) {
                var model = new CrudeFinancialPaymentAccountingModel();
                DataToModel(crudeFinancialPaymentAccountingBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentAccountingModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialPaymentAccountingModel>();
            List<CrudeFinancialPaymentAccountingData> dataList = CrudeFinancialPaymentAccountingData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialPaymentAccountingData crudeFinancialPaymentAccountingBusiness in dataList) {
                var model = new CrudeFinancialPaymentAccountingModel();
                DataToModel(crudeFinancialPaymentAccountingBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentAccountingModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialPaymentAccountingModel>();
            List<CrudeFinancialPaymentAccountingData> dataList = CrudeFinancialPaymentAccountingData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialPaymentAccountingData crudeFinancialPaymentAccountingBusiness in dataList) {
                var model = new CrudeFinancialPaymentAccountingModel();
                DataToModel(crudeFinancialPaymentAccountingBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentAccountingData.FetchAllCount();

        }
        
        public List<CrudeFinancialPaymentAccountingModel> FetchWithFilter(System.Guid financialPaymentAccountingId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId) {
            var list = new List<CrudeFinancialPaymentAccountingModel>();
            List<CrudeFinancialPaymentAccountingData> dataList = CrudeFinancialPaymentAccountingData.FetchWithFilter(financialPaymentAccountingId,userId,dateTime,amount,financialCurrencyId);

            foreach (CrudeFinancialPaymentAccountingData data in dataList) {
                var crudeFinancialPaymentAccountingBusinessModel = new CrudeFinancialPaymentAccountingModel();
                DataToModel(data, crudeFinancialPaymentAccountingBusinessModel);
                list.Add(crudeFinancialPaymentAccountingBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentAccountingModel model) {
            var data = new CrudeFinancialPaymentAccountingData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentAccountingModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentAccountingData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentAccountingModel model) {
            var data = new CrudeFinancialPaymentAccountingData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentAccountingModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentAccountingData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialPaymentAccountingId) {
            CrudeFinancialPaymentAccountingData.Delete(financialPaymentAccountingId);
        }
        
        public static void ModelToData(CrudeFinancialPaymentAccountingModel model, CrudeFinancialPaymentAccountingData data) {
            data.FinancialPaymentAccountingId = model.FinancialPaymentAccountingId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.Amount = model.Amount;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
        }
        
        public static void DataToModel(CrudeFinancialPaymentAccountingData data, CrudeFinancialPaymentAccountingModel model) {
            model.FinancialPaymentAccountingId = data.FinancialPaymentAccountingId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.Amount = data.Amount;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
        }
    }
}
