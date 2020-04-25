/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:19:51 AM
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
    public partial interface ICrudeClientLinkTypeRefService {
        
        [OperationContract()]
        CrudeClientLinkTypeRefContract FetchByClientLinkTypeRcd(string clientLinkTypeRcd);
        
        [OperationContract()]
        List<CrudeClientLinkTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientLinkTypeRefContract FetchByClientLinkTypeName(string clientLinkTypeName);
        
        [OperationContract()]
        List<CrudeClientLinkTypeRefContract> FetchWithFilter(string clientLinkTypeRcd, string clientLinkTypeName, string clientLinkTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientLinkTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientLinkTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientLinkTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientLinkTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientLinkTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string clientLinkTypeRcd);
    }
    
    public partial class CrudeClientLinkTypeRefService : ICrudeClientLinkTypeRefService {
        
        public CrudeClientLinkTypeRefContract FetchByClientLinkTypeRcd(string clientLinkTypeRcd) {
            var dataAccessLayer = new CrudeClientLinkTypeRefData();
            var contract = new CrudeClientLinkTypeRefContract();

            dataAccessLayer.FetchByClientLinkTypeRcd(clientLinkTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientLinkTypeRefContract FetchByClientLinkTypeName(string clientLinkTypeName) {
            var dataAccessLayer = new CrudeClientLinkTypeRefData();
            var contract = new CrudeClientLinkTypeRefContract();

            dataAccessLayer.FetchByClientLinkTypeName(clientLinkTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeClientLinkTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientLinkTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientLinkTypeRefContract> DataListToContractList(List<CrudeClientLinkTypeRefData> dataList) {
            var contractList = new List<CrudeClientLinkTypeRefContract>();

            foreach (CrudeClientLinkTypeRefData data in dataList) {
                var contract = new CrudeClientLinkTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientLinkTypeRefContract> contractList, List<CrudeClientLinkTypeRefData> dataList) {
            foreach (CrudeClientLinkTypeRefContract contract in contractList) {
                var data = new CrudeClientLinkTypeRefData();
                CrudeClientLinkTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientLinkTypeRefContract> FetchAll() {
            var list = new List<CrudeClientLinkTypeRefContract>();
            List<CrudeClientLinkTypeRefData> dataList = CrudeClientLinkTypeRefData.FetchAll();

            foreach (CrudeClientLinkTypeRefData crudeClientLinkTypeRef in dataList) {
                var contract = new CrudeClientLinkTypeRefContract();
                DataToContract(crudeClientLinkTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientLinkTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientLinkTypeRefContract>();
            List<CrudeClientLinkTypeRefData> dataList = CrudeClientLinkTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientLinkTypeRefData crudeClientLinkTypeRef in dataList) {
                var contract = new CrudeClientLinkTypeRefContract();
                DataToContract(crudeClientLinkTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientLinkTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientLinkTypeRefContract>();
            List<CrudeClientLinkTypeRefData> dataList = CrudeClientLinkTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientLinkTypeRefData crudeClientLinkTypeRef in dataList) {
                var contract = new CrudeClientLinkTypeRefContract();
                DataToContract(crudeClientLinkTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientLinkTypeRefData.FetchAllCount();
        }
        
        public List<CrudeClientLinkTypeRefContract> FetchWithFilter(string clientLinkTypeRcd, string clientLinkTypeName, string clientLinkTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientLinkTypeRefContract>();
            List<CrudeClientLinkTypeRefData> dataList = CrudeClientLinkTypeRefData.FetchWithFilter(
                clientLinkTypeRcd: clientLinkTypeRcd,
                clientLinkTypeName: clientLinkTypeName,
                clientLinkTypeDescription: clientLinkTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientLinkTypeRefData data in dataList) {
                var crudeClientLinkTypeRefContract = new CrudeClientLinkTypeRefContract();
                DataToContract(data, crudeClientLinkTypeRefContract);
                list.Add(crudeClientLinkTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientLinkTypeRefContract contract) {
            var data = new CrudeClientLinkTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientLinkTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientLinkTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientLinkTypeRefContract contract) {
            var data = new CrudeClientLinkTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientLinkTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientLinkTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientLinkTypeRcd) {
            CrudeClientLinkTypeRefData.Delete(clientLinkTypeRcd);
        }
        
        public static void ContractToData(CrudeClientLinkTypeRefContract contract, CrudeClientLinkTypeRefData data) {
            data.ClientLinkTypeRcd = contract.ClientLinkTypeRcd;
            data.ClientLinkTypeName = contract.ClientLinkTypeName;
            data.ClientLinkTypeDescription = contract.ClientLinkTypeDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientLinkTypeRefData data, CrudeClientLinkTypeRefContract contract) {
            contract.ClientLinkTypeRcd = data.ClientLinkTypeRcd;
            contract.ClientLinkTypeName = data.ClientLinkTypeName;
            contract.ClientLinkTypeDescription = data.ClientLinkTypeDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
