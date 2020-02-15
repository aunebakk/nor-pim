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
    
    
    public partial class CrudeClientAddressBusiness {
        
        public CrudeClientAddressModel FetchByClientAddressId(System.Guid clientAddressId) {
            var dataAccessLayer = new CrudeClientAddressData();
            var model = new CrudeClientAddressModel();

            dataAccessLayer.FetchByClientAddressId(clientAddressId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public CrudeClientAddressModel FetchByAddressLineOneName(string addressLineOneName) {
            var dataAccessLayer = new CrudeClientAddressData();
            var model = new CrudeClientAddressModel();

            dataAccessLayer.FetchByAddressLineOneName(addressLineOneName);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeClientAddressModel> FetchByClientId(System.Guid clientId) {
            return DataListToModelList(CrudeClientAddressData.FetchByClientId(clientId));
        }
        
        public List<CrudeClientAddressModel> FetchByClientAddressTypeRcd(string clientAddressTypeRcd) {
            return DataListToModelList(CrudeClientAddressData.FetchByClientAddressTypeRcd(clientAddressTypeRcd));
        }
        
        public List<CrudeClientAddressModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeClientAddressData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientAddressModel> DataListToModelList(List<CrudeClientAddressData> dataList) {
            var modelList = new List<CrudeClientAddressModel>();

            foreach (CrudeClientAddressData data in dataList) {
                var model = new CrudeClientAddressModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeClientAddressModel> modelList, List<CrudeClientAddressData> dataList) {
            foreach (CrudeClientAddressModel model in modelList) {
                var data = new CrudeClientAddressData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientAddressModel> FetchAll() {
            var list = new List<CrudeClientAddressModel>();
            List<CrudeClientAddressData> dataList = CrudeClientAddressData.FetchAll();

            foreach (CrudeClientAddressData crudeClientAddressBusiness in dataList) {
                var model = new CrudeClientAddressModel();
                DataToModel(crudeClientAddressBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientAddressModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeClientAddressModel>();
            List<CrudeClientAddressData> dataList = CrudeClientAddressData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeClientAddressData crudeClientAddressBusiness in dataList) {
                var model = new CrudeClientAddressModel();
                DataToModel(crudeClientAddressBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeClientAddressModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeClientAddressModel>();
            List<CrudeClientAddressData> dataList = CrudeClientAddressData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeClientAddressData crudeClientAddressBusiness in dataList) {
                var model = new CrudeClientAddressModel();
                DataToModel(crudeClientAddressBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientAddressData.FetchAllCount();

        }
        
        public List<CrudeClientAddressModel> FetchWithFilter(
                    System.Guid clientAddressId, 
                    System.Guid clientId, 
                    string clientAddressTypeRcd, 
                    string addressLineOneName, 
                    string addressLineTwoName, 
                    string addressLineThreeName, 
                    string cityName, 
                    string streetName, 
                    string stateName, 
                    string districtName, 
                    string provinceName, 
                    string zipCode, 
                    string poBox, 
                    string comment, 
                    System.Guid userId, 
                    System.DateTime dateTime) {
            var list = new List<CrudeClientAddressModel>();
            List<CrudeClientAddressData> dataList = CrudeClientAddressData.FetchWithFilter(clientAddressId,clientId,clientAddressTypeRcd,addressLineOneName,addressLineTwoName,addressLineThreeName,cityName,streetName,stateName,districtName,provinceName,zipCode,poBox,comment,userId,dateTime);

            foreach (CrudeClientAddressData data in dataList) {
                var crudeClientAddressBusinessModel = new CrudeClientAddressModel();
                DataToModel(data, crudeClientAddressBusinessModel);
                list.Add(crudeClientAddressBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeClientAddressModel model) {
            var data = new CrudeClientAddressData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientAddressModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientAddressData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientAddressModel model) {
            var data = new CrudeClientAddressData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeClientAddressModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientAddressData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid clientAddressId) {
            CrudeClientAddressData.Delete(clientAddressId);
        }
        
        public static void ModelToData(CrudeClientAddressModel model, CrudeClientAddressData data) {
            data.ClientAddressId = model.ClientAddressId;
            data.ClientId = model.ClientId;
            data.ClientAddressTypeRcd = model.ClientAddressTypeRcd;
            data.AddressLineOneName = model.AddressLineOneName;
            data.AddressLineTwoName = model.AddressLineTwoName;
            data.AddressLineThreeName = model.AddressLineThreeName;
            data.CityName = model.CityName;
            data.StreetName = model.StreetName;
            data.StateName = model.StateName;
            data.DistrictName = model.DistrictName;
            data.ProvinceName = model.ProvinceName;
            data.ZipCode = model.ZipCode;
            data.PoBox = model.PoBox;
            data.Comment = model.Comment;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeClientAddressData data, CrudeClientAddressModel model) {
            model.ClientAddressId = data.ClientAddressId;
            model.ClientId = data.ClientId;
            model.ClientAddressTypeRcd = data.ClientAddressTypeRcd;
            model.AddressLineOneName = data.AddressLineOneName;
            model.AddressLineTwoName = data.AddressLineTwoName;
            model.AddressLineThreeName = data.AddressLineThreeName;
            model.CityName = data.CityName;
            model.StreetName = data.StreetName;
            model.StateName = data.StateName;
            model.DistrictName = data.DistrictName;
            model.ProvinceName = data.ProvinceName;
            model.ZipCode = data.ZipCode;
            model.PoBox = data.PoBox;
            model.Comment = data.Comment;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
