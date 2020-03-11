/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:38:40 PM
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
    
    
    public partial class CrudeProductBusiness {
        
        public CrudeProductModel FetchByProductId(System.Guid productId) {
            var dataAccessLayer = new CrudeProductData();
            var model = new CrudeProductModel();

            dataAccessLayer.FetchByProductId(productId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductModel FetchByProductName(string productName) {
            var dataAccessLayer = new CrudeProductData();
            var model = new CrudeProductModel();

            dataAccessLayer.FetchByProductName(productName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductModel> FetchByProductBecameId(System.Guid productBecameId) {
            return DataListToModelList(CrudeProductData.FetchByProductBecameId(productBecameId));
        }
        
        public List<CrudeProductModel> FetchByStateRcd(string stateRcd) {
            return DataListToModelList(CrudeProductData.FetchByStateRcd(stateRcd));
        }
        
        public List<CrudeProductModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductModel> DataListToModelList(List<CrudeProductData> dataList) {
            var modelList = new List<CrudeProductModel>();

            foreach (CrudeProductData data in dataList) {
                var model = new CrudeProductModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductModel> modelList, List<CrudeProductData> dataList) {
            foreach (CrudeProductModel model in modelList) {
                var data = new CrudeProductData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductModel> FetchAll() {
            var list = new List<CrudeProductModel>();
            List<CrudeProductData> dataList = CrudeProductData.FetchAll();

            foreach (CrudeProductData crudeProductBusiness in dataList) {
                var model = new CrudeProductModel();
                DataToModel(crudeProductBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductModel>();
            List<CrudeProductData> dataList = CrudeProductData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductData crudeProductBusiness in dataList) {
                var model = new CrudeProductModel();
                DataToModel(crudeProductBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductModel>();
            List<CrudeProductData> dataList = CrudeProductData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductData crudeProductBusiness in dataList) {
                var model = new CrudeProductModel();
                DataToModel(crudeProductBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductData.FetchAllCount();

        }
        
        public List<CrudeProductModel> FetchWithFilter(System.Guid productId, System.Guid productBecameId, string productName, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductModel>();
            List<CrudeProductData> dataList = CrudeProductData.FetchWithFilter(productId,productBecameId,productName,stateRcd,userId,dateTime);

            foreach (CrudeProductData data in dataList) {
                var crudeProductBusinessModel = new CrudeProductModel();
                DataToModel(data, crudeProductBusinessModel);
                list.Add(crudeProductBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductModel model) {
            var data = new CrudeProductData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductModel model) {
            var data = new CrudeProductData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productId) {
            CrudeProductData.Delete(productId);
        }
        
        public static void ModelToData(CrudeProductModel model, CrudeProductData data) {
            data.ProductId = model.ProductId;
            data.ProductBecameId = model.ProductBecameId;
            data.ProductName = model.ProductName;
            data.StateRcd = model.StateRcd;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductData data, CrudeProductModel model) {
            model.ProductId = data.ProductId;
            model.ProductBecameId = data.ProductBecameId;
            model.ProductName = data.ProductName;
            model.StateRcd = data.StateRcd;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
