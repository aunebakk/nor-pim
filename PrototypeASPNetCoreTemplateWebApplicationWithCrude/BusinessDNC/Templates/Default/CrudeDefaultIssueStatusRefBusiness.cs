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
    
    
    public partial class CrudeDefaultIssueStatusRefBusiness {
        
        public CrudeDefaultIssueStatusRefModel FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd) {
            var dataAccessLayer = new CrudeDefaultIssueStatusRefData();
            var model = new CrudeDefaultIssueStatusRefModel();

            dataAccessLayer.FetchByDefaultIssueStatusRcd(defaultIssueStatusRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultIssueStatusRefModel FetchByDefaultIssueStatusName(string defaultIssueStatusName) {
            var dataAccessLayer = new CrudeDefaultIssueStatusRefData();
            var model = new CrudeDefaultIssueStatusRefModel();

            dataAccessLayer.FetchByDefaultIssueStatusName(defaultIssueStatusName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultIssueStatusRefModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultIssueStatusRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultIssueStatusRefModel> DataListToModelList(List<CrudeDefaultIssueStatusRefData> dataList) {
            var modelList = new List<CrudeDefaultIssueStatusRefModel>();

            foreach (CrudeDefaultIssueStatusRefData data in dataList) {
                var model = new CrudeDefaultIssueStatusRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultIssueStatusRefModel> modelList, List<CrudeDefaultIssueStatusRefData> dataList) {
            foreach (CrudeDefaultIssueStatusRefModel model in modelList) {
                var data = new CrudeDefaultIssueStatusRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultIssueStatusRefModel> FetchAll() {
            var list = new List<CrudeDefaultIssueStatusRefModel>();
            List<CrudeDefaultIssueStatusRefData> dataList = CrudeDefaultIssueStatusRefData.FetchAll();

            foreach (CrudeDefaultIssueStatusRefData crudeDefaultIssueStatusRefBusiness in dataList) {
                var model = new CrudeDefaultIssueStatusRefModel();
                DataToModel(crudeDefaultIssueStatusRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultIssueStatusRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultIssueStatusRefModel>();
            List<CrudeDefaultIssueStatusRefData> dataList = CrudeDefaultIssueStatusRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultIssueStatusRefData crudeDefaultIssueStatusRefBusiness in dataList) {
                var model = new CrudeDefaultIssueStatusRefModel();
                DataToModel(crudeDefaultIssueStatusRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultIssueStatusRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultIssueStatusRefModel>();
            List<CrudeDefaultIssueStatusRefData> dataList = CrudeDefaultIssueStatusRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultIssueStatusRefData crudeDefaultIssueStatusRefBusiness in dataList) {
                var model = new CrudeDefaultIssueStatusRefModel();
                DataToModel(crudeDefaultIssueStatusRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultIssueStatusRefData.FetchAllCount();

        }
        
        public List<CrudeDefaultIssueStatusRefModel> FetchWithFilter(string defaultIssueStatusRcd, string defaultIssueStatusName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultIssueStatusRefModel>();
            List<CrudeDefaultIssueStatusRefData> dataList = CrudeDefaultIssueStatusRefData.FetchWithFilter(defaultIssueStatusRcd,defaultIssueStatusName,defaultUserId,dateTime);

            foreach (CrudeDefaultIssueStatusRefData data in dataList) {
                var crudeDefaultIssueStatusRefBusinessModel = new CrudeDefaultIssueStatusRefModel();
                DataToModel(data, crudeDefaultIssueStatusRefBusinessModel);
                list.Add(crudeDefaultIssueStatusRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultIssueStatusRefModel model) {
            var data = new CrudeDefaultIssueStatusRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultIssueStatusRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueStatusRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultIssueStatusRefModel model) {
            var data = new CrudeDefaultIssueStatusRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultIssueStatusRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueStatusRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultIssueStatusRcd) {
            CrudeDefaultIssueStatusRefData.Delete(defaultIssueStatusRcd);
        }
        
        public static void ModelToData(CrudeDefaultIssueStatusRefModel model, CrudeDefaultIssueStatusRefData data) {
            data.DefaultIssueStatusRcd = model.DefaultIssueStatusRcd;
            data.DefaultIssueStatusName = model.DefaultIssueStatusName;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultIssueStatusRefData data, CrudeDefaultIssueStatusRefModel model) {
            model.DefaultIssueStatusRcd = data.DefaultIssueStatusRcd;
            model.DefaultIssueStatusName = data.DefaultIssueStatusName;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
