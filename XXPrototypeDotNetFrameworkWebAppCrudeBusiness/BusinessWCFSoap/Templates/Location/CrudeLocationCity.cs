/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:20:12 AM
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
    public partial interface ICrudeLocationCityService {
        
        [OperationContract()]
        CrudeLocationCityContract FetchByLocationCityId(System.Guid locationCityId);
        
        [OperationContract()]
        List<CrudeLocationCityContract> FetchByLocationCountryId(System.Guid locationCountryId);
        
        [OperationContract()]
        List<CrudeLocationCityContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeLocationCityContract FetchByLocationCityName(string locationCityName);
        
        [OperationContract()]
        List<CrudeLocationCityContract> FetchWithFilter(System.Guid locationCityId, System.Guid locationCountryId, string locationCityCode, string locationCityName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeLocationCityContract> FetchAll();
        
        [OperationContract()]
        List<CrudeLocationCityContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeLocationCityContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeLocationCityContract contract);
        
        [OperationContract()]
        void Update(CrudeLocationCityContract contract);
        
        [OperationContract()]
        void Delete(System.Guid locationCityId);
    }
    
    public partial class CrudeLocationCityService : ICrudeLocationCityService {
        
        public CrudeLocationCityContract FetchByLocationCityId(System.Guid locationCityId) {
            var dataAccessLayer = new CrudeLocationCityData();
            var contract = new CrudeLocationCityContract();

            dataAccessLayer.FetchByLocationCityId(locationCityId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeLocationCityContract FetchByLocationCityName(string locationCityName) {
            var dataAccessLayer = new CrudeLocationCityData();
            var contract = new CrudeLocationCityContract();

            dataAccessLayer.FetchByLocationCityName(locationCityName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeLocationCityContract> FetchByLocationCountryId(System.Guid locationCountryId) {
            return DataListToContractList(CrudeLocationCityData.FetchByLocationCountryId(locationCountryId));
        }
        
        public List<CrudeLocationCityContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeLocationCityData.FetchByUserId(userId));
        }
        
        public static List<CrudeLocationCityContract> DataListToContractList(List<CrudeLocationCityData> dataList) {
            var contractList = new List<CrudeLocationCityContract>();

            foreach (CrudeLocationCityData data in dataList) {
                var contract = new CrudeLocationCityContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeLocationCityContract> contractList, List<CrudeLocationCityData> dataList) {
            foreach (CrudeLocationCityContract contract in contractList) {
                var data = new CrudeLocationCityData();
                CrudeLocationCityService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeLocationCityContract> FetchAll() {
            var list = new List<CrudeLocationCityContract>();
            List<CrudeLocationCityData> dataList = CrudeLocationCityData.FetchAll();

            foreach (CrudeLocationCityData crudeLocationCity in dataList) {
                var contract = new CrudeLocationCityContract();
                DataToContract(crudeLocationCity, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeLocationCityContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeLocationCityContract>();
            List<CrudeLocationCityData> dataList = CrudeLocationCityData.FetchAllWithLimit(limit);

            foreach (CrudeLocationCityData crudeLocationCity in dataList) {
                var contract = new CrudeLocationCityContract();
                DataToContract(crudeLocationCity, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeLocationCityContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeLocationCityContract>();
            List<CrudeLocationCityData> dataList = CrudeLocationCityData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeLocationCityData crudeLocationCity in dataList) {
                var contract = new CrudeLocationCityContract();
                DataToContract(crudeLocationCity, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeLocationCityData.FetchAllCount();
        }
        
        public List<CrudeLocationCityContract> FetchWithFilter(System.Guid locationCityId, System.Guid locationCountryId, string locationCityCode, string locationCityName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeLocationCityContract>();
            List<CrudeLocationCityData> dataList = CrudeLocationCityData.FetchWithFilter(
                locationCityId: locationCityId,
                locationCountryId: locationCountryId,
                locationCityCode: locationCityCode,
                locationCityName: locationCityName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeLocationCityData data in dataList) {
                var crudeLocationCityContract = new CrudeLocationCityContract();
                DataToContract(data, crudeLocationCityContract);
                list.Add(crudeLocationCityContract);
            }

            return list;
        }
        
        public void Insert(CrudeLocationCityContract contract) {
            var data = new CrudeLocationCityData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeLocationCityContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationCityData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeLocationCityContract contract) {
            var data = new CrudeLocationCityData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeLocationCityContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationCityData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid locationCityId) {
            CrudeLocationCityData.Delete(locationCityId);
        }
        
        public static void ContractToData(CrudeLocationCityContract contract, CrudeLocationCityData data) {
            data.LocationCityId = contract.LocationCityId;
            data.LocationCountryId = contract.LocationCountryId;
            data.LocationCityCode = contract.LocationCityCode;
            data.LocationCityName = contract.LocationCityName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeLocationCityData data, CrudeLocationCityContract contract) {
            contract.LocationCityId = data.LocationCityId;
            contract.LocationCountryId = data.LocationCountryId;
            contract.LocationCityCode = data.LocationCityCode;
            contract.LocationCityName = data.LocationCityName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
