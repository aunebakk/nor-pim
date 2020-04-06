/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:27 PM
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
    
    
    public partial class CrudeClientContactMethodBusiness {
        
        public CrudeClientContactMethodModel FetchByClientContactMethodId(System.Guid clientContactMethodId) {
            var dataAccessLayer = new CrudeClientContactMethodData();
            var model = new CrudeClientContactMethodModel();

            dataAccessLayer.FetchByClientContactMethodId(clientContactMethodId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientContactMethodModel> FetchByClientId(System.Guid clientId) {
            return DataListToModelList(CrudeClientContactMethodData.FetchByClientId(clientId));
        }
        
        public List<CrudeClientContactMethodModel> FetchByClientContactMethodRcd(string clientContactMethodRcd) {
            return DataListToModelList(CrudeClientContactMethodData.FetchByClientContactMethodRcd(clientContactMethodRcd));
        }
        
        public List<CrudeClientContactMethodModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientContactMethodData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientContactMethodModel> DataListToModelList(List<CrudeClientContactMethodData> dataList) {
            var modelList = new List<CrudeClientContactMethodModel>();

            foreach (CrudeClientContactMethodData data in dataList) {
                var model = new CrudeClientContactMethodModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientContactMethodModel> modelList, List<CrudeClientContactMethodData> dataList) {
            foreach (CrudeClientContactMethodModel model in modelList) {
                var data = new CrudeClientContactMethodData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientContactMethodModel> FetchAll() {
            var list = new List<CrudeClientContactMethodModel>();
            List<CrudeClientContactMethodData> dataList = CrudeClientContactMethodData.FetchAll();

            foreach (CrudeClientContactMethodData crudeClientContactMethodBusiness in dataList) {
                var model = new CrudeClientContactMethodModel();
                DataToModel(crudeClientContactMethodBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientContactMethodModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientContactMethodModel>();
            List<CrudeClientContactMethodData> dataList = CrudeClientContactMethodData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientContactMethodData crudeClientContactMethodBusiness in dataList) {
                var model = new CrudeClientContactMethodModel();
                DataToModel(crudeClientContactMethodBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientContactMethodModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientContactMethodModel>();
            List<CrudeClientContactMethodData> dataList = CrudeClientContactMethodData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientContactMethodData crudeClientContactMethodBusiness in dataList) {
                var model = new CrudeClientContactMethodModel();
                DataToModel(crudeClientContactMethodBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientContactMethodData.FetchAllCount();

        }
        
        public List<CrudeClientContactMethodModel> FetchWithFilter(System.Guid clientContactMethodId, System.Guid clientId, string clientContactMethodRcd, string contactMethodWay, string comment, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientContactMethodModel>();
            List<CrudeClientContactMethodData> dataList = CrudeClientContactMethodData.FetchWithFilter(clientContactMethodId,clientId,clientContactMethodRcd,contactMethodWay,comment,userId,dateTime);

            foreach (CrudeClientContactMethodData data in dataList) {
                var crudeClientContactMethodBusinessModel = new CrudeClientContactMethodModel();
                DataToModel(data, crudeClientContactMethodBusinessModel);
                list.Add(crudeClientContactMethodBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientContactMethodModel model) {
            var data = new CrudeClientContactMethodData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientContactMethodModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientContactMethodData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientContactMethodModel model) {
            var data = new CrudeClientContactMethodData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientContactMethodModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientContactMethodData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid clientContactMethodId) {
            CrudeClientContactMethodData.Delete(clientContactMethodId);
        }
        
        public static void ModelToData(CrudeClientContactMethodModel model, CrudeClientContactMethodData data) {
            data.ClientContactMethodId = model.ClientContactMethodId;
            data.ClientId = model.ClientId;
            data.ClientContactMethodRcd = model.ClientContactMethodRcd;
            data.ContactMethodWay = model.ContactMethodWay;
            data.Comment = model.Comment;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientContactMethodData data, CrudeClientContactMethodModel model) {
            model.ClientContactMethodId = data.ClientContactMethodId;
            model.ClientId = data.ClientId;
            model.ClientContactMethodRcd = data.ClientContactMethodRcd;
            model.ContactMethodWay = data.ContactMethodWay;
            model.Comment = data.Comment;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
