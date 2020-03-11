/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:56:33 PM
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
    public partial interface ICrudeFinancialPaymentService {
        
        [OperationContract()]
        CrudeFinancialPaymentContract FetchByFinancialPaymentId(System.Guid financialPaymentId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentContract> FetchByFinancialPaymentAccountingId(System.Guid financialPaymentAccountingId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentContract> FetchByFinancialPaymentBankId(System.Guid financialPaymentBankId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentContract> FetchByFinancialPaymentVoucherId(System.Guid financialPaymentVoucherId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentContract> FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentContract> FetchByFinancialPaymentCashId(System.Guid financialPaymentCashId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentContract> FetchByFinancialPaymentCouponId(System.Guid financialPaymentCouponId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentContract> FetchByFinancialPaymentTypeRcd(string financialPaymentTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialPaymentContract> FetchWithFilter(System.Guid financialPaymentId, string financialPaymentTypeRcd, System.Guid userId, System.DateTime dateTime, System.Guid financialPaymentAccountingId, System.Guid financialPaymentBankId, System.Guid financialPaymentVoucherId, System.Guid financialPaymentCardId, System.Guid financialPaymentCashId, System.Guid financialPaymentCouponId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialPaymentContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialPaymentContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialPaymentContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialPaymentContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialPaymentId);
    }
    
    public partial class CrudeFinancialPaymentService : ICrudeFinancialPaymentService {
        
        public CrudeFinancialPaymentContract FetchByFinancialPaymentId(System.Guid financialPaymentId) {
            var dataAccessLayer = new CrudeFinancialPaymentData();
            var contract = new CrudeFinancialPaymentContract();

            dataAccessLayer.FetchByFinancialPaymentId(financialPaymentId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialPaymentContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialPaymentData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialPaymentContract> FetchByFinancialPaymentAccountingId(System.Guid financialPaymentAccountingId) {
            return DataListToContractList(CrudeFinancialPaymentData.FetchByFinancialPaymentAccountingId(financialPaymentAccountingId));
        }
        
        public List<CrudeFinancialPaymentContract> FetchByFinancialPaymentBankId(System.Guid financialPaymentBankId) {
            return DataListToContractList(CrudeFinancialPaymentData.FetchByFinancialPaymentBankId(financialPaymentBankId));
        }
        
        public List<CrudeFinancialPaymentContract> FetchByFinancialPaymentVoucherId(System.Guid financialPaymentVoucherId) {
            return DataListToContractList(CrudeFinancialPaymentData.FetchByFinancialPaymentVoucherId(financialPaymentVoucherId));
        }
        
        public List<CrudeFinancialPaymentContract> FetchByFinancialPaymentCardId(System.Guid financialPaymentCardId) {
            return DataListToContractList(CrudeFinancialPaymentData.FetchByFinancialPaymentCardId(financialPaymentCardId));
        }
        
        public List<CrudeFinancialPaymentContract> FetchByFinancialPaymentCashId(System.Guid financialPaymentCashId) {
            return DataListToContractList(CrudeFinancialPaymentData.FetchByFinancialPaymentCashId(financialPaymentCashId));
        }
        
        public List<CrudeFinancialPaymentContract> FetchByFinancialPaymentCouponId(System.Guid financialPaymentCouponId) {
            return DataListToContractList(CrudeFinancialPaymentData.FetchByFinancialPaymentCouponId(financialPaymentCouponId));
        }
        
        public List<CrudeFinancialPaymentContract> FetchByFinancialPaymentTypeRcd(string financialPaymentTypeRcd) {
            return DataListToContractList(CrudeFinancialPaymentData.FetchByFinancialPaymentTypeRcd(financialPaymentTypeRcd));
        }
        
        public static List<CrudeFinancialPaymentContract> DataListToContractList(List<CrudeFinancialPaymentData> dataList) {
            var contractList = new List<CrudeFinancialPaymentContract>();

            foreach (CrudeFinancialPaymentData data in dataList) {
                var contract = new CrudeFinancialPaymentContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialPaymentContract> contractList, List<CrudeFinancialPaymentData> dataList) {
            foreach (CrudeFinancialPaymentContract contract in contractList) {
                var data = new CrudeFinancialPaymentData();
                CrudeFinancialPaymentService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentContract> FetchAll() {
            var list = new List<CrudeFinancialPaymentContract>();
            List<CrudeFinancialPaymentData> dataList = CrudeFinancialPaymentData.FetchAll();

            foreach (CrudeFinancialPaymentData crudeFinancialPayment in dataList) {
                var contract = new CrudeFinancialPaymentContract();
                DataToContract(crudeFinancialPayment, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialPaymentContract>();
            List<CrudeFinancialPaymentData> dataList = CrudeFinancialPaymentData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialPaymentData crudeFinancialPayment in dataList) {
                var contract = new CrudeFinancialPaymentContract();
                DataToContract(crudeFinancialPayment, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialPaymentContract>();
            List<CrudeFinancialPaymentData> dataList = CrudeFinancialPaymentData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialPaymentData crudeFinancialPayment in dataList) {
                var contract = new CrudeFinancialPaymentContract();
                DataToContract(crudeFinancialPayment, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentData.FetchAllCount();
        }
        
        public List<CrudeFinancialPaymentContract> FetchWithFilter(System.Guid financialPaymentId, string financialPaymentTypeRcd, System.Guid userId, System.DateTime dateTime, System.Guid financialPaymentAccountingId, System.Guid financialPaymentBankId, System.Guid financialPaymentVoucherId, System.Guid financialPaymentCardId, System.Guid financialPaymentCashId, System.Guid financialPaymentCouponId) {
            var list = new List<CrudeFinancialPaymentContract>();
            List<CrudeFinancialPaymentData> dataList = CrudeFinancialPaymentData.FetchWithFilter(
                financialPaymentId: financialPaymentId,
                financialPaymentTypeRcd: financialPaymentTypeRcd,
                userId: userId,
                dateTime: dateTime,
                financialPaymentAccountingId: financialPaymentAccountingId,
                financialPaymentBankId: financialPaymentBankId,
                financialPaymentVoucherId: financialPaymentVoucherId,
                financialPaymentCardId: financialPaymentCardId,
                financialPaymentCashId: financialPaymentCashId,
                financialPaymentCouponId: financialPaymentCouponId
                );

            foreach (CrudeFinancialPaymentData data in dataList) {
                var crudeFinancialPaymentContract = new CrudeFinancialPaymentContract();
                DataToContract(data, crudeFinancialPaymentContract);
                list.Add(crudeFinancialPaymentContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentContract contract) {
            var data = new CrudeFinancialPaymentData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentContract contract) {
            var data = new CrudeFinancialPaymentData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialPaymentId) {
            CrudeFinancialPaymentData.Delete(financialPaymentId);
        }
        
        public static void ContractToData(CrudeFinancialPaymentContract contract, CrudeFinancialPaymentData data) {
            data.FinancialPaymentId = contract.FinancialPaymentId;
            data.FinancialPaymentTypeRcd = contract.FinancialPaymentTypeRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.FinancialPaymentAccountingId = contract.FinancialPaymentAccountingId;
            data.FinancialPaymentBankId = contract.FinancialPaymentBankId;
            data.FinancialPaymentVoucherId = contract.FinancialPaymentVoucherId;
            data.FinancialPaymentCardId = contract.FinancialPaymentCardId;
            data.FinancialPaymentCashId = contract.FinancialPaymentCashId;
            data.FinancialPaymentCouponId = contract.FinancialPaymentCouponId;
        }
        
        public static void DataToContract(CrudeFinancialPaymentData data, CrudeFinancialPaymentContract contract) {
            contract.FinancialPaymentId = data.FinancialPaymentId;
            contract.FinancialPaymentTypeRcd = data.FinancialPaymentTypeRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.FinancialPaymentAccountingId = data.FinancialPaymentAccountingId;
            contract.FinancialPaymentBankId = data.FinancialPaymentBankId;
            contract.FinancialPaymentVoucherId = data.FinancialPaymentVoucherId;
            contract.FinancialPaymentCardId = data.FinancialPaymentCardId;
            contract.FinancialPaymentCashId = data.FinancialPaymentCashId;
            contract.FinancialPaymentCouponId = data.FinancialPaymentCouponId;
        }
    }
}
