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
    
    
    public partial class CrudeClientAddressTypeRefBusiness {
        
        public CrudeClientAddressTypeRefModel FetchByClientAddressTypeRcd(string clientAddressTypeRcd) {
            var dataAccessLayer = new CrudeClientAddressTypeRefData();
            var model = new CrudeClientAddressTypeRefModel();

            dataAccessLayer.FetchByClientAddressTypeRcd(clientAddressTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeClientAddressTypeRefModel FetchByClientAddressTypeName(string clientAddressTypeName) {
            var dataAccessLayer = new CrudeClientAddressTypeRefData();
            var model = new CrudeClientAddressTypeRefModel();

            dataAccessLayer.FetchByClientAddressTypeName(clientAddressTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientAddressTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientAddressTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientAddressTypeRefModel> DataListToModelList(List<CrudeClientAddressTypeRefData> dataList) {
            var modelList = new List<CrudeClientAddressTypeRefModel>();

            foreach (CrudeClientAddressTypeRefData data in dataList) {
                var model = new CrudeClientAddressTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientAddressTypeRefModel> modelList, List<CrudeClientAddressTypeRefData> dataList) {
            foreach (CrudeClientAddressTypeRefModel model in modelList) {
                var data = new CrudeClientAddressTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientAddressTypeRefModel> FetchAll() {
            var list = new List<CrudeClientAddressTypeRefModel>();
            List<CrudeClientAddressTypeRefData> dataList = CrudeClientAddressTypeRefData.FetchAll();

            foreach (CrudeClientAddressTypeRefData crudeClientAddressTypeRefBusiness in dataList) {
                var model = new CrudeClientAddressTypeRefModel();
                DataToModel(crudeClientAddressTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientAddressTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientAddressTypeRefModel>();
            List<CrudeClientAddressTypeRefData> dataList = CrudeClientAddressTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientAddressTypeRefData crudeClientAddressTypeRefBusiness in dataList) {
                var model = new CrudeClientAddressTypeRefModel();
                DataToModel(crudeClientAddressTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientAddressTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientAddressTypeRefModel>();
            List<CrudeClientAddressTypeRefData> dataList = CrudeClientAddressTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientAddressTypeRefData crudeClientAddressTypeRefBusiness in dataList) {
                var model = new CrudeClientAddressTypeRefModel();
                DataToModel(crudeClientAddressTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientAddressTypeRefData.FetchAllCount();

        }
        
        public List<CrudeClientAddressTypeRefModel> FetchWithFilter(string clientAddressTypeRcd, string clientAddressTypeName, string clientAddressTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientAddressTypeRefModel>();
            List<CrudeClientAddressTypeRefData> dataList = CrudeClientAddressTypeRefData.FetchWithFilter(clientAddressTypeRcd,clientAddressTypeName,clientAddressTypeDescription,activeFlag,sortOrder,userId,dateTime);

            foreach (CrudeClientAddressTypeRefData data in dataList) {
                var crudeClientAddressTypeRefBusinessModel = new CrudeClientAddressTypeRefModel();
                DataToModel(data, crudeClientAddressTypeRefBusinessModel);
                list.Add(crudeClientAddressTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientAddressTypeRefModel model) {
            var data = new CrudeClientAddressTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientAddressTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientAddressTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientAddressTypeRefModel model) {
            var data = new CrudeClientAddressTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientAddressTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientAddressTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientAddressTypeRcd) {
            CrudeClientAddressTypeRefData.Delete(clientAddressTypeRcd);
        }
        
        public static void ModelToData(CrudeClientAddressTypeRefModel model, CrudeClientAddressTypeRefData data) {
            data.ClientAddressTypeRcd = model.ClientAddressTypeRcd;
            data.ClientAddressTypeName = model.ClientAddressTypeName;
            data.ClientAddressTypeDescription = model.ClientAddressTypeDescription;
            data.ActiveFlag = model.ActiveFlag;
            data.SortOrder = model.SortOrder;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientAddressTypeRefData data, CrudeClientAddressTypeRefModel model) {
            model.ClientAddressTypeRcd = data.ClientAddressTypeRcd;
            model.ClientAddressTypeName = data.ClientAddressTypeName;
            model.ClientAddressTypeDescription = data.ClientAddressTypeDescription;
            model.ActiveFlag = data.ActiveFlag;
            model.SortOrder = data.SortOrder;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
