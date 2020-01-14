/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:18:55 PM
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
    public partial interface ICrudeFinancialPaymentCouponService {
        
        [OperationContract()]
        CrudeFinancialPaymentCouponContract FetchByFinancialPaymentCouponId(System.Guid financialPaymentCouponId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCouponContract> FetchByFinancialCouponId(System.Guid financialCouponId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCouponContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCouponContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCouponContract> FetchWithFilter(System.Guid financialPaymentCouponId, System.Guid financialCouponId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCouponContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialPaymentCouponContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialPaymentCouponContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialPaymentCouponContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialPaymentCouponContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialPaymentCouponId);
    }
    
    public partial class CrudeFinancialPaymentCouponService : ICrudeFinancialPaymentCouponService {
        
        public CrudeFinancialPaymentCouponContract FetchByFinancialPaymentCouponId(System.Guid financialPaymentCouponId) {
            var dataAccessLayer = new CrudeFinancialPaymentCouponData();
            var contract = new CrudeFinancialPaymentCouponContract();

            dataAccessLayer.FetchByFinancialPaymentCouponId(financialPaymentCouponId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialPaymentCouponContract> FetchByFinancialCouponId(System.Guid financialCouponId) {
            return DataListToContractList(CrudeFinancialPaymentCouponData.FetchByFinancialCouponId(financialCouponId));
        }
        
        public List<CrudeFinancialPaymentCouponContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialPaymentCouponData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialPaymentCouponContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialPaymentCouponData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public static List<CrudeFinancialPaymentCouponContract> DataListToContractList(List<CrudeFinancialPaymentCouponData> dataList) {
            var contractList = new List<CrudeFinancialPaymentCouponContract>();

            foreach (CrudeFinancialPaymentCouponData data in dataList) {
                var contract = new CrudeFinancialPaymentCouponContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialPaymentCouponContract> contractList, List<CrudeFinancialPaymentCouponData> dataList) {
            foreach (CrudeFinancialPaymentCouponContract contract in contractList) {
                var data = new CrudeFinancialPaymentCouponData();
                CrudeFinancialPaymentCouponService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialPaymentCouponContract> FetchAll() {
            var list = new List<CrudeFinancialPaymentCouponContract>();
            List<CrudeFinancialPaymentCouponData> dataList = CrudeFinancialPaymentCouponData.FetchAll();

            foreach (CrudeFinancialPaymentCouponData crudeFinancialPaymentCoupon in dataList) {
                var contract = new CrudeFinancialPaymentCouponContract();
                DataToContract(crudeFinancialPaymentCoupon, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentCouponContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialPaymentCouponContract>();
            List<CrudeFinancialPaymentCouponData> dataList = CrudeFinancialPaymentCouponData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialPaymentCouponData crudeFinancialPaymentCoupon in dataList) {
                var contract = new CrudeFinancialPaymentCouponContract();
                DataToContract(crudeFinancialPaymentCoupon, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialPaymentCouponContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialPaymentCouponContract>();
            List<CrudeFinancialPaymentCouponData> dataList = CrudeFinancialPaymentCouponData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialPaymentCouponData crudeFinancialPaymentCoupon in dataList) {
                var contract = new CrudeFinancialPaymentCouponContract();
                DataToContract(crudeFinancialPaymentCoupon, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialPaymentCouponData.FetchAllCount();
        }
        
        public List<CrudeFinancialPaymentCouponContract> FetchWithFilter(System.Guid financialPaymentCouponId, System.Guid financialCouponId, System.Guid userId, System.DateTime dateTime, decimal amount, System.Guid financialCurrencyId) {
            var list = new List<CrudeFinancialPaymentCouponContract>();
            List<CrudeFinancialPaymentCouponData> dataList = CrudeFinancialPaymentCouponData.FetchWithFilter(
                financialPaymentCouponId: financialPaymentCouponId,
                financialCouponId: financialCouponId,
                userId: userId,
                dateTime: dateTime,
                amount: amount,
                financialCurrencyId: financialCurrencyId
                );

            foreach (CrudeFinancialPaymentCouponData data in dataList) {
                var crudeFinancialPaymentCouponContract = new CrudeFinancialPaymentCouponContract();
                DataToContract(data, crudeFinancialPaymentCouponContract);
                list.Add(crudeFinancialPaymentCouponContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialPaymentCouponContract contract) {
            var data = new CrudeFinancialPaymentCouponData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialPaymentCouponContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCouponData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialPaymentCouponContract contract) {
            var data = new CrudeFinancialPaymentCouponData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialPaymentCouponContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialPaymentCouponData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialPaymentCouponId) {
            CrudeFinancialPaymentCouponData.Delete(financialPaymentCouponId);
        }
        
        public static void ContractToData(CrudeFinancialPaymentCouponContract contract, CrudeFinancialPaymentCouponData data) {
            data.FinancialPaymentCouponId = contract.FinancialPaymentCouponId;
            data.FinancialCouponId = contract.FinancialCouponId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.Amount = contract.Amount;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
        }
        
        public static void DataToContract(CrudeFinancialPaymentCouponData data, CrudeFinancialPaymentCouponContract contract) {
            contract.FinancialPaymentCouponId = data.FinancialPaymentCouponId;
            contract.FinancialCouponId = data.FinancialCouponId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.Amount = data.Amount;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
        }
    }
}
