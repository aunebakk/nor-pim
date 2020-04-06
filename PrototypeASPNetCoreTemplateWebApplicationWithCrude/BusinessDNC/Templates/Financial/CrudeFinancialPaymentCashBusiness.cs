/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:45 PM
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
    
    
    public partial class CrudeFinancialPaymentCashBusiness {
        
        public CrudeFinancialPaymentCashModel FetchByFinancialPaymentCashId(System.Guid financialPaymentCashId) {
            var dataAccessLayer = new CrudeFinancialPaymentCashData();
            var model = new CrudeFinancialPaymentCashModel();

            dataAccessLayer.FetchByFinancialPaymentCashId(financialPaymentCashId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialPaymentCashModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialPaymentCashData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialPaymentCashModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialPaymentCashData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public static List<CrudeFinancialPaymentCashModel> DataListToModelList(List<CrudeFinancialPaymentCashData> dataList) {
            var modelList = new List<CrudeFinancialPaymentCashModel>();

            foreach (CrudeFinancialPaymentCashData data in dataList) {
                var model = new CrudeFinancialPaymentCashModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialPaymentCashModel> modelList, List<CrudeFinancialPaymentCashData> dataList) {
            foreach (CrudeFinancialPaymentCashModel model in modelList) {
                var data = new CrudeFinancialPaymentCashData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentCashModel> FetchAll() {
            var list = new List<CrudeFinancialPaymentCashModel>();
            List<CrudeFinancialPaymentCashData> dataList = CrudeFinancialPaymentCashData.FetchAll();

            foreach (CrudeFinancialPaymentCashData crudeFinancialPaymentCashBusiness in dataList) {
                var model = new CrudeFinancialPaymentCashModel();
                DataToModel(crudeFinancialPaymentCashBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentCashModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialPaymentCashModel>();
            List<CrudeFinancialPaymentCashData> dataList = CrudeFinancialPaymentCashData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialPaymentCashData crudeFinancialPaymentCashBusiness in dataList) {
                var model = new CrudeFinancialPaymentCashModel();
                DataToModel(crudeFinancialPaymentCashBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentCashModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialPaymentCashModel>();
            List<CrudeFinancialPaymentCashData> dataList = CrudeFinancialPaymentCashData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialPaymentCashData crudeFinancialPaymentCashBusiness in dataList) {
                var model = new CrudeFinancialPaymentCashModel();
                DataToModel(crudeFinancialPaymentCashBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentCashData.FetchAllCount();

        }
        
        public List<CrudeFinancialPaymentCashModel> FetchWithFilter(System.Guid financialPaymentCashId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId) {
            var list = new List<CrudeFinancialPaymentCashModel>();
            List<CrudeFinancialPaymentCashData> dataList = CrudeFinancialPaymentCashData.FetchWithFilter(financialPaymentCashId,userId,dateTime,amount,financialCurrencyId);

            foreach (CrudeFinancialPaymentCashData data in dataList) {
                var crudeFinancialPaymentCashBusinessModel = new CrudeFinancialPaymentCashModel();
                DataToModel(data, crudeFinancialPaymentCashBusinessModel);
                list.Add(crudeFinancialPaymentCashBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentCashModel model) {
            var data = new CrudeFinancialPaymentCashData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentCashModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCashData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentCashModel model) {
            var data = new CrudeFinancialPaymentCashData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentCashModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCashData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialPaymentCashId) {
            CrudeFinancialPaymentCashData.Delete(financialPaymentCashId);
        }
        
        public static void ModelToData(CrudeFinancialPaymentCashModel model, CrudeFinancialPaymentCashData data) {
            data.FinancialPaymentCashId = model.FinancialPaymentCashId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.Amount = model.Amount;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
        }
        
        public static void DataToModel(CrudeFinancialPaymentCashData data, CrudeFinancialPaymentCashModel model) {
            model.FinancialPaymentCashId = data.FinancialPaymentCashId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.Amount = data.Amount;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
        }
    }
}
