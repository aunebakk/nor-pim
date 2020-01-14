/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:22:59 PM
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
    
    
    public partial class CrudeProductCategoryDocumentationBusiness {
        
        public CrudeProductCategoryDocumentationModel FetchByProductCategoryDocumentationId(System.Guid productCategoryDocumentationId) {
            var dataAccessLayer = new CrudeProductCategoryDocumentationData();
            var model = new CrudeProductCategoryDocumentationModel();

            dataAccessLayer.FetchByProductCategoryDocumentationId(productCategoryDocumentationId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductCategoryDocumentationModel> FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd) {
            return DataListToModelList(CrudeProductCategoryDocumentationData.FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd));
        }
        
        public List<CrudeProductCategoryDocumentationModel> FetchByProductCategoryId(System.Guid productCategoryId) {
            return DataListToModelList(CrudeProductCategoryDocumentationData.FetchByProductCategoryId(productCategoryId));
        }
        
        public List<CrudeProductCategoryDocumentationModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductCategoryDocumentationData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductCategoryDocumentationModel> DataListToModelList(List<CrudeProductCategoryDocumentationData> dataList) {
            var modelList = new List<CrudeProductCategoryDocumentationModel>();

            foreach (CrudeProductCategoryDocumentationData data in dataList) {
                var model = new CrudeProductCategoryDocumentationModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductCategoryDocumentationModel> modelList, List<CrudeProductCategoryDocumentationData> dataList) {
            foreach (CrudeProductCategoryDocumentationModel model in modelList) {
                var data = new CrudeProductCategoryDocumentationData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryDocumentationModel> FetchAll() {
            var list = new List<CrudeProductCategoryDocumentationModel>();
            List<CrudeProductCategoryDocumentationData> dataList = CrudeProductCategoryDocumentationData.FetchAll();

            foreach (CrudeProductCategoryDocumentationData crudeProductCategoryDocumentationBusiness in dataList) {
                var model = new CrudeProductCategoryDocumentationModel();
                DataToModel(crudeProductCategoryDocumentationBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductCategoryDocumentationModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductCategoryDocumentationModel>();
            List<CrudeProductCategoryDocumentationData> dataList = CrudeProductCategoryDocumentationData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductCategoryDocumentationData crudeProductCategoryDocumentationBusiness in dataList) {
                var model = new CrudeProductCategoryDocumentationModel();
                DataToModel(crudeProductCategoryDocumentationBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductCategoryDocumentationModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductCategoryDocumentationModel>();
            List<CrudeProductCategoryDocumentationData> dataList = CrudeProductCategoryDocumentationData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductCategoryDocumentationData crudeProductCategoryDocumentationBusiness in dataList) {
                var model = new CrudeProductCategoryDocumentationModel();
                DataToModel(crudeProductCategoryDocumentationBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductCategoryDocumentationData.FetchAllCount();

        }
        
        public List<CrudeProductCategoryDocumentationModel> FetchWithFilter(System.Guid productCategoryDocumentationId, string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryDocumentationModel>();
            List<CrudeProductCategoryDocumentationData> dataList = CrudeProductCategoryDocumentationData.FetchWithFilter(productCategoryDocumentationId,productCategoryDocumentationTypeRcd,productCategoryId,documentation,userId,dateTime);

            foreach (CrudeProductCategoryDocumentationData data in dataList) {
                var crudeProductCategoryDocumentationBusinessModel = new CrudeProductCategoryDocumentationModel();
                DataToModel(data, crudeProductCategoryDocumentationBusinessModel);
                list.Add(crudeProductCategoryDocumentationBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryDocumentationModel model) {
            var data = new CrudeProductCategoryDocumentationData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductCategoryDocumentationModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryDocumentationData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductCategoryDocumentationModel model) {
            var data = new CrudeProductCategoryDocumentationData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductCategoryDocumentationModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryDocumentationData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productCategoryDocumentationId) {
            CrudeProductCategoryDocumentationData.Delete(productCategoryDocumentationId);
        }
        
        public static void ModelToData(CrudeProductCategoryDocumentationModel model, CrudeProductCategoryDocumentationData data) {
            data.ProductCategoryDocumentationId = model.ProductCategoryDocumentationId;
            data.ProductCategoryDocumentationTypeRcd = model.ProductCategoryDocumentationTypeRcd;
            data.ProductCategoryId = model.ProductCategoryId;
            data.Documentation = model.Documentation;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductCategoryDocumentationData data, CrudeProductCategoryDocumentationModel model) {
            model.ProductCategoryDocumentationId = data.ProductCategoryDocumentationId;
            model.ProductCategoryDocumentationTypeRcd = data.ProductCategoryDocumentationTypeRcd;
            model.ProductCategoryId = data.ProductCategoryId;
            model.Documentation = data.Documentation;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
