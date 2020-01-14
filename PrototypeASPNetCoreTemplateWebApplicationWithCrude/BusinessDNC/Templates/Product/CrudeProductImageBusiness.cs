/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:48:00 AM
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
    
    
    public partial class CrudeProductImageBusiness {
        
        public CrudeProductImageModel FetchByProductImageId(System.Guid productImageId) {
            var dataAccessLayer = new CrudeProductImageData();
            var model = new CrudeProductImageModel();

            dataAccessLayer.FetchByProductImageId(productImageId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductImageModel FetchByImageFileName(string imageFileName) {
            var dataAccessLayer = new CrudeProductImageData();
            var model = new CrudeProductImageModel();

            dataAccessLayer.FetchByImageFileName(imageFileName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductImageModel> FetchByProductId(System.Guid productId) {
            return DataListToModelList(CrudeProductImageData.FetchByProductId(productId));
        }
        
        public List<CrudeProductImageModel> FetchByProductImageTypeRcd(string productImageTypeRcd) {
            return DataListToModelList(CrudeProductImageData.FetchByProductImageTypeRcd(productImageTypeRcd));
        }
        
        public List<CrudeProductImageModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductImageData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductImageModel> DataListToModelList(List<CrudeProductImageData> dataList) {
            var modelList = new List<CrudeProductImageModel>();

            foreach (CrudeProductImageData data in dataList) {
                var model = new CrudeProductImageModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductImageModel> modelList, List<CrudeProductImageData> dataList) {
            foreach (CrudeProductImageModel model in modelList) {
                var data = new CrudeProductImageData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductImageModel> FetchAll() {
            var list = new List<CrudeProductImageModel>();
            List<CrudeProductImageData> dataList = CrudeProductImageData.FetchAll();

            foreach (CrudeProductImageData crudeProductImageBusiness in dataList) {
                var model = new CrudeProductImageModel();
                DataToModel(crudeProductImageBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductImageModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductImageModel>();
            List<CrudeProductImageData> dataList = CrudeProductImageData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductImageData crudeProductImageBusiness in dataList) {
                var model = new CrudeProductImageModel();
                DataToModel(crudeProductImageBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductImageModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductImageModel>();
            List<CrudeProductImageData> dataList = CrudeProductImageData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductImageData crudeProductImageBusiness in dataList) {
                var model = new CrudeProductImageModel();
                DataToModel(crudeProductImageBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductImageData.FetchAllCount();

        }
        
        public List<CrudeProductImageModel> FetchWithFilter(System.Guid productImageId, System.Guid productId, string productImageTypeRcd, string imageFileName, byte[] image, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductImageModel>();
            List<CrudeProductImageData> dataList = CrudeProductImageData.FetchWithFilter(productImageId,productId,productImageTypeRcd,imageFileName,image,userId,dateTime);

            foreach (CrudeProductImageData data in dataList) {
                var crudeProductImageBusinessModel = new CrudeProductImageModel();
                DataToModel(data, crudeProductImageBusinessModel);
                list.Add(crudeProductImageBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductImageModel model) {
            var data = new CrudeProductImageData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductImageModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductImageData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductImageModel model) {
            var data = new CrudeProductImageData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductImageModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductImageData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productImageId) {
            CrudeProductImageData.Delete(productImageId);
        }
        
        public static void ModelToData(CrudeProductImageModel model, CrudeProductImageData data) {
            data.ProductImageId = model.ProductImageId;
            data.ProductId = model.ProductId;
            data.ProductImageTypeRcd = model.ProductImageTypeRcd;
            data.ImageFileName = model.ImageFileName;
            data.Image = model.Image;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductImageData data, CrudeProductImageModel model) {
            model.ProductImageId = data.ProductImageId;
            model.ProductId = data.ProductId;
            model.ProductImageTypeRcd = data.ProductImageTypeRcd;
            model.ImageFileName = data.ImageFileName;
            model.Image = data.Image;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
