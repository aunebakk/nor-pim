/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:44:04 AM
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
    public partial interface ICrudeFinancialCardTypeRefService {
        
        [OperationContract()]
        CrudeFinancialCardTypeRefContract FetchByFinancialCardTypeRcd(string financialCardTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialCardTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialCardTypeRefContract FetchByFinancialCardTypeName(string financialCardTypeName);
        
        [OperationContract()]
        List<CrudeFinancialCardTypeRefContract> FetchWithFilter(string financialCardTypeRcd, string financialCardTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialCardTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialCardTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialCardTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialCardTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialCardTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string financialCardTypeRcd);
    }
    
    public partial class CrudeFinancialCardTypeRefService : ICrudeFinancialCardTypeRefService {
        
        public CrudeFinancialCardTypeRefContract FetchByFinancialCardTypeRcd(string financialCardTypeRcd) {
            var dataAccessLayer = new CrudeFinancialCardTypeRefData();
            var contract = new CrudeFinancialCardTypeRefContract();

            dataAccessLayer.FetchByFinancialCardTypeRcd(financialCardTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialCardTypeRefContract FetchByFinancialCardTypeName(string financialCardTypeName) {
            var dataAccessLayer = new CrudeFinancialCardTypeRefData();
            var contract = new CrudeFinancialCardTypeRefContract();

            dataAccessLayer.FetchByFinancialCardTypeName(financialCardTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialCardTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialCardTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialCardTypeRefContract> DataListToContractList(List<CrudeFinancialCardTypeRefData> dataList) {
            var contractList = new List<CrudeFinancialCardTypeRefContract>();

            foreach (CrudeFinancialCardTypeRefData data in dataList) {
                var contract = new CrudeFinancialCardTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialCardTypeRefContract> contractList, List<CrudeFinancialCardTypeRefData> dataList) {
            foreach (CrudeFinancialCardTypeRefContract contract in contractList) {
                var data = new CrudeFinancialCardTypeRefData();
                CrudeFinancialCardTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialCardTypeRefContract> FetchAll() {
            var list = new List<CrudeFinancialCardTypeRefContract>();
            List<CrudeFinancialCardTypeRefData> dataList = CrudeFinancialCardTypeRefData.FetchAll();

            foreach (CrudeFinancialCardTypeRefData crudeFinancialCardTypeRef in dataList) {
                var contract = new CrudeFinancialCardTypeRefContract();
                DataToContract(crudeFinancialCardTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialCardTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialCardTypeRefContract>();
            List<CrudeFinancialCardTypeRefData> dataList = CrudeFinancialCardTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialCardTypeRefData crudeFinancialCardTypeRef in dataList) {
                var contract = new CrudeFinancialCardTypeRefContract();
                DataToContract(crudeFinancialCardTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialCardTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialCardTypeRefContract>();
            List<CrudeFinancialCardTypeRefData> dataList = CrudeFinancialCardTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialCardTypeRefData crudeFinancialCardTypeRef in dataList) {
                var contract = new CrudeFinancialCardTypeRefContract();
                DataToContract(crudeFinancialCardTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialCardTypeRefData.FetchAllCount();
        }
        
        public List<CrudeFinancialCardTypeRefContract> FetchWithFilter(string financialCardTypeRcd, string financialCardTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialCardTypeRefContract>();
            List<CrudeFinancialCardTypeRefData> dataList = CrudeFinancialCardTypeRefData.FetchWithFilter(
                financialCardTypeRcd: financialCardTypeRcd,
                financialCardTypeName: financialCardTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialCardTypeRefData data in dataList) {
                var crudeFinancialCardTypeRefContract = new CrudeFinancialCardTypeRefContract();
                DataToContract(data, crudeFinancialCardTypeRefContract);
                list.Add(crudeFinancialCardTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialCardTypeRefContract contract) {
            var data = new CrudeFinancialCardTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialCardTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCardTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialCardTypeRefContract contract) {
            var data = new CrudeFinancialCardTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialCardTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCardTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialCardTypeRcd) {
            CrudeFinancialCardTypeRefData.Delete(financialCardTypeRcd);
        }
        
        public static void ContractToData(CrudeFinancialCardTypeRefContract contract, CrudeFinancialCardTypeRefData data) {
            data.FinancialCardTypeRcd = contract.FinancialCardTypeRcd;
            data.FinancialCardTypeName = contract.FinancialCardTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialCardTypeRefData data, CrudeFinancialCardTypeRefContract contract) {
            contract.FinancialCardTypeRcd = data.FinancialCardTypeRcd;
            contract.FinancialCardTypeName = data.FinancialCardTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
