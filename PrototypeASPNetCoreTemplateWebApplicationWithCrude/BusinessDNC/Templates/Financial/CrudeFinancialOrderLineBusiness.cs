/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:29:23 PM
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
    
    
    public partial class CrudeFinancialOrderLineBusiness {
        
        public CrudeFinancialOrderLineModel FetchByFinancialOrderLineId(System.Guid financialOrderLineId) {
            var dataAccessLayer = new CrudeFinancialOrderLineData();
            var model = new CrudeFinancialOrderLineModel();

            dataAccessLayer.FetchByFinancialOrderLineId(financialOrderLineId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialOrderLineModel> FetchByFinancialOrderId(System.Guid financialOrderId) {
            return DataListToModelList(CrudeFinancialOrderLineData.FetchByFinancialOrderId(financialOrderId));
        }
        
        public List<CrudeFinancialOrderLineModel> FetchByProductId(System.Guid productId) {
            return DataListToModelList(CrudeFinancialOrderLineData.FetchByProductId(productId));
        }
        
        public List<CrudeFinancialOrderLineModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialOrderLineData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialOrderLineModel> FetchByFinancialUnitOfMeasurementRcd(string financialUnitOfMeasurementRcd) {
            return DataListToModelList(CrudeFinancialOrderLineData.FetchByFinancialUnitOfMeasurementRcd(financialUnitOfMeasurementRcd));
        }
        
        public List<CrudeFinancialOrderLineModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialOrderLineData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public static List<CrudeFinancialOrderLineModel> DataListToModelList(List<CrudeFinancialOrderLineData> dataList) {
            var modelList = new List<CrudeFinancialOrderLineModel>();

            foreach (CrudeFinancialOrderLineData data in dataList) {
                var model = new CrudeFinancialOrderLineModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialOrderLineModel> modelList, List<CrudeFinancialOrderLineData> dataList) {
            foreach (CrudeFinancialOrderLineModel model in modelList) {
                var data = new CrudeFinancialOrderLineData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderLineModel> FetchAll() {
            var list = new List<CrudeFinancialOrderLineModel>();
            List<CrudeFinancialOrderLineData> dataList = CrudeFinancialOrderLineData.FetchAll();

            foreach (CrudeFinancialOrderLineData crudeFinancialOrderLineBusiness in dataList) {
                var model = new CrudeFinancialOrderLineModel();
                DataToModel(crudeFinancialOrderLineBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderLineModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialOrderLineModel>();
            List<CrudeFinancialOrderLineData> dataList = CrudeFinancialOrderLineData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialOrderLineData crudeFinancialOrderLineBusiness in dataList) {
                var model = new CrudeFinancialOrderLineModel();
                DataToModel(crudeFinancialOrderLineBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderLineModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialOrderLineModel>();
            List<CrudeFinancialOrderLineData> dataList = CrudeFinancialOrderLineData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialOrderLineData crudeFinancialOrderLineBusiness in dataList) {
                var model = new CrudeFinancialOrderLineModel();
                DataToModel(crudeFinancialOrderLineBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderLineData.FetchAllCount();

        }
        
        public List<CrudeFinancialOrderLineModel> FetchWithFilter(System.Guid financialOrderLineId, System.Guid financialOrderId, System.Guid productId, System.Guid userId, System.DateTime dateTime, string comment, int lineNumber, string financialUnitOfMeasurementRcd, int quantityNumber, System.Guid financialCurrencyId, decimal amount) {
            var list = new List<CrudeFinancialOrderLineModel>();
            List<CrudeFinancialOrderLineData> dataList = CrudeFinancialOrderLineData.FetchWithFilter(financialOrderLineId,financialOrderId,productId,userId,dateTime,comment,lineNumber,financialUnitOfMeasurementRcd,quantityNumber,financialCurrencyId,amount);

            foreach (CrudeFinancialOrderLineData data in dataList) {
                var crudeFinancialOrderLineBusinessModel = new CrudeFinancialOrderLineModel();
                DataToModel(data, crudeFinancialOrderLineBusinessModel);
                list.Add(crudeFinancialOrderLineBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderLineModel model) {
            var data = new CrudeFinancialOrderLineData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderLineModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderLineData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderLineModel model) {
            var data = new CrudeFinancialOrderLineData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderLineModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderLineData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialOrderLineId) {
            CrudeFinancialOrderLineData.Delete(financialOrderLineId);
        }
        
        public static void ModelToData(CrudeFinancialOrderLineModel model, CrudeFinancialOrderLineData data) {
            data.FinancialOrderLineId = model.FinancialOrderLineId;
            data.FinancialOrderId = model.FinancialOrderId;
            data.ProductId = model.ProductId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.Comment = model.Comment;
            data.LineNumber = model.LineNumber;
            data.FinancialUnitOfMeasurementRcd = model.FinancialUnitOfMeasurementRcd;
            data.QuantityNumber = model.QuantityNumber;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
            data.Amount = model.Amount;
        }
        
        public static void DataToModel(CrudeFinancialOrderLineData data, CrudeFinancialOrderLineModel model) {
            model.FinancialOrderLineId = data.FinancialOrderLineId;
            model.FinancialOrderId = data.FinancialOrderId;
            model.ProductId = data.ProductId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.Comment = data.Comment;
            model.LineNumber = data.LineNumber;
            model.FinancialUnitOfMeasurementRcd = data.FinancialUnitOfMeasurementRcd;
            model.QuantityNumber = data.QuantityNumber;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
            model.Amount = data.Amount;
        }
    }
}
