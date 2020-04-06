/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:41:23 PM
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
    
    
    public partial class CrudeLocationCityBusiness {
        
        public CrudeLocationCityModel FetchByLocationCityId(System.Guid locationCityId) {
            var dataAccessLayer = new CrudeLocationCityData();
            var model = new CrudeLocationCityModel();

            dataAccessLayer.FetchByLocationCityId(locationCityId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeLocationCityModel FetchByLocationCityName(string locationCityName) {
            var dataAccessLayer = new CrudeLocationCityData();
            var model = new CrudeLocationCityModel();

            dataAccessLayer.FetchByLocationCityName(locationCityName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeLocationCityModel> FetchByLocationCountryId(System.Guid locationCountryId) {
            return DataListToModelList(CrudeLocationCityData.FetchByLocationCountryId(locationCountryId));
        }
        
        public List<CrudeLocationCityModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeLocationCityData.FetchByUserId(userId));
        }
        
        public static List<CrudeLocationCityModel> DataListToModelList(List<CrudeLocationCityData> dataList) {
            var modelList = new List<CrudeLocationCityModel>();

            foreach (CrudeLocationCityData data in dataList) {
                var model = new CrudeLocationCityModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeLocationCityModel> modelList, List<CrudeLocationCityData> dataList) {
            foreach (CrudeLocationCityModel model in modelList) {
                var data = new CrudeLocationCityData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeLocationCityModel> FetchAll() {
            var list = new List<CrudeLocationCityModel>();
            List<CrudeLocationCityData> dataList = CrudeLocationCityData.FetchAll();

            foreach (CrudeLocationCityData crudeLocationCityBusiness in dataList) {
                var model = new CrudeLocationCityModel();
                DataToModel(crudeLocationCityBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeLocationCityModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeLocationCityModel>();
            List<CrudeLocationCityData> dataList = CrudeLocationCityData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeLocationCityData crudeLocationCityBusiness in dataList) {
                var model = new CrudeLocationCityModel();
                DataToModel(crudeLocationCityBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeLocationCityModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeLocationCityModel>();
            List<CrudeLocationCityData> dataList = CrudeLocationCityData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeLocationCityData crudeLocationCityBusiness in dataList) {
                var model = new CrudeLocationCityModel();
                DataToModel(crudeLocationCityBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeLocationCityData.FetchAllCount();

        }
        
        public List<CrudeLocationCityModel> FetchWithFilter(System.Guid locationCityId, System.Guid locationCountryId, string locationCityCode, string locationCityName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeLocationCityModel>();
            List<CrudeLocationCityData> dataList = CrudeLocationCityData.FetchWithFilter(locationCityId,locationCountryId,locationCityCode,locationCityName,userId,dateTime);

            foreach (CrudeLocationCityData data in dataList) {
                var crudeLocationCityBusinessModel = new CrudeLocationCityModel();
                DataToModel(data, crudeLocationCityBusinessModel);
                list.Add(crudeLocationCityBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeLocationCityModel model) {
            var data = new CrudeLocationCityData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeLocationCityModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationCityData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeLocationCityModel model) {
            var data = new CrudeLocationCityData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeLocationCityModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationCityData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid locationCityId) {
            CrudeLocationCityData.Delete(locationCityId);
        }
        
        public static void ModelToData(CrudeLocationCityModel model, CrudeLocationCityData data) {
            data.LocationCityId = model.LocationCityId;
            data.LocationCountryId = model.LocationCountryId;
            data.LocationCityCode = model.LocationCityCode;
            data.LocationCityName = model.LocationCityName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeLocationCityData data, CrudeLocationCityModel model) {
            model.LocationCityId = data.LocationCityId;
            model.LocationCountryId = data.LocationCountryId;
            model.LocationCityCode = data.LocationCityCode;
            model.LocationCityName = data.LocationCityName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
