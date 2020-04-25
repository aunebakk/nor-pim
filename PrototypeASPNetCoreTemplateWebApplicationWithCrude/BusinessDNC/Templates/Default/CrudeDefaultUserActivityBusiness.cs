/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:45:42 AM
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
    
    
    public partial class CrudeDefaultUserActivityBusiness {
        
        public CrudeDefaultUserActivityModel FetchByDefaultUserActivityId(System.Guid defaultUserActivityId) {
            var dataAccessLayer = new CrudeDefaultUserActivityData();
            var model = new CrudeDefaultUserActivityModel();

            dataAccessLayer.FetchByDefaultUserActivityId(defaultUserActivityId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultUserActivityModel> FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd) {
            return DataListToModelList(CrudeDefaultUserActivityData.FetchByDefaultUserActivityTypeRcd(defaultUserActivityTypeRcd));
        }
        
        public List<CrudeDefaultUserActivityModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultUserActivityData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultUserActivityModel> DataListToModelList(List<CrudeDefaultUserActivityData> dataList) {
            var modelList = new List<CrudeDefaultUserActivityModel>();

            foreach (CrudeDefaultUserActivityData data in dataList) {
                var model = new CrudeDefaultUserActivityModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultUserActivityModel> modelList, List<CrudeDefaultUserActivityData> dataList) {
            foreach (CrudeDefaultUserActivityModel model in modelList) {
                var data = new CrudeDefaultUserActivityData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultUserActivityModel> FetchAll() {
            var list = new List<CrudeDefaultUserActivityModel>();
            List<CrudeDefaultUserActivityData> dataList = CrudeDefaultUserActivityData.FetchAll();

            foreach (CrudeDefaultUserActivityData crudeDefaultUserActivityBusiness in dataList) {
                var model = new CrudeDefaultUserActivityModel();
                DataToModel(crudeDefaultUserActivityBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultUserActivityModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultUserActivityModel>();
            List<CrudeDefaultUserActivityData> dataList = CrudeDefaultUserActivityData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultUserActivityData crudeDefaultUserActivityBusiness in dataList) {
                var model = new CrudeDefaultUserActivityModel();
                DataToModel(crudeDefaultUserActivityBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultUserActivityModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultUserActivityModel>();
            List<CrudeDefaultUserActivityData> dataList = CrudeDefaultUserActivityData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultUserActivityData crudeDefaultUserActivityBusiness in dataList) {
                var model = new CrudeDefaultUserActivityModel();
                DataToModel(crudeDefaultUserActivityBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultUserActivityData.FetchAllCount();

        }
        
        public List<CrudeDefaultUserActivityModel> FetchWithFilter(System.Guid defaultUserActivityId, string defaultUserActivityTypeRcd, string userActivityNote, string originatingAddress, string referrer, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultUserActivityModel>();
            List<CrudeDefaultUserActivityData> dataList = CrudeDefaultUserActivityData.FetchWithFilter(defaultUserActivityId,defaultUserActivityTypeRcd,userActivityNote,originatingAddress,referrer,defaultUserId,dateTime);

            foreach (CrudeDefaultUserActivityData data in dataList) {
                var crudeDefaultUserActivityBusinessModel = new CrudeDefaultUserActivityModel();
                DataToModel(data, crudeDefaultUserActivityBusinessModel);
                list.Add(crudeDefaultUserActivityBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultUserActivityModel model) {
            var data = new CrudeDefaultUserActivityData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultUserActivityModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserActivityData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultUserActivityModel model) {
            var data = new CrudeDefaultUserActivityData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultUserActivityModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserActivityData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultUserActivityId) {
            CrudeDefaultUserActivityData.Delete(defaultUserActivityId);
        }
        
        public static void ModelToData(CrudeDefaultUserActivityModel model, CrudeDefaultUserActivityData data) {
            data.DefaultUserActivityId = model.DefaultUserActivityId;
            data.DefaultUserActivityTypeRcd = model.DefaultUserActivityTypeRcd;
            data.UserActivityNote = model.UserActivityNote;
            data.OriginatingAddress = model.OriginatingAddress;
            data.Referrer = model.Referrer;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultUserActivityData data, CrudeDefaultUserActivityModel model) {
            model.DefaultUserActivityId = data.DefaultUserActivityId;
            model.DefaultUserActivityTypeRcd = data.DefaultUserActivityTypeRcd;
            model.UserActivityNote = data.UserActivityNote;
            model.OriginatingAddress = data.OriginatingAddress;
            model.Referrer = data.Referrer;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
