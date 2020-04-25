/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:25:17 PM
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
    
    
    public partial class CrudeDefaultIssueTypeRefBusiness {
        
        public CrudeDefaultIssueTypeRefModel FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd) {
            var dataAccessLayer = new CrudeDefaultIssueTypeRefData();
            var model = new CrudeDefaultIssueTypeRefModel();

            dataAccessLayer.FetchByDefaultIssueTypeRcd(defaultIssueTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultIssueTypeRefModel FetchByDefaultIssueTypeName(string defaultIssueTypeName) {
            var dataAccessLayer = new CrudeDefaultIssueTypeRefData();
            var model = new CrudeDefaultIssueTypeRefModel();

            dataAccessLayer.FetchByDefaultIssueTypeName(defaultIssueTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultIssueTypeRefModel> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToModelList(CrudeDefaultIssueTypeRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultIssueTypeRefModel> DataListToModelList(List<CrudeDefaultIssueTypeRefData> dataList) {
            var modelList = new List<CrudeDefaultIssueTypeRefModel>();

            foreach (CrudeDefaultIssueTypeRefData data in dataList) {
                var model = new CrudeDefaultIssueTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultIssueTypeRefModel> modelList, List<CrudeDefaultIssueTypeRefData> dataList) {
            foreach (CrudeDefaultIssueTypeRefModel model in modelList) {
                var data = new CrudeDefaultIssueTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultIssueTypeRefModel> FetchAll() {
            var list = new List<CrudeDefaultIssueTypeRefModel>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchAll();

            foreach (CrudeDefaultIssueTypeRefData crudeDefaultIssueTypeRefBusiness in dataList) {
                var model = new CrudeDefaultIssueTypeRefModel();
                DataToModel(crudeDefaultIssueTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultIssueTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultIssueTypeRefModel>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultIssueTypeRefData crudeDefaultIssueTypeRefBusiness in dataList) {
                var model = new CrudeDefaultIssueTypeRefModel();
                DataToModel(crudeDefaultIssueTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultIssueTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultIssueTypeRefModel>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultIssueTypeRefData crudeDefaultIssueTypeRefBusiness in dataList) {
                var model = new CrudeDefaultIssueTypeRefModel();
                DataToModel(crudeDefaultIssueTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultIssueTypeRefData.FetchAllCount();

        }
        
        public List<CrudeDefaultIssueTypeRefModel> FetchWithFilter(string defaultIssueTypeRcd, string defaultIssueTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultIssueTypeRefModel>();
            List<CrudeDefaultIssueTypeRefData> dataList = CrudeDefaultIssueTypeRefData.FetchWithFilter(defaultIssueTypeRcd,defaultIssueTypeName,defaultUserId,dateTime);

            foreach (CrudeDefaultIssueTypeRefData data in dataList) {
                var crudeDefaultIssueTypeRefBusinessModel = new CrudeDefaultIssueTypeRefModel();
                DataToModel(data, crudeDefaultIssueTypeRefBusinessModel);
                list.Add(crudeDefaultIssueTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultIssueTypeRefModel model) {
            var data = new CrudeDefaultIssueTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultIssueTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultIssueTypeRefModel model) {
            var data = new CrudeDefaultIssueTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultIssueTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultIssueTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultIssueTypeRcd) {
            CrudeDefaultIssueTypeRefData.Delete(defaultIssueTypeRcd);
        }
        
        public static void ModelToData(CrudeDefaultIssueTypeRefModel model, CrudeDefaultIssueTypeRefData data) {
            data.DefaultIssueTypeRcd = model.DefaultIssueTypeRcd;
            data.DefaultIssueTypeName = model.DefaultIssueTypeName;
            data.DefaultUserId = model.DefaultUserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultIssueTypeRefData data, CrudeDefaultIssueTypeRefModel model) {
            model.DefaultIssueTypeRcd = data.DefaultIssueTypeRcd;
            model.DefaultIssueTypeName = data.DefaultIssueTypeName;
            model.DefaultUserId = data.DefaultUserId;
            model.DateTime = data.DateTime;
        }
    }
}
