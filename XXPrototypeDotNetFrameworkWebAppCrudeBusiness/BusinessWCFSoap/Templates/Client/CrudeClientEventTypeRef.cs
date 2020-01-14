/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:57:28 PM
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
    public partial interface ICrudeClientEventTypeRefService {
        
        [OperationContract()]
        CrudeClientEventTypeRefContract FetchByClientEventTypeRcd(string clientEventTypeRcd);
        
        [OperationContract()]
        List<CrudeClientEventTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientEventTypeRefContract FetchByClientEventTypeName(string clientEventTypeName);
        
        [OperationContract()]
        List<CrudeClientEventTypeRefContract> FetchWithFilter(string clientEventTypeRcd, string clientEventTypeName, string clientEventTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientEventTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientEventTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientEventTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientEventTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientEventTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string clientEventTypeRcd);
    }
    
    public partial class CrudeClientEventTypeRefService : ICrudeClientEventTypeRefService {
        
        public CrudeClientEventTypeRefContract FetchByClientEventTypeRcd(string clientEventTypeRcd) {
            var dataAccessLayer = new CrudeClientEventTypeRefData();
            var contract = new CrudeClientEventTypeRefContract();

            dataAccessLayer.FetchByClientEventTypeRcd(clientEventTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientEventTypeRefContract FetchByClientEventTypeName(string clientEventTypeName) {
            var dataAccessLayer = new CrudeClientEventTypeRefData();
            var contract = new CrudeClientEventTypeRefContract();

            dataAccessLayer.FetchByClientEventTypeName(clientEventTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeClientEventTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientEventTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientEventTypeRefContract> DataListToContractList(List<CrudeClientEventTypeRefData> dataList) {
            var contractList = new List<CrudeClientEventTypeRefContract>();

            foreach (CrudeClientEventTypeRefData data in dataList) {
                var contract = new CrudeClientEventTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientEventTypeRefContract> contractList, List<CrudeClientEventTypeRefData> dataList) {
            foreach (CrudeClientEventTypeRefContract contract in contractList) {
                var data = new CrudeClientEventTypeRefData();
                CrudeClientEventTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientEventTypeRefContract> FetchAll() {
            var list = new List<CrudeClientEventTypeRefContract>();
            List<CrudeClientEventTypeRefData> dataList = CrudeClientEventTypeRefData.FetchAll();

            foreach (CrudeClientEventTypeRefData crudeClientEventTypeRef in dataList) {
                var contract = new CrudeClientEventTypeRefContract();
                DataToContract(crudeClientEventTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientEventTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientEventTypeRefContract>();
            List<CrudeClientEventTypeRefData> dataList = CrudeClientEventTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientEventTypeRefData crudeClientEventTypeRef in dataList) {
                var contract = new CrudeClientEventTypeRefContract();
                DataToContract(crudeClientEventTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientEventTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientEventTypeRefContract>();
            List<CrudeClientEventTypeRefData> dataList = CrudeClientEventTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientEventTypeRefData crudeClientEventTypeRef in dataList) {
                var contract = new CrudeClientEventTypeRefContract();
                DataToContract(crudeClientEventTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientEventTypeRefData.FetchAllCount();
        }
        
        public List<CrudeClientEventTypeRefContract> FetchWithFilter(string clientEventTypeRcd, string clientEventTypeName, string clientEventTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientEventTypeRefContract>();
            List<CrudeClientEventTypeRefData> dataList = CrudeClientEventTypeRefData.FetchWithFilter(
                clientEventTypeRcd: clientEventTypeRcd,
                clientEventTypeName: clientEventTypeName,
                clientEventTypeDescription: clientEventTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientEventTypeRefData data in dataList) {
                var crudeClientEventTypeRefContract = new CrudeClientEventTypeRefContract();
                DataToContract(data, crudeClientEventTypeRefContract);
                list.Add(crudeClientEventTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientEventTypeRefContract contract) {
            var data = new CrudeClientEventTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientEventTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientEventTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientEventTypeRefContract contract) {
            var data = new CrudeClientEventTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientEventTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientEventTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientEventTypeRcd) {
            CrudeClientEventTypeRefData.Delete(clientEventTypeRcd);
        }
        
        public static void ContractToData(CrudeClientEventTypeRefContract contract, CrudeClientEventTypeRefData data) {
            data.ClientEventTypeRcd = contract.ClientEventTypeRcd;
            data.ClientEventTypeName = contract.ClientEventTypeName;
            data.ClientEventTypeDescription = contract.ClientEventTypeDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientEventTypeRefData data, CrudeClientEventTypeRefContract contract) {
            contract.ClientEventTypeRcd = data.ClientEventTypeRcd;
            contract.ClientEventTypeName = data.ClientEventTypeName;
            contract.ClientEventTypeDescription = data.ClientEventTypeDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
