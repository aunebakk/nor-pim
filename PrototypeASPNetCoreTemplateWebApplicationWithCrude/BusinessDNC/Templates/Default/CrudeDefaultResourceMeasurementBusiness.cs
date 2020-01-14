/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:29:02 AM
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
    
    
    public partial class CrudeDefaultResourceMeasurementBusiness {
        
        public CrudeDefaultResourceMeasurementModel FetchByDefaultResourceMeasurementId(System.Guid defaultResourceMeasurementId) {
            var dataAccessLayer = new CrudeDefaultResourceMeasurementData();
            var model = new CrudeDefaultResourceMeasurementModel();

            dataAccessLayer.FetchByDefaultResourceMeasurementId(defaultResourceMeasurementId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultResourceMeasurementModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultResourceMeasurementData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultResourceMeasurementModel> DataListToModelList(List<CrudeDefaultResourceMeasurementData> dataList) {
            var modelList = new List<CrudeDefaultResourceMeasurementModel>();

            foreach (CrudeDefaultResourceMeasurementData data in dataList) {
                var model = new CrudeDefaultResourceMeasurementModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultResourceMeasurementModel> modelList, List<CrudeDefaultResourceMeasurementData> dataList) {
            foreach (CrudeDefaultResourceMeasurementModel model in modelList) {
                var data = new CrudeDefaultResourceMeasurementData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultResourceMeasurementModel> FetchAll() {
            var list = new List<CrudeDefaultResourceMeasurementModel>();
            List<CrudeDefaultResourceMeasurementData> dataList = CrudeDefaultResourceMeasurementData.FetchAll();

            foreach (CrudeDefaultResourceMeasurementData crudeDefaultResourceMeasurementBusiness in dataList) {
                var model = new CrudeDefaultResourceMeasurementModel();
                DataToModel(crudeDefaultResourceMeasurementBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultResourceMeasurementModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultResourceMeasurementModel>();
            List<CrudeDefaultResourceMeasurementData> dataList = CrudeDefaultResourceMeasurementData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultResourceMeasurementData crudeDefaultResourceMeasurementBusiness in dataList) {
                var model = new CrudeDefaultResourceMeasurementModel();
                DataToModel(crudeDefaultResourceMeasurementBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultResourceMeasurementModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultResourceMeasurementModel>();
            List<CrudeDefaultResourceMeasurementData> dataList = CrudeDefaultResourceMeasurementData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultResourceMeasurementData crudeDefaultResourceMeasurementBusiness in dataList) {
                var model = new CrudeDefaultResourceMeasurementModel();
                DataToModel(crudeDefaultResourceMeasurementBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultResourceMeasurementData.FetchAllCount();

        }
        
        public List<CrudeDefaultResourceMeasurementModel> FetchWithFilter(System.Guid defaultResourceMeasurementId, int clientWorkingsetBytes, int businessWorkingsetBytes, int databaseSizeBytes, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultResourceMeasurementModel>();
            List<CrudeDefaultResourceMeasurementData> dataList = CrudeDefaultResourceMeasurementData.FetchWithFilter(defaultResourceMeasurementId,clientWorkingsetBytes,businessWorkingsetBytes,databaseSizeBytes,defaultUserId,dateTime);

            foreach (CrudeDefaultResourceMeasurementData data in dataList) {
                var crudeDefaultResourceMeasurementBusinessModel = new CrudeDefaultResourceMeasurementModel();
                DataToModel(data, crudeDefaultResourceMeasurementBusinessModel);
                list.Add(crudeDefaultResourceMeasurementBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultResourceMeasurementModel model) {
            var data = new CrudeDefaultResourceMeasurementData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultResourceMeasurementModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultResourceMeasurementData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultResourceMeasurementModel model) {
            var data = new CrudeDefaultResourceMeasurementData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultResourceMeasurementModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultResourceMeasurementData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultResourceMeasurementId) {
            CrudeDefaultResourceMeasurementData.Delete(defaultResourceMeasurementId);
        }
        
        public static void ModelToData(CrudeDefaultResourceMeasurementModel model, CrudeDefaultResourceMeasurementData data) {
            data.DefaultResourceMeasurementId = model.DefaultResourceMeasurementId;
            data.ClientWorkingsetBytes = model.ClientWorkingsetBytes;
            data.BusinessWorkingsetBytes = model.BusinessWorkingsetBytes;
            data.DatabaseSizeBytes = model.DatabaseSizeBytes;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultResourceMeasurementData data, CrudeDefaultResourceMeasurementModel model) {
            model.DefaultResourceMeasurementId = data.DefaultResourceMeasurementId;
            model.ClientWorkingsetBytes = data.ClientWorkingsetBytes;
            model.BusinessWorkingsetBytes = data.BusinessWorkingsetBytes;
            model.DatabaseSizeBytes = data.DatabaseSizeBytes;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
