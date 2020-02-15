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
    
    
    public partial class CrudeClientBusiness {
        
        public CrudeClientModel FetchByClientId(System.Guid clientId) {
            var dataAccessLayer = new CrudeClientData();
            var model = new CrudeClientModel();

            dataAccessLayer.FetchByClientId(clientId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeClientModel FetchByFirstName(string firstName) {
            var dataAccessLayer = new CrudeClientData();
            var model = new CrudeClientModel();

            dataAccessLayer.FetchByFirstName(firstName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientModel> FetchByClientTypeRcd(string clientTypeRcd) {
            return DataListToModelList(CrudeClientData.FetchByClientTypeRcd(clientTypeRcd));
        }
        
        public List<CrudeClientModel> FetchByClientNationalityRcd(string clientNationalityRcd) {
            return DataListToModelList(CrudeClientData.FetchByClientNationalityRcd(clientNationalityRcd));
        }
        
        public List<CrudeClientModel> FetchByClientGenderRcd(string clientGenderRcd) {
            return DataListToModelList(CrudeClientData.FetchByClientGenderRcd(clientGenderRcd));
        }
        
        public List<CrudeClientModel> FetchByClientTitleRcd(string clientTitleRcd) {
            return DataListToModelList(CrudeClientData.FetchByClientTitleRcd(clientTitleRcd));
        }
        
        public List<CrudeClientModel> FetchByClientAddressId(System.Guid clientAddressId) {
            return DataListToModelList(CrudeClientData.FetchByClientAddressId(clientAddressId));
        }
        
        public List<CrudeClientModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientModel> DataListToModelList(List<CrudeClientData> dataList) {
            var modelList = new List<CrudeClientModel>();

            foreach (CrudeClientData data in dataList) {
                var model = new CrudeClientModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientModel> modelList, List<CrudeClientData> dataList) {
            foreach (CrudeClientModel model in modelList) {
                var data = new CrudeClientData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientModel> FetchAll() {
            var list = new List<CrudeClientModel>();
            List<CrudeClientData> dataList = CrudeClientData.FetchAll();

            foreach (CrudeClientData crudeClientBusiness in dataList) {
                var model = new CrudeClientModel();
                DataToModel(crudeClientBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientModel>();
            List<CrudeClientData> dataList = CrudeClientData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientData crudeClientBusiness in dataList) {
                var model = new CrudeClientModel();
                DataToModel(crudeClientBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientModel>();
            List<CrudeClientData> dataList = CrudeClientData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientData crudeClientBusiness in dataList) {
                var model = new CrudeClientModel();
                DataToModel(crudeClientBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientData.FetchAllCount();

        }
        
        public List<CrudeClientModel> FetchWithFilter(System.Guid clientId, string clientTypeRcd, string clientNationalityRcd, string clientGenderRcd, string clientTitleRcd, System.Guid clientAddressId, string firstName, string middleName, string lastName, byte[] image, string imageBlobFilename, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientModel>();
            List<CrudeClientData> dataList = CrudeClientData.FetchWithFilter(clientId,clientTypeRcd,clientNationalityRcd,clientGenderRcd,clientTitleRcd,clientAddressId,firstName,middleName,lastName,image,imageBlobFilename,userId,dateTime);

            foreach (CrudeClientData data in dataList) {
                var crudeClientBusinessModel = new CrudeClientModel();
                DataToModel(data, crudeClientBusinessModel);
                list.Add(crudeClientBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientModel model) {
            var data = new CrudeClientData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientModel model) {
            var data = new CrudeClientData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid clientId) {
            CrudeClientData.Delete(clientId);
        }
        
        public static void ModelToData(CrudeClientModel model, CrudeClientData data) {
            data.ClientId = model.ClientId;
            data.ClientTypeRcd = model.ClientTypeRcd;
            data.ClientNationalityRcd = model.ClientNationalityRcd;
            data.ClientGenderRcd = model.ClientGenderRcd;
            data.ClientTitleRcd = model.ClientTitleRcd;
            data.ClientAddressId = model.ClientAddressId;
            data.FirstName = model.FirstName;
            data.MiddleName = model.MiddleName;
            data.LastName = model.LastName;
            data.Image = model.Image;
            data.ImageBlobFilename = model.ImageBlobFilename;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientData data, CrudeClientModel model) {
            model.ClientId = data.ClientId;
            model.ClientTypeRcd = data.ClientTypeRcd;
            model.ClientNationalityRcd = data.ClientNationalityRcd;
            model.ClientGenderRcd = data.ClientGenderRcd;
            model.ClientTitleRcd = data.ClientTitleRcd;
            model.ClientAddressId = data.ClientAddressId;
            model.FirstName = data.FirstName;
            model.MiddleName = data.MiddleName;
            model.LastName = data.LastName;
            model.Image = data.Image;
            model.ImageBlobFilename = data.ImageBlobFilename;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
