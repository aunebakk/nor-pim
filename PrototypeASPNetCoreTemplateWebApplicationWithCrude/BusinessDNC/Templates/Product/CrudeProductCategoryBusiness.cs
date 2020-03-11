/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:34:15 PM
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
    
    
    public partial class CrudeProductCategoryBusiness {
        
        public CrudeProductCategoryModel FetchByProductCategoryId(System.Guid productCategoryId) {
            var dataAccessLayer = new CrudeProductCategoryData();
            var model = new CrudeProductCategoryModel();

            dataAccessLayer.FetchByProductCategoryId(productCategoryId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductCategoryModel FetchByProductCategoryName(string productCategoryName) {
            var dataAccessLayer = new CrudeProductCategoryData();
            var model = new CrudeProductCategoryModel();

            dataAccessLayer.FetchByProductCategoryName(productCategoryName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductCategoryModel> FetchByProductCategoryBecameId(System.Guid productCategoryBecameId) {
            return DataListToModelList(CrudeProductCategoryData.FetchByProductCategoryBecameId(productCategoryBecameId));
        }
        
        public List<CrudeProductCategoryModel> FetchByProductCategoryParentId(System.Guid productCategoryParentId) {
            return DataListToModelList(CrudeProductCategoryData.FetchByProductCategoryParentId(productCategoryParentId));
        }
        
        public List<CrudeProductCategoryModel> FetchByStateRcd(string stateRcd) {
            return DataListToModelList(CrudeProductCategoryData.FetchByStateRcd(stateRcd));
        }
        
        public List<CrudeProductCategoryModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductCategoryData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductCategoryModel> DataListToModelList(List<CrudeProductCategoryData> dataList) {
            var modelList = new List<CrudeProductCategoryModel>();

            foreach (CrudeProductCategoryData data in dataList) {
                var model = new CrudeProductCategoryModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductCategoryModel> modelList, List<CrudeProductCategoryData> dataList) {
            foreach (CrudeProductCategoryModel model in modelList) {
                var data = new CrudeProductCategoryData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryModel> FetchAll() {
            var list = new List<CrudeProductCategoryModel>();
            List<CrudeProductCategoryData> dataList = CrudeProductCategoryData.FetchAll();

            foreach (CrudeProductCategoryData crudeProductCategoryBusiness in dataList) {
                var model = new CrudeProductCategoryModel();
                DataToModel(crudeProductCategoryBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductCategoryModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductCategoryModel>();
            List<CrudeProductCategoryData> dataList = CrudeProductCategoryData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductCategoryData crudeProductCategoryBusiness in dataList) {
                var model = new CrudeProductCategoryModel();
                DataToModel(crudeProductCategoryBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductCategoryModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductCategoryModel>();
            List<CrudeProductCategoryData> dataList = CrudeProductCategoryData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductCategoryData crudeProductCategoryBusiness in dataList) {
                var model = new CrudeProductCategoryModel();
                DataToModel(crudeProductCategoryBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductCategoryData.FetchAllCount();

        }
        
        public List<CrudeProductCategoryModel> FetchWithFilter(System.Guid productCategoryId, System.Guid productCategoryBecameId, System.Guid productCategoryParentId, string productCategoryCode, string productCategoryName, int productCategoryPosition, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryModel>();
            List<CrudeProductCategoryData> dataList = CrudeProductCategoryData.FetchWithFilter(productCategoryId,productCategoryBecameId,productCategoryParentId,productCategoryCode,productCategoryName,productCategoryPosition,stateRcd,userId,dateTime);

            foreach (CrudeProductCategoryData data in dataList) {
                var crudeProductCategoryBusinessModel = new CrudeProductCategoryModel();
                DataToModel(data, crudeProductCategoryBusinessModel);
                list.Add(crudeProductCategoryBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryModel model) {
            var data = new CrudeProductCategoryData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductCategoryModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductCategoryModel model) {
            var data = new CrudeProductCategoryData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductCategoryModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productCategoryId) {
            CrudeProductCategoryData.Delete(productCategoryId);
        }
        
        public static void ModelToData(CrudeProductCategoryModel model, CrudeProductCategoryData data) {
            data.ProductCategoryId = model.ProductCategoryId;
            data.ProductCategoryBecameId = model.ProductCategoryBecameId;
            data.ProductCategoryParentId = model.ProductCategoryParentId;
            data.ProductCategoryCode = model.ProductCategoryCode;
            data.ProductCategoryName = model.ProductCategoryName;
            data.ProductCategoryPosition = model.ProductCategoryPosition;
            data.StateRcd = model.StateRcd;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductCategoryData data, CrudeProductCategoryModel model) {
            model.ProductCategoryId = data.ProductCategoryId;
            model.ProductCategoryBecameId = data.ProductCategoryBecameId;
            model.ProductCategoryParentId = data.ProductCategoryParentId;
            model.ProductCategoryCode = data.ProductCategoryCode;
            model.ProductCategoryName = data.ProductCategoryName;
            model.ProductCategoryPosition = data.ProductCategoryPosition;
            model.StateRcd = data.StateRcd;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
