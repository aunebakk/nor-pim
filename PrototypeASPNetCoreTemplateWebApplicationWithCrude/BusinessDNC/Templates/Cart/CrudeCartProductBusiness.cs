/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:35:20 PM
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
    
    
    public partial class CrudeCartProductBusiness {
        
        public CrudeCartProductModel FetchByCartProductId(System.Guid cartProductId) {
            var dataAccessLayer = new CrudeCartProductData();
            var model = new CrudeCartProductModel();

            dataAccessLayer.FetchByCartProductId(cartProductId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeCartProductModel> FetchByClientId(System.Guid clientId) {
            return DataListToModelList(CrudeCartProductData.FetchByClientId(clientId));
        }
        
        public List<CrudeCartProductModel> FetchByProductId(System.Guid productId) {
            return DataListToModelList(CrudeCartProductData.FetchByProductId(productId));
        }
        
        public List<CrudeCartProductModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeCartProductData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeCartProductModel> FetchByStateRcd(string stateRcd) {
            return DataListToModelList(CrudeCartProductData.FetchByStateRcd(stateRcd));
        }
        
        public List<CrudeCartProductModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeCartProductData.FetchByUserId(userId));
        }
        
        public static List<CrudeCartProductModel> DataListToModelList(List<CrudeCartProductData> dataList) {
            var modelList = new List<CrudeCartProductModel>();

            foreach (CrudeCartProductData data in dataList) {
                var model = new CrudeCartProductModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeCartProductModel> modelList, List<CrudeCartProductData> dataList) {
            foreach (CrudeCartProductModel model in modelList) {
                var data = new CrudeCartProductData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeCartProductModel> FetchAll() {
            var list = new List<CrudeCartProductModel>();
            List<CrudeCartProductData> dataList = CrudeCartProductData.FetchAll();

            foreach (CrudeCartProductData crudeCartProductBusiness in dataList) {
                var model = new CrudeCartProductModel();
                DataToModel(crudeCartProductBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeCartProductModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeCartProductModel>();
            List<CrudeCartProductData> dataList = CrudeCartProductData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeCartProductData crudeCartProductBusiness in dataList) {
                var model = new CrudeCartProductModel();
                DataToModel(crudeCartProductBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeCartProductModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeCartProductModel>();
            List<CrudeCartProductData> dataList = CrudeCartProductData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeCartProductData crudeCartProductBusiness in dataList) {
                var model = new CrudeCartProductModel();
                DataToModel(crudeCartProductBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeCartProductData.FetchAllCount();

        }
        
        public List<CrudeCartProductModel> FetchWithFilter(System.Guid cartProductId, System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, decimal amount, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeCartProductModel>();
            List<CrudeCartProductData> dataList = CrudeCartProductData.FetchWithFilter(cartProductId,clientId,productId,financialCurrencyId,amount,stateRcd,userId,dateTime);

            foreach (CrudeCartProductData data in dataList) {
                var crudeCartProductBusinessModel = new CrudeCartProductModel();
                DataToModel(data, crudeCartProductBusinessModel);
                list.Add(crudeCartProductBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeCartProductModel model) {
            var data = new CrudeCartProductData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeCartProductModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeCartProductData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeCartProductModel model) {
            var data = new CrudeCartProductData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeCartProductModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeCartProductData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid cartProductId) {
            CrudeCartProductData.Delete(cartProductId);
        }
        
        public static void ModelToData(CrudeCartProductModel model, CrudeCartProductData data) {
            data.CartProductId = model.CartProductId;
            data.ClientId = model.ClientId;
            data.ProductId = model.ProductId;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
            data.Amount = model.Amount;
            data.StateRcd = model.StateRcd;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeCartProductData data, CrudeCartProductModel model) {
            model.CartProductId = data.CartProductId;
            model.ClientId = data.ClientId;
            model.ProductId = data.ProductId;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
            model.Amount = data.Amount;
            model.StateRcd = data.StateRcd;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
