/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:25 PM
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
    
    
    public partial class CrudeClientEventBusiness {
        
        public CrudeClientEventModel FetchByClientEventId(System.Guid clientEventId) {
            var dataAccessLayer = new CrudeClientEventData();
            var model = new CrudeClientEventModel();

            dataAccessLayer.FetchByClientEventId(clientEventId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientEventModel> FetchByClientId(System.Guid clientId) {
            return DataListToModelList(CrudeClientEventData.FetchByClientId(clientId));
        }
        
        public List<CrudeClientEventModel> FetchByClientEventTypeRcd(string clientEventTypeRcd) {
            return DataListToModelList(CrudeClientEventData.FetchByClientEventTypeRcd(clientEventTypeRcd));
        }
        
        public List<CrudeClientEventModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientEventData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientEventModel> DataListToModelList(List<CrudeClientEventData> dataList) {
            var modelList = new List<CrudeClientEventModel>();

            foreach (CrudeClientEventData data in dataList) {
                var model = new CrudeClientEventModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientEventModel> modelList, List<CrudeClientEventData> dataList) {
            foreach (CrudeClientEventModel model in modelList) {
                var data = new CrudeClientEventData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientEventModel> FetchAll() {
            var list = new List<CrudeClientEventModel>();
            List<CrudeClientEventData> dataList = CrudeClientEventData.FetchAll();

            foreach (CrudeClientEventData crudeClientEventBusiness in dataList) {
                var model = new CrudeClientEventModel();
                DataToModel(crudeClientEventBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientEventModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientEventModel>();
            List<CrudeClientEventData> dataList = CrudeClientEventData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientEventData crudeClientEventBusiness in dataList) {
                var model = new CrudeClientEventModel();
                DataToModel(crudeClientEventBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientEventModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientEventModel>();
            List<CrudeClientEventData> dataList = CrudeClientEventData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientEventData crudeClientEventBusiness in dataList) {
                var model = new CrudeClientEventModel();
                DataToModel(crudeClientEventBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientEventData.FetchAllCount();

        }
        
        public List<CrudeClientEventModel> FetchWithFilter(System.Guid clientEventId, System.Guid clientId, string clientEventTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientEventModel>();
            List<CrudeClientEventData> dataList = CrudeClientEventData.FetchWithFilter(clientEventId,clientId,clientEventTypeRcd,userId,dateTime);

            foreach (CrudeClientEventData data in dataList) {
                var crudeClientEventBusinessModel = new CrudeClientEventModel();
                DataToModel(data, crudeClientEventBusinessModel);
                list.Add(crudeClientEventBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientEventModel model) {
            var data = new CrudeClientEventData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientEventModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientEventData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientEventModel model) {
            var data = new CrudeClientEventData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientEventModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientEventData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid clientEventId) {
            CrudeClientEventData.Delete(clientEventId);
        }
        
        public static void ModelToData(CrudeClientEventModel model, CrudeClientEventData data) {
            data.ClientEventId = model.ClientEventId;
            data.ClientId = model.ClientId;
            data.ClientEventTypeRcd = model.ClientEventTypeRcd;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientEventData data, CrudeClientEventModel model) {
            model.ClientEventId = data.ClientEventId;
            model.ClientId = data.ClientId;
            model.ClientEventTypeRcd = data.ClientEventTypeRcd;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
