/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/30/2020 6:40:19 AM
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
    public partial interface ICrudeClientContactMethodRefService {
        
        [OperationContract()]
        CrudeClientContactMethodRefContract FetchByClientContactMethodRcd(string clientContactMethodRcd);
        
        [OperationContract()]
        List<CrudeClientContactMethodRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientContactMethodRefContract FetchByClientContactMethodName(string clientContactMethodName);
        
        [OperationContract()]
        List<CrudeClientContactMethodRefContract> FetchWithFilter(string clientContactMethodRcd, string clientContactMethodName, string clientContactMethodDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientContactMethodRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientContactMethodRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientContactMethodRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientContactMethodRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientContactMethodRefContract contract);
        
        [OperationContract()]
        void Delete(string clientContactMethodRcd);
    }
    
    public partial class CrudeClientContactMethodRefService : ICrudeClientContactMethodRefService {
        
        public CrudeClientContactMethodRefContract FetchByClientContactMethodRcd(string clientContactMethodRcd) {
            var dataAccessLayer = new CrudeClientContactMethodRefData();
            var contract = new CrudeClientContactMethodRefContract();

            dataAccessLayer.FetchByClientContactMethodRcd(clientContactMethodRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientContactMethodRefContract FetchByClientContactMethodName(string clientContactMethodName) {
            var dataAccessLayer = new CrudeClientContactMethodRefData();
            var contract = new CrudeClientContactMethodRefContract();

            dataAccessLayer.FetchByClientContactMethodName(clientContactMethodName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeClientContactMethodRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientContactMethodRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientContactMethodRefContract> DataListToContractList(List<CrudeClientContactMethodRefData> dataList) {
            var contractList = new List<CrudeClientContactMethodRefContract>();

            foreach (CrudeClientContactMethodRefData data in dataList) {
                var contract = new CrudeClientContactMethodRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientContactMethodRefContract> contractList, List<CrudeClientContactMethodRefData> dataList) {
            foreach (CrudeClientContactMethodRefContract contract in contractList) {
                var data = new CrudeClientContactMethodRefData();
                CrudeClientContactMethodRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientContactMethodRefContract> FetchAll() {
            var list = new List<CrudeClientContactMethodRefContract>();
            List<CrudeClientContactMethodRefData> dataList = CrudeClientContactMethodRefData.FetchAll();

            foreach (CrudeClientContactMethodRefData crudeClientContactMethodRef in dataList) {
                var contract = new CrudeClientContactMethodRefContract();
                DataToContract(crudeClientContactMethodRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientContactMethodRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientContactMethodRefContract>();
            List<CrudeClientContactMethodRefData> dataList = CrudeClientContactMethodRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientContactMethodRefData crudeClientContactMethodRef in dataList) {
                var contract = new CrudeClientContactMethodRefContract();
                DataToContract(crudeClientContactMethodRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientContactMethodRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientContactMethodRefContract>();
            List<CrudeClientContactMethodRefData> dataList = CrudeClientContactMethodRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientContactMethodRefData crudeClientContactMethodRef in dataList) {
                var contract = new CrudeClientContactMethodRefContract();
                DataToContract(crudeClientContactMethodRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientContactMethodRefData.FetchAllCount();
        }
        
        public List<CrudeClientContactMethodRefContract> FetchWithFilter(string clientContactMethodRcd, string clientContactMethodName, string clientContactMethodDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientContactMethodRefContract>();
            List<CrudeClientContactMethodRefData> dataList = CrudeClientContactMethodRefData.FetchWithFilter(
                clientContactMethodRcd: clientContactMethodRcd,
                clientContactMethodName: clientContactMethodName,
                clientContactMethodDescription: clientContactMethodDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientContactMethodRefData data in dataList) {
                var crudeClientContactMethodRefContract = new CrudeClientContactMethodRefContract();
                DataToContract(data, crudeClientContactMethodRefContract);
                list.Add(crudeClientContactMethodRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientContactMethodRefContract contract) {
            var data = new CrudeClientContactMethodRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientContactMethodRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientContactMethodRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientContactMethodRefContract contract) {
            var data = new CrudeClientContactMethodRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientContactMethodRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientContactMethodRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientContactMethodRcd) {
            CrudeClientContactMethodRefData.Delete(clientContactMethodRcd);
        }
        
        public static void ContractToData(CrudeClientContactMethodRefContract contract, CrudeClientContactMethodRefData data) {
            data.ClientContactMethodRcd = contract.ClientContactMethodRcd;
            data.ClientContactMethodName = contract.ClientContactMethodName;
            data.ClientContactMethodDescription = contract.ClientContactMethodDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientContactMethodRefData data, CrudeClientContactMethodRefContract contract) {
            contract.ClientContactMethodRcd = data.ClientContactMethodRcd;
            contract.ClientContactMethodName = data.ClientContactMethodName;
            contract.ClientContactMethodDescription = data.ClientContactMethodDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
