/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:25 AM
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
    
    
    public partial class CrudeProductAttributeBusiness {
        
        public CrudeProductAttributeModel FetchByProductAttributeId(System.Guid productAttributeId) {
            var dataAccessLayer = new CrudeProductAttributeData();
            var model = new CrudeProductAttributeModel();

            dataAccessLayer.FetchByProductAttributeId(productAttributeId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductAttributeModel> FetchByProductId(System.Guid productId) {
            return DataListToModelList(CrudeProductAttributeData.FetchByProductId(productId));
        }
        
        public List<CrudeProductAttributeModel> FetchByProductAttributeRcd(string productAttributeRcd) {
            return DataListToModelList(CrudeProductAttributeData.FetchByProductAttributeRcd(productAttributeRcd));
        }
        
        public List<CrudeProductAttributeModel> FetchByProductAttributeUnitRcd(string productAttributeUnitRcd) {
            return DataListToModelList(CrudeProductAttributeData.FetchByProductAttributeUnitRcd(productAttributeUnitRcd));
        }
        
        public List<CrudeProductAttributeModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductAttributeData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductAttributeModel> DataListToModelList(List<CrudeProductAttributeData> dataList) {
            var modelList = new List<CrudeProductAttributeModel>();

            foreach (CrudeProductAttributeData data in dataList) {
                var model = new CrudeProductAttributeModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductAttributeModel> modelList, List<CrudeProductAttributeData> dataList) {
            foreach (CrudeProductAttributeModel model in modelList) {
                var data = new CrudeProductAttributeData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductAttributeModel> FetchAll() {
            var list = new List<CrudeProductAttributeModel>();
            List<CrudeProductAttributeData> dataList = CrudeProductAttributeData.FetchAll();

            foreach (CrudeProductAttributeData crudeProductAttributeBusiness in dataList) {
                var model = new CrudeProductAttributeModel();
                DataToModel(crudeProductAttributeBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductAttributeModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductAttributeModel>();
            List<CrudeProductAttributeData> dataList = CrudeProductAttributeData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductAttributeData crudeProductAttributeBusiness in dataList) {
                var model = new CrudeProductAttributeModel();
                DataToModel(crudeProductAttributeBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductAttributeModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductAttributeModel>();
            List<CrudeProductAttributeData> dataList = CrudeProductAttributeData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductAttributeData crudeProductAttributeBusiness in dataList) {
                var model = new CrudeProductAttributeModel();
                DataToModel(crudeProductAttributeBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductAttributeData.FetchAllCount();

        }
        
        public List<CrudeProductAttributeModel> FetchWithFilter(System.Guid productAttributeId, System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, string value, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductAttributeModel>();
            List<CrudeProductAttributeData> dataList = CrudeProductAttributeData.FetchWithFilter(productAttributeId,productId,productAttributeRcd,productAttributeUnitRcd,value,userId,dateTime);

            foreach (CrudeProductAttributeData data in dataList) {
                var crudeProductAttributeBusinessModel = new CrudeProductAttributeModel();
                DataToModel(data, crudeProductAttributeBusinessModel);
                list.Add(crudeProductAttributeBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductAttributeModel model) {
            var data = new CrudeProductAttributeData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductAttributeModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductAttributeModel model) {
            var data = new CrudeProductAttributeData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductAttributeModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productAttributeId) {
            CrudeProductAttributeData.Delete(productAttributeId);
        }
        
        public static void ModelToData(CrudeProductAttributeModel model, CrudeProductAttributeData data) {
            data.ProductAttributeId = model.ProductAttributeId;
            data.ProductId = model.ProductId;
            data.ProductAttributeRcd = model.ProductAttributeRcd;
            data.ProductAttributeUnitRcd = model.ProductAttributeUnitRcd;
            data.Value = model.Value;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductAttributeData data, CrudeProductAttributeModel model) {
            model.ProductAttributeId = data.ProductAttributeId;
            model.ProductId = data.ProductId;
            model.ProductAttributeRcd = data.ProductAttributeRcd;
            model.ProductAttributeUnitRcd = data.ProductAttributeUnitRcd;
            model.Value = data.Value;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
