/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:20:52 PM
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
    
    
    public partial class CrudeClientTypeRefBusiness {
        
        public CrudeClientTypeRefModel FetchByClientTypeRcd(string clientTypeRcd) {
            var dataAccessLayer = new CrudeClientTypeRefData();
            var model = new CrudeClientTypeRefModel();

            dataAccessLayer.FetchByClientTypeRcd(clientTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeClientTypeRefModel FetchByClientTypeName(string clientTypeName) {
            var dataAccessLayer = new CrudeClientTypeRefData();
            var model = new CrudeClientTypeRefModel();

            dataAccessLayer.FetchByClientTypeName(clientTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientTypeRefModel> DataListToModelList(List<CrudeClientTypeRefData> dataList) {
            var modelList = new List<CrudeClientTypeRefModel>();

            foreach (CrudeClientTypeRefData data in dataList) {
                var model = new CrudeClientTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientTypeRefModel> modelList, List<CrudeClientTypeRefData> dataList) {
            foreach (CrudeClientTypeRefModel model in modelList) {
                var data = new CrudeClientTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientTypeRefModel> FetchAll() {
            var list = new List<CrudeClientTypeRefModel>();
            List<CrudeClientTypeRefData> dataList = CrudeClientTypeRefData.FetchAll();

            foreach (CrudeClientTypeRefData crudeClientTypeRefBusiness in dataList) {
                var model = new CrudeClientTypeRefModel();
                DataToModel(crudeClientTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientTypeRefModel>();
            List<CrudeClientTypeRefData> dataList = CrudeClientTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientTypeRefData crudeClientTypeRefBusiness in dataList) {
                var model = new CrudeClientTypeRefModel();
                DataToModel(crudeClientTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientTypeRefModel>();
            List<CrudeClientTypeRefData> dataList = CrudeClientTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientTypeRefData crudeClientTypeRefBusiness in dataList) {
                var model = new CrudeClientTypeRefModel();
                DataToModel(crudeClientTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientTypeRefData.FetchAllCount();

        }
        
        public List<CrudeClientTypeRefModel> FetchWithFilter(string clientTypeRcd, string clientTypeName, string clientTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientTypeRefModel>();
            List<CrudeClientTypeRefData> dataList = CrudeClientTypeRefData.FetchWithFilter(clientTypeRcd,clientTypeName,clientTypeDescription,activeFlag,sortOrder,userId,dateTime);

            foreach (CrudeClientTypeRefData data in dataList) {
                var crudeClientTypeRefBusinessModel = new CrudeClientTypeRefModel();
                DataToModel(data, crudeClientTypeRefBusinessModel);
                list.Add(crudeClientTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientTypeRefModel model) {
            var data = new CrudeClientTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientTypeRefModel model) {
            var data = new CrudeClientTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientTypeRcd) {
            CrudeClientTypeRefData.Delete(clientTypeRcd);
        }
        
        public static void ModelToData(CrudeClientTypeRefModel model, CrudeClientTypeRefData data) {
            data.ClientTypeRcd = model.ClientTypeRcd;
            data.ClientTypeName = model.ClientTypeName;
            data.ClientTypeDescription = model.ClientTypeDescription;
            data.ActiveFlag = model.ActiveFlag;
            data.SortOrder = model.SortOrder;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientTypeRefData data, CrudeClientTypeRefModel model) {
            model.ClientTypeRcd = data.ClientTypeRcd;
            model.ClientTypeName = data.ClientTypeName;
            model.ClientTypeDescription = data.ClientTypeDescription;
            model.ActiveFlag = data.ActiveFlag;
            model.SortOrder = data.SortOrder;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
