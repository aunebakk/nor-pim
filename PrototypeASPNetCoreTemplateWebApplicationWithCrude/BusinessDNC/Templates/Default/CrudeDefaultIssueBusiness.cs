/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:19 AM
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
    
    
    public partial class CrudeDefaultIssueBusiness {
        
        public CrudeDefaultIssueModel FetchByDefaultIssueId(System.Guid defaultIssueId) {
            var dataAccessLayer = new CrudeDefaultIssueData();
            var model = new CrudeDefaultIssueModel();

            dataAccessLayer.FetchByDefaultIssueId(defaultIssueId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultIssueModel FetchByIssueName(string issueName) {
            var dataAccessLayer = new CrudeDefaultIssueData();
            var model = new CrudeDefaultIssueModel();

            dataAccessLayer.FetchByIssueName(issueName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultIssueModel> FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd) {
            return DataListToModelList(CrudeDefaultIssueData.FetchByDefaultIssueTypeRcd(defaultIssueTypeRcd));
        }
        
        public List<CrudeDefaultIssueModel> FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd) {
            return DataListToModelList(CrudeDefaultIssueData.FetchByDefaultIssueStatusRcd(defaultIssueStatusRcd));
        }
        
        public List<CrudeDefaultIssueModel> FetchByDefaultErrorId(System.Guid defaultErrorId) {
            return DataListToModelList(CrudeDefaultIssueData.FetchByDefaultErrorId(defaultErrorId));
        }
        
        public List<CrudeDefaultIssueModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultIssueData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultIssueModel> DataListToModelList(List<CrudeDefaultIssueData> dataList) {
            var modelList = new List<CrudeDefaultIssueModel>();

            foreach (CrudeDefaultIssueData data in dataList) {
                var model = new CrudeDefaultIssueModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultIssueModel> modelList, List<CrudeDefaultIssueData> dataList) {
            foreach (CrudeDefaultIssueModel model in modelList) {
                var data = new CrudeDefaultIssueData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultIssueModel> FetchAll() {
            var list = new List<CrudeDefaultIssueModel>();
            List<CrudeDefaultIssueData> dataList = CrudeDefaultIssueData.FetchAll();

            foreach (CrudeDefaultIssueData crudeDefaultIssueBusiness in dataList) {
                var model = new CrudeDefaultIssueModel();
                DataToModel(crudeDefaultIssueBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultIssueModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultIssueModel>();
            List<CrudeDefaultIssueData> dataList = CrudeDefaultIssueData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultIssueData crudeDefaultIssueBusiness in dataList) {
                var model = new CrudeDefaultIssueModel();
                DataToModel(crudeDefaultIssueBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultIssueModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultIssueModel>();
            List<CrudeDefaultIssueData> dataList = CrudeDefaultIssueData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultIssueData crudeDefaultIssueBusiness in dataList) {
                var model = new CrudeDefaultIssueModel();
                DataToModel(crudeDefaultIssueBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultIssueData.FetchAllCount();

        }
        
        public List<CrudeDefaultIssueModel> FetchWithFilter(System.Guid defaultIssueId, string defaultIssueTypeRcd, string defaultIssueStatusRcd, System.Guid defaultErrorId, string issueName, string issueDescription, string stepsToReproduce, string link, System.Guid defaultUserId, System.DateTime dateTime, string fixedNote) {
            var list = new List<CrudeDefaultIssueModel>();
            List<CrudeDefaultIssueData> dataList = CrudeDefaultIssueData.FetchWithFilter(defaultIssueId,defaultIssueTypeRcd,defaultIssueStatusRcd,defaultErrorId,issueName,issueDescription,stepsToReproduce,link,defaultUserId,dateTime,fixedNote);

            foreach (CrudeDefaultIssueData data in dataList) {
                var crudeDefaultIssueBusinessModel = new CrudeDefaultIssueModel();
                DataToModel(data, crudeDefaultIssueBusinessModel);
                list.Add(crudeDefaultIssueBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultIssueModel model) {
            var data = new CrudeDefaultIssueData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultIssueModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultIssueModel model) {
            var data = new CrudeDefaultIssueData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultIssueModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultIssueId) {
            CrudeDefaultIssueData.Delete(defaultIssueId);
        }
        
        public static void ModelToData(CrudeDefaultIssueModel model, CrudeDefaultIssueData data) {
            data.DefaultIssueId = model.DefaultIssueId;
            data.DefaultIssueTypeRcd = model.DefaultIssueTypeRcd;
            data.DefaultIssueStatusRcd = model.DefaultIssueStatusRcd;
            data.DefaultErrorId = model.DefaultErrorId;
            data.IssueName = model.IssueName;
            data.IssueDescription = model.IssueDescription;
            data.StepsToReproduce = model.StepsToReproduce;
            data.Link = model.Link;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
            data.FixedNote = model.FixedNote;
        }
        
        public static void DataToModel(CrudeDefaultIssueData data, CrudeDefaultIssueModel model) {
            model.DefaultIssueId = data.DefaultIssueId;
            model.DefaultIssueTypeRcd = data.DefaultIssueTypeRcd;
            model.DefaultIssueStatusRcd = data.DefaultIssueStatusRcd;
            model.DefaultErrorId = data.DefaultErrorId;
            model.IssueName = data.IssueName;
            model.IssueDescription = data.IssueDescription;
            model.StepsToReproduce = data.StepsToReproduce;
            model.Link = data.Link;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
            model.FixedNote = data.FixedNote;
        }
    }
}
