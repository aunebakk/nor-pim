/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:44:31 PM
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
    
    
    public partial class CrudeClientIdentifierBusiness {
        
        public CrudeClientIdentifierModel FetchByClientIdentifierId(System.Guid clientIdentifierId) {
            var dataAccessLayer = new CrudeClientIdentifierData();
            var model = new CrudeClientIdentifierModel();

            dataAccessLayer.FetchByClientIdentifierId(clientIdentifierId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientIdentifierModel> FetchByClientId(System.Guid clientId) {
            return DataListToModelList(CrudeClientIdentifierData.FetchByClientId(clientId));
        }
        
        public List<CrudeClientIdentifierModel> FetchByClientIdentifierTypeRcd(string clientIdentifierTypeRcd) {
            return DataListToModelList(CrudeClientIdentifierData.FetchByClientIdentifierTypeRcd(clientIdentifierTypeRcd));
        }
        
        public List<CrudeClientIdentifierModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientIdentifierData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientIdentifierModel> DataListToModelList(List<CrudeClientIdentifierData> dataList) {
            var modelList = new List<CrudeClientIdentifierModel>();

            foreach (CrudeClientIdentifierData data in dataList) {
                var model = new CrudeClientIdentifierModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientIdentifierModel> modelList, List<CrudeClientIdentifierData> dataList) {
            foreach (CrudeClientIdentifierModel model in modelList) {
                var data = new CrudeClientIdentifierData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientIdentifierModel> FetchAll() {
            var list = new List<CrudeClientIdentifierModel>();
            List<CrudeClientIdentifierData> dataList = CrudeClientIdentifierData.FetchAll();

            foreach (CrudeClientIdentifierData crudeClientIdentifierBusiness in dataList) {
                var model = new CrudeClientIdentifierModel();
                DataToModel(crudeClientIdentifierBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientIdentifierModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientIdentifierModel>();
            List<CrudeClientIdentifierData> dataList = CrudeClientIdentifierData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientIdentifierData crudeClientIdentifierBusiness in dataList) {
                var model = new CrudeClientIdentifierModel();
                DataToModel(crudeClientIdentifierBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientIdentifierModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientIdentifierModel>();
            List<CrudeClientIdentifierData> dataList = CrudeClientIdentifierData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientIdentifierData crudeClientIdentifierBusiness in dataList) {
                var model = new CrudeClientIdentifierModel();
                DataToModel(crudeClientIdentifierBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientIdentifierData.FetchAllCount();

        }
        
        public List<CrudeClientIdentifierModel> FetchWithFilter(System.Guid clientIdentifierId, System.Guid clientId, string clientIdentifierTypeRcd, string clientIdentifierCode, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientIdentifierModel>();
            List<CrudeClientIdentifierData> dataList = CrudeClientIdentifierData.FetchWithFilter(clientIdentifierId,clientId,clientIdentifierTypeRcd,clientIdentifierCode,userId,dateTime);

            foreach (CrudeClientIdentifierData data in dataList) {
                var crudeClientIdentifierBusinessModel = new CrudeClientIdentifierModel();
                DataToModel(data, crudeClientIdentifierBusinessModel);
                list.Add(crudeClientIdentifierBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientIdentifierModel model) {
            var data = new CrudeClientIdentifierData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientIdentifierModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientIdentifierData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientIdentifierModel model) {
            var data = new CrudeClientIdentifierData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientIdentifierModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientIdentifierData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid clientIdentifierId) {
            CrudeClientIdentifierData.Delete(clientIdentifierId);
        }
        
        public static void ModelToData(CrudeClientIdentifierModel model, CrudeClientIdentifierData data) {
            data.ClientIdentifierId = model.ClientIdentifierId;
            data.ClientId = model.ClientId;
            data.ClientIdentifierTypeRcd = model.ClientIdentifierTypeRcd;
            data.ClientIdentifierCode = model.ClientIdentifierCode;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientIdentifierData data, CrudeClientIdentifierModel model) {
            model.ClientIdentifierId = data.ClientIdentifierId;
            model.ClientId = data.ClientId;
            model.ClientIdentifierTypeRcd = data.ClientIdentifierTypeRcd;
            model.ClientIdentifierCode = data.ClientIdentifierCode;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
