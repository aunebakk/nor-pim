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
    
    
    public partial class CrudeProductCategoryImageBusiness {
        
        public CrudeProductCategoryImageModel FetchByProductCategoryImageId(System.Guid productCategoryImageId) {
            var dataAccessLayer = new CrudeProductCategoryImageData();
            var model = new CrudeProductCategoryImageModel();

            dataAccessLayer.FetchByProductCategoryImageId(productCategoryImageId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductCategoryImageModel> FetchByProductCategoryId(System.Guid productCategoryId) {
            return DataListToModelList(CrudeProductCategoryImageData.FetchByProductCategoryId(productCategoryId));
        }
        
        public List<CrudeProductCategoryImageModel> FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd) {
            return DataListToModelList(CrudeProductCategoryImageData.FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd));
        }
        
        public List<CrudeProductCategoryImageModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductCategoryImageData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductCategoryImageModel> DataListToModelList(List<CrudeProductCategoryImageData> dataList) {
            var modelList = new List<CrudeProductCategoryImageModel>();

            foreach (CrudeProductCategoryImageData data in dataList) {
                var model = new CrudeProductCategoryImageModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductCategoryImageModel> modelList, List<CrudeProductCategoryImageData> dataList) {
            foreach (CrudeProductCategoryImageModel model in modelList) {
                var data = new CrudeProductCategoryImageData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryImageModel> FetchAll() {
            var list = new List<CrudeProductCategoryImageModel>();
            List<CrudeProductCategoryImageData> dataList = CrudeProductCategoryImageData.FetchAll();

            foreach (CrudeProductCategoryImageData crudeProductCategoryImageBusiness in dataList) {
                var model = new CrudeProductCategoryImageModel();
                DataToModel(crudeProductCategoryImageBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductCategoryImageModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductCategoryImageModel>();
            List<CrudeProductCategoryImageData> dataList = CrudeProductCategoryImageData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductCategoryImageData crudeProductCategoryImageBusiness in dataList) {
                var model = new CrudeProductCategoryImageModel();
                DataToModel(crudeProductCategoryImageBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductCategoryImageModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductCategoryImageModel>();
            List<CrudeProductCategoryImageData> dataList = CrudeProductCategoryImageData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductCategoryImageData crudeProductCategoryImageBusiness in dataList) {
                var model = new CrudeProductCategoryImageModel();
                DataToModel(crudeProductCategoryImageBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductCategoryImageData.FetchAllCount();

        }
        
        public List<CrudeProductCategoryImageModel> FetchWithFilter(System.Guid productCategoryImageId, System.Guid productCategoryId, string productCategoryImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryImageModel>();
            List<CrudeProductCategoryImageData> dataList = CrudeProductCategoryImageData.FetchWithFilter(productCategoryImageId,productCategoryId,productCategoryImageTypeRcd,image,userId,dateTime);

            foreach (CrudeProductCategoryImageData data in dataList) {
                var crudeProductCategoryImageBusinessModel = new CrudeProductCategoryImageModel();
                DataToModel(data, crudeProductCategoryImageBusinessModel);
                list.Add(crudeProductCategoryImageBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryImageModel model) {
            var data = new CrudeProductCategoryImageData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductCategoryImageModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryImageData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductCategoryImageModel model) {
            var data = new CrudeProductCategoryImageData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductCategoryImageModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryImageData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productCategoryImageId) {
            CrudeProductCategoryImageData.Delete(productCategoryImageId);
        }
        
        public static void ModelToData(CrudeProductCategoryImageModel model, CrudeProductCategoryImageData data) {
            data.ProductCategoryImageId = model.ProductCategoryImageId;
            data.ProductCategoryId = model.ProductCategoryId;
            data.ProductCategoryImageTypeRcd = model.ProductCategoryImageTypeRcd;
            data.Image = model.Image;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductCategoryImageData data, CrudeProductCategoryImageModel model) {
            model.ProductCategoryImageId = data.ProductCategoryImageId;
            model.ProductCategoryId = data.ProductCategoryId;
            model.ProductCategoryImageTypeRcd = data.ProductCategoryImageTypeRcd;
            model.Image = data.Image;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
