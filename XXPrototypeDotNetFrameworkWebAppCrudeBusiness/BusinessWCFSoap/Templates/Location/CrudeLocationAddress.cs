/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:18:57 PM
  Template: sql2x.TemplateCrudeSoap.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel.Activation;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [ServiceContract()]
    public partial interface ICrudeLocationAddressService {
        
        [OperationContract()]
        CrudeLocationAddressContract FetchByLocationAddressId(System.Guid locationAddressId);
        
        [OperationContract()]
        List<CrudeLocationAddressContract> FetchByLocationCountryId(System.Guid locationCountryId);
        
        [OperationContract()]
        List<CrudeLocationAddressContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeLocationAddressContract> FetchByLocationAddressTypeRcd(string locationAddressTypeRcd);
        
        [OperationContract()]
        List<CrudeLocationAddressContract> FetchWithFilter(
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
                    System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeLocationAddressContract> FetchAll();
        
        [OperationContract()]
        List<CrudeLocationAddressContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeLocationAddressContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeLocationAddressContract contract);
        
        [OperationContract()]
        void Update(CrudeLocationAddressContract contract);
        
        [OperationContract()]
        void Delete(System.Guid locationAddressId);
    }
    
    public partial class CrudeLocationAddressService : ICrudeLocationAddressService {
        
        public CrudeLocationAddressContract FetchByLocationAddressId(System.Guid locationAddressId) {
            var dataAccessLayer = new CrudeLocationAddressData();
            var contract = new CrudeLocationAddressContract();

            dataAccessLayer.FetchByLocationAddressId(locationAddressId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeLocationAddressContract> FetchByLocationCountryId(System.Guid locationCountryId) {
            return DataListToContractList(CrudeLocationAddressData.FetchByLocationCountryId(locationCountryId));
        }
        
        public List<CrudeLocationAddressContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeLocationAddressData.FetchByUserId(userId));
        }
        
        public List<CrudeLocationAddressContract> FetchByLocationAddressTypeRcd(string locationAddressTypeRcd) {
            return DataListToContractList(CrudeLocationAddressData.FetchByLocationAddressTypeRcd(locationAddressTypeRcd));
        }
        
        public static List<CrudeLocationAddressContract> DataListToContractList(List<CrudeLocationAddressData> dataList) {
            var contractList = new List<CrudeLocationAddressContract>();

            foreach (CrudeLocationAddressData data in dataList) {
                var contract = new CrudeLocationAddressContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeLocationAddressContract> contractList, List<CrudeLocationAddressData> dataList) {
            foreach (CrudeLocationAddressContract contract in contractList) {
                var data = new CrudeLocationAddressData();
                CrudeLocationAddressService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeLocationAddressContract> FetchAll() {
            var list = new List<CrudeLocationAddressContract>();
            List<CrudeLocationAddressData> dataList = CrudeLocationAddressData.FetchAll();

            foreach (CrudeLocationAddressData crudeLocationAddress in dataList) {
                var contract = new CrudeLocationAddressContract();
                DataToContract(crudeLocationAddress, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeLocationAddressContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeLocationAddressContract>();
            List<CrudeLocationAddressData> dataList = CrudeLocationAddressData.FetchAllWithLimit(limit);

            foreach (CrudeLocationAddressData crudeLocationAddress in dataList) {
                var contract = new CrudeLocationAddressContract();
                DataToContract(crudeLocationAddress, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeLocationAddressContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeLocationAddressContract>();
            List<CrudeLocationAddressData> dataList = CrudeLocationAddressData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeLocationAddressData crudeLocationAddress in dataList) {
                var contract = new CrudeLocationAddressContract();
                DataToContract(crudeLocationAddress, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeLocationAddressData.FetchAllCount();
        }
        
        public List<CrudeLocationAddressContract> FetchWithFilter(
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
            var list = new List<CrudeLocationAddressContract>();
            List<CrudeLocationAddressData> dataList = CrudeLocationAddressData.FetchWithFilter(
                locationAddressId: locationAddressId,
                locationAddressTypeRcd: locationAddressTypeRcd,
                locationCountryId: locationCountryId,
                addressOne: addressOne,
                addressTwo: addressTwo,
                addressThree: addressThree,
                city: city,
                street: street,
                state: state,
                district: district,
                province: province,
                zipCode: zipCode,
                poBox: poBox,
                comment: comment,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeLocationAddressData data in dataList) {
                var crudeLocationAddressContract = new CrudeLocationAddressContract();
                DataToContract(data, crudeLocationAddressContract);
                list.Add(crudeLocationAddressContract);
            }

            return list;
        }
        
        public void Insert(CrudeLocationAddressContract contract) {
            var data = new CrudeLocationAddressData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeLocationAddressContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationAddressData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeLocationAddressContract contract) {
            var data = new CrudeLocationAddressData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeLocationAddressContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationAddressData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid locationAddressId) {
            CrudeLocationAddressData.Delete(locationAddressId);
        }
        
        public static void ContractToData(CrudeLocationAddressContract contract, CrudeLocationAddressData data) {
            data.LocationAddressId = contract.LocationAddressId;
            data.LocationAddressTypeRcd = contract.LocationAddressTypeRcd;
            data.LocationCountryId = contract.LocationCountryId;
            data.AddressOne = contract.AddressOne;
            data.AddressTwo = contract.AddressTwo;
            data.AddressThree = contract.AddressThree;
            data.City = contract.City;
            data.Street = contract.Street;
            data.State = contract.State;
            data.District = contract.District;
            data.Province = contract.Province;
            data.ZipCode = contract.ZipCode;
            data.PoBox = contract.PoBox;
            data.Comment = contract.Comment;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeLocationAddressData data, CrudeLocationAddressContract contract) {
            contract.LocationAddressId = data.LocationAddressId;
            contract.LocationAddressTypeRcd = data.LocationAddressTypeRcd;
            contract.LocationCountryId = data.LocationCountryId;
            contract.AddressOne = data.AddressOne;
            contract.AddressTwo = data.AddressTwo;
            contract.AddressThree = data.AddressThree;
            contract.City = data.City;
            contract.Street = data.Street;
            contract.State = data.State;
            contract.District = data.District;
            contract.Province = data.Province;
            contract.ZipCode = data.ZipCode;
            contract.PoBox = data.PoBox;
            contract.Comment = data.Comment;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
