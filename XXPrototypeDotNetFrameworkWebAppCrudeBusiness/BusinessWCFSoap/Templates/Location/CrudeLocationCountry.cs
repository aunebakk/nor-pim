/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:34:52 PM
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
    public partial interface ICrudeLocationCountryService {
        
        [OperationContract()]
        CrudeLocationCountryContract FetchByLocationCountryId(System.Guid locationCountryId);
        
        [OperationContract()]
        List<CrudeLocationCountryContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeLocationCountryContract FetchByLocationCountryName(string locationCountryName);
        
        [OperationContract()]
        List<CrudeLocationCountryContract> FetchWithFilter(System.Guid locationCountryId, string locationCountryCode, string locationCountryName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeLocationCountryContract> FetchAll();
        
        [OperationContract()]
        List<CrudeLocationCountryContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeLocationCountryContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeLocationCountryContract contract);
        
        [OperationContract()]
        void Update(CrudeLocationCountryContract contract);
        
        [OperationContract()]
        void Delete(System.Guid locationCountryId);
    }
    
    public partial class CrudeLocationCountryService : ICrudeLocationCountryService {
        
        public CrudeLocationCountryContract FetchByLocationCountryId(System.Guid locationCountryId) {
            var dataAccessLayer = new CrudeLocationCountryData();
            var contract = new CrudeLocationCountryContract();

            dataAccessLayer.FetchByLocationCountryId(locationCountryId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeLocationCountryContract FetchByLocationCountryName(string locationCountryName) {
            var dataAccessLayer = new CrudeLocationCountryData();
            var contract = new CrudeLocationCountryContract();

            dataAccessLayer.FetchByLocationCountryName(locationCountryName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeLocationCountryContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeLocationCountryData.FetchByUserId(userId));
        }
        
        public static List<CrudeLocationCountryContract> DataListToContractList(List<CrudeLocationCountryData> dataList) {
            var contractList = new List<CrudeLocationCountryContract>();

            foreach (CrudeLocationCountryData data in dataList) {
                var contract = new CrudeLocationCountryContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeLocationCountryContract> contractList, List<CrudeLocationCountryData> dataList) {
            foreach (CrudeLocationCountryContract contract in contractList) {
                var data = new CrudeLocationCountryData();
                CrudeLocationCountryService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeLocationCountryContract> FetchAll() {
            var list = new List<CrudeLocationCountryContract>();
            List<CrudeLocationCountryData> dataList = CrudeLocationCountryData.FetchAll();

            foreach (CrudeLocationCountryData crudeLocationCountry in dataList) {
                var contract = new CrudeLocationCountryContract();
                DataToContract(crudeLocationCountry, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeLocationCountryContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeLocationCountryContract>();
            List<CrudeLocationCountryData> dataList = CrudeLocationCountryData.FetchAllWithLimit(limit);

            foreach (CrudeLocationCountryData crudeLocationCountry in dataList) {
                var contract = new CrudeLocationCountryContract();
                DataToContract(crudeLocationCountry, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeLocationCountryContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeLocationCountryContract>();
            List<CrudeLocationCountryData> dataList = CrudeLocationCountryData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeLocationCountryData crudeLocationCountry in dataList) {
                var contract = new CrudeLocationCountryContract();
                DataToContract(crudeLocationCountry, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeLocationCountryData.FetchAllCount();
        }
        
        public List<CrudeLocationCountryContract> FetchWithFilter(System.Guid locationCountryId, string locationCountryCode, string locationCountryName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeLocationCountryContract>();
            List<CrudeLocationCountryData> dataList = CrudeLocationCountryData.FetchWithFilter(
                locationCountryId: locationCountryId,
                locationCountryCode: locationCountryCode,
                locationCountryName: locationCountryName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeLocationCountryData data in dataList) {
                var crudeLocationCountryContract = new CrudeLocationCountryContract();
                DataToContract(data, crudeLocationCountryContract);
                list.Add(crudeLocationCountryContract);
            }

            return list;
        }
        
        public void Insert(CrudeLocationCountryContract contract) {
            var data = new CrudeLocationCountryData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeLocationCountryContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationCountryData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeLocationCountryContract contract) {
            var data = new CrudeLocationCountryData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeLocationCountryContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationCountryData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid locationCountryId) {
            CrudeLocationCountryData.Delete(locationCountryId);
        }
        
        public static void ContractToData(CrudeLocationCountryContract contract, CrudeLocationCountryData data) {
            data.LocationCountryId = contract.LocationCountryId;
            data.LocationCountryCode = contract.LocationCountryCode;
            data.LocationCountryName = contract.LocationCountryName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeLocationCountryData data, CrudeLocationCountryContract contract) {
            contract.LocationCountryId = data.LocationCountryId;
            contract.LocationCountryCode = data.LocationCountryCode;
            contract.LocationCountryName = data.LocationCountryName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
