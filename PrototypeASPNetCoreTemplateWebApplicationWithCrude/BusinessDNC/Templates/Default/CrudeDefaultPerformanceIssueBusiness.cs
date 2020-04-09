/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:26:47 AM
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
    
    
    public partial class CrudeDefaultPerformanceIssueBusiness {
        
        public CrudeDefaultPerformanceIssueModel FetchByDefaultPerformanceIssueId(System.Guid defaultPerformanceIssueId) {
            var dataAccessLayer = new CrudeDefaultPerformanceIssueData();
            var model = new CrudeDefaultPerformanceIssueModel();

            dataAccessLayer.FetchByDefaultPerformanceIssueId(defaultPerformanceIssueId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultPerformanceIssueModel FetchByCommandName(string commandName) {
            var dataAccessLayer = new CrudeDefaultPerformanceIssueData();
            var model = new CrudeDefaultPerformanceIssueModel();

            dataAccessLayer.FetchByCommandName(commandName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultPerformanceIssueModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultPerformanceIssueData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultPerformanceIssueModel> DataListToModelList(List<CrudeDefaultPerformanceIssueData> dataList) {
            var modelList = new List<CrudeDefaultPerformanceIssueModel>();

            foreach (CrudeDefaultPerformanceIssueData data in dataList) {
                var model = new CrudeDefaultPerformanceIssueModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultPerformanceIssueModel> modelList, List<CrudeDefaultPerformanceIssueData> dataList) {
            foreach (CrudeDefaultPerformanceIssueModel model in modelList) {
                var data = new CrudeDefaultPerformanceIssueData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultPerformanceIssueModel> FetchAll() {
            var list = new List<CrudeDefaultPerformanceIssueModel>();
            List<CrudeDefaultPerformanceIssueData> dataList = CrudeDefaultPerformanceIssueData.FetchAll();

            foreach (CrudeDefaultPerformanceIssueData crudeDefaultPerformanceIssueBusiness in dataList) {
                var model = new CrudeDefaultPerformanceIssueModel();
                DataToModel(crudeDefaultPerformanceIssueBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultPerformanceIssueModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultPerformanceIssueModel>();
            List<CrudeDefaultPerformanceIssueData> dataList = CrudeDefaultPerformanceIssueData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultPerformanceIssueData crudeDefaultPerformanceIssueBusiness in dataList) {
                var model = new CrudeDefaultPerformanceIssueModel();
                DataToModel(crudeDefaultPerformanceIssueBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultPerformanceIssueModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultPerformanceIssueModel>();
            List<CrudeDefaultPerformanceIssueData> dataList = CrudeDefaultPerformanceIssueData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultPerformanceIssueData crudeDefaultPerformanceIssueBusiness in dataList) {
                var model = new CrudeDefaultPerformanceIssueModel();
                DataToModel(crudeDefaultPerformanceIssueBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultPerformanceIssueData.FetchAllCount();

        }
        
        public List<CrudeDefaultPerformanceIssueModel> FetchWithFilter(System.Guid defaultPerformanceIssueId, string commandName, string commandText, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultPerformanceIssueModel>();
            List<CrudeDefaultPerformanceIssueData> dataList = CrudeDefaultPerformanceIssueData.FetchWithFilter(defaultPerformanceIssueId,commandName,commandText,milliseconds,defaultUserId,dateTime);

            foreach (CrudeDefaultPerformanceIssueData data in dataList) {
                var crudeDefaultPerformanceIssueBusinessModel = new CrudeDefaultPerformanceIssueModel();
                DataToModel(data, crudeDefaultPerformanceIssueBusinessModel);
                list.Add(crudeDefaultPerformanceIssueBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultPerformanceIssueModel model) {
            var data = new CrudeDefaultPerformanceIssueData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultPerformanceIssueModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceIssueData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultPerformanceIssueModel model) {
            var data = new CrudeDefaultPerformanceIssueData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultPerformanceIssueModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceIssueData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultPerformanceIssueId) {
            CrudeDefaultPerformanceIssueData.Delete(defaultPerformanceIssueId);
        }
        
        public static void ModelToData(CrudeDefaultPerformanceIssueModel model, CrudeDefaultPerformanceIssueData data) {
            data.DefaultPerformanceIssueId = model.DefaultPerformanceIssueId;
            data.CommandName = model.CommandName;
            data.CommandText = model.CommandText;
            data.Milliseconds = model.Milliseconds;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultPerformanceIssueData data, CrudeDefaultPerformanceIssueModel model) {
            model.DefaultPerformanceIssueId = data.DefaultPerformanceIssueId;
            model.CommandName = data.CommandName;
            model.CommandText = data.CommandText;
            model.Milliseconds = data.Milliseconds;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
