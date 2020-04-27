/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:43:09 PM
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
    public partial interface ICrudeFinancialOrderTransactionService {
        
        [OperationContract()]
        CrudeFinancialOrderTransactionContract FetchByFinancialBookingTransactionId(System.Guid financialBookingTransactionId);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionContract> FetchByFinancialFeeId(System.Guid financialFeeId);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionContract> FetchByFinancialTaxId(System.Guid financialTaxId);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionContract> FetchByFinancialPaymentId(System.Guid financialPaymentId);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionContract> FetchByFinancialCostcentreId(System.Guid financialCostcentreId);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionContract> FetchByFinancialAdjustmentId(System.Guid financialAdjustmentId);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionContract> FetchByFinancialOrderId(System.Guid financialOrderId);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionContract> FetchByFinancialOrderTransactionTypeRcd(string financialOrderTransactionTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionContract> FetchWithFilter(System.Guid financialBookingTransactionId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialFeeId, System.Guid financialTaxId, System.Guid financialPaymentId, System.Guid financialCurrencyId, int transactionNumber, System.Guid financialCostcentreId, System.Guid financialAdjustmentId, string financialOrderTransactionTypeRcd, System.Guid financialOrderId);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialOrderTransactionContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialOrderTransactionContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialOrderTransactionContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialBookingTransactionId);
    }
    
    public partial class CrudeFinancialOrderTransactionService : ICrudeFinancialOrderTransactionService {
        
        public CrudeFinancialOrderTransactionContract FetchByFinancialBookingTransactionId(System.Guid financialBookingTransactionId) {
            var dataAccessLayer = new CrudeFinancialOrderTransactionData();
            var contract = new CrudeFinancialOrderTransactionContract();

            dataAccessLayer.FetchByFinancialBookingTransactionId(financialBookingTransactionId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialOrderTransactionContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialOrderTransactionData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialOrderTransactionContract> FetchByFinancialFeeId(System.Guid financialFeeId) {
            return DataListToContractList(CrudeFinancialOrderTransactionData.FetchByFinancialFeeId(financialFeeId));
        }
        
        public List<CrudeFinancialOrderTransactionContract> FetchByFinancialTaxId(System.Guid financialTaxId) {
            return DataListToContractList(CrudeFinancialOrderTransactionData.FetchByFinancialTaxId(financialTaxId));
        }
        
        public List<CrudeFinancialOrderTransactionContract> FetchByFinancialPaymentId(System.Guid financialPaymentId) {
            return DataListToContractList(CrudeFinancialOrderTransactionData.FetchByFinancialPaymentId(financialPaymentId));
        }
        
        public List<CrudeFinancialOrderTransactionContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialOrderTransactionData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeFinancialOrderTransactionContract> FetchByFinancialCostcentreId(System.Guid financialCostcentreId) {
            return DataListToContractList(CrudeFinancialOrderTransactionData.FetchByFinancialCostcentreId(financialCostcentreId));
        }
        
        public List<CrudeFinancialOrderTransactionContract> FetchByFinancialAdjustmentId(System.Guid financialAdjustmentId) {
            return DataListToContractList(CrudeFinancialOrderTransactionData.FetchByFinancialAdjustmentId(financialAdjustmentId));
        }
        
        public List<CrudeFinancialOrderTransactionContract> FetchByFinancialOrderId(System.Guid financialOrderId) {
            return DataListToContractList(CrudeFinancialOrderTransactionData.FetchByFinancialOrderId(financialOrderId));
        }
        
        public List<CrudeFinancialOrderTransactionContract> FetchByFinancialOrderTransactionTypeRcd(string financialOrderTransactionTypeRcd) {
            return DataListToContractList(CrudeFinancialOrderTransactionData.FetchByFinancialOrderTransactionTypeRcd(financialOrderTransactionTypeRcd));
        }
        
        public static List<CrudeFinancialOrderTransactionContract> DataListToContractList(List<CrudeFinancialOrderTransactionData> dataList) {
            var contractList = new List<CrudeFinancialOrderTransactionContract>();

            foreach (CrudeFinancialOrderTransactionData data in dataList) {
                var contract = new CrudeFinancialOrderTransactionContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialOrderTransactionContract> contractList, List<CrudeFinancialOrderTransactionData> dataList) {
            foreach (CrudeFinancialOrderTransactionContract contract in contractList) {
                var data = new CrudeFinancialOrderTransactionData();
                CrudeFinancialOrderTransactionService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderTransactionContract> FetchAll() {
            var list = new List<CrudeFinancialOrderTransactionContract>();
            List<CrudeFinancialOrderTransactionData> dataList = CrudeFinancialOrderTransactionData.FetchAll();

            foreach (CrudeFinancialOrderTransactionData crudeFinancialOrderTransaction in dataList) {
                var contract = new CrudeFinancialOrderTransactionContract();
                DataToContract(crudeFinancialOrderTransaction, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderTransactionContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialOrderTransactionContract>();
            List<CrudeFinancialOrderTransactionData> dataList = CrudeFinancialOrderTransactionData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialOrderTransactionData crudeFinancialOrderTransaction in dataList) {
                var contract = new CrudeFinancialOrderTransactionContract();
                DataToContract(crudeFinancialOrderTransaction, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderTransactionContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialOrderTransactionContract>();
            List<CrudeFinancialOrderTransactionData> dataList = CrudeFinancialOrderTransactionData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialOrderTransactionData crudeFinancialOrderTransaction in dataList) {
                var contract = new CrudeFinancialOrderTransactionContract();
                DataToContract(crudeFinancialOrderTransaction, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderTransactionData.FetchAllCount();
        }
        
        public List<CrudeFinancialOrderTransactionContract> FetchWithFilter(System.Guid financialBookingTransactionId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialFeeId, System.Guid financialTaxId, System.Guid financialPaymentId, System.Guid financialCurrencyId, int transactionNumber, System.Guid financialCostcentreId, System.Guid financialAdjustmentId, string financialOrderTransactionTypeRcd, System.Guid financialOrderId) {
            var list = new List<CrudeFinancialOrderTransactionContract>();
            List<CrudeFinancialOrderTransactionData> dataList = CrudeFinancialOrderTransactionData.FetchWithFilter(
                financialBookingTransactionId: financialBookingTransactionId,
                userId: userId,
                dateTime: dateTime,
                amount: amount,
                financialFeeId: financialFeeId,
                financialTaxId: financialTaxId,
                financialPaymentId: financialPaymentId,
                financialCurrencyId: financialCurrencyId,
                transactionNumber: transactionNumber,
                financialCostcentreId: financialCostcentreId,
                financialAdjustmentId: financialAdjustmentId,
                financialOrderTransactionTypeRcd: financialOrderTransactionTypeRcd,
                financialOrderId: financialOrderId
                );

            foreach (CrudeFinancialOrderTransactionData data in dataList) {
                var crudeFinancialOrderTransactionContract = new CrudeFinancialOrderTransactionContract();
                DataToContract(data, crudeFinancialOrderTransactionContract);
                list.Add(crudeFinancialOrderTransactionContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderTransactionContract contract) {
            var data = new CrudeFinancialOrderTransactionData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderTransactionContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderTransactionData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderTransactionContract contract) {
            var data = new CrudeFinancialOrderTransactionData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderTransactionContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderTransactionData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialBookingTransactionId) {
            CrudeFinancialOrderTransactionData.Delete(financialBookingTransactionId);
        }
        
        public static void ContractToData(CrudeFinancialOrderTransactionContract contract, CrudeFinancialOrderTransactionData data) {
            data.FinancialBookingTransactionId = contract.FinancialBookingTransactionId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.Amount = contract.Amount;
            data.FinancialFeeId = contract.FinancialFeeId;
            data.FinancialTaxId = contract.FinancialTaxId;
            data.FinancialPaymentId = contract.FinancialPaymentId;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.TransactionNumber = contract.TransactionNumber;
            data.FinancialCostcentreId = contract.FinancialCostcentreId;
            data.FinancialAdjustmentId = contract.FinancialAdjustmentId;
            data.FinancialOrderTransactionTypeRcd = contract.FinancialOrderTransactionTypeRcd;
            data.FinancialOrderId = contract.FinancialOrderId;
        }
        
        public static void DataToContract(CrudeFinancialOrderTransactionData data, CrudeFinancialOrderTransactionContract contract) {
            contract.FinancialBookingTransactionId = data.FinancialBookingTransactionId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.Amount = data.Amount;
            contract.FinancialFeeId = data.FinancialFeeId;
            contract.FinancialTaxId = data.FinancialTaxId;
            contract.FinancialPaymentId = data.FinancialPaymentId;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.TransactionNumber = data.TransactionNumber;
            contract.FinancialCostcentreId = data.FinancialCostcentreId;
            contract.FinancialAdjustmentId = data.FinancialAdjustmentId;
            contract.FinancialOrderTransactionTypeRcd = data.FinancialOrderTransactionTypeRcd;
            contract.FinancialOrderId = data.FinancialOrderId;
        }
    }
}
