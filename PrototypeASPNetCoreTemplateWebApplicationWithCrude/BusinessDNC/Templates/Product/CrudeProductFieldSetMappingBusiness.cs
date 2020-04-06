/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:51 PM
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
    
    
    public partial class CrudeProductFieldSetMappingBusiness {
        
        public CrudeProductFieldSetMappingModel FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId) {
            var dataAccessLayer = new CrudeProductFieldSetMappingData();
            var model = new CrudeProductFieldSetMappingModel();

            dataAccessLayer.FetchByProductFieldSetMappingId(productFieldSetMappingId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductFieldSetMappingModel> FetchByProductFieldSetId(System.Guid productFieldSetId) {
            return DataListToModelList(CrudeProductFieldSetMappingData.FetchByProductFieldSetId(productFieldSetId));
        }
        
        public List<CrudeProductFieldSetMappingModel> FetchByProductIdentifierRcd(string productIdentifierRcd) {
            return DataListToModelList(CrudeProductFieldSetMappingData.FetchByProductIdentifierRcd(productIdentifierRcd));
        }
        
        public List<CrudeProductFieldSetMappingModel> FetchByProductAttributeRcd(string productAttributeRcd) {
            return DataListToModelList(CrudeProductFieldSetMappingData.FetchByProductAttributeRcd(productAttributeRcd));
        }
        
        public List<CrudeProductFieldSetMappingModel> FetchByProductInfoRcd(string productInfoRcd) {
            return DataListToModelList(CrudeProductFieldSetMappingData.FetchByProductInfoRcd(productInfoRcd));
        }
        
        public List<CrudeProductFieldSetMappingModel> FetchByProductImageTypeRcd(string productImageTypeRcd) {
            return DataListToModelList(CrudeProductFieldSetMappingData.FetchByProductImageTypeRcd(productImageTypeRcd));
        }
        
        public List<CrudeProductFieldSetMappingModel> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            return DataListToModelList(CrudeProductFieldSetMappingData.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd));
        }
        
        public List<CrudeProductFieldSetMappingModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductFieldSetMappingData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductFieldSetMappingModel> DataListToModelList(List<CrudeProductFieldSetMappingData> dataList) {
            var modelList = new List<CrudeProductFieldSetMappingModel>();

            foreach (CrudeProductFieldSetMappingData data in dataList) {
                var model = new CrudeProductFieldSetMappingModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductFieldSetMappingModel> modelList, List<CrudeProductFieldSetMappingData> dataList) {
            foreach (CrudeProductFieldSetMappingModel model in modelList) {
                var data = new CrudeProductFieldSetMappingData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductFieldSetMappingModel> FetchAll() {
            var list = new List<CrudeProductFieldSetMappingModel>();
            List<CrudeProductFieldSetMappingData> dataList = CrudeProductFieldSetMappingData.FetchAll();

            foreach (CrudeProductFieldSetMappingData crudeProductFieldSetMappingBusiness in dataList) {
                var model = new CrudeProductFieldSetMappingModel();
                DataToModel(crudeProductFieldSetMappingBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductFieldSetMappingModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductFieldSetMappingModel>();
            List<CrudeProductFieldSetMappingData> dataList = CrudeProductFieldSetMappingData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductFieldSetMappingData crudeProductFieldSetMappingBusiness in dataList) {
                var model = new CrudeProductFieldSetMappingModel();
                DataToModel(crudeProductFieldSetMappingBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductFieldSetMappingModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductFieldSetMappingModel>();
            List<CrudeProductFieldSetMappingData> dataList = CrudeProductFieldSetMappingData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductFieldSetMappingData crudeProductFieldSetMappingBusiness in dataList) {
                var model = new CrudeProductFieldSetMappingModel();
                DataToModel(crudeProductFieldSetMappingBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductFieldSetMappingData.FetchAllCount();

        }
        
        public List<CrudeProductFieldSetMappingModel> FetchWithFilter(System.Guid productFieldSetMappingId, System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductFieldSetMappingModel>();
            List<CrudeProductFieldSetMappingData> dataList = CrudeProductFieldSetMappingData.FetchWithFilter(productFieldSetMappingId,productFieldSetId,productIdentifierRcd,productAttributeRcd,productInfoRcd,productImageTypeRcd,productDocumentationTypeRcd,userId,dateTime);

            foreach (CrudeProductFieldSetMappingData data in dataList) {
                var crudeProductFieldSetMappingBusinessModel = new CrudeProductFieldSetMappingModel();
                DataToModel(data, crudeProductFieldSetMappingBusinessModel);
                list.Add(crudeProductFieldSetMappingBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductFieldSetMappingModel model) {
            var data = new CrudeProductFieldSetMappingData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductFieldSetMappingModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductFieldSetMappingData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductFieldSetMappingModel model) {
            var data = new CrudeProductFieldSetMappingData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductFieldSetMappingModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductFieldSetMappingData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productFieldSetMappingId) {
            CrudeProductFieldSetMappingData.Delete(productFieldSetMappingId);
        }
        
        public static void ModelToData(CrudeProductFieldSetMappingModel model, CrudeProductFieldSetMappingData data) {
            data.ProductFieldSetMappingId = model.ProductFieldSetMappingId;
            data.ProductFieldSetId = model.ProductFieldSetId;
            data.ProductIdentifierRcd = model.ProductIdentifierRcd;
            data.ProductAttributeRcd = model.ProductAttributeRcd;
            data.ProductInfoRcd = model.ProductInfoRcd;
            data.ProductImageTypeRcd = model.ProductImageTypeRcd;
            data.ProductDocumentationTypeRcd = model.ProductDocumentationTypeRcd;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductFieldSetMappingData data, CrudeProductFieldSetMappingModel model) {
            model.ProductFieldSetMappingId = data.ProductFieldSetMappingId;
            model.ProductFieldSetId = data.ProductFieldSetId;
            model.ProductIdentifierRcd = data.ProductIdentifierRcd;
            model.ProductAttributeRcd = data.ProductAttributeRcd;
            model.ProductInfoRcd = data.ProductInfoRcd;
            model.ProductImageTypeRcd = data.ProductImageTypeRcd;
            model.ProductDocumentationTypeRcd = data.ProductDocumentationTypeRcd;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
