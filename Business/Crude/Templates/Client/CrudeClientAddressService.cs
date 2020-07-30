/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/30/2020 6:40:18 AM
  From Machine: DESKTOP-00MSEIL
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
    public partial interface ICrudeClientAddressService {
        
        [OperationContract()]
        CrudeClientAddressContract FetchByClientAddressId(System.Guid clientAddressId);
        
        [OperationContract()]
        List<CrudeClientAddressContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeClientAddressContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeClientAddressContract> FetchByClientAddressTypeRcd(string clientAddressTypeRcd);
        
        [OperationContract()]
        CrudeClientAddressContract FetchByAddressLineOneName(string addressLineOneName);
        
        [OperationContract()]
        List<CrudeClientAddressContract> FetchWithFilter(
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
                    System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientAddressContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientAddressContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientAddressContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientAddressContract contract);
        
        [OperationContract()]
        void Update(CrudeClientAddressContract contract);
        
        [OperationContract()]
        void Delete(System.Guid clientAddressId);
    }
    
    public partial class CrudeClientAddressService : ICrudeClientAddressService {
        
        public CrudeClientAddressContract FetchByClientAddressId(System.Guid clientAddressId) {
            var dataAccessLayer = new CrudeClientAddressData();
            var contract = new CrudeClientAddressContract();

            dataAccessLayer.FetchByClientAddressId(clientAddressId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientAddressContract FetchByAddressLineOneName(string addressLineOneName) {
            var dataAccessLayer = new CrudeClientAddressData();
            var contract = new CrudeClientAddressContract();

            dataAccessLayer.FetchByAddressLineOneName(addressLineOneName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeClientAddressContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeClientAddressData.FetchByClientId(clientId));
        }
        
        public List<CrudeClientAddressContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientAddressData.FetchByUserId(userId));
        }
        
        public List<CrudeClientAddressContract> FetchByClientAddressTypeRcd(string clientAddressTypeRcd) {
            return DataListToContractList(CrudeClientAddressData.FetchByClientAddressTypeRcd(clientAddressTypeRcd));
        }
        
        public static List<CrudeClientAddressContract> DataListToContractList(List<CrudeClientAddressData> dataList) {
            var contractList = new List<CrudeClientAddressContract>();

            foreach (CrudeClientAddressData data in dataList) {
                var contract = new CrudeClientAddressContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientAddressContract> contractList, List<CrudeClientAddressData> dataList) {
            foreach (CrudeClientAddressContract contract in contractList) {
                var data = new CrudeClientAddressData();
                CrudeClientAddressService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientAddressContract> FetchAll() {
            var list = new List<CrudeClientAddressContract>();
            List<CrudeClientAddressData> dataList = CrudeClientAddressData.FetchAll();

            foreach (CrudeClientAddressData crudeClientAddress in dataList) {
                var contract = new CrudeClientAddressContract();
                DataToContract(crudeClientAddress, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientAddressContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientAddressContract>();
            List<CrudeClientAddressData> dataList = CrudeClientAddressData.FetchAllWithLimit(limit);

            foreach (CrudeClientAddressData crudeClientAddress in dataList) {
                var contract = new CrudeClientAddressContract();
                DataToContract(crudeClientAddress, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientAddressContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientAddressContract>();
            List<CrudeClientAddressData> dataList = CrudeClientAddressData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientAddressData crudeClientAddress in dataList) {
                var contract = new CrudeClientAddressContract();
                DataToContract(crudeClientAddress, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientAddressData.FetchAllCount();
        }
        
        public List<CrudeClientAddressContract> FetchWithFilter(
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
            var list = new List<CrudeClientAddressContract>();
            List<CrudeClientAddressData> dataList = CrudeClientAddressData.FetchWithFilter(
                clientAddressId: clientAddressId,
                clientId: clientId,
                clientAddressTypeRcd: clientAddressTypeRcd,
                addressLineOneName: addressLineOneName,
                addressLineTwoName: addressLineTwoName,
                addressLineThreeName: addressLineThreeName,
                cityName: cityName,
                streetName: streetName,
                stateName: stateName,
                districtName: districtName,
                provinceName: provinceName,
                zipCode: zipCode,
                poBox: poBox,
                comment: comment,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientAddressData data in dataList) {
                var crudeClientAddressContract = new CrudeClientAddressContract();
                DataToContract(data, crudeClientAddressContract);
                list.Add(crudeClientAddressContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientAddressContract contract) {
            var data = new CrudeClientAddressData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientAddressContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientAddressData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientAddressContract contract) {
            var data = new CrudeClientAddressData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientAddressContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientAddressData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid clientAddressId) {
            CrudeClientAddressData.Delete(clientAddressId);
        }
        
        public static void ContractToData(CrudeClientAddressContract contract, CrudeClientAddressData data) {
            data.ClientAddressId = contract.ClientAddressId;
            data.ClientId = contract.ClientId;
            data.ClientAddressTypeRcd = contract.ClientAddressTypeRcd;
            data.AddressLineOneName = contract.AddressLineOneName;
            data.AddressLineTwoName = contract.AddressLineTwoName;
            data.AddressLineThreeName = contract.AddressLineThreeName;
            data.CityName = contract.CityName;
            data.StreetName = contract.StreetName;
            data.StateName = contract.StateName;
            data.DistrictName = contract.DistrictName;
            data.ProvinceName = contract.ProvinceName;
            data.ZipCode = contract.ZipCode;
            data.PoBox = contract.PoBox;
            data.Comment = contract.Comment;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientAddressData data, CrudeClientAddressContract contract) {
            contract.ClientAddressId = data.ClientAddressId;
            contract.ClientId = data.ClientId;
            contract.ClientAddressTypeRcd = data.ClientAddressTypeRcd;
            contract.AddressLineOneName = data.AddressLineOneName;
            contract.AddressLineTwoName = data.AddressLineTwoName;
            contract.AddressLineThreeName = data.AddressLineThreeName;
            contract.CityName = data.CityName;
            contract.StreetName = data.StreetName;
            contract.StateName = data.StateName;
            contract.DistrictName = data.DistrictName;
            contract.ProvinceName = data.ProvinceName;
            contract.ZipCode = data.ZipCode;
            contract.PoBox = data.PoBox;
            contract.Comment = data.Comment;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
