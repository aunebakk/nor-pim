/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:22:58 AM
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
    
    
    public partial class CrudeFinancialAdjustmentBusiness {
        
        public CrudeFinancialAdjustmentModel FetchByFinancialAdjustmentId(System.Guid financialAdjustmentId) {
            var dataAccessLayer = new CrudeFinancialAdjustmentData();
            var model = new CrudeFinancialAdjustmentModel();

            dataAccessLayer.FetchByFinancialAdjustmentId(financialAdjustmentId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialAdjustmentModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialAdjustmentData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeFinancialAdjustmentModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialAdjustmentData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialAdjustmentModel> FetchByFinancialAdjustmentTypeRcd(string financialAdjustmentTypeRcd) {
            return DataListToModelList(CrudeFinancialAdjustmentData.FetchByFinancialAdjustmentTypeRcd(financialAdjustmentTypeRcd));
        }
        
        public static List<CrudeFinancialAdjustmentModel> DataListToModelList(List<CrudeFinancialAdjustmentData> dataList) {
            var modelList = new List<CrudeFinancialAdjustmentModel>();

            foreach (CrudeFinancialAdjustmentData data in dataList) {
                var model = new CrudeFinancialAdjustmentModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialAdjustmentModel> modelList, List<CrudeFinancialAdjustmentData> dataList) {
            foreach (CrudeFinancialAdjustmentModel model in modelList) {
                var data = new CrudeFinancialAdjustmentData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialAdjustmentModel> FetchAll() {
            var list = new List<CrudeFinancialAdjustmentModel>();
            List<CrudeFinancialAdjustmentData> dataList = CrudeFinancialAdjustmentData.FetchAll();

            foreach (CrudeFinancialAdjustmentData crudeFinancialAdjustmentBusiness in dataList) {
                var model = new CrudeFinancialAdjustmentModel();
                DataToModel(crudeFinancialAdjustmentBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialAdjustmentModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialAdjustmentModel>();
            List<CrudeFinancialAdjustmentData> dataList = CrudeFinancialAdjustmentData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialAdjustmentData crudeFinancialAdjustmentBusiness in dataList) {
                var model = new CrudeFinancialAdjustmentModel();
                DataToModel(crudeFinancialAdjustmentBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialAdjustmentModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialAdjustmentModel>();
            List<CrudeFinancialAdjustmentData> dataList = CrudeFinancialAdjustmentData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialAdjustmentData crudeFinancialAdjustmentBusiness in dataList) {
                var model = new CrudeFinancialAdjustmentModel();
                DataToModel(crudeFinancialAdjustmentBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialAdjustmentData.FetchAllCount();

        }
        
        public List<CrudeFinancialAdjustmentModel> FetchWithFilter(System.Guid financialAdjustmentId, decimal amount, System.Guid financialCurrencyId, System.Guid userId, System.DateTime dateTime, string financialAdjustmentTypeRcd) {
            var list = new List<CrudeFinancialAdjustmentModel>();
            List<CrudeFinancialAdjustmentData> dataList = CrudeFinancialAdjustmentData.FetchWithFilter(financialAdjustmentId,amount,financialCurrencyId,userId,dateTime,financialAdjustmentTypeRcd);

            foreach (CrudeFinancialAdjustmentData data in dataList) {
                var crudeFinancialAdjustmentBusinessModel = new CrudeFinancialAdjustmentModel();
                DataToModel(data, crudeFinancialAdjustmentBusinessModel);
                list.Add(crudeFinancialAdjustmentBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialAdjustmentModel model) {
            var data = new CrudeFinancialAdjustmentData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialAdjustmentModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialAdjustmentData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialAdjustmentModel model) {
            var data = new CrudeFinancialAdjustmentData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialAdjustmentModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialAdjustmentData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialAdjustmentId) {
            CrudeFinancialAdjustmentData.Delete(financialAdjustmentId);
        }
        
        public static void ModelToData(CrudeFinancialAdjustmentModel model, CrudeFinancialAdjustmentData data) {
            data.FinancialAdjustmentId = model.FinancialAdjustmentId;
            data.Amount = model.Amount;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.FinancialAdjustmentTypeRcd = model.FinancialAdjustmentTypeRcd;
        }
        
        public static void DataToModel(CrudeFinancialAdjustmentData data, CrudeFinancialAdjustmentModel model) {
            model.FinancialAdjustmentId = data.FinancialAdjustmentId;
            model.Amount = data.Amount;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.FinancialAdjustmentTypeRcd = data.FinancialAdjustmentTypeRcd;
        }
    }
}
