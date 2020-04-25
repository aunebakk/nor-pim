/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:45:43 AM
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
    
    
    public partial class CrudeLocationAddressTypeRefBusiness {
        
        public CrudeLocationAddressTypeRefModel FetchByLocationAddressTypeRcd(string locationAddressTypeRcd) {
            var dataAccessLayer = new CrudeLocationAddressTypeRefData();
            var model = new CrudeLocationAddressTypeRefModel();

            dataAccessLayer.FetchByLocationAddressTypeRcd(locationAddressTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeLocationAddressTypeRefModel FetchByLocationAddressTypeName(string locationAddressTypeName) {
            var dataAccessLayer = new CrudeLocationAddressTypeRefData();
            var model = new CrudeLocationAddressTypeRefModel();

            dataAccessLayer.FetchByLocationAddressTypeName(locationAddressTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeLocationAddressTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeLocationAddressTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeLocationAddressTypeRefModel> DataListToModelList(List<CrudeLocationAddressTypeRefData> dataList) {
            var modelList = new List<CrudeLocationAddressTypeRefModel>();

            foreach (CrudeLocationAddressTypeRefData data in dataList) {
                var model = new CrudeLocationAddressTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeLocationAddressTypeRefModel> modelList, List<CrudeLocationAddressTypeRefData> dataList) {
            foreach (CrudeLocationAddressTypeRefModel model in modelList) {
                var data = new CrudeLocationAddressTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeLocationAddressTypeRefModel> FetchAll() {
            var list = new List<CrudeLocationAddressTypeRefModel>();
            List<CrudeLocationAddressTypeRefData> dataList = CrudeLocationAddressTypeRefData.FetchAll();

            foreach (CrudeLocationAddressTypeRefData crudeLocationAddressTypeRefBusiness in dataList) {
                var model = new CrudeLocationAddressTypeRefModel();
                DataToModel(crudeLocationAddressTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeLocationAddressTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeLocationAddressTypeRefModel>();
            List<CrudeLocationAddressTypeRefData> dataList = CrudeLocationAddressTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeLocationAddressTypeRefData crudeLocationAddressTypeRefBusiness in dataList) {
                var model = new CrudeLocationAddressTypeRefModel();
                DataToModel(crudeLocationAddressTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeLocationAddressTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeLocationAddressTypeRefModel>();
            List<CrudeLocationAddressTypeRefData> dataList = CrudeLocationAddressTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeLocationAddressTypeRefData crudeLocationAddressTypeRefBusiness in dataList) {
                var model = new CrudeLocationAddressTypeRefModel();
                DataToModel(crudeLocationAddressTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeLocationAddressTypeRefData.FetchAllCount();

        }
        
        public List<CrudeLocationAddressTypeRefModel> FetchWithFilter(string locationAddressTypeRcd, string locationAddressTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeLocationAddressTypeRefModel>();
            List<CrudeLocationAddressTypeRefData> dataList = CrudeLocationAddressTypeRefData.FetchWithFilter(locationAddressTypeRcd,locationAddressTypeName,userId,dateTime);

            foreach (CrudeLocationAddressTypeRefData data in dataList) {
                var crudeLocationAddressTypeRefBusinessModel = new CrudeLocationAddressTypeRefModel();
                DataToModel(data, crudeLocationAddressTypeRefBusinessModel);
                list.Add(crudeLocationAddressTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeLocationAddressTypeRefModel model) {
            var data = new CrudeLocationAddressTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeLocationAddressTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationAddressTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeLocationAddressTypeRefModel model) {
            var data = new CrudeLocationAddressTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeLocationAddressTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationAddressTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string locationAddressTypeRcd) {
            CrudeLocationAddressTypeRefData.Delete(locationAddressTypeRcd);
        }
        
        public static void ModelToData(CrudeLocationAddressTypeRefModel model, CrudeLocationAddressTypeRefData data) {
            data.LocationAddressTypeRcd = model.LocationAddressTypeRcd;
            data.LocationAddressTypeName = model.LocationAddressTypeName;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeLocationAddressTypeRefData data, CrudeLocationAddressTypeRefModel model) {
            model.LocationAddressTypeRcd = data.LocationAddressTypeRcd;
            model.LocationAddressTypeName = data.LocationAddressTypeName;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
