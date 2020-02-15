/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:17 AM
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
    
    
    public partial class CrudeClientDocumentBusiness {
        
        public CrudeClientDocumentModel FetchByClientDocumentId(System.Guid clientDocumentId) {
            var dataAccessLayer = new CrudeClientDocumentData();
            var model = new CrudeClientDocumentModel();

            dataAccessLayer.FetchByClientDocumentId(clientDocumentId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeClientDocumentModel FetchByDocumentName(string documentName) {
            var dataAccessLayer = new CrudeClientDocumentData();
            var model = new CrudeClientDocumentModel();

            dataAccessLayer.FetchByDocumentName(documentName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientDocumentModel> FetchByClientId(System.Guid clientId) {
            return DataListToModelList(CrudeClientDocumentData.FetchByClientId(clientId));
        }
        
        public List<CrudeClientDocumentModel> FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd) {
            return DataListToModelList(CrudeClientDocumentData.FetchByClientDocumentTypeRcd(clientDocumentTypeRcd));
        }
        
        public List<CrudeClientDocumentModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientDocumentData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientDocumentModel> DataListToModelList(List<CrudeClientDocumentData> dataList) {
            var modelList = new List<CrudeClientDocumentModel>();

            foreach (CrudeClientDocumentData data in dataList) {
                var model = new CrudeClientDocumentModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientDocumentModel> modelList, List<CrudeClientDocumentData> dataList) {
            foreach (CrudeClientDocumentModel model in modelList) {
                var data = new CrudeClientDocumentData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientDocumentModel> FetchAll() {
            var list = new List<CrudeClientDocumentModel>();
            List<CrudeClientDocumentData> dataList = CrudeClientDocumentData.FetchAll();

            foreach (CrudeClientDocumentData crudeClientDocumentBusiness in dataList) {
                var model = new CrudeClientDocumentModel();
                DataToModel(crudeClientDocumentBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientDocumentModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientDocumentModel>();
            List<CrudeClientDocumentData> dataList = CrudeClientDocumentData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientDocumentData crudeClientDocumentBusiness in dataList) {
                var model = new CrudeClientDocumentModel();
                DataToModel(crudeClientDocumentBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientDocumentModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientDocumentModel>();
            List<CrudeClientDocumentData> dataList = CrudeClientDocumentData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientDocumentData crudeClientDocumentBusiness in dataList) {
                var model = new CrudeClientDocumentModel();
                DataToModel(crudeClientDocumentBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientDocumentData.FetchAllCount();

        }
        
        public List<CrudeClientDocumentModel> FetchWithFilter(System.Guid clientDocumentId, System.Guid clientId, string clientDocumentTypeRcd, string documentName, System.DateTime documentDateTime, System.DateTime expiryDateTime, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientDocumentModel>();
            List<CrudeClientDocumentData> dataList = CrudeClientDocumentData.FetchWithFilter(clientDocumentId,clientId,clientDocumentTypeRcd,documentName,documentDateTime,expiryDateTime,userId,dateTime);

            foreach (CrudeClientDocumentData data in dataList) {
                var crudeClientDocumentBusinessModel = new CrudeClientDocumentModel();
                DataToModel(data, crudeClientDocumentBusinessModel);
                list.Add(crudeClientDocumentBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientDocumentModel model) {
            var data = new CrudeClientDocumentData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientDocumentModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientDocumentData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientDocumentModel model) {
            var data = new CrudeClientDocumentData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientDocumentModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientDocumentData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid clientDocumentId) {
            CrudeClientDocumentData.Delete(clientDocumentId);
        }
        
        public static void ModelToData(CrudeClientDocumentModel model, CrudeClientDocumentData data) {
            data.ClientDocumentId = model.ClientDocumentId;
            data.ClientId = model.ClientId;
            data.ClientDocumentTypeRcd = model.ClientDocumentTypeRcd;
            data.DocumentName = model.DocumentName;
            data.DocumentDateTime = model.DocumentDateTime;
            data.ExpiryDateTime = model.ExpiryDateTime;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientDocumentData data, CrudeClientDocumentModel model) {
            model.ClientDocumentId = data.ClientDocumentId;
            model.ClientId = data.ClientId;
            model.ClientDocumentTypeRcd = data.ClientDocumentTypeRcd;
            model.DocumentName = data.DocumentName;
            model.DocumentDateTime = data.DocumentDateTime;
            model.ExpiryDateTime = data.ExpiryDateTime;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
