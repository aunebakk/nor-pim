/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:57:27 PM
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
    public partial interface ICrudeClientAddressTypeRefService {
        
        [OperationContract()]
        CrudeClientAddressTypeRefContract FetchByClientAddressTypeRcd(string clientAddressTypeRcd);
        
        [OperationContract()]
        List<CrudeClientAddressTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientAddressTypeRefContract FetchByClientAddressTypeName(string clientAddressTypeName);
        
        [OperationContract()]
        List<CrudeClientAddressTypeRefContract> FetchWithFilter(string clientAddressTypeRcd, string clientAddressTypeName, string clientAddressTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientAddressTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientAddressTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientAddressTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientAddressTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientAddressTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string clientAddressTypeRcd);
    }
    
    public partial class CrudeClientAddressTypeRefService : ICrudeClientAddressTypeRefService {
        
        public CrudeClientAddressTypeRefContract FetchByClientAddressTypeRcd(string clientAddressTypeRcd) {
            var dataAccessLayer = new CrudeClientAddressTypeRefData();
            var contract = new CrudeClientAddressTypeRefContract();

            dataAccessLayer.FetchByClientAddressTypeRcd(clientAddressTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientAddressTypeRefContract FetchByClientAddressTypeName(string clientAddressTypeName) {
            var dataAccessLayer = new CrudeClientAddressTypeRefData();
            var contract = new CrudeClientAddressTypeRefContract();

            dataAccessLayer.FetchByClientAddressTypeName(clientAddressTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeClientAddressTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientAddressTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientAddressTypeRefContract> DataListToContractList(List<CrudeClientAddressTypeRefData> dataList) {
            var contractList = new List<CrudeClientAddressTypeRefContract>();

            foreach (CrudeClientAddressTypeRefData data in dataList) {
                var contract = new CrudeClientAddressTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientAddressTypeRefContract> contractList, List<CrudeClientAddressTypeRefData> dataList) {
            foreach (CrudeClientAddressTypeRefContract contract in contractList) {
                var data = new CrudeClientAddressTypeRefData();
                CrudeClientAddressTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientAddressTypeRefContract> FetchAll() {
            var list = new List<CrudeClientAddressTypeRefContract>();
            List<CrudeClientAddressTypeRefData> dataList = CrudeClientAddressTypeRefData.FetchAll();

            foreach (CrudeClientAddressTypeRefData crudeClientAddressTypeRef in dataList) {
                var contract = new CrudeClientAddressTypeRefContract();
                DataToContract(crudeClientAddressTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientAddressTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientAddressTypeRefContract>();
            List<CrudeClientAddressTypeRefData> dataList = CrudeClientAddressTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientAddressTypeRefData crudeClientAddressTypeRef in dataList) {
                var contract = new CrudeClientAddressTypeRefContract();
                DataToContract(crudeClientAddressTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientAddressTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientAddressTypeRefContract>();
            List<CrudeClientAddressTypeRefData> dataList = CrudeClientAddressTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientAddressTypeRefData crudeClientAddressTypeRef in dataList) {
                var contract = new CrudeClientAddressTypeRefContract();
                DataToContract(crudeClientAddressTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientAddressTypeRefData.FetchAllCount();
        }
        
        public List<CrudeClientAddressTypeRefContract> FetchWithFilter(string clientAddressTypeRcd, string clientAddressTypeName, string clientAddressTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientAddressTypeRefContract>();
            List<CrudeClientAddressTypeRefData> dataList = CrudeClientAddressTypeRefData.FetchWithFilter(
                clientAddressTypeRcd: clientAddressTypeRcd,
                clientAddressTypeName: clientAddressTypeName,
                clientAddressTypeDescription: clientAddressTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientAddressTypeRefData data in dataList) {
                var crudeClientAddressTypeRefContract = new CrudeClientAddressTypeRefContract();
                DataToContract(data, crudeClientAddressTypeRefContract);
                list.Add(crudeClientAddressTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientAddressTypeRefContract contract) {
            var data = new CrudeClientAddressTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientAddressTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientAddressTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientAddressTypeRefContract contract) {
            var data = new CrudeClientAddressTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientAddressTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientAddressTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientAddressTypeRcd) {
            CrudeClientAddressTypeRefData.Delete(clientAddressTypeRcd);
        }
        
        public static void ContractToData(CrudeClientAddressTypeRefContract contract, CrudeClientAddressTypeRefData data) {
            data.ClientAddressTypeRcd = contract.ClientAddressTypeRcd;
            data.ClientAddressTypeName = contract.ClientAddressTypeName;
            data.ClientAddressTypeDescription = contract.ClientAddressTypeDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientAddressTypeRefData data, CrudeClientAddressTypeRefContract contract) {
            contract.ClientAddressTypeRcd = data.ClientAddressTypeRcd;
            contract.ClientAddressTypeName = data.ClientAddressTypeName;
            contract.ClientAddressTypeDescription = data.ClientAddressTypeDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
