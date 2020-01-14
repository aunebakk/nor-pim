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
    public partial interface ICrudeFinancialPaymentBankService {
        
        [OperationContract()]
        CrudeFinancialPaymentBankContract FetchByFinancialPaymentBankId(System.Guid financialPaymentBankId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentBankContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentBankContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentBankContract> FetchByFinancialBankAccountNumberTypeRcd(string financialBankAccountNumberTypeRcd);
        
        [OperationContract()]
        CrudeFinancialPaymentBankContract FetchByBankName(string bankName);
        
        [OperationContract()]
        List<CrudeFinancialPaymentBankContract> FetchWithFilter(System.Guid financialPaymentBankId, System.Guid userId, System.DateTime dateTime, string bankName, string bankAccount, string bankNumber, string financialBankAccountNumberTypeRcd, decimal amount, System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentBankContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialPaymentBankContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialPaymentBankContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialPaymentBankContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialPaymentBankContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialPaymentBankId);
    }
    
    public partial class CrudeFinancialPaymentBankService : ICrudeFinancialPaymentBankService {
        
        public CrudeFinancialPaymentBankContract FetchByFinancialPaymentBankId(System.Guid financialPaymentBankId) {
            var dataAccessLayer = new CrudeFinancialPaymentBankData();
            var contract = new CrudeFinancialPaymentBankContract();

            dataAccessLayer.FetchByFinancialPaymentBankId(financialPaymentBankId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeFinancialPaymentBankContract FetchByBankName(string bankName) {
            var dataAccessLayer = new CrudeFinancialPaymentBankData();
            var contract = new CrudeFinancialPaymentBankContract();

            dataAccessLayer.FetchByBankName(bankName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialPaymentBankContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialPaymentBankData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialPaymentBankContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialPaymentBankData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeFinancialPaymentBankContract> FetchByFinancialBankAccountNumberTypeRcd(string financialBankAccountNumberTypeRcd) {
            return DataListToContractList(CrudeFinancialPaymentBankData.FetchByFinancialBankAccountNumberTypeRcd(financialBankAccountNumberTypeRcd));
        }
        
        public static List<CrudeFinancialPaymentBankContract> DataListToContractList(List<CrudeFinancialPaymentBankData> dataList) {
            var contractList = new List<CrudeFinancialPaymentBankContract>();

            foreach (CrudeFinancialPaymentBankData data in dataList) {
                var contract = new CrudeFinancialPaymentBankContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialPaymentBankContract> contractList, List<CrudeFinancialPaymentBankData> dataList) {
            foreach (CrudeFinancialPaymentBankContract contract in contractList) {
                var data = new CrudeFinancialPaymentBankData();
                CrudeFinancialPaymentBankService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentBankContract> FetchAll() {
            var list = new List<CrudeFinancialPaymentBankContract>();
            List<CrudeFinancialPaymentBankData> dataList = CrudeFinancialPaymentBankData.FetchAll();

            foreach (CrudeFinancialPaymentBankData crudeFinancialPaymentBank in dataList) {
                var contract = new CrudeFinancialPaymentBankContract();
                DataToContract(crudeFinancialPaymentBank, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentBankContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialPaymentBankContract>();
            List<CrudeFinancialPaymentBankData> dataList = CrudeFinancialPaymentBankData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialPaymentBankData crudeFinancialPaymentBank in dataList) {
                var contract = new CrudeFinancialPaymentBankContract();
                DataToContract(crudeFinancialPaymentBank, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentBankContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialPaymentBankContract>();
            List<CrudeFinancialPaymentBankData> dataList = CrudeFinancialPaymentBankData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialPaymentBankData crudeFinancialPaymentBank in dataList) {
                var contract = new CrudeFinancialPaymentBankContract();
                DataToContract(crudeFinancialPaymentBank, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentBankData.FetchAllCount();
        }
        
        public List<CrudeFinancialPaymentBankContract> FetchWithFilter(System.Guid financialPaymentBankId, System.Guid userId, System.DateTime dateTime, string bankName, string bankAccount, string bankNumber, string financialBankAccountNumberTypeRcd, decimal amount, System.Guid financialCurrencyId) {
            var list = new List<CrudeFinancialPaymentBankContract>();
            List<CrudeFinancialPaymentBankData> dataList = CrudeFinancialPaymentBankData.FetchWithFilter(
                financialPaymentBankId: financialPaymentBankId,
                userId: userId,
                dateTime: dateTime,
                bankName: bankName,
                bankAccount: bankAccount,
                bankNumber: bankNumber,
                financialBankAccountNumberTypeRcd: financialBankAccountNumberTypeRcd,
                amount: amount,
                financialCurrencyId: financialCurrencyId
                );

            foreach (CrudeFinancialPaymentBankData data in dataList) {
                var crudeFinancialPaymentBankContract = new CrudeFinancialPaymentBankContract();
                DataToContract(data, crudeFinancialPaymentBankContract);
                list.Add(crudeFinancialPaymentBankContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentBankContract contract) {
            var data = new CrudeFinancialPaymentBankData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentBankContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentBankData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentBankContract contract) {
            var data = new CrudeFinancialPaymentBankData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentBankContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentBankData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialPaymentBankId) {
            CrudeFinancialPaymentBankData.Delete(financialPaymentBankId);
        }
        
        public static void ContractToData(CrudeFinancialPaymentBankContract contract, CrudeFinancialPaymentBankData data) {
            data.FinancialPaymentBankId = contract.FinancialPaymentBankId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.BankName = contract.BankName;
            data.BankAccount = contract.BankAccount;
            data.BankNumber = contract.BankNumber;
            data.FinancialBankAccountNumberTypeRcd = contract.FinancialBankAccountNumberTypeRcd;
            data.Amount = contract.Amount;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
        }
        
        public static void DataToContract(CrudeFinancialPaymentBankData data, CrudeFinancialPaymentBankContract contract) {
            contract.FinancialPaymentBankId = data.FinancialPaymentBankId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.BankName = data.BankName;
            contract.BankAccount = data.BankAccount;
            contract.BankNumber = data.BankNumber;
            contract.FinancialBankAccountNumberTypeRcd = data.FinancialBankAccountNumberTypeRcd;
            contract.Amount = data.Amount;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
        }
    }
}
