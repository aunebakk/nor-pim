/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:24:22 AM
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
    public partial interface ICrudeFinancialBankAccountNumberTypeRefService {
        
        [OperationContract()]
        CrudeFinancialBankAccountNumberTypeRefContract FetchByFinancialBankAccountNumberTypeRcd(string financialBankAccountNumberTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialBankAccountNumberTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialBankAccountNumberTypeRefContract FetchByFinancialBankAccountNumberTypeName(string financialBankAccountNumberTypeName);
        
        [OperationContract()]
        List<CrudeFinancialBankAccountNumberTypeRefContract> FetchWithFilter(string financialBankAccountNumberTypeRcd, string financialBankAccountNumberTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialBankAccountNumberTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialBankAccountNumberTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialBankAccountNumberTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialBankAccountNumberTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialBankAccountNumberTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string financialBankAccountNumberTypeRcd);
    }
    
    public partial class CrudeFinancialBankAccountNumberTypeRefService : ICrudeFinancialBankAccountNumberTypeRefService {
        
        public CrudeFinancialBankAccountNumberTypeRefContract FetchByFinancialBankAccountNumberTypeRcd(string financialBankAccountNumberTypeRcd) {
            var dataAccessLayer = new CrudeFinancialBankAccountNumberTypeRefData();
            var contract = new CrudeFinancialBankAccountNumberTypeRefContract();

            dataAccessLayer.FetchByFinancialBankAccountNumberTypeRcd(financialBankAccountNumberTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialBankAccountNumberTypeRefContract FetchByFinancialBankAccountNumberTypeName(string financialBankAccountNumberTypeName) {
            var dataAccessLayer = new CrudeFinancialBankAccountNumberTypeRefData();
            var contract = new CrudeFinancialBankAccountNumberTypeRefContract();

            dataAccessLayer.FetchByFinancialBankAccountNumberTypeName(financialBankAccountNumberTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialBankAccountNumberTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialBankAccountNumberTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialBankAccountNumberTypeRefContract> DataListToContractList(List<CrudeFinancialBankAccountNumberTypeRefData> dataList) {
            var contractList = new List<CrudeFinancialBankAccountNumberTypeRefContract>();

            foreach (CrudeFinancialBankAccountNumberTypeRefData data in dataList) {
                var contract = new CrudeFinancialBankAccountNumberTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialBankAccountNumberTypeRefContract> contractList, List<CrudeFinancialBankAccountNumberTypeRefData> dataList) {
            foreach (CrudeFinancialBankAccountNumberTypeRefContract contract in contractList) {
                var data = new CrudeFinancialBankAccountNumberTypeRefData();
                CrudeFinancialBankAccountNumberTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialBankAccountNumberTypeRefContract> FetchAll() {
            var list = new List<CrudeFinancialBankAccountNumberTypeRefContract>();
            List<CrudeFinancialBankAccountNumberTypeRefData> dataList = CrudeFinancialBankAccountNumberTypeRefData.FetchAll();

            foreach (CrudeFinancialBankAccountNumberTypeRefData crudeFinancialBankAccountNumberTypeRef in dataList) {
                var contract = new CrudeFinancialBankAccountNumberTypeRefContract();
                DataToContract(crudeFinancialBankAccountNumberTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialBankAccountNumberTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialBankAccountNumberTypeRefContract>();
            List<CrudeFinancialBankAccountNumberTypeRefData> dataList = CrudeFinancialBankAccountNumberTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialBankAccountNumberTypeRefData crudeFinancialBankAccountNumberTypeRef in dataList) {
                var contract = new CrudeFinancialBankAccountNumberTypeRefContract();
                DataToContract(crudeFinancialBankAccountNumberTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialBankAccountNumberTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialBankAccountNumberTypeRefContract>();
            List<CrudeFinancialBankAccountNumberTypeRefData> dataList = CrudeFinancialBankAccountNumberTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialBankAccountNumberTypeRefData crudeFinancialBankAccountNumberTypeRef in dataList) {
                var contract = new CrudeFinancialBankAccountNumberTypeRefContract();
                DataToContract(crudeFinancialBankAccountNumberTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialBankAccountNumberTypeRefData.FetchAllCount();
        }
        
        public List<CrudeFinancialBankAccountNumberTypeRefContract> FetchWithFilter(string financialBankAccountNumberTypeRcd, string financialBankAccountNumberTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialBankAccountNumberTypeRefContract>();
            List<CrudeFinancialBankAccountNumberTypeRefData> dataList = CrudeFinancialBankAccountNumberTypeRefData.FetchWithFilter(
                financialBankAccountNumberTypeRcd: financialBankAccountNumberTypeRcd,
                financialBankAccountNumberTypeName: financialBankAccountNumberTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialBankAccountNumberTypeRefData data in dataList) {
                var crudeFinancialBankAccountNumberTypeRefContract = new CrudeFinancialBankAccountNumberTypeRefContract();
                DataToContract(data, crudeFinancialBankAccountNumberTypeRefContract);
                list.Add(crudeFinancialBankAccountNumberTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialBankAccountNumberTypeRefContract contract) {
            var data = new CrudeFinancialBankAccountNumberTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialBankAccountNumberTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialBankAccountNumberTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialBankAccountNumberTypeRefContract contract) {
            var data = new CrudeFinancialBankAccountNumberTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialBankAccountNumberTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialBankAccountNumberTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialBankAccountNumberTypeRcd) {
            CrudeFinancialBankAccountNumberTypeRefData.Delete(financialBankAccountNumberTypeRcd);
        }
        
        public static void ContractToData(CrudeFinancialBankAccountNumberTypeRefContract contract, CrudeFinancialBankAccountNumberTypeRefData data) {
            data.FinancialBankAccountNumberTypeRcd = contract.FinancialBankAccountNumberTypeRcd;
            data.FinancialBankAccountNumberTypeName = contract.FinancialBankAccountNumberTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialBankAccountNumberTypeRefData data, CrudeFinancialBankAccountNumberTypeRefContract contract) {
            contract.FinancialBankAccountNumberTypeRcd = data.FinancialBankAccountNumberTypeRcd;
            contract.FinancialBankAccountNumberTypeName = data.FinancialBankAccountNumberTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
