/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:32:01 AM
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
    public partial interface ICrudeFinancialPaymentCashService {
        
        [OperationContract()]
        CrudeFinancialPaymentCashContract FetchByFinancialPaymentCashId(System.Guid financialPaymentCashId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCashContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCashContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCashContract> FetchWithFilter(System.Guid financialPaymentCashId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCashContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialPaymentCashContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCashContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialPaymentCashContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialPaymentCashContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialPaymentCashId);
    }
    
    public partial class CrudeFinancialPaymentCashService : ICrudeFinancialPaymentCashService {
        
        public CrudeFinancialPaymentCashContract FetchByFinancialPaymentCashId(System.Guid financialPaymentCashId) {
            var dataAccessLayer = new CrudeFinancialPaymentCashData();
            var contract = new CrudeFinancialPaymentCashContract();

            dataAccessLayer.FetchByFinancialPaymentCashId(financialPaymentCashId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialPaymentCashContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialPaymentCashData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialPaymentCashContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialPaymentCashData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public static List<CrudeFinancialPaymentCashContract> DataListToContractList(List<CrudeFinancialPaymentCashData> dataList) {
            var contractList = new List<CrudeFinancialPaymentCashContract>();

            foreach (CrudeFinancialPaymentCashData data in dataList) {
                var contract = new CrudeFinancialPaymentCashContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialPaymentCashContract> contractList, List<CrudeFinancialPaymentCashData> dataList) {
            foreach (CrudeFinancialPaymentCashContract contract in contractList) {
                var data = new CrudeFinancialPaymentCashData();
                CrudeFinancialPaymentCashService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentCashContract> FetchAll() {
            var list = new List<CrudeFinancialPaymentCashContract>();
            List<CrudeFinancialPaymentCashData> dataList = CrudeFinancialPaymentCashData.FetchAll();

            foreach (CrudeFinancialPaymentCashData crudeFinancialPaymentCash in dataList) {
                var contract = new CrudeFinancialPaymentCashContract();
                DataToContract(crudeFinancialPaymentCash, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentCashContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialPaymentCashContract>();
            List<CrudeFinancialPaymentCashData> dataList = CrudeFinancialPaymentCashData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialPaymentCashData crudeFinancialPaymentCash in dataList) {
                var contract = new CrudeFinancialPaymentCashContract();
                DataToContract(crudeFinancialPaymentCash, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentCashContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialPaymentCashContract>();
            List<CrudeFinancialPaymentCashData> dataList = CrudeFinancialPaymentCashData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialPaymentCashData crudeFinancialPaymentCash in dataList) {
                var contract = new CrudeFinancialPaymentCashContract();
                DataToContract(crudeFinancialPaymentCash, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentCashData.FetchAllCount();
        }
        
        public List<CrudeFinancialPaymentCashContract> FetchWithFilter(System.Guid financialPaymentCashId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId) {
            var list = new List<CrudeFinancialPaymentCashContract>();
            List<CrudeFinancialPaymentCashData> dataList = CrudeFinancialPaymentCashData.FetchWithFilter(
                financialPaymentCashId: financialPaymentCashId,
                userId: userId,
                dateTime: dateTime,
                amount: amount,
                financialCurrencyId: financialCurrencyId
                );

            foreach (CrudeFinancialPaymentCashData data in dataList) {
                var crudeFinancialPaymentCashContract = new CrudeFinancialPaymentCashContract();
                DataToContract(data, crudeFinancialPaymentCashContract);
                list.Add(crudeFinancialPaymentCashContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentCashContract contract) {
            var data = new CrudeFinancialPaymentCashData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentCashContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCashData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentCashContract contract) {
            var data = new CrudeFinancialPaymentCashData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentCashContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCashData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialPaymentCashId) {
            CrudeFinancialPaymentCashData.Delete(financialPaymentCashId);
        }
        
        public static void ContractToData(CrudeFinancialPaymentCashContract contract, CrudeFinancialPaymentCashData data) {
            data.FinancialPaymentCashId = contract.FinancialPaymentCashId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.Amount = contract.Amount;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
        }
        
        public static void DataToContract(CrudeFinancialPaymentCashData data, CrudeFinancialPaymentCashContract contract) {
            contract.FinancialPaymentCashId = data.FinancialPaymentCashId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.Amount = data.Amount;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
        }
    }
}
