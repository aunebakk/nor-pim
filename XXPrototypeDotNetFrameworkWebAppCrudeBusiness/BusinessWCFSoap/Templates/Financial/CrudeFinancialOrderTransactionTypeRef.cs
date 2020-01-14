/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:24:26 AM
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
    public partial interface ICrudeFinancialOrderTransactionTypeRefService {
        
        [OperationContract()]
        CrudeFinancialOrderTransactionTypeRefContract FetchByFinancialOrderTransactionTypeRcd(string financialOrderTransactionTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialOrderTransactionTypeRefContract FetchByFinancialOrderTransactionTypeName(string financialOrderTransactionTypeName);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionTypeRefContract> FetchWithFilter(string financialOrderTransactionTypeRcd, string financialOrderTransactionTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialOrderTransactionTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialOrderTransactionTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string financialOrderTransactionTypeRcd);
    }
    
    public partial class CrudeFinancialOrderTransactionTypeRefService : ICrudeFinancialOrderTransactionTypeRefService {
        
        public CrudeFinancialOrderTransactionTypeRefContract FetchByFinancialOrderTransactionTypeRcd(string financialOrderTransactionTypeRcd) {
            var dataAccessLayer = new CrudeFinancialOrderTransactionTypeRefData();
            var contract = new CrudeFinancialOrderTransactionTypeRefContract();

            dataAccessLayer.FetchByFinancialOrderTransactionTypeRcd(financialOrderTransactionTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialOrderTransactionTypeRefContract FetchByFinancialOrderTransactionTypeName(string financialOrderTransactionTypeName) {
            var dataAccessLayer = new CrudeFinancialOrderTransactionTypeRefData();
            var contract = new CrudeFinancialOrderTransactionTypeRefContract();

            dataAccessLayer.FetchByFinancialOrderTransactionTypeName(financialOrderTransactionTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialOrderTransactionTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialOrderTransactionTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialOrderTransactionTypeRefContract> DataListToContractList(List<CrudeFinancialOrderTransactionTypeRefData> dataList) {
            var contractList = new List<CrudeFinancialOrderTransactionTypeRefContract>();

            foreach (CrudeFinancialOrderTransactionTypeRefData data in dataList) {
                var contract = new CrudeFinancialOrderTransactionTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialOrderTransactionTypeRefContract> contractList, List<CrudeFinancialOrderTransactionTypeRefData> dataList) {
            foreach (CrudeFinancialOrderTransactionTypeRefContract contract in contractList) {
                var data = new CrudeFinancialOrderTransactionTypeRefData();
                CrudeFinancialOrderTransactionTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderTransactionTypeRefContract> FetchAll() {
            var list = new List<CrudeFinancialOrderTransactionTypeRefContract>();
            List<CrudeFinancialOrderTransactionTypeRefData> dataList = CrudeFinancialOrderTransactionTypeRefData.FetchAll();

            foreach (CrudeFinancialOrderTransactionTypeRefData crudeFinancialOrderTransactionTypeRef in dataList) {
                var contract = new CrudeFinancialOrderTransactionTypeRefContract();
                DataToContract(crudeFinancialOrderTransactionTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderTransactionTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialOrderTransactionTypeRefContract>();
            List<CrudeFinancialOrderTransactionTypeRefData> dataList = CrudeFinancialOrderTransactionTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialOrderTransactionTypeRefData crudeFinancialOrderTransactionTypeRef in dataList) {
                var contract = new CrudeFinancialOrderTransactionTypeRefContract();
                DataToContract(crudeFinancialOrderTransactionTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderTransactionTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialOrderTransactionTypeRefContract>();
            List<CrudeFinancialOrderTransactionTypeRefData> dataList = CrudeFinancialOrderTransactionTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialOrderTransactionTypeRefData crudeFinancialOrderTransactionTypeRef in dataList) {
                var contract = new CrudeFinancialOrderTransactionTypeRefContract();
                DataToContract(crudeFinancialOrderTransactionTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderTransactionTypeRefData.FetchAllCount();
        }
        
        public List<CrudeFinancialOrderTransactionTypeRefContract> FetchWithFilter(string financialOrderTransactionTypeRcd, string financialOrderTransactionTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialOrderTransactionTypeRefContract>();
            List<CrudeFinancialOrderTransactionTypeRefData> dataList = CrudeFinancialOrderTransactionTypeRefData.FetchWithFilter(
                financialOrderTransactionTypeRcd: financialOrderTransactionTypeRcd,
                financialOrderTransactionTypeName: financialOrderTransactionTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialOrderTransactionTypeRefData data in dataList) {
                var crudeFinancialOrderTransactionTypeRefContract = new CrudeFinancialOrderTransactionTypeRefContract();
                DataToContract(data, crudeFinancialOrderTransactionTypeRefContract);
                list.Add(crudeFinancialOrderTransactionTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderTransactionTypeRefContract contract) {
            var data = new CrudeFinancialOrderTransactionTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderTransactionTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderTransactionTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderTransactionTypeRefContract contract) {
            var data = new CrudeFinancialOrderTransactionTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderTransactionTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderTransactionTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialOrderTransactionTypeRcd) {
            CrudeFinancialOrderTransactionTypeRefData.Delete(financialOrderTransactionTypeRcd);
        }
        
        public static void ContractToData(CrudeFinancialOrderTransactionTypeRefContract contract, CrudeFinancialOrderTransactionTypeRefData data) {
            data.FinancialOrderTransactionTypeRcd = contract.FinancialOrderTransactionTypeRcd;
            data.FinancialOrderTransactionTypeName = contract.FinancialOrderTransactionTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialOrderTransactionTypeRefData data, CrudeFinancialOrderTransactionTypeRefContract contract) {
            contract.FinancialOrderTransactionTypeRcd = data.FinancialOrderTransactionTypeRcd;
            contract.FinancialOrderTransactionTypeName = data.FinancialOrderTransactionTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
