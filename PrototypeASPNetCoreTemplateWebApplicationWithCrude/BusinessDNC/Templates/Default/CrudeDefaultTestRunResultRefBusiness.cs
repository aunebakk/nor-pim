/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:44:05 PM
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
    
    
    public partial class CrudeDefaultTestRunResultRefBusiness {
        
        public CrudeDefaultTestRunResultRefModel FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd) {
            var dataAccessLayer = new CrudeDefaultTestRunResultRefData();
            var model = new CrudeDefaultTestRunResultRefModel();

            dataAccessLayer.FetchByDefaultTestRunResultRcd(defaultTestRunResultRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultTestRunResultRefModel FetchByDefaultTestRunResultName(string defaultTestRunResultName) {
            var dataAccessLayer = new CrudeDefaultTestRunResultRefData();
            var model = new CrudeDefaultTestRunResultRefModel();

            dataAccessLayer.FetchByDefaultTestRunResultName(defaultTestRunResultName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultTestRunResultRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeDefaultTestRunResultRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeDefaultTestRunResultRefModel> DataListToModelList(List<CrudeDefaultTestRunResultRefData> dataList) {
            var modelList = new List<CrudeDefaultTestRunResultRefModel>();

            foreach (CrudeDefaultTestRunResultRefData data in dataList) {
                var model = new CrudeDefaultTestRunResultRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultTestRunResultRefModel> modelList, List<CrudeDefaultTestRunResultRefData> dataList) {
            foreach (CrudeDefaultTestRunResultRefModel model in modelList) {
                var data = new CrudeDefaultTestRunResultRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultTestRunResultRefModel> FetchAll() {
            var list = new List<CrudeDefaultTestRunResultRefModel>();
            List<CrudeDefaultTestRunResultRefData> dataList = CrudeDefaultTestRunResultRefData.FetchAll();

            foreach (CrudeDefaultTestRunResultRefData crudeDefaultTestRunResultRefBusiness in dataList) {
                var model = new CrudeDefaultTestRunResultRefModel();
                DataToModel(crudeDefaultTestRunResultRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultTestRunResultRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultTestRunResultRefModel>();
            List<CrudeDefaultTestRunResultRefData> dataList = CrudeDefaultTestRunResultRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultTestRunResultRefData crudeDefaultTestRunResultRefBusiness in dataList) {
                var model = new CrudeDefaultTestRunResultRefModel();
                DataToModel(crudeDefaultTestRunResultRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultTestRunResultRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultTestRunResultRefModel>();
            List<CrudeDefaultTestRunResultRefData> dataList = CrudeDefaultTestRunResultRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultTestRunResultRefData crudeDefaultTestRunResultRefBusiness in dataList) {
                var model = new CrudeDefaultTestRunResultRefModel();
                DataToModel(crudeDefaultTestRunResultRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultTestRunResultRefData.FetchAllCount();

        }
        
        public List<CrudeDefaultTestRunResultRefModel> FetchWithFilter(string defaultTestRunResultRcd, string defaultTestRunResultName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultTestRunResultRefModel>();
            List<CrudeDefaultTestRunResultRefData> dataList = CrudeDefaultTestRunResultRefData.FetchWithFilter(defaultTestRunResultRcd,defaultTestRunResultName,userId,dateTime);

            foreach (CrudeDefaultTestRunResultRefData data in dataList) {
                var crudeDefaultTestRunResultRefBusinessModel = new CrudeDefaultTestRunResultRefModel();
                DataToModel(data, crudeDefaultTestRunResultRefBusinessModel);
                list.Add(crudeDefaultTestRunResultRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultTestRunResultRefModel model) {
            var data = new CrudeDefaultTestRunResultRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultTestRunResultRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestRunResultRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultTestRunResultRefModel model) {
            var data = new CrudeDefaultTestRunResultRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultTestRunResultRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestRunResultRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultTestRunResultRcd) {
            CrudeDefaultTestRunResultRefData.Delete(defaultTestRunResultRcd);
        }
        
        public static void ModelToData(CrudeDefaultTestRunResultRefModel model, CrudeDefaultTestRunResultRefData data) {
            data.DefaultTestRunResultRcd = model.DefaultTestRunResultRcd;
            data.DefaultTestRunResultName = model.DefaultTestRunResultName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultTestRunResultRefData data, CrudeDefaultTestRunResultRefModel model) {
            model.DefaultTestRunResultRcd = data.DefaultTestRunResultRcd;
            model.DefaultTestRunResultName = data.DefaultTestRunResultName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
