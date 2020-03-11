/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:39:39 PM
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
    
    
    public partial class CrudeProductGatherBusiness {
        
        public CrudeProductGatherModel FetchByProductGatherId(System.Guid productGatherId) {
            var dataAccessLayer = new CrudeProductGatherData();
            var model = new CrudeProductGatherModel();

            dataAccessLayer.FetchByProductGatherId(productGatherId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductGatherModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductGatherData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherModel> DataListToModelList(List<CrudeProductGatherData> dataList) {
            var modelList = new List<CrudeProductGatherModel>();

            foreach (CrudeProductGatherData data in dataList) {
                var model = new CrudeProductGatherModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductGatherModel> modelList, List<CrudeProductGatherData> dataList) {
            foreach (CrudeProductGatherModel model in modelList) {
                var data = new CrudeProductGatherData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherModel> FetchAll() {
            var list = new List<CrudeProductGatherModel>();
            List<CrudeProductGatherData> dataList = CrudeProductGatherData.FetchAll();

            foreach (CrudeProductGatherData crudeProductGatherBusiness in dataList) {
                var model = new CrudeProductGatherModel();
                DataToModel(crudeProductGatherBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductGatherModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductGatherModel>();
            List<CrudeProductGatherData> dataList = CrudeProductGatherData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductGatherData crudeProductGatherBusiness in dataList) {
                var model = new CrudeProductGatherModel();
                DataToModel(crudeProductGatherBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductGatherModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductGatherModel>();
            List<CrudeProductGatherData> dataList = CrudeProductGatherData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductGatherData crudeProductGatherBusiness in dataList) {
                var model = new CrudeProductGatherModel();
                DataToModel(crudeProductGatherBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductGatherData.FetchAllCount();

        }
        
        public List<CrudeProductGatherModel> FetchWithFilter(System.Guid productGatherId, System.DateTime startDateTime, System.DateTime finishDateTime, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherModel>();
            List<CrudeProductGatherData> dataList = CrudeProductGatherData.FetchWithFilter(productGatherId,startDateTime,finishDateTime,userId,dateTime);

            foreach (CrudeProductGatherData data in dataList) {
                var crudeProductGatherBusinessModel = new CrudeProductGatherModel();
                DataToModel(data, crudeProductGatherBusinessModel);
                list.Add(crudeProductGatherBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherModel model) {
            var data = new CrudeProductGatherData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductGatherModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductGatherModel model) {
            var data = new CrudeProductGatherData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductGatherModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productGatherId) {
            CrudeProductGatherData.Delete(productGatherId);
        }
        
        public static void ModelToData(CrudeProductGatherModel model, CrudeProductGatherData data) {
            data.ProductGatherId = model.ProductGatherId;
            data.StartDateTime = model.StartDateTime;
            data.FinishDateTime = model.FinishDateTime;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductGatherData data, CrudeProductGatherModel model) {
            model.ProductGatherId = data.ProductGatherId;
            model.StartDateTime = data.StartDateTime;
            model.FinishDateTime = data.FinishDateTime;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
