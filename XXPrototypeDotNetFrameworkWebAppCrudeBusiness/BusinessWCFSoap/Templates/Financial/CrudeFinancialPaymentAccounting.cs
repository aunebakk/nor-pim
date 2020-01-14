/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:18:54 PM
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
    public partial interface ICrudeFinancialPaymentAccountingService {
        
        [OperationContract()]
        CrudeFinancialPaymentAccountingContract FetchByFinancialPaymentAccountingId(System.Guid financialPaymentAccountingId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentAccountingContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentAccountingContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentAccountingContract> FetchWithFilter(System.Guid financialPaymentAccountingId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentAccountingContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialPaymentAccountingContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialPaymentAccountingContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialPaymentAccountingContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialPaymentAccountingContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialPaymentAccountingId);
    }
    
    public partial class CrudeFinancialPaymentAccountingService : ICrudeFinancialPaymentAccountingService {
        
        public CrudeFinancialPaymentAccountingContract FetchByFinancialPaymentAccountingId(System.Guid financialPaymentAccountingId) {
            var dataAccessLayer = new CrudeFinancialPaymentAccountingData();
            var contract = new CrudeFinancialPaymentAccountingContract();

            dataAccessLayer.FetchByFinancialPaymentAccountingId(financialPaymentAccountingId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialPaymentAccountingContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialPaymentAccountingData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialPaymentAccountingContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialPaymentAccountingData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public static List<CrudeFinancialPaymentAccountingContract> DataListToContractList(List<CrudeFinancialPaymentAccountingData> dataList) {
            var contractList = new List<CrudeFinancialPaymentAccountingContract>();

            foreach (CrudeFinancialPaymentAccountingData data in dataList) {
                var contract = new CrudeFinancialPaymentAccountingContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialPaymentAccountingContract> contractList, List<CrudeFinancialPaymentAccountingData> dataList) {
            foreach (CrudeFinancialPaymentAccountingContract contract in contractList) {
                var data = new CrudeFinancialPaymentAccountingData();
                CrudeFinancialPaymentAccountingService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentAccountingContract> FetchAll() {
            var list = new List<CrudeFinancialPaymentAccountingContract>();
            List<CrudeFinancialPaymentAccountingData> dataList = CrudeFinancialPaymentAccountingData.FetchAll();

            foreach (CrudeFinancialPaymentAccountingData crudeFinancialPaymentAccounting in dataList) {
                var contract = new CrudeFinancialPaymentAccountingContract();
                DataToContract(crudeFinancialPaymentAccounting, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentAccountingContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialPaymentAccountingContract>();
            List<CrudeFinancialPaymentAccountingData> dataList = CrudeFinancialPaymentAccountingData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialPaymentAccountingData crudeFinancialPaymentAccounting in dataList) {
                var contract = new CrudeFinancialPaymentAccountingContract();
                DataToContract(crudeFinancialPaymentAccounting, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentAccountingContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialPaymentAccountingContract>();
            List<CrudeFinancialPaymentAccountingData> dataList = CrudeFinancialPaymentAccountingData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialPaymentAccountingData crudeFinancialPaymentAccounting in dataList) {
                var contract = new CrudeFinancialPaymentAccountingContract();
                DataToContract(crudeFinancialPaymentAccounting, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentAccountingData.FetchAllCount();
        }
        
        public List<CrudeFinancialPaymentAccountingContract> FetchWithFilter(System.Guid financialPaymentAccountingId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId) {
            var list = new List<CrudeFinancialPaymentAccountingContract>();
            List<CrudeFinancialPaymentAccountingData> dataList = CrudeFinancialPaymentAccountingData.FetchWithFilter(
                financialPaymentAccountingId: financialPaymentAccountingId,
                userId: userId,
                dateTime: dateTime,
                amount: amount,
                financialCurrencyId: financialCurrencyId
                );

            foreach (CrudeFinancialPaymentAccountingData data in dataList) {
                var crudeFinancialPaymentAccountingContract = new CrudeFinancialPaymentAccountingContract();
                DataToContract(data, crudeFinancialPaymentAccountingContract);
                list.Add(crudeFinancialPaymentAccountingContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentAccountingContract contract) {
            var data = new CrudeFinancialPaymentAccountingData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentAccountingContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentAccountingData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentAccountingContract contract) {
            var data = new CrudeFinancialPaymentAccountingData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentAccountingContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentAccountingData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialPaymentAccountingId) {
            CrudeFinancialPaymentAccountingData.Delete(financialPaymentAccountingId);
        }
        
        public static void ContractToData(CrudeFinancialPaymentAccountingContract contract, CrudeFinancialPaymentAccountingData data) {
            data.FinancialPaymentAccountingId = contract.FinancialPaymentAccountingId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.Amount = contract.Amount;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
        }
        
        public static void DataToContract(CrudeFinancialPaymentAccountingData data, CrudeFinancialPaymentAccountingContract contract) {
            contract.FinancialPaymentAccountingId = data.FinancialPaymentAccountingId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.Amount = data.Amount;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
        }
    }
}
