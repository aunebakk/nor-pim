/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:50:18 AM
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
    
    
    public partial class CrudeDefaultTestBusiness {
        
        public CrudeDefaultTestModel FetchByDefaultTestId(System.Guid defaultTestId) {
            var dataAccessLayer = new CrudeDefaultTestData();
            var model = new CrudeDefaultTestModel();

            dataAccessLayer.FetchByDefaultTestId(defaultTestId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeDefaultTestModel FetchBySystemName(string systemName) {
            var dataAccessLayer = new CrudeDefaultTestData();
            var model = new CrudeDefaultTestModel();

            dataAccessLayer.FetchBySystemName(systemName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeDefaultTestModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeDefaultTestData.FetchByUserId(userId));
        }
        
        public static List<CrudeDefaultTestModel> DataListToModelList(List<CrudeDefaultTestData> dataList) {
            var modelList = new List<CrudeDefaultTestModel>();

            foreach (CrudeDefaultTestData data in dataList) {
                var model = new CrudeDefaultTestModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeDefaultTestModel> modelList, List<CrudeDefaultTestData> dataList) {
            foreach (CrudeDefaultTestModel model in modelList) {
                var data = new CrudeDefaultTestData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultTestModel> FetchAll() {
            var list = new List<CrudeDefaultTestModel>();
            List<CrudeDefaultTestData> dataList = CrudeDefaultTestData.FetchAll();

            foreach (CrudeDefaultTestData crudeDefaultTestBusiness in dataList) {
                var model = new CrudeDefaultTestModel();
                DataToModel(crudeDefaultTestBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultTestModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeDefaultTestModel>();
            List<CrudeDefaultTestData> dataList = CrudeDefaultTestData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeDefaultTestData crudeDefaultTestBusiness in dataList) {
                var model = new CrudeDefaultTestModel();
                DataToModel(crudeDefaultTestBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeDefaultTestModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeDefaultTestModel>();
            List<CrudeDefaultTestData> dataList = CrudeDefaultTestData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeDefaultTestData crudeDefaultTestBusiness in dataList) {
                var model = new CrudeDefaultTestModel();
                DataToModel(crudeDefaultTestBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultTestData.FetchAllCount();

        }
        
        public List<CrudeDefaultTestModel> FetchWithFilter(System.Guid defaultTestId, string systemName, string testArea, string testSubArea, string testAddress, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultTestModel>();
            List<CrudeDefaultTestData> dataList = CrudeDefaultTestData.FetchWithFilter(defaultTestId,systemName,testArea,testSubArea,testAddress,userId,dateTime);

            foreach (CrudeDefaultTestData data in dataList) {
                var crudeDefaultTestBusinessModel = new CrudeDefaultTestModel();
                DataToModel(data, crudeDefaultTestBusinessModel);
                list.Add(crudeDefaultTestBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultTestModel model) {
            var data = new CrudeDefaultTestData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultTestModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultTestModel model) {
            var data = new CrudeDefaultTestData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultTestModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultTestId) {
            CrudeDefaultTestData.Delete(defaultTestId);
        }
        
        public static void ModelToData(CrudeDefaultTestModel model, CrudeDefaultTestData data) {
            data.DefaultTestId = model.DefaultTestId;
            data.SystemName = model.SystemName;
            data.TestArea = model.TestArea;
            data.TestSubArea = model.TestSubArea;
            data.TestAddress = model.TestAddress;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeDefaultTestData data, CrudeDefaultTestModel model) {
            model.DefaultTestId = data.DefaultTestId;
            model.SystemName = data.SystemName;
            model.TestArea = data.TestArea;
            model.TestSubArea = data.TestSubArea;
            model.TestAddress = data.TestAddress;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
