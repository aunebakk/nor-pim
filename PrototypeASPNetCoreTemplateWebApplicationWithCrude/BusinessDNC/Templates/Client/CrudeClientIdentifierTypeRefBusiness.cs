/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:18 AM
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
    
    
    public partial class CrudeClientIdentifierTypeRefBusiness {
        
        public CrudeClientIdentifierTypeRefModel FetchByClientIdentifierTypeRcd(string clientIdentifierTypeRcd) {
            var dataAccessLayer = new CrudeClientIdentifierTypeRefData();
            var model = new CrudeClientIdentifierTypeRefModel();

            dataAccessLayer.FetchByClientIdentifierTypeRcd(clientIdentifierTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeClientIdentifierTypeRefModel FetchByClientIdentifierTypeName(string clientIdentifierTypeName) {
            var dataAccessLayer = new CrudeClientIdentifierTypeRefData();
            var model = new CrudeClientIdentifierTypeRefModel();

            dataAccessLayer.FetchByClientIdentifierTypeName(clientIdentifierTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientIdentifierTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientIdentifierTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientIdentifierTypeRefModel> DataListToModelList(List<CrudeClientIdentifierTypeRefData> dataList) {
            var modelList = new List<CrudeClientIdentifierTypeRefModel>();

            foreach (CrudeClientIdentifierTypeRefData data in dataList) {
                var model = new CrudeClientIdentifierTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientIdentifierTypeRefModel> modelList, List<CrudeClientIdentifierTypeRefData> dataList) {
            foreach (CrudeClientIdentifierTypeRefModel model in modelList) {
                var data = new CrudeClientIdentifierTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientIdentifierTypeRefModel> FetchAll() {
            var list = new List<CrudeClientIdentifierTypeRefModel>();
            List<CrudeClientIdentifierTypeRefData> dataList = CrudeClientIdentifierTypeRefData.FetchAll();

            foreach (CrudeClientIdentifierTypeRefData crudeClientIdentifierTypeRefBusiness in dataList) {
                var model = new CrudeClientIdentifierTypeRefModel();
                DataToModel(crudeClientIdentifierTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientIdentifierTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientIdentifierTypeRefModel>();
            List<CrudeClientIdentifierTypeRefData> dataList = CrudeClientIdentifierTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientIdentifierTypeRefData crudeClientIdentifierTypeRefBusiness in dataList) {
                var model = new CrudeClientIdentifierTypeRefModel();
                DataToModel(crudeClientIdentifierTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientIdentifierTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientIdentifierTypeRefModel>();
            List<CrudeClientIdentifierTypeRefData> dataList = CrudeClientIdentifierTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientIdentifierTypeRefData crudeClientIdentifierTypeRefBusiness in dataList) {
                var model = new CrudeClientIdentifierTypeRefModel();
                DataToModel(crudeClientIdentifierTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientIdentifierTypeRefData.FetchAllCount();

        }
        
        public List<CrudeClientIdentifierTypeRefModel> FetchWithFilter(string clientIdentifierTypeRcd, string clientIdentifierTypeName, string clientIdentifierTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientIdentifierTypeRefModel>();
            List<CrudeClientIdentifierTypeRefData> dataList = CrudeClientIdentifierTypeRefData.FetchWithFilter(clientIdentifierTypeRcd,clientIdentifierTypeName,clientIdentifierTypeDescription,activeFlag,sortOrder,userId,dateTime);

            foreach (CrudeClientIdentifierTypeRefData data in dataList) {
                var crudeClientIdentifierTypeRefBusinessModel = new CrudeClientIdentifierTypeRefModel();
                DataToModel(data, crudeClientIdentifierTypeRefBusinessModel);
                list.Add(crudeClientIdentifierTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientIdentifierTypeRefModel model) {
            var data = new CrudeClientIdentifierTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientIdentifierTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientIdentifierTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientIdentifierTypeRefModel model) {
            var data = new CrudeClientIdentifierTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientIdentifierTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientIdentifierTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientIdentifierTypeRcd) {
            CrudeClientIdentifierTypeRefData.Delete(clientIdentifierTypeRcd);
        }
        
        public static void ModelToData(CrudeClientIdentifierTypeRefModel model, CrudeClientIdentifierTypeRefData data) {
            data.ClientIdentifierTypeRcd = model.ClientIdentifierTypeRcd;
            data.ClientIdentifierTypeName = model.ClientIdentifierTypeName;
            data.ClientIdentifierTypeDescription = model.ClientIdentifierTypeDescription;
            data.ActiveFlag = model.ActiveFlag;
            data.SortOrder = model.SortOrder;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientIdentifierTypeRefData data, CrudeClientIdentifierTypeRefModel model) {
            model.ClientIdentifierTypeRcd = data.ClientIdentifierTypeRcd;
            model.ClientIdentifierTypeName = data.ClientIdentifierTypeName;
            model.ClientIdentifierTypeDescription = data.ClientIdentifierTypeDescription;
            model.ActiveFlag = data.ActiveFlag;
            model.SortOrder = data.SortOrder;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
