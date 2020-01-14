/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:27 PM
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
    
    
    public partial class CrudeLocationCountryBusiness {
        
        public CrudeLocationCountryModel FetchByLocationCountryId(System.Guid locationCountryId) {
            var dataAccessLayer = new CrudeLocationCountryData();
            var model = new CrudeLocationCountryModel();

            dataAccessLayer.FetchByLocationCountryId(locationCountryId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeLocationCountryModel FetchByLocationCountryName(string locationCountryName) {
            var dataAccessLayer = new CrudeLocationCountryData();
            var model = new CrudeLocationCountryModel();

            dataAccessLayer.FetchByLocationCountryName(locationCountryName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeLocationCountryModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeLocationCountryData.FetchByUserId(userId));
        }
        
        public static List<CrudeLocationCountryModel> DataListToModelList(List<CrudeLocationCountryData> dataList) {
            var modelList = new List<CrudeLocationCountryModel>();

            foreach (CrudeLocationCountryData data in dataList) {
                var model = new CrudeLocationCountryModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeLocationCountryModel> modelList, List<CrudeLocationCountryData> dataList) {
            foreach (CrudeLocationCountryModel model in modelList) {
                var data = new CrudeLocationCountryData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeLocationCountryModel> FetchAll() {
            var list = new List<CrudeLocationCountryModel>();
            List<CrudeLocationCountryData> dataList = CrudeLocationCountryData.FetchAll();

            foreach (CrudeLocationCountryData crudeLocationCountryBusiness in dataList) {
                var model = new CrudeLocationCountryModel();
                DataToModel(crudeLocationCountryBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeLocationCountryModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeLocationCountryModel>();
            List<CrudeLocationCountryData> dataList = CrudeLocationCountryData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeLocationCountryData crudeLocationCountryBusiness in dataList) {
                var model = new CrudeLocationCountryModel();
                DataToModel(crudeLocationCountryBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeLocationCountryModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeLocationCountryModel>();
            List<CrudeLocationCountryData> dataList = CrudeLocationCountryData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeLocationCountryData crudeLocationCountryBusiness in dataList) {
                var model = new CrudeLocationCountryModel();
                DataToModel(crudeLocationCountryBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeLocationCountryData.FetchAllCount();

        }
        
        public List<CrudeLocationCountryModel> FetchWithFilter(System.Guid locationCountryId, string locationCountryCode, string locationCountryName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeLocationCountryModel>();
            List<CrudeLocationCountryData> dataList = CrudeLocationCountryData.FetchWithFilter(locationCountryId,locationCountryCode,locationCountryName,userId,dateTime);

            foreach (CrudeLocationCountryData data in dataList) {
                var crudeLocationCountryBusinessModel = new CrudeLocationCountryModel();
                DataToModel(data, crudeLocationCountryBusinessModel);
                list.Add(crudeLocationCountryBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeLocationCountryModel model) {
            var data = new CrudeLocationCountryData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeLocationCountryModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationCountryData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeLocationCountryModel model) {
            var data = new CrudeLocationCountryData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeLocationCountryModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationCountryData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid locationCountryId) {
            CrudeLocationCountryData.Delete(locationCountryId);
        }
        
        public static void ModelToData(CrudeLocationCountryModel model, CrudeLocationCountryData data) {
            data.LocationCountryId = model.LocationCountryId;
            data.LocationCountryCode = model.LocationCountryCode;
            data.LocationCountryName = model.LocationCountryName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeLocationCountryData data, CrudeLocationCountryModel model) {
            model.LocationCountryId = data.LocationCountryId;
            model.LocationCountryCode = data.LocationCountryCode;
            model.LocationCountryName = data.LocationCountryName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
