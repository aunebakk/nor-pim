/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:36 PM
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
    
    
    public partial class CrudeDefaultPerformanceTimeBusiness {
        
        public CrudeDefaultPerformanceTimeModel FetchByDefaultPerformanceTimeId(System.Guid defaultPerformanceTimeId) {
            var dataAccessLayer = new CrudeDefaultPerformanceTimeData();
            var model = new CrudeDefaultPerformanceTimeModel();

            dataAccessLayer.FetchByDefaultPerformanceTimeId(defaultPerformanceTimeId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultPerformanceTimeModel FetchByCommandName(string commandName) {
            var dataAccessLayer = new CrudeDefaultPerformanceTimeData();
            var model = new CrudeDefaultPerformanceTimeModel();

            dataAccessLayer.FetchByCommandName(commandName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultPerformanceTimeModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultPerformanceTimeData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultPerformanceTimeModel> DataListToModelList(List<CrudeDefaultPerformanceTimeData> dataList) {
            var modelList = new List<CrudeDefaultPerformanceTimeModel>();

            foreach (CrudeDefaultPerformanceTimeData data in dataList) {
                var model = new CrudeDefaultPerformanceTimeModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultPerformanceTimeModel> modelList, List<CrudeDefaultPerformanceTimeData> dataList) {
            foreach (CrudeDefaultPerformanceTimeModel model in modelList) {
                var data = new CrudeDefaultPerformanceTimeData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultPerformanceTimeModel> FetchAll() {
            var list = new List<CrudeDefaultPerformanceTimeModel>();
            List<CrudeDefaultPerformanceTimeData> dataList = CrudeDefaultPerformanceTimeData.FetchAll();

            foreach (CrudeDefaultPerformanceTimeData crudeDefaultPerformanceTimeBusiness in dataList) {
                var model = new CrudeDefaultPerformanceTimeModel();
                DataToModel(crudeDefaultPerformanceTimeBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultPerformanceTimeModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultPerformanceTimeModel>();
            List<CrudeDefaultPerformanceTimeData> dataList = CrudeDefaultPerformanceTimeData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultPerformanceTimeData crudeDefaultPerformanceTimeBusiness in dataList) {
                var model = new CrudeDefaultPerformanceTimeModel();
                DataToModel(crudeDefaultPerformanceTimeBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultPerformanceTimeModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultPerformanceTimeModel>();
            List<CrudeDefaultPerformanceTimeData> dataList = CrudeDefaultPerformanceTimeData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultPerformanceTimeData crudeDefaultPerformanceTimeBusiness in dataList) {
                var model = new CrudeDefaultPerformanceTimeModel();
                DataToModel(crudeDefaultPerformanceTimeBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultPerformanceTimeData.FetchAllCount();

        }
        
        public List<CrudeDefaultPerformanceTimeModel> FetchWithFilter(System.Guid defaultPerformanceTimeId, string commandName, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultPerformanceTimeModel>();
            List<CrudeDefaultPerformanceTimeData> dataList = CrudeDefaultPerformanceTimeData.FetchWithFilter(defaultPerformanceTimeId,commandName,milliseconds,defaultUserId,dateTime);

            foreach (CrudeDefaultPerformanceTimeData data in dataList) {
                var crudeDefaultPerformanceTimeBusinessModel = new CrudeDefaultPerformanceTimeModel();
                DataToModel(data, crudeDefaultPerformanceTimeBusinessModel);
                list.Add(crudeDefaultPerformanceTimeBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultPerformanceTimeModel model) {
            var data = new CrudeDefaultPerformanceTimeData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultPerformanceTimeModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceTimeData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultPerformanceTimeModel model) {
            var data = new CrudeDefaultPerformanceTimeData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultPerformanceTimeModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceTimeData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultPerformanceTimeId) {
            CrudeDefaultPerformanceTimeData.Delete(defaultPerformanceTimeId);
        }
        
        public static void ModelToData(CrudeDefaultPerformanceTimeModel model, CrudeDefaultPerformanceTimeData data) {
            data.DefaultPerformanceTimeId = model.DefaultPerformanceTimeId;
            data.CommandName = model.CommandName;
            data.Milliseconds = model.Milliseconds;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultPerformanceTimeData data, CrudeDefaultPerformanceTimeModel model) {
            model.DefaultPerformanceTimeId = data.DefaultPerformanceTimeId;
            model.CommandName = data.CommandName;
            model.Milliseconds = data.Milliseconds;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
