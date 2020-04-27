/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:45:11 PM
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
    
    
    public partial class CrudeProductFieldSetBusiness {
        
        public CrudeProductFieldSetModel FetchByProductFieldSetId(System.Guid productFieldSetId) {
            var dataAccessLayer = new CrudeProductFieldSetData();
            var model = new CrudeProductFieldSetModel();

            dataAccessLayer.FetchByProductFieldSetId(productFieldSetId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeProductFieldSetModel FetchByProductFieldSetName(string productFieldSetName) {
            var dataAccessLayer = new CrudeProductFieldSetData();
            var model = new CrudeProductFieldSetModel();

            dataAccessLayer.FetchByProductFieldSetName(productFieldSetName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeProductFieldSetModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeProductFieldSetData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductFieldSetModel> DataListToModelList(List<CrudeProductFieldSetData> dataList) {
            var modelList = new List<CrudeProductFieldSetModel>();

            foreach (CrudeProductFieldSetData data in dataList) {
                var model = new CrudeProductFieldSetModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeProductFieldSetModel> modelList, List<CrudeProductFieldSetData> dataList) {
            foreach (CrudeProductFieldSetModel model in modelList) {
                var data = new CrudeProductFieldSetData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductFieldSetModel> FetchAll() {
            var list = new List<CrudeProductFieldSetModel>();
            List<CrudeProductFieldSetData> dataList = CrudeProductFieldSetData.FetchAll();

            foreach (CrudeProductFieldSetData crudeProductFieldSetBusiness in dataList) {
                var model = new CrudeProductFieldSetModel();
                DataToModel(crudeProductFieldSetBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductFieldSetModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeProductFieldSetModel>();
            List<CrudeProductFieldSetData> dataList = CrudeProductFieldSetData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeProductFieldSetData crudeProductFieldSetBusiness in dataList) {
                var model = new CrudeProductFieldSetModel();
                DataToModel(crudeProductFieldSetBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeProductFieldSetModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeProductFieldSetModel>();
            List<CrudeProductFieldSetData> dataList = CrudeProductFieldSetData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeProductFieldSetData crudeProductFieldSetBusiness in dataList) {
                var model = new CrudeProductFieldSetModel();
                DataToModel(crudeProductFieldSetBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductFieldSetData.FetchAllCount();

        }
        
        public List<CrudeProductFieldSetModel> FetchWithFilter(System.Guid productFieldSetId, string productFieldSetName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductFieldSetModel>();
            List<CrudeProductFieldSetData> dataList = CrudeProductFieldSetData.FetchWithFilter(productFieldSetId,productFieldSetName,userId,dateTime);

            foreach (CrudeProductFieldSetData data in dataList) {
                var crudeProductFieldSetBusinessModel = new CrudeProductFieldSetModel();
                DataToModel(data, crudeProductFieldSetBusinessModel);
                list.Add(crudeProductFieldSetBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeProductFieldSetModel model) {
            var data = new CrudeProductFieldSetData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductFieldSetModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductFieldSetData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductFieldSetModel model) {
            var data = new CrudeProductFieldSetData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeProductFieldSetModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductFieldSetData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productFieldSetId) {
            CrudeProductFieldSetData.Delete(productFieldSetId);
        }
        
        public static void ModelToData(CrudeProductFieldSetModel model, CrudeProductFieldSetData data) {
            data.ProductFieldSetId = model.ProductFieldSetId;
            data.ProductFieldSetName = model.ProductFieldSetName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeProductFieldSetData data, CrudeProductFieldSetModel model) {
            model.ProductFieldSetId = data.ProductFieldSetId;
            model.ProductFieldSetName = data.ProductFieldSetName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
