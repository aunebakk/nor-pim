/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:47:41 AM
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
    
    
    public partial class CrudeClientLinkBusiness {
        
        public CrudeClientLinkModel FetchByClientLinkId(System.Guid clientLinkId) {
            var dataAccessLayer = new CrudeClientLinkData();
            var model = new CrudeClientLinkModel();

            dataAccessLayer.FetchByClientLinkId(clientLinkId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeClientLinkModel FetchByLinkName(string linkName) {
            var dataAccessLayer = new CrudeClientLinkData();
            var model = new CrudeClientLinkModel();

            dataAccessLayer.FetchByLinkName(linkName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientLinkModel> FetchByClientId(System.Guid clientId) {
            return DataListToModelList(CrudeClientLinkData.FetchByClientId(clientId));
        }
        
        public List<CrudeClientLinkModel> FetchByClientLinkTypeRcd(string clientLinkTypeRcd) {
            return DataListToModelList(CrudeClientLinkData.FetchByClientLinkTypeRcd(clientLinkTypeRcd));
        }
        
        public List<CrudeClientLinkModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientLinkData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientLinkModel> DataListToModelList(List<CrudeClientLinkData> dataList) {
            var modelList = new List<CrudeClientLinkModel>();

            foreach (CrudeClientLinkData data in dataList) {
                var model = new CrudeClientLinkModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientLinkModel> modelList, List<CrudeClientLinkData> dataList) {
            foreach (CrudeClientLinkModel model in modelList) {
                var data = new CrudeClientLinkData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientLinkModel> FetchAll() {
            var list = new List<CrudeClientLinkModel>();
            List<CrudeClientLinkData> dataList = CrudeClientLinkData.FetchAll();

            foreach (CrudeClientLinkData crudeClientLinkBusiness in dataList) {
                var model = new CrudeClientLinkModel();
                DataToModel(crudeClientLinkBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientLinkModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientLinkModel>();
            List<CrudeClientLinkData> dataList = CrudeClientLinkData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientLinkData crudeClientLinkBusiness in dataList) {
                var model = new CrudeClientLinkModel();
                DataToModel(crudeClientLinkBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientLinkModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientLinkModel>();
            List<CrudeClientLinkData> dataList = CrudeClientLinkData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientLinkData crudeClientLinkBusiness in dataList) {
                var model = new CrudeClientLinkModel();
                DataToModel(crudeClientLinkBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientLinkData.FetchAllCount();

        }
        
        public List<CrudeClientLinkModel> FetchWithFilter(System.Guid clientLinkId, System.Guid clientId, string clientLinkTypeRcd, string linkName, string link, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientLinkModel>();
            List<CrudeClientLinkData> dataList = CrudeClientLinkData.FetchWithFilter(clientLinkId,clientId,clientLinkTypeRcd,linkName,link,userId,dateTime);

            foreach (CrudeClientLinkData data in dataList) {
                var crudeClientLinkBusinessModel = new CrudeClientLinkModel();
                DataToModel(data, crudeClientLinkBusinessModel);
                list.Add(crudeClientLinkBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientLinkModel model) {
            var data = new CrudeClientLinkData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientLinkModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientLinkData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientLinkModel model) {
            var data = new CrudeClientLinkData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientLinkModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientLinkData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid clientLinkId) {
            CrudeClientLinkData.Delete(clientLinkId);
        }
        
        public static void ModelToData(CrudeClientLinkModel model, CrudeClientLinkData data) {
            data.ClientLinkId = model.ClientLinkId;
            data.ClientId = model.ClientId;
            data.ClientLinkTypeRcd = model.ClientLinkTypeRcd;
            data.LinkName = model.LinkName;
            data.Link = model.Link;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientLinkData data, CrudeClientLinkModel model) {
            model.ClientLinkId = data.ClientLinkId;
            model.ClientId = data.ClientId;
            model.ClientLinkTypeRcd = data.ClientLinkTypeRcd;
            model.LinkName = data.LinkName;
            model.Link = data.Link;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
