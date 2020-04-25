/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:25:17 PM
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
    
    
    public partial class CrudeCartProductPriceBusiness {
        
        public CrudeCartProductPriceModel FetchByCartProductPriceId(System.Guid cartProductPriceId) {
            var dataAccessLayer = new CrudeCartProductPriceData();
            var model = new CrudeCartProductPriceModel();

            dataAccessLayer.FetchByCartProductPriceId(cartProductPriceId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeCartProductPriceModel> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToModelList(CrudeCartProductPriceData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeCartProductPriceModel> FetchByStateRcd(string stateRcd) {
            return DataListToModelList(CrudeCartProductPriceData.FetchByStateRcd(stateRcd));
        }
        
        public List<CrudeCartProductPriceModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeCartProductPriceData.FetchByUserId(userId));
        }
        
        public List<CrudeCartProductPriceModel> FetchByProductId(System.Guid productId) {
            return DataListToModelList(CrudeCartProductPriceData.FetchByProductId(productId));
        }
        
        public static List<CrudeCartProductPriceModel> DataListToModelList(List<CrudeCartProductPriceData> dataList) {
            var modelList = new List<CrudeCartProductPriceModel>();

            foreach (CrudeCartProductPriceData data in dataList) {
                var model = new CrudeCartProductPriceModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeCartProductPriceModel> modelList, List<CrudeCartProductPriceData> dataList) {
            foreach (CrudeCartProductPriceModel model in modelList) {
                var data = new CrudeCartProductPriceData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeCartProductPriceModel> FetchAll() {
            var list = new List<CrudeCartProductPriceModel>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchAll();

            foreach (CrudeCartProductPriceData crudeCartProductPriceBusiness in dataList) {
                var model = new CrudeCartProductPriceModel();
                DataToModel(crudeCartProductPriceBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeCartProductPriceModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeCartProductPriceModel>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeCartProductPriceData crudeCartProductPriceBusiness in dataList) {
                var model = new CrudeCartProductPriceModel();
                DataToModel(crudeCartProductPriceBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeCartProductPriceModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeCartProductPriceModel>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeCartProductPriceData crudeCartProductPriceBusiness in dataList) {
                var model = new CrudeCartProductPriceModel();
                DataToModel(crudeCartProductPriceBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeCartProductPriceData.FetchAllCount();

        }
        
        public List<CrudeCartProductPriceModel> FetchWithFilter(System.Guid cartProductPriceId, System.Guid financialCurrencyId, decimal amount, string stateRcd, System.Guid userId, System.DateTime dateTime, System.Guid productId) {
            var list = new List<CrudeCartProductPriceModel>();
            List<CrudeCartProductPriceData> dataList = CrudeCartProductPriceData.FetchWithFilter(cartProductPriceId,financialCurrencyId,amount,stateRcd,userId,dateTime,productId);

            foreach (CrudeCartProductPriceData data in dataList) {
                var crudeCartProductPriceBusinessModel = new CrudeCartProductPriceModel();
                DataToModel(data, crudeCartProductPriceBusinessModel);
                list.Add(crudeCartProductPriceBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeCartProductPriceModel model) {
            var data = new CrudeCartProductPriceData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeCartProductPriceModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeCartProductPriceData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeCartProductPriceModel model) {
            var data = new CrudeCartProductPriceData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeCartProductPriceModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeCartProductPriceData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid cartProductPriceId) {
            CrudeCartProductPriceData.Delete(cartProductPriceId);
        }
        
        public static void ModelToData(CrudeCartProductPriceModel model, CrudeCartProductPriceData data) {
            data.CartProductPriceId = model.CartProductPriceId;
            data.FinancialCurrencyId = model.FinancialCurrencyId;
            data.Amount = model.Amount;
            data.StateRcd = model.StateRcd;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
            data.ProductId = model.ProductId;
        }
        
        public static void DataToModel(CrudeCartProductPriceData data, CrudeCartProductPriceModel model) {
            model.CartProductPriceId = data.CartProductPriceId;
            model.FinancialCurrencyId = data.FinancialCurrencyId;
            model.Amount = data.Amount;
            model.StateRcd = data.StateRcd;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
            model.ProductId = data.ProductId;
        }
    }
}
