/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:27:09 PM
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
    public partial interface ICrudeFinancialVoucherService {
        
        [OperationContract()]
        CrudeFinancialVoucherContract FetchByFinancialVoucherId(System.Guid financialVoucherId);
        
        [OperationContract()]
        List<CrudeFinancialVoucherContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialVoucherContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialVoucherContract> FetchByFinancialVoucherTypeRcd(string financialVoucherTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialVoucherContract> FetchWithFilter(System.Guid financialVoucherId, System.Guid userId, System.DateTime dateTime, decimal valueAmount, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, System.Guid financialCurrencyId, int voucherNumber, string voucherDescription, string financialVoucherTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialVoucherContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialVoucherContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialVoucherContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialVoucherContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialVoucherContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialVoucherId);
    }
    
    public partial class CrudeFinancialVoucherService : ICrudeFinancialVoucherService {
        
        public CrudeFinancialVoucherContract FetchByFinancialVoucherId(System.Guid financialVoucherId) {
            var dataAccessLayer = new CrudeFinancialVoucherData();
            var contract = new CrudeFinancialVoucherContract();

            dataAccessLayer.FetchByFinancialVoucherId(financialVoucherId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialVoucherContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialVoucherData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialVoucherContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialVoucherData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeFinancialVoucherContract> FetchByFinancialVoucherTypeRcd(string financialVoucherTypeRcd) {
            return DataListToContractList(CrudeFinancialVoucherData.FetchByFinancialVoucherTypeRcd(financialVoucherTypeRcd));
        }
        
        public static List<CrudeFinancialVoucherContract> DataListToContractList(List<CrudeFinancialVoucherData> dataList) {
            var contractList = new List<CrudeFinancialVoucherContract>();

            foreach (CrudeFinancialVoucherData data in dataList) {
                var contract = new CrudeFinancialVoucherContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialVoucherContract> contractList, List<CrudeFinancialVoucherData> dataList) {
            foreach (CrudeFinancialVoucherContract contract in contractList) {
                var data = new CrudeFinancialVoucherData();
                CrudeFinancialVoucherService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialVoucherContract> FetchAll() {
            var list = new List<CrudeFinancialVoucherContract>();
            List<CrudeFinancialVoucherData> dataList = CrudeFinancialVoucherData.FetchAll();

            foreach (CrudeFinancialVoucherData crudeFinancialVoucher in dataList) {
                var contract = new CrudeFinancialVoucherContract();
                DataToContract(crudeFinancialVoucher, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialVoucherContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialVoucherContract>();
            List<CrudeFinancialVoucherData> dataList = CrudeFinancialVoucherData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialVoucherData crudeFinancialVoucher in dataList) {
                var contract = new CrudeFinancialVoucherContract();
                DataToContract(crudeFinancialVoucher, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialVoucherContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialVoucherContract>();
            List<CrudeFinancialVoucherData> dataList = CrudeFinancialVoucherData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialVoucherData crudeFinancialVoucher in dataList) {
                var contract = new CrudeFinancialVoucherContract();
                DataToContract(crudeFinancialVoucher, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialVoucherData.FetchAllCount();
        }
        
        public List<CrudeFinancialVoucherContract> FetchWithFilter(System.Guid financialVoucherId, System.Guid userId, System.DateTime dateTime, decimal valueAmount, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, System.Guid financialCurrencyId, int voucherNumber, string voucherDescription, string financialVoucherTypeRcd) {
            var list = new List<CrudeFinancialVoucherContract>();
            List<CrudeFinancialVoucherData> dataList = CrudeFinancialVoucherData.FetchWithFilter(
                financialVoucherId: financialVoucherId,
                userId: userId,
                dateTime: dateTime,
                valueAmount: valueAmount,
                validFromDateTime: validFromDateTime,
                validUntilDateTime: validUntilDateTime,
                financialCurrencyId: financialCurrencyId,
                voucherNumber: voucherNumber,
                voucherDescription: voucherDescription,
                financialVoucherTypeRcd: financialVoucherTypeRcd
                );

            foreach (CrudeFinancialVoucherData data in dataList) {
                var crudeFinancialVoucherContract = new CrudeFinancialVoucherContract();
                DataToContract(data, crudeFinancialVoucherContract);
                list.Add(crudeFinancialVoucherContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialVoucherContract contract) {
            var data = new CrudeFinancialVoucherData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialVoucherContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialVoucherData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialVoucherContract contract) {
            var data = new CrudeFinancialVoucherData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialVoucherContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialVoucherData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialVoucherId) {
            CrudeFinancialVoucherData.Delete(financialVoucherId);
        }
        
        public static void ContractToData(CrudeFinancialVoucherContract contract, CrudeFinancialVoucherData data) {
            data.FinancialVoucherId = contract.FinancialVoucherId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.ValueAmount = contract.ValueAmount;
            data.ValidFromDateTime = contract.ValidFromDateTime;
            data.ValidUntilDateTime = contract.ValidUntilDateTime;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.VoucherNumber = contract.VoucherNumber;
            data.VoucherDescription = contract.VoucherDescription;
            data.FinancialVoucherTypeRcd = contract.FinancialVoucherTypeRcd;
        }
        
        public static void DataToContract(CrudeFinancialVoucherData data, CrudeFinancialVoucherContract contract) {
            contract.FinancialVoucherId = data.FinancialVoucherId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.ValueAmount = data.ValueAmount;
            contract.ValidFromDateTime = data.ValidFromDateTime;
            contract.ValidUntilDateTime = data.ValidUntilDateTime;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.VoucherNumber = data.VoucherNumber;
            contract.VoucherDescription = data.VoucherDescription;
            contract.FinancialVoucherTypeRcd = data.FinancialVoucherTypeRcd;
        }
    }
}
