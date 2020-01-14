/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:57:41 PM
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
    public partial interface ICrudeFinancialPaymentVoucherService {
        
        [OperationContract()]
        CrudeFinancialPaymentVoucherContract FetchByFinancialPaymentVoucherId(System.Guid financialPaymentVoucherId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentVoucherContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentVoucherContract> FetchByFinancialVoucherId(System.Guid financialVoucherId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentVoucherContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentVoucherContract> FetchWithFilter(System.Guid financialPaymentVoucherId, System.Guid userId, System.DateTime dateTime, System.Guid financialVoucherId, decimal amount, System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentVoucherContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialPaymentVoucherContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialPaymentVoucherContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialPaymentVoucherContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialPaymentVoucherContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialPaymentVoucherId);
    }
    
    public partial class CrudeFinancialPaymentVoucherService : ICrudeFinancialPaymentVoucherService {
        
        public CrudeFinancialPaymentVoucherContract FetchByFinancialPaymentVoucherId(System.Guid financialPaymentVoucherId) {
            var dataAccessLayer = new CrudeFinancialPaymentVoucherData();
            var contract = new CrudeFinancialPaymentVoucherContract();

            dataAccessLayer.FetchByFinancialPaymentVoucherId(financialPaymentVoucherId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialPaymentVoucherContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialPaymentVoucherData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialPaymentVoucherContract> FetchByFinancialVoucherId(System.Guid financialVoucherId) {
            return DataListToContractList(CrudeFinancialPaymentVoucherData.FetchByFinancialVoucherId(financialVoucherId));
        }
        
        public List<CrudeFinancialPaymentVoucherContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialPaymentVoucherData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public static List<CrudeFinancialPaymentVoucherContract> DataListToContractList(List<CrudeFinancialPaymentVoucherData> dataList) {
            var contractList = new List<CrudeFinancialPaymentVoucherContract>();

            foreach (CrudeFinancialPaymentVoucherData data in dataList) {
                var contract = new CrudeFinancialPaymentVoucherContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialPaymentVoucherContract> contractList, List<CrudeFinancialPaymentVoucherData> dataList) {
            foreach (CrudeFinancialPaymentVoucherContract contract in contractList) {
                var data = new CrudeFinancialPaymentVoucherData();
                CrudeFinancialPaymentVoucherService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentVoucherContract> FetchAll() {
            var list = new List<CrudeFinancialPaymentVoucherContract>();
            List<CrudeFinancialPaymentVoucherData> dataList = CrudeFinancialPaymentVoucherData.FetchAll();

            foreach (CrudeFinancialPaymentVoucherData crudeFinancialPaymentVoucher in dataList) {
                var contract = new CrudeFinancialPaymentVoucherContract();
                DataToContract(crudeFinancialPaymentVoucher, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentVoucherContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialPaymentVoucherContract>();
            List<CrudeFinancialPaymentVoucherData> dataList = CrudeFinancialPaymentVoucherData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialPaymentVoucherData crudeFinancialPaymentVoucher in dataList) {
                var contract = new CrudeFinancialPaymentVoucherContract();
                DataToContract(crudeFinancialPaymentVoucher, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentVoucherContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialPaymentVoucherContract>();
            List<CrudeFinancialPaymentVoucherData> dataList = CrudeFinancialPaymentVoucherData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialPaymentVoucherData crudeFinancialPaymentVoucher in dataList) {
                var contract = new CrudeFinancialPaymentVoucherContract();
                DataToContract(crudeFinancialPaymentVoucher, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentVoucherData.FetchAllCount();
        }
        
        public List<CrudeFinancialPaymentVoucherContract> FetchWithFilter(System.Guid financialPaymentVoucherId, System.Guid userId, System.DateTime dateTime, System.Guid financialVoucherId, decimal amount, System.Guid financialCurrencyId) {
            var list = new List<CrudeFinancialPaymentVoucherContract>();
            List<CrudeFinancialPaymentVoucherData> dataList = CrudeFinancialPaymentVoucherData.FetchWithFilter(
                financialPaymentVoucherId: financialPaymentVoucherId,
                userId: userId,
                dateTime: dateTime,
                financialVoucherId: financialVoucherId,
                amount: amount,
                financialCurrencyId: financialCurrencyId
                );

            foreach (CrudeFinancialPaymentVoucherData data in dataList) {
                var crudeFinancialPaymentVoucherContract = new CrudeFinancialPaymentVoucherContract();
                DataToContract(data, crudeFinancialPaymentVoucherContract);
                list.Add(crudeFinancialPaymentVoucherContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentVoucherContract contract) {
            var data = new CrudeFinancialPaymentVoucherData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentVoucherContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentVoucherData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentVoucherContract contract) {
            var data = new CrudeFinancialPaymentVoucherData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentVoucherContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentVoucherData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialPaymentVoucherId) {
            CrudeFinancialPaymentVoucherData.Delete(financialPaymentVoucherId);
        }
        
        public static void ContractToData(CrudeFinancialPaymentVoucherContract contract, CrudeFinancialPaymentVoucherData data) {
            data.FinancialPaymentVoucherId = contract.FinancialPaymentVoucherId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.FinancialVoucherId = contract.FinancialVoucherId;
            data.Amount = contract.Amount;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
        }
        
        public static void DataToContract(CrudeFinancialPaymentVoucherData data, CrudeFinancialPaymentVoucherContract contract) {
            contract.FinancialPaymentVoucherId = data.FinancialPaymentVoucherId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.FinancialVoucherId = data.FinancialVoucherId;
            contract.Amount = data.Amount;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
        }
    }
}
