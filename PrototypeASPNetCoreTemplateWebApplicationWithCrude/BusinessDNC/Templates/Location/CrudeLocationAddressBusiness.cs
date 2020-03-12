/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:44:09 PM
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
    
    
    public partial class CrudeLocationAddressBusiness {
        
        public CrudeLocationAddressModel FetchByLocationAddressId(System.Guid locationAddressId) {
            var dataAccessLayer = new CrudeLocationAddressData();
            var model = new CrudeLocationAddressModel();

            dataAccessLayer.FetchByLocationAddressId(locationAddressId);
            DataToModel(dataAccessLayer, model);

            return model;
        }
        
        public List<CrudeLocationAddressModel> FetchByLocationAddressTypeRcd(string locationAddressTypeRcd) {
            return DataListToModelList(CrudeLocationAddressData.FetchByLocationAddressTypeRcd(locationAddressTypeRcd));
        }
        
        public List<CrudeLocationAddressModel> FetchByLocationCountryId(System.Guid locationCountryId) {
            return DataListToModelList(CrudeLocationAddressData.FetchByLocationCountryId(locationCountryId));
        }
        
        public List<CrudeLocationAddressModel> FetchByUserId(System.Guid userId) {
            return DataListToModelList(CrudeLocationAddressData.FetchByUserId(userId));
        }
        
        public static List<CrudeLocationAddressModel> DataListToModelList(List<CrudeLocationAddressData> dataList) {
            var modelList = new List<CrudeLocationAddressModel>();

            foreach (CrudeLocationAddressData data in dataList) {
                var model = new CrudeLocationAddressModel();
                DataToModel(data, model);
                modelList.Add(model);
            }

            return modelList;
        }
        
        public static void ModelListToDataList(List<CrudeLocationAddressModel> modelList, List<CrudeLocationAddressData> dataList) {
            foreach (CrudeLocationAddressModel model in modelList) {
                var data = new CrudeLocationAddressData();
                ModelToData(model, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeLocationAddressModel> FetchAll() {
            var list = new List<CrudeLocationAddressModel>();
            List<CrudeLocationAddressData> dataList = CrudeLocationAddressData.FetchAll();

            foreach (CrudeLocationAddressData crudeLocationAddressBusiness in dataList) {
                var model = new CrudeLocationAddressModel();
                DataToModel(crudeLocationAddressBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeLocationAddressModel> FetchAllWithLimit(string limit) {
            var list = new List<CrudeLocationAddressModel>();
            List<CrudeLocationAddressData> dataList = CrudeLocationAddressData.FetchAllWithLimit(int.Parse(limit));

            foreach (CrudeLocationAddressData crudeLocationAddressBusiness in dataList) {
                var model = new CrudeLocationAddressModel();
                DataToModel(crudeLocationAddressBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public List<CrudeLocationAddressModel> FetchAllWithLimitAndOffset(string limit, string offset) {
            var list = new List<CrudeLocationAddressModel>();
            List<CrudeLocationAddressData> dataList = CrudeLocationAddressData.FetchAllWithLimitAndOffset(int.Parse(limit), int.Parse(offset));

            foreach (CrudeLocationAddressData crudeLocationAddressBusiness in dataList) {
                var model = new CrudeLocationAddressModel();
                DataToModel(crudeLocationAddressBusiness, model);
                list.Add(model);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeLocationAddressData.FetchAllCount();

        }
        
        public List<CrudeLocationAddressModel> FetchWithFilter(
                    System.Guid locationAddressId, 
                    string locationAddressTypeRcd, 
                    System.Guid locationCountryId, 
                    string addressOne, 
                    string addressTwo, 
                    string addressThree, 
                    string city, 
                    string street, 
                    string state, 
                    string district, 
                    string province, 
                    string zipCode, 
                    string poBox, 
                    string comment, 
                    System.Guid userId, 
                    System.DateTime dateTime) {
            var list = new List<CrudeLocationAddressModel>();
            List<CrudeLocationAddressData> dataList = CrudeLocationAddressData.FetchWithFilter(locationAddressId,locationAddressTypeRcd,locationCountryId,addressOne,addressTwo,addressThree,city,street,state,district,province,zipCode,poBox,comment,userId,dateTime);

            foreach (CrudeLocationAddressData data in dataList) {
                var crudeLocationAddressBusinessModel = new CrudeLocationAddressModel();
                DataToModel(data, crudeLocationAddressBusinessModel);
                list.Add(crudeLocationAddressBusinessModel);
            }

            return list;
        }
        
        public void Insert(CrudeLocationAddressModel model) {
            var data = new CrudeLocationAddressData();
            ModelToData(model, data);
            data.Insert();
        }
        
        public void Insert(CrudeLocationAddressModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationAddressData();
            ModelToData(model, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeLocationAddressModel model) {
            var data = new CrudeLocationAddressData();
            ModelToData(model, data);
            data.Update();
        }
        
        public void Update(CrudeLocationAddressModel model, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationAddressData();
            ModelToData(model, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid locationAddressId) {
            CrudeLocationAddressData.Delete(locationAddressId);
        }
        
        public static void ModelToData(CrudeLocationAddressModel model, CrudeLocationAddressData data) {
            data.LocationAddressId = model.LocationAddressId;
            data.LocationAddressTypeRcd = model.LocationAddressTypeRcd;
            data.LocationCountryId = model.LocationCountryId;
            data.AddressOne = model.AddressOne;
            data.AddressTwo = model.AddressTwo;
            data.AddressThree = model.AddressThree;
            data.City = model.City;
            data.Street = model.Street;
            data.State = model.State;
            data.District = model.District;
            data.Province = model.Province;
            data.ZipCode = model.ZipCode;
            data.PoBox = model.PoBox;
            data.Comment = model.Comment;
            data.UserId = model.UserId;
            data.DateTime = model.DateTime;
        }
        
        public static void DataToModel(CrudeLocationAddressData data, CrudeLocationAddressModel model) {
            model.LocationAddressId = data.LocationAddressId;
            model.LocationAddressTypeRcd = data.LocationAddressTypeRcd;
            model.LocationCountryId = data.LocationCountryId;
            model.AddressOne = data.AddressOne;
            model.AddressTwo = data.AddressTwo;
            model.AddressThree = data.AddressThree;
            model.City = data.City;
            model.Street = data.Street;
            model.State = data.State;
            model.District = data.District;
            model.Province = data.Province;
            model.ZipCode = data.ZipCode;
            model.PoBox = data.PoBox;
            model.Comment = data.Comment;
            model.UserId = data.UserId;
            model.DateTime = data.DateTime;
        }
    }
}
