/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 7:01:24 AM
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
    
    
    public partial class CrudeProductCategoryDocumentationTypeRefBusiness {
        
        public CrudeProductCategoryDocumentationTypeRefModel FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd) {
            var dataAccessLayer = new CrudeProductCategoryDocumentationTypeRefData();
            var model = new CrudeProductCategoryDocumentationTypeRefModel();

            dataAccessLayer.FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductCategoryDocumentationTypeRefModel FetchByProductCategoryDocumentationTypeName(string productCategoryDocumentationTypeName) {
            var dataAccessLayer = new CrudeProductCategoryDocumentationTypeRefData();
            var model = new CrudeProductCategoryDocumentationTypeRefModel();

            dataAccessLayer.FetchByProductCategoryDocumentationTypeName(productCategoryDocumentationTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductCategoryDocumentationTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductCategoryDocumentationTypeRefModel> DataListToModelList(List<CrudeProductCategoryDocumentationTypeRefData> dataList) {
            var modelList = new List<CrudeProductCategoryDocumentationTypeRefModel>();

            foreach (CrudeProductCategoryDocumentationTypeRefData data in dataList) {
                var model = new CrudeProductCategoryDocumentationTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductCategoryDocumentationTypeRefModel> modelList, List<CrudeProductCategoryDocumentationTypeRefData> dataList) {
            foreach (CrudeProductCategoryDocumentationTypeRefModel model in modelList) {
                var data = new CrudeProductCategoryDocumentationTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefModel> FetchAll() {
            var list = new List<CrudeProductCategoryDocumentationTypeRefModel>();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = CrudeProductCategoryDocumentationTypeRefData.FetchAll();

            foreach (CrudeProductCategoryDocumentationTypeRefData crudeProductCategoryDocumentationTypeRefBusiness in dataList) {
                var model = new CrudeProductCategoryDocumentationTypeRefModel();
                DataToModel(crudeProductCategoryDocumentationTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductCategoryDocumentationTypeRefModel>();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = CrudeProductCategoryDocumentationTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductCategoryDocumentationTypeRefData crudeProductCategoryDocumentationTypeRefBusiness in dataList) {
                var model = new CrudeProductCategoryDocumentationTypeRefModel();
                DataToModel(crudeProductCategoryDocumentationTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductCategoryDocumentationTypeRefModel>();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = CrudeProductCategoryDocumentationTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductCategoryDocumentationTypeRefData crudeProductCategoryDocumentationTypeRefBusiness in dataList) {
                var model = new CrudeProductCategoryDocumentationTypeRefModel();
                DataToModel(crudeProductCategoryDocumentationTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductCategoryDocumentationTypeRefData.FetchAllCount();

        }
        
        public List<CrudeProductCategoryDocumentationTypeRefModel> FetchWithFilter(string productCategoryDocumentationTypeRcd, string productCategoryDocumentationTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryDocumentationTypeRefModel>();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = CrudeProductCategoryDocumentationTypeRefData.FetchWithFilter(productCategoryDocumentationTypeRcd,productCategoryDocumentationTypeName,userId,dateTime);

            foreach (CrudeProductCategoryDocumentationTypeRefData data in dataList) {
                var crudeProductCategoryDocumentationTypeRefBusinessModel = new CrudeProductCategoryDocumentationTypeRefModel();
                DataToModel(data, crudeProductCategoryDocumentationTypeRefBusinessModel);
                list.Add(crudeProductCategoryDocumentationTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryDocumentationTypeRefModel model) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductCategoryDocumentationTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductCategoryDocumentationTypeRefModel model) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductCategoryDocumentationTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productCategoryDocumentationTypeRcd) {
            CrudeProductCategoryDocumentationTypeRefData.Delete(productCategoryDocumentationTypeRcd);
        }
        
        public static void ModelToData(CrudeProductCategoryDocumentationTypeRefModel model, CrudeProductCategoryDocumentationTypeRefData data) {
            data.ProductCategoryDocumentationTypeRcd = model.ProductCategoryDocumentationTypeRcd;
            data.ProductCategoryDocumentationTypeName = model.ProductCategoryDocumentationTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductCategoryDocumentationTypeRefData data, CrudeProductCategoryDocumentationTypeRefModel model) {
            model.ProductCategoryDocumentationTypeRcd = data.ProductCategoryDocumentationTypeRcd;
            model.ProductCategoryDocumentationTypeName = data.ProductCategoryDocumentationTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
