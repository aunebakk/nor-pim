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
    
    
    public partial class CrudeProductExposeBusiness {
        
        public CrudeProductExposeModel FetchByProductExposeId(System.Guid productExposeId) {
            var dataAccessLayer = new CrudeProductExposeData();
            var model = new CrudeProductExposeModel();

            dataAccessLayer.FetchByProductExposeId(productExposeId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductExposeModel> FetchByExposeProductId(System.Guid exposeProductId) {
            return DataListToModelList(CrudeProductExposeData.FetchByExposeProductId(exposeProductId));
        }
        
        public List<CrudeProductExposeModel> FetchByExposeBasedOnProductId(System.Guid exposeBasedOnProductId) {
            return DataListToModelList(CrudeProductExposeData.FetchByExposeBasedOnProductId(exposeBasedOnProductId));
        }
        
        public List<CrudeProductExposeModel> FetchByProductExposeSetId(System.Guid productExposeSetId) {
            return DataListToModelList(CrudeProductExposeData.FetchByProductExposeSetId(productExposeSetId));
        }
        
        public List<CrudeProductExposeModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductExposeData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductExposeModel> DataListToModelList(List<CrudeProductExposeData> dataList) {
            var modelList = new List<CrudeProductExposeModel>();

            foreach (CrudeProductExposeData data in dataList) {
                var model = new CrudeProductExposeModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductExposeModel> modelList, List<CrudeProductExposeData> dataList) {
            foreach (CrudeProductExposeModel model in modelList) {
                var data = new CrudeProductExposeData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductExposeModel> FetchAll() {
            var list = new List<CrudeProductExposeModel>();
            List<CrudeProductExposeData> dataList = CrudeProductExposeData.FetchAll();

            foreach (CrudeProductExposeData crudeProductExposeBusiness in dataList) {
                var model = new CrudeProductExposeModel();
                DataToModel(crudeProductExposeBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductExposeModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductExposeModel>();
            List<CrudeProductExposeData> dataList = CrudeProductExposeData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductExposeData crudeProductExposeBusiness in dataList) {
                var model = new CrudeProductExposeModel();
                DataToModel(crudeProductExposeBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductExposeModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductExposeModel>();
            List<CrudeProductExposeData> dataList = CrudeProductExposeData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductExposeData crudeProductExposeBusiness in dataList) {
                var model = new CrudeProductExposeModel();
                DataToModel(crudeProductExposeBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductExposeData.FetchAllCount();

        }
        
        public List<CrudeProductExposeModel> FetchWithFilter(System.Guid productExposeId, System.Guid exposeProductId, System.Guid exposeBasedOnProductId, System.Guid productExposeSetId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposeModel>();
            List<CrudeProductExposeData> dataList = CrudeProductExposeData.FetchWithFilter(productExposeId,exposeProductId,exposeBasedOnProductId,productExposeSetId,userId,dateTime);

            foreach (CrudeProductExposeData data in dataList) {
                var crudeProductExposeBusinessModel = new CrudeProductExposeModel();
                DataToModel(data, crudeProductExposeBusinessModel);
                list.Add(crudeProductExposeBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductExposeModel model) {
            var data = new CrudeProductExposeData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductExposeModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductExposeModel model) {
            var data = new CrudeProductExposeData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductExposeModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productExposeId) {
            CrudeProductExposeData.Delete(productExposeId);
        }
        
        public static void ModelToData(CrudeProductExposeModel model, CrudeProductExposeData data) {
            data.ProductExposeId = model.ProductExposeId;
            data.ExposeProductId = model.ExposeProductId;
            data.ExposeBasedOnProductId = model.ExposeBasedOnProductId;
            data.ProductExposeSetId = model.ProductExposeSetId;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductExposeData data, CrudeProductExposeModel model) {
            model.ProductExposeId = data.ProductExposeId;
            model.ExposeProductId = data.ExposeProductId;
            model.ExposeBasedOnProductId = data.ExposeBasedOnProductId;
            model.ProductExposeSetId = data.ProductExposeSetId;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
