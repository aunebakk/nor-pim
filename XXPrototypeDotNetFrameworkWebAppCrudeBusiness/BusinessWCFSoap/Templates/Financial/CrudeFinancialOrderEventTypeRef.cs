/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:20:04 AM
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
    public partial interface ICrudeFinancialOrderEventTypeRefService {
        
        [OperationContract()]
        CrudeFinancialOrderEventTypeRefContract FetchByFinancialOrderEventTypeRcd(string financialOrderEventTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialOrderEventTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialOrderEventTypeRefContract FetchByFinancialOrderEventTypeName(string financialOrderEventTypeName);
        
        [OperationContract()]
        List<CrudeFinancialOrderEventTypeRefContract> FetchWithFilter(string financialOrderEventTypeRcd, string financialOrderEventTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialOrderEventTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialOrderEventTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialOrderEventTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialOrderEventTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialOrderEventTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string financialOrderEventTypeRcd);
    }
    
    public partial class CrudeFinancialOrderEventTypeRefService : ICrudeFinancialOrderEventTypeRefService {
        
        public CrudeFinancialOrderEventTypeRefContract FetchByFinancialOrderEventTypeRcd(string financialOrderEventTypeRcd) {
            var dataAccessLayer = new CrudeFinancialOrderEventTypeRefData();
            var contract = new CrudeFinancialOrderEventTypeRefContract();

            dataAccessLayer.FetchByFinancialOrderEventTypeRcd(financialOrderEventTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialOrderEventTypeRefContract FetchByFinancialOrderEventTypeName(string financialOrderEventTypeName) {
            var dataAccessLayer = new CrudeFinancialOrderEventTypeRefData();
            var contract = new CrudeFinancialOrderEventTypeRefContract();

            dataAccessLayer.FetchByFinancialOrderEventTypeName(financialOrderEventTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialOrderEventTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialOrderEventTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialOrderEventTypeRefContract> DataListToContractList(List<CrudeFinancialOrderEventTypeRefData> dataList) {
            var contractList = new List<CrudeFinancialOrderEventTypeRefContract>();

            foreach (CrudeFinancialOrderEventTypeRefData data in dataList) {
                var contract = new CrudeFinancialOrderEventTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialOrderEventTypeRefContract> contractList, List<CrudeFinancialOrderEventTypeRefData> dataList) {
            foreach (CrudeFinancialOrderEventTypeRefContract contract in contractList) {
                var data = new CrudeFinancialOrderEventTypeRefData();
                CrudeFinancialOrderEventTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderEventTypeRefContract> FetchAll() {
            var list = new List<CrudeFinancialOrderEventTypeRefContract>();
            List<CrudeFinancialOrderEventTypeRefData> dataList = CrudeFinancialOrderEventTypeRefData.FetchAll();

            foreach (CrudeFinancialOrderEventTypeRefData crudeFinancialOrderEventTypeRef in dataList) {
                var contract = new CrudeFinancialOrderEventTypeRefContract();
                DataToContract(crudeFinancialOrderEventTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderEventTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialOrderEventTypeRefContract>();
            List<CrudeFinancialOrderEventTypeRefData> dataList = CrudeFinancialOrderEventTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialOrderEventTypeRefData crudeFinancialOrderEventTypeRef in dataList) {
                var contract = new CrudeFinancialOrderEventTypeRefContract();
                DataToContract(crudeFinancialOrderEventTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderEventTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialOrderEventTypeRefContract>();
            List<CrudeFinancialOrderEventTypeRefData> dataList = CrudeFinancialOrderEventTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialOrderEventTypeRefData crudeFinancialOrderEventTypeRef in dataList) {
                var contract = new CrudeFinancialOrderEventTypeRefContract();
                DataToContract(crudeFinancialOrderEventTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderEventTypeRefData.FetchAllCount();
        }
        
        public List<CrudeFinancialOrderEventTypeRefContract> FetchWithFilter(string financialOrderEventTypeRcd, string financialOrderEventTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialOrderEventTypeRefContract>();
            List<CrudeFinancialOrderEventTypeRefData> dataList = CrudeFinancialOrderEventTypeRefData.FetchWithFilter(
                financialOrderEventTypeRcd: financialOrderEventTypeRcd,
                financialOrderEventTypeName: financialOrderEventTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialOrderEventTypeRefData data in dataList) {
                var crudeFinancialOrderEventTypeRefContract = new CrudeFinancialOrderEventTypeRefContract();
                DataToContract(data, crudeFinancialOrderEventTypeRefContract);
                list.Add(crudeFinancialOrderEventTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderEventTypeRefContract contract) {
            var data = new CrudeFinancialOrderEventTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderEventTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderEventTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderEventTypeRefContract contract) {
            var data = new CrudeFinancialOrderEventTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderEventTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderEventTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialOrderEventTypeRcd) {
            CrudeFinancialOrderEventTypeRefData.Delete(financialOrderEventTypeRcd);
        }
        
        public static void ContractToData(CrudeFinancialOrderEventTypeRefContract contract, CrudeFinancialOrderEventTypeRefData data) {
            data.FinancialOrderEventTypeRcd = contract.FinancialOrderEventTypeRcd;
            data.FinancialOrderEventTypeName = contract.FinancialOrderEventTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialOrderEventTypeRefData data, CrudeFinancialOrderEventTypeRefContract contract) {
            contract.FinancialOrderEventTypeRcd = data.FinancialOrderEventTypeRcd;
            contract.FinancialOrderEventTypeName = data.FinancialOrderEventTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
