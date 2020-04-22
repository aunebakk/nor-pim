/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:37:58 AM
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
    
    
    public partial class CrudeDefaultTestRunBusiness {
        
        public CrudeDefaultTestRunModel FetchByDefaultTestRunId(System.Guid defaultTestRunId) {
            var dataAccessLayer = new CrudeDefaultTestRunData();
            var model = new CrudeDefaultTestRunModel();

            dataAccessLayer.FetchByDefaultTestRunId(defaultTestRunId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultTestRunModel> FetchByDefaultTestId(System.Guid defaultTestId) {
            return DataListToModelList(CrudeDefaultTestRunData.FetchByDefaultTestId(defaultTestId));
        }
        
        public List<CrudeDefaultTestRunModel> FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd) {
            return DataListToModelList(CrudeDefaultTestRunData.FetchByDefaultTestRunResultRcd(defaultTestRunResultRcd));
        }
        
        public List<CrudeDefaultTestRunModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeDefaultTestRunData.FetchByUserId(userId));
        }
        
        public static List<CrudeDefaultTestRunModel> DataListToModelList(List<CrudeDefaultTestRunData> dataList) {
            var modelList = new List<CrudeDefaultTestRunModel>();

            foreach (CrudeDefaultTestRunData data in dataList) {
                var model = new CrudeDefaultTestRunModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultTestRunModel> modelList, List<CrudeDefaultTestRunData> dataList) {
            foreach (CrudeDefaultTestRunModel model in modelList) {
                var data = new CrudeDefaultTestRunData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultTestRunModel> FetchAll() {
            var list = new List<CrudeDefaultTestRunModel>();
            List<CrudeDefaultTestRunData> dataList = CrudeDefaultTestRunData.FetchAll();

            foreach (CrudeDefaultTestRunData crudeDefaultTestRunBusiness in dataList) {
                var model = new CrudeDefaultTestRunModel();
                DataToModel(crudeDefaultTestRunBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultTestRunModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultTestRunModel>();
            List<CrudeDefaultTestRunData> dataList = CrudeDefaultTestRunData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultTestRunData crudeDefaultTestRunBusiness in dataList) {
                var model = new CrudeDefaultTestRunModel();
                DataToModel(crudeDefaultTestRunBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultTestRunModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultTestRunModel>();
            List<CrudeDefaultTestRunData> dataList = CrudeDefaultTestRunData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultTestRunData crudeDefaultTestRunBusiness in dataList) {
                var model = new CrudeDefaultTestRunModel();
                DataToModel(crudeDefaultTestRunBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultTestRunData.FetchAllCount();

        }
        
        public List<CrudeDefaultTestRunModel> FetchWithFilter(System.Guid defaultTestRunId, System.Guid defaultTestId, string defaultTestRunResultRcd, string result, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultTestRunModel>();
            List<CrudeDefaultTestRunData> dataList = CrudeDefaultTestRunData.FetchWithFilter(defaultTestRunId,defaultTestId,defaultTestRunResultRcd,result,startDateTime,endDateTime,elapsedMilliseconds,userId,dateTime);

            foreach (CrudeDefaultTestRunData data in dataList) {
                var crudeDefaultTestRunBusinessModel = new CrudeDefaultTestRunModel();
                DataToModel(data, crudeDefaultTestRunBusinessModel);
                list.Add(crudeDefaultTestRunBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultTestRunModel model) {
            var data = new CrudeDefaultTestRunData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultTestRunModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestRunData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultTestRunModel model) {
            var data = new CrudeDefaultTestRunData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultTestRunModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestRunData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultTestRunId) {
            CrudeDefaultTestRunData.Delete(defaultTestRunId);
        }
        
        public static void ModelToData(CrudeDefaultTestRunModel model, CrudeDefaultTestRunData data) {
            data.DefaultTestRunId = model.DefaultTestRunId;
            data.DefaultTestId = model.DefaultTestId;
            data.DefaultTestRunResultRcd = model.DefaultTestRunResultRcd;
            data.Result = model.Result;
            data.StartDateTime = model.StartDateTime;
            data.EndDateTime = model.EndDateTime;
            data.ElapsedMilliseconds = model.ElapsedMilliseconds;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultTestRunData data, CrudeDefaultTestRunModel model) {
            model.DefaultTestRunId = data.DefaultTestRunId;
            model.DefaultTestId = data.DefaultTestId;
            model.DefaultTestRunResultRcd = data.DefaultTestRunResultRcd;
            model.Result = data.Result;
            model.StartDateTime = data.StartDateTime;
            model.EndDateTime = data.EndDateTime;
            model.ElapsedMilliseconds = data.ElapsedMilliseconds;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
