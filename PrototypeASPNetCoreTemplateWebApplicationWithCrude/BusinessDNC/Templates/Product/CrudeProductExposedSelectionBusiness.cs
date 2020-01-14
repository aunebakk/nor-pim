/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:46:30 AM
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
    
    
    public partial class CrudeProductExposedSelectionBusiness {
        
        public CrudeProductExposedSelectionModel FetchByProductExposedSelectionId(System.Guid productExposedSelectionId) {
            var dataAccessLayer = new CrudeProductExposedSelectionData();
            var model = new CrudeProductExposedSelectionModel();

            dataAccessLayer.FetchByProductExposedSelectionId(productExposedSelectionId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductExposedSelectionModel> FetchByProductExposeId(System.Guid productExposeId) {
            return DataListToModelList(CrudeProductExposedSelectionData.FetchByProductExposeId(productExposeId));
        }
        
        public List<CrudeProductExposedSelectionModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductExposedSelectionData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductExposedSelectionModel> DataListToModelList(List<CrudeProductExposedSelectionData> dataList) {
            var modelList = new List<CrudeProductExposedSelectionModel>();

            foreach (CrudeProductExposedSelectionData data in dataList) {
                var model = new CrudeProductExposedSelectionModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductExposedSelectionModel> modelList, List<CrudeProductExposedSelectionData> dataList) {
            foreach (CrudeProductExposedSelectionModel model in modelList) {
                var data = new CrudeProductExposedSelectionData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductExposedSelectionModel> FetchAll() {
            var list = new List<CrudeProductExposedSelectionModel>();
            List<CrudeProductExposedSelectionData> dataList = CrudeProductExposedSelectionData.FetchAll();

            foreach (CrudeProductExposedSelectionData crudeProductExposedSelectionBusiness in dataList) {
                var model = new CrudeProductExposedSelectionModel();
                DataToModel(crudeProductExposedSelectionBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductExposedSelectionModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductExposedSelectionModel>();
            List<CrudeProductExposedSelectionData> dataList = CrudeProductExposedSelectionData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductExposedSelectionData crudeProductExposedSelectionBusiness in dataList) {
                var model = new CrudeProductExposedSelectionModel();
                DataToModel(crudeProductExposedSelectionBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductExposedSelectionModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductExposedSelectionModel>();
            List<CrudeProductExposedSelectionData> dataList = CrudeProductExposedSelectionData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductExposedSelectionData crudeProductExposedSelectionBusiness in dataList) {
                var model = new CrudeProductExposedSelectionModel();
                DataToModel(crudeProductExposedSelectionBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductExposedSelectionData.FetchAllCount();

        }
        
        public List<CrudeProductExposedSelectionModel> FetchWithFilter(System.Guid productExposedSelectionId, System.Guid productExposeId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposedSelectionModel>();
            List<CrudeProductExposedSelectionData> dataList = CrudeProductExposedSelectionData.FetchWithFilter(productExposedSelectionId,productExposeId,userId,dateTime);

            foreach (CrudeProductExposedSelectionData data in dataList) {
                var crudeProductExposedSelectionBusinessModel = new CrudeProductExposedSelectionModel();
                DataToModel(data, crudeProductExposedSelectionBusinessModel);
                list.Add(crudeProductExposedSelectionBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductExposedSelectionModel model) {
            var data = new CrudeProductExposedSelectionData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductExposedSelectionModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposedSelectionData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductExposedSelectionModel model) {
            var data = new CrudeProductExposedSelectionData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductExposedSelectionModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposedSelectionData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productExposedSelectionId) {
            CrudeProductExposedSelectionData.Delete(productExposedSelectionId);
        }
        
        public static void ModelToData(CrudeProductExposedSelectionModel model, CrudeProductExposedSelectionData data) {
            data.ProductExposedSelectionId = model.ProductExposedSelectionId;
            data.ProductExposeId = model.ProductExposeId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductExposedSelectionData data, CrudeProductExposedSelectionModel model) {
            model.ProductExposedSelectionId = data.ProductExposedSelectionId;
            model.ProductExposeId = data.ProductExposeId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
