/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:22 AM
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
    
    
    public partial class CrudeFinancialOrderBusiness {
        
        public CrudeFinancialOrderModel FetchByFinancialOrderId(System.Guid financialOrderId) {
            var dataAccessLayer = new CrudeFinancialOrderData();
            var model = new CrudeFinancialOrderModel();

            dataAccessLayer.FetchByFinancialOrderId(financialOrderId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeFinancialOrderModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeFinancialOrderData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialOrderModel> FetchByLocationAddressId(System.Guid locationAddressId) {
            return DataListToModelList(CrudeFinancialOrderData.FetchByLocationAddressId(locationAddressId));
        }
        
        public List<CrudeFinancialOrderModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeFinancialOrderData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeFinancialOrderModel> FetchByFinancialOrderSourceRcd(string financialOrderSourceRcd) {
            return DataListToModelList(CrudeFinancialOrderData.FetchByFinancialOrderSourceRcd(financialOrderSourceRcd));
        }
        
        public List<CrudeFinancialOrderModel> FetchByClientId(System.Guid clientId) {
            return DataListToModelList(CrudeFinancialOrderData.FetchByClientId(clientId));
        }
        
        public static List<CrudeFinancialOrderModel> DataListToModelList(List<CrudeFinancialOrderData> dataList) {
            var modelList = new List<CrudeFinancialOrderModel>();

            foreach (CrudeFinancialOrderData data in dataList) {
                var model = new CrudeFinancialOrderModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeFinancialOrderModel> modelList, List<CrudeFinancialOrderData> dataList) {
            foreach (CrudeFinancialOrderModel model in modelList) {
                var data = new CrudeFinancialOrderData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderModel> FetchAll() {
            var list = new List<CrudeFinancialOrderModel>();
            List<CrudeFinancialOrderData> dataList = CrudeFinancialOrderData.FetchAll();

            foreach (CrudeFinancialOrderData crudeFinancialOrderBusiness in dataList) {
                var model = new CrudeFinancialOrderModel();
                DataToModel(crudeFinancialOrderBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeFinancialOrderModel>();
            List<CrudeFinancialOrderData> dataList = CrudeFinancialOrderData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeFinancialOrderData crudeFinancialOrderBusiness in dataList) {
                var model = new CrudeFinancialOrderModel();
                DataToModel(crudeFinancialOrderBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeFinancialOrderModel>();
            List<CrudeFinancialOrderData> dataList = CrudeFinancialOrderData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeFinancialOrderData crudeFinancialOrderBusiness in dataList) {
                var model = new CrudeFinancialOrderModel();
                DataToModel(crudeFinancialOrderBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderData.FetchAllCount();

        }
        
        public List<CrudeFinancialOrderModel> FetchWithFilter(System.Guid financialOrderId, System.Guid userId, System.DateTime dateTime, string comment, System.Guid locationAddressId, System.Guid financialCurrencyId, string financialOrderSourceRcd, System.Guid clientId) {
            var list = new List<CrudeFinancialOrderModel>();
            List<CrudeFinancialOrderData> dataList = CrudeFinancialOrderData.FetchWithFilter(financialOrderId,userId,dateTime,comment,locationAddressId,financialCurrencyId,financialOrderSourceRcd,clientId);

            foreach (CrudeFinancialOrderData data in dataList) {
                var crudeFinancialOrderBusinessModel = new CrudeFinancialOrderModel();
                DataToModel(data, crudeFinancialOrderBusinessModel);
                list.Add(crudeFinancialOrderBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderModel model) {
            var data = new CrudeFinancialOrderData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderModel model) {
            var data = new CrudeFinancialOrderData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialOrderId) {
            CrudeFinancialOrderData.Delete(financialOrderId);
        }
        
        public static void ModelToData(CrudeFinancialOrderModel model, CrudeFinancialOrderData data) {
            data.FinancialOrderId = model.FinancialOrderId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.Comment = model.Comment;
            data.LocationAddressId = model.LocationAddressId;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
            data.FinancialOrderSourceRcd = model.FinancialOrderSourceRcd;
            data.ClientId = model.ClientId;
        }
        
        public static void DataToModel(CrudeFinancialOrderData data, CrudeFinancialOrderModel model) {
            model.FinancialOrderId = data.FinancialOrderId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.Comment = data.Comment;
            model.LocationAddressId = data.LocationAddressId;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
            model.FinancialOrderSourceRcd = data.FinancialOrderSourceRcd;
            model.ClientId = data.ClientId;
        }
    }
}
