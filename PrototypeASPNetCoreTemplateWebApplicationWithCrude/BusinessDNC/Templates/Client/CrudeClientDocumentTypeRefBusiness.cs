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
    
    
    public partial class CrudeClientDocumentTypeRefBusiness {
        
        public CrudeClientDocumentTypeRefModel FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd) {
            var dataAccessLayer = new CrudeClientDocumentTypeRefData();
            var model = new CrudeClientDocumentTypeRefModel();

            dataAccessLayer.FetchByClientDocumentTypeRcd(clientDocumentTypeRcd);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeClientDocumentTypeRefModel FetchByClientDocumentTypeName(string clientDocumentTypeName) {
            var dataAccessLayer = new CrudeClientDocumentTypeRefData();
            var model = new CrudeClientDocumentTypeRefModel();

            dataAccessLayer.FetchByClientDocumentTypeName(clientDocumentTypeName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientDocumentTypeRefModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientDocumentTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientDocumentTypeRefModel> DataListToModelList(List<CrudeClientDocumentTypeRefData> dataList) {
            var modelList = new List<CrudeClientDocumentTypeRefModel>();

            foreach (CrudeClientDocumentTypeRefData data in dataList) {
                var model = new CrudeClientDocumentTypeRefModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientDocumentTypeRefModel> modelList, List<CrudeClientDocumentTypeRefData> dataList) {
            foreach (CrudeClientDocumentTypeRefModel model in modelList) {
                var data = new CrudeClientDocumentTypeRefData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientDocumentTypeRefModel> FetchAll() {
            var list = new List<CrudeClientDocumentTypeRefModel>();
            List<CrudeClientDocumentTypeRefData> dataList = CrudeClientDocumentTypeRefData.FetchAll();

            foreach (CrudeClientDocumentTypeRefData crudeClientDocumentTypeRefBusiness in dataList) {
                var model = new CrudeClientDocumentTypeRefModel();
                DataToModel(crudeClientDocumentTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientDocumentTypeRefModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientDocumentTypeRefModel>();
            List<CrudeClientDocumentTypeRefData> dataList = CrudeClientDocumentTypeRefData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientDocumentTypeRefData crudeClientDocumentTypeRefBusiness in dataList) {
                var model = new CrudeClientDocumentTypeRefModel();
                DataToModel(crudeClientDocumentTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientDocumentTypeRefModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientDocumentTypeRefModel>();
            List<CrudeClientDocumentTypeRefData> dataList = CrudeClientDocumentTypeRefData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientDocumentTypeRefData crudeClientDocumentTypeRefBusiness in dataList) {
                var model = new CrudeClientDocumentTypeRefModel();
                DataToModel(crudeClientDocumentTypeRefBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientDocumentTypeRefData.FetchAllCount();

        }
        
        public List<CrudeClientDocumentTypeRefModel> FetchWithFilter(string clientDocumentTypeRcd, string clientDocumentTypeName, string clientDocumentTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientDocumentTypeRefModel>();
            List<CrudeClientDocumentTypeRefData> dataList = CrudeClientDocumentTypeRefData.FetchWithFilter(clientDocumentTypeRcd,clientDocumentTypeName,clientDocumentTypeDescription,activeFlag,sortOrder,userId,dateTime);

            foreach (CrudeClientDocumentTypeRefData data in dataList) {
                var crudeClientDocumentTypeRefBusinessModel = new CrudeClientDocumentTypeRefModel();
                DataToModel(data, crudeClientDocumentTypeRefBusinessModel);
                list.Add(crudeClientDocumentTypeRefBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientDocumentTypeRefModel model) {
            var data = new CrudeClientDocumentTypeRefData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientDocumentTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientDocumentTypeRefData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientDocumentTypeRefModel model) {
            var data = new CrudeClientDocumentTypeRefData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientDocumentTypeRefModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientDocumentTypeRefData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientDocumentTypeRcd) {
            CrudeClientDocumentTypeRefData.Delete(clientDocumentTypeRcd);
        }
        
        public static void ModelToData(CrudeClientDocumentTypeRefModel model, CrudeClientDocumentTypeRefData data) {
            data.ClientDocumentTypeRcd = model.ClientDocumentTypeRcd;
            data.ClientDocumentTypeName = model.ClientDocumentTypeName;
            data.ClientDocumentTypeDescription = model.ClientDocumentTypeDescription;
            data.ActiveFlag = model.ActiveFlag;
            data.SortOrder = model.SortOrder;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientDocumentTypeRefData data, CrudeClientDocumentTypeRefModel model) {
            model.ClientDocumentTypeRcd = data.ClientDocumentTypeRcd;
            model.ClientDocumentTypeName = data.ClientDocumentTypeName;
            model.ClientDocumentTypeDescription = data.ClientDocumentTypeDescription;
            model.ActiveFlag = data.ActiveFlag;
            model.SortOrder = data.SortOrder;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
