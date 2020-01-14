/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:24 PM
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
    
    
    public partial class CrudeDefaultPerformanceTimeRollupBusiness {
        
        public CrudeDefaultPerformanceTimeRollupModel FetchByDefaultPerformanceTimeRollupId(System.Guid defaultPerformanceTimeRollupId) {
            var dataAccessLayer = new CrudeDefaultPerformanceTimeRollupData();
            var model = new CrudeDefaultPerformanceTimeRollupModel();

            dataAccessLayer.FetchByDefaultPerformanceTimeRollupId(defaultPerformanceTimeRollupId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultPerformanceTimeRollupModel FetchByCommandName(string commandName) {
            var dataAccessLayer = new CrudeDefaultPerformanceTimeRollupData();
            var model = new CrudeDefaultPerformanceTimeRollupModel();

            dataAccessLayer.FetchByCommandName(commandName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultPerformanceTimeRollupModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultPerformanceTimeRollupData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultPerformanceTimeRollupModel> DataListToModelList(List<CrudeDefaultPerformanceTimeRollupData> dataList) {
            var modelList = new List<CrudeDefaultPerformanceTimeRollupModel>();

            foreach (CrudeDefaultPerformanceTimeRollupData data in dataList) {
                var model = new CrudeDefaultPerformanceTimeRollupModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultPerformanceTimeRollupModel> modelList, List<CrudeDefaultPerformanceTimeRollupData> dataList) {
            foreach (CrudeDefaultPerformanceTimeRollupModel model in modelList) {
                var data = new CrudeDefaultPerformanceTimeRollupData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultPerformanceTimeRollupModel> FetchAll() {
            var list = new List<CrudeDefaultPerformanceTimeRollupModel>();
            List<CrudeDefaultPerformanceTimeRollupData> dataList = CrudeDefaultPerformanceTimeRollupData.FetchAll();

            foreach (CrudeDefaultPerformanceTimeRollupData crudeDefaultPerformanceTimeRollupBusiness in dataList) {
                var model = new CrudeDefaultPerformanceTimeRollupModel();
                DataToModel(crudeDefaultPerformanceTimeRollupBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultPerformanceTimeRollupModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultPerformanceTimeRollupModel>();
            List<CrudeDefaultPerformanceTimeRollupData> dataList = CrudeDefaultPerformanceTimeRollupData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultPerformanceTimeRollupData crudeDefaultPerformanceTimeRollupBusiness in dataList) {
                var model = new CrudeDefaultPerformanceTimeRollupModel();
                DataToModel(crudeDefaultPerformanceTimeRollupBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultPerformanceTimeRollupModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultPerformanceTimeRollupModel>();
            List<CrudeDefaultPerformanceTimeRollupData> dataList = CrudeDefaultPerformanceTimeRollupData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultPerformanceTimeRollupData crudeDefaultPerformanceTimeRollupBusiness in dataList) {
                var model = new CrudeDefaultPerformanceTimeRollupModel();
                DataToModel(crudeDefaultPerformanceTimeRollupBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultPerformanceTimeRollupData.FetchAllCount();

        }
        
        public List<CrudeDefaultPerformanceTimeRollupModel> FetchWithFilter(System.Guid defaultPerformanceTimeRollupId, string commandName, long milliseconds, long hits, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultPerformanceTimeRollupModel>();
            List<CrudeDefaultPerformanceTimeRollupData> dataList = CrudeDefaultPerformanceTimeRollupData.FetchWithFilter(defaultPerformanceTimeRollupId,commandName,milliseconds,hits,defaultUserId,dateTime);

            foreach (CrudeDefaultPerformanceTimeRollupData data in dataList) {
                var crudeDefaultPerformanceTimeRollupBusinessModel = new CrudeDefaultPerformanceTimeRollupModel();
                DataToModel(data, crudeDefaultPerformanceTimeRollupBusinessModel);
                list.Add(crudeDefaultPerformanceTimeRollupBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultPerformanceTimeRollupModel model) {
            var data = new CrudeDefaultPerformanceTimeRollupData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultPerformanceTimeRollupModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceTimeRollupData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultPerformanceTimeRollupModel model) {
            var data = new CrudeDefaultPerformanceTimeRollupData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultPerformanceTimeRollupModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceTimeRollupData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultPerformanceTimeRollupId) {
            CrudeDefaultPerformanceTimeRollupData.Delete(defaultPerformanceTimeRollupId);
        }
        
        public static void ModelToData(CrudeDefaultPerformanceTimeRollupModel model, CrudeDefaultPerformanceTimeRollupData data) {
            data.DefaultPerformanceTimeRollupId = model.DefaultPerformanceTimeRollupId;
            data.CommandName = model.CommandName;
            data.Milliseconds = model.Milliseconds;
            data.Hits = model.Hits;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultPerformanceTimeRollupData data, CrudeDefaultPerformanceTimeRollupModel model) {
            model.DefaultPerformanceTimeRollupId = data.DefaultPerformanceTimeRollupId;
            model.CommandName = data.CommandName;
            model.Milliseconds = data.Milliseconds;
            model.Hits = data.Hits;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
