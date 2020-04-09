/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:26:54 AM
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
    
    
    public partial class CrudeProductGatherAttributeBusiness {
        
        public CrudeProductGatherAttributeModel FetchByProductGatherAttributeId(System.Guid productGatherAttributeId) {
            var dataAccessLayer = new CrudeProductGatherAttributeData();
            var model = new CrudeProductGatherAttributeModel();

            dataAccessLayer.FetchByProductGatherAttributeId(productGatherAttributeId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductGatherAttributeModel> FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd) {
            return DataListToModelList(CrudeProductGatherAttributeData.FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd));
        }
        
        public List<CrudeProductGatherAttributeModel> FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            return DataListToModelList(CrudeProductGatherAttributeData.FetchByProductGatherKeyId(productGatherKeyId));
        }
        
        public List<CrudeProductGatherAttributeModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductGatherAttributeData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherAttributeModel> DataListToModelList(List<CrudeProductGatherAttributeData> dataList) {
            var modelList = new List<CrudeProductGatherAttributeModel>();

            foreach (CrudeProductGatherAttributeData data in dataList) {
                var model = new CrudeProductGatherAttributeModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductGatherAttributeModel> modelList, List<CrudeProductGatherAttributeData> dataList) {
            foreach (CrudeProductGatherAttributeModel model in modelList) {
                var data = new CrudeProductGatherAttributeData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherAttributeModel> FetchAll() {
            var list = new List<CrudeProductGatherAttributeModel>();
            List<CrudeProductGatherAttributeData> dataList = CrudeProductGatherAttributeData.FetchAll();

            foreach (CrudeProductGatherAttributeData crudeProductGatherAttributeBusiness in dataList) {
                var model = new CrudeProductGatherAttributeModel();
                DataToModel(crudeProductGatherAttributeBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductGatherAttributeModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductGatherAttributeModel>();
            List<CrudeProductGatherAttributeData> dataList = CrudeProductGatherAttributeData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductGatherAttributeData crudeProductGatherAttributeBusiness in dataList) {
                var model = new CrudeProductGatherAttributeModel();
                DataToModel(crudeProductGatherAttributeBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductGatherAttributeModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductGatherAttributeModel>();
            List<CrudeProductGatherAttributeData> dataList = CrudeProductGatherAttributeData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductGatherAttributeData crudeProductGatherAttributeBusiness in dataList) {
                var model = new CrudeProductGatherAttributeModel();
                DataToModel(crudeProductGatherAttributeBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductGatherAttributeData.FetchAllCount();

        }
        
        public List<CrudeProductGatherAttributeModel> FetchWithFilter(System.Guid productGatherAttributeId, string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherAttributeModel>();
            List<CrudeProductGatherAttributeData> dataList = CrudeProductGatherAttributeData.FetchWithFilter(productGatherAttributeId,productGatherAttributeValue,productGatherAttributeTypeRcd,productGatherKeyId,userId,dateTime);

            foreach (CrudeProductGatherAttributeData data in dataList) {
                var crudeProductGatherAttributeBusinessModel = new CrudeProductGatherAttributeModel();
                DataToModel(data, crudeProductGatherAttributeBusinessModel);
                list.Add(crudeProductGatherAttributeBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherAttributeModel model) {
            var data = new CrudeProductGatherAttributeData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductGatherAttributeModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherAttributeData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductGatherAttributeModel model) {
            var data = new CrudeProductGatherAttributeData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductGatherAttributeModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherAttributeData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productGatherAttributeId) {
            CrudeProductGatherAttributeData.Delete(productGatherAttributeId);
        }
        
        public static void ModelToData(CrudeProductGatherAttributeModel model, CrudeProductGatherAttributeData data) {
            data.ProductGatherAttributeId = model.ProductGatherAttributeId;
            data.ProductGatherAttributeValue = model.ProductGatherAttributeValue;
            data.ProductGatherAttributeTypeRcd = model.ProductGatherAttributeTypeRcd;
            data.ProductGatherKeyId = model.ProductGatherKeyId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductGatherAttributeData data, CrudeProductGatherAttributeModel model) {
            model.ProductGatherAttributeId = data.ProductGatherAttributeId;
            model.ProductGatherAttributeValue = data.ProductGatherAttributeValue;
            model.ProductGatherAttributeTypeRcd = data.ProductGatherAttributeTypeRcd;
            model.ProductGatherKeyId = data.ProductGatherKeyId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
