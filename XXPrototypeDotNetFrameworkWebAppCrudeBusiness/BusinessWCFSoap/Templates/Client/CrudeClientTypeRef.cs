/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:56:01 PM
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
    public partial interface ICrudeClientTypeRefService {
        
        [OperationContract()]
        CrudeClientTypeRefContract FetchByClientTypeRcd(string clientTypeRcd);
        
        [OperationContract()]
        List<CrudeClientTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientTypeRefContract FetchByClientTypeName(string clientTypeName);
        
        [OperationContract()]
        List<CrudeClientTypeRefContract> FetchWithFilter(string clientTypeRcd, string clientTypeName, string clientTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string clientTypeRcd);
    }
    
    public partial class CrudeClientTypeRefService : ICrudeClientTypeRefService {
        
        public CrudeClientTypeRefContract FetchByClientTypeRcd(string clientTypeRcd) {
            var dataAccessLayer = new CrudeClientTypeRefData();
            var contract = new CrudeClientTypeRefContract();

            dataAccessLayer.FetchByClientTypeRcd(clientTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientTypeRefContract FetchByClientTypeName(string clientTypeName) {
            var dataAccessLayer = new CrudeClientTypeRefData();
            var contract = new CrudeClientTypeRefContract();

            dataAccessLayer.FetchByClientTypeName(clientTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeClientTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientTypeRefContract> DataListToContractList(List<CrudeClientTypeRefData> dataList) {
            var contractList = new List<CrudeClientTypeRefContract>();

            foreach (CrudeClientTypeRefData data in dataList) {
                var contract = new CrudeClientTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientTypeRefContract> contractList, List<CrudeClientTypeRefData> dataList) {
            foreach (CrudeClientTypeRefContract contract in contractList) {
                var data = new CrudeClientTypeRefData();
                CrudeClientTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientTypeRefContract> FetchAll() {
            var list = new List<CrudeClientTypeRefContract>();
            List<CrudeClientTypeRefData> dataList = CrudeClientTypeRefData.FetchAll();

            foreach (CrudeClientTypeRefData crudeClientTypeRef in dataList) {
                var contract = new CrudeClientTypeRefContract();
                DataToContract(crudeClientTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientTypeRefContract>();
            List<CrudeClientTypeRefData> dataList = CrudeClientTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientTypeRefData crudeClientTypeRef in dataList) {
                var contract = new CrudeClientTypeRefContract();
                DataToContract(crudeClientTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientTypeRefContract>();
            List<CrudeClientTypeRefData> dataList = CrudeClientTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientTypeRefData crudeClientTypeRef in dataList) {
                var contract = new CrudeClientTypeRefContract();
                DataToContract(crudeClientTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientTypeRefData.FetchAllCount();
        }
        
        public List<CrudeClientTypeRefContract> FetchWithFilter(string clientTypeRcd, string clientTypeName, string clientTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientTypeRefContract>();
            List<CrudeClientTypeRefData> dataList = CrudeClientTypeRefData.FetchWithFilter(
                clientTypeRcd: clientTypeRcd,
                clientTypeName: clientTypeName,
                clientTypeDescription: clientTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientTypeRefData data in dataList) {
                var crudeClientTypeRefContract = new CrudeClientTypeRefContract();
                DataToContract(data, crudeClientTypeRefContract);
                list.Add(crudeClientTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientTypeRefContract contract) {
            var data = new CrudeClientTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientTypeRefContract contract) {
            var data = new CrudeClientTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientTypeRcd) {
            CrudeClientTypeRefData.Delete(clientTypeRcd);
        }
        
        public static void ContractToData(CrudeClientTypeRefContract contract, CrudeClientTypeRefData data) {
            data.ClientTypeRcd = contract.ClientTypeRcd;
            data.ClientTypeName = contract.ClientTypeName;
            data.ClientTypeDescription = contract.ClientTypeDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientTypeRefData data, CrudeClientTypeRefContract contract) {
            contract.ClientTypeRcd = data.ClientTypeRcd;
            contract.ClientTypeName = data.ClientTypeName;
            contract.ClientTypeDescription = data.ClientTypeDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
