/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:44:10 PM
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
    
    
    public partial class CrudeProductCategoryMappingBusiness {
        
        public CrudeProductCategoryMappingModel FetchByProductCategoryMappingId(System.Guid productCategoryMappingId) {
            var dataAccessLayer = new CrudeProductCategoryMappingData();
            var model = new CrudeProductCategoryMappingModel();

            dataAccessLayer.FetchByProductCategoryMappingId(productCategoryMappingId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductCategoryMappingModel> FetchByProductCategoryId(System.Guid productCategoryId) {
            return DataListToModelList(CrudeProductCategoryMappingData.FetchByProductCategoryId(productCategoryId));
        }
        
        public List<CrudeProductCategoryMappingModel> FetchByProductId(System.Guid productId) {
            return DataListToModelList(CrudeProductCategoryMappingData.FetchByProductId(productId));
        }
        
        public List<CrudeProductCategoryMappingModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductCategoryMappingData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductCategoryMappingModel> DataListToModelList(List<CrudeProductCategoryMappingData> dataList) {
            var modelList = new List<CrudeProductCategoryMappingModel>();

            foreach (CrudeProductCategoryMappingData data in dataList) {
                var model = new CrudeProductCategoryMappingModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductCategoryMappingModel> modelList, List<CrudeProductCategoryMappingData> dataList) {
            foreach (CrudeProductCategoryMappingModel model in modelList) {
                var data = new CrudeProductCategoryMappingData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryMappingModel> FetchAll() {
            var list = new List<CrudeProductCategoryMappingModel>();
            List<CrudeProductCategoryMappingData> dataList = CrudeProductCategoryMappingData.FetchAll();

            foreach (CrudeProductCategoryMappingData crudeProductCategoryMappingBusiness in dataList) {
                var model = new CrudeProductCategoryMappingModel();
                DataToModel(crudeProductCategoryMappingBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductCategoryMappingModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductCategoryMappingModel>();
            List<CrudeProductCategoryMappingData> dataList = CrudeProductCategoryMappingData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductCategoryMappingData crudeProductCategoryMappingBusiness in dataList) {
                var model = new CrudeProductCategoryMappingModel();
                DataToModel(crudeProductCategoryMappingBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductCategoryMappingModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductCategoryMappingModel>();
            List<CrudeProductCategoryMappingData> dataList = CrudeProductCategoryMappingData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductCategoryMappingData crudeProductCategoryMappingBusiness in dataList) {
                var model = new CrudeProductCategoryMappingModel();
                DataToModel(crudeProductCategoryMappingBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductCategoryMappingData.FetchAllCount();

        }
        
        public List<CrudeProductCategoryMappingModel> FetchWithFilter(System.Guid productCategoryMappingId, System.Guid productCategoryId, System.Guid productId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryMappingModel>();
            List<CrudeProductCategoryMappingData> dataList = CrudeProductCategoryMappingData.FetchWithFilter(productCategoryMappingId,productCategoryId,productId,userId,dateTime);

            foreach (CrudeProductCategoryMappingData data in dataList) {
                var crudeProductCategoryMappingBusinessModel = new CrudeProductCategoryMappingModel();
                DataToModel(data, crudeProductCategoryMappingBusinessModel);
                list.Add(crudeProductCategoryMappingBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryMappingModel model) {
            var data = new CrudeProductCategoryMappingData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductCategoryMappingModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryMappingData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductCategoryMappingModel model) {
            var data = new CrudeProductCategoryMappingData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductCategoryMappingModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryMappingData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productCategoryMappingId) {
            CrudeProductCategoryMappingData.Delete(productCategoryMappingId);
        }
        
        public static void ModelToData(CrudeProductCategoryMappingModel model, CrudeProductCategoryMappingData data) {
            data.ProductCategoryMappingId = model.ProductCategoryMappingId;
            data.ProductCategoryId = model.ProductCategoryId;
            data.ProductId = model.ProductId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductCategoryMappingData data, CrudeProductCategoryMappingModel model) {
            model.ProductCategoryMappingId = data.ProductCategoryMappingId;
            model.ProductCategoryId = data.ProductCategoryId;
            model.ProductId = data.ProductId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
