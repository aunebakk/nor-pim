/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:29 PM
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
    
    
    public partial class CrudeClientEventTypeRefBusiness {
        
        public CrudeClientEventTypeRefModel FetchByClientEventTypeRcd(string clientEventTypeRcd) {
            var dataAccessLayer = new CrudeClientEventTypeRefData();
            var model = new CrudeClientEventTypeRefModel();

            dataAccessLayer.FetchByClientEventTypeRcd(clientEventTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeClientEventTypeRefModel FetchByClientEventTypeName(string clientEventTypeName) {
            var dataAccessLayer = new CrudeClientEventTypeRefData();
            var model = new CrudeClientEventTypeRefModel();

            dataAccessLayer.FetchByClientEventTypeName(clientEventTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientEventTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientEventTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientEventTypeRefModel> DataListToModelList(List<CrudeClientEventTypeRefData> dataList) {
            var modelList = new List<CrudeClientEventTypeRefModel>();

            foreach (CrudeClientEventTypeRefData data in dataList) {
                var model = new CrudeClientEventTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientEventTypeRefModel> modelList, List<CrudeClientEventTypeRefData> dataList) {
            foreach (CrudeClientEventTypeRefModel model in modelList) {
                var data = new CrudeClientEventTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientEventTypeRefModel> FetchAll() {
            var list = new List<CrudeClientEventTypeRefModel>();
            List<CrudeClientEventTypeRefData> dataList = CrudeClientEventTypeRefData.FetchAll();

            foreach (CrudeClientEventTypeRefData crudeClientEventTypeRefBusiness in dataList) {
                var model = new CrudeClientEventTypeRefModel();
                DataToModel(crudeClientEventTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientEventTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientEventTypeRefModel>();
            List<CrudeClientEventTypeRefData> dataList = CrudeClientEventTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientEventTypeRefData crudeClientEventTypeRefBusiness in dataList) {
                var model = new CrudeClientEventTypeRefModel();
                DataToModel(crudeClientEventTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientEventTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientEventTypeRefModel>();
            List<CrudeClientEventTypeRefData> dataList = CrudeClientEventTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientEventTypeRefData crudeClientEventTypeRefBusiness in dataList) {
                var model = new CrudeClientEventTypeRefModel();
                DataToModel(crudeClientEventTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientEventTypeRefData.FetchAllCount();

        }
        
        public List<CrudeClientEventTypeRefModel> FetchWithFilter(string clientEventTypeRcd, string clientEventTypeName, string clientEventTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientEventTypeRefModel>();
            List<CrudeClientEventTypeRefData> dataList = CrudeClientEventTypeRefData.FetchWithFilter(clientEventTypeRcd,clientEventTypeName,clientEventTypeDescription,activeFlag,sortOrder,userId,dateTime);

            foreach (CrudeClientEventTypeRefData data in dataList) {
                var crudeClientEventTypeRefBusinessModel = new CrudeClientEventTypeRefModel();
                DataToModel(data, crudeClientEventTypeRefBusinessModel);
                list.Add(crudeClientEventTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientEventTypeRefModel model) {
            var data = new CrudeClientEventTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientEventTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientEventTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientEventTypeRefModel model) {
            var data = new CrudeClientEventTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientEventTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientEventTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientEventTypeRcd) {
            CrudeClientEventTypeRefData.Delete(clientEventTypeRcd);
        }
        
        public static void ModelToData(CrudeClientEventTypeRefModel model, CrudeClientEventTypeRefData data) {
            data.ClientEventTypeRcd = model.ClientEventTypeRcd;
            data.ClientEventTypeName = model.ClientEventTypeName;
            data.ClientEventTypeDescription = model.ClientEventTypeDescription;
            data.ActiveFlag = model.ActiveFlag;
            data.SortOrder = model.SortOrder;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientEventTypeRefData data, CrudeClientEventTypeRefModel model) {
            model.ClientEventTypeRcd = data.ClientEventTypeRcd;
            model.ClientEventTypeName = data.ClientEventTypeName;
            model.ClientEventTypeDescription = data.ClientEventTypeDescription;
            model.ActiveFlag = data.ActiveFlag;
            model.SortOrder = data.SortOrder;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
