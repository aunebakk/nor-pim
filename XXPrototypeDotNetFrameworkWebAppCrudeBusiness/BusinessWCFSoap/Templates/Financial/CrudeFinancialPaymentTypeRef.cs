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
    public partial interface ICrudeFinancialPaymentTypeRefService {
        
        [OperationContract()]
        CrudeFinancialPaymentTypeRefContract FetchByFinancialPaymentTypeRcd(string financialPaymentTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialPaymentTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeFinancialPaymentTypeRefContract FetchByFinancialPaymentTypeName(string financialPaymentTypeName);
        
        [OperationContract()]
        List<CrudeFinancialPaymentTypeRefContract> FetchWithFilter(string financialPaymentTypeRcd, string financialPaymentTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeFinancialPaymentTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialPaymentTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialPaymentTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialPaymentTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialPaymentTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string financialPaymentTypeRcd);
    }
    
    public partial class CrudeFinancialPaymentTypeRefService : ICrudeFinancialPaymentTypeRefService {
        
        public CrudeFinancialPaymentTypeRefContract FetchByFinancialPaymentTypeRcd(string financialPaymentTypeRcd) {
            var dataAccessLayer = new CrudeFinancialPaymentTypeRefData();
            var contract = new CrudeFinancialPaymentTypeRefContract();

            dataAccessLayer.FetchByFinancialPaymentTypeRcd(financialPaymentTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialPaymentTypeRefContract FetchByFinancialPaymentTypeName(string financialPaymentTypeName) {
            var dataAccessLayer = new CrudeFinancialPaymentTypeRefData();
            var contract = new CrudeFinancialPaymentTypeRefContract();

            dataAccessLayer.FetchByFinancialPaymentTypeName(financialPaymentTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialPaymentTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialPaymentTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeFinancialPaymentTypeRefContract> DataListToContractList(List<CrudeFinancialPaymentTypeRefData> dataList) {
            var contractList = new List<CrudeFinancialPaymentTypeRefContract>();

            foreach (CrudeFinancialPaymentTypeRefData data in dataList) {
                var contract = new CrudeFinancialPaymentTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialPaymentTypeRefContract> contractList, List<CrudeFinancialPaymentTypeRefData> dataList) {
            foreach (CrudeFinancialPaymentTypeRefContract contract in contractList) {
                var data = new CrudeFinancialPaymentTypeRefData();
                CrudeFinancialPaymentTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentTypeRefContract> FetchAll() {
            var list = new List<CrudeFinancialPaymentTypeRefContract>();
            List<CrudeFinancialPaymentTypeRefData> dataList = CrudeFinancialPaymentTypeRefData.FetchAll();

            foreach (CrudeFinancialPaymentTypeRefData crudeFinancialPaymentTypeRef in dataList) {
                var contract = new CrudeFinancialPaymentTypeRefContract();
                DataToContract(crudeFinancialPaymentTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialPaymentTypeRefContract>();
            List<CrudeFinancialPaymentTypeRefData> dataList = CrudeFinancialPaymentTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialPaymentTypeRefData crudeFinancialPaymentTypeRef in dataList) {
                var contract = new CrudeFinancialPaymentTypeRefContract();
                DataToContract(crudeFinancialPaymentTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialPaymentTypeRefContract>();
            List<CrudeFinancialPaymentTypeRefData> dataList = CrudeFinancialPaymentTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialPaymentTypeRefData crudeFinancialPaymentTypeRef in dataList) {
                var contract = new CrudeFinancialPaymentTypeRefContract();
                DataToContract(crudeFinancialPaymentTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentTypeRefData.FetchAllCount();
        }
        
        public List<CrudeFinancialPaymentTypeRefContract> FetchWithFilter(string financialPaymentTypeRcd, string financialPaymentTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeFinancialPaymentTypeRefContract>();
            List<CrudeFinancialPaymentTypeRefData> dataList = CrudeFinancialPaymentTypeRefData.FetchWithFilter(
                financialPaymentTypeRcd: financialPaymentTypeRcd,
                financialPaymentTypeName: financialPaymentTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeFinancialPaymentTypeRefData data in dataList) {
                var crudeFinancialPaymentTypeRefContract = new CrudeFinancialPaymentTypeRefContract();
                DataToContract(data, crudeFinancialPaymentTypeRefContract);
                list.Add(crudeFinancialPaymentTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentTypeRefContract contract) {
            var data = new CrudeFinancialPaymentTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentTypeRefContract contract) {
            var data = new CrudeFinancialPaymentTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string financialPaymentTypeRcd) {
            CrudeFinancialPaymentTypeRefData.Delete(financialPaymentTypeRcd);
        }
        
        public static void ContractToData(CrudeFinancialPaymentTypeRefContract contract, CrudeFinancialPaymentTypeRefData data) {
            data.FinancialPaymentTypeRcd = contract.FinancialPaymentTypeRcd;
            data.FinancialPaymentTypeName = contract.FinancialPaymentTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeFinancialPaymentTypeRefData data, CrudeFinancialPaymentTypeRefContract contract) {
            contract.FinancialPaymentTypeRcd = data.FinancialPaymentTypeRcd;
            contract.FinancialPaymentTypeName = data.FinancialPaymentTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
