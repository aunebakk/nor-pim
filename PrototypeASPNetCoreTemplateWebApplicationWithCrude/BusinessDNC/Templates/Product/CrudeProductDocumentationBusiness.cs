/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:26 AM
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
    
    
    public partial class CrudeProductDocumentationBusiness {
        
        public CrudeProductDocumentationModel FetchByProductDocumentationId(System.Guid productDocumentationId) {
            var dataAccessLayer = new CrudeProductDocumentationData();
            var model = new CrudeProductDocumentationModel();

            dataAccessLayer.FetchByProductDocumentationId(productDocumentationId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductDocumentationModel> FetchByProductId(System.Guid productId) {
            return DataListToModelList(CrudeProductDocumentationData.FetchByProductId(productId));
        }
        
        public List<CrudeProductDocumentationModel> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            return DataListToModelList(CrudeProductDocumentationData.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd));
        }
        
        public List<CrudeProductDocumentationModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductDocumentationData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductDocumentationModel> DataListToModelList(List<CrudeProductDocumentationData> dataList) {
            var modelList = new List<CrudeProductDocumentationModel>();

            foreach (CrudeProductDocumentationData data in dataList) {
                var model = new CrudeProductDocumentationModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductDocumentationModel> modelList, List<CrudeProductDocumentationData> dataList) {
            foreach (CrudeProductDocumentationModel model in modelList) {
                var data = new CrudeProductDocumentationData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductDocumentationModel> FetchAll() {
            var list = new List<CrudeProductDocumentationModel>();
            List<CrudeProductDocumentationData> dataList = CrudeProductDocumentationData.FetchAll();

            foreach (CrudeProductDocumentationData crudeProductDocumentationBusiness in dataList) {
                var model = new CrudeProductDocumentationModel();
                DataToModel(crudeProductDocumentationBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductDocumentationModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductDocumentationModel>();
            List<CrudeProductDocumentationData> dataList = CrudeProductDocumentationData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductDocumentationData crudeProductDocumentationBusiness in dataList) {
                var model = new CrudeProductDocumentationModel();
                DataToModel(crudeProductDocumentationBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductDocumentationModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductDocumentationModel>();
            List<CrudeProductDocumentationData> dataList = CrudeProductDocumentationData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductDocumentationData crudeProductDocumentationBusiness in dataList) {
                var model = new CrudeProductDocumentationModel();
                DataToModel(crudeProductDocumentationBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductDocumentationData.FetchAllCount();

        }
        
        public List<CrudeProductDocumentationModel> FetchWithFilter(System.Guid productDocumentationId, System.Guid productId, string productDocumentationTypeRcd, string documentation, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductDocumentationModel>();
            List<CrudeProductDocumentationData> dataList = CrudeProductDocumentationData.FetchWithFilter(productDocumentationId,productId,productDocumentationTypeRcd,documentation,userId,dateTime);

            foreach (CrudeProductDocumentationData data in dataList) {
                var crudeProductDocumentationBusinessModel = new CrudeProductDocumentationModel();
                DataToModel(data, crudeProductDocumentationBusinessModel);
                list.Add(crudeProductDocumentationBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductDocumentationModel model) {
            var data = new CrudeProductDocumentationData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductDocumentationModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductDocumentationData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductDocumentationModel model) {
            var data = new CrudeProductDocumentationData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductDocumentationModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductDocumentationData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productDocumentationId) {
            CrudeProductDocumentationData.Delete(productDocumentationId);
        }
        
        public static void ModelToData(CrudeProductDocumentationModel model, CrudeProductDocumentationData data) {
            data.ProductDocumentationId = model.ProductDocumentationId;
            data.ProductId = model.ProductId;
            data.ProductDocumentationTypeRcd = model.ProductDocumentationTypeRcd;
            data.Documentation = model.Documentation;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductDocumentationData data, CrudeProductDocumentationModel model) {
            model.ProductDocumentationId = data.ProductDocumentationId;
            model.ProductId = data.ProductId;
            model.ProductDocumentationTypeRcd = data.ProductDocumentationTypeRcd;
            model.Documentation = data.Documentation;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
